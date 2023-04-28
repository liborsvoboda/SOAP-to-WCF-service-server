Option Strict Off
Option Explicit On
Imports System.Web.Services


<Assembly: System.Runtime.Serialization.ContractNamespaceAttribute("http://www.App.sk/soa/COURIERSERVICESInterface/xsd", ClrNamespace:="www.tmobile.sk.soa.COURIERSERVICESInterface.xsd")>

Namespace CourierDeliveryManagementSoapPortTypeService
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),
 System.ServiceModel.ServiceContractAttribute(Name:="CourierDeliveryManagementSoapPortTypeService", [Namespace]:="http://www.App.sk/soa/COURIERSERVICESInterface")>
    Public Interface ICourierDeliveryManagementSoapPortTypeService

        'CODEGEN: Probíhá generování kontraktu zprávy, protože operace requestCourierDelivery není RPC ani není zabalena dokumentem.
        <System.ServiceModel.OperationContractAttribute(Action:="CourierDeliveryManagement.requestCourierDelivery"),
         System.ServiceModel.FaultContractAttribute(GetType(www.tmobile.sk.soa.COURIERSERVICESInterface.xsd.requestCourierDeliveryFault), Action:="CourierDeliveryManagement.requestCourierDelivery", Name:="requestCourierDeliveryFault", [Namespace]:="http://www.App.sk/soa/COURIERSERVICESInterface/xsd"),
         System.ServiceModel.XmlSerializerFormatAttribute(),
         System.ServiceModel.ServiceKnownTypeAttribute(GetType(ResponseMessage)),
         System.ServiceModel.ServiceKnownTypeAttribute(GetType(Header))>
        Function requestCourierDelivery(ByVal request As requestCourierDeliveryRequest1) As requestCourierDeliveryResponse1

        '<System.ServiceModel.OperationContractAttribute(Action:="CourierDeliveryManagement.requestCourierDelivery", ReplyAction:="*")>
        'Function requestCourierDeliveryAsync(ByVal request As requestCourierDeliveryRequest1) As System.Threading.Tasks.Task(Of requestCourierDeliveryResponse1)

        'CODEGEN: Probíhá generování kontraktu zprávy, protože operace deliveryDocumentsNotify není RPC ani není zabalena dokumentem.
        <System.ServiceModel.OperationContractAttribute(Action:="CourierDeliveryManagement.deliveryDocumentsNotify"),
         System.ServiceModel.FaultContractAttribute(GetType(www.tmobile.sk.soa.COURIERSERVICESInterface.xsd.deliveryDocumentsNotifyFault), Action:="CourierDeliveryManagement.deliveryDocumentsNotify", Name:="deliveryDocumentsNotifyFault", [Namespace]:="http://www.App.sk/soa/COURIERSERVICESInterface/xsd"),
         System.ServiceModel.XmlSerializerFormatAttribute(),
         System.ServiceModel.ServiceKnownTypeAttribute(GetType(ResponseMessage)),
         System.ServiceModel.ServiceKnownTypeAttribute(GetType(Header))>
        Function deliveryDocumentsNotify(ByVal request As deliveryDocumentsNotifyRequest1) As deliveryDocumentsNotifyResponse1

        '<System.ServiceModel.OperationContractAttribute(Action:="CourierDeliveryManagement.deliveryDocumentsNotify", ReplyAction:="*")>
        'Function deliveryDocumentsNotifyAsync(ByVal request As deliveryDocumentsNotifyRequest1) As System.Threading.Tasks.Task(Of deliveryDocumentsNotifyResponse1)

        'CODEGEN: Probíhá generování kontraktu zprávy, protože operace requestCourierLabel není RPC ani není zabalena dokumentem.
        <System.ServiceModel.OperationContractAttribute(Action:="CourierDeliveryManagement.requestCourierLabel"),
         System.ServiceModel.FaultContractAttribute(GetType(www.tmobile.sk.soa.COURIERSERVICESInterface.xsd.requestCourierLabelFault), Action:="CourierDeliveryManagement.requestCourierLabel", Name:="requestCourierLabelFault", [Namespace]:="http://www.App.sk/soa/COURIERSERVICESInterface/xsd"),
         System.ServiceModel.XmlSerializerFormatAttribute(),
         System.ServiceModel.ServiceKnownTypeAttribute(GetType(ResponseMessage)),
         System.ServiceModel.ServiceKnownTypeAttribute(GetType(Header))>
        Function requestCourierLabel(ByVal request As requestCourierLabelRequest1) As requestCourierLabelResponse1

        '<System.ServiceModel.OperationContractAttribute(Action:="CourierDeliveryManagement.requestCourierLabel", ReplyAction:="*")>
        'Function requestCourierLabelAsync(ByVal request As requestCourierLabelRequest1) As System.Threading.Tasks.Task(Of requestCourierLabelResponse1)

    End Interface

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
     System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(),
     System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.App.sk/soa/COURIERSERVICESInterface/xsd")>
    Partial Public Class requestCourierDeliveryIn
        Inherits Header

        Private bodyField As requestCourierDeliveryRequest

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=0)>
        Public Property Body() As requestCourierDeliveryRequest
            Get
                Return Me.bodyField
            End Get
            Set
                Me.bodyField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
     System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(),
     System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://www.App.sk/soa/COURIERSERVICESInterface/xsd")>
    Partial Public Class requestCourierDeliveryRequest

        Private idField As String

        Private externalIdField As String

        Private signatureTypeField As String

        Private signaturePINField As String

        Private personalIdScanField As Boolean

        Private personalIdScanFieldSpecified As Boolean

        Private personalIdVerificationField As Boolean

        Private personalIdVerificationFieldSpecified As Boolean

        Private createdField As Date

        Private createdFieldSpecified As Boolean

        Private shopCodeField As String

        Private deliveryContentField As String

        Private oversizedPackageField As String

        Private packageCountField As String

        Private customerField As Customer

        Private packagesField() As Package

        Private paymentsField() As Payment

        Private courierServicesField() As Attributes

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=0)>
        Public Property id() As String
            Get
                Return Me.idField
            End Get
            Set
                Me.idField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=1)>
        Public Property externalId() As String
            Get
                Return Me.externalIdField
            End Get
            Set
                Me.externalIdField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=2)>
        Public Property signatureType() As String
            Get
                Return Me.signatureTypeField
            End Get
            Set
                Me.signatureTypeField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=3)>
        Public Property signaturePIN() As String
            Get
                Return Me.signaturePINField
            End Get
            Set
                Me.signaturePINField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=4)>
        Public Property personalIdScan() As Boolean
            Get
                Return Me.personalIdScanField
            End Get
            Set
                Me.personalIdScanField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>
        Public Property personalIdScanSpecified() As Boolean
            Get
                Return Me.personalIdScanFieldSpecified
            End Get
            Set
                Me.personalIdScanFieldSpecified = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=5)>
        Public Property personalIdVerification() As Boolean
            Get
                Return Me.personalIdVerificationField
            End Get
            Set
                Me.personalIdVerificationField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>
        Public Property personalIdVerificationSpecified() As Boolean
            Get
                Return Me.personalIdVerificationFieldSpecified
            End Get
            Set
                Me.personalIdVerificationFieldSpecified = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=6)>
        Public Property created() As Date
            Get
                Return Me.createdField
            End Get
            Set
                Me.createdField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>
        Public Property createdSpecified() As Boolean
            Get
                Return Me.createdFieldSpecified
            End Get
            Set
                Me.createdFieldSpecified = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=7)>
        Public Property shopCode() As String
            Get
                Return Me.shopCodeField
            End Get
            Set
                Me.shopCodeField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=8)>
        Public Property deliveryContent() As String
            Get
                Return Me.deliveryContentField
            End Get
            Set
                Me.deliveryContentField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=9)>
        Public Property packageCount() As String
            Get
                Return Me.packageCountField
            End Get
            Set
                Me.packageCountField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=10)>
        Public Property oversizedPackage() As String
            Get
                Return Me.oversizedPackageField
            End Get
            Set
                Me.oversizedPackageField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=11)>
        Public Property customer() As Customer
            Get
                Return Me.customerField
            End Get
            Set
                Me.customerField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("packages", Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=12)>
        Public Property packages() As Package()
            Get
                Return Me.packagesField
            End Get
            Set
                Me.packagesField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("payments", Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=13)>
        Public Property payments() As Payment()
            Get
                Return Me.paymentsField
            End Get
            Set
                Me.paymentsField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("courierServices", Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=14)>
        Public Property courierServices() As Attributes()
            Get
                Return Me.courierServicesField
            End Get
            Set
                Me.courierServicesField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
     System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(),
     System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://www.App.sk/soa/COURIERSERVICESInterface/xsd")>
    Partial Public Class Customer

        Private typeField As String

        Private externalIdField As String

        Private firstNameField As String

        Private lastNameField As String

        Private companyIdField As String

        Private personalIdField As String

        Private mobilePhoneNumField As String

        Private fixPhoneNumField As String

        Private emailField As String

        Private addressesField() As Address

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=0)>
        Public Property type() As String
            Get
                Return Me.typeField
            End Get
            Set
                Me.typeField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=1)>
        Public Property externalId() As String
            Get
                Return Me.externalIdField
            End Get
            Set
                Me.externalIdField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=2)>
        Public Property firstName() As String
            Get
                Return Me.firstNameField
            End Get
            Set
                Me.firstNameField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=3)>
        Public Property lastName() As String
            Get
                Return Me.lastNameField
            End Get
            Set
                Me.lastNameField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=4)>
        Public Property companyId() As String
            Get
                Return Me.companyIdField
            End Get
            Set
                Me.companyIdField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=5)>
        Public Property personalId() As String
            Get
                Return Me.personalIdField
            End Get
            Set
                Me.personalIdField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=6)>
        Public Property mobilePhoneNum() As String
            Get
                Return Me.mobilePhoneNumField
            End Get
            Set
                Me.mobilePhoneNumField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=7)>
        Public Property fixPhoneNum() As String
            Get
                Return Me.fixPhoneNumField
            End Get
            Set
                Me.fixPhoneNumField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=8)>
        Public Property email() As String
            Get
                Return Me.emailField
            End Get
            Set
                Me.emailField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("addresses", Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=9)>
        Public Property addresses() As Address()
            Get
                Return Me.addressesField
            End Get
            Set
                Me.addressesField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
     System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(),
     System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://www.App.sk/soa/COURIERSERVICESInterface/xsd")>
    Partial Public Class Address

        Private typeField As String

        Private externalIdField As String

        Private streetNameField As String

        Private streetNumberField As String

        Private houseNumberField As String

        Private flloorField As String

        Private cityField As String

        Private zipField As String

        Private districtField As String

        Private countryField As String

        Private noteField As String

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=0)>
        Public Property type() As String
            Get
                Return Me.typeField
            End Get
            Set
                Me.typeField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=1)>
        Public Property externalId() As String
            Get
                Return Me.externalIdField
            End Get
            Set
                Me.externalIdField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=2)>
        Public Property streetName() As String
            Get
                Return Me.streetNameField
            End Get
            Set
                Me.streetNameField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=3)>
        Public Property streetNumber() As String
            Get
                Return Me.streetNumberField
            End Get
            Set
                Me.streetNumberField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=4)>
        Public Property houseNumber() As String
            Get
                Return Me.houseNumberField
            End Get
            Set
                Me.houseNumberField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=5)>
        Public Property flloor() As String
            Get
                Return Me.flloorField
            End Get
            Set
                Me.flloorField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=6)>
        Public Property city() As String
            Get
                Return Me.cityField
            End Get
            Set
                Me.cityField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=7)>
        Public Property zip() As String
            Get
                Return Me.zipField
            End Get
            Set
                Me.zipField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=8)>
        Public Property district() As String
            Get
                Return Me.districtField
            End Get
            Set
                Me.districtField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=9)>
        Public Property country() As String
            Get
                Return Me.countryField
            End Get
            Set
                Me.countryField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=10)>
        Public Property note() As String
            Get
                Return Me.noteField
            End Get
            Set
                Me.noteField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
     System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(),
     System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://www.App.sk/soa/COURIERSERVICESInterface/xsd")>
    Partial Public Class requestCourierLabelResponse

        Private fileNameField As String

        Private mimeTypeField As String

        Private binaryContentField() As Byte

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=0)>
        Public Property fileName() As String
            Get
                Return Me.fileNameField
            End Get
            Set
                Me.fileNameField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=1)>
        Public Property mimeType() As String
            Get
                Return Me.mimeTypeField
            End Get
            Set
                Me.mimeTypeField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType:="base64Binary", Order:=2)>
        Public Property binaryContent() As Byte()
            Get
                Return Me.binaryContentField
            End Get
            Set
                Me.binaryContentField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
     System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(),
     System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://www.App.sk/soa/COURIERSERVICESInterface/xsd")>
    Partial Public Class requestCourierLabelRequest

        Private externalIdField As String

        Private trackingIdField As String

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=0)>
        Public Property externalId() As String
            Get
                Return Me.externalIdField
            End Get
            Set
                Me.externalIdField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=1)>
        Public Property trackingId() As String
            Get
                Return Me.trackingIdField
            End Get
            Set
                Me.trackingIdField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
     System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(),
     System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://www.App.sk/soa/COURIERSERVICESInterface/xsd")>
    Partial Public Class deliveryDocumentsNotifyResponse
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
     System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(),
     System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://www.App.sk/soa/COURIERSERVICESInterface/xsd")>
    Partial Public Class deliveryDocumentsNotifyRequest

        Private externalDeliveryIdField As String

        Private trackingIdField As String

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=0)>
        Public Property externalDeliveryId() As String
            Get
                Return Me.externalDeliveryIdField
            End Get
            Set
                Me.externalDeliveryIdField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=1)>
        Public Property trackingId() As String
            Get
                Return Me.trackingIdField
            End Get
            Set
                Me.trackingIdField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
     System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(),
     System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://www.App.sk/soa/COURIERSERVICESInterface/xsd")>
    Partial Public Class requestCourierDeliveryResponse
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
     System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(),
     System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://www.App.sk/soa/COURIERSERVICESInterface/xsd")>
    Partial Public Class ResponseMessage

        Private messageIdField As String

        Private statusField As String

        Private statusCodeField As String

        Private statusMessageField As String

        Private stackTraceField As String

        Private timestampField As Date

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=0)>
        Public Property messageId() As String
            Get
                Return Me.messageIdField
            End Get
            Set
                Me.messageIdField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=1)>
        Public Property status() As String
            Get
                Return Me.statusField
            End Get
            Set
                Me.statusField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=2)>
        Public Property statusCode() As String
            Get
                Return Me.statusCodeField
            End Get
            Set
                Me.statusCodeField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=3)>
        Public Property statusMessage() As String
            Get
                Return Me.statusMessageField
            End Get
            Set
                Me.statusMessageField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=4)>
        Public Property stackTrace() As String
            Get
                Return Me.stackTraceField
            End Get
            Set
                Me.stackTraceField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=5)>
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
     System.Diagnostics.DebuggerStepThroughAttribute(),
     System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://www.App.sk/soa/COURIERSERVICESInterface/xsd")>
    Partial Public Class Attributes

        Private nameField As String

        Private valueField As String

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=0)>
        Public Property name() As String
            Get
                Return Me.nameField
            End Get
            Set
                Me.nameField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=1)>
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
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://www.App.sk/soa/COURIERSERVICESInterface/xsd")>
    Partial Public Class Payment

        Private typeField As String

        Private packageIdField As String

        Private priceField As String

        Private netPriceField As String

        Private refNumberField As String

        Private currencyField As String

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=0)>
        Public Property type() As String
            Get
                Return Me.typeField
            End Get
            Set
                Me.typeField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=1)>
        Public Property packageId() As String
            Get
                Return Me.packageIdField
            End Get
            Set
                Me.packageIdField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=2)>
        Public Property price() As String
            Get
                Return Me.priceField
            End Get
            Set
                Me.priceField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=3)>
        Public Property netPrice() As String
            Get
                Return Me.netPriceField
            End Get
            Set
                Me.netPriceField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=4)>
        Public Property refNumber() As String
            Get
                Return Me.refNumberField
            End Get
            Set
                Me.refNumberField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=5)>
        Public Property currency() As String
            Get
                Return Me.currencyField
            End Get
            Set
                Me.currencyField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
     System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(),
     System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://www.App.sk/soa/COURIERSERVICESInterface/xsd")>
    Partial Public Class Package

        Private packageIdField As String

        Private shipmentIdField As String

        Private deliveryNoteIdField As String

        Private deliveryTypeField As String

        Private priceField As Decimal

        Private priceFieldSpecified As Boolean

        Private weightField As Decimal

        Private weightFieldSpecified As Boolean

        Private noteField As String



        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=0)>
        Public Property packageId() As String
            Get
                Return Me.packageIdField
            End Get
            Set
                Me.packageIdField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=1)>
        Public Property shipmentId() As String
            Get
                Return Me.shipmentIdField
            End Get
            Set
                Me.shipmentIdField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=2)>
        Public Property deliveryNoteId() As String
            Get
                Return Me.deliveryNoteIdField
            End Get
            Set
                Me.deliveryNoteIdField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=3)>
        Public Property deliveryType() As String
            Get
                Return Me.deliveryTypeField
            End Get
            Set
                Me.deliveryTypeField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=4)>
        Public Property price() As Decimal
            Get
                Return Me.priceField
            End Get
            Set
                Me.priceField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>
        Public Property priceSpecified() As Boolean
            Get
                Return Me.priceFieldSpecified
            End Get
            Set
                Me.priceFieldSpecified = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=5)>
        Public Property weight() As Decimal
            Get
                Return Me.weightField
            End Get
            Set
                Me.weightField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>
        Public Property weightSpecified() As Boolean
            Get
                Return Me.weightFieldSpecified
            End Get
            Set
                Me.weightFieldSpecified = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=6)>
        Public Property note() As String
            Get
                Return Me.noteField
            End Get
            Set
                Me.noteField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
     System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(),
     System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://www.App.sk/soa/COURIERSERVICESInterface/xsd")>
    Partial Public Class Header

        Private typeField As String

        Private versionField As String

        Private messageIdField As String

        Private correlationIdField As String

        Private originatorField As String

        Private targetField As String

        Private operationField As String

        Private timestampField As Date

        Private userField As String

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=0)>
        Public Property type() As String
            Get
                Return Me.typeField
            End Get
            Set
                Me.typeField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=1)>
        Public Property version() As String
            Get
                Return Me.versionField
            End Get
            Set
                Me.versionField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=2)>
        Public Property messageId() As String
            Get
                Return Me.messageIdField
            End Get
            Set
                Me.messageIdField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=3)>
        Public Property correlationId() As String
            Get
                Return Me.correlationIdField
            End Get
            Set
                Me.correlationIdField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=4)>
        Public Property originator() As String
            Get
                Return Me.originatorField
            End Get
            Set
                Me.originatorField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=5)>
        Public Property target() As String
            Get
                Return Me.targetField
            End Get
            Set
                Me.targetField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=6)>
        Public Property operation() As String
            Get
                Return Me.operationField
            End Get
            Set
                Me.operationField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=7)>
        Public Property timestamp() As Date
            Get
                Return Me.timestampField
            End Get
            Set
                Me.timestampField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=8)>
        Public Property user() As String
            Get
                Return Me.userField
            End Get
            Set
                Me.userField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
     System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(),
     System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.App.sk/soa/COURIERSERVICESInterface/xsd")>
    Partial Public Class requestCourierDeliveryOut
        Inherits ResponseMessage

        Private bodyField As requestCourierDeliveryResponse

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=0)>
        Public Property Body() As requestCourierDeliveryResponse
            Get
                Return Me.bodyField
            End Get
            Set
                Me.bodyField = Value
            End Set
        End Property
    End Class

    <System.Diagnostics.DebuggerStepThroughAttribute(),
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),
     System.ServiceModel.MessageContractAttribute(IsWrapped:=False)>
    Partial Public Class requestCourierDeliveryRequest1

        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="http://www.App.sk/soa/COURIERSERVICESInterface/xsd", Order:=0)>
        Public requestCourierDeliveryIn As requestCourierDeliveryIn

        Public Sub New()
            MyBase.New
        End Sub

        Public Sub New(ByVal requestCourierDeliveryIn As requestCourierDeliveryIn)
            MyBase.New
            Me.requestCourierDeliveryIn = requestCourierDeliveryIn
        End Sub
    End Class

    <System.Diagnostics.DebuggerStepThroughAttribute(),
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),
     System.ServiceModel.MessageContractAttribute(IsWrapped:=False)>
    Partial Public Class requestCourierDeliveryResponse1

        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="http://www.App.sk/soa/COURIERSERVICESInterface/xsd", Order:=0)>
        Public requestCourierDeliveryOut As requestCourierDeliveryOut

        Public Sub New()
            MyBase.New
        End Sub

        Public Sub New(ByVal requestCourierDeliveryOut As requestCourierDeliveryOut)
            MyBase.New
            Me.requestCourierDeliveryOut = requestCourierDeliveryOut
        End Sub
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
     System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(),
     System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.App.sk/soa/COURIERSERVICESInterface/xsd")>
    Partial Public Class deliveryDocumentsNotifyIn
        Inherits Header

        Private bodyField As deliveryDocumentsNotifyRequest

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=0)>
        Public Property Body() As deliveryDocumentsNotifyRequest
            Get
                Return Me.bodyField
            End Get
            Set
                Me.bodyField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
     System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(),
     System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.App.sk/soa/COURIERSERVICESInterface/xsd")>
    Partial Public Class deliveryDocumentsNotifyOut
        Inherits ResponseMessage

        Private bodyField As deliveryDocumentsNotifyResponse

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=0)>
        Public Property Body() As deliveryDocumentsNotifyResponse
            Get
                Return Me.bodyField
            End Get
            Set
                Me.bodyField = Value
            End Set
        End Property
    End Class

    <System.Diagnostics.DebuggerStepThroughAttribute(),
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),
     System.ServiceModel.MessageContractAttribute(IsWrapped:=False)>
    Partial Public Class deliveryDocumentsNotifyRequest1

        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="http://www.App.sk/soa/COURIERSERVICESInterface/xsd", Order:=0)>
        Public deliveryDocumentsNotifyIn As deliveryDocumentsNotifyIn

        Public Sub New()
            MyBase.New
        End Sub

        Public Sub New(ByVal deliveryDocumentsNotifyIn As deliveryDocumentsNotifyIn)
            MyBase.New
            Me.deliveryDocumentsNotifyIn = deliveryDocumentsNotifyIn
        End Sub
    End Class

    <System.Diagnostics.DebuggerStepThroughAttribute(),
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),
     System.ServiceModel.MessageContractAttribute(IsWrapped:=False)>
    Partial Public Class deliveryDocumentsNotifyResponse1

        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="http://www.App.sk/soa/COURIERSERVICESInterface/xsd", Order:=0)>
        Public deliveryDocumentsNotifyOut As deliveryDocumentsNotifyOut

        Public Sub New()
            MyBase.New
        End Sub

        Public Sub New(ByVal deliveryDocumentsNotifyOut As deliveryDocumentsNotifyOut)
            MyBase.New
            Me.deliveryDocumentsNotifyOut = deliveryDocumentsNotifyOut
        End Sub
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
     System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(),
     System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.App.sk/soa/COURIERSERVICESInterface/xsd")>
    Partial Public Class requestCourierLabelIn
        Inherits Header

        Private bodyField As requestCourierLabelRequest

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=0)>
        Public Property Body() As requestCourierLabelRequest
            Get
                Return Me.bodyField
            End Get
            Set
                Me.bodyField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
     System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(),
     System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.App.sk/soa/COURIERSERVICESInterface/xsd")>
    Partial Public Class requestCourierLabelOut
        Inherits ResponseMessage

        Private bodyField As requestCourierLabelResponse

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=0)>
        Public Property Body() As requestCourierLabelResponse
            Get
                Return Me.bodyField
            End Get
            Set
                Me.bodyField = Value
            End Set
        End Property
    End Class

    <System.Diagnostics.DebuggerStepThroughAttribute(),
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),
     System.ServiceModel.MessageContractAttribute(IsWrapped:=False)>
    Partial Public Class requestCourierLabelRequest1

        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="http://www.App.sk/soa/COURIERSERVICESInterface/xsd", Order:=0)>
        Public requestCourierLabelIn As requestCourierLabelIn

        Public Sub New()
            MyBase.New
        End Sub

        Public Sub New(ByVal requestCourierLabelIn As requestCourierLabelIn)
            MyBase.New
            Me.requestCourierLabelIn = requestCourierLabelIn
        End Sub
    End Class

    <System.Diagnostics.DebuggerStepThroughAttribute(),
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),
     System.ServiceModel.MessageContractAttribute(IsWrapped:=False)>
    Partial Public Class requestCourierLabelResponse1

        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="http://www.App.sk/soa/COURIERSERVICESInterface/xsd", Order:=0)>
        Public requestCourierLabelOut As requestCourierLabelOut

        Public Sub New()
            MyBase.New
        End Sub

        Public Sub New(ByVal requestCourierLabelOut As requestCourierLabelOut)
            MyBase.New
            Me.requestCourierLabelOut = requestCourierLabelOut
        End Sub
    End Class

    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>
    Public Interface CourierDeliveryManagementSoapPortTypeChannel
        Inherits ICourierDeliveryManagementSoapPortTypeService, System.ServiceModel.IClientChannel
    End Interface

    <System.Diagnostics.DebuggerStepThroughAttribute(),
 System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>
    Partial Public Class CourierDeliveryManagementSoapPortTypeClient
        Inherits System.ServiceModel.ClientBase(Of ICourierDeliveryManagementSoapPortTypeService)
        Implements ICourierDeliveryManagementSoapPortTypeService

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
        Function CourierDeliveryManagementSoapPortType_requestCourierDelivery(ByVal request As requestCourierDeliveryRequest1) As requestCourierDeliveryResponse1 Implements ICourierDeliveryManagementSoapPortTypeService.requestCourierDelivery
            Return MyBase.Channel.requestCourierDelivery(request)
        End Function

        Public Function requestCourierDelivery(ByVal requestCourierDeliveryIn As requestCourierDeliveryIn) As requestCourierDeliveryOut
            Dim inValue As requestCourierDeliveryRequest1 = New requestCourierDeliveryRequest1()
            inValue.requestCourierDeliveryIn = requestCourierDeliveryIn
            Dim retVal As requestCourierDeliveryResponse1 = CType(Me, ICourierDeliveryManagementSoapPortTypeService).requestCourierDelivery(inValue)
            Return retVal.requestCourierDeliveryOut
        End Function

        '<System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        'Function CourierDeliveryManagementSoapPortType_requestCourierDeliveryAsync(ByVal request As requestCourierDeliveryRequest1) As System.Threading.Tasks.Task(Of requestCourierDeliveryResponse1) Implements CourierDeliveryManagementSoapPortType.requestCourierDeliveryAsync
        '    Return MyBase.Channel.requestCourierDeliveryAsync(request)
        'End Function

        'Public Function requestCourierDeliveryAsync(ByVal requestCourierDeliveryIn As requestCourierDeliveryIn) As System.Threading.Tasks.Task(Of requestCourierDeliveryResponse1)
        '    Dim inValue As requestCourierDeliveryRequest1 = New requestCourierDeliveryRequest1()
        '    inValue.requestCourierDeliveryIn = requestCourierDeliveryIn
        '    Return CType(Me,CourierDeliveryManagementSoapPortType).requestCourierDeliveryAsync(inValue)
        'End Function

        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>
        Function CourierDeliveryManagementSoapPortType_deliveryDocumentsNotify(ByVal request As deliveryDocumentsNotifyRequest1) As deliveryDocumentsNotifyResponse1 Implements ICourierDeliveryManagementSoapPortTypeService.deliveryDocumentsNotify
            Return MyBase.Channel.deliveryDocumentsNotify(request)
        End Function

        Public Function deliveryDocumentsNotify(ByVal deliveryDocumentsNotifyIn As deliveryDocumentsNotifyIn) As deliveryDocumentsNotifyOut
            Dim inValue As deliveryDocumentsNotifyRequest1 = New deliveryDocumentsNotifyRequest1()
            inValue.deliveryDocumentsNotifyIn = deliveryDocumentsNotifyIn
            Dim retVal As deliveryDocumentsNotifyResponse1 = CType(Me, ICourierDeliveryManagementSoapPortTypeService).deliveryDocumentsNotify(inValue)
            Return retVal.deliveryDocumentsNotifyOut
        End Function

        '<System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        'Function CourierDeliveryManagementSoapPortType_deliveryDocumentsNotifyAsync(ByVal request As deliveryDocumentsNotifyRequest1) As System.Threading.Tasks.Task(Of deliveryDocumentsNotifyResponse1) Implements CourierDeliveryManagementSoapPortType.deliveryDocumentsNotifyAsync
        '    Return MyBase.Channel.deliveryDocumentsNotifyAsync(request)
        'End Function

        'Public Function deliveryDocumentsNotifyAsync(ByVal deliveryDocumentsNotifyIn As deliveryDocumentsNotifyIn) As System.Threading.Tasks.Task(Of deliveryDocumentsNotifyResponse1)
        '    Dim inValue As deliveryDocumentsNotifyRequest1 = New deliveryDocumentsNotifyRequest1()
        '    inValue.deliveryDocumentsNotifyIn = deliveryDocumentsNotifyIn
        '    Return CType(Me,CourierDeliveryManagementSoapPortType).deliveryDocumentsNotifyAsync(inValue)
        'End Function

        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>
        Function CourierDeliveryManagementSoapPortType_requestCourierLabel(ByVal request As requestCourierLabelRequest1) As requestCourierLabelResponse1 Implements ICourierDeliveryManagementSoapPortTypeService.requestCourierLabel
            Return MyBase.Channel.requestCourierLabel(request)
        End Function

        Public Function requestCourierLabel(ByVal requestCourierLabelIn As requestCourierLabelIn) As requestCourierLabelOut
            Dim inValue As requestCourierLabelRequest1 = New requestCourierLabelRequest1()
            inValue.requestCourierLabelIn = requestCourierLabelIn
            Dim retVal As requestCourierLabelResponse1 = CType(Me, ICourierDeliveryManagementSoapPortTypeService).requestCourierLabel(inValue)
            Return retVal.requestCourierLabelOut
        End Function

        '<System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)> _
        'Function CourierDeliveryManagementSoapPortType_requestCourierLabelAsync(ByVal request As requestCourierLabelRequest1) As System.Threading.Tasks.Task(Of requestCourierLabelResponse1) Implements CourierDeliveryManagementSoapPortType.requestCourierLabelAsync
        '    Return MyBase.Channel.requestCourierLabelAsync(request)
        'End Function

        'Public Function requestCourierLabelAsync(ByVal requestCourierLabelIn As requestCourierLabelIn) As System.Threading.Tasks.Task(Of requestCourierLabelResponse1)
        '    Dim inValue As requestCourierLabelRequest1 = New requestCourierLabelRequest1()
        '    inValue.requestCourierLabelIn = requestCourierLabelIn
        '    Return CType(Me,CourierDeliveryManagementSoapPortType).requestCourierLabelAsync(inValue)
        'End Function
    End Class
