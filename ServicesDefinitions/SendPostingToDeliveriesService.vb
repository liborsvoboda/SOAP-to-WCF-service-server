Option Strict Off
Option Explicit On

Imports System.Runtime.Serialization
Imports AppWSDL.together

<Assembly: System.Runtime.Serialization.ContractNamespaceAttribute("http://schemas.telekom.net/csdg_v01.02", ClrNamespace:="schemas.telekom.net.csdg_v01._02")>

Namespace SendPostingToDeliveries


    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),
 System.ServiceModel.ServiceContractAttribute(Name:="SendPostingToDeliveriesConsumerService", [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1")>
    Public Interface ISendPostingToDeliveries

        'CODEGEN: Probíhá generování kontraktu zprávy, protože obor názvů obálky (http://schemas.telekom.net/csdg_v01.02) zprávy sendPostingToDeliveriesResponse neodpovídá výchozí hodnotě (http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDeliveries/v1)
        <System.ServiceModel.OperationContract(Action:="sendPostingToDeliveries"),
     System.ServiceModel.FaultContractAttribute(GetType(schemas.telekom.net.csdg_v01._02.TCTechnicalFaultInfo), Action:="sendPostingToDeliveries", Name:="technicalFault", [Namespace]:="http://schemas.telekom.net/csdg_v01.02"),
     System.ServiceModel.XmlSerializerFormatAttribute()>
        Function sendPostingToDeliveries(ByVal request As sendPostingToDeliveriesRequest) As sendPostingToDeliveriesResponse

        '<System.ServiceModel.OperationContractAttribute(Action:="sendPostingToDeliveries", ReplyAction:="*")>
        'Function sendPostingToDeliveriesAsync(ByVal request As sendPostingToDeliveriesRequest) As System.Threading.Tasks.Task(Of sendPostingToDeliveriesResponse)
    End Interface

    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Diagnostics.DebuggerStepThroughAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Partial Public Class ZSCMT19C_DELVRY03

        Private iDOCField As ZSCMT19C_DELVRY03IDOC

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property IDOC() As ZSCMT19C_DELVRY03IDOC
            Get
                Return Me.iDOCField
            End Get
            Set
                Me.iDOCField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Diagnostics.DebuggerStepThroughAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Partial Public Class ZSCMT19C_DELVRY03IDOC

        Private eDI_DC40Field As ZSCMT19C_DELVRY03IDOCEDI_DC40

        Private e1EDL20Field() As ZSCMT19C_DELVRY03IDOCE1EDL20

        Private bEGINField As ZSCMT19C_DELVRY03IDOCBEGIN

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property EDI_DC40() As ZSCMT19C_DELVRY03IDOCEDI_DC40
            Get
                Return Me.eDI_DC40Field
            End Get
            Set
                Me.eDI_DC40Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("E1EDL20", Order:=1)>
        Public Property E1EDL20() As ZSCMT19C_DELVRY03IDOCE1EDL20()
            Get
                Return Me.e1EDL20Field
            End Get
            Set
                Me.e1EDL20Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property BEGIN() As ZSCMT19C_DELVRY03IDOCBEGIN
            Get
                Return Me.bEGINField
            End Get
            Set
                Me.bEGINField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Diagnostics.DebuggerStepThroughAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Partial Public Class ZSCMT19C_DELVRY03IDOCEDI_DC40

        Private tABNAMField As String

        Private mANDTField As String

        Private dOCNUMField As String

        Private dOCRELField As String

        Private sTATUSField As String

        Private dIRECTField As ZSCMT19C_DELVRY03IDOCEDI_DC40DIRECT

        Private oUTMODField As String

        Private eXPRSSField As String

        Private tESTField As String

        Private iDOCTYPField As String

        Private cIMTYPField As String

        Private mESTYPField As String

        Private mESCODField As String

        Private mESFCTField As String

        Private sTDField As String

        Private sTDVRSField As String

        Private sTDMESField As String

        Private sNDPORField As String

        Private sNDPRTField As String

        Private sNDPFCField As String

        Private sNDPRNField As String

        Private sNDSADField As String

        Private sNDLADField As String

        Private rCVPORField As String

        Private rCVPRTField As String

        Private rCVPFCField As String

        Private rCVPRNField As String

        Private rCVSADField As String

        Private rCVLADField As String

        Private cREDATField As String

        Private cRETIMField As String

        Private rEFINTField As String

        Private rEFGRPField As String

        Private rEFMESField As String

        Private aRCKEYField As String

        Private sERIALField As String

        Private sEGMENTField As ZSCMT19C_DELVRY03IDOCEDI_DC40SEGMENT

        Public Sub New()
            MyBase.New
            Me.tABNAMField = "EDI_DC40"
            Me.iDOCTYPField = "DELVRY03"
            Me.cIMTYPField = "ZSCMT19C_DELVRY03"
        End Sub

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property TABNAM() As String
            Get
                Return Me.tABNAMField
            End Get
            Set
                Me.tABNAMField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public Property MANDT() As String
            Get
                Return Me.mANDTField
            End Get
            Set
                Me.mANDTField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>
        Public Property DOCNUM() As String
            Get
                Return Me.dOCNUMField
            End Get
            Set
                Me.dOCNUMField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=3)>
        Public Property DOCREL() As String
            Get
                Return Me.dOCRELField
            End Get
            Set
                Me.dOCRELField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=4)>
        Public Property STATUS() As String
            Get
                Return Me.sTATUSField
            End Get
            Set
                Me.sTATUSField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=5)>
        Public Property DIRECT() As ZSCMT19C_DELVRY03IDOCEDI_DC40DIRECT
            Get
                Return Me.dIRECTField
            End Get
            Set
                Me.dIRECTField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=6)>
        Public Property OUTMOD() As String
            Get
                Return Me.oUTMODField
            End Get
            Set
                Me.oUTMODField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=7)>
        Public Property EXPRSS() As String
            Get
                Return Me.eXPRSSField
            End Get
            Set
                Me.eXPRSSField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=8)>
        Public Property TEST() As String
            Get
                Return Me.tESTField
            End Get
            Set
                Me.tESTField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=9)>
        Public Property IDOCTYP() As String
            Get
                Return Me.iDOCTYPField
            End Get
            Set
                Me.iDOCTYPField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=10)>
        Public Property CIMTYP() As String
            Get
                Return Me.cIMTYPField
            End Get
            Set
                Me.cIMTYPField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=11)>
        Public Property MESTYP() As String
            Get
                Return Me.mESTYPField
            End Get
            Set
                Me.mESTYPField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=12)>
        Public Property MESCOD() As String
            Get
                Return Me.mESCODField
            End Get
            Set
                Me.mESCODField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=13)>
        Public Property MESFCT() As String
            Get
                Return Me.mESFCTField
            End Get
            Set
                Me.mESFCTField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=14)>
        Public Property STD() As String
            Get
                Return Me.sTDField
            End Get
            Set
                Me.sTDField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=15)>
        Public Property STDVRS() As String
            Get
                Return Me.sTDVRSField
            End Get
            Set
                Me.sTDVRSField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=16)>
        Public Property STDMES() As String
            Get
                Return Me.sTDMESField
            End Get
            Set
                Me.sTDMESField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=17)>
        Public Property SNDPOR() As String
            Get
                Return Me.sNDPORField
            End Get
            Set
                Me.sNDPORField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=18)>
        Public Property SNDPRT() As String
            Get
                Return Me.sNDPRTField
            End Get
            Set
                Me.sNDPRTField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=19)>
        Public Property SNDPFC() As String
            Get
                Return Me.sNDPFCField
            End Get
            Set
                Me.sNDPFCField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=20)>
        Public Property SNDPRN() As String
            Get
                Return Me.sNDPRNField
            End Get
            Set
                Me.sNDPRNField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=21)>
        Public Property SNDSAD() As String
            Get
                Return Me.sNDSADField
            End Get
            Set
                Me.sNDSADField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=22)>
        Public Property SNDLAD() As String
            Get
                Return Me.sNDLADField
            End Get
            Set
                Me.sNDLADField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=23)>
        Public Property RCVPOR() As String
            Get
                Return Me.rCVPORField
            End Get
            Set
                Me.rCVPORField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=24)>
        Public Property RCVPRT() As String
            Get
                Return Me.rCVPRTField
            End Get
            Set
                Me.rCVPRTField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=25)>
        Public Property RCVPFC() As String
            Get
                Return Me.rCVPFCField
            End Get
            Set
                Me.rCVPFCField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=26)>
        Public Property RCVPRN() As String
            Get
                Return Me.rCVPRNField
            End Get
            Set
                Me.rCVPRNField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=27)>
        Public Property RCVSAD() As String
            Get
                Return Me.rCVSADField
            End Get
            Set
                Me.rCVSADField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=28)>
        Public Property RCVLAD() As String
            Get
                Return Me.rCVLADField
            End Get
            Set
                Me.rCVLADField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=29)>
        Public Property CREDAT() As String
            Get
                Return Me.cREDATField
            End Get
            Set
                Me.cREDATField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=30)>
        Public Property CRETIM() As String
            Get
                Return Me.cRETIMField
            End Get
            Set
                Me.cRETIMField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=31)>
        Public Property REFINT() As String
            Get
                Return Me.rEFINTField
            End Get
            Set
                Me.rEFINTField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=32)>
        Public Property REFGRP() As String
            Get
                Return Me.rEFGRPField
            End Get
            Set
                Me.rEFGRPField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=33)>
        Public Property REFMES() As String
            Get
                Return Me.rEFMESField
            End Get
            Set
                Me.rEFMESField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=34)>
        Public Property ARCKEY() As String
            Get
                Return Me.aRCKEYField
            End Get
            Set
                Me.aRCKEYField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=35)>
        Public Property SERIAL() As String
            Get
                Return Me.sERIALField
            End Get
            Set
                Me.sERIALField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property SEGMENT() As ZSCMT19C_DELVRY03IDOCEDI_DC40SEGMENT
            Get
                Return Me.sEGMENTField
            End Get
            Set
                Me.sEGMENTField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Public Enum ZSCMT19C_DELVRY03IDOCEDI_DC40DIRECT

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("2")>
        Item2
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Public Enum ZSCMT19C_DELVRY03IDOCEDI_DC40SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Diagnostics.DebuggerStepThroughAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Partial Public Class ZSCMT19C_DELVRY03IDOCE1EDL20

        Private vBELNField As String

        Private vSTELField As String

        Private vKORGField As String

        Private lSTELField As String

        Private vKBURField As String

        Private lGNUMField As String

        Private aBLADField As String

        Private iNCO1Field As String

        Private iNCO2Field As String

        Private rOUTEField As String

        Private vSBEDField As String

        Private bTGEWField As String

        Private nTGEWField As String

        Private gEWEIField As String

        Private vOLUMField As String

        Private vOLEHField As String

        Private aNZPKField As String

        Private bOLNRField As String

        Private tRATYField As String

        Private tRAIDField As String

        Private xABLNField As String

        Private lIFEXField As String

        Private pARIDField As String

        Private pODATField As String

        Private pOTIMField As String

        Private lOC_SEQField As String

        Private hOLDField As String

        Private mAX_ERR_TYPEField As String

        Private lE_SCENARIOField As String

        Private rECIPIENT_CREATEField As String

        Private iNCOVField As String

        Private iNCO2_LField As String

        Private iNCO3_LField As String

        Private zSCMT19C_E1EDL20Field() As ZSCMT19C_DELVRY03IDOCE1EDL20ZSCMT19C_E1EDL20

        Private e1EDL22Field As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL22

        Private e1EDL21Field As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL21

        Private e1EDL51Field() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL51

        Private e1EDD01Field As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDD01

        Private e1EDL18Field() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL18

        Private e1EDL55Field() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL55

        Private e1ADRM1Field() As ZSCMT19C_DELVRY03IDOCE1EDL20E1ADRM1

        Private e1EDT13Field() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDT13

        Private e1TXTH8Field() As ZSCMT19C_DELVRY03IDOCE1EDL20E1TXTH8

        Private e1EDDH2Field() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDDH2

        Private e1EDL33Field As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL33

        Private e1EDL28Field As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL28

        Private e1EDL47Field As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL47

        Private e1EDL24Field() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24

        Private e1EDL37Field() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL37

        Private e1EDL54Field() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL54

        Private sEGMENTField As ZSCMT19C_DELVRY03IDOCE1EDL20SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property VBELN() As String
            Get
                Return Me.vBELNField
            End Get
            Set
                Me.vBELNField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public Property VSTEL() As String
            Get
                Return Me.vSTELField
            End Get
            Set
                Me.vSTELField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>
        Public Property VKORG() As String
            Get
                Return Me.vKORGField
            End Get
            Set
                Me.vKORGField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=3)>
        Public Property LSTEL() As String
            Get
                Return Me.lSTELField
            End Get
            Set
                Me.lSTELField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=4)>
        Public Property VKBUR() As String
            Get
                Return Me.vKBURField
            End Get
            Set
                Me.vKBURField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=5)>
        Public Property LGNUM() As String
            Get
                Return Me.lGNUMField
            End Get
            Set
                Me.lGNUMField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=6)>
        Public Property ABLAD() As String
            Get
                Return Me.aBLADField
            End Get
            Set
                Me.aBLADField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=7)>
        Public Property INCO1() As String
            Get
                Return Me.iNCO1Field
            End Get
            Set
                Me.iNCO1Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=8)>
        Public Property INCO2() As String
            Get
                Return Me.iNCO2Field
            End Get
            Set
                Me.iNCO2Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=9)>
        Public Property ROUTE() As String
            Get
                Return Me.rOUTEField
            End Get
            Set
                Me.rOUTEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=10)>
        Public Property VSBED() As String
            Get
                Return Me.vSBEDField
            End Get
            Set
                Me.vSBEDField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=11)>
        Public Property BTGEW() As String
            Get
                Return Me.bTGEWField
            End Get
            Set
                Me.bTGEWField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=12)>
        Public Property NTGEW() As String
            Get
                Return Me.nTGEWField
            End Get
            Set
                Me.nTGEWField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=13)>
        Public Property GEWEI() As String
            Get
                Return Me.gEWEIField
            End Get
            Set
                Me.gEWEIField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=14)>
        Public Property VOLUM() As String
            Get
                Return Me.vOLUMField
            End Get
            Set
                Me.vOLUMField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=15)>
        Public Property VOLEH() As String
            Get
                Return Me.vOLEHField
            End Get
            Set
                Me.vOLEHField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=16)>
        Public Property ANZPK() As String
            Get
                Return Me.aNZPKField
            End Get
            Set
                Me.aNZPKField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=17)>
        Public Property BOLNR() As String
            Get
                Return Me.bOLNRField
            End Get
            Set
                Me.bOLNRField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=18)>
        Public Property TRATY() As String
            Get
                Return Me.tRATYField
            End Get
            Set
                Me.tRATYField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=19)>
        Public Property TRAID() As String
            Get
                Return Me.tRAIDField
            End Get
            Set
                Me.tRAIDField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=20)>
        Public Property XABLN() As String
            Get
                Return Me.xABLNField
            End Get
            Set
                Me.xABLNField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=21)>
        Public Property LIFEX() As String
            Get
                Return Me.lIFEXField
            End Get
            Set
                Me.lIFEXField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=22)>
        Public Property PARID() As String
            Get
                Return Me.pARIDField
            End Get
            Set
                Me.pARIDField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=23)>
        Public Property PODAT() As String
            Get
                Return Me.pODATField
            End Get
            Set
                Me.pODATField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=24)>
        Public Property POTIM() As String
            Get
                Return Me.pOTIMField
            End Get
            Set
                Me.pOTIMField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=25)>
        Public Property LOC_SEQ() As String
            Get
                Return Me.lOC_SEQField
            End Get
            Set
                Me.lOC_SEQField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=26)>
        Public Property HOLD() As String
            Get
                Return Me.hOLDField
            End Get
            Set
                Me.hOLDField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=27)>
        Public Property MAX_ERR_TYPE() As String
            Get
                Return Me.mAX_ERR_TYPEField
            End Get
            Set
                Me.mAX_ERR_TYPEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=28)>
        Public Property LE_SCENARIO() As String
            Get
                Return Me.lE_SCENARIOField
            End Get
            Set
                Me.lE_SCENARIOField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=29)>
        Public Property RECIPIENT_CREATE() As String
            Get
                Return Me.rECIPIENT_CREATEField
            End Get
            Set
                Me.rECIPIENT_CREATEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=30)>
        Public Property INCOV() As String
            Get
                Return Me.iNCOVField
            End Get
            Set
                Me.iNCOVField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=31)>
        Public Property INCO2_L() As String
            Get
                Return Me.iNCO2_LField
            End Get
            Set
                Me.iNCO2_LField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=32)>
        Public Property INCO3_L() As String
            Get
                Return Me.iNCO3_LField
            End Get
            Set
                Me.iNCO3_LField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("ZSCMT19C_E1EDL20", Order:=33)>
        Public Property ZSCMT19C_E1EDL20() As ZSCMT19C_DELVRY03IDOCE1EDL20ZSCMT19C_E1EDL20()
            Get
                Return Me.zSCMT19C_E1EDL20Field
            End Get
            Set
                Me.zSCMT19C_E1EDL20Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=34)>
        Public Property E1EDL22() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL22
            Get
                Return Me.e1EDL22Field
            End Get
            Set
                Me.e1EDL22Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=35)>
        Public Property E1EDL21() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL21
            Get
                Return Me.e1EDL21Field
            End Get
            Set
                Me.e1EDL21Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("E1EDL51", Order:=36)>
        Public Property E1EDL51() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL51()
            Get
                Return Me.e1EDL51Field
            End Get
            Set
                Me.e1EDL51Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=37)>
        Public Property E1EDD01() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDD01
            Get
                Return Me.e1EDD01Field
            End Get
            Set
                Me.e1EDD01Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("E1EDL18", Order:=38)>
        Public Property E1EDL18() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL18()
            Get
                Return Me.e1EDL18Field
            End Get
            Set
                Me.e1EDL18Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("E1EDL55", Order:=39)>
        Public Property E1EDL55() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL55()
            Get
                Return Me.e1EDL55Field
            End Get
            Set
                Me.e1EDL55Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("E1ADRM1", Order:=40)>
        Public Property E1ADRM1() As ZSCMT19C_DELVRY03IDOCE1EDL20E1ADRM1()
            Get
                Return Me.e1ADRM1Field
            End Get
            Set
                Me.e1ADRM1Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("E1EDT13", Order:=41)>
        Public Property E1EDT13() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDT13()
            Get
                Return Me.e1EDT13Field
            End Get
            Set
                Me.e1EDT13Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("E1TXTH8", Order:=42)>
        Public Property E1TXTH8() As ZSCMT19C_DELVRY03IDOCE1EDL20E1TXTH8()
            Get
                Return Me.e1TXTH8Field
            End Get
            Set
                Me.e1TXTH8Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("E1EDDH2", Order:=43)>
        Public Property E1EDDH2() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDDH2()
            Get
                Return Me.e1EDDH2Field
            End Get
            Set
                Me.e1EDDH2Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=44)>
        Public Property E1EDL33() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL33
            Get
                Return Me.e1EDL33Field
            End Get
            Set
                Me.e1EDL33Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=45)>
        Public Property E1EDL28() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL28
            Get
                Return Me.e1EDL28Field
            End Get
            Set
                Me.e1EDL28Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=46)>
        Public Property E1EDL47() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL47
            Get
                Return Me.e1EDL47Field
            End Get
            Set
                Me.e1EDL47Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("E1EDL24", Order:=47)>
        Public Property E1EDL24() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24()
            Get
                Return Me.e1EDL24Field
            End Get
            Set
                Me.e1EDL24Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("E1EDL37", Order:=48)>
        Public Property E1EDL37() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL37()
            Get
                Return Me.e1EDL37Field
            End Get
            Set
                Me.e1EDL37Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("E1EDL54", Order:=49)>
        Public Property E1EDL54() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL54()
            Get
                Return Me.e1EDL54Field
            End Get
            Set
                Me.e1EDL54Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property SEGMENT() As ZSCMT19C_DELVRY03IDOCE1EDL20SEGMENT
            Get
                Return Me.sEGMENTField
            End Get
            Set
                Me.sEGMENTField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Diagnostics.DebuggerStepThroughAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Partial Public Class ZSCMT19C_DELVRY03IDOCE1EDL20ZSCMT19C_E1EDL20

        Private qUALField As String

        Private vALUE1Field As String

        Private vALUE2Field As String

        Private vALUE3Field As String

        Private vALUE4Field As String

        Private sEGMENTField As ZSCMT19C_DELVRY03IDOCE1EDL20ZSCMT19C_E1EDL20SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property QUAL() As String
            Get
                Return Me.qUALField
            End Get
            Set
                Me.qUALField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public Property VALUE1() As String
            Get
                Return Me.vALUE1Field
            End Get
            Set
                Me.vALUE1Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>
        Public Property VALUE2() As String
            Get
                Return Me.vALUE2Field
            End Get
            Set
                Me.vALUE2Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=3)>
        Public Property VALUE3() As String
            Get
                Return Me.vALUE3Field
            End Get
            Set
                Me.vALUE3Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=4)>
        Public Property VALUE4() As String
            Get
                Return Me.vALUE4Field
            End Get
            Set
                Me.vALUE4Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property SEGMENT() As ZSCMT19C_DELVRY03IDOCE1EDL20ZSCMT19C_E1EDL20SEGMENT
            Get
                Return Me.sEGMENTField
            End Get
            Set
                Me.sEGMENTField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Public Enum ZSCMT19C_DELVRY03IDOCE1EDL20ZSCMT19C_E1EDL20SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Diagnostics.DebuggerStepThroughAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Partial Public Class ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL22

        Private vSTEL_BEZField As String

        Private vKORG_BEZField As String

        Private lSTEL_BEZField As String

        Private vKBUR_BEZField As String

        Private lGNUM_BEZField As String

        Private iNCO1_BEZField As String

        Private rOUTE_BEZField As String

        Private vSBED_BEZField As String

        Private tRATY_BEZField As String

        Private iNCOV_BEZField As String

        Private sEGMENTField As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL22SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property VSTEL_BEZ() As String
            Get
                Return Me.vSTEL_BEZField
            End Get
            Set
                Me.vSTEL_BEZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public Property VKORG_BEZ() As String
            Get
                Return Me.vKORG_BEZField
            End Get
            Set
                Me.vKORG_BEZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>
        Public Property LSTEL_BEZ() As String
            Get
                Return Me.lSTEL_BEZField
            End Get
            Set
                Me.lSTEL_BEZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=3)>
        Public Property VKBUR_BEZ() As String
            Get
                Return Me.vKBUR_BEZField
            End Get
            Set
                Me.vKBUR_BEZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=4)>
        Public Property LGNUM_BEZ() As String
            Get
                Return Me.lGNUM_BEZField
            End Get
            Set
                Me.lGNUM_BEZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=5)>
        Public Property INCO1_BEZ() As String
            Get
                Return Me.iNCO1_BEZField
            End Get
            Set
                Me.iNCO1_BEZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=6)>
        Public Property ROUTE_BEZ() As String
            Get
                Return Me.rOUTE_BEZField
            End Get
            Set
                Me.rOUTE_BEZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=7)>
        Public Property VSBED_BEZ() As String
            Get
                Return Me.vSBED_BEZField
            End Get
            Set
                Me.vSBED_BEZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=8)>
        Public Property TRATY_BEZ() As String
            Get
                Return Me.tRATY_BEZField
            End Get
            Set
                Me.tRATY_BEZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=9)>
        Public Property INCOV_BEZ() As String
            Get
                Return Me.iNCOV_BEZField
            End Get
            Set
                Me.iNCOV_BEZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property SEGMENT() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL22SEGMENT
            Get
                Return Me.sEGMENTField
            End Get
            Set
                Me.sEGMENTField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Public Enum ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL22SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Diagnostics.DebuggerStepThroughAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Partial Public Class ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL21

        Private lFARTField As String

        Private bZIRKField As String

        Private aUTLFField As String

        Private eXPKZField As String

        Private lIFSKField As String

        Private lPRIOField As String

        Private kDGRPField As String

        Private bEROTField As String

        Private tRAGRField As String

        Private tRSPGField As String

        Private aULWEField As String

        Private e1EDL23Field As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL21E1EDL23

        Private sEGMENTField As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL21SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property LFART() As String
            Get
                Return Me.lFARTField
            End Get
            Set
                Me.lFARTField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public Property BZIRK() As String
            Get
                Return Me.bZIRKField
            End Get
            Set
                Me.bZIRKField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>
        Public Property AUTLF() As String
            Get
                Return Me.aUTLFField
            End Get
            Set
                Me.aUTLFField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=3)>
        Public Property EXPKZ() As String
            Get
                Return Me.eXPKZField
            End Get
            Set
                Me.eXPKZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=4)>
        Public Property LIFSK() As String
            Get
                Return Me.lIFSKField
            End Get
            Set
                Me.lIFSKField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=5)>
        Public Property LPRIO() As String
            Get
                Return Me.lPRIOField
            End Get
            Set
                Me.lPRIOField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=6)>
        Public Property KDGRP() As String
            Get
                Return Me.kDGRPField
            End Get
            Set
                Me.kDGRPField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=7)>
        Public Property BEROT() As String
            Get
                Return Me.bEROTField
            End Get
            Set
                Me.bEROTField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=8)>
        Public Property TRAGR() As String
            Get
                Return Me.tRAGRField
            End Get
            Set
                Me.tRAGRField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=9)>
        Public Property TRSPG() As String
            Get
                Return Me.tRSPGField
            End Get
            Set
                Me.tRSPGField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=10)>
        Public Property AULWE() As String
            Get
                Return Me.aULWEField
            End Get
            Set
                Me.aULWEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=11)>
        Public Property E1EDL23() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL21E1EDL23
            Get
                Return Me.e1EDL23Field
            End Get
            Set
                Me.e1EDL23Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property SEGMENT() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL21SEGMENT
            Get
                Return Me.sEGMENTField
            End Get
            Set
                Me.sEGMENTField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Diagnostics.DebuggerStepThroughAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Partial Public Class ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL21E1EDL23

        Private lFART_BEZField As String

        Private lPRIO_BEZField As String

        Private bZIRK_BEZField As String

        Private lIFSK_BEZField As String

        Private kDGRP_BEZField As String

        Private tRAGR_BEZField As String

        Private tRSPG_BEZField As String

        Private aULWE_BEZField As String

        Private sEGMENTField As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL21E1EDL23SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property LFART_BEZ() As String
            Get
                Return Me.lFART_BEZField
            End Get
            Set
                Me.lFART_BEZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public Property LPRIO_BEZ() As String
            Get
                Return Me.lPRIO_BEZField
            End Get
            Set
                Me.lPRIO_BEZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>
        Public Property BZIRK_BEZ() As String
            Get
                Return Me.bZIRK_BEZField
            End Get
            Set
                Me.bZIRK_BEZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=3)>
        Public Property LIFSK_BEZ() As String
            Get
                Return Me.lIFSK_BEZField
            End Get
            Set
                Me.lIFSK_BEZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=4)>
        Public Property KDGRP_BEZ() As String
            Get
                Return Me.kDGRP_BEZField
            End Get
            Set
                Me.kDGRP_BEZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=5)>
        Public Property TRAGR_BEZ() As String
            Get
                Return Me.tRAGR_BEZField
            End Get
            Set
                Me.tRAGR_BEZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=6)>
        Public Property TRSPG_BEZ() As String
            Get
                Return Me.tRSPG_BEZField
            End Get
            Set
                Me.tRSPG_BEZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=7)>
        Public Property AULWE_BEZ() As String
            Get
                Return Me.aULWE_BEZField
            End Get
            Set
                Me.aULWE_BEZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property SEGMENT() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL21E1EDL23SEGMENT
            Get
                Return Me.sEGMENTField
            End Get
            Set
                Me.sEGMENTField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Public Enum ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL21E1EDL23SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Public Enum ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL21SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Diagnostics.DebuggerStepThroughAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Partial Public Class ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL51

        Private qUALFField As String

        Private pRODNField As String

        Private sEGMENTField As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL51SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property QUALF() As String
            Get
                Return Me.qUALFField
            End Get
            Set
                Me.qUALFField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public Property PRODN() As String
            Get
                Return Me.pRODNField
            End Get
            Set
                Me.pRODNField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property SEGMENT() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL51SEGMENT
            Get
                Return Me.sEGMENTField
            End Get
            Set
                Me.sEGMENTField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Public Enum ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL51SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Diagnostics.DebuggerStepThroughAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Partial Public Class ZSCMT19C_DELVRY03IDOCE1EDL20E1EDD01

        Private nCDGField As String

        Private iNR1Field As String

        Private aCTVTY_TOTAL_A2Field As String

        Private eXPL_NET_SUMField As String

        Private eXPL_NET_SUM_UField As String

        Private sEGMENTField As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDD01SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property NCDG() As String
            Get
                Return Me.nCDGField
            End Get
            Set
                Me.nCDGField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public Property INR1() As String
            Get
                Return Me.iNR1Field
            End Get
            Set
                Me.iNR1Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>
        Public Property ACTVTY_TOTAL_A2() As String
            Get
                Return Me.aCTVTY_TOTAL_A2Field
            End Get
            Set
                Me.aCTVTY_TOTAL_A2Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=3)>
        Public Property EXPL_NET_SUM() As String
            Get
                Return Me.eXPL_NET_SUMField
            End Get
            Set
                Me.eXPL_NET_SUMField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=4)>
        Public Property EXPL_NET_SUM_U() As String
            Get
                Return Me.eXPL_NET_SUM_UField
            End Get
            Set
                Me.eXPL_NET_SUM_UField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property SEGMENT() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDD01SEGMENT
            Get
                Return Me.sEGMENTField
            End Get
            Set
                Me.sEGMENTField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Public Enum ZSCMT19C_DELVRY03IDOCE1EDL20E1EDD01SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Diagnostics.DebuggerStepThroughAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Partial Public Class ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL18

        Private qUALFField As String

        Private pARAMField As String

        Private sEGMENTField As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL18SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property QUALF() As String
            Get
                Return Me.qUALFField
            End Get
            Set
                Me.qUALFField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public Property PARAM() As String
            Get
                Return Me.pARAMField
            End Get
            Set
                Me.pARAMField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property SEGMENT() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL18SEGMENT
            Get
                Return Me.sEGMENTField
            End Get
            Set
                Me.sEGMENTField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Public Enum ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL18SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Diagnostics.DebuggerStepThroughAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Partial Public Class ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL55

        Private qUALFField As String

        Private rEFNRField As String

        Private sEGMENTField As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL55SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property QUALF() As String
            Get
                Return Me.qUALFField
            End Get
            Set
                Me.qUALFField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public Property REFNR() As String
            Get
                Return Me.rEFNRField
            End Get
            Set
                Me.rEFNRField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property SEGMENT() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL55SEGMENT
            Get
                Return Me.sEGMENTField
            End Get
            Set
                Me.sEGMENTField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Public Enum ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL55SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Diagnostics.DebuggerStepThroughAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Partial Public Class ZSCMT19C_DELVRY03IDOCE1EDL20E1ADRM1

        Private pARTNER_QField As String

        Private aDDRESS_TField As String

        Private pARTNER_IDField As String

        Private jURISDICField As String

        Private lANGUAGEField As String

        Private fORMOFADDRField As String

        Private nAME1Field As String

        Private nAME2Field As String

        Private nAME3Field As String

        Private nAME4Field As String

        Private nAME_TEXTField As String

        Private nAME_COField As String

        Private lOCATIONField As String

        Private bUILDINGField As String

        Private fLOORField As String

        Private rOOMField As String

        Private sTREET1Field As String

        Private sTREET2Field As String

        Private sTREET3Field As String

        Private hOUSE_SUPLField As String

        Private hOUSE_RANGField As String

        Private pOSTL_COD1Field As String

        Private pOSTL_COD3Field As String

        Private pOSTL_AREAField As String

        Private cITY1Field As String

        Private cITY2Field As String

        Private pOSTL_PBOXField As String

        Private pOSTL_COD2Field As String

        Private pOSTL_CITYField As String

        Private tELEPHONE1Field As String

        Private tELEPHONE2Field As String

        Private tELEFAXField As String

        Private tELEXField As String

        Private e_MAILField As String

        Private cOUNTRY1Field As String

        Private cOUNTRY2Field As String

        Private rEGIONField As String

        Private cOUNTY_CODField As String

        Private cOUNTY_TXTField As String

        Private tZCODEField As String

        Private tZDESCField As String

        Private e1ADRE1Field() As ZSCMT19C_DELVRY03IDOCE1EDL20E1ADRM1E1ADRE1

        Private sEGMENTField As ZSCMT19C_DELVRY03IDOCE1EDL20E1ADRM1SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property PARTNER_Q() As String
            Get
                Return Me.pARTNER_QField
            End Get
            Set
                Me.pARTNER_QField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public Property ADDRESS_T() As String
            Get
                Return Me.aDDRESS_TField
            End Get
            Set
                Me.aDDRESS_TField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>
        Public Property PARTNER_ID() As String
            Get
                Return Me.pARTNER_IDField
            End Get
            Set
                Me.pARTNER_IDField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=3)>
        Public Property JURISDIC() As String
            Get
                Return Me.jURISDICField
            End Get
            Set
                Me.jURISDICField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=4)>
        Public Property LANGUAGE() As String
            Get
                Return Me.lANGUAGEField
            End Get
            Set
                Me.lANGUAGEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=5)>
        Public Property FORMOFADDR() As String
            Get
                Return Me.fORMOFADDRField
            End Get
            Set
                Me.fORMOFADDRField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=6)>
        Public Property NAME1() As String
            Get
                Return Me.nAME1Field
            End Get
            Set
                Me.nAME1Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=7)>
        Public Property NAME2() As String
            Get
                Return Me.nAME2Field
            End Get
            Set
                Me.nAME2Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=8)>
        Public Property NAME3() As String
            Get
                Return Me.nAME3Field
            End Get
            Set
                Me.nAME3Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=9)>
        Public Property NAME4() As String
            Get
                Return Me.nAME4Field
            End Get
            Set
                Me.nAME4Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=10)>
        Public Property NAME_TEXT() As String
            Get
                Return Me.nAME_TEXTField
            End Get
            Set
                Me.nAME_TEXTField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=11)>
        Public Property NAME_CO() As String
            Get
                Return Me.nAME_COField
            End Get
            Set
                Me.nAME_COField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=12)>
        Public Property LOCATION() As String
            Get
                Return Me.lOCATIONField
            End Get
            Set
                Me.lOCATIONField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=13)>
        Public Property BUILDING() As String
            Get
                Return Me.bUILDINGField
            End Get
            Set
                Me.bUILDINGField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=14)>
        Public Property FLOOR() As String
            Get
                Return Me.fLOORField
            End Get
            Set
                Me.fLOORField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=15)>
        Public Property ROOM() As String
            Get
                Return Me.rOOMField
            End Get
            Set
                Me.rOOMField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=16)>
        Public Property STREET1() As String
            Get
                Return Me.sTREET1Field
            End Get
            Set
                Me.sTREET1Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=17)>
        Public Property STREET2() As String
            Get
                Return Me.sTREET2Field
            End Get
            Set
                Me.sTREET2Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=18)>
        Public Property STREET3() As String
            Get
                Return Me.sTREET3Field
            End Get
            Set
                Me.sTREET3Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=19)>
        Public Property HOUSE_SUPL() As String
            Get
                Return Me.hOUSE_SUPLField
            End Get
            Set
                Me.hOUSE_SUPLField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=20)>
        Public Property HOUSE_RANG() As String
            Get
                Return Me.hOUSE_RANGField
            End Get
            Set
                Me.hOUSE_RANGField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=21)>
        Public Property POSTL_COD1() As String
            Get
                Return Me.pOSTL_COD1Field
            End Get
            Set
                Me.pOSTL_COD1Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=22)>
        Public Property POSTL_COD3() As String
            Get
                Return Me.pOSTL_COD3Field
            End Get
            Set
                Me.pOSTL_COD3Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=23)>
        Public Property POSTL_AREA() As String
            Get
                Return Me.pOSTL_AREAField
            End Get
            Set
                Me.pOSTL_AREAField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=24)>
        Public Property CITY1() As String
            Get
                Return Me.cITY1Field
            End Get
            Set
                Me.cITY1Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=25)>
        Public Property CITY2() As String
            Get
                Return Me.cITY2Field
            End Get
            Set
                Me.cITY2Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=26)>
        Public Property POSTL_PBOX() As String
            Get
                Return Me.pOSTL_PBOXField
            End Get
            Set
                Me.pOSTL_PBOXField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=27)>
        Public Property POSTL_COD2() As String
            Get
                Return Me.pOSTL_COD2Field
            End Get
            Set
                Me.pOSTL_COD2Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=28)>
        Public Property POSTL_CITY() As String
            Get
                Return Me.pOSTL_CITYField
            End Get
            Set
                Me.pOSTL_CITYField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=29)>
        Public Property TELEPHONE1() As String
            Get
                Return Me.tELEPHONE1Field
            End Get
            Set
                Me.tELEPHONE1Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=30)>
        Public Property TELEPHONE2() As String
            Get
                Return Me.tELEPHONE2Field
            End Get
            Set
                Me.tELEPHONE2Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=31)>
        Public Property TELEFAX() As String
            Get
                Return Me.tELEFAXField
            End Get
            Set
                Me.tELEFAXField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=32)>
        Public Property TELEX() As String
            Get
                Return Me.tELEXField
            End Get
            Set
                Me.tELEXField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=33)>
        Public Property E_MAIL() As String
            Get
                Return Me.e_MAILField
            End Get
            Set
                Me.e_MAILField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=34)>
        Public Property COUNTRY1() As String
            Get
                Return Me.cOUNTRY1Field
            End Get
            Set
                Me.cOUNTRY1Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=35)>
        Public Property COUNTRY2() As String
            Get
                Return Me.cOUNTRY2Field
            End Get
            Set
                Me.cOUNTRY2Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=36)>
        Public Property REGION() As String
            Get
                Return Me.rEGIONField
            End Get
            Set
                Me.rEGIONField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=37)>
        Public Property COUNTY_COD() As String
            Get
                Return Me.cOUNTY_CODField
            End Get
            Set
                Me.cOUNTY_CODField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=38)>
        Public Property COUNTY_TXT() As String
            Get
                Return Me.cOUNTY_TXTField
            End Get
            Set
                Me.cOUNTY_TXTField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=39)>
        Public Property TZCODE() As String
            Get
                Return Me.tZCODEField
            End Get
            Set
                Me.tZCODEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=40)>
        Public Property TZDESC() As String
            Get
                Return Me.tZDESCField
            End Get
            Set
                Me.tZDESCField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("E1ADRE1", Order:=41)>
        Public Property E1ADRE1() As ZSCMT19C_DELVRY03IDOCE1EDL20E1ADRM1E1ADRE1()
            Get
                Return Me.e1ADRE1Field
            End Get
            Set
                Me.e1ADRE1Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property SEGMENT() As ZSCMT19C_DELVRY03IDOCE1EDL20E1ADRM1SEGMENT
            Get
                Return Me.sEGMENTField
            End Get
            Set
                Me.sEGMENTField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Diagnostics.DebuggerStepThroughAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Partial Public Class ZSCMT19C_DELVRY03IDOCE1EDL20E1ADRM1E1ADRE1

        Private eXTEND_QField As String

        Private eXTEND_DField As String

        Private sEGMENTField As ZSCMT19C_DELVRY03IDOCE1EDL20E1ADRM1E1ADRE1SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property EXTEND_Q() As String
            Get
                Return Me.eXTEND_QField
            End Get
            Set
                Me.eXTEND_QField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public Property EXTEND_D() As String
            Get
                Return Me.eXTEND_DField
            End Get
            Set
                Me.eXTEND_DField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property SEGMENT() As ZSCMT19C_DELVRY03IDOCE1EDL20E1ADRM1E1ADRE1SEGMENT
            Get
                Return Me.sEGMENTField
            End Get
            Set
                Me.sEGMENTField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Public Enum ZSCMT19C_DELVRY03IDOCE1EDL20E1ADRM1E1ADRE1SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Public Enum ZSCMT19C_DELVRY03IDOCE1EDL20E1ADRM1SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Diagnostics.DebuggerStepThroughAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Partial Public Class ZSCMT19C_DELVRY03IDOCE1EDL20E1EDT13

        Private qUALFField As String

        Private vSTZWField As String

        Private vSTZW_BEZField As String

        Private nTANFField As String

        Private nTANZField As String

        Private nTENDField As String

        Private nTENZField As String

        Private tZONE_BEGField As String

        Private iSDDField As String

        Private iSDZField As String

        Private iEDDField As String

        Private iEDZField As String

        Private tZONE_ENDField As String

        Private vORNRField As String

        Private vSTGAField As String

        Private vSTGA_BEZField As String

        Private eVENTField As String

        Private eVENT_ALIField As String

        Private e1EDL40Field As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDT13E1EDL40

        Private e1TXTH0Field() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDT13E1TXTH0

        Private sEGMENTField As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDT13SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property QUALF() As String
            Get
                Return Me.qUALFField
            End Get
            Set
                Me.qUALFField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public Property VSTZW() As String
            Get
                Return Me.vSTZWField
            End Get
            Set
                Me.vSTZWField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>
        Public Property VSTZW_BEZ() As String
            Get
                Return Me.vSTZW_BEZField
            End Get
            Set
                Me.vSTZW_BEZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=3)>
        Public Property NTANF() As String
            Get
                Return Me.nTANFField
            End Get
            Set
                Me.nTANFField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=4)>
        Public Property NTANZ() As String
            Get
                Return Me.nTANZField
            End Get
            Set
                Me.nTANZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=5)>
        Public Property NTEND() As String
            Get
                Return Me.nTENDField
            End Get
            Set
                Me.nTENDField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=6)>
        Public Property NTENZ() As String
            Get
                Return Me.nTENZField
            End Get
            Set
                Me.nTENZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=7)>
        Public Property TZONE_BEG() As String
            Get
                Return Me.tZONE_BEGField
            End Get
            Set
                Me.tZONE_BEGField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=8)>
        Public Property ISDD() As String
            Get
                Return Me.iSDDField
            End Get
            Set
                Me.iSDDField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=9)>
        Public Property ISDZ() As String
            Get
                Return Me.iSDZField
            End Get
            Set
                Me.iSDZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=10)>
        Public Property IEDD() As String
            Get
                Return Me.iEDDField
            End Get
            Set
                Me.iEDDField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=11)>
        Public Property IEDZ() As String
            Get
                Return Me.iEDZField
            End Get
            Set
                Me.iEDZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=12)>
        Public Property TZONE_END() As String
            Get
                Return Me.tZONE_ENDField
            End Get
            Set
                Me.tZONE_ENDField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=13)>
        Public Property VORNR() As String
            Get
                Return Me.vORNRField
            End Get
            Set
                Me.vORNRField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=14)>
        Public Property VSTGA() As String
            Get
                Return Me.vSTGAField
            End Get
            Set
                Me.vSTGAField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=15)>
        Public Property VSTGA_BEZ() As String
            Get
                Return Me.vSTGA_BEZField
            End Get
            Set
                Me.vSTGA_BEZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=16)>
        Public Property [EVENT]() As String
            Get
                Return Me.eVENTField
            End Get
            Set
                Me.eVENTField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=17)>
        Public Property EVENT_ALI() As String
            Get
                Return Me.eVENT_ALIField
            End Get
            Set
                Me.eVENT_ALIField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=18)>
        Public Property E1EDL40() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDT13E1EDL40
            Get
                Return Me.e1EDL40Field
            End Get
            Set
                Me.e1EDL40Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("E1TXTH0", Order:=19)>
        Public Property E1TXTH0() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDT13E1TXTH0()
            Get
                Return Me.e1TXTH0Field
            End Get
            Set
                Me.e1TXTH0Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property SEGMENT() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDT13SEGMENT
            Get
                Return Me.sEGMENTField
            End Get
            Set
                Me.sEGMENTField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Diagnostics.DebuggerStepThroughAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Partial Public Class ZSCMT19C_DELVRY03IDOCE1EDL20E1EDT13E1EDL40

        Private kNOTEField As String

        Private kNOTE_BEZField As String

        Private e1ADRM2Field As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDT13E1EDL40E1ADRM2

        Private sEGMENTField As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDT13E1EDL40SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property KNOTE() As String
            Get
                Return Me.kNOTEField
            End Get
            Set
                Me.kNOTEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public Property KNOTE_BEZ() As String
            Get
                Return Me.kNOTE_BEZField
            End Get
            Set
                Me.kNOTE_BEZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>
        Public Property E1ADRM2() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDT13E1EDL40E1ADRM2
            Get
                Return Me.e1ADRM2Field
            End Get
            Set
                Me.e1ADRM2Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property SEGMENT() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDT13E1EDL40SEGMENT
            Get
                Return Me.sEGMENTField
            End Get
            Set
                Me.sEGMENTField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Diagnostics.DebuggerStepThroughAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Partial Public Class ZSCMT19C_DELVRY03IDOCE1EDL20E1EDT13E1EDL40E1ADRM2

        Private pARTNER_QField As String

        Private aDDRESS_TField As String

        Private pARTNER_IDField As String

        Private jURISDICField As String

        Private lANGUAGEField As String

        Private fORMOFADDRField As String

        Private nAME1Field As String

        Private nAME2Field As String

        Private nAME3Field As String

        Private nAME4Field As String

        Private nAME_TEXTField As String

        Private nAME_COField As String

        Private lOCATIONField As String

        Private bUILDINGField As String

        Private fLOORField As String

        Private rOOMField As String

        Private sTREET1Field As String

        Private sTREET2Field As String

        Private sTREET3Field As String

        Private hOUSE_SUPLField As String

        Private hOUSE_RANGField As String

        Private pOSTL_COD1Field As String

        Private pOSTL_COD3Field As String

        Private pOSTL_AREAField As String

        Private cITY1Field As String

        Private cITY2Field As String

        Private pOSTL_PBOXField As String

        Private pOSTL_COD2Field As String

        Private pOSTL_CITYField As String

        Private tELEPHONE1Field As String

        Private tELEPHONE2Field As String

        Private tELFAXField As String

        Private tELEXField As String

        Private e_MAILField As String

        Private cOUNTRY1Field As String

        Private cOUNTRY2Field As String

        Private rEGIONField As String

        Private cOUNTY_CODField As String

        Private cOUNTY_TXTField As String

        Private tZCODEField As String

        Private tZDESCField As String

        Private sEGMENTField As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDT13E1EDL40E1ADRM2SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property PARTNER_Q() As String
            Get
                Return Me.pARTNER_QField
            End Get
            Set
                Me.pARTNER_QField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public Property ADDRESS_T() As String
            Get
                Return Me.aDDRESS_TField
            End Get
            Set
                Me.aDDRESS_TField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>
        Public Property PARTNER_ID() As String
            Get
                Return Me.pARTNER_IDField
            End Get
            Set
                Me.pARTNER_IDField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=3)>
        Public Property JURISDIC() As String
            Get
                Return Me.jURISDICField
            End Get
            Set
                Me.jURISDICField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=4)>
        Public Property LANGUAGE() As String
            Get
                Return Me.lANGUAGEField
            End Get
            Set
                Me.lANGUAGEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=5)>
        Public Property FORMOFADDR() As String
            Get
                Return Me.fORMOFADDRField
            End Get
            Set
                Me.fORMOFADDRField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=6)>
        Public Property NAME1() As String
            Get
                Return Me.nAME1Field
            End Get
            Set
                Me.nAME1Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=7)>
        Public Property NAME2() As String
            Get
                Return Me.nAME2Field
            End Get
            Set
                Me.nAME2Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=8)>
        Public Property NAME3() As String
            Get
                Return Me.nAME3Field
            End Get
            Set
                Me.nAME3Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=9)>
        Public Property NAME4() As String
            Get
                Return Me.nAME4Field
            End Get
            Set
                Me.nAME4Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=10)>
        Public Property NAME_TEXT() As String
            Get
                Return Me.nAME_TEXTField
            End Get
            Set
                Me.nAME_TEXTField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=11)>
        Public Property NAME_CO() As String
            Get
                Return Me.nAME_COField
            End Get
            Set
                Me.nAME_COField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=12)>
        Public Property LOCATION() As String
            Get
                Return Me.lOCATIONField
            End Get
            Set
                Me.lOCATIONField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=13)>
        Public Property BUILDING() As String
            Get
                Return Me.bUILDINGField
            End Get
            Set
                Me.bUILDINGField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=14)>
        Public Property FLOOR() As String
            Get
                Return Me.fLOORField
            End Get
            Set
                Me.fLOORField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=15)>
        Public Property ROOM() As String
            Get
                Return Me.rOOMField
            End Get
            Set
                Me.rOOMField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=16)>
        Public Property STREET1() As String
            Get
                Return Me.sTREET1Field
            End Get
            Set
                Me.sTREET1Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=17)>
        Public Property STREET2() As String
            Get
                Return Me.sTREET2Field
            End Get
            Set
                Me.sTREET2Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=18)>
        Public Property STREET3() As String
            Get
                Return Me.sTREET3Field
            End Get
            Set
                Me.sTREET3Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=19)>
        Public Property HOUSE_SUPL() As String
            Get
                Return Me.hOUSE_SUPLField
            End Get
            Set
                Me.hOUSE_SUPLField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=20)>
        Public Property HOUSE_RANG() As String
            Get
                Return Me.hOUSE_RANGField
            End Get
            Set
                Me.hOUSE_RANGField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=21)>
        Public Property POSTL_COD1() As String
            Get
                Return Me.pOSTL_COD1Field
            End Get
            Set
                Me.pOSTL_COD1Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=22)>
        Public Property POSTL_COD3() As String
            Get
                Return Me.pOSTL_COD3Field
            End Get
            Set
                Me.pOSTL_COD3Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=23)>
        Public Property POSTL_AREA() As String
            Get
                Return Me.pOSTL_AREAField
            End Get
            Set
                Me.pOSTL_AREAField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=24)>
        Public Property CITY1() As String
            Get
                Return Me.cITY1Field
            End Get
            Set
                Me.cITY1Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=25)>
        Public Property CITY2() As String
            Get
                Return Me.cITY2Field
            End Get
            Set
                Me.cITY2Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=26)>
        Public Property POSTL_PBOX() As String
            Get
                Return Me.pOSTL_PBOXField
            End Get
            Set
                Me.pOSTL_PBOXField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=27)>
        Public Property POSTL_COD2() As String
            Get
                Return Me.pOSTL_COD2Field
            End Get
            Set
                Me.pOSTL_COD2Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=28)>
        Public Property POSTL_CITY() As String
            Get
                Return Me.pOSTL_CITYField
            End Get
            Set
                Me.pOSTL_CITYField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=29)>
        Public Property TELEPHONE1() As String
            Get
                Return Me.tELEPHONE1Field
            End Get
            Set
                Me.tELEPHONE1Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=30)>
        Public Property TELEPHONE2() As String
            Get
                Return Me.tELEPHONE2Field
            End Get
            Set
                Me.tELEPHONE2Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=31)>
        Public Property TELFAX() As String
            Get
                Return Me.tELFAXField
            End Get
            Set
                Me.tELFAXField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=32)>
        Public Property TELEX() As String
            Get
                Return Me.tELEXField
            End Get
            Set
                Me.tELEXField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=33)>
        Public Property E_MAIL() As String
            Get
                Return Me.e_MAILField
            End Get
            Set
                Me.e_MAILField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=34)>
        Public Property COUNTRY1() As String
            Get
                Return Me.cOUNTRY1Field
            End Get
            Set
                Me.cOUNTRY1Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=35)>
        Public Property COUNTRY2() As String
            Get
                Return Me.cOUNTRY2Field
            End Get
            Set
                Me.cOUNTRY2Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=36)>
        Public Property REGION() As String
            Get
                Return Me.rEGIONField
            End Get
            Set
                Me.rEGIONField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=37)>
        Public Property COUNTY_COD() As String
            Get
                Return Me.cOUNTY_CODField
            End Get
            Set
                Me.cOUNTY_CODField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=38)>
        Public Property COUNTY_TXT() As String
            Get
                Return Me.cOUNTY_TXTField
            End Get
            Set
                Me.cOUNTY_TXTField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=39)>
        Public Property TZCODE() As String
            Get
                Return Me.tZCODEField
            End Get
            Set
                Me.tZCODEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=40)>
        Public Property TZDESC() As String
            Get
                Return Me.tZDESCField
            End Get
            Set
                Me.tZDESCField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property SEGMENT() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDT13E1EDL40E1ADRM2SEGMENT
            Get
                Return Me.sEGMENTField
            End Get
            Set
                Me.sEGMENTField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Public Enum ZSCMT19C_DELVRY03IDOCE1EDL20E1EDT13E1EDL40E1ADRM2SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Public Enum ZSCMT19C_DELVRY03IDOCE1EDL20E1EDT13E1EDL40SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Diagnostics.DebuggerStepThroughAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Partial Public Class ZSCMT19C_DELVRY03IDOCE1EDL20E1EDT13E1TXTH0

        Private fUNCTIONField As String

        Private tDOBJECTField As String

        Private tDOBNAMEField As String

        Private tDIDField As String

        Private tDSPRASField As String

        Private tDTEXTTYPEField As String

        Private lANGUA_ISOField As String

        Private e1TXTP0Field() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDT13E1TXTH0E1TXTP0

        Private sEGMENTField As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDT13E1TXTH0SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property [FUNCTION]() As String
            Get
                Return Me.fUNCTIONField
            End Get
            Set
                Me.fUNCTIONField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public Property TDOBJECT() As String
            Get
                Return Me.tDOBJECTField
            End Get
            Set
                Me.tDOBJECTField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>
        Public Property TDOBNAME() As String
            Get
                Return Me.tDOBNAMEField
            End Get
            Set
                Me.tDOBNAMEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=3)>
        Public Property TDID() As String
            Get
                Return Me.tDIDField
            End Get
            Set
                Me.tDIDField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=4)>
        Public Property TDSPRAS() As String
            Get
                Return Me.tDSPRASField
            End Get
            Set
                Me.tDSPRASField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=5)>
        Public Property TDTEXTTYPE() As String
            Get
                Return Me.tDTEXTTYPEField
            End Get
            Set
                Me.tDTEXTTYPEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=6)>
        Public Property LANGUA_ISO() As String
            Get
                Return Me.lANGUA_ISOField
            End Get
            Set
                Me.lANGUA_ISOField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("E1TXTP0", Order:=7)>
        Public Property E1TXTP0() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDT13E1TXTH0E1TXTP0()
            Get
                Return Me.e1TXTP0Field
            End Get
            Set
                Me.e1TXTP0Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property SEGMENT() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDT13E1TXTH0SEGMENT
            Get
                Return Me.sEGMENTField
            End Get
            Set
                Me.sEGMENTField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Diagnostics.DebuggerStepThroughAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Partial Public Class ZSCMT19C_DELVRY03IDOCE1EDL20E1EDT13E1TXTH0E1TXTP0

        Private tDFORMATField As String

        Private tDLINEField As String

        Private sEGMENTField As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDT13E1TXTH0E1TXTP0SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property TDFORMAT() As String
            Get
                Return Me.tDFORMATField
            End Get
            Set
                Me.tDFORMATField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public Property TDLINE() As String
            Get
                Return Me.tDLINEField
            End Get
            Set
                Me.tDLINEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property SEGMENT() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDT13E1TXTH0E1TXTP0SEGMENT
            Get
                Return Me.sEGMENTField
            End Get
            Set
                Me.sEGMENTField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Public Enum ZSCMT19C_DELVRY03IDOCE1EDL20E1EDT13E1TXTH0E1TXTP0SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Public Enum ZSCMT19C_DELVRY03IDOCE1EDL20E1EDT13E1TXTH0SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Public Enum ZSCMT19C_DELVRY03IDOCE1EDL20E1EDT13SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Diagnostics.DebuggerStepThroughAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Partial Public Class ZSCMT19C_DELVRY03IDOCE1EDL20E1TXTH8

        Private fUNCTIONField As String

        Private tDOBJECTField As String

        Private tDOBNAMEField As String

        Private tDIDField As String

        Private tDSPRASField As String

        Private tDTEXTTYPEField As String

        Private lANGUA_ISOField As String

        Private e1TXTP8Field() As ZSCMT19C_DELVRY03IDOCE1EDL20E1TXTH8E1TXTP8

        Private sEGMENTField As ZSCMT19C_DELVRY03IDOCE1EDL20E1TXTH8SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property [FUNCTION]() As String
            Get
                Return Me.fUNCTIONField
            End Get
            Set
                Me.fUNCTIONField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public Property TDOBJECT() As String
            Get
                Return Me.tDOBJECTField
            End Get
            Set
                Me.tDOBJECTField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>
        Public Property TDOBNAME() As String
            Get
                Return Me.tDOBNAMEField
            End Get
            Set
                Me.tDOBNAMEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=3)>
        Public Property TDID() As String
            Get
                Return Me.tDIDField
            End Get
            Set
                Me.tDIDField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=4)>
        Public Property TDSPRAS() As String
            Get
                Return Me.tDSPRASField
            End Get
            Set
                Me.tDSPRASField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=5)>
        Public Property TDTEXTTYPE() As String
            Get
                Return Me.tDTEXTTYPEField
            End Get
            Set
                Me.tDTEXTTYPEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=6)>
        Public Property LANGUA_ISO() As String
            Get
                Return Me.lANGUA_ISOField
            End Get
            Set
                Me.lANGUA_ISOField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("E1TXTP8", Order:=7)>
        Public Property E1TXTP8() As ZSCMT19C_DELVRY03IDOCE1EDL20E1TXTH8E1TXTP8()
            Get
                Return Me.e1TXTP8Field
            End Get
            Set
                Me.e1TXTP8Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property SEGMENT() As ZSCMT19C_DELVRY03IDOCE1EDL20E1TXTH8SEGMENT
            Get
                Return Me.sEGMENTField
            End Get
            Set
                Me.sEGMENTField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Diagnostics.DebuggerStepThroughAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Partial Public Class ZSCMT19C_DELVRY03IDOCE1EDL20E1TXTH8E1TXTP8

        Private tDFORMATField As String

        Private tDLINEField As String

        Private sEGMENTField As ZSCMT19C_DELVRY03IDOCE1EDL20E1TXTH8E1TXTP8SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property TDFORMAT() As String
            Get
                Return Me.tDFORMATField
            End Get
            Set
                Me.tDFORMATField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public Property TDLINE() As String
            Get
                Return Me.tDLINEField
            End Get
            Set
                Me.tDLINEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property SEGMENT() As ZSCMT19C_DELVRY03IDOCE1EDL20E1TXTH8E1TXTP8SEGMENT
            Get
                Return Me.sEGMENTField
            End Get
            Set
                Me.sEGMENTField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Public Enum ZSCMT19C_DELVRY03IDOCE1EDL20E1TXTH8E1TXTP8SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Public Enum ZSCMT19C_DELVRY03IDOCE1EDL20E1TXTH8SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Diagnostics.DebuggerStepThroughAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Partial Public Class ZSCMT19C_DELVRY03IDOCE1EDL20E1EDDH2

        Private fUNCTIONField As String

        Private tDOBJECTField As String

        Private tDOBNAMEField As String

        Private tDIDField As String

        Private tDTEXTTYPEField As String

        Private lANGUA_ISOField As String

        Private pHRSELField As String

        Private iDENTIFIERField As String

        Private lANGUA_PHRField As String

        Private e1EDDP2Field() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDDH2E1EDDP2

        Private sEGMENTField As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDDH2SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property [FUNCTION]() As String
            Get
                Return Me.fUNCTIONField
            End Get
            Set
                Me.fUNCTIONField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public Property TDOBJECT() As String
            Get
                Return Me.tDOBJECTField
            End Get
            Set
                Me.tDOBJECTField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>
        Public Property TDOBNAME() As String
            Get
                Return Me.tDOBNAMEField
            End Get
            Set
                Me.tDOBNAMEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=3)>
        Public Property TDID() As String
            Get
                Return Me.tDIDField
            End Get
            Set
                Me.tDIDField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=4)>
        Public Property TDTEXTTYPE() As String
            Get
                Return Me.tDTEXTTYPEField
            End Get
            Set
                Me.tDTEXTTYPEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=5)>
        Public Property LANGUA_ISO() As String
            Get
                Return Me.lANGUA_ISOField
            End Get
            Set
                Me.lANGUA_ISOField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=6)>
        Public Property PHRSEL() As String
            Get
                Return Me.pHRSELField
            End Get
            Set
                Me.pHRSELField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=7)>
        Public Property IDENTIFIER() As String
            Get
                Return Me.iDENTIFIERField
            End Get
            Set
                Me.iDENTIFIERField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=8)>
        Public Property LANGUA_PHR() As String
            Get
                Return Me.lANGUA_PHRField
            End Get
            Set
                Me.lANGUA_PHRField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("E1EDDP2", Order:=9)>
        Public Property E1EDDP2() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDDH2E1EDDP2()
            Get
                Return Me.e1EDDP2Field
            End Get
            Set
                Me.e1EDDP2Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property SEGMENT() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDDH2SEGMENT
            Get
                Return Me.sEGMENTField
            End Get
            Set
                Me.sEGMENTField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Diagnostics.DebuggerStepThroughAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Partial Public Class ZSCMT19C_DELVRY03IDOCE1EDL20E1EDDH2E1EDDP2

        Private tDFORMATField As String

        Private tDLINEField As String

        Private sEGMENTField As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDDH2E1EDDP2SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property TDFORMAT() As String
            Get
                Return Me.tDFORMATField
            End Get
            Set
                Me.tDFORMATField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public Property TDLINE() As String
            Get
                Return Me.tDLINEField
            End Get
            Set
                Me.tDLINEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property SEGMENT() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDDH2E1EDDP2SEGMENT
            Get
                Return Me.sEGMENTField
            End Get
            Set
                Me.sEGMENTField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Public Enum ZSCMT19C_DELVRY03IDOCE1EDL20E1EDDH2E1EDDP2SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Public Enum ZSCMT19C_DELVRY03IDOCE1EDL20E1EDDH2SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Diagnostics.DebuggerStepThroughAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Partial Public Class ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL33

        Private aLANDField As String

        Private eXPVZField As String

        Private zOLLAField As String

        Private zOLLBField As String

        Private zOLL1Field As String

        Private zOLL2Field As String

        Private zOLL3Field As String

        Private zOLL4Field As String

        Private zOLL5Field As String

        Private zOLL6Field As String

        Private kZGBEField As String

        Private kZABEField As String

        Private sTGBEField As String

        Private sTABEField As String

        Private cONTAField As String

        Private gRWCUField As String

        Private iEVERField As String

        Private pREV_DOC_NOField As String

        Private pREV_DOC_TYPEField As String

        Private e1EDL34Field As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL33E1EDL34

        Private sEGMENTField As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL33SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property ALAND() As String
            Get
                Return Me.aLANDField
            End Get
            Set
                Me.aLANDField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public Property EXPVZ() As String
            Get
                Return Me.eXPVZField
            End Get
            Set
                Me.eXPVZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>
        Public Property ZOLLA() As String
            Get
                Return Me.zOLLAField
            End Get
            Set
                Me.zOLLAField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=3)>
        Public Property ZOLLB() As String
            Get
                Return Me.zOLLBField
            End Get
            Set
                Me.zOLLBField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=4)>
        Public Property ZOLL1() As String
            Get
                Return Me.zOLL1Field
            End Get
            Set
                Me.zOLL1Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=5)>
        Public Property ZOLL2() As String
            Get
                Return Me.zOLL2Field
            End Get
            Set
                Me.zOLL2Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=6)>
        Public Property ZOLL3() As String
            Get
                Return Me.zOLL3Field
            End Get
            Set
                Me.zOLL3Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=7)>
        Public Property ZOLL4() As String
            Get
                Return Me.zOLL4Field
            End Get
            Set
                Me.zOLL4Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=8)>
        Public Property ZOLL5() As String
            Get
                Return Me.zOLL5Field
            End Get
            Set
                Me.zOLL5Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=9)>
        Public Property ZOLL6() As String
            Get
                Return Me.zOLL6Field
            End Get
            Set
                Me.zOLL6Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=10)>
        Public Property KZGBE() As String
            Get
                Return Me.kZGBEField
            End Get
            Set
                Me.kZGBEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=11)>
        Public Property KZABE() As String
            Get
                Return Me.kZABEField
            End Get
            Set
                Me.kZABEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=12)>
        Public Property STGBE() As String
            Get
                Return Me.sTGBEField
            End Get
            Set
                Me.sTGBEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=13)>
        Public Property STABE() As String
            Get
                Return Me.sTABEField
            End Get
            Set
                Me.sTABEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=14)>
        Public Property CONTA() As String
            Get
                Return Me.cONTAField
            End Get
            Set
                Me.cONTAField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=15)>
        Public Property GRWCU() As String
            Get
                Return Me.gRWCUField
            End Get
            Set
                Me.gRWCUField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=16)>
        Public Property IEVER() As String
            Get
                Return Me.iEVERField
            End Get
            Set
                Me.iEVERField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=17)>
        Public Property PREV_DOC_NO() As String
            Get
                Return Me.pREV_DOC_NOField
            End Get
            Set
                Me.pREV_DOC_NOField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=18)>
        Public Property PREV_DOC_TYPE() As String
            Get
                Return Me.pREV_DOC_TYPEField
            End Get
            Set
                Me.pREV_DOC_TYPEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=19)>
        Public Property E1EDL34() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL33E1EDL34
            Get
                Return Me.e1EDL34Field
            End Get
            Set
                Me.e1EDL34Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property SEGMENT() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL33SEGMENT
            Get
                Return Me.sEGMENTField
            End Get
            Set
                Me.sEGMENTField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Diagnostics.DebuggerStepThroughAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Partial Public Class ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL33E1EDL34

        Private eXPVZ_BEZField As String

        Private zOLLA_BEZField As String

        Private zOLLB_BEZField As String

        Private zOLL1_BEZField As String

        Private zOLL2_BEZField As String

        Private zOLL3_BEZField As String

        Private zOLL4_BEZField As String

        Private zOLL5_BEZField As String

        Private zOLL6_BEZField As String

        Private iEVER_BEZField As String

        Private sTGBE_BEZField As String

        Private sTABE_BEZField As String

        Private sEGMENTField As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL33E1EDL34SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property EXPVZ_BEZ() As String
            Get
                Return Me.eXPVZ_BEZField
            End Get
            Set
                Me.eXPVZ_BEZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public Property ZOLLA_BEZ() As String
            Get
                Return Me.zOLLA_BEZField
            End Get
            Set
                Me.zOLLA_BEZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>
        Public Property ZOLLB_BEZ() As String
            Get
                Return Me.zOLLB_BEZField
            End Get
            Set
                Me.zOLLB_BEZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=3)>
        Public Property ZOLL1_BEZ() As String
            Get
                Return Me.zOLL1_BEZField
            End Get
            Set
                Me.zOLL1_BEZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=4)>
        Public Property ZOLL2_BEZ() As String
            Get
                Return Me.zOLL2_BEZField
            End Get
            Set
                Me.zOLL2_BEZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=5)>
        Public Property ZOLL3_BEZ() As String
            Get
                Return Me.zOLL3_BEZField
            End Get
            Set
                Me.zOLL3_BEZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=6)>
        Public Property ZOLL4_BEZ() As String
            Get
                Return Me.zOLL4_BEZField
            End Get
            Set
                Me.zOLL4_BEZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=7)>
        Public Property ZOLL5_BEZ() As String
            Get
                Return Me.zOLL5_BEZField
            End Get
            Set
                Me.zOLL5_BEZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=8)>
        Public Property ZOLL6_BEZ() As String
            Get
                Return Me.zOLL6_BEZField
            End Get
            Set
                Me.zOLL6_BEZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=9)>
        Public Property IEVER_BEZ() As String
            Get
                Return Me.iEVER_BEZField
            End Get
            Set
                Me.iEVER_BEZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=10)>
        Public Property STGBE_BEZ() As String
            Get
                Return Me.sTGBE_BEZField
            End Get
            Set
                Me.sTGBE_BEZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=11)>
        Public Property STABE_BEZ() As String
            Get
                Return Me.sTABE_BEZField
            End Get
            Set
                Me.sTABE_BEZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property SEGMENT() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL33E1EDL34SEGMENT
            Get
                Return Me.sEGMENTField
            End Get
            Set
                Me.sEGMENTField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Public Enum ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL33E1EDL34SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Public Enum ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL33SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Diagnostics.DebuggerStepThroughAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Partial Public Class ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL28

        Private rOUTEField As String

        Private vSARTField As String

        Private vSAVLField As String

        Private vSANLField As String

        Private rOUIDField As String

        Private dISTZField As String

        Private mEDSTField As String

        Private e1EDL29Field As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL28E1EDL29

        Private e1EDL30Field() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL28E1EDL30

        Private sEGMENTField As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL28SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property ROUTE() As String
            Get
                Return Me.rOUTEField
            End Get
            Set
                Me.rOUTEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public Property VSART() As String
            Get
                Return Me.vSARTField
            End Get
            Set
                Me.vSARTField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>
        Public Property VSAVL() As String
            Get
                Return Me.vSAVLField
            End Get
            Set
                Me.vSAVLField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=3)>
        Public Property VSANL() As String
            Get
                Return Me.vSANLField
            End Get
            Set
                Me.vSANLField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=4)>
        Public Property ROUID() As String
            Get
                Return Me.rOUIDField
            End Get
            Set
                Me.rOUIDField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=5)>
        Public Property DISTZ() As String
            Get
                Return Me.dISTZField
            End Get
            Set
                Me.dISTZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=6)>
        Public Property MEDST() As String
            Get
                Return Me.mEDSTField
            End Get
            Set
                Me.mEDSTField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=7)>
        Public Property E1EDL29() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL28E1EDL29
            Get
                Return Me.e1EDL29Field
            End Get
            Set
                Me.e1EDL29Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("E1EDL30", Order:=8)>
        Public Property E1EDL30() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL28E1EDL30()
            Get
                Return Me.e1EDL30Field
            End Get
            Set
                Me.e1EDL30Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property SEGMENT() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL28SEGMENT
            Get
                Return Me.sEGMENTField
            End Get
            Set
                Me.sEGMENTField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Diagnostics.DebuggerStepThroughAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Partial Public Class ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL28E1EDL29

        Private rOUTE_BEZField As String

        Private vSART_BEZField As String

        Private vSAVL_BEZField As String

        Private vSANL_BEZField As String

        Private sEGMENTField As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL28E1EDL29SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property ROUTE_BEZ() As String
            Get
                Return Me.rOUTE_BEZField
            End Get
            Set
                Me.rOUTE_BEZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public Property VSART_BEZ() As String
            Get
                Return Me.vSART_BEZField
            End Get
            Set
                Me.vSART_BEZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>
        Public Property VSAVL_BEZ() As String
            Get
                Return Me.vSAVL_BEZField
            End Get
            Set
                Me.vSAVL_BEZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=3)>
        Public Property VSANL_BEZ() As String
            Get
                Return Me.vSANL_BEZField
            End Get
            Set
                Me.vSANL_BEZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property SEGMENT() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL28E1EDL29SEGMENT
            Get
                Return Me.sEGMENTField
            End Get
            Set
                Me.sEGMENTField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Public Enum ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL28E1EDL29SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Diagnostics.DebuggerStepThroughAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Partial Public Class ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL28E1EDL30

        Private aBNUMField As String

        Private aNFRFField As String

        Private vSARTField As String

        Private dISTZField As String

        Private mEDSTField As String

        Private tSTYPField As String

        Private e1EDL31Field As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL28E1EDL30E1EDL31

        Private e1EDL32Field() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL28E1EDL30E1EDL32

        Private sEGMENTField As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL28E1EDL30SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property ABNUM() As String
            Get
                Return Me.aBNUMField
            End Get
            Set
                Me.aBNUMField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public Property ANFRF() As String
            Get
                Return Me.aNFRFField
            End Get
            Set
                Me.aNFRFField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>
        Public Property VSART() As String
            Get
                Return Me.vSARTField
            End Get
            Set
                Me.vSARTField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=3)>
        Public Property DISTZ() As String
            Get
                Return Me.dISTZField
            End Get
            Set
                Me.dISTZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=4)>
        Public Property MEDST() As String
            Get
                Return Me.mEDSTField
            End Get
            Set
                Me.mEDSTField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=5)>
        Public Property TSTYP() As String
            Get
                Return Me.tSTYPField
            End Get
            Set
                Me.tSTYPField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=6)>
        Public Property E1EDL31() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL28E1EDL30E1EDL31
            Get
                Return Me.e1EDL31Field
            End Get
            Set
                Me.e1EDL31Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("E1EDL32", Order:=7)>
        Public Property E1EDL32() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL28E1EDL30E1EDL32()
            Get
                Return Me.e1EDL32Field
            End Get
            Set
                Me.e1EDL32Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property SEGMENT() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL28E1EDL30SEGMENT
            Get
                Return Me.sEGMENTField
            End Get
            Set
                Me.sEGMENTField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Diagnostics.DebuggerStepThroughAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Partial Public Class ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL28E1EDL30E1EDL31

        Private vSART_BEZField As String

        Private sEGMENTField As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL28E1EDL30E1EDL31SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property VSART_BEZ() As String
            Get
                Return Me.vSART_BEZField
            End Get
            Set
                Me.vSART_BEZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property SEGMENT() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL28E1EDL30E1EDL31SEGMENT
            Get
                Return Me.sEGMENTField
            End Get
            Set
                Me.sEGMENTField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Public Enum ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL28E1EDL30E1EDL31SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Diagnostics.DebuggerStepThroughAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Partial Public Class ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL28E1EDL30E1EDL32

        Private qUALIField As String

        Private kNOTEField As String

        Private aDRNRField As String

        Private vSTELField As String

        Private lSTELField As String

        Private wERKSField As String

        Private lGORTField As String

        Private kUNNRField As String

        Private lIFNRField As String

        Private aBLADField As String

        Private lGNUMField As String

        Private lGTORField As String

        Private e1EDL45Field As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL28E1EDL30E1EDL32E1EDL45

        Private e1ADRM3Field As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL28E1EDL30E1EDL32E1ADRM3

        Private sEGMENTField As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL28E1EDL30E1EDL32SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property QUALI() As String
            Get
                Return Me.qUALIField
            End Get
            Set
                Me.qUALIField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public Property KNOTE() As String
            Get
                Return Me.kNOTEField
            End Get
            Set
                Me.kNOTEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>
        Public Property ADRNR() As String
            Get
                Return Me.aDRNRField
            End Get
            Set
                Me.aDRNRField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=3)>
        Public Property VSTEL() As String
            Get
                Return Me.vSTELField
            End Get
            Set
                Me.vSTELField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=4)>
        Public Property LSTEL() As String
            Get
                Return Me.lSTELField
            End Get
            Set
                Me.lSTELField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=5)>
        Public Property WERKS() As String
            Get
                Return Me.wERKSField
            End Get
            Set
                Me.wERKSField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=6)>
        Public Property LGORT() As String
            Get
                Return Me.lGORTField
            End Get
            Set
                Me.lGORTField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=7)>
        Public Property KUNNR() As String
            Get
                Return Me.kUNNRField
            End Get
            Set
                Me.kUNNRField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=8)>
        Public Property LIFNR() As String
            Get
                Return Me.lIFNRField
            End Get
            Set
                Me.lIFNRField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=9)>
        Public Property ABLAD() As String
            Get
                Return Me.aBLADField
            End Get
            Set
                Me.aBLADField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=10)>
        Public Property LGNUM() As String
            Get
                Return Me.lGNUMField
            End Get
            Set
                Me.lGNUMField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=11)>
        Public Property LGTOR() As String
            Get
                Return Me.lGTORField
            End Get
            Set
                Me.lGTORField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=12)>
        Public Property E1EDL45() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL28E1EDL30E1EDL32E1EDL45
            Get
                Return Me.e1EDL45Field
            End Get
            Set
                Me.e1EDL45Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=13)>
        Public Property E1ADRM3() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL28E1EDL30E1EDL32E1ADRM3
            Get
                Return Me.e1ADRM3Field
            End Get
            Set
                Me.e1ADRM3Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property SEGMENT() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL28E1EDL30E1EDL32SEGMENT
            Get
                Return Me.sEGMENTField
            End Get
            Set
                Me.sEGMENTField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Diagnostics.DebuggerStepThroughAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Partial Public Class ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL28E1EDL30E1EDL32E1EDL45

        Private kNOTE_BEZField As String

        Private vSTEL_BEZField As String

        Private lSTEL_BEZField As String

        Private wERKS_BEZField As String

        Private lGORT_BEZField As String

        Private lGNUM_BEZField As String

        Private lGTOR_BEZField As String

        Private sEGMENTField As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL28E1EDL30E1EDL32E1EDL45SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property KNOTE_BEZ() As String
            Get
                Return Me.kNOTE_BEZField
            End Get
            Set
                Me.kNOTE_BEZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public Property VSTEL_BEZ() As String
            Get
                Return Me.vSTEL_BEZField
            End Get
            Set
                Me.vSTEL_BEZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>
        Public Property LSTEL_BEZ() As String
            Get
                Return Me.lSTEL_BEZField
            End Get
            Set
                Me.lSTEL_BEZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=3)>
        Public Property WERKS_BEZ() As String
            Get
                Return Me.wERKS_BEZField
            End Get
            Set
                Me.wERKS_BEZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=4)>
        Public Property LGORT_BEZ() As String
            Get
                Return Me.lGORT_BEZField
            End Get
            Set
                Me.lGORT_BEZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=5)>
        Public Property LGNUM_BEZ() As String
            Get
                Return Me.lGNUM_BEZField
            End Get
            Set
                Me.lGNUM_BEZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=6)>
        Public Property LGTOR_BEZ() As String
            Get
                Return Me.lGTOR_BEZField
            End Get
            Set
                Me.lGTOR_BEZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property SEGMENT() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL28E1EDL30E1EDL32E1EDL45SEGMENT
            Get
                Return Me.sEGMENTField
            End Get
            Set
                Me.sEGMENTField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Public Enum ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL28E1EDL30E1EDL32E1EDL45SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Diagnostics.DebuggerStepThroughAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Partial Public Class ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL28E1EDL30E1EDL32E1ADRM3

        Private pARTNER_QField As String

        Private aDDRES_TField As String

        Private pARTNER_IDField As String

        Private jURISDICField As String

        Private lANGUAGEField As String

        Private fORMOFADDRField As String

        Private nAME1Field As String

        Private nAME2Field As String

        Private nAME3Field As String

        Private nAME4Field As String

        Private nAME_TEXTField As String

        Private nAME_COField As String

        Private lOCATIONField As String

        Private bUILDINGField As String

        Private fLOORField As String

        Private rOOMField As String

        Private sTREET1Field As String

        Private sTREET2Field As String

        Private sTREET3Field As String

        Private hOUSE_SUPLField As String

        Private hOUSE_RANGField As String

        Private pOSTL_COD1Field As String

        Private pOSTL_COD3Field As String

        Private pOSTL_AREAField As String

        Private cITY1Field As String

        Private cITY2Field As String

        Private pOSTL_PBOXField As String

        Private pOSTL_COD2Field As String

        Private pOSTL_CITYField As String

        Private tELEPHONE1Field As String

        Private tELEPHONE2Field As String

        Private tELEFAXField As String

        Private tELEXField As String

        Private e_MAILField As String

        Private cOUNTRY1Field As String

        Private cOUNTRY2Field As String

        Private rEGIONField As String

        Private cOUNTY_CODField As String

        Private cOUNTY_TXTField As String

        Private tZCODEField As String

        Private tZDESCField As String

        Private sEGMENTField As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL28E1EDL30E1EDL32E1ADRM3SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property PARTNER_Q() As String
            Get
                Return Me.pARTNER_QField
            End Get
            Set
                Me.pARTNER_QField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public Property ADDRES_T() As String
            Get
                Return Me.aDDRES_TField
            End Get
            Set
                Me.aDDRES_TField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>
        Public Property PARTNER_ID() As String
            Get
                Return Me.pARTNER_IDField
            End Get
            Set
                Me.pARTNER_IDField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=3)>
        Public Property JURISDIC() As String
            Get
                Return Me.jURISDICField
            End Get
            Set
                Me.jURISDICField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=4)>
        Public Property LANGUAGE() As String
            Get
                Return Me.lANGUAGEField
            End Get
            Set
                Me.lANGUAGEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=5)>
        Public Property FORMOFADDR() As String
            Get
                Return Me.fORMOFADDRField
            End Get
            Set
                Me.fORMOFADDRField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=6)>
        Public Property NAME1() As String
            Get
                Return Me.nAME1Field
            End Get
            Set
                Me.nAME1Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=7)>
        Public Property NAME2() As String
            Get
                Return Me.nAME2Field
            End Get
            Set
                Me.nAME2Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=8)>
        Public Property NAME3() As String
            Get
                Return Me.nAME3Field
            End Get
            Set
                Me.nAME3Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=9)>
        Public Property NAME4() As String
            Get
                Return Me.nAME4Field
            End Get
            Set
                Me.nAME4Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=10)>
        Public Property NAME_TEXT() As String
            Get
                Return Me.nAME_TEXTField
            End Get
            Set
                Me.nAME_TEXTField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=11)>
        Public Property NAME_CO() As String
            Get
                Return Me.nAME_COField
            End Get
            Set
                Me.nAME_COField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=12)>
        Public Property LOCATION() As String
            Get
                Return Me.lOCATIONField
            End Get
            Set
                Me.lOCATIONField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=13)>
        Public Property BUILDING() As String
            Get
                Return Me.bUILDINGField
            End Get
            Set
                Me.bUILDINGField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=14)>
        Public Property FLOOR() As String
            Get
                Return Me.fLOORField
            End Get
            Set
                Me.fLOORField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=15)>
        Public Property ROOM() As String
            Get
                Return Me.rOOMField
            End Get
            Set
                Me.rOOMField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=16)>
        Public Property STREET1() As String
            Get
                Return Me.sTREET1Field
            End Get
            Set
                Me.sTREET1Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=17)>
        Public Property STREET2() As String
            Get
                Return Me.sTREET2Field
            End Get
            Set
                Me.sTREET2Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=18)>
        Public Property STREET3() As String
            Get
                Return Me.sTREET3Field
            End Get
            Set
                Me.sTREET3Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=19)>
        Public Property HOUSE_SUPL() As String
            Get
                Return Me.hOUSE_SUPLField
            End Get
            Set
                Me.hOUSE_SUPLField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=20)>
        Public Property HOUSE_RANG() As String
            Get
                Return Me.hOUSE_RANGField
            End Get
            Set
                Me.hOUSE_RANGField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=21)>
        Public Property POSTL_COD1() As String
            Get
                Return Me.pOSTL_COD1Field
            End Get
            Set
                Me.pOSTL_COD1Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=22)>
        Public Property POSTL_COD3() As String
            Get
                Return Me.pOSTL_COD3Field
            End Get
            Set
                Me.pOSTL_COD3Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=23)>
        Public Property POSTL_AREA() As String
            Get
                Return Me.pOSTL_AREAField
            End Get
            Set
                Me.pOSTL_AREAField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=24)>
        Public Property CITY1() As String
            Get
                Return Me.cITY1Field
            End Get
            Set
                Me.cITY1Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=25)>
        Public Property CITY2() As String
            Get
                Return Me.cITY2Field
            End Get
            Set
                Me.cITY2Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=26)>
        Public Property POSTL_PBOX() As String
            Get
                Return Me.pOSTL_PBOXField
            End Get
            Set
                Me.pOSTL_PBOXField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=27)>
        Public Property POSTL_COD2() As String
            Get
                Return Me.pOSTL_COD2Field
            End Get
            Set
                Me.pOSTL_COD2Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=28)>
        Public Property POSTL_CITY() As String
            Get
                Return Me.pOSTL_CITYField
            End Get
            Set
                Me.pOSTL_CITYField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=29)>
        Public Property TELEPHONE1() As String
            Get
                Return Me.tELEPHONE1Field
            End Get
            Set
                Me.tELEPHONE1Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=30)>
        Public Property TELEPHONE2() As String
            Get
                Return Me.tELEPHONE2Field
            End Get
            Set
                Me.tELEPHONE2Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=31)>
        Public Property TELEFAX() As String
            Get
                Return Me.tELEFAXField
            End Get
            Set
                Me.tELEFAXField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=32)>
        Public Property TELEX() As String
            Get
                Return Me.tELEXField
            End Get
            Set
                Me.tELEXField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=33)>
        Public Property E_MAIL() As String
            Get
                Return Me.e_MAILField
            End Get
            Set
                Me.e_MAILField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=34)>
        Public Property COUNTRY1() As String
            Get
                Return Me.cOUNTRY1Field
            End Get
            Set
                Me.cOUNTRY1Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=35)>
        Public Property COUNTRY2() As String
            Get
                Return Me.cOUNTRY2Field
            End Get
            Set
                Me.cOUNTRY2Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=36)>
        Public Property REGION() As String
            Get
                Return Me.rEGIONField
            End Get
            Set
                Me.rEGIONField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=37)>
        Public Property COUNTY_COD() As String
            Get
                Return Me.cOUNTY_CODField
            End Get
            Set
                Me.cOUNTY_CODField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=38)>
        Public Property COUNTY_TXT() As String
            Get
                Return Me.cOUNTY_TXTField
            End Get
            Set
                Me.cOUNTY_TXTField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=39)>
        Public Property TZCODE() As String
            Get
                Return Me.tZCODEField
            End Get
            Set
                Me.tZCODEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=40)>
        Public Property TZDESC() As String
            Get
                Return Me.tZDESCField
            End Get
            Set
                Me.tZDESCField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property SEGMENT() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL28E1EDL30E1EDL32E1ADRM3SEGMENT
            Get
                Return Me.sEGMENTField
            End Get
            Set
                Me.sEGMENTField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Public Enum ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL28E1EDL30E1EDL32E1ADRM3SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Public Enum ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL28E1EDL30E1EDL32SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Public Enum ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL28E1EDL30SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Public Enum ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL28SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Diagnostics.DebuggerStepThroughAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Partial Public Class ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL47

        Private xSITDField As String

        Private sHIPACCTField As String

        Private tRACKNField As String

        Private rOUTECODEField As String

        Private xSISRVCField As String

        Private pRDCDField As String

        Private xSIURL_MULTI_TRACKField As String

        Private e1EDL48Field() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL47E1EDL48

        Private sEGMENTField As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL47SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property XSITD() As String
            Get
                Return Me.xSITDField
            End Get
            Set
                Me.xSITDField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public Property SHIPACCT() As String
            Get
                Return Me.sHIPACCTField
            End Get
            Set
                Me.sHIPACCTField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>
        Public Property TRACKN() As String
            Get
                Return Me.tRACKNField
            End Get
            Set
                Me.tRACKNField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=3)>
        Public Property ROUTECODE() As String
            Get
                Return Me.rOUTECODEField
            End Get
            Set
                Me.rOUTECODEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=4)>
        Public Property XSISRVC() As String
            Get
                Return Me.xSISRVCField
            End Get
            Set
                Me.xSISRVCField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=5)>
        Public Property PRDCD() As String
            Get
                Return Me.pRDCDField
            End Get
            Set
                Me.pRDCDField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=6)>
        Public Property XSIURL_MULTI_TRACK() As String
            Get
                Return Me.xSIURL_MULTI_TRACKField
            End Get
            Set
                Me.xSIURL_MULTI_TRACKField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("E1EDL48", Order:=7)>
        Public Property E1EDL48() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL47E1EDL48()
            Get
                Return Me.e1EDL48Field
            End Get
            Set
                Me.e1EDL48Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property SEGMENT() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL47SEGMENT
            Get
                Return Me.sEGMENTField
            End Get
            Set
                Me.sEGMENTField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Diagnostics.DebuggerStepThroughAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Partial Public Class ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL47E1EDL48

        Private xSIQUALFField As String

        Private xSITDField As String

        Private vLABDATAField As String

        Private sEGMENTField As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL47E1EDL48SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property XSIQUALF() As String
            Get
                Return Me.xSIQUALFField
            End Get
            Set
                Me.xSIQUALFField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public Property XSITD() As String
            Get
                Return Me.xSITDField
            End Get
            Set
                Me.xSITDField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>
        Public Property VLABDATA() As String
            Get
                Return Me.vLABDATAField
            End Get
            Set
                Me.vLABDATAField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property SEGMENT() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL47E1EDL48SEGMENT
            Get
                Return Me.sEGMENTField
            End Get
            Set
                Me.sEGMENTField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Public Enum ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL47E1EDL48SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Public Enum ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL47SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Diagnostics.DebuggerStepThroughAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Partial Public Class ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24

        Private pOSNRField As String

        Private mATNRField As String

        Private mATWAField As String

        Private aRKTXField As String

        Private oRKTXField As String

        Private sUGRDField As String

        Private sUDRUField As String

        Private mATKLField As String

        Private wERKSField As String

        Private lGORTField As String

        Private cHARGField As String

        Private kDMATField As String

        Private lFIMGField As String

        Private vRKMEField As String

        Private lGMNGField As String

        Private mEINSField As String

        Private nTGEWField As String

        Private bRGEWField As String

        Private gEWEIField As String

        Private vOLUMField As String

        Private vOLEHField As String

        Private lGPBEField As String

        Private hIPOSField As String

        Private hIEVWField As String

        Private lADGRField As String

        Private tRAGRField As String

        Private vKBURField As String

        Private vKGRPField As String

        Private vTWEGField As String

        Private sPARTField As String

        Private gRKORField As String

        Private eAN11Field As String

        Private sERNRField As String

        Private aESKDField As String

        Private eMPSTField As String

        Private mFRGRField As String

        Private vBRSTField As String

        Private lABNKField As String

        Private aBRDTField As String

        Private mFRPNField As String

        Private mFRNRField As String

        Private aBRVWField As String

        Private kDMAT35Field As String

        Private kANNRField As String

        Private pOSEXField As String

        Private lIEFFZField As String

        Private uSR01Field As String

        Private uSR02Field As String

        Private uSR03Field As String

        Private uSR04Field As String

        Private uSR05Field As String

        Private mATNR_EXTERNALField As String

        Private mATNR_VERSIONField As String

        Private mATNR_GUIDField As String

        Private mATWA_EXTERNALField As String

        Private mATWA_VERSIONField As String

        Private mATWA_GUIDField As String

        Private zUDATField As String

        Private vFDATField As String

        Private rMA_NUMBERField As String

        Private rMA_COMPLETEField As String

        Private eXPIRY_DATE_EXTField As String

        Private vGBELField As String

        Private vGPOSField As String

        Private fOLLOW_UP_CODEField As String

        Private oRMNGField As String

        Private cOMPLField As String

        Private hOLDField As String

        Private mAX_ERR_TYPEField As String

        Private lICHNField As String

        Private rECIPIENT_CREATEField As String

        Private eXPIRY_DATE_EXT_BField As String

        Private zSCMT19C_E1EDL24Field() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24ZSCMT19C_E1EDL24

        Private zE1EDL98Field As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24ZE1EDL98

        Private e1EDL25Field As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDL25

        Private e1EDL26Field As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDL26

        Private e1EDL52Field() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDL52

        Private e1EDL53Field() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDL53

        Private e1EDD10Field() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDD10

        Private e1EDD14Field As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDD14

        Private e1EDL19Field() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDL19

        Private e1EDL11Field() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDL11

        Private e1EDL15Field() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDL15

        Private e1EDL35Field As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDL35

        Private e1EDL43Field() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDL43

        Private e1EDL41Field() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDL41

        Private e1TXTH9Field() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1TXTH9

        Private e1EDL12Field() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDL12

        Private sEGMENTField As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property POSNR() As String
            Get
                Return Me.pOSNRField
            End Get
            Set
                Me.pOSNRField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public Property MATNR() As String
            Get
                Return Me.mATNRField
            End Get
            Set
                Me.mATNRField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>
        Public Property MATWA() As String
            Get
                Return Me.mATWAField
            End Get
            Set
                Me.mATWAField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=3)>
        Public Property ARKTX() As String
            Get
                Return Me.aRKTXField
            End Get
            Set
                Me.aRKTXField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=4)>
        Public Property ORKTX() As String
            Get
                Return Me.oRKTXField
            End Get
            Set
                Me.oRKTXField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=5)>
        Public Property SUGRD() As String
            Get
                Return Me.sUGRDField
            End Get
            Set
                Me.sUGRDField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=6)>
        Public Property SUDRU() As String
            Get
                Return Me.sUDRUField
            End Get
            Set
                Me.sUDRUField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=7)>
        Public Property MATKL() As String
            Get
                Return Me.mATKLField
            End Get
            Set
                Me.mATKLField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=8)>
        Public Property WERKS() As String
            Get
                Return Me.wERKSField
            End Get
            Set
                Me.wERKSField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=9)>
        Public Property LGORT() As String
            Get
                Return Me.lGORTField
            End Get
            Set
                Me.lGORTField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=10)>
        Public Property CHARG() As String
            Get
                Return Me.cHARGField
            End Get
            Set
                Me.cHARGField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=11)>
        Public Property KDMAT() As String
            Get
                Return Me.kDMATField
            End Get
            Set
                Me.kDMATField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=12)>
        Public Property LFIMG() As String
            Get
                Return Me.lFIMGField
            End Get
            Set
                Me.lFIMGField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=13)>
        Public Property VRKME() As String
            Get
                Return Me.vRKMEField
            End Get
            Set
                Me.vRKMEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=14)>
        Public Property LGMNG() As String
            Get
                Return Me.lGMNGField
            End Get
            Set
                Me.lGMNGField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=15)>
        Public Property MEINS() As String
            Get
                Return Me.mEINSField
            End Get
            Set
                Me.mEINSField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=16)>
        Public Property NTGEW() As String
            Get
                Return Me.nTGEWField
            End Get
            Set
                Me.nTGEWField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=17)>
        Public Property BRGEW() As String
            Get
                Return Me.bRGEWField
            End Get
            Set
                Me.bRGEWField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=18)>
        Public Property GEWEI() As String
            Get
                Return Me.gEWEIField
            End Get
            Set
                Me.gEWEIField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=19)>
        Public Property VOLUM() As String
            Get
                Return Me.vOLUMField
            End Get
            Set
                Me.vOLUMField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=20)>
        Public Property VOLEH() As String
            Get
                Return Me.vOLEHField
            End Get
            Set
                Me.vOLEHField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=21)>
        Public Property LGPBE() As String
            Get
                Return Me.lGPBEField
            End Get
            Set
                Me.lGPBEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=22)>
        Public Property HIPOS() As String
            Get
                Return Me.hIPOSField
            End Get
            Set
                Me.hIPOSField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=23)>
        Public Property HIEVW() As String
            Get
                Return Me.hIEVWField
            End Get
            Set
                Me.hIEVWField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=24)>
        Public Property LADGR() As String
            Get
                Return Me.lADGRField
            End Get
            Set
                Me.lADGRField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=25)>
        Public Property TRAGR() As String
            Get
                Return Me.tRAGRField
            End Get
            Set
                Me.tRAGRField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=26)>
        Public Property VKBUR() As String
            Get
                Return Me.vKBURField
            End Get
            Set
                Me.vKBURField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=27)>
        Public Property VKGRP() As String
            Get
                Return Me.vKGRPField
            End Get
            Set
                Me.vKGRPField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=28)>
        Public Property VTWEG() As String
            Get
                Return Me.vTWEGField
            End Get
            Set
                Me.vTWEGField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=29)>
        Public Property SPART() As String
            Get
                Return Me.sPARTField
            End Get
            Set
                Me.sPARTField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=30)>
        Public Property GRKOR() As String
            Get
                Return Me.gRKORField
            End Get
            Set
                Me.gRKORField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=31)>
        Public Property EAN11() As String
            Get
                Return Me.eAN11Field
            End Get
            Set
                Me.eAN11Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=32)>
        Public Property SERNR() As String
            Get
                Return Me.sERNRField
            End Get
            Set
                Me.sERNRField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=33)>
        Public Property AESKD() As String
            Get
                Return Me.aESKDField
            End Get
            Set
                Me.aESKDField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=34)>
        Public Property EMPST() As String
            Get
                Return Me.eMPSTField
            End Get
            Set
                Me.eMPSTField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=35)>
        Public Property MFRGR() As String
            Get
                Return Me.mFRGRField
            End Get
            Set
                Me.mFRGRField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=36)>
        Public Property VBRST() As String
            Get
                Return Me.vBRSTField
            End Get
            Set
                Me.vBRSTField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=37)>
        Public Property LABNK() As String
            Get
                Return Me.lABNKField
            End Get
            Set
                Me.lABNKField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=38)>
        Public Property ABRDT() As String
            Get
                Return Me.aBRDTField
            End Get
            Set
                Me.aBRDTField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=39)>
        Public Property MFRPN() As String
            Get
                Return Me.mFRPNField
            End Get
            Set
                Me.mFRPNField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=40)>
        Public Property MFRNR() As String
            Get
                Return Me.mFRNRField
            End Get
            Set
                Me.mFRNRField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=41)>
        Public Property ABRVW() As String
            Get
                Return Me.aBRVWField
            End Get
            Set
                Me.aBRVWField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=42)>
        Public Property KDMAT35() As String
            Get
                Return Me.kDMAT35Field
            End Get
            Set
                Me.kDMAT35Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=43)>
        Public Property KANNR() As String
            Get
                Return Me.kANNRField
            End Get
            Set
                Me.kANNRField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=44)>
        Public Property POSEX() As String
            Get
                Return Me.pOSEXField
            End Get
            Set
                Me.pOSEXField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=45)>
        Public Property LIEFFZ() As String
            Get
                Return Me.lIEFFZField
            End Get
            Set
                Me.lIEFFZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=46)>
        Public Property USR01() As String
            Get
                Return Me.uSR01Field
            End Get
            Set
                Me.uSR01Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=47)>
        Public Property USR02() As String
            Get
                Return Me.uSR02Field
            End Get
            Set
                Me.uSR02Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=48)>
        Public Property USR03() As String
            Get
                Return Me.uSR03Field
            End Get
            Set
                Me.uSR03Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=49)>
        Public Property USR04() As String
            Get
                Return Me.uSR04Field
            End Get
            Set
                Me.uSR04Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=50)>
        Public Property USR05() As String
            Get
                Return Me.uSR05Field
            End Get
            Set
                Me.uSR05Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=51)>
        Public Property MATNR_EXTERNAL() As String
            Get
                Return Me.mATNR_EXTERNALField
            End Get
            Set
                Me.mATNR_EXTERNALField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=52)>
        Public Property MATNR_VERSION() As String
            Get
                Return Me.mATNR_VERSIONField
            End Get
            Set
                Me.mATNR_VERSIONField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=53)>
        Public Property MATNR_GUID() As String
            Get
                Return Me.mATNR_GUIDField
            End Get
            Set
                Me.mATNR_GUIDField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=54)>
        Public Property MATWA_EXTERNAL() As String
            Get
                Return Me.mATWA_EXTERNALField
            End Get
            Set
                Me.mATWA_EXTERNALField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=55)>
        Public Property MATWA_VERSION() As String
            Get
                Return Me.mATWA_VERSIONField
            End Get
            Set
                Me.mATWA_VERSIONField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=56)>
        Public Property MATWA_GUID() As String
            Get
                Return Me.mATWA_GUIDField
            End Get
            Set
                Me.mATWA_GUIDField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=57)>
        Public Property ZUDAT() As String
            Get
                Return Me.zUDATField
            End Get
            Set
                Me.zUDATField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=58)>
        Public Property VFDAT() As String
            Get
                Return Me.vFDATField
            End Get
            Set
                Me.vFDATField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=59)>
        Public Property RMA_NUMBER() As String
            Get
                Return Me.rMA_NUMBERField
            End Get
            Set
                Me.rMA_NUMBERField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=60)>
        Public Property RMA_COMPLETE() As String
            Get
                Return Me.rMA_COMPLETEField
            End Get
            Set
                Me.rMA_COMPLETEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=61)>
        Public Property EXPIRY_DATE_EXT() As String
            Get
                Return Me.eXPIRY_DATE_EXTField
            End Get
            Set
                Me.eXPIRY_DATE_EXTField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=62)>
        Public Property VGBEL() As String
            Get
                Return Me.vGBELField
            End Get
            Set
                Me.vGBELField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=63)>
        Public Property VGPOS() As String
            Get
                Return Me.vGPOSField
            End Get
            Set
                Me.vGPOSField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=64)>
        Public Property FOLLOW_UP_CODE() As String
            Get
                Return Me.fOLLOW_UP_CODEField
            End Get
            Set
                Me.fOLLOW_UP_CODEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=65)>
        Public Property ORMNG() As String
            Get
                Return Me.oRMNGField
            End Get
            Set
                Me.oRMNGField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=66)>
        Public Property COMPL() As String
            Get
                Return Me.cOMPLField
            End Get
            Set
                Me.cOMPLField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=67)>
        Public Property HOLD() As String
            Get
                Return Me.hOLDField
            End Get
            Set
                Me.hOLDField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=68)>
        Public Property MAX_ERR_TYPE() As String
            Get
                Return Me.mAX_ERR_TYPEField
            End Get
            Set
                Me.mAX_ERR_TYPEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=69)>
        Public Property LICHN() As String
            Get
                Return Me.lICHNField
            End Get
            Set
                Me.lICHNField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=70)>
        Public Property RECIPIENT_CREATE() As String
            Get
                Return Me.rECIPIENT_CREATEField
            End Get
            Set
                Me.rECIPIENT_CREATEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=71)>
        Public Property EXPIRY_DATE_EXT_B() As String
            Get
                Return Me.eXPIRY_DATE_EXT_BField
            End Get
            Set
                Me.eXPIRY_DATE_EXT_BField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("ZSCMT19C_E1EDL24", Order:=72)>
        Public Property ZSCMT19C_E1EDL24() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24ZSCMT19C_E1EDL24()
            Get
                Return Me.zSCMT19C_E1EDL24Field
            End Get
            Set
                Me.zSCMT19C_E1EDL24Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=73)>
        Public Property ZE1EDL98() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24ZE1EDL98
            Get
                Return Me.zE1EDL98Field
            End Get
            Set
                Me.zE1EDL98Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=74)>
        Public Property E1EDL25() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDL25
            Get
                Return Me.e1EDL25Field
            End Get
            Set
                Me.e1EDL25Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=75)>
        Public Property E1EDL26() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDL26
            Get
                Return Me.e1EDL26Field
            End Get
            Set
                Me.e1EDL26Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("E1EDL52", Order:=76)>
        Public Property E1EDL52() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDL52()
            Get
                Return Me.e1EDL52Field
            End Get
            Set
                Me.e1EDL52Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("E1EDL53", Order:=77)>
        Public Property E1EDL53() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDL53()
            Get
                Return Me.e1EDL53Field
            End Get
            Set
                Me.e1EDL53Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("E1EDD10", Order:=78)>
        Public Property E1EDD10() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDD10()
            Get
                Return Me.e1EDD10Field
            End Get
            Set
                Me.e1EDD10Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=79)>
        Public Property E1EDD14() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDD14
            Get
                Return Me.e1EDD14Field
            End Get
            Set
                Me.e1EDD14Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("E1EDL19", Order:=80)>
        Public Property E1EDL19() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDL19()
            Get
                Return Me.e1EDL19Field
            End Get
            Set
                Me.e1EDL19Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("E1EDL11", Order:=81)>
        Public Property E1EDL11() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDL11()
            Get
                Return Me.e1EDL11Field
            End Get
            Set
                Me.e1EDL11Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("E1EDL15", Order:=82)>
        Public Property E1EDL15() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDL15()
            Get
                Return Me.e1EDL15Field
            End Get
            Set
                Me.e1EDL15Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=83)>
        Public Property E1EDL35() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDL35
            Get
                Return Me.e1EDL35Field
            End Get
            Set
                Me.e1EDL35Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("E1EDL43", Order:=84)>
        Public Property E1EDL43() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDL43()
            Get
                Return Me.e1EDL43Field
            End Get
            Set
                Me.e1EDL43Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("E1EDL41", Order:=85)>
        Public Property E1EDL41() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDL41()
            Get
                Return Me.e1EDL41Field
            End Get
            Set
                Me.e1EDL41Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("E1TXTH9", Order:=86)>
        Public Property E1TXTH9() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1TXTH9()
            Get
                Return Me.e1TXTH9Field
            End Get
            Set
                Me.e1TXTH9Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("E1EDL12", Order:=87)>
        Public Property E1EDL12() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDL12()
            Get
                Return Me.e1EDL12Field
            End Get
            Set
                Me.e1EDL12Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property SEGMENT() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24SEGMENT
            Get
                Return Me.sEGMENTField
            End Get
            Set
                Me.sEGMENTField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Diagnostics.DebuggerStepThroughAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Partial Public Class ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24ZSCMT19C_E1EDL24

        Private qUALField As String

        Private vALUE1Field As String

        Private vALUE2Field As String

        Private vALUE3Field As String

        Private vALUE4Field As String

        Private sEGMENTField As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24ZSCMT19C_E1EDL24SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property QUAL() As String
            Get
                Return Me.qUALField
            End Get
            Set
                Me.qUALField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public Property VALUE1() As String
            Get
                Return Me.vALUE1Field
            End Get
            Set
                Me.vALUE1Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>
        Public Property VALUE2() As String
            Get
                Return Me.vALUE2Field
            End Get
            Set
                Me.vALUE2Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=3)>
        Public Property VALUE3() As String
            Get
                Return Me.vALUE3Field
            End Get
            Set
                Me.vALUE3Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=4)>
        Public Property VALUE4() As String
            Get
                Return Me.vALUE4Field
            End Get
            Set
                Me.vALUE4Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property SEGMENT() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24ZSCMT19C_E1EDL24SEGMENT
            Get
                Return Me.sEGMENTField
            End Get
            Set
                Me.sEGMENTField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Public Enum ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24ZSCMT19C_E1EDL24SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Diagnostics.DebuggerStepThroughAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Partial Public Class ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24ZE1EDL98

        Private bWARTField As String

        Private kOSTLField As String

        Private bWTARField As String

        Private sEGMENTField As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24ZE1EDL98SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property BWART() As String
            Get
                Return Me.bWARTField
            End Get
            Set
                Me.bWARTField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public Property KOSTL() As String
            Get
                Return Me.kOSTLField
            End Get
            Set
                Me.kOSTLField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>
        Public Property BWTAR() As String
            Get
                Return Me.bWTARField
            End Get
            Set
                Me.bWTARField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property SEGMENT() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24ZE1EDL98SEGMENT
            Get
                Return Me.sEGMENTField
            End Get
            Set
                Me.sEGMENTField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Public Enum ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24ZE1EDL98SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Diagnostics.DebuggerStepThroughAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Partial Public Class ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDL25

        Private lGORT_BEZField As String

        Private lADGR_BEZField As String

        Private tRAGR_BEZField As String

        Private vKBUR_BEZField As String

        Private vKGRP_BEZField As String

        Private vTWEG_BEZField As String

        Private sPART_BEZField As String

        Private mFRGR_BEZField As String

        Private sEGMENTField As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDL25SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property LGORT_BEZ() As String
            Get
                Return Me.lGORT_BEZField
            End Get
            Set
                Me.lGORT_BEZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public Property LADGR_BEZ() As String
            Get
                Return Me.lADGR_BEZField
            End Get
            Set
                Me.lADGR_BEZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>
        Public Property TRAGR_BEZ() As String
            Get
                Return Me.tRAGR_BEZField
            End Get
            Set
                Me.tRAGR_BEZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=3)>
        Public Property VKBUR_BEZ() As String
            Get
                Return Me.vKBUR_BEZField
            End Get
            Set
                Me.vKBUR_BEZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=4)>
        Public Property VKGRP_BEZ() As String
            Get
                Return Me.vKGRP_BEZField
            End Get
            Set
                Me.vKGRP_BEZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=5)>
        Public Property VTWEG_BEZ() As String
            Get
                Return Me.vTWEG_BEZField
            End Get
            Set
                Me.vTWEG_BEZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=6)>
        Public Property SPART_BEZ() As String
            Get
                Return Me.sPART_BEZField
            End Get
            Set
                Me.sPART_BEZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=7)>
        Public Property MFRGR_BEZ() As String
            Get
                Return Me.mFRGR_BEZField
            End Get
            Set
                Me.mFRGR_BEZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property SEGMENT() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDL25SEGMENT
            Get
                Return Me.sEGMENTField
            End Get
            Set
                Me.sEGMENTField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Public Enum ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDL25SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Diagnostics.DebuggerStepThroughAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Partial Public Class ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDL26

        Private pSTYVField As String

        Private mATKLField As String

        Private pRODHField As String

        Private uMVKZField As String

        Private uMVKNField As String

        Private kZTLFField As String

        Private uEBTKField As String

        Private uEBTOField As String

        Private uNTTOField As String

        Private cHSPLField As String

        Private xCHBWField As String

        Private pOSARField As String

        Private sOBKZField As String

        Private pCKPFField As String

        Private mAGRVField As String

        Private sHKZGField As String

        Private kOQUIField As String

        Private aKTNRField As String

        Private kZUMWField As String

        Private kVGR1Field As String

        Private kVGR2Field As String

        Private kVGR3Field As String

        Private kVGR4Field As String

        Private kVGR5Field As String

        Private mVGR1Field As String

        Private mVGR2Field As String

        Private mVGR3Field As String

        Private mVGR4Field As String

        Private mVGR5Field As String

        Private lIFEXPOS2Field As String

        Private cQU_SAField As String

        Private cQU_SA_UNITField As String

        Private cQU_ITQSField As String

        Private cQU_ITQS_UNITField As String

        Private vBUMG_BMEField As String

        Private sGT_RCATField As String

        Private sGT_SCATField As String

        Private e1EDL27Field As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDL26E1EDL27

        Private sEGMENTField As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDL26SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property PSTYV() As String
            Get
                Return Me.pSTYVField
            End Get
            Set
                Me.pSTYVField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public Property MATKL() As String
            Get
                Return Me.mATKLField
            End Get
            Set
                Me.mATKLField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>
        Public Property PRODH() As String
            Get
                Return Me.pRODHField
            End Get
            Set
                Me.pRODHField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=3)>
        Public Property UMVKZ() As String
            Get
                Return Me.uMVKZField
            End Get
            Set
                Me.uMVKZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=4)>
        Public Property UMVKN() As String
            Get
                Return Me.uMVKNField
            End Get
            Set
                Me.uMVKNField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=5)>
        Public Property KZTLF() As String
            Get
                Return Me.kZTLFField
            End Get
            Set
                Me.kZTLFField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=6)>
        Public Property UEBTK() As String
            Get
                Return Me.uEBTKField
            End Get
            Set
                Me.uEBTKField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=7)>
        Public Property UEBTO() As String
            Get
                Return Me.uEBTOField
            End Get
            Set
                Me.uEBTOField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=8)>
        Public Property UNTTO() As String
            Get
                Return Me.uNTTOField
            End Get
            Set
                Me.uNTTOField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=9)>
        Public Property CHSPL() As String
            Get
                Return Me.cHSPLField
            End Get
            Set
                Me.cHSPLField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=10)>
        Public Property XCHBW() As String
            Get
                Return Me.xCHBWField
            End Get
            Set
                Me.xCHBWField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=11)>
        Public Property POSAR() As String
            Get
                Return Me.pOSARField
            End Get
            Set
                Me.pOSARField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=12)>
        Public Property SOBKZ() As String
            Get
                Return Me.sOBKZField
            End Get
            Set
                Me.sOBKZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=13)>
        Public Property PCKPF() As String
            Get
                Return Me.pCKPFField
            End Get
            Set
                Me.pCKPFField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=14)>
        Public Property MAGRV() As String
            Get
                Return Me.mAGRVField
            End Get
            Set
                Me.mAGRVField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=15)>
        Public Property SHKZG() As String
            Get
                Return Me.sHKZGField
            End Get
            Set
                Me.sHKZGField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=16)>
        Public Property KOQUI() As String
            Get
                Return Me.kOQUIField
            End Get
            Set
                Me.kOQUIField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=17)>
        Public Property AKTNR() As String
            Get
                Return Me.aKTNRField
            End Get
            Set
                Me.aKTNRField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=18)>
        Public Property KZUMW() As String
            Get
                Return Me.kZUMWField
            End Get
            Set
                Me.kZUMWField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=19)>
        Public Property KVGR1() As String
            Get
                Return Me.kVGR1Field
            End Get
            Set
                Me.kVGR1Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=20)>
        Public Property KVGR2() As String
            Get
                Return Me.kVGR2Field
            End Get
            Set
                Me.kVGR2Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=21)>
        Public Property KVGR3() As String
            Get
                Return Me.kVGR3Field
            End Get
            Set
                Me.kVGR3Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=22)>
        Public Property KVGR4() As String
            Get
                Return Me.kVGR4Field
            End Get
            Set
                Me.kVGR4Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=23)>
        Public Property KVGR5() As String
            Get
                Return Me.kVGR5Field
            End Get
            Set
                Me.kVGR5Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=24)>
        Public Property MVGR1() As String
            Get
                Return Me.mVGR1Field
            End Get
            Set
                Me.mVGR1Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=25)>
        Public Property MVGR2() As String
            Get
                Return Me.mVGR2Field
            End Get
            Set
                Me.mVGR2Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=26)>
        Public Property MVGR3() As String
            Get
                Return Me.mVGR3Field
            End Get
            Set
                Me.mVGR3Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=27)>
        Public Property MVGR4() As String
            Get
                Return Me.mVGR4Field
            End Get
            Set
                Me.mVGR4Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=28)>
        Public Property MVGR5() As String
            Get
                Return Me.mVGR5Field
            End Get
            Set
                Me.mVGR5Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=29)>
        Public Property LIFEXPOS2() As String
            Get
                Return Me.lIFEXPOS2Field
            End Get
            Set
                Me.lIFEXPOS2Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=30)>
        Public Property CQU_SA() As String
            Get
                Return Me.cQU_SAField
            End Get
            Set
                Me.cQU_SAField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=31)>
        Public Property CQU_SA_UNIT() As String
            Get
                Return Me.cQU_SA_UNITField
            End Get
            Set
                Me.cQU_SA_UNITField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=32)>
        Public Property CQU_ITQS() As String
            Get
                Return Me.cQU_ITQSField
            End Get
            Set
                Me.cQU_ITQSField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=33)>
        Public Property CQU_ITQS_UNIT() As String
            Get
                Return Me.cQU_ITQS_UNITField
            End Get
            Set
                Me.cQU_ITQS_UNITField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=34)>
        Public Property VBUMG_BME() As String
            Get
                Return Me.vBUMG_BMEField
            End Get
            Set
                Me.vBUMG_BMEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=35)>
        Public Property SGT_RCAT() As String
            Get
                Return Me.sGT_RCATField
            End Get
            Set
                Me.sGT_RCATField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=36)>
        Public Property SGT_SCAT() As String
            Get
                Return Me.sGT_SCATField
            End Get
            Set
                Me.sGT_SCATField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=37)>
        Public Property E1EDL27() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDL26E1EDL27
            Get
                Return Me.e1EDL27Field
            End Get
            Set
                Me.e1EDL27Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property SEGMENT() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDL26SEGMENT
            Get
                Return Me.sEGMENTField
            End Get
            Set
                Me.sEGMENTField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Diagnostics.DebuggerStepThroughAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Partial Public Class ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDL26E1EDL27

        Private pSTYV_BEZField As String

        Private mATKL_BEZField As String

        Private pRODH_BEZField As String

        Private wERKS_BEZField As String

        Private kVGR1_BEZField As String

        Private kVGR2_BEZField As String

        Private kVGR3_BEZField As String

        Private kVGR4_BEZField As String

        Private kVGR5_BEZField As String

        Private mVGR1_BEZField As String

        Private mVGR2_BEZField As String

        Private mVGR3_BEZField As String

        Private mVGR4_BEZField As String

        Private mVGR5_BEZField As String

        Private sEGMENTField As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDL26E1EDL27SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property PSTYV_BEZ() As String
            Get
                Return Me.pSTYV_BEZField
            End Get
            Set
                Me.pSTYV_BEZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public Property MATKL_BEZ() As String
            Get
                Return Me.mATKL_BEZField
            End Get
            Set
                Me.mATKL_BEZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>
        Public Property PRODH_BEZ() As String
            Get
                Return Me.pRODH_BEZField
            End Get
            Set
                Me.pRODH_BEZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=3)>
        Public Property WERKS_BEZ() As String
            Get
                Return Me.wERKS_BEZField
            End Get
            Set
                Me.wERKS_BEZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=4)>
        Public Property KVGR1_BEZ() As String
            Get
                Return Me.kVGR1_BEZField
            End Get
            Set
                Me.kVGR1_BEZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=5)>
        Public Property KVGR2_BEZ() As String
            Get
                Return Me.kVGR2_BEZField
            End Get
            Set
                Me.kVGR2_BEZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=6)>
        Public Property KVGR3_BEZ() As String
            Get
                Return Me.kVGR3_BEZField
            End Get
            Set
                Me.kVGR3_BEZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=7)>
        Public Property KVGR4_BEZ() As String
            Get
                Return Me.kVGR4_BEZField
            End Get
            Set
                Me.kVGR4_BEZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=8)>
        Public Property KVGR5_BEZ() As String
            Get
                Return Me.kVGR5_BEZField
            End Get
            Set
                Me.kVGR5_BEZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=9)>
        Public Property MVGR1_BEZ() As String
            Get
                Return Me.mVGR1_BEZField
            End Get
            Set
                Me.mVGR1_BEZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=10)>
        Public Property MVGR2_BEZ() As String
            Get
                Return Me.mVGR2_BEZField
            End Get
            Set
                Me.mVGR2_BEZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=11)>
        Public Property MVGR3_BEZ() As String
            Get
                Return Me.mVGR3_BEZField
            End Get
            Set
                Me.mVGR3_BEZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=12)>
        Public Property MVGR4_BEZ() As String
            Get
                Return Me.mVGR4_BEZField
            End Get
            Set
                Me.mVGR4_BEZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=13)>
        Public Property MVGR5_BEZ() As String
            Get
                Return Me.mVGR5_BEZField
            End Get
            Set
                Me.mVGR5_BEZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property SEGMENT() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDL26E1EDL27SEGMENT
            Get
                Return Me.sEGMENTField
            End Get
            Set
                Me.sEGMENTField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Public Enum ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDL26E1EDL27SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Public Enum ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDL26SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Diagnostics.DebuggerStepThroughAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Partial Public Class ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDL52

        Private qUALFField As String

        Private pRODNField As String

        Private iTMNRField As String

        Private sQUNTField As String

        Private sEGMENTField As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDL52SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property QUALF() As String
            Get
                Return Me.qUALFField
            End Get
            Set
                Me.qUALFField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public Property PRODN() As String
            Get
                Return Me.pRODNField
            End Get
            Set
                Me.pRODNField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>
        Public Property ITMNR() As String
            Get
                Return Me.iTMNRField
            End Get
            Set
                Me.iTMNRField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=3)>
        Public Property SQUNT() As String
            Get
                Return Me.sQUNTField
            End Get
            Set
                Me.sQUNTField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property SEGMENT() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDL52SEGMENT
            Get
                Return Me.sEGMENTField
            End Get
            Set
                Me.sEGMENTField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Public Enum ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDL52SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Diagnostics.DebuggerStepThroughAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Partial Public Class ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDL53

        Private gRUNDField As String

        Private pODMGField As String

        Private lFIMG_DIFFField As String

        Private vRKMEField As String

        Private lGMNG_DIFFField As String

        Private mEINSField As String

        Private sEGMENTField As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDL53SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property GRUND() As String
            Get
                Return Me.gRUNDField
            End Get
            Set
                Me.gRUNDField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public Property PODMG() As String
            Get
                Return Me.pODMGField
            End Get
            Set
                Me.pODMGField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>
        Public Property LFIMG_DIFF() As String
            Get
                Return Me.lFIMG_DIFFField
            End Get
            Set
                Me.lFIMG_DIFFField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=3)>
        Public Property VRKME() As String
            Get
                Return Me.vRKMEField
            End Get
            Set
                Me.vRKMEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=4)>
        Public Property LGMNG_DIFF() As String
            Get
                Return Me.lGMNG_DIFFField
            End Get
            Set
                Me.lGMNG_DIFFField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=5)>
        Public Property MEINS() As String
            Get
                Return Me.mEINSField
            End Get
            Set
                Me.mEINSField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property SEGMENT() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDL53SEGMENT
            Get
                Return Me.sEGMENTField
            End Get
            Set
                Me.sEGMENTField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Public Enum ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDL53SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Diagnostics.DebuggerStepThroughAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Partial Public Class ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDD10

        Private mOTField As String

        Private vALDATField As String

        Private dGCAOField As String

        Private dGNHMField As String

        Private tKUIField As String

        Private dGNUField As String

        Private cOLNOField As String

        Private dGRES1Field As String

        Private dGRES2Field As String

        Private dGRES3Field As String

        Private dGREMPField As String

        Private dGRERQField As String

        Private dGCLField As String

        Private dGSCField As String

        Private sDBCField As String

        Private sLBEField As String

        Private lDBCField As String

        Private lWDGField As String

        Private eINUField As String

        Private eICNField As String

        Private eMSN1Field As String

        Private eMSN2Field As String

        Private mFAG1Field As String

        Private mFAG2Field As String

        Private hQTUField As String

        Private hQTUNField As String

        Private pINField As String

        Private pINLQField As String

        Private pGROField As String

        Private hNUField As String

        Private hPN1Field As String

        Private hPN2Field As String

        Private hPN3Field As String

        Private hPN4Field As String

        Private hPN5Field As String

        Private hPN6Field As String

        Private hPN7Field As String

        Private lAB1Field As String

        Private lAB2Field As String

        Private lAB3Field As String

        Private lAB4Field As String

        Private lAB5Field As String

        Private lAB6Field As String

        Private lAB7Field As String

        Private lAB8Field As String

        Private lAB9Field As String

        Private lAB10Field As String

        Private pBIField As String

        Private dGPTAField As String

        Private nHMEField As String

        Private dGSHEField As String

        Private pIMDGField As String

        Private sPPROField As String

        Private mAPOLField As String

        Private eXCEPField As String

        Private aGRNOField As String

        Private rEGNOField As String

        Private sDGCLField As String

        Private tDGCLField As String

        Private lWDGNField As String

        Private rVLIDField As String

        Private mOS1Field As String

        Private mOS2Field As String

        Private mOS3Field As String

        Private mOS4Field As String

        Private mOS5Field As String

        Private mOS6Field As String

        Private mOS7Field As String

        Private mOS8Field As String

        Private mOS9Field As String

        Private mOSAField As String

        Private dGTNAField As String

        Private dGWOSField As String

        Private sCASEField As String

        Private eIMDGField As String

        Private mSEPR1Field As String

        Private mSEPR2Field As String

        Private mSEPR3Field As String

        Private mSEPR4Field As String

        Private mSEPR5Field As String

        Private mSEPR6Field As String

        Private mSEPR7Field As String

        Private mSEPR8Field As String

        Private mSEPR9Field As String

        Private mSEPRAField As String

        Private mSEPRBField As String

        Private mSEPRCField As String

        Private mSEPRDField As String

        Private mSEPREField As String

        Private mSEPRFField As String

        Private mSEPRGField As String

        Private mSEPRHField As String

        Private mLOAR1Field As String

        Private mLOAR2Field As String

        Private mLOAR3Field As String

        Private mLOAR4Field As String

        Private mLOAR5Field As String

        Private mLOAR6Field As String

        Private mLOAR7Field As String

        Private mLOAR8Field As String

        Private mLOAR9Field As String

        Private mLOARAField As String

        Private rSMLG1Field As String

        Private rSMLG2Field As String

        Private rSMLG3Field As String

        Private eSMLG1Field As String

        Private eSMLG2Field As String

        Private eSMLG3Field As String

        Private pPDG1Field As String

        Private pPDG2Field As String

        Private pPDG3Field As String

        Private pPDG4Field As String

        Private pPDG5Field As String

        Private pPDG6Field As String

        Private pPDG7Field As String

        Private pPDG8Field As String

        Private pPDG9Field As String

        Private pPDGAField As String

        Private pPDGBField As String

        Private pPDGCField As String

        Private pPDGEField As String

        Private pPDGFField As String

        Private pPDGGField As String

        Private lFDNRField As String

        Private sUBPOS_NRField As String

        Private dG_NET_WEIGHTField As String

        Private dG_GROSS_WEIGHTField As String

        Private dG_WEIGHT_UField As String

        Private lANGUField As String

        Private e1EDD11Field As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDD10E1EDD11

        Private e1EDD15Field As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDD10E1EDD15

        Private e1EDD12Field() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDD10E1EDD12

        Private e1EDD13Field() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDD10E1EDD13

        Private e1EDDH3Field() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDD10E1EDDH3

        Private sEGMENTField As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDD10SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property MOT() As String
            Get
                Return Me.mOTField
            End Get
            Set
                Me.mOTField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public Property VALDAT() As String
            Get
                Return Me.vALDATField
            End Get
            Set
                Me.vALDATField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>
        Public Property DGCAO() As String
            Get
                Return Me.dGCAOField
            End Get
            Set
                Me.dGCAOField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=3)>
        Public Property DGNHM() As String
            Get
                Return Me.dGNHMField
            End Get
            Set
                Me.dGNHMField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=4)>
        Public Property TKUI() As String
            Get
                Return Me.tKUIField
            End Get
            Set
                Me.tKUIField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=5)>
        Public Property DGNU() As String
            Get
                Return Me.dGNUField
            End Get
            Set
                Me.dGNUField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=6)>
        Public Property COLNO() As String
            Get
                Return Me.cOLNOField
            End Get
            Set
                Me.cOLNOField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=7)>
        Public Property DGRES1() As String
            Get
                Return Me.dGRES1Field
            End Get
            Set
                Me.dGRES1Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=8)>
        Public Property DGRES2() As String
            Get
                Return Me.dGRES2Field
            End Get
            Set
                Me.dGRES2Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=9)>
        Public Property DGRES3() As String
            Get
                Return Me.dGRES3Field
            End Get
            Set
                Me.dGRES3Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=10)>
        Public Property DGREMP() As String
            Get
                Return Me.dGREMPField
            End Get
            Set
                Me.dGREMPField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=11)>
        Public Property DGRERQ() As String
            Get
                Return Me.dGRERQField
            End Get
            Set
                Me.dGRERQField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=12)>
        Public Property DGCL() As String
            Get
                Return Me.dGCLField
            End Get
            Set
                Me.dGCLField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=13)>
        Public Property DGSC() As String
            Get
                Return Me.dGSCField
            End Get
            Set
                Me.dGSCField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=14)>
        Public Property SDBC() As String
            Get
                Return Me.sDBCField
            End Get
            Set
                Me.sDBCField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=15)>
        Public Property SLBE() As String
            Get
                Return Me.sLBEField
            End Get
            Set
                Me.sLBEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=16)>
        Public Property LDBC() As String
            Get
                Return Me.lDBCField
            End Get
            Set
                Me.lDBCField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=17)>
        Public Property LWDG() As String
            Get
                Return Me.lWDGField
            End Get
            Set
                Me.lWDGField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=18)>
        Public Property EINU() As String
            Get
                Return Me.eINUField
            End Get
            Set
                Me.eINUField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=19)>
        Public Property EICN() As String
            Get
                Return Me.eICNField
            End Get
            Set
                Me.eICNField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=20)>
        Public Property EMSN1() As String
            Get
                Return Me.eMSN1Field
            End Get
            Set
                Me.eMSN1Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=21)>
        Public Property EMSN2() As String
            Get
                Return Me.eMSN2Field
            End Get
            Set
                Me.eMSN2Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=22)>
        Public Property MFAG1() As String
            Get
                Return Me.mFAG1Field
            End Get
            Set
                Me.mFAG1Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=23)>
        Public Property MFAG2() As String
            Get
                Return Me.mFAG2Field
            End Get
            Set
                Me.mFAG2Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=24)>
        Public Property HQTU() As String
            Get
                Return Me.hQTUField
            End Get
            Set
                Me.hQTUField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=25)>
        Public Property HQTUN() As String
            Get
                Return Me.hQTUNField
            End Get
            Set
                Me.hQTUNField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=26)>
        Public Property PIN() As String
            Get
                Return Me.pINField
            End Get
            Set
                Me.pINField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=27)>
        Public Property PINLQ() As String
            Get
                Return Me.pINLQField
            End Get
            Set
                Me.pINLQField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=28)>
        Public Property PGRO() As String
            Get
                Return Me.pGROField
            End Get
            Set
                Me.pGROField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=29)>
        Public Property HNU() As String
            Get
                Return Me.hNUField
            End Get
            Set
                Me.hNUField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=30)>
        Public Property HPN1() As String
            Get
                Return Me.hPN1Field
            End Get
            Set
                Me.hPN1Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=31)>
        Public Property HPN2() As String
            Get
                Return Me.hPN2Field
            End Get
            Set
                Me.hPN2Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=32)>
        Public Property HPN3() As String
            Get
                Return Me.hPN3Field
            End Get
            Set
                Me.hPN3Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=33)>
        Public Property HPN4() As String
            Get
                Return Me.hPN4Field
            End Get
            Set
                Me.hPN4Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=34)>
        Public Property HPN5() As String
            Get
                Return Me.hPN5Field
            End Get
            Set
                Me.hPN5Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=35)>
        Public Property HPN6() As String
            Get
                Return Me.hPN6Field
            End Get
            Set
                Me.hPN6Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=36)>
        Public Property HPN7() As String
            Get
                Return Me.hPN7Field
            End Get
            Set
                Me.hPN7Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=37)>
        Public Property LAB1() As String
            Get
                Return Me.lAB1Field
            End Get
            Set
                Me.lAB1Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=38)>
        Public Property LAB2() As String
            Get
                Return Me.lAB2Field
            End Get
            Set
                Me.lAB2Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=39)>
        Public Property LAB3() As String
            Get
                Return Me.lAB3Field
            End Get
            Set
                Me.lAB3Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=40)>
        Public Property LAB4() As String
            Get
                Return Me.lAB4Field
            End Get
            Set
                Me.lAB4Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=41)>
        Public Property LAB5() As String
            Get
                Return Me.lAB5Field
            End Get
            Set
                Me.lAB5Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=42)>
        Public Property LAB6() As String
            Get
                Return Me.lAB6Field
            End Get
            Set
                Me.lAB6Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=43)>
        Public Property LAB7() As String
            Get
                Return Me.lAB7Field
            End Get
            Set
                Me.lAB7Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=44)>
        Public Property LAB8() As String
            Get
                Return Me.lAB8Field
            End Get
            Set
                Me.lAB8Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=45)>
        Public Property LAB9() As String
            Get
                Return Me.lAB9Field
            End Get
            Set
                Me.lAB9Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=46)>
        Public Property LAB10() As String
            Get
                Return Me.lAB10Field
            End Get
            Set
                Me.lAB10Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=47)>
        Public Property PBI() As String
            Get
                Return Me.pBIField
            End Get
            Set
                Me.pBIField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=48)>
        Public Property DGPTA() As String
            Get
                Return Me.dGPTAField
            End Get
            Set
                Me.dGPTAField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=49)>
        Public Property NHME() As String
            Get
                Return Me.nHMEField
            End Get
            Set
                Me.nHMEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=50)>
        Public Property DGSHE() As String
            Get
                Return Me.dGSHEField
            End Get
            Set
                Me.dGSHEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=51)>
        Public Property PIMDG() As String
            Get
                Return Me.pIMDGField
            End Get
            Set
                Me.pIMDGField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=52)>
        Public Property SPPRO() As String
            Get
                Return Me.sPPROField
            End Get
            Set
                Me.sPPROField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=53)>
        Public Property MAPOL() As String
            Get
                Return Me.mAPOLField
            End Get
            Set
                Me.mAPOLField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=54)>
        Public Property EXCEP() As String
            Get
                Return Me.eXCEPField
            End Get
            Set
                Me.eXCEPField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=55)>
        Public Property AGRNO() As String
            Get
                Return Me.aGRNOField
            End Get
            Set
                Me.aGRNOField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=56)>
        Public Property REGNO() As String
            Get
                Return Me.rEGNOField
            End Get
            Set
                Me.rEGNOField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=57)>
        Public Property SDGCL() As String
            Get
                Return Me.sDGCLField
            End Get
            Set
                Me.sDGCLField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=58)>
        Public Property TDGCL() As String
            Get
                Return Me.tDGCLField
            End Get
            Set
                Me.tDGCLField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=59)>
        Public Property LWDGN() As String
            Get
                Return Me.lWDGNField
            End Get
            Set
                Me.lWDGNField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=60)>
        Public Property RVLID() As String
            Get
                Return Me.rVLIDField
            End Get
            Set
                Me.rVLIDField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=61)>
        Public Property MOS1() As String
            Get
                Return Me.mOS1Field
            End Get
            Set
                Me.mOS1Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=62)>
        Public Property MOS2() As String
            Get
                Return Me.mOS2Field
            End Get
            Set
                Me.mOS2Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=63)>
        Public Property MOS3() As String
            Get
                Return Me.mOS3Field
            End Get
            Set
                Me.mOS3Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=64)>
        Public Property MOS4() As String
            Get
                Return Me.mOS4Field
            End Get
            Set
                Me.mOS4Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=65)>
        Public Property MOS5() As String
            Get
                Return Me.mOS5Field
            End Get
            Set
                Me.mOS5Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=66)>
        Public Property MOS6() As String
            Get
                Return Me.mOS6Field
            End Get
            Set
                Me.mOS6Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=67)>
        Public Property MOS7() As String
            Get
                Return Me.mOS7Field
            End Get
            Set
                Me.mOS7Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=68)>
        Public Property MOS8() As String
            Get
                Return Me.mOS8Field
            End Get
            Set
                Me.mOS8Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=69)>
        Public Property MOS9() As String
            Get
                Return Me.mOS9Field
            End Get
            Set
                Me.mOS9Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=70)>
        Public Property MOSA() As String
            Get
                Return Me.mOSAField
            End Get
            Set
                Me.mOSAField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=71)>
        Public Property DGTNA() As String
            Get
                Return Me.dGTNAField
            End Get
            Set
                Me.dGTNAField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=72)>
        Public Property DGWOS() As String
            Get
                Return Me.dGWOSField
            End Get
            Set
                Me.dGWOSField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=73)>
        Public Property SCASE() As String
            Get
                Return Me.sCASEField
            End Get
            Set
                Me.sCASEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=74)>
        Public Property EIMDG() As String
            Get
                Return Me.eIMDGField
            End Get
            Set
                Me.eIMDGField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=75)>
        Public Property MSEPR1() As String
            Get
                Return Me.mSEPR1Field
            End Get
            Set
                Me.mSEPR1Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=76)>
        Public Property MSEPR2() As String
            Get
                Return Me.mSEPR2Field
            End Get
            Set
                Me.mSEPR2Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=77)>
        Public Property MSEPR3() As String
            Get
                Return Me.mSEPR3Field
            End Get
            Set
                Me.mSEPR3Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=78)>
        Public Property MSEPR4() As String
            Get
                Return Me.mSEPR4Field
            End Get
            Set
                Me.mSEPR4Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=79)>
        Public Property MSEPR5() As String
            Get
                Return Me.mSEPR5Field
            End Get
            Set
                Me.mSEPR5Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=80)>
        Public Property MSEPR6() As String
            Get
                Return Me.mSEPR6Field
            End Get
            Set
                Me.mSEPR6Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=81)>
        Public Property MSEPR7() As String
            Get
                Return Me.mSEPR7Field
            End Get
            Set
                Me.mSEPR7Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=82)>
        Public Property MSEPR8() As String
            Get
                Return Me.mSEPR8Field
            End Get
            Set
                Me.mSEPR8Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=83)>
        Public Property MSEPR9() As String
            Get
                Return Me.mSEPR9Field
            End Get
            Set
                Me.mSEPR9Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=84)>
        Public Property MSEPRA() As String
            Get
                Return Me.mSEPRAField
            End Get
            Set
                Me.mSEPRAField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=85)>
        Public Property MSEPRB() As String
            Get
                Return Me.mSEPRBField
            End Get
            Set
                Me.mSEPRBField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=86)>
        Public Property MSEPRC() As String
            Get
                Return Me.mSEPRCField
            End Get
            Set
                Me.mSEPRCField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=87)>
        Public Property MSEPRD() As String
            Get
                Return Me.mSEPRDField
            End Get
            Set
                Me.mSEPRDField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=88)>
        Public Property MSEPRE() As String
            Get
                Return Me.mSEPREField
            End Get
            Set
                Me.mSEPREField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=89)>
        Public Property MSEPRF() As String
            Get
                Return Me.mSEPRFField
            End Get
            Set
                Me.mSEPRFField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=90)>
        Public Property MSEPRG() As String
            Get
                Return Me.mSEPRGField
            End Get
            Set
                Me.mSEPRGField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=91)>
        Public Property MSEPRH() As String
            Get
                Return Me.mSEPRHField
            End Get
            Set
                Me.mSEPRHField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=92)>
        Public Property MLOAR1() As String
            Get
                Return Me.mLOAR1Field
            End Get
            Set
                Me.mLOAR1Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=93)>
        Public Property MLOAR2() As String
            Get
                Return Me.mLOAR2Field
            End Get
            Set
                Me.mLOAR2Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=94)>
        Public Property MLOAR3() As String
            Get
                Return Me.mLOAR3Field
            End Get
            Set
                Me.mLOAR3Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=95)>
        Public Property MLOAR4() As String
            Get
                Return Me.mLOAR4Field
            End Get
            Set
                Me.mLOAR4Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=96)>
        Public Property MLOAR5() As String
            Get
                Return Me.mLOAR5Field
            End Get
            Set
                Me.mLOAR5Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=97)>
        Public Property MLOAR6() As String
            Get
                Return Me.mLOAR6Field
            End Get
            Set
                Me.mLOAR6Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=98)>
        Public Property MLOAR7() As String
            Get
                Return Me.mLOAR7Field
            End Get
            Set
                Me.mLOAR7Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=99)>
        Public Property MLOAR8() As String
            Get
                Return Me.mLOAR8Field
            End Get
            Set
                Me.mLOAR8Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=100)>
        Public Property MLOAR9() As String
            Get
                Return Me.mLOAR9Field
            End Get
            Set
                Me.mLOAR9Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=101)>
        Public Property MLOARA() As String
            Get
                Return Me.mLOARAField
            End Get
            Set
                Me.mLOARAField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=102)>
        Public Property RSMLG1() As String
            Get
                Return Me.rSMLG1Field
            End Get
            Set
                Me.rSMLG1Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=103)>
        Public Property RSMLG2() As String
            Get
                Return Me.rSMLG2Field
            End Get
            Set
                Me.rSMLG2Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=104)>
        Public Property RSMLG3() As String
            Get
                Return Me.rSMLG3Field
            End Get
            Set
                Me.rSMLG3Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=105)>
        Public Property ESMLG1() As String
            Get
                Return Me.eSMLG1Field
            End Get
            Set
                Me.eSMLG1Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=106)>
        Public Property ESMLG2() As String
            Get
                Return Me.eSMLG2Field
            End Get
            Set
                Me.eSMLG2Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=107)>
        Public Property ESMLG3() As String
            Get
                Return Me.eSMLG3Field
            End Get
            Set
                Me.eSMLG3Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=108)>
        Public Property PPDG1() As String
            Get
                Return Me.pPDG1Field
            End Get
            Set
                Me.pPDG1Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=109)>
        Public Property PPDG2() As String
            Get
                Return Me.pPDG2Field
            End Get
            Set
                Me.pPDG2Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=110)>
        Public Property PPDG3() As String
            Get
                Return Me.pPDG3Field
            End Get
            Set
                Me.pPDG3Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=111)>
        Public Property PPDG4() As String
            Get
                Return Me.pPDG4Field
            End Get
            Set
                Me.pPDG4Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=112)>
        Public Property PPDG5() As String
            Get
                Return Me.pPDG5Field
            End Get
            Set
                Me.pPDG5Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=113)>
        Public Property PPDG6() As String
            Get
                Return Me.pPDG6Field
            End Get
            Set
                Me.pPDG6Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=114)>
        Public Property PPDG7() As String
            Get
                Return Me.pPDG7Field
            End Get
            Set
                Me.pPDG7Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=115)>
        Public Property PPDG8() As String
            Get
                Return Me.pPDG8Field
            End Get
            Set
                Me.pPDG8Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=116)>
        Public Property PPDG9() As String
            Get
                Return Me.pPDG9Field
            End Get
            Set
                Me.pPDG9Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=117)>
        Public Property PPDGA() As String
            Get
                Return Me.pPDGAField
            End Get
            Set
                Me.pPDGAField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=118)>
        Public Property PPDGB() As String
            Get
                Return Me.pPDGBField
            End Get
            Set
                Me.pPDGBField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=119)>
        Public Property PPDGC() As String
            Get
                Return Me.pPDGCField
            End Get
            Set
                Me.pPDGCField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=120)>
        Public Property PPDGE() As String
            Get
                Return Me.pPDGEField
            End Get
            Set
                Me.pPDGEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=121)>
        Public Property PPDGF() As String
            Get
                Return Me.pPDGFField
            End Get
            Set
                Me.pPDGFField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=122)>
        Public Property PPDGG() As String
            Get
                Return Me.pPDGGField
            End Get
            Set
                Me.pPDGGField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=123)>
        Public Property LFDNR() As String
            Get
                Return Me.lFDNRField
            End Get
            Set
                Me.lFDNRField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=124)>
        Public Property SUBPOS_NR() As String
            Get
                Return Me.sUBPOS_NRField
            End Get
            Set
                Me.sUBPOS_NRField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=125)>
        Public Property DG_NET_WEIGHT() As String
            Get
                Return Me.dG_NET_WEIGHTField
            End Get
            Set
                Me.dG_NET_WEIGHTField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=126)>
        Public Property DG_GROSS_WEIGHT() As String
            Get
                Return Me.dG_GROSS_WEIGHTField
            End Get
            Set
                Me.dG_GROSS_WEIGHTField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=127)>
        Public Property DG_WEIGHT_U() As String
            Get
                Return Me.dG_WEIGHT_UField
            End Get
            Set
                Me.dG_WEIGHT_UField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=128)>
        Public Property LANGU() As String
            Get
                Return Me.lANGUField
            End Get
            Set
                Me.lANGUField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=129)>
        Public Property E1EDD11() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDD10E1EDD11
            Get
                Return Me.e1EDD11Field
            End Get
            Set
                Me.e1EDD11Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=130)>
        Public Property E1EDD15() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDD10E1EDD15
            Get
                Return Me.e1EDD15Field
            End Get
            Set
                Me.e1EDD15Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("E1EDD12", Order:=131)>
        Public Property E1EDD12() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDD10E1EDD12()
            Get
                Return Me.e1EDD12Field
            End Get
            Set
                Me.e1EDD12Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("E1EDD13", Order:=132)>
        Public Property E1EDD13() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDD10E1EDD13()
            Get
                Return Me.e1EDD13Field
            End Get
            Set
                Me.e1EDD13Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("E1EDDH3", Order:=133)>
        Public Property E1EDDH3() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDD10E1EDDH3()
            Get
                Return Me.e1EDDH3Field
            End Get
            Set
                Me.e1EDDH3Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property SEGMENT() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDD10SEGMENT
            Get
                Return Me.sEGMENTField
            End Get
            Set
                Me.sEGMENTField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Diagnostics.DebuggerStepThroughAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Partial Public Class ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDD10E1EDD11

        Private vKTRTField As String

        Private dGNAField As String

        Private dGRESD2Field As String

        Private dGRESDField As String

        Private dGRESD3Field As String

        Private dGREDMPField As String

        Private dGREDRQField As String

        Private sEGMENTField As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDD10E1EDD11SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property VKTRT() As String
            Get
                Return Me.vKTRTField
            End Get
            Set
                Me.vKTRTField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public Property DGNA() As String
            Get
                Return Me.dGNAField
            End Get
            Set
                Me.dGNAField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>
        Public Property DGRESD2() As String
            Get
                Return Me.dGRESD2Field
            End Get
            Set
                Me.dGRESD2Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=3)>
        Public Property DGRESD() As String
            Get
                Return Me.dGRESDField
            End Get
            Set
                Me.dGRESDField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=4)>
        Public Property DGRESD3() As String
            Get
                Return Me.dGRESD3Field
            End Get
            Set
                Me.dGRESD3Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=5)>
        Public Property DGREDMP() As String
            Get
                Return Me.dGREDMPField
            End Get
            Set
                Me.dGREDMPField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=6)>
        Public Property DGREDRQ() As String
            Get
                Return Me.dGREDRQField
            End Get
            Set
                Me.dGREDRQField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property SEGMENT() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDD10E1EDD11SEGMENT
            Get
                Return Me.sEGMENTField
            End Get
            Set
                Me.sEGMENTField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Public Enum ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDD10E1EDD11SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Diagnostics.DebuggerStepThroughAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Partial Public Class ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDD10E1EDD15

        Private hPN1DField As String

        Private hPN2DField As String

        Private hPN3DField As String

        Private hPN4DField As String

        Private hPN5DField As String

        Private hPN6DField As String

        Private hPN7DField As String

        Private sEGMENTField As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDD10E1EDD15SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property HPN1D() As String
            Get
                Return Me.hPN1DField
            End Get
            Set
                Me.hPN1DField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public Property HPN2D() As String
            Get
                Return Me.hPN2DField
            End Get
            Set
                Me.hPN2DField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>
        Public Property HPN3D() As String
            Get
                Return Me.hPN3DField
            End Get
            Set
                Me.hPN3DField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=3)>
        Public Property HPN4D() As String
            Get
                Return Me.hPN4DField
            End Get
            Set
                Me.hPN4DField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=4)>
        Public Property HPN5D() As String
            Get
                Return Me.hPN5DField
            End Get
            Set
                Me.hPN5DField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=5)>
        Public Property HPN6D() As String
            Get
                Return Me.hPN6DField
            End Get
            Set
                Me.hPN6DField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=6)>
        Public Property HPN7D() As String
            Get
                Return Me.hPN7DField
            End Get
            Set
                Me.hPN7DField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property SEGMENT() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDD10E1EDD15SEGMENT
            Get
                Return Me.sEGMENTField
            End Get
            Set
                Me.sEGMENTField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Public Enum ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDD10E1EDD15SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Diagnostics.DebuggerStepThroughAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Partial Public Class ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDD10E1EDD12

        Private sTOSUField As String

        Private cOTMPField As String

        Private tPCUNField As String

        Private eMTMPField As String

        Private tPEUNField As String

        Private fLTMPField As String

        Private tPFUNField As String

        Private tPSNLField As String

        Private tPSLUField As String

        Private tPSNHField As String

        Private tPSHUField As String

        Private cOWEField As String

        Private vBFCField As String

        Private sDCLField As String

        Private sOOWAField As String

        Private uSOOWField As String

        Private dENFEEField As String

        Private uDENFEField As String

        Private dENTWEField As String

        Private uDENTWEField As String

        Private dENFIFField As String

        Private uDENFIField As String

        Private bUDENField As String

        Private uBUDEField As String

        Private bOPOIField As String

        Private uBOPOField As String

        Private vISCOField As String

        Private uVISCField As String

        Private sTPRESField As String

        Private uSTPREField As String

        Private hYGROField As String

        Private mEPOIField As String

        Private uMEPOField As String

        Private cOOEXField As String

        Private uCOOEField As String

        Private mTMPFField As String

        Private uMTMPField As String

        Private pAIField As String

        Private pAIUField As String

        Private pAOField As String

        Private pAOUField As String

        Private rQAField As String

        Private rQUField As String

        Private mINQField As String

        Private mINUField As String

        Private mAXQField As String

        Private mAXUField As String

        Private rELQField As String

        Private rELUField As String

        Private mULRQField As String

        Private rCHEMField As String

        Private sTOPAField As String

        Private pASIField As String

        Private uPASIField As String

        Private pAGWField As String

        Private uPAGWField As String

        Private mIOWAField As String

        Private uMIOWField As String

        Private rQA2Field As String

        Private rQU2Field As String

        Private eXPL_NETField As String

        Private eXPL_NET_UField As String

        Private eXPL_REL_PERCENTField As String

        Private aCTVTY_MAXField As String

        Private aCTVTY_MAX_UField As String

        Private aCTVTY_MAX_RELField As String

        Private aCTVTY_MAX_REL_UField As String

        Private tRANSP_INDEXField As String

        Private cRIT_SAF_INDEXField As String

        Private pACKAGE_CATField As String

        Private aCTVTY_SINGLE_A2Field As String

        Private lTSKField As String

        Private eMVField As String

        Private fSAKField As String

        Private sFKField As String

        Private mUNAKODEField As String

        Private eXNUMBERField As String

        Private pINEQField As String

        Private eXC_QUANT_IPField As String

        Private eXC_QUANT_IP_UField As String

        Private eXC_QUANT_OPField As String

        Private eXC_QUANT_OP_UField As String

        Private dANLAB01Field As String

        Private dANLAB02Field As String

        Private dANLAB03Field As String

        Private dANLAB04Field As String

        Private dANLAB05Field As String

        Private dANLAB06Field As String

        Private dANLAB07Field As String

        Private e1EDD16Field As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDD10E1EDD12E1EDD16

        Private sEGMENTField As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDD10E1EDD12SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property STOSU() As String
            Get
                Return Me.sTOSUField
            End Get
            Set
                Me.sTOSUField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public Property COTMP() As String
            Get
                Return Me.cOTMPField
            End Get
            Set
                Me.cOTMPField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>
        Public Property TPCUN() As String
            Get
                Return Me.tPCUNField
            End Get
            Set
                Me.tPCUNField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=3)>
        Public Property EMTMP() As String
            Get
                Return Me.eMTMPField
            End Get
            Set
                Me.eMTMPField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=4)>
        Public Property TPEUN() As String
            Get
                Return Me.tPEUNField
            End Get
            Set
                Me.tPEUNField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=5)>
        Public Property FLTMP() As String
            Get
                Return Me.fLTMPField
            End Get
            Set
                Me.fLTMPField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=6)>
        Public Property TPFUN() As String
            Get
                Return Me.tPFUNField
            End Get
            Set
                Me.tPFUNField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=7)>
        Public Property TPSNL() As String
            Get
                Return Me.tPSNLField
            End Get
            Set
                Me.tPSNLField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=8)>
        Public Property TPSLU() As String
            Get
                Return Me.tPSLUField
            End Get
            Set
                Me.tPSLUField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=9)>
        Public Property TPSNH() As String
            Get
                Return Me.tPSNHField
            End Get
            Set
                Me.tPSNHField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=10)>
        Public Property TPSHU() As String
            Get
                Return Me.tPSHUField
            End Get
            Set
                Me.tPSHUField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=11)>
        Public Property COWE() As String
            Get
                Return Me.cOWEField
            End Get
            Set
                Me.cOWEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=12)>
        Public Property VBFC() As String
            Get
                Return Me.vBFCField
            End Get
            Set
                Me.vBFCField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=13)>
        Public Property SDCL() As String
            Get
                Return Me.sDCLField
            End Get
            Set
                Me.sDCLField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=14)>
        Public Property SOOWA() As String
            Get
                Return Me.sOOWAField
            End Get
            Set
                Me.sOOWAField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=15)>
        Public Property USOOW() As String
            Get
                Return Me.uSOOWField
            End Get
            Set
                Me.uSOOWField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=16)>
        Public Property DENFEE() As String
            Get
                Return Me.dENFEEField
            End Get
            Set
                Me.dENFEEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=17)>
        Public Property UDENFE() As String
            Get
                Return Me.uDENFEField
            End Get
            Set
                Me.uDENFEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=18)>
        Public Property DENTWE() As String
            Get
                Return Me.dENTWEField
            End Get
            Set
                Me.dENTWEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=19)>
        Public Property UDENTWE() As String
            Get
                Return Me.uDENTWEField
            End Get
            Set
                Me.uDENTWEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=20)>
        Public Property DENFIF() As String
            Get
                Return Me.dENFIFField
            End Get
            Set
                Me.dENFIFField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=21)>
        Public Property UDENFI() As String
            Get
                Return Me.uDENFIField
            End Get
            Set
                Me.uDENFIField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=22)>
        Public Property BUDEN() As String
            Get
                Return Me.bUDENField
            End Get
            Set
                Me.bUDENField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=23)>
        Public Property UBUDE() As String
            Get
                Return Me.uBUDEField
            End Get
            Set
                Me.uBUDEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=24)>
        Public Property BOPOI() As String
            Get
                Return Me.bOPOIField
            End Get
            Set
                Me.bOPOIField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=25)>
        Public Property UBOPO() As String
            Get
                Return Me.uBOPOField
            End Get
            Set
                Me.uBOPOField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=26)>
        Public Property VISCO() As String
            Get
                Return Me.vISCOField
            End Get
            Set
                Me.vISCOField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=27)>
        Public Property UVISC() As String
            Get
                Return Me.uVISCField
            End Get
            Set
                Me.uVISCField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=28)>
        Public Property STPRES() As String
            Get
                Return Me.sTPRESField
            End Get
            Set
                Me.sTPRESField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=29)>
        Public Property USTPRE() As String
            Get
                Return Me.uSTPREField
            End Get
            Set
                Me.uSTPREField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=30)>
        Public Property HYGRO() As String
            Get
                Return Me.hYGROField
            End Get
            Set
                Me.hYGROField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=31)>
        Public Property MEPOI() As String
            Get
                Return Me.mEPOIField
            End Get
            Set
                Me.mEPOIField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=32)>
        Public Property UMEPO() As String
            Get
                Return Me.uMEPOField
            End Get
            Set
                Me.uMEPOField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=33)>
        Public Property COOEX() As String
            Get
                Return Me.cOOEXField
            End Get
            Set
                Me.cOOEXField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=34)>
        Public Property UCOOE() As String
            Get
                Return Me.uCOOEField
            End Get
            Set
                Me.uCOOEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=35)>
        Public Property MTMPF() As String
            Get
                Return Me.mTMPFField
            End Get
            Set
                Me.mTMPFField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=36)>
        Public Property UMTMP() As String
            Get
                Return Me.uMTMPField
            End Get
            Set
                Me.uMTMPField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=37)>
        Public Property PAI() As String
            Get
                Return Me.pAIField
            End Get
            Set
                Me.pAIField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=38)>
        Public Property PAIU() As String
            Get
                Return Me.pAIUField
            End Get
            Set
                Me.pAIUField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=39)>
        Public Property PAO() As String
            Get
                Return Me.pAOField
            End Get
            Set
                Me.pAOField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=40)>
        Public Property PAOU() As String
            Get
                Return Me.pAOUField
            End Get
            Set
                Me.pAOUField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=41)>
        Public Property RQA() As String
            Get
                Return Me.rQAField
            End Get
            Set
                Me.rQAField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=42)>
        Public Property RQU() As String
            Get
                Return Me.rQUField
            End Get
            Set
                Me.rQUField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=43)>
        Public Property MINQ() As String
            Get
                Return Me.mINQField
            End Get
            Set
                Me.mINQField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=44)>
        Public Property MINU() As String
            Get
                Return Me.mINUField
            End Get
            Set
                Me.mINUField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=45)>
        Public Property MAXQ() As String
            Get
                Return Me.mAXQField
            End Get
            Set
                Me.mAXQField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=46)>
        Public Property MAXU() As String
            Get
                Return Me.mAXUField
            End Get
            Set
                Me.mAXUField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=47)>
        Public Property RELQ() As String
            Get
                Return Me.rELQField
            End Get
            Set
                Me.rELQField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=48)>
        Public Property RELU() As String
            Get
                Return Me.rELUField
            End Get
            Set
                Me.rELUField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=49)>
        Public Property MULRQ() As String
            Get
                Return Me.mULRQField
            End Get
            Set
                Me.mULRQField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=50)>
        Public Property RCHEM() As String
            Get
                Return Me.rCHEMField
            End Get
            Set
                Me.rCHEMField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=51)>
        Public Property STOPA() As String
            Get
                Return Me.sTOPAField
            End Get
            Set
                Me.sTOPAField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=52)>
        Public Property PASI() As String
            Get
                Return Me.pASIField
            End Get
            Set
                Me.pASIField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=53)>
        Public Property UPASI() As String
            Get
                Return Me.uPASIField
            End Get
            Set
                Me.uPASIField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=54)>
        Public Property PAGW() As String
            Get
                Return Me.pAGWField
            End Get
            Set
                Me.pAGWField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=55)>
        Public Property UPAGW() As String
            Get
                Return Me.uPAGWField
            End Get
            Set
                Me.uPAGWField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=56)>
        Public Property MIOWA() As String
            Get
                Return Me.mIOWAField
            End Get
            Set
                Me.mIOWAField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=57)>
        Public Property UMIOW() As String
            Get
                Return Me.uMIOWField
            End Get
            Set
                Me.uMIOWField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=58)>
        Public Property RQA2() As String
            Get
                Return Me.rQA2Field
            End Get
            Set
                Me.rQA2Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=59)>
        Public Property RQU2() As String
            Get
                Return Me.rQU2Field
            End Get
            Set
                Me.rQU2Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=60)>
        Public Property EXPL_NET() As String
            Get
                Return Me.eXPL_NETField
            End Get
            Set
                Me.eXPL_NETField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=61)>
        Public Property EXPL_NET_U() As String
            Get
                Return Me.eXPL_NET_UField
            End Get
            Set
                Me.eXPL_NET_UField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=62)>
        Public Property EXPL_REL_PERCENT() As String
            Get
                Return Me.eXPL_REL_PERCENTField
            End Get
            Set
                Me.eXPL_REL_PERCENTField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=63)>
        Public Property ACTVTY_MAX() As String
            Get
                Return Me.aCTVTY_MAXField
            End Get
            Set
                Me.aCTVTY_MAXField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=64)>
        Public Property ACTVTY_MAX_U() As String
            Get
                Return Me.aCTVTY_MAX_UField
            End Get
            Set
                Me.aCTVTY_MAX_UField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=65)>
        Public Property ACTVTY_MAX_REL() As String
            Get
                Return Me.aCTVTY_MAX_RELField
            End Get
            Set
                Me.aCTVTY_MAX_RELField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=66)>
        Public Property ACTVTY_MAX_REL_U() As String
            Get
                Return Me.aCTVTY_MAX_REL_UField
            End Get
            Set
                Me.aCTVTY_MAX_REL_UField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=67)>
        Public Property TRANSP_INDEX() As String
            Get
                Return Me.tRANSP_INDEXField
            End Get
            Set
                Me.tRANSP_INDEXField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=68)>
        Public Property CRIT_SAF_INDEX() As String
            Get
                Return Me.cRIT_SAF_INDEXField
            End Get
            Set
                Me.cRIT_SAF_INDEXField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=69)>
        Public Property PACKAGE_CAT() As String
            Get
                Return Me.pACKAGE_CATField
            End Get
            Set
                Me.pACKAGE_CATField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=70)>
        Public Property ACTVTY_SINGLE_A2() As String
            Get
                Return Me.aCTVTY_SINGLE_A2Field
            End Get
            Set
                Me.aCTVTY_SINGLE_A2Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=71)>
        Public Property LTSK() As String
            Get
                Return Me.lTSKField
            End Get
            Set
                Me.lTSKField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=72)>
        Public Property EMV() As String
            Get
                Return Me.eMVField
            End Get
            Set
                Me.eMVField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=73)>
        Public Property FSAK() As String
            Get
                Return Me.fSAKField
            End Get
            Set
                Me.fSAKField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=74)>
        Public Property SFK() As String
            Get
                Return Me.sFKField
            End Get
            Set
                Me.sFKField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=75)>
        Public Property MUNAKODE() As String
            Get
                Return Me.mUNAKODEField
            End Get
            Set
                Me.mUNAKODEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=76)>
        Public Property EXNUMBER() As String
            Get
                Return Me.eXNUMBERField
            End Get
            Set
                Me.eXNUMBERField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=77)>
        Public Property PINEQ() As String
            Get
                Return Me.pINEQField
            End Get
            Set
                Me.pINEQField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=78)>
        Public Property EXC_QUANT_IP() As String
            Get
                Return Me.eXC_QUANT_IPField
            End Get
            Set
                Me.eXC_QUANT_IPField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=79)>
        Public Property EXC_QUANT_IP_U() As String
            Get
                Return Me.eXC_QUANT_IP_UField
            End Get
            Set
                Me.eXC_QUANT_IP_UField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=80)>
        Public Property EXC_QUANT_OP() As String
            Get
                Return Me.eXC_QUANT_OPField
            End Get
            Set
                Me.eXC_QUANT_OPField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=81)>
        Public Property EXC_QUANT_OP_U() As String
            Get
                Return Me.eXC_QUANT_OP_UField
            End Get
            Set
                Me.eXC_QUANT_OP_UField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=82)>
        Public Property DANLAB01() As String
            Get
                Return Me.dANLAB01Field
            End Get
            Set
                Me.dANLAB01Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=83)>
        Public Property DANLAB02() As String
            Get
                Return Me.dANLAB02Field
            End Get
            Set
                Me.dANLAB02Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=84)>
        Public Property DANLAB03() As String
            Get
                Return Me.dANLAB03Field
            End Get
            Set
                Me.dANLAB03Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=85)>
        Public Property DANLAB04() As String
            Get
                Return Me.dANLAB04Field
            End Get
            Set
                Me.dANLAB04Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=86)>
        Public Property DANLAB05() As String
            Get
                Return Me.dANLAB05Field
            End Get
            Set
                Me.dANLAB05Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=87)>
        Public Property DANLAB06() As String
            Get
                Return Me.dANLAB06Field
            End Get
            Set
                Me.dANLAB06Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=88)>
        Public Property DANLAB07() As String
            Get
                Return Me.dANLAB07Field
            End Get
            Set
                Me.dANLAB07Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=89)>
        Public Property E1EDD16() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDD10E1EDD12E1EDD16
            Get
                Return Me.e1EDD16Field
            End Get
            Set
                Me.e1EDD16Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property SEGMENT() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDD10E1EDD12SEGMENT
            Get
                Return Me.sEGMENTField
            End Get
            Set
                Me.sEGMENTField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Diagnostics.DebuggerStepThroughAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Partial Public Class ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDD10E1EDD12E1EDD16

        Private aGGRTField As String

        Private cOWEDField As String

        Private fORM_PHYS_CHEM_DField As String

        Private tUNNEL_RESTRICTION_CODEField As String

        Private sEGMENTField As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDD10E1EDD12E1EDD16SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property AGGRT() As String
            Get
                Return Me.aGGRTField
            End Get
            Set
                Me.aGGRTField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public Property COWED() As String
            Get
                Return Me.cOWEDField
            End Get
            Set
                Me.cOWEDField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>
        Public Property FORM_PHYS_CHEM_D() As String
            Get
                Return Me.fORM_PHYS_CHEM_DField
            End Get
            Set
                Me.fORM_PHYS_CHEM_DField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=3)>
        Public Property TUNNEL_RESTRICTION_CODE() As String
            Get
                Return Me.tUNNEL_RESTRICTION_CODEField
            End Get
            Set
                Me.tUNNEL_RESTRICTION_CODEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property SEGMENT() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDD10E1EDD12E1EDD16SEGMENT
            Get
                Return Me.sEGMENTField
            End Get
            Set
                Me.sEGMENTField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Public Enum ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDD10E1EDD12E1EDD16SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Public Enum ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDD10E1EDD12SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Diagnostics.DebuggerStepThroughAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Partial Public Class ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDD10E1EDD13

        Private eDIQField As String

        Private dAINField As String

        Private dAIDField As String

        Private sEGMENTField As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDD10E1EDD13SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property EDIQ() As String
            Get
                Return Me.eDIQField
            End Get
            Set
                Me.eDIQField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public Property DAIN() As String
            Get
                Return Me.dAINField
            End Get
            Set
                Me.dAINField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>
        Public Property DAID() As String
            Get
                Return Me.dAIDField
            End Get
            Set
                Me.dAIDField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property SEGMENT() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDD10E1EDD13SEGMENT
            Get
                Return Me.sEGMENTField
            End Get
            Set
                Me.sEGMENTField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Public Enum ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDD10E1EDD13SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Diagnostics.DebuggerStepThroughAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Partial Public Class ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDD10E1EDDH3

        Private fUNCTIONField As String

        Private tDOBJECTField As String

        Private tDOBNAMEField As String

        Private tDIDField As String

        Private tDTEXTTYPEField As String

        Private lANGUA_ISOField As String

        Private pHRSELField As String

        Private iDENTIFIERField As String

        Private lANGUA_PHRField As String

        Private e1EDDP3Field() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDD10E1EDDH3E1EDDP3

        Private sEGMENTField As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDD10E1EDDH3SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property [FUNCTION]() As String
            Get
                Return Me.fUNCTIONField
            End Get
            Set
                Me.fUNCTIONField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public Property TDOBJECT() As String
            Get
                Return Me.tDOBJECTField
            End Get
            Set
                Me.tDOBJECTField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>
        Public Property TDOBNAME() As String
            Get
                Return Me.tDOBNAMEField
            End Get
            Set
                Me.tDOBNAMEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=3)>
        Public Property TDID() As String
            Get
                Return Me.tDIDField
            End Get
            Set
                Me.tDIDField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=4)>
        Public Property TDTEXTTYPE() As String
            Get
                Return Me.tDTEXTTYPEField
            End Get
            Set
                Me.tDTEXTTYPEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=5)>
        Public Property LANGUA_ISO() As String
            Get
                Return Me.lANGUA_ISOField
            End Get
            Set
                Me.lANGUA_ISOField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=6)>
        Public Property PHRSEL() As String
            Get
                Return Me.pHRSELField
            End Get
            Set
                Me.pHRSELField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=7)>
        Public Property IDENTIFIER() As String
            Get
                Return Me.iDENTIFIERField
            End Get
            Set
                Me.iDENTIFIERField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=8)>
        Public Property LANGUA_PHR() As String
            Get
                Return Me.lANGUA_PHRField
            End Get
            Set
                Me.lANGUA_PHRField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("E1EDDP3", Order:=9)>
        Public Property E1EDDP3() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDD10E1EDDH3E1EDDP3()
            Get
                Return Me.e1EDDP3Field
            End Get
            Set
                Me.e1EDDP3Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property SEGMENT() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDD10E1EDDH3SEGMENT
            Get
                Return Me.sEGMENTField
            End Get
            Set
                Me.sEGMENTField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Diagnostics.DebuggerStepThroughAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Partial Public Class ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDD10E1EDDH3E1EDDP3

        Private tDFORMATField As String

        Private tDLINEField As String

        Private sEGMENTField As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDD10E1EDDH3E1EDDP3SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property TDFORMAT() As String
            Get
                Return Me.tDFORMATField
            End Get
            Set
                Me.tDFORMATField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public Property TDLINE() As String
            Get
                Return Me.tDLINEField
            End Get
            Set
                Me.tDLINEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property SEGMENT() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDD10E1EDDH3E1EDDP3SEGMENT
            Get
                Return Me.sEGMENTField
            End Get
            Set
                Me.sEGMENTField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Public Enum ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDD10E1EDDH3E1EDDP3SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Public Enum ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDD10E1EDDH3SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Public Enum ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDD10SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Diagnostics.DebuggerStepThroughAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Partial Public Class ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDD14

        Private dGARANDField As String

        Private dGPULIMField As String

        Private dGPASField As String

        Private dGREPQUField As String

        Private dGEXCQUField As String

        Private dGSUP_TRANSIND01Field As String

        Private dGSUP_TRANSIND02Field As String

        Private dGSUP_TRANSIND03Field As String

        Private dGSUP_TRANSIND04Field As String

        Private dGSUP_TRANSIND05Field As String

        Private dGSUP_TRANSIND06Field As String

        Private dGSUP_TRANSIND07Field As String

        Private dGSUP_TRANSIND08Field As String

        Private sEGMENTField As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDD14SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property DGARAND() As String
            Get
                Return Me.dGARANDField
            End Get
            Set
                Me.dGARANDField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public Property DGPULIM() As String
            Get
                Return Me.dGPULIMField
            End Get
            Set
                Me.dGPULIMField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>
        Public Property DGPAS() As String
            Get
                Return Me.dGPASField
            End Get
            Set
                Me.dGPASField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=3)>
        Public Property DGREPQU() As String
            Get
                Return Me.dGREPQUField
            End Get
            Set
                Me.dGREPQUField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=4)>
        Public Property DGEXCQU() As String
            Get
                Return Me.dGEXCQUField
            End Get
            Set
                Me.dGEXCQUField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=5)>
        Public Property DGSUP_TRANSIND01() As String
            Get
                Return Me.dGSUP_TRANSIND01Field
            End Get
            Set
                Me.dGSUP_TRANSIND01Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=6)>
        Public Property DGSUP_TRANSIND02() As String
            Get
                Return Me.dGSUP_TRANSIND02Field
            End Get
            Set
                Me.dGSUP_TRANSIND02Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=7)>
        Public Property DGSUP_TRANSIND03() As String
            Get
                Return Me.dGSUP_TRANSIND03Field
            End Get
            Set
                Me.dGSUP_TRANSIND03Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=8)>
        Public Property DGSUP_TRANSIND04() As String
            Get
                Return Me.dGSUP_TRANSIND04Field
            End Get
            Set
                Me.dGSUP_TRANSIND04Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=9)>
        Public Property DGSUP_TRANSIND05() As String
            Get
                Return Me.dGSUP_TRANSIND05Field
            End Get
            Set
                Me.dGSUP_TRANSIND05Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=10)>
        Public Property DGSUP_TRANSIND06() As String
            Get
                Return Me.dGSUP_TRANSIND06Field
            End Get
            Set
                Me.dGSUP_TRANSIND06Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=11)>
        Public Property DGSUP_TRANSIND07() As String
            Get
                Return Me.dGSUP_TRANSIND07Field
            End Get
            Set
                Me.dGSUP_TRANSIND07Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=12)>
        Public Property DGSUP_TRANSIND08() As String
            Get
                Return Me.dGSUP_TRANSIND08Field
            End Get
            Set
                Me.dGSUP_TRANSIND08Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property SEGMENT() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDD14SEGMENT
            Get
                Return Me.sEGMENTField
            End Get
            Set
                Me.sEGMENTField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Public Enum ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDD14SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Diagnostics.DebuggerStepThroughAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Partial Public Class ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDL19

        Private qUALFField As String

        Private pARAMField As String

        Private sEGMENTField As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDL19SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property QUALF() As String
            Get
                Return Me.qUALFField
            End Get
            Set
                Me.qUALFField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public Property PARAM() As String
            Get
                Return Me.pARAMField
            End Get
            Set
                Me.pARAMField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property SEGMENT() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDL19SEGMENT
            Get
                Return Me.sEGMENTField
            End Get
            Set
                Me.sEGMENTField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Public Enum ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDL19SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Diagnostics.DebuggerStepThroughAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Partial Public Class ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDL11

        Private sERNRField As String

        Private uIIField As String

        Private sEGMENTField As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDL11SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property SERNR() As String
            Get
                Return Me.sERNRField
            End Get
            Set
                Me.sERNRField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public Property UII() As String
            Get
                Return Me.uIIField
            End Get
            Set
                Me.uIIField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property SEGMENT() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDL11SEGMENT
            Get
                Return Me.sEGMENTField
            End Get
            Set
                Me.sEGMENTField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Public Enum ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDL11SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Diagnostics.DebuggerStepThroughAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Partial Public Class ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDL15

        Private aTINNField As String

        Private aTNAMField As String

        Private aTBEZField As String

        Private aTWRTField As String

        Private aTWTBField As String

        Private eWAHRField As String

        Private sEGMENTField As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDL15SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property ATINN() As String
            Get
                Return Me.aTINNField
            End Get
            Set
                Me.aTINNField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public Property ATNAM() As String
            Get
                Return Me.aTNAMField
            End Get
            Set
                Me.aTNAMField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>
        Public Property ATBEZ() As String
            Get
                Return Me.aTBEZField
            End Get
            Set
                Me.aTBEZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=3)>
        Public Property ATWRT() As String
            Get
                Return Me.aTWRTField
            End Get
            Set
                Me.aTWRTField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=4)>
        Public Property ATWTB() As String
            Get
                Return Me.aTWTBField
            End Get
            Set
                Me.aTWTBField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=5)>
        Public Property EWAHR() As String
            Get
                Return Me.eWAHRField
            End Get
            Set
                Me.eWAHRField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property SEGMENT() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDL15SEGMENT
            Get
                Return Me.sEGMENTField
            End Get
            Set
                Me.sEGMENTField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Public Enum ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDL15SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Diagnostics.DebuggerStepThroughAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Partial Public Class ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDL35

        Private sTAWNField As String

        Private eXPRFField As String

        Private eXARTField As String

        Private hERKLField As String

        Private hERKRField As String

        Private gRWRTField As String

        Private pREFEField As String

        Private e1EDL36Field As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDL35E1EDL36

        Private sEGMENTField As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDL35SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property STAWN() As String
            Get
                Return Me.sTAWNField
            End Get
            Set
                Me.sTAWNField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public Property EXPRF() As String
            Get
                Return Me.eXPRFField
            End Get
            Set
                Me.eXPRFField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>
        Public Property EXART() As String
            Get
                Return Me.eXARTField
            End Get
            Set
                Me.eXARTField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=3)>
        Public Property HERKL() As String
            Get
                Return Me.hERKLField
            End Get
            Set
                Me.hERKLField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=4)>
        Public Property HERKR() As String
            Get
                Return Me.hERKRField
            End Get
            Set
                Me.hERKRField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=5)>
        Public Property GRWRT() As String
            Get
                Return Me.gRWRTField
            End Get
            Set
                Me.gRWRTField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=6)>
        Public Property PREFE() As String
            Get
                Return Me.pREFEField
            End Get
            Set
                Me.pREFEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=7)>
        Public Property E1EDL36() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDL35E1EDL36
            Get
                Return Me.e1EDL36Field
            End Get
            Set
                Me.e1EDL36Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property SEGMENT() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDL35SEGMENT
            Get
                Return Me.sEGMENTField
            End Get
            Set
                Me.sEGMENTField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Diagnostics.DebuggerStepThroughAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Partial Public Class ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDL35E1EDL36

        Private sTXT1Field As String

        Private sTXT2Field As String

        Private sTXT3Field As String

        Private sTXT4Field As String

        Private sTXT5Field As String

        Private sTXT6Field As String

        Private sTXT7Field As String

        Private eXPRF_BEZField As String

        Private eXART_BEZField As String

        Private hERKL_BEZField As String

        Private hERKR_BEZField As String

        Private sEGMENTField As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDL35E1EDL36SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property STXT1() As String
            Get
                Return Me.sTXT1Field
            End Get
            Set
                Me.sTXT1Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public Property STXT2() As String
            Get
                Return Me.sTXT2Field
            End Get
            Set
                Me.sTXT2Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>
        Public Property STXT3() As String
            Get
                Return Me.sTXT3Field
            End Get
            Set
                Me.sTXT3Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=3)>
        Public Property STXT4() As String
            Get
                Return Me.sTXT4Field
            End Get
            Set
                Me.sTXT4Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=4)>
        Public Property STXT5() As String
            Get
                Return Me.sTXT5Field
            End Get
            Set
                Me.sTXT5Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=5)>
        Public Property STXT6() As String
            Get
                Return Me.sTXT6Field
            End Get
            Set
                Me.sTXT6Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=6)>
        Public Property STXT7() As String
            Get
                Return Me.sTXT7Field
            End Get
            Set
                Me.sTXT7Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=7)>
        Public Property EXPRF_BEZ() As String
            Get
                Return Me.eXPRF_BEZField
            End Get
            Set
                Me.eXPRF_BEZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=8)>
        Public Property EXART_BEZ() As String
            Get
                Return Me.eXART_BEZField
            End Get
            Set
                Me.eXART_BEZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=9)>
        Public Property HERKL_BEZ() As String
            Get
                Return Me.hERKL_BEZField
            End Get
            Set
                Me.hERKL_BEZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=10)>
        Public Property HERKR_BEZ() As String
            Get
                Return Me.hERKR_BEZField
            End Get
            Set
                Me.hERKR_BEZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property SEGMENT() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDL35E1EDL36SEGMENT
            Get
                Return Me.sEGMENTField
            End Get
            Set
                Me.sEGMENTField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Public Enum ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDL35E1EDL36SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Public Enum ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDL35SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Diagnostics.DebuggerStepThroughAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Partial Public Class ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDL43

        Private qUALFField As String

        Private bELNRField As String

        Private pOSNRField As String

        Private dATUMField As String

        Private sEGMENTField As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDL43SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property QUALF() As String
            Get
                Return Me.qUALFField
            End Get
            Set
                Me.qUALFField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public Property BELNR() As String
            Get
                Return Me.bELNRField
            End Get
            Set
                Me.bELNRField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>
        Public Property POSNR() As String
            Get
                Return Me.pOSNRField
            End Get
            Set
                Me.pOSNRField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=3)>
        Public Property DATUM() As String
            Get
                Return Me.dATUMField
            End Get
            Set
                Me.dATUMField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property SEGMENT() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDL43SEGMENT
            Get
                Return Me.sEGMENTField
            End Get
            Set
                Me.sEGMENTField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Public Enum ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDL43SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Diagnostics.DebuggerStepThroughAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Partial Public Class ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDL41

        Private qUALIField As String

        Private bSTNRField As String

        Private bSTDTField As String

        Private bSARKField As String

        Private iHREZField As String

        Private pOSEXField As String

        Private e1EDL42Field As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDL41E1EDL42

        Private sEGMENTField As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDL41SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property QUALI() As String
            Get
                Return Me.qUALIField
            End Get
            Set
                Me.qUALIField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public Property BSTNR() As String
            Get
                Return Me.bSTNRField
            End Get
            Set
                Me.bSTNRField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>
        Public Property BSTDT() As String
            Get
                Return Me.bSTDTField
            End Get
            Set
                Me.bSTDTField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=3)>
        Public Property BSARK() As String
            Get
                Return Me.bSARKField
            End Get
            Set
                Me.bSARKField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=4)>
        Public Property IHREZ() As String
            Get
                Return Me.iHREZField
            End Get
            Set
                Me.iHREZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=5)>
        Public Property POSEX() As String
            Get
                Return Me.pOSEXField
            End Get
            Set
                Me.pOSEXField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=6)>
        Public Property E1EDL42() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDL41E1EDL42
            Get
                Return Me.e1EDL42Field
            End Get
            Set
                Me.e1EDL42Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property SEGMENT() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDL41SEGMENT
            Get
                Return Me.sEGMENTField
            End Get
            Set
                Me.sEGMENTField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Diagnostics.DebuggerStepThroughAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Partial Public Class ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDL41E1EDL42

        Private bSARK_BEZField As String

        Private sEGMENTField As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDL41E1EDL42SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property BSARK_BEZ() As String
            Get
                Return Me.bSARK_BEZField
            End Get
            Set
                Me.bSARK_BEZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property SEGMENT() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDL41E1EDL42SEGMENT
            Get
                Return Me.sEGMENTField
            End Get
            Set
                Me.sEGMENTField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Public Enum ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDL41E1EDL42SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Public Enum ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDL41SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Diagnostics.DebuggerStepThroughAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Partial Public Class ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1TXTH9

        Private fUNCTIONField As String

        Private tDOBJECTField As String

        Private tDOBNAMEField As String

        Private tDIDField As String

        Private tDSPRASField As String

        Private tDTEXTTYPEField As String

        Private lANGUA_ISOField As String

        Private e1TXTP9Field() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1TXTH9E1TXTP9

        Private sEGMENTField As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1TXTH9SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property [FUNCTION]() As String
            Get
                Return Me.fUNCTIONField
            End Get
            Set
                Me.fUNCTIONField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public Property TDOBJECT() As String
            Get
                Return Me.tDOBJECTField
            End Get
            Set
                Me.tDOBJECTField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>
        Public Property TDOBNAME() As String
            Get
                Return Me.tDOBNAMEField
            End Get
            Set
                Me.tDOBNAMEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=3)>
        Public Property TDID() As String
            Get
                Return Me.tDIDField
            End Get
            Set
                Me.tDIDField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=4)>
        Public Property TDSPRAS() As String
            Get
                Return Me.tDSPRASField
            End Get
            Set
                Me.tDSPRASField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=5)>
        Public Property TDTEXTTYPE() As String
            Get
                Return Me.tDTEXTTYPEField
            End Get
            Set
                Me.tDTEXTTYPEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=6)>
        Public Property LANGUA_ISO() As String
            Get
                Return Me.lANGUA_ISOField
            End Get
            Set
                Me.lANGUA_ISOField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("E1TXTP9", Order:=7)>
        Public Property E1TXTP9() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1TXTH9E1TXTP9()
            Get
                Return Me.e1TXTP9Field
            End Get
            Set
                Me.e1TXTP9Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property SEGMENT() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1TXTH9SEGMENT
            Get
                Return Me.sEGMENTField
            End Get
            Set
                Me.sEGMENTField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Diagnostics.DebuggerStepThroughAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Partial Public Class ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1TXTH9E1TXTP9

        Private tDFORMATField As String

        Private tDLINEField As String

        Private sEGMENTField As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1TXTH9E1TXTP9SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property TDFORMAT() As String
            Get
                Return Me.tDFORMATField
            End Get
            Set
                Me.tDFORMATField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public Property TDLINE() As String
            Get
                Return Me.tDLINEField
            End Get
            Set
                Me.tDLINEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property SEGMENT() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1TXTH9E1TXTP9SEGMENT
            Get
                Return Me.sEGMENTField
            End Get
            Set
                Me.sEGMENTField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Public Enum ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1TXTH9E1TXTP9SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Public Enum ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1TXTH9SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Diagnostics.DebuggerStepThroughAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Partial Public Class ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDL12

        Private aTINNField As String

        Private aTNAMField As String

        Private aTBEZField As String

        Private aTWRTField As String

        Private aTWTBField As String

        Private eWAHRField As String

        Private sEGMENTField As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDL12SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property ATINN() As String
            Get
                Return Me.aTINNField
            End Get
            Set
                Me.aTINNField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public Property ATNAM() As String
            Get
                Return Me.aTNAMField
            End Get
            Set
                Me.aTNAMField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>
        Public Property ATBEZ() As String
            Get
                Return Me.aTBEZField
            End Get
            Set
                Me.aTBEZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=3)>
        Public Property ATWRT() As String
            Get
                Return Me.aTWRTField
            End Get
            Set
                Me.aTWRTField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=4)>
        Public Property ATWTB() As String
            Get
                Return Me.aTWTBField
            End Get
            Set
                Me.aTWTBField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=5)>
        Public Property EWAHR() As String
            Get
                Return Me.eWAHRField
            End Get
            Set
                Me.eWAHRField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property SEGMENT() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDL12SEGMENT
            Get
                Return Me.sEGMENTField
            End Get
            Set
                Me.sEGMENTField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Public Enum ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24E1EDL12SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Public Enum ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL24SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Diagnostics.DebuggerStepThroughAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Partial Public Class ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL37

        Private eXIDVField As String

        Private tARAGField As String

        Private gWEITField As String

        Private bRGEWField As String

        Private nTGEWField As String

        Private mAGEWField As String

        Private gWEIMField As String

        Private bTVOLField As String

        Private nTVOLField As String

        Private mAVOLField As String

        Private vOLEMField As String

        Private tAVOLField As String

        Private vOLETField As String

        Private vEGR2Field As String

        Private vEGR1Field As String

        Private vEGR3Field As String

        Private vHILMField As String

        Private vEGR4Field As String

        Private lAENGField As String

        Private vEGR5Field As String

        Private bREITField As String

        Private hOEHEField As String

        Private mEABMField As String

        Private iNHALTField As String

        Private vHARTField As String

        Private mAGRVField As String

        Private lADLGField As String

        Private lADEHField As String

        Private fARZTField As String

        Private fAREHField As String

        Private eNTFEField As String

        Private eHENTField As String

        Private vELTPField As String

        Private eXIDV2Field As String

        Private lANDTField As String

        Private lANDFField As String

        Private nAMEFField As String

        Private nAMBEField As String

        Private vHILM_KUField As String

        Private vEBEZField As String

        Private sMGKNField As String

        Private kDMAT35Field As String

        Private sORTLField As String

        Private eRNAMField As String

        Private gEWFXField As String

        Private eRLKZField As String

        Private eXIDAField As String

        Private mOVE_STATUSField As String

        Private pACKVORSCHRField As String

        Private pACKVORSCHR_STField As String

        Private lABELTYPField As String

        Private zUL_AUFLField As String

        Private vHILM_EXTERNALField As String

        Private vHILM_VERSIONField As String

        Private vHILM_GUIDField As String

        Private kDMAT35_EXTERNALField As String

        Private kDMAT35_VERSIONField As String

        Private kDMAT35_GUIDField As String

        Private vHILM_KU_EXTERNALField As String

        Private vHILM_KU_VERSIONField As String

        Private vHILM_KU_GUIDField As String

        Private e1EDL39Field() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL37E1EDL39

        Private e1EDL38Field As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL37E1EDL38

        Private e1EDL49Field As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL37E1EDL49

        Private e1EDL44Field() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL37E1EDL44

        Private sEGMENTField As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL37SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property EXIDV() As String
            Get
                Return Me.eXIDVField
            End Get
            Set
                Me.eXIDVField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public Property TARAG() As String
            Get
                Return Me.tARAGField
            End Get
            Set
                Me.tARAGField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>
        Public Property GWEIT() As String
            Get
                Return Me.gWEITField
            End Get
            Set
                Me.gWEITField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=3)>
        Public Property BRGEW() As String
            Get
                Return Me.bRGEWField
            End Get
            Set
                Me.bRGEWField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=4)>
        Public Property NTGEW() As String
            Get
                Return Me.nTGEWField
            End Get
            Set
                Me.nTGEWField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=5)>
        Public Property MAGEW() As String
            Get
                Return Me.mAGEWField
            End Get
            Set
                Me.mAGEWField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=6)>
        Public Property GWEIM() As String
            Get
                Return Me.gWEIMField
            End Get
            Set
                Me.gWEIMField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=7)>
        Public Property BTVOL() As String
            Get
                Return Me.bTVOLField
            End Get
            Set
                Me.bTVOLField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=8)>
        Public Property NTVOL() As String
            Get
                Return Me.nTVOLField
            End Get
            Set
                Me.nTVOLField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=9)>
        Public Property MAVOL() As String
            Get
                Return Me.mAVOLField
            End Get
            Set
                Me.mAVOLField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=10)>
        Public Property VOLEM() As String
            Get
                Return Me.vOLEMField
            End Get
            Set
                Me.vOLEMField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=11)>
        Public Property TAVOL() As String
            Get
                Return Me.tAVOLField
            End Get
            Set
                Me.tAVOLField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=12)>
        Public Property VOLET() As String
            Get
                Return Me.vOLETField
            End Get
            Set
                Me.vOLETField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=13)>
        Public Property VEGR2() As String
            Get
                Return Me.vEGR2Field
            End Get
            Set
                Me.vEGR2Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=14)>
        Public Property VEGR1() As String
            Get
                Return Me.vEGR1Field
            End Get
            Set
                Me.vEGR1Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=15)>
        Public Property VEGR3() As String
            Get
                Return Me.vEGR3Field
            End Get
            Set
                Me.vEGR3Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=16)>
        Public Property VHILM() As String
            Get
                Return Me.vHILMField
            End Get
            Set
                Me.vHILMField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=17)>
        Public Property VEGR4() As String
            Get
                Return Me.vEGR4Field
            End Get
            Set
                Me.vEGR4Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=18)>
        Public Property LAENG() As String
            Get
                Return Me.lAENGField
            End Get
            Set
                Me.lAENGField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=19)>
        Public Property VEGR5() As String
            Get
                Return Me.vEGR5Field
            End Get
            Set
                Me.vEGR5Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=20)>
        Public Property BREIT() As String
            Get
                Return Me.bREITField
            End Get
            Set
                Me.bREITField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=21)>
        Public Property HOEHE() As String
            Get
                Return Me.hOEHEField
            End Get
            Set
                Me.hOEHEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=22)>
        Public Property MEABM() As String
            Get
                Return Me.mEABMField
            End Get
            Set
                Me.mEABMField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=23)>
        Public Property INHALT() As String
            Get
                Return Me.iNHALTField
            End Get
            Set
                Me.iNHALTField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=24)>
        Public Property VHART() As String
            Get
                Return Me.vHARTField
            End Get
            Set
                Me.vHARTField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=25)>
        Public Property MAGRV() As String
            Get
                Return Me.mAGRVField
            End Get
            Set
                Me.mAGRVField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=26)>
        Public Property LADLG() As String
            Get
                Return Me.lADLGField
            End Get
            Set
                Me.lADLGField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=27)>
        Public Property LADEH() As String
            Get
                Return Me.lADEHField
            End Get
            Set
                Me.lADEHField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=28)>
        Public Property FARZT() As String
            Get
                Return Me.fARZTField
            End Get
            Set
                Me.fARZTField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=29)>
        Public Property FAREH() As String
            Get
                Return Me.fAREHField
            End Get
            Set
                Me.fAREHField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=30)>
        Public Property ENTFE() As String
            Get
                Return Me.eNTFEField
            End Get
            Set
                Me.eNTFEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=31)>
        Public Property EHENT() As String
            Get
                Return Me.eHENTField
            End Get
            Set
                Me.eHENTField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=32)>
        Public Property VELTP() As String
            Get
                Return Me.vELTPField
            End Get
            Set
                Me.vELTPField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=33)>
        Public Property EXIDV2() As String
            Get
                Return Me.eXIDV2Field
            End Get
            Set
                Me.eXIDV2Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=34)>
        Public Property LANDT() As String
            Get
                Return Me.lANDTField
            End Get
            Set
                Me.lANDTField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=35)>
        Public Property LANDF() As String
            Get
                Return Me.lANDFField
            End Get
            Set
                Me.lANDFField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=36)>
        Public Property NAMEF() As String
            Get
                Return Me.nAMEFField
            End Get
            Set
                Me.nAMEFField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=37)>
        Public Property NAMBE() As String
            Get
                Return Me.nAMBEField
            End Get
            Set
                Me.nAMBEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=38)>
        Public Property VHILM_KU() As String
            Get
                Return Me.vHILM_KUField
            End Get
            Set
                Me.vHILM_KUField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=39)>
        Public Property VEBEZ() As String
            Get
                Return Me.vEBEZField
            End Get
            Set
                Me.vEBEZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=40)>
        Public Property SMGKN() As String
            Get
                Return Me.sMGKNField
            End Get
            Set
                Me.sMGKNField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=41)>
        Public Property KDMAT35() As String
            Get
                Return Me.kDMAT35Field
            End Get
            Set
                Me.kDMAT35Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=42)>
        Public Property SORTL() As String
            Get
                Return Me.sORTLField
            End Get
            Set
                Me.sORTLField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=43)>
        Public Property ERNAM() As String
            Get
                Return Me.eRNAMField
            End Get
            Set
                Me.eRNAMField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=44)>
        Public Property GEWFX() As String
            Get
                Return Me.gEWFXField
            End Get
            Set
                Me.gEWFXField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=45)>
        Public Property ERLKZ() As String
            Get
                Return Me.eRLKZField
            End Get
            Set
                Me.eRLKZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=46)>
        Public Property EXIDA() As String
            Get
                Return Me.eXIDAField
            End Get
            Set
                Me.eXIDAField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=47)>
        Public Property MOVE_STATUS() As String
            Get
                Return Me.mOVE_STATUSField
            End Get
            Set
                Me.mOVE_STATUSField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=48)>
        Public Property PACKVORSCHR() As String
            Get
                Return Me.pACKVORSCHRField
            End Get
            Set
                Me.pACKVORSCHRField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=49)>
        Public Property PACKVORSCHR_ST() As String
            Get
                Return Me.pACKVORSCHR_STField
            End Get
            Set
                Me.pACKVORSCHR_STField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=50)>
        Public Property LABELTYP() As String
            Get
                Return Me.lABELTYPField
            End Get
            Set
                Me.lABELTYPField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=51)>
        Public Property ZUL_AUFL() As String
            Get
                Return Me.zUL_AUFLField
            End Get
            Set
                Me.zUL_AUFLField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=52)>
        Public Property VHILM_EXTERNAL() As String
            Get
                Return Me.vHILM_EXTERNALField
            End Get
            Set
                Me.vHILM_EXTERNALField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=53)>
        Public Property VHILM_VERSION() As String
            Get
                Return Me.vHILM_VERSIONField
            End Get
            Set
                Me.vHILM_VERSIONField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=54)>
        Public Property VHILM_GUID() As String
            Get
                Return Me.vHILM_GUIDField
            End Get
            Set
                Me.vHILM_GUIDField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=55)>
        Public Property KDMAT35_EXTERNAL() As String
            Get
                Return Me.kDMAT35_EXTERNALField
            End Get
            Set
                Me.kDMAT35_EXTERNALField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=56)>
        Public Property KDMAT35_VERSION() As String
            Get
                Return Me.kDMAT35_VERSIONField
            End Get
            Set
                Me.kDMAT35_VERSIONField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=57)>
        Public Property KDMAT35_GUID() As String
            Get
                Return Me.kDMAT35_GUIDField
            End Get
            Set
                Me.kDMAT35_GUIDField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=58)>
        Public Property VHILM_KU_EXTERNAL() As String
            Get
                Return Me.vHILM_KU_EXTERNALField
            End Get
            Set
                Me.vHILM_KU_EXTERNALField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=59)>
        Public Property VHILM_KU_VERSION() As String
            Get
                Return Me.vHILM_KU_VERSIONField
            End Get
            Set
                Me.vHILM_KU_VERSIONField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=60)>
        Public Property VHILM_KU_GUID() As String
            Get
                Return Me.vHILM_KU_GUIDField
            End Get
            Set
                Me.vHILM_KU_GUIDField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("E1EDL39", Order:=61)>
        Public Property E1EDL39() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL37E1EDL39()
            Get
                Return Me.e1EDL39Field
            End Get
            Set
                Me.e1EDL39Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=62)>
        Public Property E1EDL38() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL37E1EDL38
            Get
                Return Me.e1EDL38Field
            End Get
            Set
                Me.e1EDL38Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=63)>
        Public Property E1EDL49() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL37E1EDL49
            Get
                Return Me.e1EDL49Field
            End Get
            Set
                Me.e1EDL49Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("E1EDL44", Order:=64)>
        Public Property E1EDL44() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL37E1EDL44()
            Get
                Return Me.e1EDL44Field
            End Get
            Set
                Me.e1EDL44Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property SEGMENT() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL37SEGMENT
            Get
                Return Me.sEGMENTField
            End Get
            Set
                Me.sEGMENTField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Diagnostics.DebuggerStepThroughAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Partial Public Class ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL37E1EDL39

        Private qUALFField As String

        Private pARAMField As String

        Private sEGMENTField As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL37E1EDL39SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property QUALF() As String
            Get
                Return Me.qUALFField
            End Get
            Set
                Me.qUALFField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public Property PARAM() As String
            Get
                Return Me.pARAMField
            End Get
            Set
                Me.pARAMField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property SEGMENT() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL37E1EDL39SEGMENT
            Get
                Return Me.sEGMENTField
            End Get
            Set
                Me.sEGMENTField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Public Enum ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL37E1EDL39SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Diagnostics.DebuggerStepThroughAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Partial Public Class ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL37E1EDL38

        Private vEGR1_BEZField As String

        Private vEGR2_BEZField As String

        Private vEGR3_BEZField As String

        Private vEGR4_BEZField As String

        Private vEGR5_BEZField As String

        Private vHART_BEZField As String

        Private mAGRV_BEZField As String

        Private vEBEZField As String

        Private sEGMENTField As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL37E1EDL38SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property VEGR1_BEZ() As String
            Get
                Return Me.vEGR1_BEZField
            End Get
            Set
                Me.vEGR1_BEZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public Property VEGR2_BEZ() As String
            Get
                Return Me.vEGR2_BEZField
            End Get
            Set
                Me.vEGR2_BEZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>
        Public Property VEGR3_BEZ() As String
            Get
                Return Me.vEGR3_BEZField
            End Get
            Set
                Me.vEGR3_BEZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=3)>
        Public Property VEGR4_BEZ() As String
            Get
                Return Me.vEGR4_BEZField
            End Get
            Set
                Me.vEGR4_BEZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=4)>
        Public Property VEGR5_BEZ() As String
            Get
                Return Me.vEGR5_BEZField
            End Get
            Set
                Me.vEGR5_BEZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=5)>
        Public Property VHART_BEZ() As String
            Get
                Return Me.vHART_BEZField
            End Get
            Set
                Me.vHART_BEZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=6)>
        Public Property MAGRV_BEZ() As String
            Get
                Return Me.mAGRV_BEZField
            End Get
            Set
                Me.mAGRV_BEZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=7)>
        Public Property VEBEZ() As String
            Get
                Return Me.vEBEZField
            End Get
            Set
                Me.vEBEZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property SEGMENT() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL37E1EDL38SEGMENT
            Get
                Return Me.sEGMENTField
            End Get
            Set
                Me.sEGMENTField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Public Enum ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL37E1EDL38SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Diagnostics.DebuggerStepThroughAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Partial Public Class ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL37E1EDL49

        Private xSITDField As String

        Private sHIPACCTField As String

        Private tRACKNField As String

        Private xSIURL_SINGLE_TRACKField As String

        Private e1EDL50Field() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL37E1EDL49E1EDL50

        Private sEGMENTField As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL37E1EDL49SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property XSITD() As String
            Get
                Return Me.xSITDField
            End Get
            Set
                Me.xSITDField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public Property SHIPACCT() As String
            Get
                Return Me.sHIPACCTField
            End Get
            Set
                Me.sHIPACCTField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>
        Public Property TRACKN() As String
            Get
                Return Me.tRACKNField
            End Get
            Set
                Me.tRACKNField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=3)>
        Public Property XSIURL_SINGLE_TRACK() As String
            Get
                Return Me.xSIURL_SINGLE_TRACKField
            End Get
            Set
                Me.xSIURL_SINGLE_TRACKField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("E1EDL50", Order:=4)>
        Public Property E1EDL50() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL37E1EDL49E1EDL50()
            Get
                Return Me.e1EDL50Field
            End Get
            Set
                Me.e1EDL50Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property SEGMENT() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL37E1EDL49SEGMENT
            Get
                Return Me.sEGMENTField
            End Get
            Set
                Me.sEGMENTField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Diagnostics.DebuggerStepThroughAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Partial Public Class ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL37E1EDL49E1EDL50

        Private xSIQUALFField As String

        Private xSITDField As String

        Private vLABDATAField As String

        Private sEGMENTField As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL37E1EDL49E1EDL50SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property XSIQUALF() As String
            Get
                Return Me.xSIQUALFField
            End Get
            Set
                Me.xSIQUALFField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public Property XSITD() As String
            Get
                Return Me.xSITDField
            End Get
            Set
                Me.xSITDField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>
        Public Property VLABDATA() As String
            Get
                Return Me.vLABDATAField
            End Get
            Set
                Me.vLABDATAField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property SEGMENT() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL37E1EDL49E1EDL50SEGMENT
            Get
                Return Me.sEGMENTField
            End Get
            Set
                Me.sEGMENTField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Public Enum ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL37E1EDL49E1EDL50SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Public Enum ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL37E1EDL49SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Diagnostics.DebuggerStepThroughAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Partial Public Class ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL37E1EDL44

        Private vELINField As String

        Private vBELNField As String

        Private pOSNRField As String

        Private eXIDVField As String

        Private vEMNGField As String

        Private vEMEHField As String

        Private mATNRField As String

        Private kDMATField As String

        Private cHARGField As String

        Private wERKSField As String

        Private lGORTField As String

        Private cUOBJField As String

        Private bESTQField As String

        Private sOBKZField As String

        Private sONUMField As String

        Private aNZSNField As String

        Private wDATUField As String

        Private pARIDField As String

        Private mATNR_EXTERNALField As String

        Private mATNR_VERSIONField As String

        Private mATNR_GUIDField As String

        Private kDMAT_EXTERNALField As String

        Private kDMAT_VERSIONField As String

        Private kDMAT_GUIDField As String

        Private e1EDL46Field() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL37E1EDL44E1EDL46

        Private sEGMENTField As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL37E1EDL44SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property VELIN() As String
            Get
                Return Me.vELINField
            End Get
            Set
                Me.vELINField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public Property VBELN() As String
            Get
                Return Me.vBELNField
            End Get
            Set
                Me.vBELNField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>
        Public Property POSNR() As String
            Get
                Return Me.pOSNRField
            End Get
            Set
                Me.pOSNRField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=3)>
        Public Property EXIDV() As String
            Get
                Return Me.eXIDVField
            End Get
            Set
                Me.eXIDVField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=4)>
        Public Property VEMNG() As String
            Get
                Return Me.vEMNGField
            End Get
            Set
                Me.vEMNGField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=5)>
        Public Property VEMEH() As String
            Get
                Return Me.vEMEHField
            End Get
            Set
                Me.vEMEHField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=6)>
        Public Property MATNR() As String
            Get
                Return Me.mATNRField
            End Get
            Set
                Me.mATNRField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=7)>
        Public Property KDMAT() As String
            Get
                Return Me.kDMATField
            End Get
            Set
                Me.kDMATField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=8)>
        Public Property CHARG() As String
            Get
                Return Me.cHARGField
            End Get
            Set
                Me.cHARGField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=9)>
        Public Property WERKS() As String
            Get
                Return Me.wERKSField
            End Get
            Set
                Me.wERKSField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=10)>
        Public Property LGORT() As String
            Get
                Return Me.lGORTField
            End Get
            Set
                Me.lGORTField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=11)>
        Public Property CUOBJ() As String
            Get
                Return Me.cUOBJField
            End Get
            Set
                Me.cUOBJField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=12)>
        Public Property BESTQ() As String
            Get
                Return Me.bESTQField
            End Get
            Set
                Me.bESTQField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=13)>
        Public Property SOBKZ() As String
            Get
                Return Me.sOBKZField
            End Get
            Set
                Me.sOBKZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=14)>
        Public Property SONUM() As String
            Get
                Return Me.sONUMField
            End Get
            Set
                Me.sONUMField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=15)>
        Public Property ANZSN() As String
            Get
                Return Me.aNZSNField
            End Get
            Set
                Me.aNZSNField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=16)>
        Public Property WDATU() As String
            Get
                Return Me.wDATUField
            End Get
            Set
                Me.wDATUField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=17)>
        Public Property PARID() As String
            Get
                Return Me.pARIDField
            End Get
            Set
                Me.pARIDField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=18)>
        Public Property MATNR_EXTERNAL() As String
            Get
                Return Me.mATNR_EXTERNALField
            End Get
            Set
                Me.mATNR_EXTERNALField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=19)>
        Public Property MATNR_VERSION() As String
            Get
                Return Me.mATNR_VERSIONField
            End Get
            Set
                Me.mATNR_VERSIONField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=20)>
        Public Property MATNR_GUID() As String
            Get
                Return Me.mATNR_GUIDField
            End Get
            Set
                Me.mATNR_GUIDField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=21)>
        Public Property KDMAT_EXTERNAL() As String
            Get
                Return Me.kDMAT_EXTERNALField
            End Get
            Set
                Me.kDMAT_EXTERNALField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=22)>
        Public Property KDMAT_VERSION() As String
            Get
                Return Me.kDMAT_VERSIONField
            End Get
            Set
                Me.kDMAT_VERSIONField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=23)>
        Public Property KDMAT_GUID() As String
            Get
                Return Me.kDMAT_GUIDField
            End Get
            Set
                Me.kDMAT_GUIDField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("E1EDL46", Order:=24)>
        Public Property E1EDL46() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL37E1EDL44E1EDL46()
            Get
                Return Me.e1EDL46Field
            End Get
            Set
                Me.e1EDL46Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property SEGMENT() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL37E1EDL44SEGMENT
            Get
                Return Me.sEGMENTField
            End Get
            Set
                Me.sEGMENTField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Diagnostics.DebuggerStepThroughAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Partial Public Class ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL37E1EDL44E1EDL46

        Private sERNRField As String

        Private uIIField As String

        Private sEGMENTField As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL37E1EDL44E1EDL46SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property SERNR() As String
            Get
                Return Me.sERNRField
            End Get
            Set
                Me.sERNRField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public Property UII() As String
            Get
                Return Me.uIIField
            End Get
            Set
                Me.uIIField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property SEGMENT() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL37E1EDL44E1EDL46SEGMENT
            Get
                Return Me.sEGMENTField
            End Get
            Set
                Me.sEGMENTField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Public Enum ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL37E1EDL44E1EDL46SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Public Enum ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL37E1EDL44SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Public Enum ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL37SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Diagnostics.DebuggerStepThroughAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Partial Public Class ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL54

        Private sOURCEHUField As String

        Private dESTHUField As String

        Private pACKHUField As String

        Private pACK_QTYField As String

        Private bASE_UOMField As String

        Private mATERIALField As String

        Private bATCHField As String

        Private pLANTField As String

        Private sTGE_LOCField As String

        Private sTOCK_CATField As String

        Private sPEC_STOCKField As String

        Private sP_STCK_NOField As String

        Private dELIV_NUMBField As String

        Private dELIV_ITEMField As String

        Private mATERIAL_EXTERNALField As String

        Private mATERIAL_VERSIONField As String

        Private mATERIAL_GUIDField As String

        Private sEGMENTField As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL54SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property SOURCEHU() As String
            Get
                Return Me.sOURCEHUField
            End Get
            Set
                Me.sOURCEHUField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public Property DESTHU() As String
            Get
                Return Me.dESTHUField
            End Get
            Set
                Me.dESTHUField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>
        Public Property PACKHU() As String
            Get
                Return Me.pACKHUField
            End Get
            Set
                Me.pACKHUField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=3)>
        Public Property PACK_QTY() As String
            Get
                Return Me.pACK_QTYField
            End Get
            Set
                Me.pACK_QTYField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=4)>
        Public Property BASE_UOM() As String
            Get
                Return Me.bASE_UOMField
            End Get
            Set
                Me.bASE_UOMField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=5)>
        Public Property MATERIAL() As String
            Get
                Return Me.mATERIALField
            End Get
            Set
                Me.mATERIALField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=6)>
        Public Property BATCH() As String
            Get
                Return Me.bATCHField
            End Get
            Set
                Me.bATCHField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=7)>
        Public Property PLANT() As String
            Get
                Return Me.pLANTField
            End Get
            Set
                Me.pLANTField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=8)>
        Public Property STGE_LOC() As String
            Get
                Return Me.sTGE_LOCField
            End Get
            Set
                Me.sTGE_LOCField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=9)>
        Public Property STOCK_CAT() As String
            Get
                Return Me.sTOCK_CATField
            End Get
            Set
                Me.sTOCK_CATField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=10)>
        Public Property SPEC_STOCK() As String
            Get
                Return Me.sPEC_STOCKField
            End Get
            Set
                Me.sPEC_STOCKField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=11)>
        Public Property SP_STCK_NO() As String
            Get
                Return Me.sP_STCK_NOField
            End Get
            Set
                Me.sP_STCK_NOField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=12)>
        Public Property DELIV_NUMB() As String
            Get
                Return Me.dELIV_NUMBField
            End Get
            Set
                Me.dELIV_NUMBField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=13)>
        Public Property DELIV_ITEM() As String
            Get
                Return Me.dELIV_ITEMField
            End Get
            Set
                Me.dELIV_ITEMField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=14)>
        Public Property MATERIAL_EXTERNAL() As String
            Get
                Return Me.mATERIAL_EXTERNALField
            End Get
            Set
                Me.mATERIAL_EXTERNALField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=15)>
        Public Property MATERIAL_VERSION() As String
            Get
                Return Me.mATERIAL_VERSIONField
            End Get
            Set
                Me.mATERIAL_VERSIONField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=16)>
        Public Property MATERIAL_GUID() As String
            Get
                Return Me.mATERIAL_GUIDField
            End Get
            Set
                Me.mATERIAL_GUIDField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property SEGMENT() As ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL54SEGMENT
            Get
                Return Me.sEGMENTField
            End Get
            Set
                Me.sEGMENTField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Public Enum ZSCMT19C_DELVRY03IDOCE1EDL20E1EDL54SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Public Enum ZSCMT19C_DELVRY03IDOCE1EDL20SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Public Enum ZSCMT19C_DELVRY03IDOCBEGIN

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Diagnostics.DebuggerStepThroughAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1/types")>
    Partial Public Class SendPostingToDeliveriesData

        Private zSCMT19C_DELVRY03Field As ZSCMT19C_DELVRY03

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property ZSCMT19C_DELVRY03() As ZSCMT19C_DELVRY03
            Get
                Return Me.zSCMT19C_DELVRY03Field
            End Get
            Set
                Me.zSCMT19C_DELVRY03Field = Value
            End Set
        End Property
    End Class

    <System.Diagnostics.DebuggerStepThroughAttribute(),
 System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),
 System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),
 System.ServiceModel.MessageContractAttribute(WrapperName:="sendPostingToDeliveries", WrapperNamespace:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
    "iveries/v1", IsWrapped:=True)>
    Partial Public Class sendPostingToDeliveriesRequest

        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
        "iveries/v1/types", Order:=0),
     System.Xml.Serialization.XmlElementAttribute([Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
        "iveries/v1/types")>
        Public context As TCContext

        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
        "iveries/v1/types", Order:=1),
     System.Xml.Serialization.XmlElementAttribute([Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/SendPostingToDel" &
        "iveries/v1/types")>
        Public data As SendPostingToDeliveriesData

        Public Sub New()
            MyBase.New
        End Sub

        Public Sub New(ByVal context As TCContext, ByVal data As SendPostingToDeliveriesData)
            MyBase.New
            Me.context = context
            Me.data = data
        End Sub
    End Class
    'WrapperName:="empty",
    <System.Diagnostics.DebuggerStepThroughAttribute(),
 System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),
 System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),
 System.ServiceModel.MessageContractAttribute(WrapperNamespace:="http://schemas.telekom.net/csdg_v01.02", IsWrapped:=True)>
    Partial Public Class sendPostingToDeliveriesResponse

        Public Sub New()
            MyBase.New
        End Sub
    End Class

    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>
    Public Interface SendPostingToDeliveriesConsumerChannel
        Inherits ISendPostingToDeliveries, System.ServiceModel.IClientChannel
    End Interface

    <System.Diagnostics.DebuggerStepThroughAttribute(),
 System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>
    Partial Public Class SendPostingToDeliveriesConsumerClient
        Inherits System.ServiceModel.ClientBase(Of ISendPostingToDeliveries)
        Implements ISendPostingToDeliveries

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
        Function SendPostingToDeliveriesConsumer_sendPostingToDeliveries(ByVal request As sendPostingToDeliveriesRequest) As sendPostingToDeliveriesResponse Implements ISendPostingToDeliveries.sendPostingToDeliveries
            Return MyBase.Channel.sendPostingToDeliveries(request)
        End Function

        Public Sub sendPostingToDeliveries(ByVal context As TCContext, ByVal data As SendPostingToDeliveriesData)
            Dim inValue As sendPostingToDeliveriesRequest = New sendPostingToDeliveriesRequest()
            inValue.context = context
            inValue.data = data
            Dim retVal As sendPostingToDeliveriesResponse = CType(Me, ISendPostingToDeliveries).sendPostingToDeliveries(inValue)
        End Sub


        '<System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>
        'Function SendPostingToDeliveriesConsumer_sendPostingToDeliveriesAsync(ByVal request As sendPostingToDeliveriesRequest) As System.Threading.Tasks.Task(Of sendPostingToDeliveriesResponse) Implements SendPostingToDeliveriesConsumer.sendPostingToDeliveriesAsync
        '    Return MyBase.Channel.sendPostingToDeliveriesAsync(request)
        'End Function

        'Public Function sendPostingToDeliveriesAsync(ByVal context As TCContext, ByVal data As SendPostingToDeliveriesData) As System.Threading.Tasks.Task(Of sendPostingToDeliveriesResponse)
        '    Dim inValue As sendPostingToDeliveriesRequest = New sendPostingToDeliveriesRequest()
        '    inValue.context = context
        '    inValue.data = data
        '    Return CType(Me, SendPostingToDeliveriesConsumer).sendPostingToDeliveriesAsync(inValue)
        'End Function
    End Class
End Namespace

