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
        Function courierDeliveryStatus(ByVal request As courierDeliveryStatusRequest1)

        '<System.ServiceModel.OperationContractAttribute(IsOneWay:=True, Action:="")>
        'Function courierDeliveryStatusAsync(ByVal request As courierDeliveryStatusRequest1) As System.Threading.Tasks.Task
    End Interface


    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Diagnostics.DebuggerStepThroughAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.st.sk/oss/courierdeliverystatusrequest")>
    Partial Public Class courierDeliveryStatusRequest
        Inherits ossEndPointHeader

        Private courierDeliveryStatusField As courierDeliveryStatus

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property courierDeliveryStatus() As courierDeliveryStatus
            Get
                Return Me.courierDeliveryStatusField
            End Get
            Set
                Me.courierDeliveryStatusField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Diagnostics.DebuggerStepThroughAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://www.st.sk/oss/courierdeliverystatusrequest")>
    Partial Public Class courierDeliveryStatus

        Private uscField As String

        Private courierField As String

        Private courierTrackingIDField As String

        Private deliveryStatusField As String

        Private deliveryStatusInfoField As String

        Private eventDateTimeField As Date

        Private eventDateTimeFieldSpecified As Boolean

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property usc() As String
            Get
                Return Me.uscField
            End Get
            Set
                Me.uscField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public Property courier() As String
            Get
                Return Me.courierField
            End Get
            Set
                Me.courierField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>
        Public Property courierTrackingID() As String
            Get
                Return Me.courierTrackingIDField
            End Get
            Set
                Me.courierTrackingIDField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=3)>
        Public Property deliveryStatus() As String
            Get
                Return Me.deliveryStatusField
            End Get
            Set
                Me.deliveryStatusField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=4)>
        Public Property deliveryStatusInfo() As String
            Get
                Return Me.deliveryStatusInfoField
            End Get
            Set
                Me.deliveryStatusInfoField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=5)>
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
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
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
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property messageId() As String
            Get
                Return Me.messageIdField
            End Get
            Set
                Me.messageIdField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public Property source() As messageEnvelopeSource
            Get
                Return Me.sourceField
            End Get
            Set
                Me.sourceField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>
        Public Property target() As messageEnvelopeTarget
            Get
                Return Me.targetField
            End Get
            Set
                Me.targetField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=3)>
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
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
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
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
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
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
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
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property orderId() As String
            Get
                Return Me.orderIdField
            End Get
            Set
                Me.orderIdField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public Property systems() As messageEnvelope
            Get
                Return Me.systemsField
            End Get
            Set
                Me.systemsField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>
        Public Property serviceType() As ossServiceType
            Get
                Return Me.serviceTypeField
            End Get
            Set
                Me.serviceTypeField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=3)>
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
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
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
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
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

    <System.Diagnostics.DebuggerStepThroughAttribute(),
 System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),
 System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),
 System.ServiceModel.MessageContractAttribute(IsWrapped:=False)>
    Partial Public Class courierDeliveryStatusRequest1

        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="http://www.st.sk/oss/courierdeliverystatusrequest", Order:=0)>
        Public courierDeliveryStatusRequest As courierDeliveryStatusRequest

        Public Sub New()
            MyBase.New
        End Sub

        Public Sub New(ByVal courierDeliveryStatusRequest As courierDeliveryStatusRequest)
            MyBase.New
            Me.courierDeliveryStatusRequest = courierDeliveryStatusRequest
        End Sub
    End Class

    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>
    Public Interface courierDeliveryStatusChannel
        Inherits IcourierDeliveryStatusService, System.ServiceModel.IClientChannel
    End Interface

    <System.Diagnostics.DebuggerStepThroughAttribute(),
 System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>
    Partial Public Class courierDeliveryStatusClient
        Inherits System.ServiceModel.ClientBase(Of IcourierDeliveryStatusService)
        Implements IcourierDeliveryStatusService

        Public Sub New()
            MyBase.New
        End Sub

        Public Sub New(ByVal endpointConfigurationName As String)
            MyBase.New(endpointConfigurationName)
        End Sub

        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As String)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub

        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub

        Public Sub New(ByVal binding As System.ServiceModel.Channels.Binding, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(binding, remoteAddress)
        End Sub

        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>
        Function courierDeliveryStatus(ByVal request As courierDeliveryStatusRequest1) Implements IcourierDeliveryStatusService.courierDeliveryStatus
            MyBase.Channel.courierDeliveryStatus(request)
        End Function

        Public Function courierDeliveryStatus(ByVal courierDeliveryStatusRequest As courierDeliveryStatusRequest)
            Dim inValue As courierDeliveryStatusRequest1 = New courierDeliveryStatusRequest1()
            inValue.courierDeliveryStatusRequest = courierDeliveryStatusRequest
            'CType(Me, courierDeliveryStatus).courierDeliveryStatus(inValue)
        End Function

        '<System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>
        'Function courierDeliveryStatus_courierDeliveryStatusAsync(ByVal request As courierDeliveryStatusRequest1) As System.Threading.Tasks.Task Implements IcourierDeliveryStatusService.courierDeliveryStatusAsync
        '    Return MyBase.Channel.courierDeliveryStatusAsync(request)
        'End Function

        'Public Function courierDeliveryStatusAsync(ByVal courierDeliveryStatusRequest As courierDeliveryStatusRequest) As System.Threading.Tasks.Task
        '    Dim inValue As courierDeliveryStatusRequest1 = New courierDeliveryStatusRequest1()
        '    inValue.courierDeliveryStatusRequest = courierDeliveryStatusRequest
        '    Return CType(Me, courierDeliveryStatus).courierDeliveryStatusAsync(inValue)
        'End Function
    End Class
End Namespace