End Namespace

Namespace www.tmobile.sk.soa.COURIERSERVICESInterface.xsd

    <System.Diagnostics.DebuggerStepThroughAttribute(),
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0"),
     System.Xml.Serialization.XmlSchemaProviderAttribute("ExportSchema"),
     System.Xml.Serialization.XmlRootAttribute(IsNullable:=False)>
    Partial Public Class requestCourierDeliveryFault
        Inherits Object
        Implements System.Xml.Serialization.IXmlSerializable

        Private nodesField() As System.Xml.XmlNode

        Private Shared typeName As System.Xml.XmlQualifiedName = New System.Xml.XmlQualifiedName("requestCourierDeliveryFault", "http://www.App.sk/soa/COURIERSERVICESInterface/xsd")

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
    Partial Public Class FaultMessage
        Inherits Object
        Implements System.Xml.Serialization.IXmlSerializable

        Private nodesField() As System.Xml.XmlNode

        Private Shared typeName As System.Xml.XmlQualifiedName = New System.Xml.XmlQualifiedName("FaultMessage", "http://www.App.sk/soa/COURIERSERVICESInterface/xsd")

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
    Partial Public Class deliveryDocumentsNotifyFault
        Inherits Object
        Implements System.Xml.Serialization.IXmlSerializable

        Private nodesField() As System.Xml.XmlNode

        Private Shared typeName As System.Xml.XmlQualifiedName = New System.Xml.XmlQualifiedName("deliveryDocumentsNotifyFault", "http://www.App.sk/soa/COURIERSERVICESInterface/xsd")

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
    Partial Public Class requestCourierLabelFault
        Inherits Object
        Implements System.Xml.Serialization.IXmlSerializable

        Private nodesField() As System.Xml.XmlNode

        Private Shared typeName As System.Xml.XmlQualifiedName = New System.Xml.XmlQualifiedName("requestCourierLabelFault", "http://www.App.sk/soa/COURIERSERVICESInterface/xsd")

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
