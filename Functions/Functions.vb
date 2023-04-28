Imports System.Web.Configuration
Imports System.Xml
Imports AppWSDL.CourierDeliveryManagementSoapPortTypeService
Imports AppWSDL.courierDeliveryStatusService
Imports AppWSDL.GoodsMovementService
Imports AppWSDL.MaterialCreateChange
Imports AppWSDL.SendDeliveryDocument
Imports AppWSDL.SendPostingToDeliveries
Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing
Imports System.Drawing
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
Imports Image = iTextSharp.text.Image
Imports Font = iTextSharp.text.Font
Imports Renci.SshNet
'Imports Renci.SshNet

Module Functions

    Function fn_delete_file(ByVal file As String) As Boolean
        System.IO.File.Delete(file)

        If Not fn_check_file(file) Then
            Return True
        Else
            Return False
        End If
    End Function

    Function fnPrintLabel(ByVal Id As String) As Byte()
        Dim conStrMysql = New MySqlConnection()
        conStrMysql.ConnectionString = WebConfigurationManager.ConnectionStrings("SHARPCONN").ConnectionString
        Dim DTEmpDet = New DataSet()
        Dim objednavka, cisloZasilky, zakaznik, pocetKusu, adresa, psc, mesto, kontakt, dodaciList, dobirka, region, dodatek, poradi As String

        'define label size
        Dim pgSize = New iTextSharp.text.Rectangle(Utilities.MillimetersToPoints(105), Utilities.MillimetersToPoints(74))
        Dim m As MemoryStream = New MemoryStream()
        Dim pdfDoc = New Document(pgSize, 10, 10, 10, 10)
        Dim pdfWrite As PdfWriter = PdfWriter.GetInstance(pdfDoc, m)
        ' Dim pdfWrite As PdfWriter = PdfWriter.GetInstance(pdfDoc, New FileStream(Path.Combine(ServiceWSDL.setting_folder,"bin", "Data", "label.pdf"), FileMode.Create))
        pdfDoc.Open()

        'DTEmpDet = MySqlHelper.ExecuteDataset(conStrMysql, String.Format("SELECT DISTINCT asd.CISLO_ZASILKY,asd.POCET_KUSU,asd.ZAKAZNIK,asd.DODATEK,asd.ADRESA,asd.PSC,asd.MESTO,asd.KONTAKT,asd.DODACI_LIST,asd.DOBIRKA,asd.REGION,asd.PORADI,asd.OBJEDNAVKA FROM a_stitky_davka asd,esign_request_label erl WHERE  asd.CISLO_ZASILKY = erl.TRACKING_ID AND erl.ID =" + Id.ToString()))
        DTEmpDet = MySqlHelper.ExecuteDataset(conStrMysql, String.Format("SELECT DISTINCT z.CISLO_ZASILKY, asd.POCET_KUSU, asd.ZAKAZNIK, asd.DODATEK, asd.ADRESA, asd.PSC, asd.MESTO, asd.KONTAKT, asd.DODACI_LIST, asd.DOBIRKA, asd.REGION, asd.PORADI, erl.EXTERNAL_ID, asd.OBJEDNAVKA FROM esign_request_label erl, a_stitky_davka asd, zasilky z WHERE  asd.CISLO_ZASILKY = erl.TRACKING_ID And z.OBJEDNAVKA = erl.EXTERNAL_ID  And erl.ID =" + Id.ToString()))
        For Each datarow As DataRow In DTEmpDet.Tables(0).Rows

            pdfDoc.NewPage()
            pdfWrite.CloseStream = False
            Dim bf As BaseFont = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1250, BaseFont.NOT_EMBEDDED)
            Dim Font = New Font(bf, 10)
            Dim FontBold = New Font(bf, 10, Font.BOLD)

            cisloZasilky = If(IsDBNull(datarow.Item(0)), "", datarow.Item(0))
            pocetKusu = If(IsDBNull(datarow.Item(1)), "", datarow.Item(1))
            zakaznik = If(IsDBNull(datarow.Item(2)), "", datarow.Item(2))
            dodatek = If(IsDBNull(datarow.Item(3)), "", datarow.Item(3))
            adresa = If(IsDBNull(datarow.Item(4)), "", datarow.Item(4))
            psc = If(IsDBNull(datarow.Item(5)), "", datarow.Item(5))
            mesto = If(IsDBNull(datarow.Item(6)), "", datarow.Item(6))
            kontakt = If(IsDBNull(datarow.Item(7)), "", datarow.Item(7))
            dodaciList = If(IsDBNull(datarow.Item(8)), "", datarow.Item(8))
            dobirka = If(IsDBNull(datarow.Item(9)), "", datarow.Item(9))
            region = If(IsDBNull(datarow.Item(10)), "", datarow.Item(10))
            poradi = If(IsDBNull(datarow.Item(11)), "", datarow.Item(11))
            objednavka = If(IsDBNull(datarow.Item(12)), "", datarow.Item(12))


            'recipient table
            Dim outerTable As PdfPTable = New PdfPTable(1)
            outerTable.TotalWidth = 160.0F
            outerTable.LockedWidth = True
            outerTable.DefaultCell.Border = Element.RECTANGLE
            Dim outercell = New PdfPCell()
            outercell.BorderWidth = 3.0F
            outercell.PaddingLeft = 2.0F

            Dim table As PdfPTable = New PdfPTable(2)
            table.TotalWidth = 160.0F
            table.LockedWidth = True
            table.DefaultCell.Border = iTextSharp.text.Rectangle.NO_BORDER


            Dim cell = New PdfPCell(New Phrase("Příjemce: ", Font)) With {.Colspan = 2, .Border = iTextSharp.text.Rectangle.NO_BORDER}
            table.AddCell(cell)

            cell = New PdfPCell(New Phrase(zakaznik, FontBold)) With {.Colspan = 2, .Border = iTextSharp.text.Rectangle.NO_BORDER}
            table.AddCell(cell)

            cell = New PdfPCell(New Phrase(dodatek, FontBold)) With {.Colspan = 2, .Border = iTextSharp.text.Rectangle.NO_BORDER}
            table.AddCell(cell)

            cell = New PdfPCell(New Phrase(adresa, FontBold)) With {.Colspan = 2, .Border = iTextSharp.text.Rectangle.NO_BORDER}
            table.AddCell(cell)

            cell = New PdfPCell(New Phrase(psc + " " + mesto, FontBold)) With {.Colspan = 2, .Border = iTextSharp.text.Rectangle.NO_BORDER}
            table.AddCell(cell)

            cell = New PdfPCell(New Phrase("", FontBold)) With {.Colspan = 2, .Border = iTextSharp.text.Rectangle.NO_BORDER}
            table.AddCell(cell)

            cell = New PdfPCell(New Phrase("Tel:", FontBold)) With {.Border = iTextSharp.text.Rectangle.NO_BORDER}
            table.AddCell(cell)

            cell = New PdfPCell(New Phrase(kontakt, FontBold)) With {.HorizontalAlignment = 2, .Border = iTextSharp.text.Rectangle.NO_BORDER}
            table.AddCell(cell)

            outercell.AddElement(table)
            outerTable.AddCell(outercell)


            'pdfDoc.Open()
            Dim cb As PdfContentByte = pdfWrite.DirectContent
            cb.BeginText()
            cb.SetFontAndSize(bf, 9)

            'logo 

            Dim Image As Image = Image.GetInstance(Path.Combine(ServiceWSDL.setting_folder, "bin", "Data", "logo.jpg"))
            Image.ScaleToFit(180, 30)
            Image.SetAbsolutePosition(5, 165)
            cb.AddImage(Image)

            'barcode
            Dim bc As Barcode39 = New Barcode39()
            bc.TextAlignment = Element.ALIGN_CENTER
            bc.StartStopText = False
            'bc.CodeType = Barcode.CODE128
            bc.ChecksumText = False
            bc.GenerateChecksum = False
            bc.Code = cisloZasilky
            bc.Extended = False
            bc.Font = Nothing 'remove text


            Dim bcImage As Image = bc.CreateImageWithBarcode(cb, BaseColor.BLACK, BaseColor.BLACK)
            bcImage.Alignment = ContentAlignment.MiddleCenter
            bcImage.ScaleAbsoluteWidth(150)
            bcImage.ScaleAbsoluteHeight(40)
            'bcImage.ScaleToFit(300, 40)
            bcImage.SetAbsolutePosition(25, 10)
            cb.AddImage(bcImage)


            'notes
            cb.SetTextMatrix(5, 148)
            cb.ShowText("Odesílatel:")

            'sender

            cb.SetTextMatrix(5, 138)
            cb.ShowText("Logistické centrum App")

            cb.SetTextMatrix(5, 125)
            cb.ShowText("PJ App s.r.o.")

            cb.SetTextMatrix(5, 112)
            cb.ShowText("Areál Pragorent (Hala S32)")

            cb.SetTextMatrix(5, 99)
            cb.ShowText("F.V. Veselého")

            cb.SetTextMatrix(5, 86)
            cb.ShowText("193 00 Praha 9")

            cb.SetFontAndSize(bf, 10)
            cb.SetTextMatrix(130, 80)
            cb.ShowText(objednavka)

            cb.SetTextMatrix(230, 80)
            cb.ShowText("*" + cisloZasilky + "*")

            cb.SetFontAndSize(bf, 8)
            'DATA UNDER LINE
            cb.SetTextMatrix(5, 60)
            cb.ShowText("B:" + poradi)

            cb.SetTextMatrix(30, 60)
            cb.ShowText("Ks: " + pocetKusu)

            cb.SetTextMatrix(60, 60)
            cb.ShowText("DL: " + dodaciList)

            cb.SetTextMatrix(130, 60)
            cb.ShowText("REG: " + region)

            cb.SetFontAndSize(bf, 10)
            cb.SetTextMatrix(200, 25)
            cb.ShowText("Dobírka: " + dobirka + ",-")

            'cb.SetFontAndSize(bf, 12)
            'cb.SetTextMatrix(170, 30)
            'cb.ShowText("Dobírka:  " + dobirka)


            'generate label
            outerTable.WriteSelectedRows(0, -1, 130, 198, cb)
            cb.EndText()

            'graphgics
            cb.SetLineWidth(1.5)
            cb.MoveTo(5, 75)
            cb.LineTo(290, 75)
            cb.Stroke()
        Next

        pdfDoc.Close()
        Return m.ToArray()
    End Function


    Function fnTransferSftpToFtp(tmFile, AppFile) As Boolean
        Try

            Dim keyFile = New PrivateKeyFile(Path.Combine(ServiceWSDL.setting_folder, "bin", "Data", "AppSFTPtest.pk8", ""))
            Dim keyFiles = {keyFile}
            Dim ConnectionInfo = New ConnectionInfo("mnpdbt2.App.cz", "22022", "App",
                                         New PrivateKeyAuthenticationMethod("App", keyFile))

            Using client = New SftpClient(ConnectionInfo)
                client.Connect()
                Using fileStream As Stream = File.Create(Path.Combine(ServiceWSDL.setting_folder, "bin", "Data", "Temp", tmFile))
                    client.DownloadFile("/data/outbound/" + tmFile, fileStream)
                End Using
            End Using


            If Not fnFtpUploadFile(Path.Combine(ServiceWSDL.setting_folder, "bin", "Data", "Temp", tmFile), "ftp://10.10.10.3:21/SFTP/IN/" + AppFile, "ftp_user", "spWJv5x9anlwq6564dsa") Then
                Return False
            End If

            'here delete file from local tmp
            fn_delete_file(Path.Combine(ServiceWSDL.setting_folder, "bin", "Data", "Temp", tmFile))

            Return True
        Catch ex As Exception
            fn_WriteToFile(System.IO.Path.Combine(ServiceWSDL.setting_folder, ServiceWSDL.logFile), "sftpTM:" + ex.Message)
            'Trace.WriteLine(ex)
            Return False
        End Try


    End Function

    Function fnFtpUploadFile(ByVal _FileName As String, ByVal _UploadPath As String, ByVal _FTPUser As String, ByVal _FTPPass As String) As Boolean

        Try
            Dim _FileInfo As New System.IO.FileInfo(_FileName)
            Dim _FtpWebRequest As System.Net.FtpWebRequest = CType(System.Net.FtpWebRequest.Create(New Uri(_UploadPath)), System.Net.FtpWebRequest)
            _FtpWebRequest.Credentials = New System.Net.NetworkCredential(_FTPUser, _FTPPass)
            _FtpWebRequest.KeepAlive = False
            _FtpWebRequest.Timeout = 200000
            _FtpWebRequest.Method = System.Net.WebRequestMethods.Ftp.UploadFile
            _FtpWebRequest.UseBinary = True
            _FtpWebRequest.ContentLength = _FileInfo.Length
            Dim buffLength As Integer = 2048
            Dim buff(buffLength - 1) As Byte
            Dim _FileStream As System.IO.FileStream = _FileInfo.OpenRead()

            Dim _Stream As System.IO.Stream = _FtpWebRequest.GetRequestStream()
            Dim contentLen As Integer = _FileStream.Read(buff, 0, buffLength)
            Do While contentLen <> 0
                _Stream.Write(buff, 0, contentLen)
                contentLen = _FileStream.Read(buff, 0, buffLength)
            Loop
            _Stream.Close()
            _Stream.Dispose()
            _FileStream.Close()
            _FileStream.Dispose()

            Return True
        Catch ex As Exception
            fn_WriteToFile(System.IO.Path.Combine(ServiceWSDL.setting_folder, ServiceWSDL.logFile), "sftpApp:" + ex.Message)
            Return False
        End Try
    End Function

    Function fnCallByName_sendDeliveryDocumentRequest(ByRef table As String, ByRef searchedObject As sendDeliveryDocumentRequest, ByRef searchedValue As String, ByRef paramName As String, ByRef paramList As List(Of MySqlParameter)) As List(Of MySqlParameter)
        Dim newParam As MySqlParameter = New MySqlParameter
        Select Case table
            Case "inbound_delivery_h"
                For cycle = 0 To 4
                    If Not String.IsNullOrWhiteSpace(newParam.ParameterName) Then Exit For
                    Try
                        Select Case cycle
                            Case 0
                                If Not String.IsNullOrWhiteSpace(CallByName(searchedObject.data.ZSCMT19C_DELVRY07.IDOC.E1EDL20(0), searchedValue, CallType.Get)) Then
                                    newParam = New MySqlParameter(paramName, CallByName(searchedObject.data.ZSCMT19C_DELVRY07.IDOC.E1EDL20(0), searchedValue, CallType.Get))
                                End If
                            Case 1
                                If Not String.IsNullOrWhiteSpace(CallByName(searchedObject.data.ZSCMT19C_DELVRY07.IDOC.E1EDL20(0).E1EDT13(0), searchedValue, CallType.Get)) Then
                                    newParam = New MySqlParameter(paramName, CallByName(searchedObject.data.ZSCMT19C_DELVRY07.IDOC.E1EDL20(0).E1EDT13(0), searchedValue, CallType.Get))
                                End If
                            Case 2
                                If Not String.IsNullOrWhiteSpace(CallByName(searchedObject.data.ZSCMT19C_DELVRY07.IDOC.E1EDL20(0).E1ADRM1(0), searchedValue, CallType.Get)) Then
                                    newParam = New MySqlParameter(paramName, CallByName(searchedObject.data.ZSCMT19C_DELVRY07.IDOC.E1EDL20(0).E1ADRM1(0), searchedValue, CallType.Get))
                                End If
                            Case 3
                                If Not String.IsNullOrWhiteSpace(CallByName(searchedObject.data.ZSCMT19C_DELVRY07.IDOC.E1EDL20(0).E1EDL21, searchedValue, CallType.Get)) Then
                                    newParam = New MySqlParameter(paramName, CallByName(searchedObject.data.ZSCMT19C_DELVRY07.IDOC.E1EDL20(0).E1EDL21, searchedValue, CallType.Get))
                                End If
                            Case 4
                                If Not String.IsNullOrWhiteSpace(CallByName(searchedObject.data.ZSCMT19C_DELVRY07.IDOC.E1EDL20(0).E1EDL24(0).E1EDL26, searchedValue, CallType.Get)) Then
                                    newParam = New MySqlParameter(paramName, CallByName(searchedObject.data.ZSCMT19C_DELVRY07.IDOC.E1EDL20(0).E1EDL24(0).E1EDL26, searchedValue, CallType.Get))
                                End If
                        End Select
                    Catch
                    End Try
                Next
            Case "inbound_delivery_i"
                For cycle = 0 To 1
                    If Not String.IsNullOrWhiteSpace(newParam.ParameterName) Then Exit For
                    Try
                        Select Case cycle
                            Case 0
                                If Not String.IsNullOrWhiteSpace(CallByName(searchedObject.data.ZSCMT19C_DELVRY07.IDOC.E1EDL20(0).E1EDL24(0), searchedValue, CallType.Get)) Then
                                    newParam = New MySqlParameter(paramName, CallByName(searchedObject.data.ZSCMT19C_DELVRY07.IDOC.E1EDL20(0).E1EDL24(0), searchedValue, CallType.Get))
                                End If
                            Case 1
                                If Not String.IsNullOrWhiteSpace(CallByName(searchedObject.data.ZSCMT19C_DELVRY07.IDOC.E1EDL20(0).E1EDL24(0).E1EDL11(0), searchedValue, CallType.Get)) Then
                                    newParam = New MySqlParameter(paramName, CallByName(searchedObject.data.ZSCMT19C_DELVRY07.IDOC.E1EDL20(0).E1EDL24(0).E1EDL11(0), searchedValue, CallType.Get))
                                End If
                        End Select
                    Catch
                    End Try
                Next
            Case "outbound_delivery_h"
                For cycle = 0 To 4
                    If Not String.IsNullOrWhiteSpace(newParam.ParameterName) Then Exit For
                    Try
                        Select Case cycle
                            Case 0
                                If Not String.IsNullOrWhiteSpace(CallByName(searchedObject.data.ZSCMT19C_DELVRY07.IDOC.E1EDL20(0), searchedValue, CallType.Get)) Then
                                    newParam = New MySqlParameter(paramName, CallByName(searchedObject.data.ZSCMT19C_DELVRY07.IDOC.E1EDL20(0), searchedValue, CallType.Get))
                                End If
                            Case 1
                                If Not String.IsNullOrWhiteSpace(CallByName(searchedObject.data.ZSCMT19C_DELVRY07.IDOC.E1EDL20(0).E1EDL21, searchedValue, CallType.Get)) Then
                                    newParam = New MySqlParameter(paramName, CallByName(searchedObject.data.ZSCMT19C_DELVRY07.IDOC.E1EDL20(0).E1EDL21, searchedValue, CallType.Get))
                                End If
                            Case 2
                                If Not String.IsNullOrWhiteSpace(CallByName(searchedObject.data.ZSCMT19C_DELVRY07.IDOC.E1EDL20(0).E1EDT13(0), searchedValue, CallType.Get)) Then
                                    newParam = New MySqlParameter(paramName, CallByName(searchedObject.data.ZSCMT19C_DELVRY07.IDOC.E1EDL20(0).E1EDT13(0), searchedValue, CallType.Get))
                                End If
                            Case 3
                                If Not String.IsNullOrWhiteSpace(CallByName(searchedObject.data.ZSCMT19C_DELVRY07.IDOC.E1EDL20(0).E1ADRM1(0), searchedValue, CallType.Get)) Then
                                    newParam = New MySqlParameter(paramName, CallByName(searchedObject.data.ZSCMT19C_DELVRY07.IDOC.E1EDL20(0).E1ADRM1(0), searchedValue, CallType.Get))
                                End If
                            Case 4
                                If Not String.IsNullOrWhiteSpace(CallByName(searchedObject.data.ZSCMT19C_DELVRY07.IDOC.E1EDL20(0).E1EDL37(0), searchedValue, CallType.Get)) Then
                                    newParam = New MySqlParameter(paramName, CallByName(searchedObject.data.ZSCMT19C_DELVRY07.IDOC.E1EDL20(0).E1EDL37(0), searchedValue, CallType.Get))
                                End If
                        End Select
                    Catch
                    End Try
                Next
            Case "outbound_delivery_i"
                For cycle = 0 To 7
                    If Not String.IsNullOrWhiteSpace(newParam.ParameterName) Then Exit For
                    Try
                        Select Case cycle
                            Case 0
                                If Not String.IsNullOrWhiteSpace(CallByName(searchedObject.data.ZSCMT19C_DELVRY07.IDOC.E1EDL20(0).E1EDL24(0), searchedValue, CallType.Get)) Then
                                    newParam = New MySqlParameter(paramName, CallByName(searchedObject.data.ZSCMT19C_DELVRY07.IDOC.E1EDL20(0).E1EDL24(0), searchedValue, CallType.Get))
                                End If
                            Case 1
                                If Not String.IsNullOrWhiteSpace(CallByName(searchedObject.data.ZSCMT19C_DELVRY07.IDOC.E1EDL20(0).E1EDL24(0).ZE1EDL98, searchedValue, CallType.Get)) Then
                                    newParam = New MySqlParameter(paramName, CallByName(searchedObject.data.ZSCMT19C_DELVRY07.IDOC.E1EDL20(0).E1EDL24(0).ZE1EDL98, searchedValue, CallType.Get))
                                End If
                            Case 2
                                If Not String.IsNullOrWhiteSpace(CallByName(searchedObject.data.ZSCMT19C_DELVRY07.IDOC.E1EDL20(0).E1EDL24(0).E1EDL11(0), searchedValue, CallType.Get)) Then
                                    newParam = New MySqlParameter(paramName, CallByName(searchedObject.data.ZSCMT19C_DELVRY07.IDOC.E1EDL20(0).E1EDL24(0).E1EDL11(0), searchedValue, CallType.Get))
                                End If
                            Case 3
                                If Not String.IsNullOrWhiteSpace(CallByName(searchedObject.data.ZSCMT19C_DELVRY07.IDOC.E1EDL20(0).E1EDL24(0), searchedValue, CallType.Get)) Then
                                    newParam = New MySqlParameter(paramName, CallByName(searchedObject.data.ZSCMT19C_DELVRY07.IDOC.E1EDL20(0).E1EDL24(0), searchedValue, CallType.Get))
                                End If
                            Case 4
                                If Not String.IsNullOrWhiteSpace(CallByName(searchedObject.data.ZSCMT19C_DELVRY07.IDOC.E1EDL20(0).E1EDL24(0).E1EDL26, searchedValue, CallType.Get)) Then
                                    newParam = New MySqlParameter(paramName, CallByName(searchedObject.data.ZSCMT19C_DELVRY07.IDOC.E1EDL20(0).E1EDL24(0).E1EDL26, searchedValue, CallType.Get))
                                End If
                            Case 5
                                If Not String.IsNullOrWhiteSpace(CallByName(searchedObject.data.ZSCMT19C_DELVRY07.IDOC.E1EDL20(0).E1EDL24(0).ZSCMT19C_E1EDL24(0), searchedValue, CallType.Get)) Then
                                    newParam = New MySqlParameter(paramName, CallByName(searchedObject.data.ZSCMT19C_DELVRY07.IDOC.E1EDL20(0).E1EDL24(0).ZSCMT19C_E1EDL24(0), searchedValue, CallType.Get))
                                End If
                            Case 6
                                If Not String.IsNullOrWhiteSpace(CallByName(searchedObject.data.ZSCMT19C_DELVRY07.IDOC.E1EDL20(0).E1EDL24(0).ZE1EDL98, searchedValue, CallType.Get)) Then
                                    newParam = New MySqlParameter(paramName, CallByName(searchedObject.data.ZSCMT19C_DELVRY07.IDOC.E1EDL20(0).E1EDL24(0).ZE1EDL98, searchedValue, CallType.Get))
                                End If
                            Case 7
                                If Not String.IsNullOrWhiteSpace(CallByName(searchedObject.data.ZSCMT19C_DELVRY07.IDOC.E1EDL20(0).E1EDT13(0), searchedValue, CallType.Get)) Then
                                    newParam = New MySqlParameter(paramName, CallByName(searchedObject.data.ZSCMT19C_DELVRY07.IDOC.E1EDL20(0).E1EDT13(0), searchedValue, CallType.Get))
                                End If
                        End Select
                    Catch
                    End Try
                Next
            Case "delivery_document_h"
                For cycle = 0 To 2
                    If Not String.IsNullOrWhiteSpace(newParam.ParameterName) Then Exit For
                    Try
                        Select Case cycle
                            Case 0
                                If Not String.IsNullOrWhiteSpace(CallByName(searchedObject.data.ZSCMT19C_DELVRY07.IDOC.E1EDL20(0), searchedValue, CallType.Get)) Then
                                    newParam = New MySqlParameter(paramName, CallByName(searchedObject.data.ZSCMT19C_DELVRY07.IDOC.E1EDL20(0), searchedValue, CallType.Get))
                                End If
                            Case 1
                                If Not String.IsNullOrWhiteSpace(CallByName(searchedObject.data.ZSCMT19C_DELVRY07.IDOC.E1EDL20(0).E1ADRM1(0), searchedValue, CallType.Get)) Then
                                    newParam = New MySqlParameter(paramName, CallByName(searchedObject.data.ZSCMT19C_DELVRY07.IDOC.E1EDL20(0).E1ADRM1(0), searchedValue, CallType.Get))
                                End If
                            Case 1
                                If Not String.IsNullOrWhiteSpace(CallByName(searchedObject.data.ZSCMT19C_DELVRY07.IDOC.E1EDL20(0).E1ADRM1(0), searchedValue, CallType.Get)) Then
                                    newParam = New MySqlParameter(paramName, CallByName(searchedObject.data.ZSCMT19C_DELVRY07.IDOC.E1EDL20(0).E1ADRM1(0), searchedValue, CallType.Get))
                                End If
                            Case 2
                                If Not String.IsNullOrWhiteSpace(CallByName(searchedObject.data.ZSCMT19C_DELVRY07.IDOC.E1EDL20(0).E1EDT13(0), searchedValue, CallType.Get)) Then
                                    newParam = New MySqlParameter(paramName, CallByName(searchedObject.data.ZSCMT19C_DELVRY07.IDOC.E1EDL20(0).E1EDT13(0), searchedValue, CallType.Get))
                                End If
                        End Select
                    Catch
                    End Try
                Next
            Case "delivery_document_i"
                For cycle = 0 To 3
                    If Not String.IsNullOrWhiteSpace(newParam.ParameterName) Then Exit For
                    Try
                        Select Case cycle
                            Case 0
                                If Not String.IsNullOrWhiteSpace(CallByName(searchedObject.data.ZSCMT19C_DELVRY07.IDOC.E1EDL20(0).E1EDL24(0), searchedValue, CallType.Get)) Then
                                    newParam = New MySqlParameter(paramName, CallByName(searchedObject.data.ZSCMT19C_DELVRY07.IDOC.E1EDL20(0).E1EDL24(0), searchedValue, CallType.Get))
                                End If
                            Case 1
                                If Not String.IsNullOrWhiteSpace(CallByName(searchedObject.data.ZSCMT19C_DELVRY07.IDOC.E1EDL20(0).E1EDL24(0).E1EDL11(0), searchedValue, CallType.Get)) Then
                                    newParam = New MySqlParameter(paramName, CallByName(searchedObject.data.ZSCMT19C_DELVRY07.IDOC.E1EDL20(0).E1EDL24(0).E1EDL11(0), searchedValue, CallType.Get))
                                End If
                            Case 2
                                If Not String.IsNullOrWhiteSpace(CallByName(searchedObject.data.ZSCMT19C_DELVRY07.IDOC.E1EDL20(0).E1EDL24(0).E1EDL26, searchedValue, CallType.Get)) Then
                                    newParam = New MySqlParameter(paramName, CallByName(searchedObject.data.ZSCMT19C_DELVRY07.IDOC.E1EDL20(0).E1EDL24(0).E1EDL26, searchedValue, CallType.Get))
                                End If
                            Case 3
                                If Not String.IsNullOrWhiteSpace(CallByName(searchedObject.data.ZSCMT19C_DELVRY07.IDOC.E1EDL20(0).E1EDL21, searchedValue, CallType.Get)) Then
                                    newParam = New MySqlParameter(paramName, CallByName(searchedObject.data.ZSCMT19C_DELVRY07.IDOC.E1EDL20(0).E1EDL21, searchedValue, CallType.Get))
                                End If
                        End Select
                    Catch
                    End Try
                Next
        End Select

        If String.IsNullOrWhiteSpace(newParam.ParameterName) Then
            newParam = New MySqlParameter(paramName, "")
            paramList.Add(newParam)
            Return paramList
        Else
            paramList.Add(newParam)
            Return paramList
        End If
    End Function

    Function fnCallByName_sendGoodsMovementRequest(ByRef table As String, ByRef searchedObject As sendGoodsMovementRequest, ByRef searchedValue As String, ByRef paramName As String, ByRef paramList As List(Of MySqlParameter)) As List(Of MySqlParameter)
        Dim newParam As MySqlParameter = New MySqlParameter

        Select Case table
            Case "goods_movement_h"
                For cycle = 0 To 1
                    If Not String.IsNullOrWhiteSpace(newParam.ParameterName) Then Exit For
                    Try
                        Select Case cycle
                            Case 0
                                If Not String.IsNullOrWhiteSpace(CallByName(searchedObject.data.sendGoodsMovement.IDOC.E1MBGMCR.E1BP2017_GM_HEAD_01, searchedValue, CallType.Get)) Then
                                    newParam = New MySqlParameter(paramName, CallByName(searchedObject.data.sendGoodsMovement.IDOC.E1MBGMCR.E1BP2017_GM_HEAD_01, searchedValue, CallType.Get))
                                End If
                            Case 1
                                If Not String.IsNullOrWhiteSpace(CallByName(searchedObject.data.sendGoodsMovement.IDOC.E1MBGMCR.E1BP2017_GM_CODE, searchedValue, CallType.Get)) Then
                                    newParam = New MySqlParameter(paramName, CallByName(searchedObject.data.sendGoodsMovement.IDOC.E1MBGMCR.E1BP2017_GM_CODE, searchedValue, CallType.Get))
                                End If
                        End Select
                    Catch
                    End Try
                Next
            Case "goods_movement_i"
                For cycle = 0 To 1
                    If Not String.IsNullOrWhiteSpace(newParam.ParameterName) Then Exit For
                    Try
                        Select Case cycle
                            Case 0
                                If Not String.IsNullOrWhiteSpace(CallByName(searchedObject.data.sendGoodsMovement.IDOC.E1MBGMCR.E1BP2017_GM_ITEM_CREATE(0), searchedValue, CallType.Get)) Then
                                    newParam = New MySqlParameter(paramName, CallByName(searchedObject.data.sendGoodsMovement.IDOC.E1MBGMCR.E1BP2017_GM_ITEM_CREATE(0), searchedValue, CallType.Get))
                                End If
                            Case 1
                                If Not String.IsNullOrWhiteSpace(CallByName(searchedObject.data.sendGoodsMovement.IDOC.E1MBGMCR.E1BP2017_GM_SERIALNUMBER(0), searchedValue, CallType.Get)) Then
                                    newParam = New MySqlParameter(paramName, CallByName(searchedObject.data.sendGoodsMovement.IDOC.E1MBGMCR.E1BP2017_GM_SERIALNUMBER(0), searchedValue, CallType.Get))
                                End If
                        End Select
                    Catch
                    End Try
                Next
        End Select

        If String.IsNullOrWhiteSpace(newParam.ParameterName) Then
            newParam = New MySqlParameter(paramName, "")
            paramList.Add(newParam)
            Return paramList
        Else
            paramList.Add(newParam)
            Return paramList
        End If
    End Function

    Function fnCallByName_sendPostingToDeliveriesRequest(ByRef table As String, ByRef searchedObject As sendPostingToDeliveriesRequest, ByRef searchedValue As String, ByRef paramName As String, ByRef paramList As List(Of MySqlParameter)) As List(Of MySqlParameter)
        Dim newParam As MySqlParameter = New MySqlParameter

        Select Case table
            Case "goods_issue_receive_h"
                For cycle = 0 To 3
                    If Not String.IsNullOrWhiteSpace(newParam.ParameterName) Then Exit For
                    Try
                        Select Case cycle
                            Case 0
                                If Not String.IsNullOrWhiteSpace(CallByName(searchedObject.data.ZSCMT19C_DELVRY03.IDOC.E1EDL20(0), searchedValue, CallType.Get)) Then
                                    newParam = New MySqlParameter(paramName, CallByName(searchedObject.data.ZSCMT19C_DELVRY03.IDOC.E1EDL20(0), searchedValue, CallType.Get))
                                End If
                            Case 1
                                If Not (paramName = "TYP_DATUMU" And searchedValue = "QUALF") Then
                                    If Not String.IsNullOrWhiteSpace(CallByName(searchedObject.data.ZSCMT19C_DELVRY03.IDOC.E1EDL20(0).E1EDL18(0), searchedValue, CallType.Get)) Then
                                        newParam = New MySqlParameter(paramName, CallByName(searchedObject.data.ZSCMT19C_DELVRY03.IDOC.E1EDL20(0).E1EDL18(0), searchedValue, CallType.Get))
                                    End If
                                End If
                            Case 2
                                If Not (paramName = "IDOC_QUALF" And searchedValue = "QUALF") Then
                                    If Not String.IsNullOrWhiteSpace(CallByName(searchedObject.data.ZSCMT19C_DELVRY03.IDOC.E1EDL20(0).E1EDT13(0), searchedValue, CallType.Get)) Then
                                        newParam = New MySqlParameter(paramName, CallByName(searchedObject.data.ZSCMT19C_DELVRY03.IDOC.E1EDL20(0).E1EDT13(0), searchedValue, CallType.Get))
                                    End If
                                End If
                            Case 3
                                If Not String.IsNullOrWhiteSpace(CallByName(searchedObject.data.ZSCMT19C_DELVRY03.IDOC.E1EDL20(0).E1EDL24(0).ZE1EDL98, searchedValue, CallType.Get)) Then
                                    newParam = New MySqlParameter(paramName, CallByName(searchedObject.data.ZSCMT19C_DELVRY03.IDOC.E1EDL20(0).E1EDL24(0).ZE1EDL98, searchedValue, CallType.Get))
                                End If
                        End Select
                    Catch
                    End Try
                Next
            Case "goods_issue_receive_i"
                For cycle = 0 To 2
                    If Not String.IsNullOrWhiteSpace(newParam.ParameterName) Then Exit For
                    Try
                        Select Case cycle
                            Case 0
                                If Not String.IsNullOrWhiteSpace(CallByName(searchedObject.data.ZSCMT19C_DELVRY03.IDOC.E1EDL20(0).E1EDL24(0), searchedValue, CallType.Get)) Then
                                    newParam = New MySqlParameter(paramName, CallByName(searchedObject.data.ZSCMT19C_DELVRY03.IDOC.E1EDL20(0).E1EDL24(0), searchedValue, CallType.Get))
                                End If
                            Case 1
                                If Not String.IsNullOrWhiteSpace(CallByName(searchedObject.data.ZSCMT19C_DELVRY03.IDOC.E1EDL20(0).E1EDL24(0).ZE1EDL98, searchedValue, CallType.Get)) Then
                                    newParam = New MySqlParameter(paramName, CallByName(searchedObject.data.ZSCMT19C_DELVRY03.IDOC.E1EDL20(0).E1EDL24(0).ZE1EDL98, searchedValue, CallType.Get))
                                End If
                            Case 2
                                If Not String.IsNullOrWhiteSpace(CallByName(searchedObject.data.ZSCMT19C_DELVRY03.IDOC.E1EDL20(0).E1EDL24(0).E1EDL11(0), searchedValue, CallType.Get)) Then
                                    newParam = New MySqlParameter(paramName, CallByName(searchedObject.data.ZSCMT19C_DELVRY03.IDOC.E1EDL20(0).E1EDL24(0).E1EDL11(0), searchedValue, CallType.Get))
                                End If
                        End Select
                    Catch
                    End Try
                Next
        End Select

        If String.IsNullOrWhiteSpace(newParam.ParameterName) Then
            newParam = New MySqlParameter(paramName, "")
            paramList.Add(newParam)
            Return paramList
        Else
            paramList.Add(newParam)
            Return paramList
        End If
    End Function

    Function fnCallByName_createOrChangeMaterialRequest(ByRef table As String, ByRef searchedObject As createOrChangeMaterialRequest, ByRef searchedValue As String, ByRef paramName As String, ByRef paramList As List(Of MySqlParameter)) As List(Of MySqlParameter)
        Dim newParam As MySqlParameter = New MySqlParameter
        Select Case table
            Case "ciselnik_materialu"
                For cycle = 0 To 1
                    If Not String.IsNullOrWhiteSpace(newParam.ParameterName) Then Exit For
                    Try
                        Select Case cycle
                            Case 0
                                If Not String.IsNullOrWhiteSpace(CallByName(searchedObject.data.createOrChangeMaterial(0).E1MARAM(0), searchedValue, CallType.Get)) Then
                                    newParam = New MySqlParameter(paramName, CallByName(searchedObject.data.createOrChangeMaterial(0).E1MARAM(0), searchedValue, CallType.Get))
                                End If
                            Case 1
                                If Not String.IsNullOrWhiteSpace(CallByName(searchedObject.data.createOrChangeMaterial(0).E1MARAM(0).E1MAKTM(0), searchedValue, CallType.Get)) Then
                                    newParam = New MySqlParameter(paramName, CallByName(searchedObject.data.createOrChangeMaterial(0).E1MARAM(0).E1MAKTM(0), searchedValue, CallType.Get))
                                End If
                        End Select
                    Catch
                    End Try
                Next
        End Select

        If String.IsNullOrWhiteSpace(newParam.ParameterName) Then
            newParam = New MySqlParameter(paramName, "")
            paramList.Add(newParam)
            Return paramList
        Else
            paramList.Add(newParam)
            Return paramList
        End If
    End Function

    Function fnCallByName_requestCourierDelivery(ByRef table As String, ByRef searchedObject As requestCourierDeliveryRequest1, ByRef searchedValue As String, ByRef paramName As String, ByRef paramList As List(Of MySqlParameter)) As List(Of MySqlParameter)
        Dim newParam As MySqlParameter = New MySqlParameter

        Select Case table
            Case "esign_import"
                For cycle = 0 To 1
                    If Not String.IsNullOrWhiteSpace(newParam.ParameterName) Then Exit For
                    Try
                        'If Not String.IsNullOrWhiteSpace(CallByName(searchedObject.context.technicalContext, searchedValue, CallType.Get)) Then
                        '    newParam = New MySqlParameter(paramName, CallByName(searchedObject.context.technicalContext, searchedValue, CallType.Get))
                        'End If
                        If paramName.Contains("CUSTOMER_") Then
                            For Each child In searchedObject.requestCourierDeliveryIn.Body.customer().GetType().GetProperties()
                                If child.Name = searchedValue Then
                                    newParam = New MySqlParameter(paramName, CallByName(searchedObject.requestCourierDeliveryIn.Body.customer(), child.Name, CallType.Get))
                                    Exit For
                                End If
                            Next child
                        ElseIf paramName.Contains("ADDRESS_") Then
                            For Each child In searchedObject.requestCourierDeliveryIn.Body.customer.addresses(0).GetType().GetProperties()
                                If child.Name = searchedValue Then
                                    newParam = New MySqlParameter(paramName, CallByName(searchedObject.requestCourierDeliveryIn.Body.customer.addresses(0), child.Name, CallType.Get))
                                    Exit For
                                End If
                            Next child
                        ElseIf paramName.Contains("PERSONAL_") Then
                            For Each child In searchedObject.requestCourierDeliveryIn.Body.GetType().GetProperties()
                                If child.Name = searchedValue Then
                                    newParam = New MySqlParameter(paramName, CallByName(searchedObject.requestCourierDeliveryIn.Body, child.Name, CallType.Get))
                                    Exit For
                                End If
                            Next child
                        ElseIf paramName.Contains("PACKAGE_") AndAlso paramName <> "PACKAGE_COUNT" Then
                            For Each package In searchedObject.requestCourierDeliveryIn.Body.packages
                                If CType(package.packageId, Int32) = 1 Then
                                    For Each child In package.GetType().GetProperties()
                                        If child.Name = searchedValue Then
                                            newParam = New MySqlParameter(paramName, CallByName(package, child.Name, CallType.Get))
                                            Exit For
                                        End If
                                    Next child
                                    Exit For
                                End If
                            Next package
                        ElseIf paramName.Contains("PAYMENTS_") Then
                            For Each payment In searchedObject.requestCourierDeliveryIn.Body.payments
                                If CType(payment.packageId, Int32) = 1 Then
                                    For Each child In payment.GetType().GetProperties()
                                        If child.Name = searchedValue Then
                                            newParam = New MySqlParameter(paramName, CallByName(payment, child.Name, CallType.Get))
                                            Exit For
                                        End If
                                    Next child
                                    Exit For
                                End If
                            Next payment
                        ElseIf paramName.Contains("SERVICES_") Then
                            For Each child In searchedObject.requestCourierDeliveryIn.Body.courierServices(0).GetType().GetProperties()
                                If child.Name = searchedValue Then
                                    newParam = New MySqlParameter(paramName, CallByName(searchedObject.requestCourierDeliveryIn.Body.courierServices(0), child.Name, CallType.Get))
                                    Exit For
                                End If
                            Next child
                        Else
                            For Each child In searchedObject.requestCourierDeliveryIn.Body.GetType().GetProperties()
                                If child.Name = searchedValue Then
                                    newParam = New MySqlParameter(paramName, CallByName(searchedObject.requestCourierDeliveryIn.Body, child.Name, CallType.Get))
                                    Exit For
                                End If
                            Next child
                        End If
                        If String.IsNullOrWhiteSpace(newParam.ParameterName) Then
                            For Each child In searchedObject.requestCourierDeliveryIn.GetType().GetProperties()
                                If child.Name = searchedValue Then
                                    newParam = New MySqlParameter(paramName, CallByName(searchedObject.requestCourierDeliveryIn, child.Name, CallType.Get))
                                    Exit For
                                End If
                            Next child
                        End If
                    Catch
                    End Try
                Next
        End Select

        If String.IsNullOrWhiteSpace(newParam.ParameterName) Then
            newParam = New MySqlParameter(paramName, "")
            paramList.Add(newParam)
            Return paramList
        Else
            paramList.Add(newParam)
            Return paramList
        End If
    End Function

    Function fnCallByName_requestCourierLabel(ByRef table As String, ByRef searchedObject As requestCourierLabelRequest1, ByRef searchedValue As String, ByRef paramName As String, ByRef paramList As List(Of MySqlParameter)) As List(Of MySqlParameter)
        Dim newParam As MySqlParameter = New MySqlParameter

        Select Case table
            Case "esign_request_label"
                For cycle = 0 To 1
                    If Not String.IsNullOrWhiteSpace(newParam.ParameterName) Then Exit For
                    Try
                        If paramName.Contains("_ID") Then
                            For Each child In searchedObject.requestCourierLabelIn.GetType().GetProperties()
                                If child.Name = paramName.ToLower().Replace("_id", "Id") Then
                                    newParam = New MySqlParameter(paramName, CallByName(searchedObject.requestCourierLabelIn, child.Name, CallType.Get))
                                    Exit For
                                End If
                            Next child

                            For Each child In searchedObject.requestCourierLabelIn.Body.GetType().GetProperties()
                                If child.Name = paramName.ToLower().Replace("_id", "Id") Then
                                    newParam = New MySqlParameter(paramName, CallByName(searchedObject.requestCourierLabelIn.Body, child.Name, CallType.Get))
                                    Exit For
                                End If
                            Next child
                        Else
                            For Each child In searchedObject.requestCourierLabelIn.GetType().GetProperties()
                                If child.Name = paramName.ToLower() Then
                                    newParam = New MySqlParameter(paramName, CallByName(searchedObject.requestCourierLabelIn, child.Name, CallType.Get))
                                    Exit For
                                End If
                            Next child
                        End If
                    Catch
                    End Try
                Next
        End Select

        If String.IsNullOrWhiteSpace(newParam.ParameterName) Then
            newParam = New MySqlParameter(paramName, "")
            paramList.Add(newParam)
            Return paramList
        Else
            paramList.Add(newParam)
            Return paramList
        End If
    End Function

    Function fnCallByName_deliveryDocumentsNotify(ByRef table As String, ByRef searchedObject As deliveryDocumentsNotifyRequest1, ByRef searchedValue As String, ByRef paramName As String, ByRef paramList As List(Of MySqlParameter)) As List(Of MySqlParameter)
        Dim newParam As MySqlParameter = New MySqlParameter

        Select Case table
            Case "esign_docs_notify"
                For cycle = 0 To 1
                    If Not String.IsNullOrWhiteSpace(newParam.ParameterName) Then Exit For
                    Try
                        If paramName.Contains("_ID") Then
                            For Each child In searchedObject.deliveryDocumentsNotifyIn.GetType().GetProperties()
                                If child.Name = paramName.ToLower().Replace("_id", "Id") Then
                                    newParam = New MySqlParameter(paramName, CallByName(searchedObject.deliveryDocumentsNotifyIn, child.Name, CallType.Get))
                                    Exit For
                                End If
                            Next child

                            For Each child In searchedObject.deliveryDocumentsNotifyIn.Body.GetType().GetProperties()
                                If child.Name = paramName.ToLower().Replace("_id", "Id").Replace("_delivery", "Delivery") Then
                                    newParam = New MySqlParameter(paramName, CallByName(searchedObject.deliveryDocumentsNotifyIn.Body, child.Name, CallType.Get))
                                    Exit For
                                End If
                            Next child
                        Else
                            For Each child In searchedObject.deliveryDocumentsNotifyIn.GetType().GetProperties()
                                If child.Name = paramName.ToLower() Then
                                    newParam = New MySqlParameter(paramName, CallByName(searchedObject.deliveryDocumentsNotifyIn, child.Name, CallType.Get))
                                    Exit For
                                End If
                            Next child
                        End If
                    Catch
                    End Try
                Next
        End Select

        If String.IsNullOrWhiteSpace(newParam.ParameterName) Then
            newParam = New MySqlParameter(paramName, "")
            paramList.Add(newParam)
            Return paramList
        Else
            paramList.Add(newParam)
            Return paramList
        End If
    End Function

    Function fnCallByName_courierDeliveryStatus(ByRef table As String, ByRef searchedObject As courierDeliveryStatusRequest, ByRef searchedValue As String, ByRef paramName As String, ByRef paramList As List(Of MySqlParameter)) As List(Of MySqlParameter)
        Dim newParam As MySqlParameter = New MySqlParameter

        Select Case table
            Case "esign_docs_notify"
                For cycle = 0 To 1
                    If Not String.IsNullOrWhiteSpace(newParam.ParameterName) Then Exit For
                    Try
                        If paramName.Contains("_ID") Then
                            For Each child In searchedObject.courierDeliveryStatus.GetType().GetProperties()
                                If child.Name = paramName.ToLower().Replace("_id", "Id") Then
                                    newParam = New MySqlParameter(paramName, CallByName(searchedObject.courierDeliveryStatus, child.Name, CallType.Get))
                                    Exit For
                                End If
                            Next child
                        Else
                            For Each child In searchedObject.courierDeliveryStatus.GetType().GetProperties()
                                If child.Name = paramName.ToLower() Then
                                    newParam = New MySqlParameter(paramName, CallByName(searchedObject.courierDeliveryStatus, child.Name, CallType.Get))
                                    Exit For
                                End If
                            Next child
                        End If
                    Catch
                    End Try
                Next
        End Select

        If String.IsNullOrWhiteSpace(newParam.ParameterName) Then
            newParam = New MySqlParameter(paramName, "")
            paramList.Add(newParam)
            Return paramList
        Else
            paramList.Add(newParam)
            Return paramList
        End If
    End Function


    Function fn_GetTCContextNodeValue(ByRef searchedObject As schemas.telekom.net.csdg_v01._01.TCContext, ByRef searchedValue As String) As String
        Dim foundedNodeValue As String = ""
        For Each child As XmlNode In searchedObject.technicalContext.Nodes
            If child.LocalName = searchedValue Then
                foundedNodeValue = child.InnerText
            End If
        Next child
        Return foundedNodeValue
    End Function

    Function fnCallByName_StockRequest(ByRef table As String, ByRef searchedObject As StockRequestService.stockRequest, ByRef searchedValue As String, ByRef paramName As String, ByRef recNo As Double, ByRef paramList As List(Of MySqlParameter)) As List(Of MySqlParameter)
        Dim newParam As MySqlParameter = New MySqlParameter
        Dim counter As Double = 0
        Select Case table
            Case "stock_request_h"
                If Not String.IsNullOrWhiteSpace(newParam.ParameterName) Then Exit Select
                Try
                    'If Not String.IsNullOrWhiteSpace(CallByName(searchedObject.context.technicalContext, searchedValue, CallType.Get)) Then
                    '    newParam = New MySqlParameter(paramName, CallByName(searchedObject.context.technicalContext, searchedValue, CallType.Get))
                    'End If
                    For Each child As XmlNode In searchedObject.context.technicalContext.Nodes
                        If child.LocalName = searchedValue Then
                            newParam = New MySqlParameter(paramName, child.InnerText)
                        End If
                    Next child
                Catch
                End Try
            Case "stock_request_i"
                If Not String.IsNullOrWhiteSpace(newParam.ParameterName) Then Exit Select
                For Each child In searchedObject.data.ToArray
                    Try
                        If counter = recNo Then
                            If Not String.IsNullOrWhiteSpace(CallByName(child, searchedValue, CallType.Get)) Then
                                newParam = New MySqlParameter(paramName, CallByName(child, searchedValue, CallType.Get))
                            End If
                        End If
                        counter += 1
                    Catch
                        counter += 1
                    End Try
                Next child
        End Select

        If String.IsNullOrWhiteSpace(newParam.ParameterName) Then
            newParam = New MySqlParameter(paramName, "")
            paramList.Add(newParam)
            Return paramList
        Else
            paramList.Add(newParam)
            Return paramList
        End If
    End Function


    'Function getMySqlLastIdSharp() As Double 'ByVal table As String
    '    Dim conStrMysql = New MySqlConnection()
    '    conStrMysql.ConnectionString = WebConfigurationManager.ConnectionStrings("SHARPCONN").ConnectionString
    '    conStrMysql.Open()
    '    Dim lastId = MySqlHelper.ExecuteScalar(conStrMysql, "SELECT LAST_INSERT_ID();")
    '    conStrMysql.Close()
    '    Return lastId
    'End Function

    'Function getMySqlLastId() As Double
    '    Dim conStrMysql = New MySqlConnection()
    '    conStrMysql.ConnectionString = WebConfigurationManager.ConnectionStrings("SHARPCONN").ConnectionString
    '    conStrMysql.Open()
    '    Dim lastId = MySqlHelper.ExecuteScalar(conStrMysql, "SELECT LAST_INSERT_ID();")
    '    conStrMysql.Close()
    '    Return lastId
    'End Function

    Function fn_save_to_import(ByRef searchedObject As requestCourierDeliveryRequest1, ByVal lastId As String, ByVal persIdScan As Boolean) As Boolean
        Dim conStrMysql = New MySqlConnection()
        conStrMysql.ConnectionString = WebConfigurationManager.ConnectionStrings("SHARPCONN").ConnectionString

        Dim davka = "", zasilka = ""
        Dim DTEmpDet = New DataSet()
        Dim arrParameters As New List(Of MySqlParameter)
        Dim selectedTable = "pravidla_wsdl_db"
        Dim foundedValue = ""
        Dim steps As Integer = 0
        Dim lgFile = ""
        Dim TvPackage = False


        Try
            conStrMysql.Open()
            DTEmpDet = MySqlHelper.ExecuteDataset(conStrMysql, String.Format("select WSDL from " + selectedTable + " where typ = 'import' ORDER BY DB ASC"))
            DTEmpDet.Tables(0).TableName = selectedTable

            Dim searchedType = fnSearchByName_requestCourierDelivery(searchedObject, "PACKAGE_DELIVERY_TYPE")
            Dim ValueType = fnSearchByName_requestCourierDelivery(searchedObject, "SERVICES_VALUE")
            Dim Prolong = If(fnSearchByName_requestCourierDelivery(searchedObject, "DELIVERY_CONTENT").ToLower().Contains("doc") And persIdScan = False, "PROLONG_", "")
            Try
                TvPackage = If(fnSearchByName_requestCourierDelivery(searchedObject, "ADDRESS_NOTE").ToLower().Contains("*tv*"), True, False)
            Catch ex As Exception
            End Try

            Try
                If (TvPackage = False) Then
                    TvPackage = If(fnSearchByName_requestCourierDelivery(searchedObject, "OVERSIZEDPACKAGE").ToLower() = "y", True, False)
                End If
            Catch ex As Exception
            End Try

            If TvPackage And searchedType <> "HOME-DELIVERY B2C" And persIdScan = True Then
                davka = "ESH_TV_" + ValueType + "_WSDL_"
            ElseIf TvPackage And searchedType = "HOME-DELIVERY B2C" Then
                davka = "ESH_HD_TV_" + ValueType + "_WSDL_"
            ElseIf TvPackage And persIdScan = False And searchedType <> "HOME-DELIVERY B2C" Then
                davka = "ESH_" + Prolong + "TV" + ValueType + "_WSDL_"
            ElseIf fnSearchByName_requestCourierDelivery(searchedObject, "SIGNATURE_TYPE") = "E" And fnSearchByName_requestCourierDelivery(searchedObject, "DELIVERY_CONTENT") = "docsOnly" Then
                davka = "ESH_ESIGN_" + ValueType + "_WSDL_"
            ElseIf searchedType = "HOME-DELIVERY B2C" Then
                davka = "ESH_HD_" + ValueType + "_WSDL_"
            ElseIf searchedType = "eContract" Then
                davka = "ESH_ECON_" + ValueType + "_WSDL_"
            ElseIf searchedType = "Standard DZ" Then
                davka = "ESH_" + Prolong + "DZ_" + ValueType + "_WSDL_"
            ElseIf searchedType = "doprava B2B" Then
                davka = "KA_WSDL_"
            End If
            davka += lastId

            If Not String.IsNullOrWhiteSpace(DTEmpDet.ToString) Then
                For Each dtRow As DataRow In DTEmpDet.Tables(0).Rows
                    If dtRow.ItemArray(0).ToString().Length = 0 Then

                    ElseIf dtRow.ItemArray(0).ToString().Length = 1 Then
                        zasilka += dtRow.ItemArray(0).ToString()
                    ElseIf dtRow.ItemArray(0).ToString() = "YYYYMMDD" Then
                        zasilka += DateTime.Now.ToString("yyyyMMdd")
                    Else
                        If dtRow.ItemArray(0).ToString() = "PERSONALIDSCAN" Then
                            foundedValue = fnSearchByName_requestCourierDelivery(searchedObject, dtRow.ItemArray(0).ToString())
                            foundedValue = If(CType(foundedValue, Boolean), 1, 0)
                        Else
                            foundedValue = fnSearchByName_requestCourierDelivery(searchedObject, dtRow.ItemArray(0).ToString())
                        End If
                        zasilka += foundedValue
                    End If
                    zasilka += ";"

                Next
            End If
            conStrMysql.Close()
        Catch ex As Exception
            conStrMysql.Close()
            fn_WriteToFile(Path.Combine(ServiceWSDL.setting_folder, "logfile" + DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss") + "_" + CInt(Int((9999 * Rnd()) + 1)).ToString() + ".log"), ex.Message)
        End Try

        Try
            conStrMysql.Open()
            fn_WriteToFile(Path.Combine(ServiceWSDL.setting_folder, "logfile" + DateTime.Now.ToString("yyyyMMddThhmmss") + "_" + CInt(Int((9999 * Rnd()) + 1)).ToString() + ".log"), "START TRANSACTION;INSERT INTO `zasilky_temp_upload` (`DAVKA`,`ID_IMPORT`,`ZASILKA`,`UZIVATEL`) VALUES ('" + davka + "'," + lastId + ",'" + zasilka + "','66');COMMIT;")
            MySqlHelper.ExecuteReader(conStrMysql, String.Format("START TRANSACTION;INSERT INTO `zasilky_temp_upload` (`DAVKA`,`ID_IMPORT`,`ZASILKA`,`UZIVATEL`) VALUES ('" + davka + "'," + lastId + ",'" + zasilka + "','66');COMMIT;"))
            conStrMysql.Close()
        Catch ex As Exception
            conStrMysql.Close()
            If Not fn_check_file(Path.Combine(ServiceWSDL.setting_folder, "logfile" + DateTime.Now.ToString("yyyyMMddThhmmss") + "_" + CInt(Int((9999 * Rnd()) + 1)).ToString() + ".log")) Then
                fn_WriteToFile(Path.Combine(ServiceWSDL.setting_folder, "logfile" + DateTime.Now.ToString("yyyyMMddThhmmss") + "_" + CInt(Int((9999 * Rnd()) + 1)).ToString() + ".log"), ex.Message)
            End If

        End Try '

    End Function


    Function fnSearchByName_requestCourierDelivery(ByRef searchedObject As requestCourierDeliveryRequest1, ByRef paramName As String) As String
        Dim result As String = Nothing
        Dim paramCount = 0
        Dim firstName = Nothing
        Dim lastName = Nothing

        Try
            For cycle = 0 To 1
                If Not String.IsNullOrWhiteSpace(result) Then Exit For

                Try
                    If paramName.Contains("CUSTOMER_") And paramName.Split(" ").Length = 1 And Not paramName.Contains("|") Then
                        For Each child In searchedObject.requestCourierDeliveryIn.Body.customer().GetType().GetProperties()
                            If child.Name.ToLower = paramName.Replace("CUSTOMER_", "").Replace("_", "").ToLower Then
                                result = CallByName(searchedObject.requestCourierDeliveryIn.Body.customer(), child.Name, CallType.Get)
                                Exit For
                            End If
                        Next child
                    ElseIf paramName.Contains("CUSTOMER_") And paramName.Split(" ").Length = 1 And paramName.Contains("|") Then
                        For paramCount = 0 To paramName.Split("|").Length
                            For Each child In searchedObject.requestCourierDeliveryIn.Body.customer().GetType().GetProperties()
                                If child.Name.ToLower = paramName.Split("|")(paramCount).Replace("CUSTOMER_", "").Replace("_", "").ToLower Then
                                    result = CallByName(searchedObject.requestCourierDeliveryIn.Body.customer(), child.Name, CallType.Get)
                                    Exit For
                                End If
                            Next child
                            If Not String.IsNullOrWhiteSpace(result) Then Exit For
                        Next
                    ElseIf paramName.Contains("CUSTOMER_") And paramName.Split(" ").Length > 1 Then
                        For paramCount = 0 To paramName.Split(" ").Length
                            For Each child In searchedObject.requestCourierDeliveryIn.Body.customer().GetType().GetProperties()
                                If child.Name.ToLower = paramName.Split(" ")(paramCount).Replace("CUSTOMER_", "").Replace("_", "").ToLower Then
                                    If child.Name.ToLower = "firstname" Then
                                        firstName = CallByName(searchedObject.requestCourierDeliveryIn.Body.customer(), child.Name, CallType.Get)
                                        result += " " + firstName
                                    ElseIf child.Name.ToLower = "lastname" Then
                                        lastName = CallByName(searchedObject.requestCourierDeliveryIn.Body.customer(), child.Name, CallType.Get)
                                        result += lastName
                                    Else
                                        result += CallByName(searchedObject.requestCourierDeliveryIn.Body.customer(), child.Name, CallType.Get)
                                    End If
                                    'result += CallByName(searchedObject.requestCourierDeliveryIn.Body.customer(), child.Name, CallType.Get)
                                    Exit For
                                End If
                            Next child
                        Next
                    ElseIf paramName.Contains("ADDRESS_") And paramName.Replace(" / ", " ").Split(" ").Length = 1 Then
                        For Each child In searchedObject.requestCourierDeliveryIn.Body.customer.addresses(0).GetType().GetProperties()
                            If child.Name.ToLower = paramName.Replace("ADDRESS_", "").Replace("_", "").ToLower Then
                                result = CallByName(searchedObject.requestCourierDeliveryIn.Body.customer.addresses(0), child.Name, CallType.Get)

                                'If child.Name.ToLower = "note" Then
                                '    For Each subchild In searchedObject.requestCourierDeliveryIn.Body.customer().GetType().GetProperties()
                                '        If subchild.Name.ToLower = "firstname" Then
                                '            firstName = CallByName(searchedObject.requestCourierDeliveryIn.Body.customer(), subchild.Name, CallType.Get)
                                '        End If
                                '        If subchild.Name.ToLower = "lastname" Then
                                '            lastName = CallByName(searchedObject.requestCourierDeliveryIn.Body.customer(), subchild.Name, CallType.Get)
                                '        End If
                                '    Next subchild
                                '    If firstName <> lastName Then result += " " + firstName

                                'End If
                                Exit For
                            End If
                        Next child
                    ElseIf paramName.Contains("ADDRESS_") And paramName.Replace(" / ", " ").Split(" ").Length > 1 Then
                        Dim prevValue As String = Nothing
                        For paramCount = 0 To paramName.Replace("/ ", " ").Split(" ").Length
                            For Each child In searchedObject.requestCourierDeliveryIn.Body.customer.addresses(0).GetType().GetProperties()
                                If child.Name.ToLower = paramName.Replace("/ ", " ").Split(" ")(paramCount).Replace("ADDRESS_", "").Replace("_", "").ToLower Then

                                    If paramCount = 3 And Not String.IsNullOrWhiteSpace(prevValue) And Not String.IsNullOrWhiteSpace(CallByName(searchedObject.requestCourierDeliveryIn.Body.customer.addresses(0), child.Name, CallType.Get)) Then result += " / "

                                    result += CallByName(searchedObject.requestCourierDeliveryIn.Body.customer.addresses(0), child.Name, CallType.Get)
                                    prevValue = CallByName(searchedObject.requestCourierDeliveryIn.Body.customer.addresses(0), child.Name, CallType.Get)

                                    If paramCount = 0 Then result += " "
                                    Exit For
                                End If
                            Next child

                        Next
                    ElseIf paramName.Contains("PERSONAL_") Then
                        For Each child In searchedObject.requestCourierDeliveryIn.Body.GetType().GetProperties()
                            If child.Name.ToLower = paramName.Replace("PERSONAL_", "").Replace("_", "").ToLower Then
                                result = CallByName(searchedObject.requestCourierDeliveryIn.Body, child.Name, CallType.Get)
                                Exit For
                            End If
                        Next child
                    ElseIf paramName.Contains("PACKAGE_") AndAlso paramName <> "PACKAGE_COUNT" And Not paramName.Contains("PACKAGE_WEIGHT_") Then
                        For Each package In searchedObject.requestCourierDeliveryIn.Body.packages
                            If CType(package.packageId, Int32) = 1 Then
                                For Each child In package.GetType().GetProperties()
                                    If child.Name.ToLower = paramName.Replace("PACKAGE_", "").Replace("_", "").ToLower Then
                                        result = CallByName(package, child.Name, CallType.Get)
                                        Exit For
                                    End If
                                Next child
                                Exit For
                            End If
                        Next package
                    ElseIf paramName.Contains("PACKAGE_") AndAlso paramName <> "PACKAGE_COUNT" And paramName.Contains("PACKAGE_WEIGHT_") Then
                        For Each package In searchedObject.requestCourierDeliveryIn.Body.packages
                            If CType(package.packageId, Int32) = paramName.Split("_")(2) Then
                                For Each child In package.GetType().GetProperties()
                                    If child.Name.ToLower = paramName.Split("_")(1).ToLower Then
                                        result = CallByName(package, child.Name, CallType.Get)
                                        Exit For
                                    End If
                                Next child
                                Exit For
                            End If
                        Next package
                    ElseIf paramName.Contains("PAYMENTS_") Then
                        For Each payment In searchedObject.requestCourierDeliveryIn.Body.payments
                            If CType(payment.packageId, Int32) = 1 Then
                                For Each child In payment.GetType().GetProperties()
                                    If child.Name.ToLower = paramName.Replace("PAYMENTS_", "").Replace("_", "").ToLower Then
                                        result = CallByName(payment, child.Name, CallType.Get)
                                        Exit For
                                    End If
                                Next child
                                Exit For
                            End If
                        Next payment
                    ElseIf paramName.Contains("SERVICES_") Then
                        For Each child In searchedObject.requestCourierDeliveryIn.Body.courierServices(0).GetType().GetProperties()
                            If child.Name.ToLower = paramName.Replace("SERVICES_", "").Replace("_", "").ToLower Then
                                result = CallByName(searchedObject.requestCourierDeliveryIn.Body.courierServices(0), child.Name, CallType.Get)
                                Exit For
                            End If
                        Next child
                    Else
                        For Each child In searchedObject.requestCourierDeliveryIn.Body.GetType().GetProperties()
                            If child.Name.ToLower = paramName.Replace("_", "").ToLower Then
                                result = CallByName(searchedObject.requestCourierDeliveryIn.Body, child.Name, CallType.Get)
                                Exit For
                            End If
                        Next child
                    End If
                    If String.IsNullOrWhiteSpace(result) Then
                        For Each child In searchedObject.requestCourierDeliveryIn.GetType().GetProperties()
                            If child.Name.ToLower = paramName.Replace("_", "").ToLower Then
                                result = CallByName(searchedObject.requestCourierDeliveryIn, child.Name, CallType.Get)
                                Exit For
                            End If
                        Next child
                    End If
                Catch
                End Try
            Next
            If Not String.IsNullOrWhiteSpace(result) Then
                If result.ToString().Contains("'") Then
                    result = result.Replace("'", "")
                End If
            End If
            Return result
        Catch ex As Exception
            Return result
        End Try

    End Function


    Function fn_WriteToFile(ByVal file As String, ByVal Message As String) As Boolean
        fn_create_file(file)

        Dim objWriter As New System.IO.StreamWriter(file, True)
        objWriter.WriteLine(Message)
        objWriter.Close()
    End Function

    Function fn_check_file(ByVal file As String) As Boolean
        fn_check_file = System.IO.File.Exists(file)
    End Function


    Function fn_create_file(ByVal file As String) As Boolean
        If Not System.IO.File.Exists(file) Then
            System.IO.File.Create(file).Close()
        End If

        If fn_check_file(file) Then
            fn_create_file = True
        Else
            fn_create_file = False
        End If
    End Function

End Module
