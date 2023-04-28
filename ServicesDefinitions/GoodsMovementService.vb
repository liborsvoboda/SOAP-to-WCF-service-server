Option Strict Off
Option Explicit On

Imports System.Runtime.Serialization
Imports System.Web.Services
Imports AppWSDL.together

<Assembly: System.Runtime.Serialization.ContractNamespaceAttribute("http://schemas.telekom.net/csdg_v01.02", ClrNamespace:="schemas.telekom.net.csdg_v01._02")>

Namespace GoodsMovementService


    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),
 System.ServiceModel.ServiceContractAttribute(Name:="GoodsMovementService", [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/GoodsMovement/v1" &
    "")>
    Public Interface IGoodsMovementService

        'CODEGEN: Probíhá generování kontraktu zprávy, protože obor názvů obálky (http://schemas.telekom.net/csdg_v01.02) zprávy sendGoodsMovementResponse neodpovídá výchozí hodnotě (http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/GoodsMovement/v1)
        <System.ServiceModel.OperationContract(Action:="sendGoodsMovement"),
     System.ServiceModel.FaultContractAttribute(GetType(schemas.telekom.net.csdg_v01._02.TCTechnicalFaultInfo), Action:="sendGoodsMovement", Name:="technicalFault", [Namespace]:="http://schemas.telekom.net/csdg_v01.02"),
     System.ServiceModel.XmlSerializerFormatAttribute()>
        Function sendGoodsMovement(ByVal request As sendGoodsMovementRequest) As sendGoodsMovementResponse

    End Interface

    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Diagnostics.DebuggerStepThroughAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/GoodsMovement/v1" &
    "/types")>
    Partial Public Class MBGMCR03Type

        Private iDOCField As MBGMCR03TypeIDOC

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property IDOC() As MBGMCR03TypeIDOC
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
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/GoodsMovement/v1" &
    "/types")>
    Partial Public Class MBGMCR03TypeIDOC

        Private eDI_DC40Field As MBGMCR03TypeIDOCEDI_DC40

        Private e1MBGMCRField As MBGMCR03TypeIDOCE1MBGMCR

        Private bEGINField As MBGMCR03TypeIDOCBEGIN

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property EDI_DC40() As MBGMCR03TypeIDOCEDI_DC40
            Get
                Return Me.eDI_DC40Field
            End Get
            Set
                Me.eDI_DC40Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public Property E1MBGMCR() As MBGMCR03TypeIDOCE1MBGMCR
            Get
                Return Me.e1MBGMCRField
            End Get
            Set
                Me.e1MBGMCRField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property BEGIN() As MBGMCR03TypeIDOCBEGIN
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
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/GoodsMovement/v1" &
    "/types")>
    Partial Public Class MBGMCR03TypeIDOCEDI_DC40

        Private tABNAMField As String

        Private mANDTField As String

        Private dOCNUMField As String

        Private dOCRELField As String

        Private sTATUSField As String

        Private dIRECTField As MBGMCR03TypeIDOCEDI_DC40DIRECT

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

        Private sEGMENTField As MBGMCR03TypeIDOCEDI_DC40SEGMENT

        Public Sub New()
            MyBase.New
            Me.tABNAMField = "EDI_DC40"
            Me.iDOCTYPField = "MBGMCR03"
            Me.cIMTYPField = ""
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
        Public Property DIRECT() As MBGMCR03TypeIDOCEDI_DC40DIRECT
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
        Public Property SEGMENT() As MBGMCR03TypeIDOCEDI_DC40SEGMENT
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
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/GoodsMovement/v1" &
    "/types")>
    Public Enum MBGMCR03TypeIDOCEDI_DC40DIRECT

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
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/GoodsMovement/v1" &
    "/types")>
    Public Enum MBGMCR03TypeIDOCEDI_DC40SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Diagnostics.DebuggerStepThroughAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/GoodsMovement/v1" &
    "/types")>
    Partial Public Class MBGMCR03TypeIDOCE1MBGMCR

        Private tESTRUNField As String

        Private e1BP2017_GM_HEAD_01Field As MBGMCR03TypeIDOCE1MBGMCRE1BP2017_GM_HEAD_01

        Private e1BP2017_GM_CODEField As MBGMCR03TypeIDOCE1MBGMCRE1BP2017_GM_CODE

        Private _SPE_E1BP2017_GM_REF_EWMField As MBGMCR03TypeIDOCE1MBGMCR_SPE_E1BP2017_GM_REF_EWM

        Private e1BP2017_GM_ITEM_CREATEField() As MBGMCR03TypeIDOCE1MBGMCRE1BP2017_GM_ITEM_CREATE

        Private e1BP2017_GM_SERIALNUMBERField() As MBGMCR03TypeIDOCE1MBGMCRE1BP2017_GM_SERIALNUMBER

        Private _SPE_E1BP2017_SERVICEPART_DField() As MBGMCR03TypeIDOCE1MBGMCR_SPE_E1BP2017_SERVICEPART_D

        Private e1BPPAREXField() As MBGMCR03TypeIDOCE1MBGMCRE1BPPAREX

        Private sEGMENTField As MBGMCR03TypeIDOCE1MBGMCRSEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property TESTRUN() As String
            Get
                Return Me.tESTRUNField
            End Get
            Set
                Me.tESTRUNField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public Property E1BP2017_GM_HEAD_01() As MBGMCR03TypeIDOCE1MBGMCRE1BP2017_GM_HEAD_01
            Get
                Return Me.e1BP2017_GM_HEAD_01Field
            End Get
            Set
                Me.e1BP2017_GM_HEAD_01Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>
        Public Property E1BP2017_GM_CODE() As MBGMCR03TypeIDOCE1MBGMCRE1BP2017_GM_CODE
            Get
                Return Me.e1BP2017_GM_CODEField
            End Get
            Set
                Me.e1BP2017_GM_CODEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("_-SPE_-E1BP2017_GM_REF_EWM", Order:=3)>
        Public Property _SPE_E1BP2017_GM_REF_EWM() As MBGMCR03TypeIDOCE1MBGMCR_SPE_E1BP2017_GM_REF_EWM
            Get
                Return Me._SPE_E1BP2017_GM_REF_EWMField
            End Get
            Set
                Me._SPE_E1BP2017_GM_REF_EWMField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("E1BP2017_GM_ITEM_CREATE", Order:=4)>
        Public Property E1BP2017_GM_ITEM_CREATE() As MBGMCR03TypeIDOCE1MBGMCRE1BP2017_GM_ITEM_CREATE()
            Get
                Return Me.e1BP2017_GM_ITEM_CREATEField
            End Get
            Set
                Me.e1BP2017_GM_ITEM_CREATEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("E1BP2017_GM_SERIALNUMBER", Order:=5)>
        Public Property E1BP2017_GM_SERIALNUMBER() As MBGMCR03TypeIDOCE1MBGMCRE1BP2017_GM_SERIALNUMBER()
            Get
                Return Me.e1BP2017_GM_SERIALNUMBERField
            End Get
            Set
                Me.e1BP2017_GM_SERIALNUMBERField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("_-SPE_-E1BP2017_SERVICEPART_D", Order:=6)>
        Public Property _SPE_E1BP2017_SERVICEPART_D() As MBGMCR03TypeIDOCE1MBGMCR_SPE_E1BP2017_SERVICEPART_D()
            Get
                Return Me._SPE_E1BP2017_SERVICEPART_DField
            End Get
            Set
                Me._SPE_E1BP2017_SERVICEPART_DField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("E1BPPAREX", Order:=7)>
        Public Property E1BPPAREX() As MBGMCR03TypeIDOCE1MBGMCRE1BPPAREX()
            Get
                Return Me.e1BPPAREXField
            End Get
            Set
                Me.e1BPPAREXField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property SEGMENT() As MBGMCR03TypeIDOCE1MBGMCRSEGMENT
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
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/GoodsMovement/v1" &
    "/types")>
    Partial Public Class MBGMCR03TypeIDOCE1MBGMCRE1BP2017_GM_HEAD_01

        Private pSTNG_DATEField As String

        Private dOC_DATEField As String

        Private rEF_DOC_NOField As String

        Private bILL_OF_LADINGField As String

        Private gR_GI_SLIP_NOField As String

        Private pR_UNAMEField As String

        Private hEADER_TXTField As String

        Private vER_GR_GI_SLIPField As String

        Private vER_GR_GI_SLIPXField As String

        Private eXT_WMSField As String

        Private rEF_DOC_NO_LONGField As String

        Private bILL_OF_LADING_LONGField As String

        Private bAR_CODEField As String

        Private sEGMENTField As MBGMCR03TypeIDOCE1MBGMCRE1BP2017_GM_HEAD_01SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property PSTNG_DATE() As String
            Get
                Return Me.pSTNG_DATEField
            End Get
            Set
                Me.pSTNG_DATEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public Property DOC_DATE() As String
            Get
                Return Me.dOC_DATEField
            End Get
            Set
                Me.dOC_DATEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>
        Public Property REF_DOC_NO() As String
            Get
                Return Me.rEF_DOC_NOField
            End Get
            Set
                Me.rEF_DOC_NOField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=3)>
        Public Property BILL_OF_LADING() As String
            Get
                Return Me.bILL_OF_LADINGField
            End Get
            Set
                Me.bILL_OF_LADINGField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=4)>
        Public Property GR_GI_SLIP_NO() As String
            Get
                Return Me.gR_GI_SLIP_NOField
            End Get
            Set
                Me.gR_GI_SLIP_NOField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=5)>
        Public Property PR_UNAME() As String
            Get
                Return Me.pR_UNAMEField
            End Get
            Set
                Me.pR_UNAMEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=6)>
        Public Property HEADER_TXT() As String
            Get
                Return Me.hEADER_TXTField
            End Get
            Set
                Me.hEADER_TXTField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=7)>
        Public Property VER_GR_GI_SLIP() As String
            Get
                Return Me.vER_GR_GI_SLIPField
            End Get
            Set
                Me.vER_GR_GI_SLIPField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=8)>
        Public Property VER_GR_GI_SLIPX() As String
            Get
                Return Me.vER_GR_GI_SLIPXField
            End Get
            Set
                Me.vER_GR_GI_SLIPXField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=9)>
        Public Property EXT_WMS() As String
            Get
                Return Me.eXT_WMSField
            End Get
            Set
                Me.eXT_WMSField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=10)>
        Public Property REF_DOC_NO_LONG() As String
            Get
                Return Me.rEF_DOC_NO_LONGField
            End Get
            Set
                Me.rEF_DOC_NO_LONGField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=11)>
        Public Property BILL_OF_LADING_LONG() As String
            Get
                Return Me.bILL_OF_LADING_LONGField
            End Get
            Set
                Me.bILL_OF_LADING_LONGField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=12)>
        Public Property BAR_CODE() As String
            Get
                Return Me.bAR_CODEField
            End Get
            Set
                Me.bAR_CODEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property SEGMENT() As MBGMCR03TypeIDOCE1MBGMCRE1BP2017_GM_HEAD_01SEGMENT
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
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/GoodsMovement/v1" &
    "/types")>
    Public Enum MBGMCR03TypeIDOCE1MBGMCRE1BP2017_GM_HEAD_01SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Diagnostics.DebuggerStepThroughAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/GoodsMovement/v1" &
    "/types")>
    Partial Public Class MBGMCR03TypeIDOCE1MBGMCRE1BP2017_GM_CODE

        Private gM_CODEField As String

        Private sEGMENTField As MBGMCR03TypeIDOCE1MBGMCRE1BP2017_GM_CODESEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property GM_CODE() As String
            Get
                Return Me.gM_CODEField
            End Get
            Set
                Me.gM_CODEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property SEGMENT() As MBGMCR03TypeIDOCE1MBGMCRE1BP2017_GM_CODESEGMENT
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
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/GoodsMovement/v1" &
    "/types")>
    Public Enum MBGMCR03TypeIDOCE1MBGMCRE1BP2017_GM_CODESEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Diagnostics.DebuggerStepThroughAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/GoodsMovement/v1" &
    "/types")>
    Partial Public Class MBGMCR03TypeIDOCE1MBGMCR_SPE_E1BP2017_GM_REF_EWM

        Private rEF_DOC_EWMField As String

        Private lOGSYSField As String

        Private gTS_SCRAP_NOField As String

        Private sEGMENTField As MBGMCR03TypeIDOCE1MBGMCR_SPE_E1BP2017_GM_REF_EWMSEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property REF_DOC_EWM() As String
            Get
                Return Me.rEF_DOC_EWMField
            End Get
            Set
                Me.rEF_DOC_EWMField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public Property LOGSYS() As String
            Get
                Return Me.lOGSYSField
            End Get
            Set
                Me.lOGSYSField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>
        Public Property GTS_SCRAP_NO() As String
            Get
                Return Me.gTS_SCRAP_NOField
            End Get
            Set
                Me.gTS_SCRAP_NOField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property SEGMENT() As MBGMCR03TypeIDOCE1MBGMCR_SPE_E1BP2017_GM_REF_EWMSEGMENT
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
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/GoodsMovement/v1" &
    "/types")>
    Public Enum MBGMCR03TypeIDOCE1MBGMCR_SPE_E1BP2017_GM_REF_EWMSEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Diagnostics.DebuggerStepThroughAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/GoodsMovement/v1" &
    "/types")>
    Partial Public Class MBGMCR03TypeIDOCE1MBGMCRE1BP2017_GM_ITEM_CREATE

        Private mATERIALField As String

        Private pLANTField As String

        Private sTGE_LOCField As String

        Private bATCHField As String

        Private mOVE_TYPEField As String

        Private sTCK_TYPEField As String

        Private sPEC_STOCKField As String

        Private vENDORField As String

        Private cUSTOMERField As String

        Private sALES_ORDField As String

        Private s_ORD_ITEMField As String

        Private sCHED_LINEField As String

        Private vAL_TYPEField As String

        Private eNTRY_QNTField As String

        Private eNTRY_UOMField As String

        Private eNTRY_UOM_ISOField As String

        Private pO_PR_QNTField As String

        Private oRDERPR_UNField As String

        Private oRDERPR_UN_ISOField As String

        Private pO_NUMBERField As String

        Private pO_ITEMField As String

        Private sHIPPINGField As String

        Private cOMP_SHIPField As String

        Private nO_MORE_GRField As String

        Private iTEM_TEXTField As String

        Private gR_RCPTField As String

        Private uNLOAD_PTField As String

        Private cOSTCENTERField As String

        Private oRDERIDField As String

        Private oRDER_ITNOField As String

        Private cALC_MOTIVEField As String

        Private aSSET_NOField As String

        Private sUB_NUMBERField As String

        Private rESERV_NOField As String

        Private rES_ITEMField As String

        Private rES_TYPEField As String

        Private wITHDRAWNField As String

        Private mOVE_MATField As String

        Private mOVE_PLANTField As String

        Private mOVE_STLOCField As String

        Private mOVE_BATCHField As String

        Private mOVE_VAL_TYPEField As String

        Private mVT_INDField As String

        Private mOVE_REASField As String

        Private rL_EST_KEYField As String

        Private rEF_DATEField As String

        Private cOST_OBJField As String

        Private pROFIT_SEGM_NOField As String

        Private pROFIT_CTRField As String

        Private wBS_ELEMField As String

        Private nETWORKField As String

        Private aCTIVITYField As String

        Private pART_ACCTField As String

        Private aMOUNT_LCField As String

        Private aMOUNT_SVField As String

        Private rEF_DOC_YRField As String

        Private rEF_DOCField As String

        Private rEF_DOC_ITField As String

        Private eXPIRYDATEField As String

        Private pROD_DATEField As String

        Private fUNDField As String

        Private fUNDS_CTRField As String

        Private cMMT_ITEMField As String

        Private vAL_SALES_ORDField As String

        Private vAL_S_ORD_ITEMField As String

        Private vAL_WBS_ELEMField As String

        Private gL_ACCOUNTField As String

        Private iND_PROPOSE_QUANXField As String

        Private xSTOBField As String

        Private eAN_UPCField As String

        Private dELIV_NUMB_TO_SEARCHField As String

        Private dELIV_ITEM_TO_SEARCHField As String

        Private sERIALNO_AUTO_NUMBERASSIGNMENTField As String

        Private vENDRBATCHField As String

        Private sTGE_TYPEField As String

        Private sTGE_BINField As String

        Private sU_PL_STCK_1Field As String

        Private sT_UN_QTYY_1Field As String

        Private sT_UN_QTYY_1_ISOField As String

        Private uNITTYPE_1Field As String

        Private sU_PL_STCK_2Field As String

        Private sT_UN_QTYY_2Field As String

        Private sT_UN_QTYY_2_ISOField As String

        Private uNITTYPE_2Field As String

        Private sTGE_TYPE_PCField As String

        Private sTGE_BIN_PCField As String

        Private nO_PST_CHGNTField As String

        Private gR_NUMBERField As String

        Private sTGE_TYPE_STField As String

        Private sTGE_BIN_STField As String

        Private mATDOC_TR_CANCELField As String

        Private mATITEM_TR_CANCELField As String

        Private mATYEAR_TR_CANCELField As String

        Private nO_TRANSFER_REQField As String

        Private cO_BUSPROCField As String

        Private aCTTYPEField As String

        Private sUPPL_VENDField As String

        Private mATERIAL_EXTERNALField As String

        Private mATERIAL_GUIDField As String

        Private mATERIAL_VERSIONField As String

        Private mOVE_MAT_EXTERNALField As String

        Private mOVE_MAT_GUIDField As String

        Private mOVE_MAT_VERSIONField As String

        Private fUNC_AREAField As String

        Private tR_PART_BAField As String

        Private pAR_COMPCOField As String

        Private e1BP2017_GM_ITEM_CREATE1Field As MBGMCR03TypeIDOCE1MBGMCRE1BP2017_GM_ITEM_CREATEE1BP2017_GM_ITEM_CREATE1

        Private sEGMENTField As MBGMCR03TypeIDOCE1MBGMCRE1BP2017_GM_ITEM_CREATESEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property MATERIAL() As String
            Get
                Return Me.mATERIALField
            End Get
            Set
                Me.mATERIALField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public Property PLANT() As String
            Get
                Return Me.pLANTField
            End Get
            Set
                Me.pLANTField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>
        Public Property STGE_LOC() As String
            Get
                Return Me.sTGE_LOCField
            End Get
            Set
                Me.sTGE_LOCField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=3)>
        Public Property BATCH() As String
            Get
                Return Me.bATCHField
            End Get
            Set
                Me.bATCHField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=4)>
        Public Property MOVE_TYPE() As String
            Get
                Return Me.mOVE_TYPEField
            End Get
            Set
                Me.mOVE_TYPEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=5)>
        Public Property STCK_TYPE() As String
            Get
                Return Me.sTCK_TYPEField
            End Get
            Set
                Me.sTCK_TYPEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=6)>
        Public Property SPEC_STOCK() As String
            Get
                Return Me.sPEC_STOCKField
            End Get
            Set
                Me.sPEC_STOCKField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=7)>
        Public Property VENDOR() As String
            Get
                Return Me.vENDORField
            End Get
            Set
                Me.vENDORField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=8)>
        Public Property CUSTOMER() As String
            Get
                Return Me.cUSTOMERField
            End Get
            Set
                Me.cUSTOMERField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=9)>
        Public Property SALES_ORD() As String
            Get
                Return Me.sALES_ORDField
            End Get
            Set
                Me.sALES_ORDField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=10)>
        Public Property S_ORD_ITEM() As String
            Get
                Return Me.s_ORD_ITEMField
            End Get
            Set
                Me.s_ORD_ITEMField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=11)>
        Public Property SCHED_LINE() As String
            Get
                Return Me.sCHED_LINEField
            End Get
            Set
                Me.sCHED_LINEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=12)>
        Public Property VAL_TYPE() As String
            Get
                Return Me.vAL_TYPEField
            End Get
            Set
                Me.vAL_TYPEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=13)>
        Public Property ENTRY_QNT() As String
            Get
                Return Me.eNTRY_QNTField
            End Get
            Set
                Me.eNTRY_QNTField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=14)>
        Public Property ENTRY_UOM() As String
            Get
                Return Me.eNTRY_UOMField
            End Get
            Set
                Me.eNTRY_UOMField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=15)>
        Public Property ENTRY_UOM_ISO() As String
            Get
                Return Me.eNTRY_UOM_ISOField
            End Get
            Set
                Me.eNTRY_UOM_ISOField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=16)>
        Public Property PO_PR_QNT() As String
            Get
                Return Me.pO_PR_QNTField
            End Get
            Set
                Me.pO_PR_QNTField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=17)>
        Public Property ORDERPR_UN() As String
            Get
                Return Me.oRDERPR_UNField
            End Get
            Set
                Me.oRDERPR_UNField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=18)>
        Public Property ORDERPR_UN_ISO() As String
            Get
                Return Me.oRDERPR_UN_ISOField
            End Get
            Set
                Me.oRDERPR_UN_ISOField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=19)>
        Public Property PO_NUMBER() As String
            Get
                Return Me.pO_NUMBERField
            End Get
            Set
                Me.pO_NUMBERField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=20)>
        Public Property PO_ITEM() As String
            Get
                Return Me.pO_ITEMField
            End Get
            Set
                Me.pO_ITEMField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=21)>
        Public Property SHIPPING() As String
            Get
                Return Me.sHIPPINGField
            End Get
            Set
                Me.sHIPPINGField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=22)>
        Public Property COMP_SHIP() As String
            Get
                Return Me.cOMP_SHIPField
            End Get
            Set
                Me.cOMP_SHIPField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=23)>
        Public Property NO_MORE_GR() As String
            Get
                Return Me.nO_MORE_GRField
            End Get
            Set
                Me.nO_MORE_GRField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=24)>
        Public Property ITEM_TEXT() As String
            Get
                Return Me.iTEM_TEXTField
            End Get
            Set
                Me.iTEM_TEXTField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=25)>
        Public Property GR_RCPT() As String
            Get
                Return Me.gR_RCPTField
            End Get
            Set
                Me.gR_RCPTField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=26)>
        Public Property UNLOAD_PT() As String
            Get
                Return Me.uNLOAD_PTField
            End Get
            Set
                Me.uNLOAD_PTField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=27)>
        Public Property COSTCENTER() As String
            Get
                Return Me.cOSTCENTERField
            End Get
            Set
                Me.cOSTCENTERField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=28)>
        Public Property ORDERID() As String
            Get
                Return Me.oRDERIDField
            End Get
            Set
                Me.oRDERIDField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=29)>
        Public Property ORDER_ITNO() As String
            Get
                Return Me.oRDER_ITNOField
            End Get
            Set
                Me.oRDER_ITNOField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=30)>
        Public Property CALC_MOTIVE() As String
            Get
                Return Me.cALC_MOTIVEField
            End Get
            Set
                Me.cALC_MOTIVEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=31)>
        Public Property ASSET_NO() As String
            Get
                Return Me.aSSET_NOField
            End Get
            Set
                Me.aSSET_NOField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=32)>
        Public Property SUB_NUMBER() As String
            Get
                Return Me.sUB_NUMBERField
            End Get
            Set
                Me.sUB_NUMBERField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=33)>
        Public Property RESERV_NO() As String
            Get
                Return Me.rESERV_NOField
            End Get
            Set
                Me.rESERV_NOField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=34)>
        Public Property RES_ITEM() As String
            Get
                Return Me.rES_ITEMField
            End Get
            Set
                Me.rES_ITEMField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=35)>
        Public Property RES_TYPE() As String
            Get
                Return Me.rES_TYPEField
            End Get
            Set
                Me.rES_TYPEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=36)>
        Public Property WITHDRAWN() As String
            Get
                Return Me.wITHDRAWNField
            End Get
            Set
                Me.wITHDRAWNField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=37)>
        Public Property MOVE_MAT() As String
            Get
                Return Me.mOVE_MATField
            End Get
            Set
                Me.mOVE_MATField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=38)>
        Public Property MOVE_PLANT() As String
            Get
                Return Me.mOVE_PLANTField
            End Get
            Set
                Me.mOVE_PLANTField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=39)>
        Public Property MOVE_STLOC() As String
            Get
                Return Me.mOVE_STLOCField
            End Get
            Set
                Me.mOVE_STLOCField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=40)>
        Public Property MOVE_BATCH() As String
            Get
                Return Me.mOVE_BATCHField
            End Get
            Set
                Me.mOVE_BATCHField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=41)>
        Public Property MOVE_VAL_TYPE() As String
            Get
                Return Me.mOVE_VAL_TYPEField
            End Get
            Set
                Me.mOVE_VAL_TYPEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=42)>
        Public Property MVT_IND() As String
            Get
                Return Me.mVT_INDField
            End Get
            Set
                Me.mVT_INDField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=43)>
        Public Property MOVE_REAS() As String
            Get
                Return Me.mOVE_REASField
            End Get
            Set
                Me.mOVE_REASField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=44)>
        Public Property RL_EST_KEY() As String
            Get
                Return Me.rL_EST_KEYField
            End Get
            Set
                Me.rL_EST_KEYField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=45)>
        Public Property REF_DATE() As String
            Get
                Return Me.rEF_DATEField
            End Get
            Set
                Me.rEF_DATEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=46)>
        Public Property COST_OBJ() As String
            Get
                Return Me.cOST_OBJField
            End Get
            Set
                Me.cOST_OBJField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=47)>
        Public Property PROFIT_SEGM_NO() As String
            Get
                Return Me.pROFIT_SEGM_NOField
            End Get
            Set
                Me.pROFIT_SEGM_NOField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=48)>
        Public Property PROFIT_CTR() As String
            Get
                Return Me.pROFIT_CTRField
            End Get
            Set
                Me.pROFIT_CTRField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=49)>
        Public Property WBS_ELEM() As String
            Get
                Return Me.wBS_ELEMField
            End Get
            Set
                Me.wBS_ELEMField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=50)>
        Public Property NETWORK() As String
            Get
                Return Me.nETWORKField
            End Get
            Set
                Me.nETWORKField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=51)>
        Public Property ACTIVITY() As String
            Get
                Return Me.aCTIVITYField
            End Get
            Set
                Me.aCTIVITYField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=52)>
        Public Property PART_ACCT() As String
            Get
                Return Me.pART_ACCTField
            End Get
            Set
                Me.pART_ACCTField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=53)>
        Public Property AMOUNT_LC() As String
            Get
                Return Me.aMOUNT_LCField
            End Get
            Set
                Me.aMOUNT_LCField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=54)>
        Public Property AMOUNT_SV() As String
            Get
                Return Me.aMOUNT_SVField
            End Get
            Set
                Me.aMOUNT_SVField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=55)>
        Public Property REF_DOC_YR() As String
            Get
                Return Me.rEF_DOC_YRField
            End Get
            Set
                Me.rEF_DOC_YRField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=56)>
        Public Property REF_DOC() As String
            Get
                Return Me.rEF_DOCField
            End Get
            Set
                Me.rEF_DOCField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=57)>
        Public Property REF_DOC_IT() As String
            Get
                Return Me.rEF_DOC_ITField
            End Get
            Set
                Me.rEF_DOC_ITField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=58)>
        Public Property EXPIRYDATE() As String
            Get
                Return Me.eXPIRYDATEField
            End Get
            Set
                Me.eXPIRYDATEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=59)>
        Public Property PROD_DATE() As String
            Get
                Return Me.pROD_DATEField
            End Get
            Set
                Me.pROD_DATEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=60)>
        Public Property FUND() As String
            Get
                Return Me.fUNDField
            End Get
            Set
                Me.fUNDField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=61)>
        Public Property FUNDS_CTR() As String
            Get
                Return Me.fUNDS_CTRField
            End Get
            Set
                Me.fUNDS_CTRField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=62)>
        Public Property CMMT_ITEM() As String
            Get
                Return Me.cMMT_ITEMField
            End Get
            Set
                Me.cMMT_ITEMField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=63)>
        Public Property VAL_SALES_ORD() As String
            Get
                Return Me.vAL_SALES_ORDField
            End Get
            Set
                Me.vAL_SALES_ORDField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=64)>
        Public Property VAL_S_ORD_ITEM() As String
            Get
                Return Me.vAL_S_ORD_ITEMField
            End Get
            Set
                Me.vAL_S_ORD_ITEMField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=65)>
        Public Property VAL_WBS_ELEM() As String
            Get
                Return Me.vAL_WBS_ELEMField
            End Get
            Set
                Me.vAL_WBS_ELEMField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=66)>
        Public Property GL_ACCOUNT() As String
            Get
                Return Me.gL_ACCOUNTField
            End Get
            Set
                Me.gL_ACCOUNTField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=67)>
        Public Property IND_PROPOSE_QUANX() As String
            Get
                Return Me.iND_PROPOSE_QUANXField
            End Get
            Set
                Me.iND_PROPOSE_QUANXField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=68)>
        Public Property XSTOB() As String
            Get
                Return Me.xSTOBField
            End Get
            Set
                Me.xSTOBField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=69)>
        Public Property EAN_UPC() As String
            Get
                Return Me.eAN_UPCField
            End Get
            Set
                Me.eAN_UPCField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=70)>
        Public Property DELIV_NUMB_TO_SEARCH() As String
            Get
                Return Me.dELIV_NUMB_TO_SEARCHField
            End Get
            Set
                Me.dELIV_NUMB_TO_SEARCHField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=71)>
        Public Property DELIV_ITEM_TO_SEARCH() As String
            Get
                Return Me.dELIV_ITEM_TO_SEARCHField
            End Get
            Set
                Me.dELIV_ITEM_TO_SEARCHField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=72)>
        Public Property SERIALNO_AUTO_NUMBERASSIGNMENT() As String
            Get
                Return Me.sERIALNO_AUTO_NUMBERASSIGNMENTField
            End Get
            Set
                Me.sERIALNO_AUTO_NUMBERASSIGNMENTField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=73)>
        Public Property VENDRBATCH() As String
            Get
                Return Me.vENDRBATCHField
            End Get
            Set
                Me.vENDRBATCHField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=74)>
        Public Property STGE_TYPE() As String
            Get
                Return Me.sTGE_TYPEField
            End Get
            Set
                Me.sTGE_TYPEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=75)>
        Public Property STGE_BIN() As String
            Get
                Return Me.sTGE_BINField
            End Get
            Set
                Me.sTGE_BINField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=76)>
        Public Property SU_PL_STCK_1() As String
            Get
                Return Me.sU_PL_STCK_1Field
            End Get
            Set
                Me.sU_PL_STCK_1Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=77)>
        Public Property ST_UN_QTYY_1() As String
            Get
                Return Me.sT_UN_QTYY_1Field
            End Get
            Set
                Me.sT_UN_QTYY_1Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=78)>
        Public Property ST_UN_QTYY_1_ISO() As String
            Get
                Return Me.sT_UN_QTYY_1_ISOField
            End Get
            Set
                Me.sT_UN_QTYY_1_ISOField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=79)>
        Public Property UNITTYPE_1() As String
            Get
                Return Me.uNITTYPE_1Field
            End Get
            Set
                Me.uNITTYPE_1Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=80)>
        Public Property SU_PL_STCK_2() As String
            Get
                Return Me.sU_PL_STCK_2Field
            End Get
            Set
                Me.sU_PL_STCK_2Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=81)>
        Public Property ST_UN_QTYY_2() As String
            Get
                Return Me.sT_UN_QTYY_2Field
            End Get
            Set
                Me.sT_UN_QTYY_2Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=82)>
        Public Property ST_UN_QTYY_2_ISO() As String
            Get
                Return Me.sT_UN_QTYY_2_ISOField
            End Get
            Set
                Me.sT_UN_QTYY_2_ISOField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=83)>
        Public Property UNITTYPE_2() As String
            Get
                Return Me.uNITTYPE_2Field
            End Get
            Set
                Me.uNITTYPE_2Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=84)>
        Public Property STGE_TYPE_PC() As String
            Get
                Return Me.sTGE_TYPE_PCField
            End Get
            Set
                Me.sTGE_TYPE_PCField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=85)>
        Public Property STGE_BIN_PC() As String
            Get
                Return Me.sTGE_BIN_PCField
            End Get
            Set
                Me.sTGE_BIN_PCField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=86)>
        Public Property NO_PST_CHGNT() As String
            Get
                Return Me.nO_PST_CHGNTField
            End Get
            Set
                Me.nO_PST_CHGNTField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=87)>
        Public Property GR_NUMBER() As String
            Get
                Return Me.gR_NUMBERField
            End Get
            Set
                Me.gR_NUMBERField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=88)>
        Public Property STGE_TYPE_ST() As String
            Get
                Return Me.sTGE_TYPE_STField
            End Get
            Set
                Me.sTGE_TYPE_STField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=89)>
        Public Property STGE_BIN_ST() As String
            Get
                Return Me.sTGE_BIN_STField
            End Get
            Set
                Me.sTGE_BIN_STField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=90)>
        Public Property MATDOC_TR_CANCEL() As String
            Get
                Return Me.mATDOC_TR_CANCELField
            End Get
            Set
                Me.mATDOC_TR_CANCELField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=91)>
        Public Property MATITEM_TR_CANCEL() As String
            Get
                Return Me.mATITEM_TR_CANCELField
            End Get
            Set
                Me.mATITEM_TR_CANCELField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=92)>
        Public Property MATYEAR_TR_CANCEL() As String
            Get
                Return Me.mATYEAR_TR_CANCELField
            End Get
            Set
                Me.mATYEAR_TR_CANCELField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=93)>
        Public Property NO_TRANSFER_REQ() As String
            Get
                Return Me.nO_TRANSFER_REQField
            End Get
            Set
                Me.nO_TRANSFER_REQField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=94)>
        Public Property CO_BUSPROC() As String
            Get
                Return Me.cO_BUSPROCField
            End Get
            Set
                Me.cO_BUSPROCField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=95)>
        Public Property ACTTYPE() As String
            Get
                Return Me.aCTTYPEField
            End Get
            Set
                Me.aCTTYPEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=96)>
        Public Property SUPPL_VEND() As String
            Get
                Return Me.sUPPL_VENDField
            End Get
            Set
                Me.sUPPL_VENDField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=97)>
        Public Property MATERIAL_EXTERNAL() As String
            Get
                Return Me.mATERIAL_EXTERNALField
            End Get
            Set
                Me.mATERIAL_EXTERNALField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=98)>
        Public Property MATERIAL_GUID() As String
            Get
                Return Me.mATERIAL_GUIDField
            End Get
            Set
                Me.mATERIAL_GUIDField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=99)>
        Public Property MATERIAL_VERSION() As String
            Get
                Return Me.mATERIAL_VERSIONField
            End Get
            Set
                Me.mATERIAL_VERSIONField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=100)>
        Public Property MOVE_MAT_EXTERNAL() As String
            Get
                Return Me.mOVE_MAT_EXTERNALField
            End Get
            Set
                Me.mOVE_MAT_EXTERNALField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=101)>
        Public Property MOVE_MAT_GUID() As String
            Get
                Return Me.mOVE_MAT_GUIDField
            End Get
            Set
                Me.mOVE_MAT_GUIDField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=102)>
        Public Property MOVE_MAT_VERSION() As String
            Get
                Return Me.mOVE_MAT_VERSIONField
            End Get
            Set
                Me.mOVE_MAT_VERSIONField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=103)>
        Public Property FUNC_AREA() As String
            Get
                Return Me.fUNC_AREAField
            End Get
            Set
                Me.fUNC_AREAField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=104)>
        Public Property TR_PART_BA() As String
            Get
                Return Me.tR_PART_BAField
            End Get
            Set
                Me.tR_PART_BAField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=105)>
        Public Property PAR_COMPCO() As String
            Get
                Return Me.pAR_COMPCOField
            End Get
            Set
                Me.pAR_COMPCOField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=106)>
        Public Property E1BP2017_GM_ITEM_CREATE1() As MBGMCR03TypeIDOCE1MBGMCRE1BP2017_GM_ITEM_CREATEE1BP2017_GM_ITEM_CREATE1
            Get
                Return Me.e1BP2017_GM_ITEM_CREATE1Field
            End Get
            Set
                Me.e1BP2017_GM_ITEM_CREATE1Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property SEGMENT() As MBGMCR03TypeIDOCE1MBGMCRE1BP2017_GM_ITEM_CREATESEGMENT
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
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/GoodsMovement/v1" &
    "/types")>
    Partial Public Class MBGMCR03TypeIDOCE1MBGMCRE1BP2017_GM_ITEM_CREATEE1BP2017_GM_ITEM_CREATE1

        Private dELIV_NUMBField As String

        Private dELIV_ITEMField As String

        Private nB_SLIPSField As String

        Private nB_SLIPSXField As String

        Private gR_RCPTXField As String

        Private uNLOAD_PTXField As String

        Private sPEC_MVMTField As String

        Private gRANT_NBRField As String

        Private cMMT_ITEM_LONGField As String

        Private fUNC_AREA_LONGField As String

        Private lINE_IDField As String

        Private pARENT_IDField As String

        Private lINE_DEPTHField As String

        Private qUANTITYField As String

        Private bASE_UOMField As String

        Private lONGNUMField As String

        Private bUDGET_PERIODField As String

        Private eARMARKED_NUMBERField As String

        Private eARMARKED_ITEMField As String

        Private sTK_SEGMENTField As String

        Private mOVE_SEGMENTField As String

        Private sEGMENTField As MBGMCR03TypeIDOCE1MBGMCRE1BP2017_GM_ITEM_CREATEE1BP2017_GM_ITEM_CREATE1SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property DELIV_NUMB() As String
            Get
                Return Me.dELIV_NUMBField
            End Get
            Set
                Me.dELIV_NUMBField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public Property DELIV_ITEM() As String
            Get
                Return Me.dELIV_ITEMField
            End Get
            Set
                Me.dELIV_ITEMField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>
        Public Property NB_SLIPS() As String
            Get
                Return Me.nB_SLIPSField
            End Get
            Set
                Me.nB_SLIPSField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=3)>
        Public Property NB_SLIPSX() As String
            Get
                Return Me.nB_SLIPSXField
            End Get
            Set
                Me.nB_SLIPSXField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=4)>
        Public Property GR_RCPTX() As String
            Get
                Return Me.gR_RCPTXField
            End Get
            Set
                Me.gR_RCPTXField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=5)>
        Public Property UNLOAD_PTX() As String
            Get
                Return Me.uNLOAD_PTXField
            End Get
            Set
                Me.uNLOAD_PTXField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=6)>
        Public Property SPEC_MVMT() As String
            Get
                Return Me.sPEC_MVMTField
            End Get
            Set
                Me.sPEC_MVMTField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=7)>
        Public Property GRANT_NBR() As String
            Get
                Return Me.gRANT_NBRField
            End Get
            Set
                Me.gRANT_NBRField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=8)>
        Public Property CMMT_ITEM_LONG() As String
            Get
                Return Me.cMMT_ITEM_LONGField
            End Get
            Set
                Me.cMMT_ITEM_LONGField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=9)>
        Public Property FUNC_AREA_LONG() As String
            Get
                Return Me.fUNC_AREA_LONGField
            End Get
            Set
                Me.fUNC_AREA_LONGField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=10)>
        Public Property LINE_ID() As String
            Get
                Return Me.lINE_IDField
            End Get
            Set
                Me.lINE_IDField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=11)>
        Public Property PARENT_ID() As String
            Get
                Return Me.pARENT_IDField
            End Get
            Set
                Me.pARENT_IDField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=12)>
        Public Property LINE_DEPTH() As String
            Get
                Return Me.lINE_DEPTHField
            End Get
            Set
                Me.lINE_DEPTHField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=13)>
        Public Property QUANTITY() As String
            Get
                Return Me.qUANTITYField
            End Get
            Set
                Me.qUANTITYField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=14)>
        Public Property BASE_UOM() As String
            Get
                Return Me.bASE_UOMField
            End Get
            Set
                Me.bASE_UOMField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=15)>
        Public Property LONGNUM() As String
            Get
                Return Me.lONGNUMField
            End Get
            Set
                Me.lONGNUMField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=16)>
        Public Property BUDGET_PERIOD() As String
            Get
                Return Me.bUDGET_PERIODField
            End Get
            Set
                Me.bUDGET_PERIODField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=17)>
        Public Property EARMARKED_NUMBER() As String
            Get
                Return Me.eARMARKED_NUMBERField
            End Get
            Set
                Me.eARMARKED_NUMBERField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=18)>
        Public Property EARMARKED_ITEM() As String
            Get
                Return Me.eARMARKED_ITEMField
            End Get
            Set
                Me.eARMARKED_ITEMField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=19)>
        Public Property STK_SEGMENT() As String
            Get
                Return Me.sTK_SEGMENTField
            End Get
            Set
                Me.sTK_SEGMENTField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=20)>
        Public Property MOVE_SEGMENT() As String
            Get
                Return Me.mOVE_SEGMENTField
            End Get
            Set
                Me.mOVE_SEGMENTField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property SEGMENT() As MBGMCR03TypeIDOCE1MBGMCRE1BP2017_GM_ITEM_CREATEE1BP2017_GM_ITEM_CREATE1SEGMENT
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
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/GoodsMovement/v1" &
    "/types")>
    Public Enum MBGMCR03TypeIDOCE1MBGMCRE1BP2017_GM_ITEM_CREATEE1BP2017_GM_ITEM_CREATE1SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/GoodsMovement/v1" &
    "/types")>
    Public Enum MBGMCR03TypeIDOCE1MBGMCRE1BP2017_GM_ITEM_CREATESEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Diagnostics.DebuggerStepThroughAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/GoodsMovement/v1" &
    "/types")>
    Partial Public Class MBGMCR03TypeIDOCE1MBGMCRE1BP2017_GM_SERIALNUMBER

        Private mATDOC_ITMField As String

        Private sERIALNOField As String

        Private uIIField As String

        Private sEGMENTField As MBGMCR03TypeIDOCE1MBGMCRE1BP2017_GM_SERIALNUMBERSEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property MATDOC_ITM() As String
            Get
                Return Me.mATDOC_ITMField
            End Get
            Set
                Me.mATDOC_ITMField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public Property SERIALNO() As String
            Get
                Return Me.sERIALNOField
            End Get
            Set
                Me.sERIALNOField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>
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
        Public Property SEGMENT() As MBGMCR03TypeIDOCE1MBGMCRE1BP2017_GM_SERIALNUMBERSEGMENT
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
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/GoodsMovement/v1" &
    "/types")>
    Public Enum MBGMCR03TypeIDOCE1MBGMCRE1BP2017_GM_SERIALNUMBERSEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Diagnostics.DebuggerStepThroughAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/GoodsMovement/v1" &
    "/types")>
    Partial Public Class MBGMCR03TypeIDOCE1MBGMCR_SPE_E1BP2017_SERVICEPART_D

        Private lINE_IDField As String

        Private rET_AUTH_NUMBERField As String

        Private dELIV_NUMBERField As String

        Private dELIV_ITEMField As String

        Private hU_NUMBERField As String

        Private iNSPOUT_GUIDField As String

        Private eVENTField As String

        Private dATEField As String

        Private tIMEField As String

        Private zONLOField As String

        Private tIMESTAMPField As String

        Private sCRAP_INDICATORField As String

        Private kEEP_QUANTITYField As String

        Private gTS_STOCK_TYPEField As String

        Private mOVE_GTS_STOCK_TYPEField As String

        Private kEEP_QUANTITY_CONVERSIONField As String

        Private zERO_QUANTITYField As String

        Private nUMERATORField As String

        Private dENOMINATRField As String

        Private iNSP_DOC_NUMBField As String

        Private pCHG_TYPEField As String

        Private sEGMENTField As MBGMCR03TypeIDOCE1MBGMCR_SPE_E1BP2017_SERVICEPART_DSEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property LINE_ID() As String
            Get
                Return Me.lINE_IDField
            End Get
            Set
                Me.lINE_IDField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public Property RET_AUTH_NUMBER() As String
            Get
                Return Me.rET_AUTH_NUMBERField
            End Get
            Set
                Me.rET_AUTH_NUMBERField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>
        Public Property DELIV_NUMBER() As String
            Get
                Return Me.dELIV_NUMBERField
            End Get
            Set
                Me.dELIV_NUMBERField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=3)>
        Public Property DELIV_ITEM() As String
            Get
                Return Me.dELIV_ITEMField
            End Get
            Set
                Me.dELIV_ITEMField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=4)>
        Public Property HU_NUMBER() As String
            Get
                Return Me.hU_NUMBERField
            End Get
            Set
                Me.hU_NUMBERField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=5)>
        Public Property INSPOUT_GUID() As String
            Get
                Return Me.iNSPOUT_GUIDField
            End Get
            Set
                Me.iNSPOUT_GUIDField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=6)>
        Public Property [EVENT]() As String
            Get
                Return Me.eVENTField
            End Get
            Set
                Me.eVENTField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=7)>
        Public Property [DATE]() As String
            Get
                Return Me.dATEField
            End Get
            Set
                Me.dATEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=8)>
        Public Property TIME() As String
            Get
                Return Me.tIMEField
            End Get
            Set
                Me.tIMEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=9)>
        Public Property ZONLO() As String
            Get
                Return Me.zONLOField
            End Get
            Set
                Me.zONLOField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=10)>
        Public Property TIMESTAMP() As String
            Get
                Return Me.tIMESTAMPField
            End Get
            Set
                Me.tIMESTAMPField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=11)>
        Public Property SCRAP_INDICATOR() As String
            Get
                Return Me.sCRAP_INDICATORField
            End Get
            Set
                Me.sCRAP_INDICATORField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=12)>
        Public Property KEEP_QUANTITY() As String
            Get
                Return Me.kEEP_QUANTITYField
            End Get
            Set
                Me.kEEP_QUANTITYField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=13)>
        Public Property GTS_STOCK_TYPE() As String
            Get
                Return Me.gTS_STOCK_TYPEField
            End Get
            Set
                Me.gTS_STOCK_TYPEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=14)>
        Public Property MOVE_GTS_STOCK_TYPE() As String
            Get
                Return Me.mOVE_GTS_STOCK_TYPEField
            End Get
            Set
                Me.mOVE_GTS_STOCK_TYPEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=15)>
        Public Property KEEP_QUANTITY_CONVERSION() As String
            Get
                Return Me.kEEP_QUANTITY_CONVERSIONField
            End Get
            Set
                Me.kEEP_QUANTITY_CONVERSIONField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=16)>
        Public Property ZERO_QUANTITY() As String
            Get
                Return Me.zERO_QUANTITYField
            End Get
            Set
                Me.zERO_QUANTITYField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=17)>
        Public Property NUMERATOR() As String
            Get
                Return Me.nUMERATORField
            End Get
            Set
                Me.nUMERATORField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=18)>
        Public Property DENOMINATR() As String
            Get
                Return Me.dENOMINATRField
            End Get
            Set
                Me.dENOMINATRField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=19)>
        Public Property INSP_DOC_NUMB() As String
            Get
                Return Me.iNSP_DOC_NUMBField
            End Get
            Set
                Me.iNSP_DOC_NUMBField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=20)>
        Public Property PCHG_TYPE() As String
            Get
                Return Me.pCHG_TYPEField
            End Get
            Set
                Me.pCHG_TYPEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property SEGMENT() As MBGMCR03TypeIDOCE1MBGMCR_SPE_E1BP2017_SERVICEPART_DSEGMENT
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
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/GoodsMovement/v1" &
    "/types")>
    Public Enum MBGMCR03TypeIDOCE1MBGMCR_SPE_E1BP2017_SERVICEPART_DSEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Diagnostics.DebuggerStepThroughAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/GoodsMovement/v1" &
    "/types")>
    Partial Public Class MBGMCR03TypeIDOCE1MBGMCRE1BPPAREX

        Private sTRUCTUREField As String

        Private vALUEPART1Field As String

        Private vALUEPART2Field As String

        Private vALUEPART3Field As String

        Private vALUEPART4Field As String

        Private sEGMENTField As MBGMCR03TypeIDOCE1MBGMCRE1BPPAREXSEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property [STRUCTURE]() As String
            Get
                Return Me.sTRUCTUREField
            End Get
            Set
                Me.sTRUCTUREField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public Property VALUEPART1() As String
            Get
                Return Me.vALUEPART1Field
            End Get
            Set
                Me.vALUEPART1Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>
        Public Property VALUEPART2() As String
            Get
                Return Me.vALUEPART2Field
            End Get
            Set
                Me.vALUEPART2Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=3)>
        Public Property VALUEPART3() As String
            Get
                Return Me.vALUEPART3Field
            End Get
            Set
                Me.vALUEPART3Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=4)>
        Public Property VALUEPART4() As String
            Get
                Return Me.vALUEPART4Field
            End Get
            Set
                Me.vALUEPART4Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property SEGMENT() As MBGMCR03TypeIDOCE1MBGMCRE1BPPAREXSEGMENT
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
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/GoodsMovement/v1" &
    "/types")>
    Public Enum MBGMCR03TypeIDOCE1MBGMCRE1BPPAREXSEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/GoodsMovement/v1" &
    "/types")>
    Public Enum MBGMCR03TypeIDOCE1MBGMCRSEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/GoodsMovement/v1" &
    "/types")>
    Public Enum MBGMCR03TypeIDOCBEGIN

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Diagnostics.DebuggerStepThroughAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/GoodsMovement/v1" &
    "/types")>
    Partial Public Class SendGoodsMovementData

        Private sendGoodsMovementField As MBGMCR03Type

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property sendGoodsMovement() As MBGMCR03Type
            Get
                Return Me.sendGoodsMovementField
            End Get
            Set
                Me.sendGoodsMovementField = Value
            End Set
        End Property
    End Class


    <System.Diagnostics.DebuggerStepThroughAttribute(),
 System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),
 System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),
 System.ServiceModel.MessageContractAttribute(WrapperName:="sendGoodsMovement", WrapperNamespace:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/GoodsMovement/v1" &
    "", IsWrapped:=True)>
    Partial Public Class sendGoodsMovementRequest

        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/GoodsMovement/v1" &
        "/types", Order:=0),
     System.Xml.Serialization.XmlElementAttribute([Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/GoodsMovement/v1" &
        "/types")>
        Public context As TCContext

        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/GoodsMovement/v1" &
        "/types", Order:=1),
     System.Xml.Serialization.XmlElementAttribute([Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/GoodsMovement/v1" &
        "/types")>
        Public data As SendGoodsMovementData

        Public Sub New()
            MyBase.New
        End Sub

        Public Sub New(ByVal context As TCContext, ByVal data As SendGoodsMovementData)
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
    Partial Public Class sendGoodsMovementResponse

        Public Sub New()
            MyBase.New
        End Sub
    End Class

    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>
    Public Interface GoodsMovementConsumerChannel
        Inherits IGoodsMovementService, System.ServiceModel.IClientChannel
    End Interface

    <System.Diagnostics.DebuggerStepThroughAttribute(),
 System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>
    Partial Public Class GoodsMovementConsumerClient
        Inherits System.ServiceModel.ClientBase(Of IGoodsMovementService)
        Implements IGoodsMovementService

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
        Function sendGoodsMovement(ByVal request As sendGoodsMovementRequest) As sendGoodsMovementResponse Implements IGoodsMovementService.sendGoodsMovement
            Return MyBase.Channel.sendGoodsMovement(request)
        End Function

        Public Sub sendGoodsMovement(ByVal context As TCContext, ByVal data As SendGoodsMovementData)
            Dim inValue As sendGoodsMovementRequest = New sendGoodsMovementRequest()
            inValue.context = context
            inValue.data = data
            Dim retVal As sendGoodsMovementResponse = CType(Me, IGoodsMovementService).sendGoodsMovement(inValue)
        End Sub

        '<System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        'Function GoodsMovementConsumer_sendGoodsMovementAsync(ByVal request As sendGoodsMovementRequest) As System.Threading.Tasks.Task(Of sendGoodsMovementResponse) Implements GoodsMovementConsumer.sendGoodsMovementAsync
        '    Return MyBase.Channel.sendGoodsMovementAsync(request)
        'End Function

        'Public Function sendGoodsMovementAsync(ByVal context As TCContext, ByVal data As SendGoodsMovementData) As System.Threading.Tasks.Task(Of sendGoodsMovementResponse)
        '    Dim inValue As sendGoodsMovementRequest = New sendGoodsMovementRequest()
        '    inValue.context = context
        '    inValue.data = data
        '    Return CType(Me,GoodsMovementConsumer).sendGoodsMovementAsync(inValue)
        'End Function
    End Class

End Namespace
