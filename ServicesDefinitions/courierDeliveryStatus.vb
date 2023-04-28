Option Strict Off
Option Explicit On

Namespace courierDeliveryStatusService


    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),
 System.ServiceModel.ServiceContractAttribute(Name:="courierDeliveryStatusService", [Namespace]:="http://www.st.sk/oss/courierdeliverystatusrequest")>
    Public Interface IcourierDeliveryStatusService

        'CODEGEN: Probíhá generování kontraktu zprávy, protože operace courierDeliveryStatus není RPC ani není zabalena dokumentem.
        <System.ServiceModel.OperationContractAttribute(Action:="courierDeliveryStatus"),
     System.ServiceModel.XmlSerializerFormatAttribute(),
     System.ServiceModel.ServiceKnownTypeAttribute(GetType(ossEndPointHeader))>
        Function courierDeliveryStatus(ByVal request As courierDeliveryStatusRequest)

        '<System.ServiceModel.OperationContractAttribute(IsOneWay:=True, Action:="")>
        'Function courierDeliveryStatusAsync(ByVal request As courierDeliveryStatusRequest1) As System.Threading.Tasks.Task
    End Interface

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.7.2556.0"),
 System.Diagnostics.DebuggerStepThroughAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Web.Services.WebServiceBindingAttribute(Name:="courierDeliveryStatusSoap11", [Namespace]:="http://www.st.sk/oss/courierdeliverystatusrequest"),
 System.Xml.Serialization.XmlIncludeAttribute(GetType(ossEndPointHeader))>
    Partial Public Class courierDeliveryStatus
        Inherits System.Web.Services.Protocols.SoapHttpClientProtocol

        Private CallcourierDeliveryStatusOperationCompleted As System.Threading.SendOrPostCallback

        '''<remarks/>
        Public Sub New()
            MyBase.New
            Me.Url = "http://localhost:8080/oss/ws"
        End Sub

        '''<remarks/>
        Public Event CallcourierDeliveryStatusCompleted As CallcourierDeliveryStatusCompletedEventHandler

        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("", OneWay:=True, Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Bare)>
        Public Sub CallcourierDeliveryStatus(<System.Xml.Serialization.XmlElementAttribute([Namespace]:="http://www.st.sk/oss/courierdeliverystatusrequest")> ByVal courierDeliveryStatusRequest As courierDeliveryStatusRequest)
            Me.Invoke("CallcourierDeliveryStatus", New Object() {courierDeliveryStatusRequest})
        End Sub

        '''<remarks/>
        Public Function BeginCallcourierDeliveryStatus(ByVal courierDeliveryStatusRequest As courierDeliveryStatusRequest, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("CallcourierDeliveryStatus", New Object() {courierDeliveryStatusRequest}, callback, asyncState)
        End Function

        '''<remarks/>
        Public Sub EndCallcourierDeliveryStatus(ByVal asyncResult As System.IAsyncResult)
            Me.EndInvoke(asyncResult)
        End Sub

        '''<remarks/>
        Public Overloads Sub CallcourierDeliveryStatusAsync(ByVal courierDeliveryStatusRequest As courierDeliveryStatusRequest)
            Me.CallcourierDeliveryStatusAsync(courierDeliveryStatusRequest, Nothing)
        End Sub

        '''<remarks/>
        Public Overloads Sub CallcourierDeliveryStatusAsync(ByVal courierDeliveryStatusRequest As courierDeliveryStatusRequest, ByVal userState As Object)
            If (Me.CallcourierDeliveryStatusOperationCompleted Is Nothing) Then
                Me.CallcourierDeliveryStatusOperationCompleted = AddressOf Me.OnCallcourierDeliveryStatusOperationCompleted
            End If
            Me.InvokeAsync("CallcourierDeliveryStatus", New Object() {courierDeliveryStatusRequest}, Me.CallcourierDeliveryStatusOperationCompleted, userState)
        End Sub

        Private Sub OnCallcourierDeliveryStatusOperationCompleted(ByVal arg As Object)
            If (Not (Me.CallcourierDeliveryStatusCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg, System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent CallcourierDeliveryStatusCompleted(Me, New System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub

        '''<remarks/>
        Public Shadows Sub CancelAsync(ByVal userState As Object)
            MyBase.CancelAsync(userState)
        End Sub
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Diagnostics.DebuggerStepThroughAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.st.sk/oss/courierdeliverystatusrequest")>
    Partial Public Class courierDeliveryStatusRequest
        Inherits ossEndPointHeader

        Private courierDeliveryStatusField As courierDeliveryStatus1

        '''<remarks/>
        Public Property courierDeliveryStatus() As courierDeliveryStatus1
            Get
                Return Me.courierDeliveryStatusField
            End Get
            Set
                Me.courierDeliveryStatusField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Diagnostics.DebuggerStepThroughAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(TypeName:="courierDeliveryStatus", [Namespace]:="http://www.st.sk/oss/courierdeliverystatusrequest")>
    Partial Public Class courierDeliveryStatus1

        Private uscField As String

        Private courierField As String

        Private courierTrackingIDField As String

        Private deliveryStatusField As String

        Private deliveryStatusInfoField As String

        Private eventDateTimeField As Date

        Private eventDateTimeFieldSpecified As Boolean

        '''<remarks/>
        Public Property usc() As String
            Get
                Return Me.uscField
            End Get
            Set
                Me.uscField = Value
            End Set
        End Property

        '''<remarks/>
        Public Property courier() As String
            Get
                Return Me.courierField
            End Get
            Set
                Me.courierField = Value
            End Set
        End Property

        '''<remarks/>
        Public Property courierTrackingID() As String
            Get
                Return Me.courierTrackingIDField
            End Get
            Set
                Me.courierTrackingIDField = Value
            End Set
        End Property

        '''<remarks/>
        Public Property deliveryStatus() As String
            Get
                Return Me.deliveryStatusField
            End Get
            Set
                Me.deliveryStatusField = Value
            End Set
        End Property

        '''<remarks/>
        Public Property deliveryStatusInfo() As String
            Get
                Return Me.deliveryStatusInfoField
            End Get
            Set
                Me.deliveryStatusInfoField = Value
            End Set
        End Property

        '''<remarks/>
        Public Property eventDateTime() As Date
            Get
                Return Me.eventDateTimeField
            End Get
            Set
                Me.eventDateTimeField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>
        Public Property eventDateTimeSpecified() As Boolean
            Get
                Return Me.eventDateTimeFieldSpecified
            End Get
            Set
                Me.eventDateTimeFieldSpecified = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Diagnostics.DebuggerStepThroughAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://www.st.sk/oss/osscommon")>
    Partial Public Class messageEnvelope

        Private messageIdField As String

        Private sourceField As messageEnvelopeSource

        Private targetField As messageEnvelopeTarget

        Private timestampField As Date

        '''<remarks/>
        Public Property messageId() As String
            Get
                Return Me.messageIdField
            End Get
            Set
                Me.messageIdField = Value
            End Set
        End Property

        '''<remarks/>
        Public Property source() As messageEnvelopeSource
            Get
                Return Me.sourceField
            End Get
            Set
                Me.sourceField = Value
            End Set
        End Property

        '''<remarks/>
        Public Property target() As messageEnvelopeTarget
            Get
                Return Me.targetField
            End Get
            Set
                Me.targetField = Value
            End Set
        End Property

        '''<remarks/>
        Public Property timestamp() As Date
            Get
                Return Me.timestampField
            End Get
            Set
                Me.timestampField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.st.sk/oss/osscommon")>
    Public Enum messageEnvelopeSource

        '''<remarks/>
        SPASiebel

        '''<remarks/>
        Cramer

        '''<remarks/>
        SD

        '''<remarks/>
        TPM

        '''<remarks/>
        Vitria

        '''<remarks/>
        Oss

        '''<remarks/>
        WORKFLOW

        '''<remarks/>
        INVENTORY

        '''<remarks/>
        ACTIVATION

        '''<remarks/>
        LOGISTICS

        '''<remarks/>
        SERVICEDESIGNER

        '''<remarks/>
        OSSSERVICEDESIGNER

        '''<remarks/>
        Tibco

        '''<remarks/>
        Stock

        '''<remarks/>
        STOCKHANDLER

        '''<remarks/>
        Flex

        '''<remarks/>
        BrightPoint

        '''<remarks/>
        INTEGRATION
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.st.sk/oss/osscommon")>
    Public Enum messageEnvelopeTarget

        '''<remarks/>
        SPASiebel

        '''<remarks/>
        Cramer

        '''<remarks/>
        SD

        '''<remarks/>
        TPM

        '''<remarks/>
        Vitria

        '''<remarks/>
        Oss

        '''<remarks/>
        WORKFLOW

        '''<remarks/>
        INVENTORY

        '''<remarks/>
        ACTIVATION

        '''<remarks/>
        LOGISTICS

        '''<remarks/>
        SERVICEDESIGNER

        '''<remarks/>
        OSSSERVICEDESIGNER

        '''<remarks/>
        Tibco

        '''<remarks/>
        Stock

        '''<remarks/>
        STOCKHANDLER

        '''<remarks/>
        Flex

        '''<remarks/>
        BrightPoint

        '''<remarks/>
        INTEGRATION
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Diagnostics.DebuggerStepThroughAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://www.st.sk/oss/osscommon")>
    Partial Public Class ossEndPointHeader

        Private orderIdField As String

        Private systemsField As messageEnvelope

        Private serviceTypeField As ossServiceType

        Private serviceActionField As ossServiceAction

        '''<remarks/>
        Public Property orderId() As String
            Get
                Return Me.orderIdField
            End Get
            Set
                Me.orderIdField = Value
            End Set
        End Property

        '''<remarks/>
        Public Property systems() As messageEnvelope
            Get
                Return Me.systemsField
            End Get
            Set
                Me.systemsField = Value
            End Set
        End Property

        '''<remarks/>
        Public Property serviceType() As ossServiceType
            Get
                Return Me.serviceTypeField
            End Get
            Set
                Me.serviceTypeField = Value
            End Set
        End Property

        '''<remarks/>
        Public Property serviceAction() As ossServiceAction
            Get
                Return Me.serviceActionField
            End Get
            Set
                Me.serviceActionField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://www.st.sk/oss/osscommon")>
    Public Enum ossServiceType

        '''<remarks/>
        TaskEngine

        '''<remarks/>
        StockHandler

        '''<remarks/>
        WorkFlow

        '''<remarks/>
        Inventory

        '''<remarks/>
        Logistics

        '''<remarks/>
        XDSLService

        '''<remarks/>
        GPONService

        '''<remarks/>
        ServiceDesign

        '''<remarks/>
        OSSPort

        '''<remarks/>
        Port

        '''<remarks/>
        GetOSSServiceProfil

        '''<remarks/>
        FindServiceNode

        '''<remarks/>
        GetDSLNeighborhoods

        '''<remarks/>
        GetServicePoint

        '''<remarks/>
        OSSGetHDMServicePointid

        '''<remarks/>
        OSSGetHDMCPEServices

        '''<remarks/>
        IMSmodificationProfile

        '''<remarks/>
        MCORE

        '''<remarks/>
        DVBS

        '''<remarks/>
        IMS

        '''<remarks/>
        HDM

        '''<remarks/>
        MEDIAROOM

        '''<remarks/>
        NETWORK

        '''<remarks/>
        GetTopology

        '''<remarks/>
        ResetDevicePIN

        '''<remarks/>
        GetLastMileStatistic

        '''<remarks/>
        GetCPEofSubscriber

        '''<remarks/>
        GetAccessMatrix

        '''<remarks/>
        GetProbe

        '''<remarks/>
        GetSubscriberForPort

        '''<remarks/>
        BringPoint

        '''<remarks/>
        Deezer

        '''<remarks/>
        PanIP

        '''<remarks/>
        TPM

        '''<remarks/>
        GetServiceCount

        '''<remarks/>
        ODB

        '''<remarks/>
        Emergency

        '''<remarks/>
        NAGRA
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://www.st.sk/oss/osscommon")>
    Public Enum ossServiceAction

        '''<remarks/>
        Start

        '''<remarks/>
        BaseProfile

        '''<remarks/>
        FullProfile

        '''<remarks/>
        HDMProfile

        '''<remarks/>
        Replacement

        '''<remarks/>
        Reset

        '''<remarks/>
        Restart

        '''<remarks/>
        Reprovisioning

        '''<remarks/>
        Pairing

        '''<remarks/>
        Reactivation

        '''<remarks/>
        ChangePassword

        '''<remarks/>
        Suspend

        '''<remarks/>
        [Resume]

        '''<remarks/>
        VasModification

        '''<remarks/>
        Assign

        '''<remarks/>
        BlockOrder

        '''<remarks/>
        Cancel

        '''<remarks/>
        Close

        '''<remarks/>
        Design

        '''<remarks/>
        ModifyDesign

        '''<remarks/>
        OnlineRedesign

        '''<remarks/>
        Refresh

        '''<remarks/>
        Rollback

        '''<remarks/>
        ServiceDesign

        '''<remarks/>
        UpdateDesign

        '''<remarks/>
        GetHwAvailability

        '''<remarks/>
        GetHwReservation

        '''<remarks/>
        SetHwReservation

        '''<remarks/>
        SetPUPResponse

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("Start Delivery")>
        StartDelivery

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("Cancel Delivery")>
        CancelDelivery

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("Confirm Delivery")>
        ConfirmDelivery

        '''<remarks/>
        [In]

        '''<remarks/>
        Out

        '''<remarks/>
        None

        '''<remarks/>
        Activate

        '''<remarks/>
        Deactivate

        '''<remarks/>
        Flex

        '''<remarks/>
        BringPoint

        '''<remarks/>
        GetStockLevel

        '''<remarks/>
        SetStockLevel

        '''<remarks/>
        GetPassword

        '''<remarks/>
        SoftSuspend

        '''<remarks/>
        HardSuspend

        '''<remarks/>
        Add

        '''<remarks/>
        Delete

        '''<remarks/>
        DslamCascade

        '''<remarks/>
        HDM

        '''<remarks/>
        SetPUPDelivery

        '''<remarks/>
        DispatchWorkflow

        '''<remarks/>
        UnblockWorkflow

        '''<remarks/>
        BlockWorkflow

        '''<remarks/>
        RollbackWorkflow

        '''<remarks/>
        InstanceExclusiveExecution

        '''<remarks/>
        GroupExclusiveExecution

        '''<remarks/>
        GlobalExclusiveExecution

        '''<remarks/>
        SetSequenceStepToZero

        '''<remarks/>
        Response

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("activate voice")>
        activatevoice

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("deactivate voice")>
        deactivatevoice

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("activate adsl")>
        activateadsl

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("activate gpon")>
        activategpon

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("deactivate adsl")>
        deactivateadsl

        '''<remarks/>
        addDevice

        '''<remarks/>
        delDevice

        '''<remarks/>
        XdslProfileChanged

        '''<remarks/>
        CHANGEONT

        '''<remarks/>
        PRIDAJ

        '''<remarks/>
        ZMAZ

        '''<remarks/>
        ZMEN

        '''<remarks/>
        SET_PIN_0

        '''<remarks/>
        SET_PIN_1

        '''<remarks/>
        SET_PIN_2

        '''<remarks/>
        SET_RECORDING_DEVICE

        '''<remarks/>
        addEnhanceListOfProducts

        '''<remarks/>
        initializeSmartCard

        '''<remarks/>
        removeAllProducts

        '''<remarks/>
        cancelListProducts

        '''<remarks/>
        setSegments

        '''<remarks/>
        activateServicePackages

        '''<remarks/>
        removeServicePackages

        '''<remarks/>
        DSL_activateService

        '''<remarks/>
        DSL_deactivateService

        '''<remarks/>
        moveSubscriber

        '''<remarks/>
        Change

        '''<remarks/>
        Modify

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("PRIDAJ B2B")>
        PRIDAJB2B

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("ZMAZ B2B")>
        ZMAZB2B

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("wait ont")>
        waitont

        '''<remarks/>
        removeDevice

        '''<remarks/>
        SetCourierDeliveryStatus
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.7.2556.0")>
    Public Delegate Sub CallcourierDeliveryStatusCompletedEventHandler(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)

End Namespace