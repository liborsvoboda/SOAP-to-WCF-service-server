
Option Strict Off
Option Explicit On

Imports System.Runtime.Serialization
Imports System.Web.Services
Imports ExpedisWSDL.messaging.ei.tmobile.net.datatypes

<Assembly: System.Runtime.Serialization.ContractNamespaceAttribute("http://messaging.ei.tmobile.net/datatypes", ClrNamespace:="messaging.ei.tmobile.net.datatypes")>
Namespace WMSDeliveryManagementService

    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),
     System.ServiceModel.ServiceContractAttribute([Namespace]:="http://logisticsordermanagement.supplypartnermanagement.tmobile.cz/ws/services/wmsdeliverymanagement")>
    Public Interface IWMSDeliveryManagement

        <System.ServiceModel.OperationContractAttribute(Action:="/webservices/WMSDeliveryManagement/notifyPackageStatus"),
         System.ServiceModel.FaultContractAttribute(GetType(messaging.ei.tmobile.net.datatypes.SOABPException2), Action:="/webservices/WMSDeliveryManagement/notifyPackageStatus", Name:="TechnicalExceptionElement"),
         System.ServiceModel.XmlSerializerFormatAttribute()>
        Function notifyPackageStatus(ByVal request As notifyPackageStatusRequest) As notifyPackageStatusResponse

        'CODEGEN: Probíhá generování kontraktu zprávy, protože operace má více návratových hodnot.
        '<System.ServiceModel.OperationContractAttribute(Action:="notifyPackageStatus", ReplyAction:="*")>
        'Function notifyPackageStatusAsync(ByVal request As notifyPackageStatusRequest) As System.Threading.Tasks.Task(Of notifyPackageStatusResponse)

        <System.ServiceModel.OperationContractAttribute(Action:="/webservices/WMSDeliveryManagement/receiveCourierLabel"),
         System.ServiceModel.FaultContractAttribute(GetType(messaging.ei.tmobile.net.datatypes.SOABPException2), Action:="/webservices/WMSDeliveryManagement/receiveCourierLabel", Name:="TechnicalExceptionElement"),
         System.ServiceModel.XmlSerializerFormatAttribute()>
        Function receiveCourierLabel(ByVal request As receiveCourierLabelRequest) As receiveCourierLabelResponse

        'CODEGEN: Probíhá generování kontraktu zprávy, protože operace má více návratových hodnot.
        '<System.ServiceModel.OperationContractAttribute(Action:="/webservices/WMSDeliveryManagement/receiveCourierLabel", ReplyAction:="*")>  _
        'Function receiveCourierLabelAsync(ByVal request As receiveCourierLabelRequest) As System.Threading.Tasks.Task(Of receiveCourierLabelResponse)
    End Interface



    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
     System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(),
     System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://messaging.ei.tmobile.net/datatypes")>
    Partial Public Class EIMessageContext3

        Private responseCodeField As String

        Private errorMessageField As String

        <System.Xml.Serialization.XmlElementAttribute(Order:=11)>
        Public Property responseCode() As String
            Get
                Return Me.responseCodeField
            End Get
            Set
                Me.responseCodeField = Value
            End Set
        End Property

        <System.Xml.Serialization.XmlElementAttribute(Order:=12)>
        Public Property errorMessage() As String
            Get
                Return Me.errorMessageField
            End Get
            Set
                Me.errorMessageField = Value
            End Set
        End Property

    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
     System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(),
     System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://messaging.ei.tmobile.net/datatypes")>
    Partial Public Class EIMessageContext2

        Private targetField As String

        Private replyToField As String

        Private requestIdField As String

        Private timeLeftField As Long

        Private timeLeftFieldSpecified As Boolean

        Private priorityField As Short

        Private priorityFieldSpecified As Boolean

        Private redeliveredField As EIMessageRedelivered

        Private redeliveredFieldSpecified As Boolean

        Private revisionField As String

        Private senderField As String

        Private correlationIdField As String

        Private sequenceIdField As String

        Private propertiesField() As EIMessageProperty

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property target() As String
            Get
                Return Me.targetField
            End Get
            Set
                Me.targetField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public Property replyTo() As String
            Get
                Return Me.replyToField
            End Get
            Set
                Me.replyToField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>
        Public Property requestId() As String
            Get
                Return Me.requestIdField
            End Get
            Set
                Me.requestIdField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=3)>
        Public Property timeLeft() As Long
            Get
                Return Me.timeLeftField
            End Get
            Set
                Me.timeLeftField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>
        Public Property timeLeftSpecified() As Boolean
            Get
                Return Me.timeLeftFieldSpecified
            End Get
            Set
                Me.timeLeftFieldSpecified = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=4)>
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
        <System.Xml.Serialization.XmlElementAttribute(Order:=5)>
        Public Property redelivered() As EIMessageRedelivered
            Get
                Return Me.redeliveredField
            End Get
            Set
                Me.redeliveredField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>
        Public Property redeliveredSpecified() As Boolean
            Get
                Return Me.redeliveredFieldSpecified
            End Get
            Set
                Me.redeliveredFieldSpecified = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=6)>
        Public Property revision() As String
            Get
                Return Me.revisionField
            End Get
            Set
                Me.revisionField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=7)>
        Public Property sender() As String
            Get
                Return Me.senderField
            End Get
            Set
                Me.senderField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=8)>
        Public Property correlationId() As String
            Get
                Return Me.correlationIdField
            End Get
            Set
                Me.correlationIdField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(DataType:="positiveInteger", Order:=9)>
        Public Property sequenceId() As String
            Get
                Return Me.sequenceIdField
            End Get
            Set
                Me.sequenceIdField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlArrayAttribute(Order:=10),
         System.Xml.Serialization.XmlArrayItemAttribute("property", IsNullable:=False)>
        Public Property properties() As EIMessageProperty()
            Get
                Return Me.propertiesField
            End Get
            Set
                Me.propertiesField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
     System.SerializableAttribute(),
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://messaging.ei.tmobile.net/datatypes")>
    Public Enum EIMessageRedelivered

        '''<remarks/>
        CLIENT

        '''<remarks/>
        SOABP

        '''<remarks/>
        MANUAL
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
     System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(),
     System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://messaging.ei.tmobile.net/datatypes")>
    Partial Public Class EIMessageProperty

        Private nameField As String

        Private policyField As String

        Private mustUnderstandField As Boolean

        Private typeField As EIMessagePropertyType

        Private typeFieldSpecified As Boolean

        Private valueField As String

        Public Sub New()
            MyBase.New
            Me.mustUnderstandField = False
        End Sub

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Qualified)>
        Public Property name() As String
            Get
                Return Me.nameField
            End Get
            Set
                Me.nameField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Qualified)>
        Public Property policy() As String
            Get
                Return Me.policyField
            End Get
            Set
                Me.policyField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Qualified),
         System.ComponentModel.DefaultValueAttribute(False)>
        Public Property mustUnderstand() As Boolean
            Get
                Return Me.mustUnderstandField
            End Get
            Set
                Me.mustUnderstandField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Qualified)>
        Public Property type() As EIMessagePropertyType
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
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://messaging.ei.tmobile.net/datatypes")>
    Public Enum EIMessagePropertyType

        '''<remarks/>
        [boolean]

        '''<remarks/>
        [byte]

        '''<remarks/>
        [short]

        '''<remarks/>
        int

        '''<remarks/>
        [long]

        '''<remarks/>
        float

        '''<remarks/>
        [double]

        '''<remarks/>
        [string]
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
     System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(),
     System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://logisticsordermanagement.supplypartnermanagement.tmobile.cz/ws/datatypes/w" &
        "msdeliverymanagement")>
    Partial Public Class WMSDeliveryManagement_receiveCourierLabelResponse

        Private someDataField As String

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property someData() As String
            Get
                Return Me.someDataField
            End Get
            Set
                Me.someDataField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
     System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(),
     System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://logisticsordermanagement.supplypartnermanagement.tmobile.cz/ws/datatypes/w" &
        "msdeliverymanagement")>
    Partial Public Class WMSDeliveryManagement_receiveCourierLabelRequest

        Private someDataField As String

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property someData() As String
            Get
                Return Me.someDataField
            End Get
            Set
                Me.someDataField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
     System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(),
     System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://logisticsordermanagement.supplypartnermanagement.tmobile.cz/ws/datatypes/w" &
        "msdeliverymanagement")>
    Partial Public Class WMSDeliveryManagement_notifyPackageStatusResponse

        Private someDataField As String

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property someData() As String
            Get
                Return Me.someDataField
            End Get
            Set
                Me.someDataField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
     System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(),
     System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://logisticsordermanagement.supplypartnermanagement.tmobile.cz/ws/datatypes/w" &
        "msdeliverymanagement")>
    Partial Public Class WMSDeliveryManagement_notifyPackageStatusRequest

        Private sapIdField As String

        Private orderIdField As String

        Private shipmentIdField As String

        Private packageStatusField As packageStatus

        Private listOfDocumentsField As listOfDocuments

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property sapId() As String
            Get
                Return Me.sapIdField
            End Get
            Set
                Me.sapIdField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public Property orderId() As String
            Get
                Return Me.orderIdField
            End Get
            Set
                Me.orderIdField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>
        Public Property shipmentId() As String
            Get
                Return Me.shipmentIdField
            End Get
            Set
                Me.shipmentIdField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=3)>
        Public Property packageStatus() As packageStatus
            Get
                Return Me.packageStatusField
            End Get
            Set
                Me.packageStatusField = Value
            End Set
        End Property

        <System.Xml.Serialization.XmlElementAttribute(Order:=4)>
        Public Property listOfDocuments() As listOfDocuments
            Get
                Return Me.listOfDocumentsField
            End Get
            Set
                Me.listOfDocumentsField = Value
            End Set
        End Property

    End Class




    <System.Diagnostics.DebuggerStepThroughAttribute(),
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),
     System.ServiceModel.MessageContractAttribute(WrapperName:="notifyPackageStatus", WrapperNamespace:="http://logisticsordermanagement.supplypartnermanagement.tmobile.cz/ws/services/wm" &
        "sdeliverymanagement", IsWrapped:=True)>
    Partial Public Class notifyPackageStatusRequest

        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="http://logisticsordermanagement.supplypartnermanagement.tmobile.cz/ws/services/wm" &
            "sdeliverymanagement", Order:=0)>
        Public eiMessageContext As EIMessageContext2

        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="http://logisticsordermanagement.supplypartnermanagement.tmobile.cz/ws/services/wm" &
            "sdeliverymanagement", Order:=1)>
        Public data As WMSDeliveryManagement_notifyPackageStatusRequest

        Public Sub New()
            MyBase.New
        End Sub

        Public Sub New(ByVal eiMessageContext As EIMessageContext2, ByVal data As WMSDeliveryManagement_notifyPackageStatusRequest)
            MyBase.New
            Me.eiMessageContext = eiMessageContext
            Me.data = data
        End Sub
    End Class

    <System.Diagnostics.DebuggerStepThroughAttribute(),
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),
     System.ServiceModel.MessageContractAttribute(WrapperName:="notifyPackageStatusOutput", WrapperNamespace:="http://logisticsordermanagement.supplypartnermanagement.tmobile.cz/ws/services/wm" &
        "sdeliverymanagement", IsWrapped:=True)>
    Partial Public Class notifyPackageStatusResponse

        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="http://logisticsordermanagement.supplypartnermanagement.tmobile.cz/ws/services/wm" &
            "sdeliverymanagement", Order:=0)>
        Public eiMessageContext As EIMessageContext3

        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="http://logisticsordermanagement.supplypartnermanagement.tmobile.cz/ws/services/wm" &
            "sdeliverymanagement", Order:=1)>
        Public data As WMSDeliveryManagement_notifyPackageStatusResponse

        Public Sub New()
            MyBase.New
        End Sub

        Public Sub New(ByVal eiMessageContext As EIMessageContext3, ByVal data As WMSDeliveryManagement_notifyPackageStatusResponse)
            MyBase.New
            Me.eiMessageContext = eiMessageContext
            Me.data = data
        End Sub
    End Class

    <System.Diagnostics.DebuggerStepThroughAttribute(),
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),
     System.ServiceModel.MessageContractAttribute(WrapperName:="receiveCourierLabel", WrapperNamespace:="http://logisticsordermanagement.supplypartnermanagement.tmobile.cz/ws/services/wm" &
        "sdeliverymanagement", IsWrapped:=True)>
    Partial Public Class receiveCourierLabelRequest

        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="http://logisticsordermanagement.supplypartnermanagement.tmobile.cz/ws/services/wm" &
            "sdeliverymanagement", Order:=0)>
        Public eiMessageContext As EIMessageContext2

        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="http://logisticsordermanagement.supplypartnermanagement.tmobile.cz/ws/services/wm" &
            "sdeliverymanagement", Order:=1)>
        Public data As WMSDeliveryManagement_receiveCourierLabelRequest

        Public Sub New()
            MyBase.New
        End Sub

        Public Sub New(ByVal eiMessageContext As EIMessageContext2, ByVal data As WMSDeliveryManagement_receiveCourierLabelRequest)
            MyBase.New
            Me.eiMessageContext = eiMessageContext
            Me.data = data
        End Sub
    End Class

    <System.Diagnostics.DebuggerStepThroughAttribute(),
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),
     System.ServiceModel.MessageContractAttribute(WrapperName:="receiveCourierLabelOutput", WrapperNamespace:="http://logisticsordermanagement.supplypartnermanagement.tmobile.cz/ws/services/wm" &
        "sdeliverymanagement", IsWrapped:=True)>
    Partial Public Class receiveCourierLabelResponse

        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="http://logisticsordermanagement.supplypartnermanagement.tmobile.cz/ws/services/wm" &
            "sdeliverymanagement", Order:=0)>
        Public eiMessageContext As EIMessageContext2

        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="http://logisticsordermanagement.supplypartnermanagement.tmobile.cz/ws/services/wm" &
            "sdeliverymanagement", Order:=1)>
        Public data As WMSDeliveryManagement_receiveCourierLabelResponse

        Public Sub New()
            MyBase.New
        End Sub

        Public Sub New(ByVal eiMessageContext As EIMessageContext2, ByVal data As WMSDeliveryManagement_receiveCourierLabelResponse)
            MyBase.New
            Me.eiMessageContext = eiMessageContext
            Me.data = data
        End Sub
    End Class

    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>
    Public Interface WMSDeliveryManagementChannel
        Inherits IWMSDeliveryManagement, System.ServiceModel.IClientChannel
    End Interface

    <System.Diagnostics.DebuggerStepThroughAttribute(),
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>
    Partial Public Class WMSDeliveryManagementClient
        Inherits System.ServiceModel.ClientBase(Of IWMSDeliveryManagement)
        Implements IWMSDeliveryManagement

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
        Function WMSDeliveryManagement_notifyPackageStatus(ByVal request As notifyPackageStatusRequest) As notifyPackageStatusResponse Implements IWMSDeliveryManagement.notifyPackageStatus
            Return MyBase.Channel.notifyPackageStatus(request)
        End Function

        Public Function notifyPackageStatus(ByRef eiMessageContext As EIMessageContext2, ByVal data As WMSDeliveryManagement_notifyPackageStatusRequest) As WMSDeliveryManagement_notifyPackageStatusResponse
            Dim inValue As notifyPackageStatusRequest = New notifyPackageStatusRequest()
            inValue.eiMessageContext = eiMessageContext
            inValue.data = data
            Dim retVal As notifyPackageStatusResponse = CType(Me, IWMSDeliveryManagement).notifyPackageStatus(inValue)
            'eiMessageContext = retVal.eiMessageContext
            Return retVal.data
        End Function

        'Public Function notifyPackageStatusAsync(ByVal request As notifyPackageStatusRequest) As System.Threading.Tasks.Task(Of notifyPackageStatusResponse) Implements WMSDeliveryManagement.notifyPackageStatusAsync
        '    Return MyBase.Channel.notifyPackageStatusAsync(request)
        'End Function

        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>
        Function WMSDeliveryManagement_receiveCourierLabel(ByVal request As receiveCourierLabelRequest) As receiveCourierLabelResponse Implements IWMSDeliveryManagement.receiveCourierLabel
            Return MyBase.Channel.receiveCourierLabel(request)
        End Function

        Public Function receiveCourierLabel(ByRef eiMessageContext As EIMessageContext2, ByVal data As WMSDeliveryManagement_receiveCourierLabelRequest) As WMSDeliveryManagement_receiveCourierLabelResponse
            Dim inValue As receiveCourierLabelRequest = New receiveCourierLabelRequest()
            inValue.eiMessageContext = eiMessageContext
            inValue.data = data
            Dim retVal As receiveCourierLabelResponse = CType(Me, IWMSDeliveryManagement).receiveCourierLabel(inValue)
            eiMessageContext = retVal.eiMessageContext
            Return retVal.data
        End Function

        'Public Function receiveCourierLabelAsync(ByVal request As receiveCourierLabelRequest) As System.Threading.Tasks.Task(Of receiveCourierLabelResponse) Implements WMSDeliveryManagement.receiveCourierLabelAsync
        '    Return MyBase.Channel.receiveCourierLabelAsync(request)
        'End Function
    End Class
End Namespace

Namespace messaging.ei.tmobile.net.datatypes

    <System.Diagnostics.DebuggerStepThroughAttribute(),
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0"),
     System.Xml.Serialization.XmlSchemaProviderAttribute("ExportSchema"),
     System.Xml.Serialization.XmlRootAttribute(ElementName:="TechnicalExceptionElement", [Namespace]:="http://logisticsordermanagement.supplypartnermanagement.tmobile.cz/ws/services/wm" &
        "sdeliverymanagement", IsNullable:=False)>
    Partial Public Class SOABPException2
        Inherits Object
        Implements System.Xml.Serialization.IXmlSerializable

        Private nodesField() As System.Xml.XmlNode

        Private Shared typeName As System.Xml.XmlQualifiedName = New System.Xml.XmlQualifiedName("SOABPException2", "http://messaging.ei.tmobile.net/datatypes")

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

    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
     System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(),
     System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://messaging.ei.tmobile.net/datatypes")>
    Partial Public Class listOfDocuments

        Private documentField() As document

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property document() As document()
            Get
                Return Me.documentField
            End Get
            Set
                Me.documentField = Value
            End Set
        End Property
    End Class

    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
     System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(),
     System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://messaging.ei.tmobile.net/datatypes")>
    Partial Public Class document

        Private documentTypeField As String

        Private templateIdField As String

        Private documentDescriptionField As String

        Private barCodeField As String

        Public Sub New()
            MyBase.New
        End Sub

        <System.Xml.Serialization.XmlElementAttribute(Order:=0, IsNullable:=True)>
        Public Property documentType() As String
            Get
                Return Me.documentTypeField
            End Get
            Set
                Me.documentTypeField = Value
            End Set
        End Property

        <System.Xml.Serialization.XmlElementAttribute(Order:=1, IsNullable:=True)>
        Public Property templateId() As String
            Get
                Return Me.templateIdField
            End Get
            Set
                Me.templateIdField = Value
            End Set
        End Property

        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>
        Public Property documentDescription() As String
            Get
                Return Me.documentDescriptionField
            End Get
            Set
                Me.documentDescriptionField = Value
            End Set
        End Property


        <System.Xml.Serialization.XmlElementAttribute(Order:=3, IsNullable:=True)>
        Public Property barCode() As String
            Get
                Return Me.barCodeField
            End Get
            Set
                Me.barCodeField = Value
            End Set
        End Property

    End Class


    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
     System.SerializableAttribute(),
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://messaging.ei.tmobile.net/datatypes")>
    Public Enum packageStatus

        '''<remarks/>
        finish

    End Enum

    <System.Diagnostics.DebuggerStepThroughAttribute(),
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0"),
     System.Runtime.Serialization.DataContractAttribute(Name:="EIMessageContext2", [Namespace]:="http://messaging.ei.tmobile.net/datatypes")>
    Partial Public Class EIMessageContext2
        Inherits Object
        Implements System.Runtime.Serialization.IExtensibleDataObject

        Private extensionDataField As System.Runtime.Serialization.ExtensionDataObject

        Private targetField As String

        Private replyToField As String

        Private requestIdField As String

        Private responseCodeField As String

        Private errorMessageField As String

        Private timeLeftField As Long

        Private priorityField As Short

        Private redeliveredField As messaging.ei.tmobile.net.datatypes.EIMessageRedelivered

        Private revisionField As String

        Private senderField As String

        Private correlationIdField As String

        Private sequenceIdField As Long

        Private propertiesField As messaging.ei.tmobile.net.datatypes.EIMessagePropertyCollection

        Public Property ExtensionData() As System.Runtime.Serialization.ExtensionDataObject Implements System.Runtime.Serialization.IExtensibleDataObject.ExtensionData
            Get
                Return Me.extensionDataField
            End Get
            Set
                Me.extensionDataField = Value
            End Set
        End Property

        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=False)>
        Public Property target() As String
            Get
                Return Me.targetField
            End Get
            Set
                Me.targetField = Value
            End Set
        End Property


        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=False, Order:=1)>
        Public Property replyTo() As String
            Get
                Return Me.replyToField
            End Get
            Set
                Me.replyToField = Value
            End Set
        End Property

        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=False, Order:=2)>
        Public Property requestId() As String
            Get
                Return Me.requestIdField
            End Get
            Set
                Me.requestIdField = Value
            End Set
        End Property

        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=False, Order:=3)>
        Public Property responseCode() As String
            Get
                Return Me.responseCodeField
            End Get
            Set
                Me.responseCodeField = Value
            End Set
        End Property

        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=False, Order:=4)>
        Public Property errorMessage() As String
            Get
                Return Me.errorMessageField
            End Get
            Set
                Me.errorMessageField = Value
            End Set
        End Property


        <System.Runtime.Serialization.DataMemberAttribute(Order:=3)>
        Public Property timeLeft() As Long
            Get
                Return Me.timeLeftField
            End Get
            Set
                Me.timeLeftField = Value
            End Set
        End Property

        <System.Runtime.Serialization.DataMemberAttribute(Order:=4)>
        Public Property priority() As Short
            Get
                Return Me.priorityField
            End Get
            Set
                Me.priorityField = Value
            End Set
        End Property

        <System.Runtime.Serialization.DataMemberAttribute(Order:=5)>
        Public Property redelivered() As messaging.ei.tmobile.net.datatypes.EIMessageRedelivered
            Get
                Return Me.redeliveredField
            End Get
            Set
                Me.redeliveredField = Value
            End Set
        End Property

        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=False, Order:=6)>
        Public Property revision() As String
            Get
                Return Me.revisionField
            End Get
            Set
                Me.revisionField = Value
            End Set
        End Property

        <System.Runtime.Serialization.DataMemberAttribute(IsRequired:=True, EmitDefaultValue:=False, Order:=7)>
        Public Property sender() As String
            Get
                Return Me.senderField
            End Get
            Set
                Me.senderField = Value
            End Set
        End Property

        <System.Runtime.Serialization.DataMemberAttribute(IsRequired:=True, EmitDefaultValue:=False, Order:=8)>
        Public Property correlationId() As String
            Get
                Return Me.correlationIdField
            End Get
            Set
                Me.correlationIdField = Value
            End Set
        End Property

        <System.Runtime.Serialization.DataMemberAttribute(Order:=9)>
        Public Property sequenceId() As Long
            Get
                Return Me.sequenceIdField
            End Get
            Set
                Me.sequenceIdField = Value
            End Set
        End Property

        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=False, Order:=10)>
        Public Property properties() As messaging.ei.tmobile.net.datatypes.EIMessagePropertyCollection
            Get
                Return Me.propertiesField
            End Get
            Set
                Me.propertiesField = Value
            End Set
        End Property
    End Class

    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0"),
     System.Runtime.Serialization.DataContractAttribute(Name:="EIMessageRedelivered", [Namespace]:="http://messaging.ei.tmobile.net/datatypes")>
    Public Enum EIMessageRedelivered As Integer

        <System.Runtime.Serialization.EnumMemberAttribute()>
        CLIENT = 0

        <System.Runtime.Serialization.EnumMemberAttribute()>
        SOABP = 1

        <System.Runtime.Serialization.EnumMemberAttribute()>
        MANUAL = 2
    End Enum

    <System.Diagnostics.DebuggerStepThroughAttribute(),
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0"),
     System.Runtime.Serialization.CollectionDataContractAttribute(Name:="EIMessagePropertyCollection", [Namespace]:="http://messaging.ei.tmobile.net/datatypes", ItemName:="property")>
    Public Class EIMessagePropertyCollection
        Inherits System.Collections.Generic.List(Of messaging.ei.tmobile.net.datatypes.EIMessageProperty)
    End Class

    <System.Diagnostics.DebuggerStepThroughAttribute(),
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0"),
     System.Xml.Serialization.XmlSchemaProviderAttribute("ExportSchema"),
     System.Xml.Serialization.XmlRootAttribute(IsNullable:=False)>
    Partial Public Class EIMessageProperty
        Inherits Object
        Implements System.Xml.Serialization.IXmlSerializable

        Private nodesField() As System.Xml.XmlNode

        Private Shared typeName As System.Xml.XmlQualifiedName = New System.Xml.XmlQualifiedName("EIMessageProperty", "http://messaging.ei.tmobile.net/datatypes")

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
