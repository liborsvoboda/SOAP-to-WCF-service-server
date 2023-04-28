Option Strict Off
Option Explicit On

Imports System.Threading.Tasks
Imports System.Web.Configuration
Imports System.Web.Services.Protocols
Imports AppWSDL.CourierDeliveryManagementSoapPortTypeService
Imports AppWSDL.courierDeliveryStatusService
Imports AppWSDL.CourierServiceWriteService
Imports AppWSDL.GoodsMovementService
Imports AppWSDL.MaterialCreateChange
Imports AppWSDL.SendDeliveryDocument
Imports AppWSDL.SendPostingToDeliveries
Imports AppWSDL.StockRequestService
Imports AppWSDL.WMSDeliveryManagementService
Imports MySql.Data.MySqlClient


Public Class ServiceWSDL
    Implements ImaterialCreateChange, ISendDeliveryDocument, IGoodsMovementService, ISendPostingToDeliveries,
        IStockRequestService, IStockRequestConsumerService, ICourierDeliveryManagementSoapPortTypeService, IcourierDeliveryStatusService, ICourierServiceWriteService,
        IWMSDeliveryManagementService

    Friend Shared setting_folder As String = AppDomain.CurrentDomain.BaseDirectory
    Friend Shared logFile As String = "Service.log"

    Public Function createOrChangeMaterial(request As createOrChangeMaterialRequest) As createOrChangeMaterialResponse Implements ImaterialCreateChange.createOrChangeMaterial
        If request.data Is Nothing Then Throw New SoapException("no data", SoapException.ServerFaultCode)

        Dim conStrMysql = New MySqlConnection()
        conStrMysql.ConnectionString = WebConfigurationManager.ConnectionStrings("SHARPCONN").ConnectionString

        Dim columnsQuery = "", valuesQuery = ""
        Dim DTEmpDet = New DataSet()
        Dim arrParameters As New List(Of MySqlParameter)
        Dim selectedTable = "ciselnik_materialu"

        Try
            'header
            DTEmpDet = MySqlHelper.ExecuteDataset(conStrMysql, String.Format("select db_nazev,wsdl_nazev from ciselnik_preklad_sloupcu where tabulka='" + selectedTable + "_h' and exportovat = 1"))
            DTEmpDet.Tables(0).TableName = selectedTable

            If Not String.IsNullOrWhiteSpace(DTEmpDet.ToString) Then
                For Each dtRow As DataRow In DTEmpDet.Tables(0).Rows

                    columnsQuery += If((columnsQuery.Length > 0), ",", "")
                    columnsQuery += "`" + dtRow.ItemArray(0).ToString() + "`"
                    valuesQuery += If((valuesQuery.Length > 0), ",", "")
                    valuesQuery += "@" + dtRow.ItemArray(0).ToString()
                    arrParameters = fnCallByName_createOrChangeMaterialRequest(selectedTable + "_h", request, dtRow.ItemArray(1).ToString(), dtRow.ItemArray(0).ToString(), arrParameters)
                Next
            End If

            Try
                conStrMysql.Open()
                columnsQuery += ",`UZIVATEL`,`DATUM_CAS`"
                valuesQuery += ",@UZIVATEL,@DATUM_CAS"
                arrParameters.Add(New MySqlParameter("UZIVATEL", 1))
                arrParameters.Add(New MySqlParameter("DATUM_CAS", DateTime.UtcNow))
                MySqlHelper.ExecuteReader(conStrMysql, String.Format("START TRANSACTION;INSERT INTO `" + selectedTable + "_h` (" + columnsQuery + ") VALUES (" + valuesQuery + ");COMMIT;"), arrParameters.ToArray())
                conStrMysql.Close()
            Catch ex As Exception
                conStrMysql.Close()
                Throw New SoapException(ex.Message, SoapException.ServerFaultCode)
            End Try

            Return New createOrChangeMaterialResponse()
        Catch ex As Exception
            conStrMysql.Close()
            Throw New SoapException(ex.Message, SoapException.ServerFaultCode)
        End Try
        'Return data
    End Function


    Public Function sendDeliveryDocument(request As sendDeliveryDocumentRequest) As sendDeliveryDocumentResponse Implements ISendDeliveryDocument.sendDeliveryDocument
        If request.data Is Nothing Then Throw New SoapException("no data", SoapException.ServerFaultCode)

        Dim conStrMysql = New MySqlConnection()
        conStrMysql.ConnectionString = WebConfigurationManager.ConnectionStrings("SHARPCONN").ConnectionString

        Dim columnsQuery = "", valuesQuery = ""
        Dim DTEmpDet = New DataSet()
        Dim arrParameters As New List(Of MySqlParameter)
        Dim selectedTable = ""

        Try

            Select Case CallByName(request.data.ZSCMT19C_DELVRY07.IDOC.E1EDL20(0).E1EDL21, "LFART", CallType.Get)
                Case "EL" 'inbound delivery 
                    selectedTable = "inbound_delivery"
                Case "LF"
                    selectedTable = "outbound_delivery"
                Case "ZRLL"
                    selectedTable = "delivery_document"
                Case Else
            End Select

            'header
            DTEmpDet = MySqlHelper.ExecuteDataset(conStrMysql, String.Format("select db_nazev,wsdl_nazev from ciselnik_preklad_sloupcu where tabulka='" + selectedTable + "_h' and exportovat = 1"))
            DTEmpDet.Tables(0).TableName = selectedTable

            If Not String.IsNullOrWhiteSpace(DTEmpDet.ToString) Then
                For Each dtRow As DataRow In DTEmpDet.Tables(0).Rows

                    columnsQuery += If((columnsQuery.Length > 0), ",", "")
                    columnsQuery += "`" + dtRow.ItemArray(0).ToString() + "`"
                    valuesQuery += If((valuesQuery.Length > 0), ",", "")
                    valuesQuery += "@" + dtRow.ItemArray(0).ToString()
                    arrParameters = fnCallByName_sendDeliveryDocumentRequest(selectedTable + "_h", request, dtRow.ItemArray(1).ToString(), dtRow.ItemArray(0).ToString(), arrParameters)
                Next
            End If

            Try
                conStrMysql.Open()
                columnsQuery += ",`UZIVATEL`,`DATUM_CAS`"
                valuesQuery += ",@UZIVATEL,@DATUM_CAS"
                arrParameters.Add(New MySqlParameter("UZIVATEL", 1))
                arrParameters.Add(New MySqlParameter("DATUM_CAS", DateTime.UtcNow))
                MySqlHelper.ExecuteReader(conStrMysql, String.Format("START TRANSACTION;INSERT INTO `" + selectedTable + "_h` (" + columnsQuery + ") VALUES (" + valuesQuery + ");COMMIT;"), arrParameters.ToArray())
                conStrMysql.Close()
            Catch ex As Exception
                conStrMysql.Close()
                Throw New SoapException(ex.Message, SoapException.ServerFaultCode)
            End Try


            'item
            columnsQuery = ""
            valuesQuery = ""
            DTEmpDet.Clear()
            arrParameters.Clear()

            DTEmpDet = MySqlHelper.ExecuteDataset(conStrMysql, String.Format("select db_nazev,wsdl_nazev from ciselnik_preklad_sloupcu where tabulka='" + selectedTable + "_i' and exportovat = 1"))
            DTEmpDet.Tables(0).TableName = selectedTable

            If Not String.IsNullOrWhiteSpace(DTEmpDet.ToString) Then
                For Each dtRow As DataRow In DTEmpDet.Tables(0).Rows

                    columnsQuery += If((columnsQuery.Length > 0), ",", "")
                    columnsQuery += "`" + dtRow.ItemArray(0).ToString() + "`"
                    valuesQuery += If((valuesQuery.Length > 0), ",", "")
                    valuesQuery += "@" + dtRow.ItemArray(0).ToString()
                    arrParameters = fnCallByName_sendDeliveryDocumentRequest(selectedTable + "_i", request, dtRow.ItemArray(1).ToString(), dtRow.ItemArray(0).ToString(), arrParameters)
                Next
            End If

            Try
                conStrMysql.Open()
                MySqlHelper.ExecuteReader(conStrMysql, String.Format("START TRANSACTION;INSERT INTO `" + selectedTable + "_i` (" + columnsQuery + ") VALUES (" + valuesQuery + ");COMMIT;"), arrParameters.ToArray())
                conStrMysql.Close()
            Catch ex As Exception
                conStrMysql.Close()
                Throw New SoapException(ex.Message, SoapException.ServerFaultCode)
            End Try

            Return New sendDeliveryDocumentResponse()
        Catch ex As Exception
            conStrMysql.Close()
            Throw New SoapException(ex.Message, SoapException.ServerFaultCode)
        End Try
        'Return data
    End Function

    Public Function sendGoodsMovement(request As sendGoodsMovementRequest) As sendGoodsMovementResponse Implements IGoodsMovementService.sendGoodsMovement
        If request.data Is Nothing Then Throw New SoapException("no data", SoapException.ServerFaultCode)

        Dim conStrMysql = New MySqlConnection()
        conStrMysql.ConnectionString = WebConfigurationManager.ConnectionStrings("SHARPCONN").ConnectionString

        Dim columnsQuery = "", valuesQuery = ""
        Dim DTEmpDet = New DataSet()
        Dim arrParameters As New List(Of MySqlParameter)
        Dim selectedTable = "goods_movement"

        Try

            'header
            DTEmpDet = MySqlHelper.ExecuteDataset(conStrMysql, String.Format("select db_nazev,wsdl_nazev from ciselnik_preklad_sloupcu where tabulka='" + selectedTable + "_h' and exportovat = 1"))
            DTEmpDet.Tables(0).TableName = selectedTable

            If Not String.IsNullOrWhiteSpace(DTEmpDet.ToString) Then
                For Each dtRow As DataRow In DTEmpDet.Tables(0).Rows

                    columnsQuery += If((columnsQuery.Length > 0), ",", "")
                    columnsQuery += "`" + dtRow.ItemArray(0).ToString() + "`"
                    valuesQuery += If((valuesQuery.Length > 0), ",", "")
                    valuesQuery += "@" + dtRow.ItemArray(0).ToString()
                    arrParameters = fnCallByName_sendGoodsMovementRequest(selectedTable + "_h", request, dtRow.ItemArray(1).ToString(), dtRow.ItemArray(0).ToString(), arrParameters)
                Next
            End If

            Try
                conStrMysql.Open()
                columnsQuery += ",`UZIVATEL`,`DATUM_CAS`"
                valuesQuery += ",@UZIVATEL,@DATUM_CAS"
                arrParameters.Add(New MySqlParameter("UZIVATEL", 1))
                arrParameters.Add(New MySqlParameter("DATUM_CAS", DateTime.UtcNow))
                MySqlHelper.ExecuteReader(conStrMysql, String.Format("START TRANSACTION;INSERT INTO `" + selectedTable + "_h` (" + columnsQuery + ") VALUES (" + valuesQuery + ");COMMIT;"), arrParameters.ToArray())
                conStrMysql.Close()
            Catch ex As Exception
                conStrMysql.Close()
                Throw New SoapException(ex.Message, SoapException.ServerFaultCode)
            End Try


            'item
            columnsQuery = ""
            valuesQuery = ""
            DTEmpDet.Clear()
            arrParameters.Clear()

            DTEmpDet = MySqlHelper.ExecuteDataset(conStrMysql, String.Format("select db_nazev,wsdl_nazev from ciselnik_preklad_sloupcu where tabulka='" + selectedTable + "_i' and exportovat = 1"))
            DTEmpDet.Tables(0).TableName = selectedTable

            If Not String.IsNullOrWhiteSpace(DTEmpDet.ToString) Then
                For Each dtRow As DataRow In DTEmpDet.Tables(0).Rows

                    columnsQuery += If((columnsQuery.Length > 0), ",", "")
                    columnsQuery += "`" + dtRow.ItemArray(0).ToString() + "`"
                    valuesQuery += If((valuesQuery.Length > 0), ",", "")
                    valuesQuery += "@" + dtRow.ItemArray(0).ToString()
                    arrParameters = fnCallByName_sendGoodsMovementRequest(selectedTable + "_i", request, dtRow.ItemArray(1).ToString(), dtRow.ItemArray(0).ToString(), arrParameters)
                Next
            End If

            Try
                conStrMysql.Open()
                MySqlHelper.ExecuteReader(conStrMysql, String.Format("START TRANSACTION;INSERT INTO `" + selectedTable + "_i` (" + columnsQuery + ") VALUES (" + valuesQuery + ");COMMIT;"), arrParameters.ToArray())
                conStrMysql.Close()
            Catch ex As Exception
                conStrMysql.Close()
                Throw New SoapException(ex.Message, SoapException.ServerFaultCode)
            End Try

            Return New sendGoodsMovementResponse()
        Catch ex As Exception
            conStrMysql.Close()
            Throw New SoapException(ex.Message, SoapException.ServerFaultCode)
        End Try
        'Return data
    End Function


    Public Function sendPostingToDeliveries(request As sendPostingToDeliveriesRequest) As sendPostingToDeliveriesResponse Implements ISendPostingToDeliveries.sendPostingToDeliveries
        If request.data Is Nothing Then Throw New SoapException("no data", SoapException.ServerFaultCode)

        Dim conStrMysql = New MySqlConnection()
        conStrMysql.ConnectionString = WebConfigurationManager.ConnectionStrings("SHARPCONN").ConnectionString

        Dim columnsQuery = "", valuesQuery = ""
        Dim DTEmpDet = New DataSet()
        Dim arrParameters As New List(Of MySqlParameter)
        Dim selectedTable = "goods_issue_receive"

        Try

            'header
            DTEmpDet = MySqlHelper.ExecuteDataset(conStrMysql, String.Format("select db_nazev,wsdl_nazev from ciselnik_preklad_sloupcu where tabulka='" + selectedTable + "_h' and exportovat = 1"))
            DTEmpDet.Tables(0).TableName = selectedTable

            If Not String.IsNullOrWhiteSpace(DTEmpDet.ToString) Then
                For Each dtRow As DataRow In DTEmpDet.Tables(0).Rows

                    columnsQuery += If((columnsQuery.Length > 0), ",", "")
                    columnsQuery += "`" + dtRow.ItemArray(0).ToString() + "`"
                    valuesQuery += If((valuesQuery.Length > 0), ",", "")
                    valuesQuery += "@" + dtRow.ItemArray(0).ToString()
                    arrParameters = fnCallByName_sendPostingToDeliveriesRequest(selectedTable + "_h", request, dtRow.ItemArray(1).ToString(), dtRow.ItemArray(0).ToString(), arrParameters)
                Next
            End If

            Try
                conStrMysql.Open()
                columnsQuery += ",`UZIVATEL`,`DATUM_CAS`"
                valuesQuery += ",@UZIVATEL,@DATUM_CAS"
                arrParameters.Add(New MySqlParameter("UZIVATEL", 1))
                arrParameters.Add(New MySqlParameter("DATUM_CAS", DateTime.UtcNow))
                MySqlHelper.ExecuteReader(conStrMysql, String.Format("START TRANSACTION;INSERT INTO `" + selectedTable + "_h` (" + columnsQuery + ") VALUES (" + valuesQuery + ");COMMIT;"), arrParameters.ToArray())
                conStrMysql.Close()
            Catch ex As Exception
                conStrMysql.Close()
                Throw New SoapException(ex.Message, SoapException.ServerFaultCode)
            End Try


            'item
            columnsQuery = ""
            valuesQuery = ""
            DTEmpDet.Clear()
            arrParameters.Clear()

            DTEmpDet = MySqlHelper.ExecuteDataset(conStrMysql, String.Format("select db_nazev,wsdl_nazev from ciselnik_preklad_sloupcu where tabulka='" + selectedTable + "_i' and exportovat = 1"))
            DTEmpDet.Tables(0).TableName = selectedTable

            If Not String.IsNullOrWhiteSpace(DTEmpDet.ToString) Then
                For Each dtRow As DataRow In DTEmpDet.Tables(0).Rows

                    columnsQuery += If((columnsQuery.Length > 0), ",", "")
                    columnsQuery += "`" + dtRow.ItemArray(0).ToString() + "`"
                    valuesQuery += If((valuesQuery.Length > 0), ",", "")
                    valuesQuery += "@" + dtRow.ItemArray(0).ToString()
                    arrParameters = fnCallByName_sendPostingToDeliveriesRequest(selectedTable + "_i", request, dtRow.ItemArray(1).ToString(), dtRow.ItemArray(0).ToString(), arrParameters)
                Next
            End If

            Try
                conStrMysql.Open()
                MySqlHelper.ExecuteReader(conStrMysql, String.Format("START TRANSACTION;INSERT INTO `" + selectedTable + "_i` (" + columnsQuery + ") VALUES (" + valuesQuery + ");COMMIT;"), arrParameters.ToArray())
                conStrMysql.Close()
            Catch ex As Exception
                conStrMysql.Close()
                Throw New SoapException(ex.Message, SoapException.ServerFaultCode)
            End Try

            Return New sendPostingToDeliveriesResponse()
        Catch ex As Exception
            conStrMysql.Close()
            Throw New SoapException(ex.Message, SoapException.ServerFaultCode)
        End Try
        'Return data
    End Function


    Private Function stockRequest(request As stockRequest) As stockRequestResponse Implements IStockRequestService.stockRequest
        If request.data Is Nothing Then Throw New SoapException("no data", SoapException.ServerFaultCode)

        Dim conStrMysql = New MySqlConnection()
        conStrMysql.ConnectionString = WebConfigurationManager.ConnectionStrings("SHARPCONN").ConnectionString

        Dim columnsQuery = "", valuesQuery = ""
        Dim DTEmpDet = New DataSet()
        Dim arrParameters As New List(Of MySqlParameter)
        Dim selectedTable = "stock_request"
        Dim insertedHeaderId As ULong

        Try

            'header
            DTEmpDet = MySqlHelper.ExecuteDataset(conStrMysql, String.Format("select db_nazev,wsdl_nazev from ciselnik_preklad_sloupcu where tabulka='" + selectedTable + "_h' and exportovat = 1"))
            DTEmpDet.Tables(0).TableName = selectedTable

            If Not String.IsNullOrWhiteSpace(DTEmpDet.ToString) Then
                For Each dtRow As DataRow In DTEmpDet.Tables(0).Rows

                    columnsQuery += If((columnsQuery.Length > 0), ",", "")
                    columnsQuery += "`" + dtRow.ItemArray(0).ToString() + "`"
                    valuesQuery += If((valuesQuery.Length > 0), ",", "")
                    valuesQuery += "@" + dtRow.ItemArray(0).ToString()
                    arrParameters = fnCallByName_StockRequest(selectedTable + "_h", request, dtRow.ItemArray(1).ToString(), dtRow.ItemArray(0).ToString(), 0, arrParameters)
                Next
            End If

            Try
                conStrMysql.Open()
                columnsQuery += ",`UZIVATEL`,`DATUM_CAS`"
                valuesQuery += ",@UZIVATEL,@DATUM_CAS"
                arrParameters.Add(New MySqlParameter("UZIVATEL", 1))
                arrParameters.Add(New MySqlParameter("DATUM_CAS", DateTime.UtcNow))
                Dim Reader As IDataReader = MySqlHelper.ExecuteReader(conStrMysql, String.Format("START TRANSACTION;INSERT INTO `" + selectedTable + "_h` (" + columnsQuery + ") VALUES (" + valuesQuery + ");SELECT LAST_INSERT_ID();COMMIT;"), arrParameters.ToArray())
                Reader.Read()
                insertedHeaderId = Reader.Item(0)
                conStrMysql.Close()

            Catch ex As Exception
                conStrMysql.Close()
                Throw New SoapException(ex.Message, SoapException.ServerFaultCode)
            End Try

            'item
            DTEmpDet.Clear()

            DTEmpDet = MySqlHelper.ExecuteDataset(conStrMysql, String.Format("select db_nazev,wsdl_nazev from ciselnik_preklad_sloupcu where tabulka='" + selectedTable + "_i' and exportovat = 1"))
            DTEmpDet.Tables(0).TableName = selectedTable

            For itemNo = 0 To request.data.ToArray.Count - 1
                columnsQuery = ""
                valuesQuery = ""
                arrParameters.Clear()

                If Not String.IsNullOrWhiteSpace(DTEmpDet.ToString) Then
                    For Each dtRow As DataRow In DTEmpDet.Tables(0).Rows

                        columnsQuery += If((columnsQuery.Length > 0), ",", "")
                        columnsQuery += "`" + dtRow.ItemArray(0).ToString() + "`"
                        valuesQuery += If((valuesQuery.Length > 0), ",", "")
                        valuesQuery += "@" + dtRow.ItemArray(0).ToString()
                        arrParameters = fnCallByName_StockRequest(selectedTable + "_i", request, dtRow.ItemArray(1).ToString(), dtRow.ItemArray(0).ToString(), itemNo, arrParameters)
                    Next
                End If

                Try
                    conStrMysql.Open()
                    MySqlHelper.ExecuteReader(conStrMysql, String.Format("START TRANSACTION;INSERT INTO `" + selectedTable + "_i` (`H_ID`," + columnsQuery + ") VALUES (" + insertedHeaderId.ToString() + "," + valuesQuery + ");COMMIT;"), arrParameters.ToArray())
                    conStrMysql.Close()
                Catch ex As Exception
                    conStrMysql.Close()
                    Throw New SoapException(ex.Message, SoapException.ServerFaultCode)
                End Try
            Next
            Return New stockRequestResponse()
        Catch ex As Exception
            Throw New SoapException(ex.Message, SoapException.ServerFaultCode)
        End Try
    End Function

    'Public Async Function stockRequestAsync(request As stockRequest) As Task(Of stockRequestResponse) Implements IStockRequestService.stockRequestAsync
    '    If request.data Is Nothing Then Throw New SoapException("no data", SoapException.ServerFaultCode)

    '    Dim conStrMysql = New MySqlConnection()
    '    conStrMysql.ConnectionString = WebConfigurationManager.ConnectionStrings("SHARPCONN").ConnectionString

    '    Dim columnsQuery = "", valuesQuery = ""
    '    Dim DTEmpDet = New DataSet()
    '    Dim arrParameters As New List(Of MySqlParameter)
    '    Dim selectedTable = "stock_request"
    '    Dim insertedHeaderId As ULong
    '    Try

    '        'header
    '        DTEmpDet = MySqlHelper.ExecuteDataset(conStrMysql, String.Format("select db_nazev,wsdl_nazev from ciselnik_preklad_sloupcu where tabulka='" + selectedTable + "_h' and exportovat = 1"))
    '        DTEmpDet.Tables(0).TableName = selectedTable

    '        If Not String.IsNullOrWhiteSpace(DTEmpDet.ToString) Then
    '            For Each dtRow As DataRow In DTEmpDet.Tables(0).Rows

    '                columnsQuery += If((columnsQuery.Length > 0), ",", "")
    '                columnsQuery += "`" + dtRow.ItemArray(0).ToString() + "`"
    '                valuesQuery += If((valuesQuery.Length > 0), ",", "")
    '                valuesQuery += "@" + dtRow.ItemArray(0).ToString()
    '                arrParameters = fnCallByName_StockRequest(selectedTable + "_h", request, dtRow.ItemArray(1).ToString(), dtRow.ItemArray(0).ToString(), 0, arrParameters)
    '            Next
    '        End If

    '        Try
    '            conStrMysql.Open()
    '            columnsQuery += ",`UZIVATEL`,`DATUM_CAS`"
    '            valuesQuery += ",@UZIVATEL,@DATUM_CAS"
    '            arrParameters.Add(New MySqlParameter("UZIVATEL", 1))
    '            arrParameters.Add(New MySqlParameter("DATUM_CAS", DateTime.UtcNow))
    '            Dim Reader As IDataReader = MySqlHelper.ExecuteReader(conStrMysql, String.Format("START TRANSACTION;INSERT INTO `" + selectedTable + "_h` (" + columnsQuery + ") VALUES (" + valuesQuery + ");SELECT LAST_INSERT_ID();COMMIT;"), arrParameters.ToArray())
    '            Reader.Read()
    '            insertedHeaderId = Reader.Item(0)
    '            conStrMysql.Close()

    '        Catch ex As Exception
    '            conStrMysql.Close()
    '            Throw New SoapException(ex.Message, SoapException.ServerFaultCode)
    '        End Try

    '        'item
    '        DTEmpDet.Clear()

    '        DTEmpDet = MySqlHelper.ExecuteDataset(conStrMysql, String.Format("select db_nazev,wsdl_nazev from ciselnik_preklad_sloupcu where tabulka='" + selectedTable + "_i' and exportovat = 1"))
    '        DTEmpDet.Tables(0).TableName = selectedTable

    '        For itemNo = 0 To request.data.ToArray.Count - 1
    '            columnsQuery = ""
    '            valuesQuery = ""
    '            arrParameters.Clear()

    '            If Not String.IsNullOrWhiteSpace(DTEmpDet.ToString) Then
    '                For Each dtRow As DataRow In DTEmpDet.Tables(0).Rows

    '                    columnsQuery += If((columnsQuery.Length > 0), ",", "")
    '                    columnsQuery += "`" + dtRow.ItemArray(0).ToString() + "`"
    '                    valuesQuery += If((valuesQuery.Length > 0), ",", "")
    '                    valuesQuery += "@" + dtRow.ItemArray(0).ToString()
    '                    arrParameters = fnCallByName_StockRequest(selectedTable + "_i", request, dtRow.ItemArray(1).ToString(), dtRow.ItemArray(0).ToString(), itemNo, arrParameters)
    '                Next
    '            End If

    '            Try
    '                conStrMysql.Open()
    '                MySqlHelper.ExecuteReader(conStrMysql, String.Format("START TRANSACTION;INSERT INTO `" + selectedTable + "_i` (`H_ID`," + columnsQuery + ") VALUES (" + insertedHeaderId.ToString() + "," + valuesQuery + ");COMMIT;"), arrParameters.ToArray())
    '                conStrMysql.Close()
    '            Catch ex As Exception
    '                conStrMysql.Close()
    '                Throw New SoapException(ex.Message, SoapException.ServerFaultCode)
    '            End Try
    '        Next
    '        Return New stockRequestResponse()
    '    Catch ex As Exception
    '        Throw New SoapException(ex.Message, SoapException.ServerFaultCode)
    '    End Try
    'End Function




    Public Function stockRequestCallback(request As stockRequestCallback) As stockRequestCallback Implements IStockRequestConsumerService.stockRequestCallback
        'If request.data Is Nothing Then Throw New SoapException("no data", SoapException.ServerFaultCode)

        'Dim response As New stockRequestCallback
        'response.context = New schemas.telekom.net.csdg_v01._01.TCContext
        'response.data = New services.tint.telekom.net.SupAndPartMgmt.LogWarehouseMgmt.StockRequest_v01._00.types.StockRequestInputData With {.Items = request.data.Items}
        'For i = 0 To request.data.Items.Count - 1
        '    response.data.Items(i).materialNumber = Nothing
        '    response.data.Items(i).plant = Nothing
        '    response.data.Items(i).quan = Nothing
        '    response.data.Items(i).quanSpecified = Nothing
        '    response.data.Items(i).SN = Nothing
        '    response.data.Items(i).stockInd = Nothing
        '    response.data.Items(i).stockType = Nothing
        '    response.data.Items(i).storLoc = Nothing
        '    response.data.Items(i).UIID = Nothing
        '    response.data.Items(i).uom = Nothing
        '    response.data.Items(i).valType = Nothing
        '    response.data.processingStatus = "KO"
        'Next
        'Dim responseItem As New StockAvailabilityItem()
        'Dim DTEmpDet = New DataSet()
        'Dim DTCis = New DataSet()
        'Dim counter = 0

        'Try
        '    Dim conStr = WebConfigurationManager.ConnectionStrings("SHARPCONN").ConnectionString

        '    DTCis = MySqlHelper.ExecuteDataset(conStr, String.Format("select db_nazev,wsdl_nazev,exportovat,podminka from ciselnik_preklad_sloupcu where tabulka='dynam_fake_sklad'"))
        '    'DTEmpDet = MySqlHelper.ExecuteDataset(conStr, String.Format("SELECT DISTINCT b.PODROBNOSTI,a.* FROM fake_sklad a,stock_request_i b,stock_request_h c WHERE ((LENGTH(b.CISLO_MATERIALU) >0 AND a.CISLO_MATERIALU = b.CISLO_MATERIALU ) OR (LENGTH(b.CISLO_MATERIALU) = 0)) AND c.ID = b.H_ID AND c.MESSAGE_ID = " + request.context.technicalContext.messageId + ""))
        '    DTEmpDet = MySqlHelper.ExecuteDataset(conStr, String.Format("SELECT DISTINCT b.PODROBNOSTI,a.* FROM fake_sklad a,stock_request_i b,stock_request_h c WHERE ((LENGTH(b.CISLO_MATERIALU) >0 AND a.CISLO_MATERIALU = b.CISLO_MATERIALU ) OR (LENGTH(b.CISLO_MATERIALU) = 0)) AND c.ID = b.H_ID AND c.MESSAGE_ID = " + CallByName(request.context.technicalContext, "messageId", CallType.Get) + ""))

        '    If Not String.IsNullOrWhiteSpace(DTEmpDet.ToString) Then
        '        For Each datarow As DataRow In DTEmpDet.Tables(0).Rows
        '            responseItem = New StockAvailabilityItem

        '            For Each columName As DataRow In DTCis.Tables(0).Rows

        '                If (columName(3).ToString.Contains(datarow.Item("PODROBNOSTI").ToString) And Not String.IsNullOrWhiteSpace(datarow.Item("PODROBNOSTI").ToString)) Or
        '                   (String.IsNullOrWhiteSpace(datarow.Item("PODROBNOSTI").ToString) And columName(3).ToString.Contains("|-|")) Or
        '                   String.IsNullOrWhiteSpace(datarow.Item("CISLO_MATERIALU").ToString) Then
        '                    Try
        '                        CallByName(responseItem, columName(1).ToString, CallType.Set, datarow.Item(columName(0).ToString))
        '                    Catch ex As Exception
        '                        CallByName(responseItem, columName(1).ToString, CallType.Set, "")
        '                    End Try
        '                End If
        '            Next

        '            response.data.Items.Insert(counter, responseItem) ' = responseItem
        '            response.data.Items(counter).quanSpecified = True
        '            response.data.processingStatus = "OK"
        '            If counter < request.data.Items.Count Then counter += 1
        '        Next
        '    End If


        'Catch ex As Exception
        '    Throw New SoapException(ex.Message, SoapException.ServerFaultCode)
        'End Try

        'Return response
    End Function


    'Public Function stockRequestFaultAsync(request As stockRequestFault) As Task(Of stockRequestResponse) Implements IStockRequestConsumerService.stockRequestFaultAsync
    '    ' If request.data Is Nothing Then Throw New SoapException("no data", SoapException.ServerFaultCode)
    '    Return stockRequestFaultAsync(request)
    'End Function

    'Public Function stockRequestAsync(request As stockRequest) As Task(Of stockRequestResponse) Implements IStockRequestConsumerService.stockRequestAsync
    '    Return New StockRequestClient().stockRequestAsync(request)
    'End Function


    Public Async Function stockRequestCallbackAsync(request As stockRequestCallback) As Task(Of stockRequestCallbackResponse) Implements IStockRequestConsumerService.stockRequestCallbackAsync
        If String.IsNullOrWhiteSpace(fn_GetTCContextNodeValue(request.context, "messageId")) Then Throw New SoapException("no data", SoapException.ServerFaultCode)

        Dim response As New stockRequestCallbackResponse
        response.context = New StockRequestService.TCContext
        response.data = New StockRequestOutputData With {.Items = request.data.Item}
        response.data.Items.Clear()

        Dim responseItem As New StockAvailabilityItem()
        Dim DTEmpDet = New DataSet()
        Dim DTCis = New DataSet()
        Dim counter = 0

        Try
            Dim conStr = WebConfigurationManager.ConnectionStrings("SHARPCONN").ConnectionString

            DTCis = Await MySqlHelper.ExecuteDatasetAsync(conStr, String.Format("select db_nazev,wsdl_nazev,exportovat,podminka from ciselnik_preklad_sloupcu where tabulka='dynam_fake_sklad'"))
            DTEmpDet = Await MySqlHelper.ExecuteDatasetAsync(conStr, String.Format("SELECT DISTINCT b.PODROBNOSTI,a.* FROM fake_sklad a,stock_request_i b,stock_request_h c WHERE ((LENGTH(b.CISLO_MATERIALU) >0 AND a.CISLO_MATERIALU = b.CISLO_MATERIALU ) OR (LENGTH(b.CISLO_MATERIALU) = 0)) AND c.ID = b.H_ID AND c.MESSAGE_ID = " + fn_GetTCContextNodeValue(request.context, "messageId") + ""))

            If Not String.IsNullOrWhiteSpace(DTEmpDet.ToString) Then
                For Each datarow As DataRow In DTEmpDet.Tables(0).Rows
                    responseItem = New StockAvailabilityItem

                    For Each columName As DataRow In DTCis.Tables(0).Rows

                        If (columName(3).ToString.Contains(datarow.Item("PODROBNOSTI").ToString) And Not String.IsNullOrWhiteSpace(datarow.Item("PODROBNOSTI").ToString)) Or
                           (String.IsNullOrWhiteSpace(datarow.Item("PODROBNOSTI").ToString) And columName(3).ToString.Contains("|-|")) Or
                           String.IsNullOrWhiteSpace(datarow.Item("CISLO_MATERIALU").ToString) Then
                            Try
                                CallByName(responseItem, columName(1).ToString, CallType.Set, datarow.Item(columName(0).ToString))
                            Catch ex As Exception
                                CallByName(responseItem, columName(1).ToString, CallType.Set, "")
                            End Try
                        End If
                    Next


                    response.data.Items.Insert(counter, responseItem) ' = responseItem
                    response.data.Items(counter).quanSpecified = True
                    response.data.processingStatus = "OK"
                    'If counter < request.data.Items.Count Then counter += 1
                    counter += 1
                Next
            End If


        Catch ex As Exception
            Throw New SoapException(ex.Message, SoapException.ServerFaultCode)
        End Try

        Return response
    End Function


    Public Function stockRequestFault(request As stockRequestFault) As stockRequestResponse Implements IStockRequestConsumerService.stockRequestFault
        ' If request.data Is Nothing Then Throw New SoapException("no data", SoapException.ServerFaultCode)
        Return New stockRequestResponse()
    End Function

    Public Function requestCourierDelivery(request As requestCourierDeliveryRequest1) As CourierDeliveryManagementSoapPortTypeService.requestCourierDeliveryResponse1 Implements ICourierDeliveryManagementSoapPortTypeService.requestCourierDelivery
        'Try
        '    Dim serxml = New XmlSerializer(request.GetType())
        '    Dim MS = New MemoryStream()
        '    serxml.Serialize(MS, request)
        '    Dim test = Encoding.UTF8.GetString(MS.ToArray())
        '    fn_WriteToFile(IO.Path.Combine(ServiceWSDL.setting_folder, "xml" + DateTime.Now.ToString("yyyyMMddThhmmss") + "_" + CInt(Int((9999 * Rnd()) + 1)).ToString() + ".log"), test)
        'Catch
        'End Try

        ' If request.data Is Nothing Then Throw New SoapException("no data", SoapException.ServerFaultCode)
        Dim conStrMysql = New MySqlConnection()
        conStrMysql.ConnectionString = WebConfigurationManager.ConnectionStrings("SHARPCONN").ConnectionString

        Dim columnsQuery = "", valuesQuery = ""
        Dim DTEmpDet = New DataSet()
        Dim arrParameters As New List(Of MySqlParameter)
        Dim selectedTable = "esign_import"
        Dim insertedHeaderId As ULong
        Dim persIdScan As Boolean = False

        Try
            'header
            DTEmpDet = MySqlHelper.ExecuteDataset(conStrMysql, String.Format("select db_nazev,wsdl_nazev from ciselnik_preklad_sloupcu where tabulka='" + selectedTable + "' and exportovat = 1"))
            DTEmpDet.Tables(0).TableName = selectedTable

            If Not String.IsNullOrWhiteSpace(DTEmpDet.ToString) Then
                For Each dtRow As DataRow In DTEmpDet.Tables(0).Rows

                    columnsQuery += If((columnsQuery.Length > 0), ",", "")
                    columnsQuery += "`" + dtRow.ItemArray(0).ToString() + "`"
                    valuesQuery += If((valuesQuery.Length > 0), ",", "")
                    valuesQuery += "@" + dtRow.ItemArray(0).ToString()
                    arrParameters = fnCallByName_requestCourierDelivery(selectedTable + "", request, dtRow.ItemArray(1).ToString(), dtRow.ItemArray(0).ToString(), arrParameters)
                Next
            End If

            persIdScan = CType(arrParameters.Find(Function(x) x.ParameterName = "PERSONAL_ID_SCAN").Value, Boolean)

            'If arrParameters.Find(Function(x) x.ParameterName = "CUSTOMER_FIRST_NAME").Value = arrParameters.Find(Function(x) x.ParameterName = "CUSTOMER_LAST_NAME").Value Then
            '    arrParameters.Find(Function(x) x.ParameterName = "CUSTOMER_LAST_NAME").Value = ""
            'End If

            Try
                conStrMysql.Open()
                Dim Reader As IDataReader = MySqlHelper.ExecuteReader(conStrMysql, String.Format("START TRANSACTION;INSERT INTO `" + selectedTable + "` (" + columnsQuery + ") VALUES (" + valuesQuery + ");SELECT LAST_INSERT_ID();COMMIT;"), arrParameters.ToArray())
                Reader.Read()
                insertedHeaderId = Reader.Item(0)
                conStrMysql.Close()
            Catch ex As MySqlException 'Exception
                fn_WriteToFile(IO.Path.Combine(ServiceWSDL.setting_folder, "logfile" + DateTime.Now.ToString("yyyyMMddThhmmss") + "_" + CInt(Int((9999 * Rnd()) + 1)).ToString() + ".log"), "START TRANSACTION;INSERT INTO `" + selectedTable + "` (" + columnsQuery + ") VALUES (" + valuesQuery + ");COMMIT;" + vbNewLine + ex.Message)

                conStrMysql.Close()
                Throw New SoapException(ex.Message, SoapException.ServerFaultCode)
            End Try

            fn_save_to_import(request, insertedHeaderId.ToString(), persIdScan)


            Dim response = New CourierDeliveryManagementSoapPortTypeService.requestCourierDeliveryResponse1()
            Dim responseCourierDeliveryOut = New requestCourierDeliveryOut

            'responseCourierDeliveryOut.statusCode = 200
            responseCourierDeliveryOut.status = "success"
            responseCourierDeliveryOut.statusCode = "OK"
            responseCourierDeliveryOut.messageId = request.requestCourierDeliveryIn.messageId
            responseCourierDeliveryOut.timestamp = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ssK")
            'responseCourierDeliveryOut.timestamp = DateTime.Now().ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ss.fff") + "+" + TimeZone.CurrentTimeZone.GetUtcOffset(DateTime.Now).ToString().Substring(0, 5)

            response.requestCourierDeliveryOut = responseCourierDeliveryOut
            response.requestCourierDeliveryOut.Body = New CourierDeliveryManagementSoapPortTypeService.requestCourierDeliveryResponse


            Return response
        Catch ex As Exception
            conStrMysql.Close()

            Dim response = New CourierDeliveryManagementSoapPortTypeService.requestCourierDeliveryResponse1()
            Dim responseCourierDeliveryOut = New requestCourierDeliveryOut
            'responseCourierDeliveryOut.statusCode = 500
            responseCourierDeliveryOut.status = "failure"
            responseCourierDeliveryOut.statusCode = ex.Message
            responseCourierDeliveryOut.messageId = request.requestCourierDeliveryIn.messageId
            responseCourierDeliveryOut.timestamp = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ssK")
            'responseCourierDeliveryOut.timestamp = DateTime.Now().ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ss.fff") + "+" + TimeZone.CurrentTimeZone.GetUtcOffset(DateTime.Now).ToString().Substring(0, 5)
            response.requestCourierDeliveryOut = responseCourierDeliveryOut
            response.requestCourierDeliveryOut.Body = New CourierDeliveryManagementSoapPortTypeService.requestCourierDeliveryResponse
            Return response

            Throw New SoapException(ex.Message, SoapException.ServerFaultCode)
        End Try
    End Function


    Public Function deliveryDocumentsNotify(request As deliveryDocumentsNotifyRequest1) As CourierDeliveryManagementSoapPortTypeService.deliveryDocumentsNotifyResponse1 Implements ICourierDeliveryManagementSoapPortTypeService.deliveryDocumentsNotify
        Dim conStrMysql = New MySqlConnection()
        conStrMysql.ConnectionString = WebConfigurationManager.ConnectionStrings("SHARPCONN").ConnectionString

        Dim columnsQuery = "", valuesQuery = ""
        Dim DTEmpDet = New DataSet()
        Dim arrParameters As New List(Of MySqlParameter)
        Dim selectedTable = "esign_docs_notify"
        Dim insertedHeaderId As ULong
        Dim tmFile As String = Nothing
        Dim AppFile As String = Nothing
        Dim DBFtpResultColumns As String = ""
        Dim DBFtpResultValues As String = ""
        Try
            'header
            DTEmpDet = MySqlHelper.ExecuteDataset(conStrMysql, String.Format("select db_nazev,wsdl_nazev from ciselnik_preklad_sloupcu where tabulka='" + selectedTable + "' and exportovat = 1"))
            DTEmpDet.Tables(0).TableName = selectedTable

            If Not String.IsNullOrWhiteSpace(DTEmpDet.ToString) Then
                For Each dtRow As DataRow In DTEmpDet.Tables(0).Rows

                    columnsQuery += If((columnsQuery.Length > 0), ",", "")
                    columnsQuery += "`" + dtRow.ItemArray(0).ToString() + "`"
                    valuesQuery += If((valuesQuery.Length > 0), ",", "")
                    valuesQuery += "@" + dtRow.ItemArray(0).ToString()
                    arrParameters = fnCallByName_deliveryDocumentsNotify(selectedTable + "", request, dtRow.ItemArray(1).ToString(), dtRow.ItemArray(0).ToString(), arrParameters)
                    If dtRow.ItemArray(0).ToString() = "EXTERNAL_DELIVERY_ID" Then
                        tmFile = "out_" + arrParameters.Last.Value + ".zip"
                        AppFile = "in_" + arrParameters.Last.Value + ".zip"
                    End If
                Next
            End If


            'transfer FTP FILES
            If Not fnTransferSftpToFtp(tmFile, AppFile) Then
                DBFtpResultColumns = ",DN_STATUS,DN_STATUS_CODE,DN_STATUS_MESSAGE"
                DBFtpResultValues = ",'failure','400','Attachment: " + tmFile + " cannot be transfered '"
            Else
                DBFtpResultColumns = ",TRANSFER_STATUS"
                DBFtpResultValues = ",1"
            End If

            Try

                'columnsQuery += ",`UZIVATEL`,`DATUM_CAS`"
                'valuesQuery += ",@UZIVATEL,@DATUM_CAS"
                'arrParameters.Add(New MySqlParameter("UZIVATEL", 1))
                'arrParameters.Add(New MySqlParameter("DATUM_CAS", DateTime.UtcNow))

                conStrMysql.Open()
                Dim Reader As IDataReader = MySqlHelper.ExecuteReader(conStrMysql, String.Format("START TRANSACTION;INSERT INTO `" + selectedTable + "` (" + columnsQuery + DBFtpResultColumns + ") VALUES (" + valuesQuery + DBFtpResultValues + ");SELECT LAST_INSERT_ID();COMMIT;"), arrParameters.ToArray())
                Reader.Read()
                insertedHeaderId = Reader.Item(0)
                conStrMysql.Close()
                'insertedHeaderId = 2
            Catch ex As Exception
                conStrMysql.Close()
                Throw New SoapException(ex.Message, SoapException.ServerFaultCode)
            End Try

            'RESPONSE PART
            Dim response As New CourierDeliveryManagementSoapPortTypeService.deliveryDocumentsNotifyResponse1 With {.deliveryDocumentsNotifyOut = New deliveryDocumentsNotifyOut With {.Body = New CourierDeliveryManagementSoapPortTypeService.deliveryDocumentsNotifyResponse()}}
            Dim responseData = New deliveryDocumentsNotifyOut
            Dim responseDataBody As New CourierDeliveryManagementSoapPortTypeService.deliveryDocumentsNotifyResponse
            DTEmpDet.Clear()

            Try

                DTEmpDet = MySqlHelper.ExecuteDataset(conStrMysql, String.Format("select DN_MESSAGE_ID,DN_STATUS,DN_STATUS_CODE,DN_STATUS_MESSAGE,DN_STACK_TRACE,DN_TIMESTAMP from " + selectedTable + " where ID=" + insertedHeaderId.ToString() + " "))

                If Not String.IsNullOrWhiteSpace(DTEmpDet.ToString) Then

                    For Each datarow As DataRow In DTEmpDet.Tables(0).Rows
                        responseData.messageId = datarow.Item(0)
                        responseData.status = datarow.Item(1)
                        responseData.statusCode = datarow.Item(2)
                        responseData.statusMessage = datarow.Item(3)
                        responseData.stackTrace = datarow.Item(4)
                        responseData.timestamp = datarow.Item(5)
                        'responseData.timestamp = CDate(datarow.Item(5)).ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ss.fff") + "+" + TimeZone.CurrentTimeZone.GetUtcOffset(DateTime.Now).ToString().Substring(0, 5)
                    Next
                End If

                responseData.Body = responseDataBody

            Catch ex As Exception
                Throw New SoapException(ex.Message, SoapException.ServerFaultCode)
            End Try

            response.deliveryDocumentsNotifyOut = responseData

            Return response
        Catch ex As Exception
            conStrMysql.Close()
            Throw New SoapException(ex.Message, SoapException.ServerFaultCode)
        End Try

    End Function

    Public Function requestCourierLabel(request As requestCourierLabelRequest1) As requestCourierLabelResponse1 Implements ICourierDeliveryManagementSoapPortTypeService.requestCourierLabel
        Dim conStrMysql = New MySqlConnection()
        conStrMysql.ConnectionString = WebConfigurationManager.ConnectionStrings("SHARPCONN").ConnectionString

        Dim columnsQuery = "", valuesQuery = ""
        Dim DTEmpDet = New DataSet()
        Dim arrParameters As New List(Of MySqlParameter)
        Dim selectedTable = "esign_request_label"
        Dim insertedHeaderId As ULong

        Try
            'header
            DTEmpDet = MySqlHelper.ExecuteDataset(conStrMysql, String.Format("select db_nazev,wsdl_nazev from ciselnik_preklad_sloupcu where tabulka='" + selectedTable + "' and exportovat = 1"))
            DTEmpDet.Tables(0).TableName = selectedTable

            If Not String.IsNullOrWhiteSpace(DTEmpDet.ToString) Then
                For Each dtRow As DataRow In DTEmpDet.Tables(0).Rows
                    columnsQuery += If((columnsQuery.Length > 0), ",", "")
                    columnsQuery += "`" + dtRow.ItemArray(0).ToString() + "`"
                    valuesQuery += If((valuesQuery.Length > 0), ",", "")
                    valuesQuery += "@" + dtRow.ItemArray(0).ToString()
                    arrParameters = fnCallByName_requestCourierLabel(selectedTable + "", request, dtRow.ItemArray(1).ToString(), dtRow.ItemArray(0).ToString(), arrParameters)
                Next
            End If

            Try
                conStrMysql.Open()
                'columnsQuery += ",`UZIVATEL`,`DATUM_CAS`"
                'valuesQuery += ",@UZIVATEL,@DATUM_CAS"
                'arrParameters.Add(New MySqlParameter("UZIVATEL", 1))
                'arrParameters.Add(New MySqlParameter("DATUM_CAS", DateTime.UtcNow))

                Dim Reader As IDataReader = MySqlHelper.ExecuteReader(conStrMysql, String.Format("START TRANSACTION;INSERT INTO `" + selectedTable + "` (" + columnsQuery + ") VALUES (" + valuesQuery + ");SELECT LAST_INSERT_ID();COMMIT;"), arrParameters.ToArray())
                Reader.Read()
                insertedHeaderId = Reader.Item(0)
                conStrMysql.Close()
                'insertedHeaderId = 191
            Catch ex As Exception
                conStrMysql.Close()
                Throw New SoapException(ex.Message, SoapException.ServerFaultCode)
            End Try


            'RESPONSE PART
            Dim response As New requestCourierLabelResponse1 With {.requestCourierLabelOut = New requestCourierLabelOut With {.Body = New requestCourierLabelResponse()}}
            Dim responseData = New requestCourierLabelOut
            Dim responseDataBody As New requestCourierLabelResponse
            DTEmpDet.Clear()

            Try

                DTEmpDet = MySqlHelper.ExecuteDataset(conStrMysql, String.Format("select LABELOUT_MESSAGE_ID,LABELOUT_STATUS,LABELOUT_STATUS_CODE,LABELOUT_STATUS_MESSAGE,LABELOUT_STACKTRACE,LABELOUT_TIMESTAMP,LABELOUT_FILENAME,LABELOUT_MIMETYPE from " + selectedTable + " where ID=" + insertedHeaderId.ToString() + " "))

                If Not String.IsNullOrWhiteSpace(DTEmpDet.ToString) Then

                    For Each datarow As DataRow In DTEmpDet.Tables(0).Rows
                        responseData.messageId = datarow.Item(0)
                        responseData.status = datarow.Item(1)
                        responseData.statusCode = datarow.Item(2)
                        responseData.statusMessage = datarow.Item(3)
                        responseData.stackTrace = datarow.Item(4)
                        responseData.timestamp = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ssK")
                        'responseData.timestamp = DateTime.Now().ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ss.fff") + "+" + TimeZone.CurrentTimeZone.GetUtcOffset(DateTime.Now).ToString().Substring(0, 5)
                        responseDataBody.fileName = datarow.Item(6)
                        responseDataBody.mimeType = datarow.Item(7)
                        responseDataBody.binaryContent = fnPrintLabel(insertedHeaderId.ToString())
                    Next
                End If

                responseData.Body = responseDataBody

            Catch ex As Exception
                Throw New SoapException(ex.Message, SoapException.ServerFaultCode)
            End Try

            response.requestCourierLabelOut = responseData

            Return response
        Catch ex As Exception
            conStrMysql.Close()
            Throw New SoapException(ex.Message, SoapException.ServerFaultCode)
        End Try
    End Function


    Public Function courierDeliveryStatus(request As courierDeliveryStatusService.courierDeliveryStatusRequest) Implements IcourierDeliveryStatusService.courierDeliveryStatus
        Dim conStrMysql = New MySqlConnection()
        conStrMysql.ConnectionString = WebConfigurationManager.ConnectionStrings("SHARPCONN").ConnectionString

        Dim columnsQuery = "", valuesQuery = ""
        Dim DTEmpDet = New DataSet()
        Dim arrParameters As New List(Of MySqlParameter)
        Dim selectedTable = "esign_delivery_status"

        Try
            'header
            DTEmpDet = MySqlHelper.ExecuteDataset(conStrMysql, String.Format("select db_nazev,wsdl_nazev from ciselnik_preklad_sloupcu where tabulka='" + selectedTable + "' and exportovat = 1"))
            DTEmpDet.Tables(0).TableName = selectedTable

            If Not String.IsNullOrWhiteSpace(DTEmpDet.ToString) Then
                For Each dtRow As DataRow In DTEmpDet.Tables(0).Rows

                    columnsQuery += If((columnsQuery.Length > 0), ",", "")
                    columnsQuery += "`" + dtRow.ItemArray(0).ToString() + "`"
                    valuesQuery += If((valuesQuery.Length > 0), ",", "")
                    valuesQuery += "@" + dtRow.ItemArray(0).ToString()
                    arrParameters = fnCallByName_courierDeliveryStatus(selectedTable + "", request, dtRow.ItemArray(1).ToString(), dtRow.ItemArray(0).ToString(), arrParameters)
                Next
            End If

            Try
                conStrMysql.Open()
                'columnsQuery += ",`UZIVATEL`,`DATUM_CAS`"
                'valuesQuery += ",@UZIVATEL,@DATUM_CAS"
                'arrParameters.Add(New MySqlParameter("UZIVATEL", 1))
                'arrParameters.Add(New MySqlParameter("DATUM_CAS", DateTime.UtcNow))
                MySqlHelper.ExecuteReader(conStrMysql, String.Format("START TRANSACTION;INSERT INTO `" + selectedTable + "` (" + columnsQuery + ") VALUES (" + valuesQuery + ");COMMIT;"), arrParameters.ToArray())
                conStrMysql.Close()
            Catch ex As Exception
                conStrMysql.Close()
                Throw New SoapException(ex.Message, SoapException.ServerFaultCode)
            End Try

        Catch ex As Exception
            conStrMysql.Close()
            Throw New SoapException(ex.Message, SoapException.ServerFaultCode)
        End Try
    End Function


    Public Function courierDeliveryStatus(request As CourierServiceWriteService.courierDeliveryStatusRequest) As courierDeliveryStatusResponse1 Implements ICourierServiceWriteService.courierDeliveryStatus
        Throw New NotImplementedException()
    End Function

    Public Function requestCourierDelivery(request As CourierServiceWriteService.requestCourierDeliveryRequest) As CourierServiceWriteService.requestCourierDeliveryResponse1 Implements ICourierServiceWriteService.requestCourierDelivery

        Throw New NotImplementedException()
    End Function

    Public Function deliveryDocumentsNotify(request As CourierServiceWriteService.deliveryDocumentsNotifyRequest) As CourierServiceWriteService.deliveryDocumentsNotifyResponse1 Implements ICourierServiceWriteService.deliveryDocumentsNotify
        Throw New NotImplementedException()
    End Function

    Public Function batchDocumentList(request As batchDocumentListRequest) As batchDocumentListResponse1 Implements ICourierServiceWriteService.batchDocumentList
        Throw New NotImplementedException()
    End Function


    Public Function notifyPackageStatus(request As notifyPackageStatusRequest) As notifyPackageStatusResponse Implements IWMSDeliveryManagementService.notifyPackageStatus
        Dim response = New notifyPackageStatusResponse()
        If request.data Is Nothing Then
            response.data = New WMSDeliveryManagement_notifyPackageStatusResponse With {.responseCode = "1", .errorMessage = "Error"}
        Else
            response.data = New WMSDeliveryManagement_notifyPackageStatusResponse With {.responseCode = "0"}
        End If
        Return response
    End Function

    Public Function receiveCourierLabel(request As receiveCourierLabelRequest) As receiveCourierLabelResponse Implements IWMSDeliveryManagementService.receiveCourierLabel
        Return New receiveCourierLabelResponse()
    End Function

