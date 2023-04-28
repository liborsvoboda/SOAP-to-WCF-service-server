Option Strict Off
Option Explicit On

Imports System.Runtime.Serialization
Imports AppWSDL.StockRequestService

<Assembly: System.Runtime.Serialization.ContractNamespaceAttribute("http://schemas.telekom.net/csdg_v01.01", ClrNamespace:="schemas.telekom.net.csdg_v01._01"),
 Assembly: System.Runtime.Serialization.ContractNamespaceAttribute("http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/StockRequest_v01" &
    ".00/types", ClrNamespace:="services.tint.telekom.net.SupAndPartMgmt.LogWarehouseMgmt.StockRequest_v01._00.ty" &
    "pes")>

Namespace StockRequestService


    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),
 System.ServiceModel.ServiceContractAttribute(Name:="StockRequestService", [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/StockRequest_v01" &
    ".00")>
    Public Interface IStockRequestService

        'System.ServiceModel.FaultContractAttribute(GetType(schemas.telekom.net.csdg_v01._01.TCTechnicalFaultInfo), Action:="http://www.w3.org/2005/08/addressing/soap/fault", Name:="technicalFault", [Namespace]:="http://schemas.telekom.net/csdg_v01.01")>
        <System.ServiceModel.OperationContractAttribute(Name:="stockRequest", Action:="")>
        Function stockRequest(ByVal request As stockRequest) As stockRequestResponse

        '<System.ServiceModel.OperationContractAttribute(Name:="stockRequestAsync", Action:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/StockRequest_v01" &
        '    ".00/StockRequest/stockRequest", ReplyAction:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/StockRequest_v01" &
        '    ".00/StockRequest/stockRequestResponse")>
        'Function stockRequestAsync(ByVal request As stockRequest) As System.Threading.Tasks.Task(Of stockRequestResponse)
    End Interface

    <System.Diagnostics.DebuggerStepThroughAttribute(),
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),
     System.ServiceModel.MessageContractAttribute(WrapperName:="stockRequest", WrapperNamespace:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/StockRequest_v01" &
        ".00", IsWrapped:=True)>
    Partial Public Class stockRequest

        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/StockRequest_v01" &
            ".00/types", Order:=0)>
        Public context As schemas.telekom.net.csdg_v01._01.TCContext

        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/StockRequest_v01" &
            ".00/types", Order:=1)>
        Public data As services.tint.telekom.net.SupAndPartMgmt.LogWarehouseMgmt.StockRequest_v01._00.types.StockRequestInputData

        Public Sub New()
            MyBase.New
        End Sub

        Public Sub New(ByVal context As schemas.telekom.net.csdg_v01._01.TCContext, ByVal data As services.tint.telekom.net.SupAndPartMgmt.LogWarehouseMgmt.StockRequest_v01._00.types.StockRequestInputData)
            MyBase.New
            Me.context = context
            Me.data = data
        End Sub
    End Class

    <System.Diagnostics.DebuggerStepThroughAttribute(),
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),
     System.ServiceModel.MessageContractAttribute(WrapperName:="empty", WrapperNamespace:="http://schemas.telekom.net/csdg_v01.01", IsWrapped:=True)>
    Partial Public Class stockRequestResponse

        Public Sub New()
            MyBase.New
        End Sub
    End Class

    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>
    Public Interface StockRequestChannel
        Inherits IStockRequestService, System.ServiceModel.IClientChannel
    End Interface

    <System.Diagnostics.DebuggerStepThroughAttribute(),
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>
    Partial Public Class StockRequestClient
        Inherits System.ServiceModel.ClientBase(Of IStockRequestService)
        Implements IStockRequestService

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
        Function stockRequest(ByVal request As stockRequest) As stockRequestResponse Implements IStockRequestService.stockRequest
            Return MyBase.Channel.stockRequest(request)
        End Function

        Public Sub stockRequest(ByVal context As schemas.telekom.net.csdg_v01._01.TCContext, ByVal data As services.tint.telekom.net.SupAndPartMgmt.LogWarehouseMgmt.StockRequest_v01._00.types.StockRequestInputData)
            Dim inValue As stockRequest = New stockRequest()
            inValue.context = context
            inValue.data = data
            Dim retVal As stockRequestResponse = CType(Me, IStockRequestService).stockRequest(inValue)
        End Sub

        '<System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>
        'Function stockRequestAsync(ByVal request As stockRequest) As System.Threading.Tasks.Task(Of stockRequestResponse) Implements IStockRequestService.stockRequestAsync
        '    Return MyBase.Channel.stockRequestAsync(request)
        'End Function

        'Public Function stockRequestAsync(ByVal context As schemas.telekom.net.csdg_v01._01.TCContext, ByVal data As services.tint.telekom.net.SupAndPartMgmt.LogWarehouseMgmt.StockRequest_v01._00.types.StockRequestInputData) As System.Threading.Tasks.Task(Of stockRequestResponse)
        '    Dim inValue As stockRequest = New stockRequest()
        '    inValue.context = context
        '    inValue.data = data
        '    Return CType(Me, IStockRequestService).stockRequestAsync(inValue)
        'End Function
    End Class



    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),
     System.ServiceModel.ServiceContractAttribute(Name:="StockRequestConsumerService", [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/StockRequest_v01" &
        ".00/consumer")>
    Public Interface IStockRequestConsumerService

        'System.ServiceModel.FaultContractAttribute(GetType(schemas.telekom.net.csdg_v01._01.TCTechnicalFaultInfo), Action:="", Name:="technicalFault", [Namespace]:="http://schemas.telekom.net/csdg_v01.01"),
        <System.ServiceModel.OperationContractAttribute(Name:="stockRequestCallback", Action:="stockRequestCallback"),
         System.ServiceModel.XmlSerializerFormatAttribute(),
         System.ServiceModel.ServiceKnownTypeAttribute(GetType(TCFaultInfo))>
        Function stockRequestCallback(ByVal request As stockRequestCallback) As stockRequestCallback

        <System.ServiceModel.OperationContractAttribute(Name:="stockRequestCallbackAsync", Action:="", ReplyAction:="*")>', ReplyAction:="*"
        Function stockRequestCallbackAsync(ByVal request As stockRequestCallback) As System.Threading.Tasks.Task(Of stockRequestCallbackResponse)

        'System.ServiceModel.FaultContractAttribute(GetType(schemas.telekom.net.csdg_v01._01.TCTechnicalFaultInfo), Action:="", Name:="technicalFault", [Namespace]:="http://schemas.telekom.net/csdg_v01.01"),
        <System.ServiceModel.OperationContractAttribute(Action:="stockRequestFault"),
         System.ServiceModel.XmlSerializerFormatAttribute(),
         System.ServiceModel.ServiceKnownTypeAttribute(GetType(TCFaultInfo))>
        Function stockRequestFault(ByVal request As stockRequestFault) As stockRequestResponse

        '<System.ServiceModel.OperationContractAttribute(Action:="", ReplyAction:="*")>
        'Function stockRequestFaultAsync(ByVal request As stockRequestFaultRequest) As System.Threading.Tasks.Task(Of stockRequestResponse)
    End Interface

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
     System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(),
     System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://schemas.telekom.net/csdg_v01.01")>
    Partial Public Class TCContext

        Private technicalContextField As schemas.telekom.net.csdg_v01._01.TCTechnicalContext

        Private businessContextField As schemas.telekom.net.csdg_v01._01.TCBusinessContext

        ''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property technicalContext() As schemas.telekom.net.csdg_v01._01.TCTechnicalContext
            Get
                Return Me.technicalContextField
            End Get
            Set
                Me.technicalContextField = Value
            End Set
        End Property

        ''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public Property businessContext() As schemas.telekom.net.csdg_v01._01.TCBusinessContext
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
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://schemas.telekom.net/csdg_v01.01")>
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
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://schemas.telekom.net/csdg_v01.01")>
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
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://schemas.telekom.net/csdg_v01.01")>
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
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://schemas.telekom.net/csdg_v01.01")>
    Partial Public Class TCDescription

        Private langField As String

        Private descIdField As String

        Private valueField As String

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Qualified)>
        Public Property lang() As String
            Get
                Return Me.langField
            End Get
            Set
                Me.langField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property descId() As String
            Get
                Return Me.descIdField
            End Get
            Set
                Me.descIdField = Value
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
    <System.Xml.Serialization.XmlIncludeAttribute(GetType(TCBusinessFaultInfo)),
     System.Xml.Serialization.XmlIncludeAttribute(GetType(TCTechnicalFaultInfo)),
     System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
     System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(),
     System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://schemas.telekom.net/csdg_v01.01")>
    Partial Public Class TCFaultInfo

        Private contextField As TCContext

        Private timestampField As Date

        Private errorCodeField As String

        Private errorLocationField As String

        Private severityField As Integer

        Private descriptionField() As TCDescription

        Private propertyField() As TCProperty

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property context() As TCContext
            Get
                Return Me.contextField
            End Get
            Set
                Me.contextField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public Property timestamp() As Date
            Get
                Return Me.timestampField
            End Get
            Set
                Me.timestampField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>
        Public Property errorCode() As String
            Get
                Return Me.errorCodeField
            End Get
            Set
                Me.errorCodeField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=3)>
        Public Property errorLocation() As String
            Get
                Return Me.errorLocationField
            End Get
            Set
                Me.errorLocationField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=4)>
        Public Property severity() As Integer
            Get
                Return Me.severityField
            End Get
            Set
                Me.severityField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("description", Order:=5)>
        Public Property description() As TCDescription()
            Get
                Return Me.descriptionField
            End Get
            Set
                Me.descriptionField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("property", Order:=6)>
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
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://schemas.telekom.net/csdg_v01.01")>
    Partial Public Class TCBusinessFaultInfo
        Inherits TCFaultInfo
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
     System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(),
     System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://schemas.telekom.net/csdg_v01.01")>
    Partial Public Class TCTechnicalFaultInfo
        Inherits TCFaultInfo
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
     System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(),
     System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/StockRequest_v01" &
        ".00/types")>
    Partial Public Class StatusBAPIItem

        Private tYPEField As String

        Private idField As String

        Private nUMBERField As String

        Private mESSAGEField As String

        Private lOG_NOField As String

        Private lOG_MSG_NOField As String

        Private mESSAGE_V1Field As String

        Private mESSAGE_V2Field As String

        Private mESSAGE_V3Field As String

        Private mESSAGE_V4Field As String

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property TYPE() As String
            Get
                Return Me.tYPEField
            End Get
            Set
                Me.tYPEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public Property ID() As String
            Get
                Return Me.idField
            End Get
            Set
                Me.idField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>
        Public Property NUMBER() As String
            Get
                Return Me.nUMBERField
            End Get
            Set
                Me.nUMBERField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=3)>
        Public Property MESSAGE() As String
            Get
                Return Me.mESSAGEField
            End Get
            Set
                Me.mESSAGEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=4)>
        Public Property LOG_NO() As String
            Get
                Return Me.lOG_NOField
            End Get
            Set
                Me.lOG_NOField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=5)>
        Public Property LOG_MSG_NO() As String
            Get
                Return Me.lOG_MSG_NOField
            End Get
            Set
                Me.lOG_MSG_NOField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=6)>
        Public Property MESSAGE_V1() As String
            Get
                Return Me.mESSAGE_V1Field
            End Get
            Set
                Me.mESSAGE_V1Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=7)>
        Public Property MESSAGE_V2() As String
            Get
                Return Me.mESSAGE_V2Field
            End Get
            Set
                Me.mESSAGE_V2Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=8)>
        Public Property MESSAGE_V3() As String
            Get
                Return Me.mESSAGE_V3Field
            End Get
            Set
                Me.mESSAGE_V3Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=9)>
        Public Property MESSAGE_V4() As String
            Get
                Return Me.mESSAGE_V4Field
            End Get
            Set
                Me.mESSAGE_V4Field = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
     System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(),
     System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/StockRequest_v01" &
        ".00/types")>
    Partial Public Class StatusHeaderItem

        Private qualifierField As String

        Private valueField As String

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property qualifier() As String
            Get
                Return Me.qualifierField
            End Get
            Set
                Me.qualifierField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public Property value() As String
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
     System.Diagnostics.DebuggerStepThroughAttribute(),
     System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/StockRequest_v01" &
        ".00/types")>
    Partial Public Class StatusHeader

        Private statusTypeField As String

        Private itemField() As StatusHeaderItem

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property statusType() As String
            Get
                Return Me.statusTypeField
            End Get
            Set
                Me.statusTypeField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("item", Order:=1)>
        Public Property item() As StatusHeaderItem()
            Get
                Return Me.itemField
            End Get
            Set
                Me.itemField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    'System.Diagnostics.DebuggerStepThroughAttribute(),
    'System.ComponentModel.DesignerCategoryAttribute("code"),
    <AttributeUsage(AttributeTargets.Class, AllowMultiple:=True)>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
     System.SerializableAttribute(),
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/StockRequest_v01" &
        ".00/types")>
    Public Class StockAvailabilityItem
        Private plantField As String = ""

        Private storLocField As String = ""

        Private stockTypeField As String = ""

        Private stockIndField As String = ""

        Private materialNumberField As String = ""

        Private valTypeField As String = ""

        Private uIIDField As String = ""

        Private snField As String = ""

        Private quanField As Decimal = Nothing

        Private quanFieldSpecified As Boolean = True

        Private uomField As String = ""

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property plant() As String
            Get
                Return Me.plantField
            End Get
            Set
                Me.plantField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public Property storLoc() As String
            Get
                Return Me.storLocField
            End Get
            Set
                Me.storLocField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>
        Public Property stockType() As String
            Get
                Return Me.stockTypeField
            End Get
            Set
                Me.stockTypeField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=3)>
        Public Property stockInd() As String
            Get
                Return Me.stockIndField
            End Get
            Set
                Me.stockIndField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=4)>
        Public Property materialNumber() As String
            Get
                Return Me.materialNumberField
            End Get
            Set
                Me.materialNumberField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=5)>
        Public Property valType() As String
            Get
                Return Me.valTypeField
            End Get
            Set
                Me.valTypeField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=6)>
        Public Property UIID() As String
            Get
                Return Me.uIIDField
            End Get
            Set
                Me.uIIDField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=7)>
        Public Property SN() As String
            Get
                Return Me.snField
            End Get
            Set
                Me.snField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=8)>
        Public Property quan() As Decimal
            Get
                Return Me.quanField
            End Get
            Set
                Me.quanField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>
        Public Property quanSpecified() As Boolean
            Get
                Return Me.quanFieldSpecified
            End Get
            Set
                Me.quanFieldSpecified = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=9)>
        Public Property uom() As String
            Get
                Return Me.uomField
            End Get
            Set
                Me.uomField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    'System.Diagnostics.DebuggerStepThroughAttribute(),
    <AttributeUsage(AttributeTargets.Class Or
AttributeTargets.Method, AllowMultiple:=True)>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
     System.SerializableAttribute(),
     System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/StockRequest_v01" &
        ".00/types")>
    Partial Public Class StockRequestOutputData

        Private processingStatusField As String

        Private itemsField As List(Of StockAvailabilityItem)

        Private statusField As StockRequestOutputDataStatus

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property processingStatus() As String
            Get
                Return Me.processingStatusField
            End Get
            Set
                Me.processingStatusField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlArrayAttribute(Order:=1),
         System.Xml.Serialization.XmlArrayItemAttribute("item", ElementName:="item", IsNullable:=False)>
        Public Property Items As List(Of StockAvailabilityItem)
            Get
                Return Me.itemsField
            End Get
            Set
                Me.itemsField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>
        Public Property Status() As StockRequestOutputDataStatus
            Get
                Return Me.statusField
            End Get
            Set
                Me.statusField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
     System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(),
     System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/StockRequest_v01" &
        ".00/types")>
    Partial Public Class StockRequestOutputDataStatus

        Private statusHeaderField As StatusHeader

        Private statusBAPIField() As StatusBAPIItem

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property StatusHeader() As StatusHeader
            Get
                Return Me.statusHeaderField
            End Get
            Set
                Me.statusHeaderField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlArrayAttribute(Order:=1),
         System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable:=False)>
        Public Property StatusBAPI() As StatusBAPIItem()
            Get
                Return Me.statusBAPIField
            End Get
            Set
                Me.statusBAPIField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
     System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(),
     System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://schemas.telekom.net/csdg_v01.01")>
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

    <'System.Diagnostics.DebuggerStepThroughAttribute(),
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),
     System.ServiceModel.MessageContractAttribute(WrapperName:="stockRequestCallback", WrapperNamespace:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/StockRequest_v01" &
        ".00/consumer", IsWrapped:=True)>
    Partial Public Class stockRequestCallback

        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/StockRequest_v01" &
            ".00/types", Order:=0),
         System.Xml.Serialization.XmlElementAttribute([Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/StockRequest_v01" &
            ".00/types")>
        Public context As schemas.telekom.net.csdg_v01._01.TCContext

        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/StockRequest_v01" &
            ".00/types", Order:=1),
         System.Xml.Serialization.XmlElementAttribute([Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/StockRequest_v01" &
            ".00/types")>
        Public data As services.tint.telekom.net.SupAndPartMgmt.LogWarehouseMgmt.StockRequest_v01._00.types.StockRequestInputData

        Public Sub New()
            MyBase.New
        End Sub

        Public Sub New(ByVal context As schemas.telekom.net.csdg_v01._01.TCContext, ByVal data As services.tint.telekom.net.SupAndPartMgmt.LogWarehouseMgmt.StockRequest_v01._00.types.StockRequestInputData)
            MyBase.New
            Me.context = context
            Me.data = data
        End Sub
    End Class

    <'System.Diagnostics.DebuggerStepThroughAttribute(),
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),
     System.ServiceModel.MessageContractAttribute(WrapperName:="stockRequestCallback", WrapperNamespace:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/StockRequest_v01" &
        ".00/consumer", IsWrapped:=True)>
    Partial Public Class stockRequestCallbackResponse

        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/StockRequest_v01" &
            ".00/types", Order:=0),
         System.Xml.Serialization.XmlElementAttribute([Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/StockRequest_v01" &
            ".00/types")>
        Public context As TCContext

        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/StockRequest_v01" &
            ".00/types", Order:=1),
         System.Xml.Serialization.XmlElementAttribute([Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/StockRequest_v01" &
            ".00/types")>
        Public data As StockRequestOutputData

        Public Sub New()
            MyBase.New
        End Sub

        Public Sub New(ByVal context As TCContext, ByVal data As StockRequestOutputData)
            MyBase.New
            Me.context = context
            Me.data = data
        End Sub
    End Class

    '''<remarks/>
    <'System.Diagnostics.DebuggerStepThroughAttribute(),
     System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
     System.SerializableAttribute(),
     System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/StockRequest_v01" &
        ".00/types")>
    Partial Public Class StockRequestFaultTypeDetail

        Private itemField As TCTechnicalFaultInfo

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("technicalFault", [Namespace]:="http://schemas.telekom.net/csdg_v01.01", Order:=0)>
        Public Property Item() As TCTechnicalFaultInfo
            Get
                Return Me.itemField
            End Get
            Set
                Me.itemField = Value
            End Set
        End Property
    End Class

    'System.Diagnostics.DebuggerStepThroughAttribute(),
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),
     System.ServiceModel.MessageContractAttribute(WrapperName:="stockRequestFault", WrapperNamespace:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/StockRequest_v01" &
        ".00", IsWrapped:=True)>
    Partial Public Class stockRequestFault

        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="http://schemas.telekom.net/csdg_v01.01", Order:=0),
         System.Xml.Serialization.XmlElementAttribute([Namespace]:="http://schemas.telekom.net/csdg_v01.01")>
        Public faultcode As System.Xml.XmlQualifiedName

        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="http://schemas.telekom.net/csdg_v01.01", Order:=1),
         System.Xml.Serialization.XmlElementAttribute([Namespace]:="http://schemas.telekom.net/csdg_v01.01")>
        Public faultstring As String

        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="http://schemas.telekom.net/csdg_v01.01", Order:=2),
         System.Xml.Serialization.XmlElementAttribute([Namespace]:="http://schemas.telekom.net/csdg_v01.01", DataType:="anyURI")>
        Public faultactor As String

        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/StockRequest_v01" &
            ".00/types", Order:=3),
         System.Xml.Serialization.XmlElementAttribute([Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/StockRequest_v01" &
            ".00/types")>
        Public detail As StockRequestFaultTypeDetail

        Public Sub New()
            MyBase.New
        End Sub

        Public Sub New(ByVal faultcode As System.Xml.XmlQualifiedName, ByVal faultstring As String, ByVal faultactor As String, ByVal detail As StockRequestFaultTypeDetail)
            MyBase.New
            Me.faultcode = faultcode
            Me.faultstring = faultstring
            Me.faultactor = faultactor
            Me.detail = detail
        End Sub
    End Class

    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>
    Public Interface StockRequestConsumerChannel
        Inherits IStockRequestConsumerService, System.ServiceModel.IClientChannel
    End Interface

    <'System.Diagnostics.DebuggerStepThroughAttribute(),
 System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>
    Partial Public Class StockRequestConsumerClient
        Inherits System.ServiceModel.ClientBase(Of IStockRequestConsumerService)
        Implements IStockRequestConsumerService

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
        Function stockRequestCallback(ByVal request As stockRequestCallback) As stockRequestCallback Implements IStockRequestConsumerService.stockRequestCallback
            Return MyBase.Channel.stockRequestCallback(request)
        End Function

        Public Sub stockRequestCallback(ByVal context As schemas.telekom.net.csdg_v01._01.TCContext, ByVal data As services.tint.telekom.net.SupAndPartMgmt.LogWarehouseMgmt.StockRequest_v01._00.types.StockRequestInputData)
            Dim inValue As stockRequestCallback = New stockRequestCallback()
            inValue.context = context
            inValue.data = data
            Dim retVal As stockRequestCallback = CType(Me, IStockRequestConsumerService).stockRequestCallback(inValue)
        End Sub

        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>
        Async Function stockRequestCallbackAsync(ByVal request As stockRequestCallback) As System.Threading.Tasks.Task(Of stockRequestCallbackResponse) Implements IStockRequestConsumerService.stockRequestCallbackAsync
            Return Await MyBase.Channel.stockRequestCallbackAsync(request)
        End Function

        Public Async Function stockRequestCallbackAsync(ByVal context As schemas.telekom.net.csdg_v01._01.TCContext, ByVal data As services.tint.telekom.net.SupAndPartMgmt.LogWarehouseMgmt.StockRequest_v01._00.types.StockRequestInputData) As System.Threading.Tasks.Task(Of stockRequestCallbackResponse)
            Dim inValue As stockRequestCallback = New stockRequestCallback()
            inValue.context = context
            inValue.data = data
            Return Await CType(Me, IStockRequestConsumerService).stockRequestCallbackAsync(inValue)
        End Function

        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>
        Function stockRequestFault(ByVal request As stockRequestFault) As stockRequestResponse Implements IStockRequestConsumerService.stockRequestFault
            Return MyBase.Channel.stockRequestFault(request)
        End Function

        Public Sub stockRequestFault(ByVal faultcode As System.Xml.XmlQualifiedName, ByVal faultstring As String, ByVal faultactor As String, ByVal detail As StockRequestFaultTypeDetail)
            Dim inValue As stockRequestFault = New stockRequestFault()
            inValue.faultcode = faultcode
            inValue.faultstring = faultstring
            inValue.faultactor = faultactor
            inValue.detail = detail
            Dim retVal As stockRequestResponse = CType(Me, IStockRequestConsumerService).stockRequestFault(inValue)
        End Sub

        '<System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>
        'Function StockRequestConsumer_stockRequestFaultAsync(ByVal request As stockRequestFaultRequest) As System.Threading.Tasks.Task(Of stockRequestResponse) Implements IStockRequestConsumerService.stockRequestFaultAsync
        '    Return MyBase.Channel.stockRequestFaultAsync(request)
        'End Function

        'Public Function stockRequestFaultAsync(ByVal faultcode As System.Xml.XmlQualifiedName, ByVal faultstring As String, ByVal faultactor As String, ByVal detail As StockRequestFaultTypeDetail) As System.Threading.Tasks.Task(Of stockRequestResponse)
        '    Dim inValue As stockRequestFaultRequest = New stockRequestFaultRequest()
        '    inValue.faultcode = faultcode
        '    inValue.faultstring = faultstring
        '    inValue.faultactor = faultactor
        '    inValue.detail = detail
        '    Return CType(Me, IStockRequestConsumerService).stockRequestFaultAsync(inValue)
        'End Function
    End Class
End Namespace


Namespace schemas.telekom.net.csdg_v01._01

    <System.Diagnostics.DebuggerStepThroughAttribute(),
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0"),
     System.Xml.Serialization.XmlSchemaProviderAttribute("ExportSchema"),
     System.Xml.Serialization.XmlRootAttribute(ElementName:="technicalFault", [Namespace]:="http://schemas.telekom.net/csdg_v01.01", IsNullable:=False)>
    Partial Public Class TCTechnicalFaultInfo
        Inherits Object
        Implements System.Xml.Serialization.IXmlSerializable

        Private nodesField() As System.Xml.XmlNode

        Private Shared typeName As System.Xml.XmlQualifiedName = New System.Xml.XmlQualifiedName("TCTechnicalFaultInfo", "http://schemas.telekom.net/csdg_v01.01")

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

        Private Shared typeName As System.Xml.XmlQualifiedName = New System.Xml.XmlQualifiedName("TCFaultInfo", "http://schemas.telekom.net/csdg_v01.01")

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
     System.Runtime.Serialization.DataContractAttribute(Name:="TCContext", [Namespace]:="http://schemas.telekom.net/csdg_v01.01")>
    Partial Public Class TCContext
        Inherits Object
        Implements System.Runtime.Serialization.IExtensibleDataObject

        Private extensionDataField As System.Runtime.Serialization.ExtensionDataObject

        Private technicalContextField As schemas.telekom.net.csdg_v01._01.TCTechnicalContext

        Private businessContextField As schemas.telekom.net.csdg_v01._01.TCBusinessContext

        Public Property ExtensionData() As System.Runtime.Serialization.ExtensionDataObject Implements System.Runtime.Serialization.IExtensibleDataObject.ExtensionData
            Get
                Return Me.extensionDataField
            End Get
            Set
                Me.extensionDataField = Value
            End Set
        End Property

        <System.Runtime.Serialization.DataMemberAttribute(IsRequired:=True, EmitDefaultValue:=False)>
        Public Property technicalContext() As schemas.telekom.net.csdg_v01._01.TCTechnicalContext
            Get
                Return Me.technicalContextField
            End Get
            Set
                Me.technicalContextField = Value
            End Set
        End Property

        <System.Runtime.Serialization.DataMemberAttribute(IsRequired:=True, EmitDefaultValue:=False, Order:=1)>
        Public Property businessContext() As schemas.telekom.net.csdg_v01._01.TCBusinessContext
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

        Private Shared typeName As System.Xml.XmlQualifiedName = New System.Xml.XmlQualifiedName("TCTechnicalContext", "http://schemas.telekom.net/csdg_v01.01")

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

        Private Shared typeName As System.Xml.XmlQualifiedName = New System.Xml.XmlQualifiedName("TCBusinessContext", "http://schemas.telekom.net/csdg_v01.01")

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


Namespace services.tint.telekom.net.SupAndPartMgmt.LogWarehouseMgmt.StockRequest_v01._00.types

    <System.Diagnostics.DebuggerStepThroughAttribute(),
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0"),
     System.Runtime.Serialization.CollectionDataContractAttribute(Name:="StockRequestInputData", [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/StockRequest_v01" &
        ".00/types", ItemName:="item")>
    Public Class StockRequestInputData
        Inherits System.Collections.Generic.List(Of services.tint.telekom.net.SupAndPartMgmt.LogWarehouseMgmt.StockRequest_v01._00.types.StockHeader)

        Friend Shadows Function Item() As List(Of StockAvailabilityItem)
            Dim b As List(Of StockAvailabilityItem) = New List(Of StockAvailabilityItem)
            b.Add(
            New StockAvailabilityItem With {.materialNumber = Nothing, .plant = Nothing, .quan = Nothing, .quanSpecified = True,
            .SN = Nothing, .stockInd = Nothing, .stockType = Nothing, .storLoc = Nothing, .UIID = Nothing, .uom = Nothing, .valType = Nothing}
            )
            Return b
        End Function
    End Class

    <System.Diagnostics.DebuggerStepThroughAttribute(),
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0"),
     System.Runtime.Serialization.DataContractAttribute(Name:="StockHeader", [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/StockRequest_v01" &
        ".00/types")>
    Partial Public Class StockHeader
        Inherits Object
        Implements System.Runtime.Serialization.IExtensibleDataObject

        Private extensionDataField As System.Runtime.Serialization.ExtensionDataObject

        Private plantField As String

        Private storLocField As String

        Private materialNumberField As String

        Private valTypeField As String

        Private withDetailsField As String

        Public Property ExtensionData() As System.Runtime.Serialization.ExtensionDataObject Implements System.Runtime.Serialization.IExtensibleDataObject.ExtensionData
            Get
                Return Me.extensionDataField
            End Get
            Set
                Me.extensionDataField = Value
            End Set
        End Property

        <System.Runtime.Serialization.DataMemberAttribute(IsRequired:=True, EmitDefaultValue:=False)>
        Public Property plant() As String
            Get
                Return Me.plantField
            End Get
            Set
                Me.plantField = Value
            End Set
        End Property

        <System.Runtime.Serialization.DataMemberAttribute(IsRequired:=True, EmitDefaultValue:=False)>
        Public Property storLoc() As String
            Get
                Return Me.storLocField
            End Get
            Set
                Me.storLocField = Value
            End Set
        End Property

        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=False, Order:=2)>
        Public Property materialNumber() As String
            Get
                Return Me.materialNumberField
            End Get
            Set
                Me.materialNumberField = Value
            End Set
        End Property

        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=False, Order:=3)>
        Public Property valType() As String
            Get
                Return Me.valTypeField
            End Get
            Set
                Me.valTypeField = Value
            End Set
        End Property

        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=False, Order:=4)>
        Public Property withDetails() As String
            Get
                Return Me.withDetailsField
            End Get
            Set
                Me.withDetailsField = Value
            End Set
        End Property
    End Class
End Namespace