End Class









Namespace together
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Diagnostics.DebuggerStepThroughAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://schemas.telekom.net/csdg_v01.02")>
    Partial Public Class TCContext

        Private technicalContextField As TCTechnicalContext

        Private businessContextField As TCBusinessContext

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property technicalContext() As TCTechnicalContext
            Get
                Return Me.technicalContextField
            End Get
            Set
                Me.technicalContextField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public Property businessContext() As TCBusinessContext
            Get
                Return Me.businessContextField
            End Get
            Set
                Me.businessContextField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
     System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(),
     System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://schemas.telekom.net/csdg_v01.02")>
    Partial Public Class TCTechnicalContext

        Private fromField As String

        Private routingInfoField As String

        Private messageIdField As String

        Private relatesToMessageIdField As String

        Private currentSenderTimestampUTCField As Date

        Private expiryOffsetInMillisField As String

        Private priorityField As Short

        Private priorityFieldSpecified As Boolean

        Private replyStateField As String

        Private propertyField() As TCProperty

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property from() As String
            Get
                Return Me.fromField
            End Get
            Set
                Me.fromField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public Property routingInfo() As String
            Get
                Return Me.routingInfoField
            End Get
            Set
                Me.routingInfoField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>
        Public Property messageId() As String
            Get
                Return Me.messageIdField
            End Get
            Set
                Me.messageIdField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=3)>
        Public Property relatesToMessageId() As String
            Get
                Return Me.relatesToMessageIdField
            End Get
            Set
                Me.relatesToMessageIdField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=4)>
        Public Property currentSenderTimestampUTC() As Date
            Get
                Return Me.currentSenderTimestampUTCField
            End Get
            Set
                Me.currentSenderTimestampUTCField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(DataType:="integer", Order:=5)>
        Public Property expiryOffsetInMillis() As String
            Get
                Return Me.expiryOffsetInMillisField
            End Get
            Set
                Me.expiryOffsetInMillisField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=6)>
        Public Property priority() As Short
            Get
                Return Me.priorityField
            End Get
            Set
                Me.priorityField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>
        Public Property prioritySpecified() As Boolean
            Get
                Return Me.priorityFieldSpecified
            End Get
            Set
                Me.priorityFieldSpecified = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=7)>
        Public Property replyState() As String
            Get
                Return Me.replyStateField
            End Get
            Set
                Me.replyStateField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("property", Order:=8)>
        Public Property [property]() As TCProperty()
            Get
                Return Me.propertyField
            End Get
            Set
                Me.propertyField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
     System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(),
     System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://schemas.telekom.net/csdg_v01.02")>
    Partial Public Class TCProperty

        Private nameField As String

        Private typeField As TCPropertyType

        Private typeFieldSpecified As Boolean

        Private policyField As String

        Private valueField As String

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property name() As String
            Get
                Return Me.nameField
            End Get
            Set
                Me.nameField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property type() As TCPropertyType
            Get
                Return Me.typeField
            End Get
            Set
                Me.typeField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>
        Public Property typeSpecified() As Boolean
            Get
                Return Me.typeFieldSpecified
            End Get
            Set
                Me.typeFieldSpecified = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property policy() As String
            Get
                Return Me.policyField
            End Get
            Set
                Me.policyField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlTextAttribute()>
        Public Property Value() As String
            Get
                Return Me.valueField
            End Get
            Set
                Me.valueField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
     System.SerializableAttribute(),
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://schemas.telekom.net/csdg_v01.02")>
    Public Enum TCPropertyType

        '''<remarks/>
        [string]

        '''<remarks/>
        int

        '''<remarks/>
        [boolean]

        '''<remarks/>
        float

        '''<remarks/>
        [date]
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
     System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(),
     System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://schemas.telekom.net/csdg_v01.02")>
    Partial Public Class TCBusinessContext

        Private processIdField As String

        Private processTypeIdField As String

        Private messageGroupIdField As String

        Private processStepTypeIdField As String

        Private parentProcessIdField As String

        Private propertyField() As TCProperty

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property processId() As String
            Get
                Return Me.processIdField
            End Get
            Set
                Me.processIdField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public Property processTypeId() As String
            Get
                Return Me.processTypeIdField
            End Get
            Set
                Me.processTypeIdField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>
        Public Property messageGroupId() As String
            Get
                Return Me.messageGroupIdField
            End Get
            Set
                Me.messageGroupIdField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=3)>
        Public Property processStepTypeId() As String
            Get
                Return Me.processStepTypeIdField
            End Get
            Set
                Me.processStepTypeIdField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=4)>
        Public Property parentProcessId() As String
            Get
                Return Me.parentProcessIdField
            End Get
            Set
                Me.parentProcessIdField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("property", Order:=5)>
        Public Property [property]() As TCProperty()
            Get
                Return Me.propertyField
            End Get
            Set
                Me.propertyField = Value
            End Set
        End Property
    End Class


End Namespace

Namespace schemas.telekom.net.csdg_v01._02

    <System.Diagnostics.DebuggerStepThroughAttribute(),
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0"),
     System.Xml.Serialization.XmlSchemaProviderAttribute("ExportSchema"),
     System.Xml.Serialization.XmlRootAttribute(ElementName:="technicalFault", [Namespace]:="http://schemas.telekom.net/csdg_v01.02", IsNullable:=False)>
    Partial Public Class TCTechnicalFaultInfo
        Inherits Object
        Implements System.Xml.Serialization.IXmlSerializable

        Private nodesField() As System.Xml.XmlNode

        Private Shared typeName As System.Xml.XmlQualifiedName = New System.Xml.XmlQualifiedName("TCTechnicalFaultInfo", "http://schemas.telekom.net/csdg_v01.02")

        Public Property Nodes() As System.Xml.XmlNode()
            Get
                Return Me.nodesField
            End Get
            Set
                Me.nodesField = Value
            End Set
        End Property

        Public Sub ReadXml(ByVal reader As System.Xml.XmlReader) Implements System.Xml.Serialization.IXmlSerializable.ReadXml
            Me.nodesField = System.Runtime.Serialization.XmlSerializableServices.ReadNodes(reader)
        End Sub

        Public Sub WriteXml(ByVal writer As System.Xml.XmlWriter) Implements System.Xml.Serialization.IXmlSerializable.WriteXml
            System.Runtime.Serialization.XmlSerializableServices.WriteNodes(writer, Me.Nodes)
        End Sub

        Public Function GetSchema() As System.Xml.Schema.XmlSchema Implements System.Xml.Serialization.IXmlSerializable.GetSchema
            Return Nothing
        End Function

        Public Shared Function ExportSchema(ByVal schemas As System.Xml.Schema.XmlSchemaSet) As System.Xml.XmlQualifiedName
            System.Runtime.Serialization.XmlSerializableServices.AddDefaultSchema(schemas, typeName)
            Return typeName
        End Function
    End Class

    <System.Diagnostics.DebuggerStepThroughAttribute(),
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0"),
     System.Xml.Serialization.XmlSchemaProviderAttribute("ExportSchema"),
     System.Xml.Serialization.XmlRootAttribute(IsNullable:=False)>
    Partial Public Class TCFaultInfo
        Inherits Object
        Implements System.Xml.Serialization.IXmlSerializable

        Private nodesField() As System.Xml.XmlNode

        Private Shared typeName As System.Xml.XmlQualifiedName = New System.Xml.XmlQualifiedName("TCFaultInfo", "http://schemas.telekom.net/csdg_v01.02")

        Public Property Nodes() As System.Xml.XmlNode()
            Get
                Return Me.nodesField
            End Get
            Set
                Me.nodesField = Value
            End Set
        End Property

        Public Sub ReadXml(ByVal reader As System.Xml.XmlReader) Implements System.Xml.Serialization.IXmlSerializable.ReadXml
            Me.nodesField = System.Runtime.Serialization.XmlSerializableServices.ReadNodes(reader)
        End Sub

        Public Sub WriteXml(ByVal writer As System.Xml.XmlWriter) Implements System.Xml.Serialization.IXmlSerializable.WriteXml
            System.Runtime.Serialization.XmlSerializableServices.WriteNodes(writer, Me.Nodes)
        End Sub

        Public Function GetSchema() As System.Xml.Schema.XmlSchema Implements System.Xml.Serialization.IXmlSerializable.GetSchema
            Return Nothing
        End Function

        Public Shared Function ExportSchema(ByVal schemas As System.Xml.Schema.XmlSchemaSet) As System.Xml.XmlQualifiedName
            System.Runtime.Serialization.XmlSerializableServices.AddDefaultSchema(schemas, typeName)
            Return typeName
        End Function
    End Class

    <System.Diagnostics.DebuggerStepThroughAttribute(),
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0"),
     System.Runtime.Serialization.DataContractAttribute(Name:="TCContext", [Namespace]:="http://schemas.telekom.net/csdg_v01.02")>
    Partial Public Class TCContext
        Inherits Object
        Implements System.Runtime.Serialization.IExtensibleDataObject

        Private extensionDataField As System.Runtime.Serialization.ExtensionDataObject

        Private technicalContextField As schemas.telekom.net.csdg_v01._02.TCTechnicalContext

        Private businessContextField As schemas.telekom.net.csdg_v01._02.TCBusinessContext

        Public Property ExtensionData() As System.Runtime.Serialization.ExtensionDataObject Implements System.Runtime.Serialization.IExtensibleDataObject.ExtensionData
            Get
                Return Me.extensionDataField
            End Get
            Set
                Me.extensionDataField = Value
            End Set
        End Property

        <System.Runtime.Serialization.DataMemberAttribute(IsRequired:=True, EmitDefaultValue:=False)>
        Public Property technicalContext() As schemas.telekom.net.csdg_v01._02.TCTechnicalContext
            Get
                Return Me.technicalContextField
            End Get
            Set
                Me.technicalContextField = Value
            End Set
        End Property

        <System.Runtime.Serialization.DataMemberAttribute(IsRequired:=True, EmitDefaultValue:=False, Order:=1)>
        Public Property businessContext() As schemas.telekom.net.csdg_v01._02.TCBusinessContext
            Get
                Return Me.businessContextField
            End Get
            Set
                Me.businessContextField = Value
            End Set
        End Property
    End Class

    <System.Diagnostics.DebuggerStepThroughAttribute(),
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0"),
     System.Xml.Serialization.XmlSchemaProviderAttribute("ExportSchema"),
     System.Xml.Serialization.XmlRootAttribute(IsNullable:=False)>
    Partial Public Class TCTechnicalContext
        Inherits Object
        Implements System.Xml.Serialization.IXmlSerializable

        Private nodesField() As System.Xml.XmlNode

        Private Shared typeName As System.Xml.XmlQualifiedName = New System.Xml.XmlQualifiedName("TCTechnicalContext", "http://schemas.telekom.net/csdg_v01.02")

        Public Property Nodes() As System.Xml.XmlNode()
            Get
                Return Me.nodesField
            End Get
            Set
                Me.nodesField = Value
            End Set
        End Property

        Public Sub ReadXml(ByVal reader As System.Xml.XmlReader) Implements System.Xml.Serialization.IXmlSerializable.ReadXml
            Me.nodesField = System.Runtime.Serialization.XmlSerializableServices.ReadNodes(reader)
        End Sub

        Public Sub WriteXml(ByVal writer As System.Xml.XmlWriter) Implements System.Xml.Serialization.IXmlSerializable.WriteXml
            System.Runtime.Serialization.XmlSerializableServices.WriteNodes(writer, Me.Nodes)
        End Sub

        Public Function GetSchema() As System.Xml.Schema.XmlSchema Implements System.Xml.Serialization.IXmlSerializable.GetSchema
            Return Nothing
        End Function

        Public Shared Function ExportSchema(ByVal schemas As System.Xml.Schema.XmlSchemaSet) As System.Xml.XmlQualifiedName
            System.Runtime.Serialization.XmlSerializableServices.AddDefaultSchema(schemas, typeName)
            Return typeName
        End Function
    End Class

    <System.Diagnostics.DebuggerStepThroughAttribute(),
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0"),
     System.Xml.Serialization.XmlSchemaProviderAttribute("ExportSchema"),
     System.Xml.Serialization.XmlRootAttribute(IsNullable:=False)>
    Partial Public Class TCBusinessContext
        Inherits Object
        Implements System.Xml.Serialization.IXmlSerializable

        Private nodesField() As System.Xml.XmlNode

        Private Shared typeName As System.Xml.XmlQualifiedName = New System.Xml.XmlQualifiedName("TCBusinessContext", "http://schemas.telekom.net/csdg_v01.02")

        Public Property Nodes() As System.Xml.XmlNode()
            Get
                Return Me.nodesField
            End Get
            Set
                Me.nodesField = Value
            End Set
        End Property

        Public Sub ReadXml(ByVal reader As System.Xml.XmlReader) Implements System.Xml.Serialization.IXmlSerializable.ReadXml
            Me.nodesField = System.Runtime.Serialization.XmlSerializableServices.ReadNodes(reader)
        End Sub

        Public Sub WriteXml(ByVal writer As System.Xml.XmlWriter) Implements System.Xml.Serialization.IXmlSerializable.WriteXml
            System.Runtime.Serialization.XmlSerializableServices.WriteNodes(writer, Me.Nodes)
        End Sub

        Public Function GetSchema() As System.Xml.Schema.XmlSchema Implements System.Xml.Serialization.IXmlSerializable.GetSchema
            Return Nothing
        End Function

        Public Shared Function ExportSchema(ByVal schemas As System.Xml.Schema.XmlSchemaSet) As System.Xml.XmlQualifiedName
            System.Runtime.Serialization.XmlSerializableServices.AddDefaultSchema(schemas, typeName)
            Return typeName
        End Function
    End Class
End Namespace
