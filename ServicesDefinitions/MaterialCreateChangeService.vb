Option Strict Off
Option Explicit On

Imports System.Runtime.Serialization
Imports System.Web.Services
Imports AppWSDL.together

<Assembly: System.Runtime.Serialization.ContractNamespaceAttribute("http://schemas.telekom.net/csdg_v01.02", ClrNamespace:="schemas.telekom.net.csdg_v01._02")>

Namespace MaterialCreateChange

    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),
 System.ServiceModel.ServiceContractAttribute(Name:="MaterialCreateChange", [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/MaterialCreateChange/v1")>
    Public Interface ImaterialCreateChange

        <System.ServiceModel.OperationContract(Action:="createOrChangeMaterial"),', ReplyAction:="*"
        System.ServiceModel.FaultContractAttribute(GetType(schemas.telekom.net.csdg_v01._02.TCTechnicalFaultInfo), Action:="createOrChangeMaterial", Name:="technicalFault", [Namespace]:="http://schemas.telekom.net/csdg_v01.02"),
        System.ServiceModel.XmlSerializerFormatAttribute()>
        Function createOrChangeMaterial(ByVal request As createOrChangeMaterialRequest) As createOrChangeMaterialResponse

        '<System.ServiceModel.OperationContractAttribute(Action:="createOrChangeMaterial", ReplyAction:="*")>
        'Function createOrChangeMaterialAsync(ByVal request As createOrChangeMaterialRequest) As System.Threading.Tasks.Task(Of createOrChangeMaterialResponse)
    End Interface


    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Diagnostics.DebuggerStepThroughAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/MaterialCreateCh" &
    "ange/v1/types")>
    Partial Public Class CreateOrChangeMaterialData

        Private createOrChangeMaterialField() As ZXMATM02TypeIDOC

        '''<remarks/>
        <System.Xml.Serialization.XmlArrayAttribute(Order:=0),
     System.Xml.Serialization.XmlArrayItemAttribute("IDOC", IsNullable:=False)>
        Public Property createOrChangeMaterial() As ZXMATM02TypeIDOC()
            Get
                Return Me.createOrChangeMaterialField
            End Get
            Set
                Me.createOrChangeMaterialField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Diagnostics.DebuggerStepThroughAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/MaterialCreateCh" &
    "ange/v1/types")>
    Partial Public Class ZXMATM02TypeIDOC

        Private eDI_DC40Field As ZXMATM02TypeIDOCEDI_DC40

        Private e1MARAMField() As ZXMATM02TypeIDOCE1MARAM

        Private e1UPSLINKField As ZXMATM02TypeIDOCE1UPSLINK

        Private bEGINField As ZXMATM02TypeIDOCBEGIN

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property EDI_DC40() As ZXMATM02TypeIDOCEDI_DC40
            Get
                Return Me.eDI_DC40Field
            End Get
            Set
                Me.eDI_DC40Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("E1MARAM", Order:=1)>
        Public Property E1MARAM() As ZXMATM02TypeIDOCE1MARAM()
            Get
                Return Me.e1MARAMField
            End Get
            Set
                Me.e1MARAMField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>
        Public Property E1UPSLINK() As ZXMATM02TypeIDOCE1UPSLINK
            Get
                Return Me.e1UPSLINKField
            End Get
            Set
                Me.e1UPSLINKField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property BEGIN() As ZXMATM02TypeIDOCBEGIN
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
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/MaterialCreateCh" &
    "ange/v1/types")>
    Partial Public Class ZXMATM02TypeIDOCEDI_DC40

        Private tABNAMField As String

        Private mANDTField As String

        Private dOCNUMField As String

        Private dOCRELField As String

        Private sTATUSField As String

        Private dIRECTField As ZXMATM02TypeIDOCEDI_DC40DIRECT

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

        Private sEGMENTField As ZXMATM02TypeIDOCEDI_DC40SEGMENT

        Public Sub New()
            MyBase.New
            Me.tABNAMField = "EDI_DC40"
            Me.iDOCTYPField = "MATMAS05"
            Me.cIMTYPField = "ZXMATM02"
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
        Public Property DIRECT() As ZXMATM02TypeIDOCEDI_DC40DIRECT
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
        Public Property SEGMENT() As ZXMATM02TypeIDOCEDI_DC40SEGMENT
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
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/MaterialCreateCh" &
    "ange/v1/types")>
    Public Enum ZXMATM02TypeIDOCEDI_DC40DIRECT

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
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/MaterialCreateCh" &
    "ange/v1/types")>
    Public Enum ZXMATM02TypeIDOCEDI_DC40SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Diagnostics.DebuggerStepThroughAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/MaterialCreateCh" &
    "ange/v1/types")>
    Partial Public Class ZXMATM02TypeIDOCE1MARAM

        Private mSGFNField As String

        Private mATNRField As String

        Private eRSDAField As String

        Private eRNAMField As String

        Private lAEDAField As String

        Private aENAMField As String

        Private pSTATField As String

        Private lVORMField As String

        Private mTARTField As String

        Private mBRSHField As String

        Private mATKLField As String

        Private bISMTField As String

        Private mEINSField As String

        Private bSTMEField As String

        Private zEINRField As String

        Private zEIARField As String

        Private zEIVRField As String

        Private zEIFOField As String

        Private aESZNField As String

        Private bLATTField As String

        Private bLANZField As String

        Private fERTHField As String

        Private fORMTField As String

        Private gROESField As String

        Private wRKSTField As String

        Private nORMTField As String

        Private lABORField As String

        Private eKWSLField As String

        Private bRGEWField As String

        Private nTGEWField As String

        Private gEWEIField As String

        Private vOLUMField As String

        Private vOLEHField As String

        Private bEHVOField As String

        Private rAUBEField As String

        Private tEMPBField As String

        Private tRAGRField As String

        Private sTOFFField As String

        Private sPARTField As String

        Private kUNNRField As String

        Private wESCHField As String

        Private bWVORField As String

        Private bWSCLField As String

        Private sAISOField As String

        Private eTIARField As String

        Private eTIFOField As String

        Private eAN11Field As String

        Private nUMTPField As String

        Private lAENGField As String

        Private bREITField As String

        Private hOEHEField As String

        Private mEABMField As String

        Private pRDHAField As String

        Private cADKZField As String

        Private eRGEWField As String

        Private eRGEIField As String

        Private eRVOLField As String

        Private eRVOEField As String

        Private gEWTOField As String

        Private vOLTOField As String

        Private vABMEField As String

        Private kZKFGField As String

        Private xCHPFField As String

        Private vHARTField As String

        Private fUELGField As String

        Private sTFAKField As String

        Private mAGRVField As String

        Private bEGRUField As String

        Private qMPURField As String

        Private rBNRMField As String

        Private mHDRZField As String

        Private mHDHBField As String

        Private mHDLPField As String

        Private vPSTAField As String

        Private eXTWGField As String

        Private mSTAEField As String

        Private mSTAVField As String

        Private mSTDEField As String

        Private mSTDVField As String

        Private kZUMWField As String

        Private kOSCHField As String

        Private nRFHGField As String

        Private mFRPNField As String

        Private mFRNRField As String

        Private bMATNField As String

        Private mPROFField As String

        Private pROFLField As String

        Private iHIVIField As String

        Private iLOOSField As String

        Private kZGVHField As String

        Private xGCHPField As String

        Private cOMPLField As String

        Private kZEFFField As String

        Private rDMHDField As String

        Private iPRKZField As String

        Private pRZUSField As String

        Private mTPOS_MARAField As String

        Private gEWTO_NEWField As String

        Private vOLTO_NEWField As String

        Private wRKST_NEWField As String

        Private aENNRField As String

        Private mATFIField As String

        Private cMRELField As String

        Private sATNRField As String

        Private sLED_BBDField As String

        Private gTIN_VARIANTField As String

        Private gENNRField As String

        Private sERLVField As String

        Private rMATPField As String

        Private gDS_RELEVANTField As String

        Private mCONDField As String

        Private rETDELCField As String

        Private lOGLEV_RETOField As String

        Private nSNIDField As String

        Private wEORAField As String

        Private _CWM_TOLGRField As String

        Private _CWM_TARAField As String

        Private _CWM_TARUMField As String

        Private pACKCODEField As String

        Private dG_PACK_STATUSField As String

        Private aNPField As String

        Private zE1OCLFField As ZXMATM02TypeIDOCE1MARAMZE1OCLF

        Private e1MARA1Field As ZXMATM02TypeIDOCE1MARAME1MARA1

        Private e1MAKTMField() As ZXMATM02TypeIDOCE1MARAME1MAKTM

        Private e1MARCMField() As ZXMATM02TypeIDOCE1MARAME1MARCM

        Private e1MARMMField() As ZXMATM02TypeIDOCE1MARAME1MARMM

        Private e1MBEWMField() As ZXMATM02TypeIDOCE1MARAME1MBEWM

        Private e1MLGNMField() As ZXMATM02TypeIDOCE1MARAME1MLGNM

        Private e1MVKEMField() As ZXMATM02TypeIDOCE1MARAME1MVKEM

        Private e1MLANMField() As ZXMATM02TypeIDOCE1MARAME1MLANM

        Private e1MTXHMField() As ZXMATM02TypeIDOCE1MARAME1MTXHM

        Private e1CUCFGField() As ZXMATM02TypeIDOCE1MARAME1CUCFG

        Private sEGMENTField As ZXMATM02TypeIDOCE1MARAMSEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property MSGFN() As String
            Get
                Return Me.mSGFNField
            End Get
            Set
                Me.mSGFNField = Value
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
        Public Property ERSDA() As String
            Get
                Return Me.eRSDAField
            End Get
            Set
                Me.eRSDAField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=3)>
        Public Property ERNAM() As String
            Get
                Return Me.eRNAMField
            End Get
            Set
                Me.eRNAMField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=4)>
        Public Property LAEDA() As String
            Get
                Return Me.lAEDAField
            End Get
            Set
                Me.lAEDAField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=5)>
        Public Property AENAM() As String
            Get
                Return Me.aENAMField
            End Get
            Set
                Me.aENAMField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=6)>
        Public Property PSTAT() As String
            Get
                Return Me.pSTATField
            End Get
            Set
                Me.pSTATField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=7)>
        Public Property LVORM() As String
            Get
                Return Me.lVORMField
            End Get
            Set
                Me.lVORMField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=8)>
        Public Property MTART() As String
            Get
                Return Me.mTARTField
            End Get
            Set
                Me.mTARTField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=9)>
        Public Property MBRSH() As String
            Get
                Return Me.mBRSHField
            End Get
            Set
                Me.mBRSHField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=10)>
        Public Property MATKL() As String
            Get
                Return Me.mATKLField
            End Get
            Set
                Me.mATKLField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=11)>
        Public Property BISMT() As String
            Get
                Return Me.bISMTField
            End Get
            Set
                Me.bISMTField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=12)>
        Public Property MEINS() As String
            Get
                Return Me.mEINSField
            End Get
            Set
                Me.mEINSField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=13)>
        Public Property BSTME() As String
            Get
                Return Me.bSTMEField
            End Get
            Set
                Me.bSTMEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=14)>
        Public Property ZEINR() As String
            Get
                Return Me.zEINRField
            End Get
            Set
                Me.zEINRField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=15)>
        Public Property ZEIAR() As String
            Get
                Return Me.zEIARField
            End Get
            Set
                Me.zEIARField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=16)>
        Public Property ZEIVR() As String
            Get
                Return Me.zEIVRField
            End Get
            Set
                Me.zEIVRField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=17)>
        Public Property ZEIFO() As String
            Get
                Return Me.zEIFOField
            End Get
            Set
                Me.zEIFOField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=18)>
        Public Property AESZN() As String
            Get
                Return Me.aESZNField
            End Get
            Set
                Me.aESZNField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=19)>
        Public Property BLATT() As String
            Get
                Return Me.bLATTField
            End Get
            Set
                Me.bLATTField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=20)>
        Public Property BLANZ() As String
            Get
                Return Me.bLANZField
            End Get
            Set
                Me.bLANZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=21)>
        Public Property FERTH() As String
            Get
                Return Me.fERTHField
            End Get
            Set
                Me.fERTHField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=22)>
        Public Property FORMT() As String
            Get
                Return Me.fORMTField
            End Get
            Set
                Me.fORMTField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=23)>
        Public Property GROES() As String
            Get
                Return Me.gROESField
            End Get
            Set
                Me.gROESField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=24)>
        Public Property WRKST() As String
            Get
                Return Me.wRKSTField
            End Get
            Set
                Me.wRKSTField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=25)>
        Public Property NORMT() As String
            Get
                Return Me.nORMTField
            End Get
            Set
                Me.nORMTField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=26)>
        Public Property LABOR() As String
            Get
                Return Me.lABORField
            End Get
            Set
                Me.lABORField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=27)>
        Public Property EKWSL() As String
            Get
                Return Me.eKWSLField
            End Get
            Set
                Me.eKWSLField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=28)>
        Public Property BRGEW() As String
            Get
                Return Me.bRGEWField
            End Get
            Set
                Me.bRGEWField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=29)>
        Public Property NTGEW() As String
            Get
                Return Me.nTGEWField
            End Get
            Set
                Me.nTGEWField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=30)>
        Public Property GEWEI() As String
            Get
                Return Me.gEWEIField
            End Get
            Set
                Me.gEWEIField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=31)>
        Public Property VOLUM() As String
            Get
                Return Me.vOLUMField
            End Get
            Set
                Me.vOLUMField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=32)>
        Public Property VOLEH() As String
            Get
                Return Me.vOLEHField
            End Get
            Set
                Me.vOLEHField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=33)>
        Public Property BEHVO() As String
            Get
                Return Me.bEHVOField
            End Get
            Set
                Me.bEHVOField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=34)>
        Public Property RAUBE() As String
            Get
                Return Me.rAUBEField
            End Get
            Set
                Me.rAUBEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=35)>
        Public Property TEMPB() As String
            Get
                Return Me.tEMPBField
            End Get
            Set
                Me.tEMPBField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=36)>
        Public Property TRAGR() As String
            Get
                Return Me.tRAGRField
            End Get
            Set
                Me.tRAGRField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=37)>
        Public Property STOFF() As String
            Get
                Return Me.sTOFFField
            End Get
            Set
                Me.sTOFFField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=38)>
        Public Property SPART() As String
            Get
                Return Me.sPARTField
            End Get
            Set
                Me.sPARTField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=39)>
        Public Property KUNNR() As String
            Get
                Return Me.kUNNRField
            End Get
            Set
                Me.kUNNRField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=40)>
        Public Property WESCH() As String
            Get
                Return Me.wESCHField
            End Get
            Set
                Me.wESCHField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=41)>
        Public Property BWVOR() As String
            Get
                Return Me.bWVORField
            End Get
            Set
                Me.bWVORField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=42)>
        Public Property BWSCL() As String
            Get
                Return Me.bWSCLField
            End Get
            Set
                Me.bWSCLField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=43)>
        Public Property SAISO() As String
            Get
                Return Me.sAISOField
            End Get
            Set
                Me.sAISOField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=44)>
        Public Property ETIAR() As String
            Get
                Return Me.eTIARField
            End Get
            Set
                Me.eTIARField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=45)>
        Public Property ETIFO() As String
            Get
                Return Me.eTIFOField
            End Get
            Set
                Me.eTIFOField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=46)>
        Public Property EAN11() As String
            Get
                Return Me.eAN11Field
            End Get
            Set
                Me.eAN11Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=47)>
        Public Property NUMTP() As String
            Get
                Return Me.nUMTPField
            End Get
            Set
                Me.nUMTPField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=48)>
        Public Property LAENG() As String
            Get
                Return Me.lAENGField
            End Get
            Set
                Me.lAENGField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=49)>
        Public Property BREIT() As String
            Get
                Return Me.bREITField
            End Get
            Set
                Me.bREITField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=50)>
        Public Property HOEHE() As String
            Get
                Return Me.hOEHEField
            End Get
            Set
                Me.hOEHEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=51)>
        Public Property MEABM() As String
            Get
                Return Me.mEABMField
            End Get
            Set
                Me.mEABMField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=52)>
        Public Property PRDHA() As String
            Get
                Return Me.pRDHAField
            End Get
            Set
                Me.pRDHAField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=53)>
        Public Property CADKZ() As String
            Get
                Return Me.cADKZField
            End Get
            Set
                Me.cADKZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=54)>
        Public Property ERGEW() As String
            Get
                Return Me.eRGEWField
            End Get
            Set
                Me.eRGEWField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=55)>
        Public Property ERGEI() As String
            Get
                Return Me.eRGEIField
            End Get
            Set
                Me.eRGEIField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=56)>
        Public Property ERVOL() As String
            Get
                Return Me.eRVOLField
            End Get
            Set
                Me.eRVOLField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=57)>
        Public Property ERVOE() As String
            Get
                Return Me.eRVOEField
            End Get
            Set
                Me.eRVOEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=58)>
        Public Property GEWTO() As String
            Get
                Return Me.gEWTOField
            End Get
            Set
                Me.gEWTOField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=59)>
        Public Property VOLTO() As String
            Get
                Return Me.vOLTOField
            End Get
            Set
                Me.vOLTOField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=60)>
        Public Property VABME() As String
            Get
                Return Me.vABMEField
            End Get
            Set
                Me.vABMEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=61)>
        Public Property KZKFG() As String
            Get
                Return Me.kZKFGField
            End Get
            Set
                Me.kZKFGField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=62)>
        Public Property XCHPF() As String
            Get
                Return Me.xCHPFField
            End Get
            Set
                Me.xCHPFField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=63)>
        Public Property VHART() As String
            Get
                Return Me.vHARTField
            End Get
            Set
                Me.vHARTField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=64)>
        Public Property FUELG() As String
            Get
                Return Me.fUELGField
            End Get
            Set
                Me.fUELGField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=65)>
        Public Property STFAK() As String
            Get
                Return Me.sTFAKField
            End Get
            Set
                Me.sTFAKField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=66)>
        Public Property MAGRV() As String
            Get
                Return Me.mAGRVField
            End Get
            Set
                Me.mAGRVField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=67)>
        Public Property BEGRU() As String
            Get
                Return Me.bEGRUField
            End Get
            Set
                Me.bEGRUField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=68)>
        Public Property QMPUR() As String
            Get
                Return Me.qMPURField
            End Get
            Set
                Me.qMPURField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=69)>
        Public Property RBNRM() As String
            Get
                Return Me.rBNRMField
            End Get
            Set
                Me.rBNRMField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=70)>
        Public Property MHDRZ() As String
            Get
                Return Me.mHDRZField
            End Get
            Set
                Me.mHDRZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=71)>
        Public Property MHDHB() As String
            Get
                Return Me.mHDHBField
            End Get
            Set
                Me.mHDHBField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=72)>
        Public Property MHDLP() As String
            Get
                Return Me.mHDLPField
            End Get
            Set
                Me.mHDLPField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=73)>
        Public Property VPSTA() As String
            Get
                Return Me.vPSTAField
            End Get
            Set
                Me.vPSTAField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=74)>
        Public Property EXTWG() As String
            Get
                Return Me.eXTWGField
            End Get
            Set
                Me.eXTWGField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=75)>
        Public Property MSTAE() As String
            Get
                Return Me.mSTAEField
            End Get
            Set
                Me.mSTAEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=76)>
        Public Property MSTAV() As String
            Get
                Return Me.mSTAVField
            End Get
            Set
                Me.mSTAVField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=77)>
        Public Property MSTDE() As String
            Get
                Return Me.mSTDEField
            End Get
            Set
                Me.mSTDEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=78)>
        Public Property MSTDV() As String
            Get
                Return Me.mSTDVField
            End Get
            Set
                Me.mSTDVField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=79)>
        Public Property KZUMW() As String
            Get
                Return Me.kZUMWField
            End Get
            Set
                Me.kZUMWField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=80)>
        Public Property KOSCH() As String
            Get
                Return Me.kOSCHField
            End Get
            Set
                Me.kOSCHField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=81)>
        Public Property NRFHG() As String
            Get
                Return Me.nRFHGField
            End Get
            Set
                Me.nRFHGField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=82)>
        Public Property MFRPN() As String
            Get
                Return Me.mFRPNField
            End Get
            Set
                Me.mFRPNField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=83)>
        Public Property MFRNR() As String
            Get
                Return Me.mFRNRField
            End Get
            Set
                Me.mFRNRField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=84)>
        Public Property BMATN() As String
            Get
                Return Me.bMATNField
            End Get
            Set
                Me.bMATNField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=85)>
        Public Property MPROF() As String
            Get
                Return Me.mPROFField
            End Get
            Set
                Me.mPROFField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=86)>
        Public Property PROFL() As String
            Get
                Return Me.pROFLField
            End Get
            Set
                Me.pROFLField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=87)>
        Public Property IHIVI() As String
            Get
                Return Me.iHIVIField
            End Get
            Set
                Me.iHIVIField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=88)>
        Public Property ILOOS() As String
            Get
                Return Me.iLOOSField
            End Get
            Set
                Me.iLOOSField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=89)>
        Public Property KZGVH() As String
            Get
                Return Me.kZGVHField
            End Get
            Set
                Me.kZGVHField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=90)>
        Public Property XGCHP() As String
            Get
                Return Me.xGCHPField
            End Get
            Set
                Me.xGCHPField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=91)>
        Public Property COMPL() As String
            Get
                Return Me.cOMPLField
            End Get
            Set
                Me.cOMPLField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=92)>
        Public Property KZEFF() As String
            Get
                Return Me.kZEFFField
            End Get
            Set
                Me.kZEFFField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=93)>
        Public Property RDMHD() As String
            Get
                Return Me.rDMHDField
            End Get
            Set
                Me.rDMHDField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=94)>
        Public Property IPRKZ() As String
            Get
                Return Me.iPRKZField
            End Get
            Set
                Me.iPRKZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=95)>
        Public Property PRZUS() As String
            Get
                Return Me.pRZUSField
            End Get
            Set
                Me.pRZUSField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=96)>
        Public Property MTPOS_MARA() As String
            Get
                Return Me.mTPOS_MARAField
            End Get
            Set
                Me.mTPOS_MARAField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=97)>
        Public Property GEWTO_NEW() As String
            Get
                Return Me.gEWTO_NEWField
            End Get
            Set
                Me.gEWTO_NEWField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=98)>
        Public Property VOLTO_NEW() As String
            Get
                Return Me.vOLTO_NEWField
            End Get
            Set
                Me.vOLTO_NEWField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=99)>
        Public Property WRKST_NEW() As String
            Get
                Return Me.wRKST_NEWField
            End Get
            Set
                Me.wRKST_NEWField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=100)>
        Public Property AENNR() As String
            Get
                Return Me.aENNRField
            End Get
            Set
                Me.aENNRField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=101)>
        Public Property MATFI() As String
            Get
                Return Me.mATFIField
            End Get
            Set
                Me.mATFIField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=102)>
        Public Property CMREL() As String
            Get
                Return Me.cMRELField
            End Get
            Set
                Me.cMRELField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=103)>
        Public Property SATNR() As String
            Get
                Return Me.sATNRField
            End Get
            Set
                Me.sATNRField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=104)>
        Public Property SLED_BBD() As String
            Get
                Return Me.sLED_BBDField
            End Get
            Set
                Me.sLED_BBDField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=105)>
        Public Property GTIN_VARIANT() As String
            Get
                Return Me.gTIN_VARIANTField
            End Get
            Set
                Me.gTIN_VARIANTField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=106)>
        Public Property GENNR() As String
            Get
                Return Me.gENNRField
            End Get
            Set
                Me.gENNRField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=107)>
        Public Property SERLV() As String
            Get
                Return Me.sERLVField
            End Get
            Set
                Me.sERLVField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=108)>
        Public Property RMATP() As String
            Get
                Return Me.rMATPField
            End Get
            Set
                Me.rMATPField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=109)>
        Public Property GDS_RELEVANT() As String
            Get
                Return Me.gDS_RELEVANTField
            End Get
            Set
                Me.gDS_RELEVANTField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=110)>
        Public Property MCOND() As String
            Get
                Return Me.mCONDField
            End Get
            Set
                Me.mCONDField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=111)>
        Public Property RETDELC() As String
            Get
                Return Me.rETDELCField
            End Get
            Set
                Me.rETDELCField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=112)>
        Public Property LOGLEV_RETO() As String
            Get
                Return Me.lOGLEV_RETOField
            End Get
            Set
                Me.lOGLEV_RETOField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=113)>
        Public Property NSNID() As String
            Get
                Return Me.nSNIDField
            End Get
            Set
                Me.nSNIDField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=114)>
        Public Property WEORA() As String
            Get
                Return Me.wEORAField
            End Get
            Set
                Me.wEORAField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("_-CWM_-TOLGR", Order:=115)>
        Public Property _CWM_TOLGR() As String
            Get
                Return Me._CWM_TOLGRField
            End Get
            Set
                Me._CWM_TOLGRField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("_-CWM_-TARA", Order:=116)>
        Public Property _CWM_TARA() As String
            Get
                Return Me._CWM_TARAField
            End Get
            Set
                Me._CWM_TARAField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("_-CWM_-TARUM", Order:=117)>
        Public Property _CWM_TARUM() As String
            Get
                Return Me._CWM_TARUMField
            End Get
            Set
                Me._CWM_TARUMField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=118)>
        Public Property PACKCODE() As String
            Get
                Return Me.pACKCODEField
            End Get
            Set
                Me.pACKCODEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=119)>
        Public Property DG_PACK_STATUS() As String
            Get
                Return Me.dG_PACK_STATUSField
            End Get
            Set
                Me.dG_PACK_STATUSField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=120)>
        Public Property ANP() As String
            Get
                Return Me.aNPField
            End Get
            Set
                Me.aNPField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=121)>
        Public Property ZE1OCLF() As ZXMATM02TypeIDOCE1MARAMZE1OCLF
            Get
                Return Me.zE1OCLFField
            End Get
            Set
                Me.zE1OCLFField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=122)>
        Public Property E1MARA1() As ZXMATM02TypeIDOCE1MARAME1MARA1
            Get
                Return Me.e1MARA1Field
            End Get
            Set
                Me.e1MARA1Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("E1MAKTM", Order:=123)>
        Public Property E1MAKTM() As ZXMATM02TypeIDOCE1MARAME1MAKTM()
            Get
                Return Me.e1MAKTMField
            End Get
            Set
                Me.e1MAKTMField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("E1MARCM", Order:=124)>
        Public Property E1MARCM() As ZXMATM02TypeIDOCE1MARAME1MARCM()
            Get
                Return Me.e1MARCMField
            End Get
            Set
                Me.e1MARCMField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("E1MARMM", Order:=125)>
        Public Property E1MARMM() As ZXMATM02TypeIDOCE1MARAME1MARMM()
            Get
                Return Me.e1MARMMField
            End Get
            Set
                Me.e1MARMMField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("E1MBEWM", Order:=126)>
        Public Property E1MBEWM() As ZXMATM02TypeIDOCE1MARAME1MBEWM()
            Get
                Return Me.e1MBEWMField
            End Get
            Set
                Me.e1MBEWMField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("E1MLGNM", Order:=127)>
        Public Property E1MLGNM() As ZXMATM02TypeIDOCE1MARAME1MLGNM()
            Get
                Return Me.e1MLGNMField
            End Get
            Set
                Me.e1MLGNMField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("E1MVKEM", Order:=128)>
        Public Property E1MVKEM() As ZXMATM02TypeIDOCE1MARAME1MVKEM()
            Get
                Return Me.e1MVKEMField
            End Get
            Set
                Me.e1MVKEMField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("E1MLANM", Order:=129)>
        Public Property E1MLANM() As ZXMATM02TypeIDOCE1MARAME1MLANM()
            Get
                Return Me.e1MLANMField
            End Get
            Set
                Me.e1MLANMField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("E1MTXHM", Order:=130)>
        Public Property E1MTXHM() As ZXMATM02TypeIDOCE1MARAME1MTXHM()
            Get
                Return Me.e1MTXHMField
            End Get
            Set
                Me.e1MTXHMField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("E1CUCFG", Order:=131)>
        Public Property E1CUCFG() As ZXMATM02TypeIDOCE1MARAME1CUCFG()
            Get
                Return Me.e1CUCFGField
            End Get
            Set
                Me.e1CUCFGField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property SEGMENT() As ZXMATM02TypeIDOCE1MARAMSEGMENT
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
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/MaterialCreateCh" &
    "ange/v1/types")>
    Partial Public Class ZXMATM02TypeIDOCE1MARAMZE1OCLF

        Private mSGFNField As String

        Private oBTABField As String

        Private oBJEKField As String

        Private kLARTField As String

        Private mAFIDField As String

        Private oBJECT_TABLEField As String

        Private zE1KSSKField() As ZXMATM02TypeIDOCE1MARAMZE1OCLFZE1KSSK

        Private zE1AUSPField() As ZXMATM02TypeIDOCE1MARAMZE1OCLFZE1AUSP

        Private zE1DATEField As ZXMATM02TypeIDOCE1MARAMZE1OCLFZE1DATE

        Private sEGMENTField As ZXMATM02TypeIDOCE1MARAMZE1OCLFSEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property MSGFN() As String
            Get
                Return Me.mSGFNField
            End Get
            Set
                Me.mSGFNField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public Property OBTAB() As String
            Get
                Return Me.oBTABField
            End Get
            Set
                Me.oBTABField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>
        Public Property OBJEK() As String
            Get
                Return Me.oBJEKField
            End Get
            Set
                Me.oBJEKField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=3)>
        Public Property KLART() As String
            Get
                Return Me.kLARTField
            End Get
            Set
                Me.kLARTField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=4)>
        Public Property MAFID() As String
            Get
                Return Me.mAFIDField
            End Get
            Set
                Me.mAFIDField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=5)>
        Public Property OBJECT_TABLE() As String
            Get
                Return Me.oBJECT_TABLEField
            End Get
            Set
                Me.oBJECT_TABLEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("ZE1KSSK", Order:=6)>
        Public Property ZE1KSSK() As ZXMATM02TypeIDOCE1MARAMZE1OCLFZE1KSSK()
            Get
                Return Me.zE1KSSKField
            End Get
            Set
                Me.zE1KSSKField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("ZE1AUSP", Order:=7)>
        Public Property ZE1AUSP() As ZXMATM02TypeIDOCE1MARAMZE1OCLFZE1AUSP()
            Get
                Return Me.zE1AUSPField
            End Get
            Set
                Me.zE1AUSPField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=8)>
        Public Property ZE1DATE() As ZXMATM02TypeIDOCE1MARAMZE1OCLFZE1DATE
            Get
                Return Me.zE1DATEField
            End Get
            Set
                Me.zE1DATEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property SEGMENT() As ZXMATM02TypeIDOCE1MARAMZE1OCLFSEGMENT
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
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/MaterialCreateCh" &
    "ange/v1/types")>
    Partial Public Class ZXMATM02TypeIDOCE1MARAMZE1OCLFZE1KSSK

        Private mSGFNField As String

        Private cLASSField As String

        Private aENNRField As String

        Private dATUVField As String

        Private sTATUField As String

        Private sTDCLField As String

        Private sEGMENTField As ZXMATM02TypeIDOCE1MARAMZE1OCLFZE1KSSKSEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property MSGFN() As String
            Get
                Return Me.mSGFNField
            End Get
            Set
                Me.mSGFNField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public Property [CLASS]() As String
            Get
                Return Me.cLASSField
            End Get
            Set
                Me.cLASSField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>
        Public Property AENNR() As String
            Get
                Return Me.aENNRField
            End Get
            Set
                Me.aENNRField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=3)>
        Public Property DATUV() As String
            Get
                Return Me.dATUVField
            End Get
            Set
                Me.dATUVField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=4)>
        Public Property STATU() As String
            Get
                Return Me.sTATUField
            End Get
            Set
                Me.sTATUField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=5)>
        Public Property STDCL() As String
            Get
                Return Me.sTDCLField
            End Get
            Set
                Me.sTDCLField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property SEGMENT() As ZXMATM02TypeIDOCE1MARAMZE1OCLFZE1KSSKSEGMENT
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
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/MaterialCreateCh" &
    "ange/v1/types")>
    Public Enum ZXMATM02TypeIDOCE1MARAMZE1OCLFZE1KSSKSEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Diagnostics.DebuggerStepThroughAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/MaterialCreateCh" &
    "ange/v1/types")>
    Partial Public Class ZXMATM02TypeIDOCE1MARAMZE1OCLFZE1AUSP

        Private mSGFNField As String

        Private aTNAMField As String

        Private aENNRField As String

        Private dATUVField As String

        Private aTWRTField As String

        Private aTFLVField As String

        Private aTAWEField As String

        Private aTFLBField As String

        Private aTAW1Field As String

        Private aTCODField As String

        Private aTTLVField As String

        Private aTTLBField As String

        Private aTPRZField As String

        Private aTINCField As String

        Private aTAUTField As String

        Private aTIMBField As String

        Private aTZISField As String

        Private uDEF_CHARField As String

        Private sEGMENTField As ZXMATM02TypeIDOCE1MARAMZE1OCLFZE1AUSPSEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property MSGFN() As String
            Get
                Return Me.mSGFNField
            End Get
            Set
                Me.mSGFNField = Value
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
        Public Property AENNR() As String
            Get
                Return Me.aENNRField
            End Get
            Set
                Me.aENNRField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=3)>
        Public Property DATUV() As String
            Get
                Return Me.dATUVField
            End Get
            Set
                Me.dATUVField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=4)>
        Public Property ATWRT() As String
            Get
                Return Me.aTWRTField
            End Get
            Set
                Me.aTWRTField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=5)>
        Public Property ATFLV() As String
            Get
                Return Me.aTFLVField
            End Get
            Set
                Me.aTFLVField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=6)>
        Public Property ATAWE() As String
            Get
                Return Me.aTAWEField
            End Get
            Set
                Me.aTAWEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=7)>
        Public Property ATFLB() As String
            Get
                Return Me.aTFLBField
            End Get
            Set
                Me.aTFLBField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=8)>
        Public Property ATAW1() As String
            Get
                Return Me.aTAW1Field
            End Get
            Set
                Me.aTAW1Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=9)>
        Public Property ATCOD() As String
            Get
                Return Me.aTCODField
            End Get
            Set
                Me.aTCODField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=10)>
        Public Property ATTLV() As String
            Get
                Return Me.aTTLVField
            End Get
            Set
                Me.aTTLVField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=11)>
        Public Property ATTLB() As String
            Get
                Return Me.aTTLBField
            End Get
            Set
                Me.aTTLBField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=12)>
        Public Property ATPRZ() As String
            Get
                Return Me.aTPRZField
            End Get
            Set
                Me.aTPRZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=13)>
        Public Property ATINC() As String
            Get
                Return Me.aTINCField
            End Get
            Set
                Me.aTINCField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=14)>
        Public Property ATAUT() As String
            Get
                Return Me.aTAUTField
            End Get
            Set
                Me.aTAUTField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=15)>
        Public Property ATIMB() As String
            Get
                Return Me.aTIMBField
            End Get
            Set
                Me.aTIMBField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=16)>
        Public Property ATZIS() As String
            Get
                Return Me.aTZISField
            End Get
            Set
                Me.aTZISField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=17)>
        Public Property UDEF_CHAR() As String
            Get
                Return Me.uDEF_CHARField
            End Get
            Set
                Me.uDEF_CHARField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property SEGMENT() As ZXMATM02TypeIDOCE1MARAMZE1OCLFZE1AUSPSEGMENT
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
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/MaterialCreateCh" &
    "ange/v1/types")>
    Public Enum ZXMATM02TypeIDOCE1MARAMZE1OCLFZE1AUSPSEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Diagnostics.DebuggerStepThroughAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/MaterialCreateCh" &
    "ange/v1/types")>
    Partial Public Class ZXMATM02TypeIDOCE1MARAMZE1OCLFZE1DATE

        Private mSGFNField As String

        Private kEY_DATEField As String

        Private aENNRField As String

        Private eFFECTIVITYField As String

        Private sEGMENTField As ZXMATM02TypeIDOCE1MARAMZE1OCLFZE1DATESEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property MSGFN() As String
            Get
                Return Me.mSGFNField
            End Get
            Set
                Me.mSGFNField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public Property KEY_DATE() As String
            Get
                Return Me.kEY_DATEField
            End Get
            Set
                Me.kEY_DATEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>
        Public Property AENNR() As String
            Get
                Return Me.aENNRField
            End Get
            Set
                Me.aENNRField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=3)>
        Public Property EFFECTIVITY() As String
            Get
                Return Me.eFFECTIVITYField
            End Get
            Set
                Me.eFFECTIVITYField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property SEGMENT() As ZXMATM02TypeIDOCE1MARAMZE1OCLFZE1DATESEGMENT
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
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/MaterialCreateCh" &
    "ange/v1/types")>
    Public Enum ZXMATM02TypeIDOCE1MARAMZE1OCLFZE1DATESEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/MaterialCreateCh" &
    "ange/v1/types")>
    Public Enum ZXMATM02TypeIDOCE1MARAMZE1OCLFSEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Diagnostics.DebuggerStepThroughAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/MaterialCreateCh" &
    "ange/v1/types")>
    Partial Public Class ZXMATM02TypeIDOCE1MARAME1MARA1

        Private mATNR_EXTERNALField As String

        Private mATNR_VERSIONField As String

        Private mATNR_GUIDField As String

        Private bMATN_EXTERNALField As String

        Private bMATN_VERSIONField As String

        Private bMATN_GUIDField As String

        Private sTOFF_EXTERNALField As String

        Private sTOFF_VERSIONField As String

        Private sTOFF_GUIDField As String

        Private hUTYP_DFLTField As String

        Private pILFERABLEField As String

        Private wHSTCField As String

        Private wHMATGRField As String

        Private hNDLCODEField As String

        Private hAZMATField As String

        Private hUTYPField As String

        Private tARE_VARField As String

        Private mAXCField As String

        Private mAXC_TOLField As String

        Private mAXLField As String

        Private mAXBField As String

        Private mAXHField As String

        Private mAXDIM_UOMField As String

        Private hERKLField As String

        Private mFRGRField As String

        Private qQTIMEField As String

        Private qQTIMEUOMField As String

        Private qGRPField As String

        Private sERIALField As String

        Private pS_SMARTFORMField As String

        Private cWQPROCField As String

        Private cWQTOLGRField As String

        Private aDPROFField As String

        Private iPMIPPRODUCTField As String

        Private mEDIUMField As String

        Private cOMMODITYField As String

        Private sGT_CSGRField As String

        Private sGT_COVSAField As String

        Private sGT_RELField As String

        Private sEGMENTField As ZXMATM02TypeIDOCE1MARAME1MARA1SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property MATNR_EXTERNAL() As String
            Get
                Return Me.mATNR_EXTERNALField
            End Get
            Set
                Me.mATNR_EXTERNALField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public Property MATNR_VERSION() As String
            Get
                Return Me.mATNR_VERSIONField
            End Get
            Set
                Me.mATNR_VERSIONField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>
        Public Property MATNR_GUID() As String
            Get
                Return Me.mATNR_GUIDField
            End Get
            Set
                Me.mATNR_GUIDField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=3)>
        Public Property BMATN_EXTERNAL() As String
            Get
                Return Me.bMATN_EXTERNALField
            End Get
            Set
                Me.bMATN_EXTERNALField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=4)>
        Public Property BMATN_VERSION() As String
            Get
                Return Me.bMATN_VERSIONField
            End Get
            Set
                Me.bMATN_VERSIONField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=5)>
        Public Property BMATN_GUID() As String
            Get
                Return Me.bMATN_GUIDField
            End Get
            Set
                Me.bMATN_GUIDField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=6)>
        Public Property STOFF_EXTERNAL() As String
            Get
                Return Me.sTOFF_EXTERNALField
            End Get
            Set
                Me.sTOFF_EXTERNALField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=7)>
        Public Property STOFF_VERSION() As String
            Get
                Return Me.sTOFF_VERSIONField
            End Get
            Set
                Me.sTOFF_VERSIONField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=8)>
        Public Property STOFF_GUID() As String
            Get
                Return Me.sTOFF_GUIDField
            End Get
            Set
                Me.sTOFF_GUIDField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=9)>
        Public Property HUTYP_DFLT() As String
            Get
                Return Me.hUTYP_DFLTField
            End Get
            Set
                Me.hUTYP_DFLTField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=10)>
        Public Property PILFERABLE() As String
            Get
                Return Me.pILFERABLEField
            End Get
            Set
                Me.pILFERABLEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=11)>
        Public Property WHSTC() As String
            Get
                Return Me.wHSTCField
            End Get
            Set
                Me.wHSTCField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=12)>
        Public Property WHMATGR() As String
            Get
                Return Me.wHMATGRField
            End Get
            Set
                Me.wHMATGRField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=13)>
        Public Property HNDLCODE() As String
            Get
                Return Me.hNDLCODEField
            End Get
            Set
                Me.hNDLCODEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=14)>
        Public Property HAZMAT() As String
            Get
                Return Me.hAZMATField
            End Get
            Set
                Me.hAZMATField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=15)>
        Public Property HUTYP() As String
            Get
                Return Me.hUTYPField
            End Get
            Set
                Me.hUTYPField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=16)>
        Public Property TARE_VAR() As String
            Get
                Return Me.tARE_VARField
            End Get
            Set
                Me.tARE_VARField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=17)>
        Public Property MAXC() As String
            Get
                Return Me.mAXCField
            End Get
            Set
                Me.mAXCField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=18)>
        Public Property MAXC_TOL() As String
            Get
                Return Me.mAXC_TOLField
            End Get
            Set
                Me.mAXC_TOLField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=19)>
        Public Property MAXL() As String
            Get
                Return Me.mAXLField
            End Get
            Set
                Me.mAXLField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=20)>
        Public Property MAXB() As String
            Get
                Return Me.mAXBField
            End Get
            Set
                Me.mAXBField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=21)>
        Public Property MAXH() As String
            Get
                Return Me.mAXHField
            End Get
            Set
                Me.mAXHField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=22)>
        Public Property MAXDIM_UOM() As String
            Get
                Return Me.mAXDIM_UOMField
            End Get
            Set
                Me.mAXDIM_UOMField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=23)>
        Public Property HERKL() As String
            Get
                Return Me.hERKLField
            End Get
            Set
                Me.hERKLField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=24)>
        Public Property MFRGR() As String
            Get
                Return Me.mFRGRField
            End Get
            Set
                Me.mFRGRField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=25)>
        Public Property QQTIME() As String
            Get
                Return Me.qQTIMEField
            End Get
            Set
                Me.qQTIMEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=26)>
        Public Property QQTIMEUOM() As String
            Get
                Return Me.qQTIMEUOMField
            End Get
            Set
                Me.qQTIMEUOMField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=27)>
        Public Property QGRP() As String
            Get
                Return Me.qGRPField
            End Get
            Set
                Me.qGRPField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=28)>
        Public Property SERIAL() As String
            Get
                Return Me.sERIALField
            End Get
            Set
                Me.sERIALField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=29)>
        Public Property PS_SMARTFORM() As String
            Get
                Return Me.pS_SMARTFORMField
            End Get
            Set
                Me.pS_SMARTFORMField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=30)>
        Public Property CWQPROC() As String
            Get
                Return Me.cWQPROCField
            End Get
            Set
                Me.cWQPROCField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=31)>
        Public Property CWQTOLGR() As String
            Get
                Return Me.cWQTOLGRField
            End Get
            Set
                Me.cWQTOLGRField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=32)>
        Public Property ADPROF() As String
            Get
                Return Me.aDPROFField
            End Get
            Set
                Me.aDPROFField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=33)>
        Public Property IPMIPPRODUCT() As String
            Get
                Return Me.iPMIPPRODUCTField
            End Get
            Set
                Me.iPMIPPRODUCTField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=34)>
        Public Property MEDIUM() As String
            Get
                Return Me.mEDIUMField
            End Get
            Set
                Me.mEDIUMField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=35)>
        Public Property COMMODITY() As String
            Get
                Return Me.cOMMODITYField
            End Get
            Set
                Me.cOMMODITYField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=36)>
        Public Property SGT_CSGR() As String
            Get
                Return Me.sGT_CSGRField
            End Get
            Set
                Me.sGT_CSGRField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=37)>
        Public Property SGT_COVSA() As String
            Get
                Return Me.sGT_COVSAField
            End Get
            Set
                Me.sGT_COVSAField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=38)>
        Public Property SGT_REL() As String
            Get
                Return Me.sGT_RELField
            End Get
            Set
                Me.sGT_RELField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property SEGMENT() As ZXMATM02TypeIDOCE1MARAME1MARA1SEGMENT
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
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/MaterialCreateCh" &
    "ange/v1/types")>
    Public Enum ZXMATM02TypeIDOCE1MARAME1MARA1SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Diagnostics.DebuggerStepThroughAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/MaterialCreateCh" &
    "ange/v1/types")>
    Partial Public Class ZXMATM02TypeIDOCE1MARAME1MAKTM

        Private mSGFNField As String

        Private sPRASField As String

        Private mAKTXField As String

        Private sPRAS_ISOField As String

        Private sEGMENTField As ZXMATM02TypeIDOCE1MARAME1MAKTMSEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property MSGFN() As String
            Get
                Return Me.mSGFNField
            End Get
            Set
                Me.mSGFNField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public Property SPRAS() As String
            Get
                Return Me.sPRASField
            End Get
            Set
                Me.sPRASField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>
        Public Property MAKTX() As String
            Get
                Return Me.mAKTXField
            End Get
            Set
                Me.mAKTXField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=3)>
        Public Property SPRAS_ISO() As String
            Get
                Return Me.sPRAS_ISOField
            End Get
            Set
                Me.sPRAS_ISOField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property SEGMENT() As ZXMATM02TypeIDOCE1MARAME1MAKTMSEGMENT
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
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/MaterialCreateCh" &
    "ange/v1/types")>
    Public Enum ZXMATM02TypeIDOCE1MARAME1MAKTMSEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Diagnostics.DebuggerStepThroughAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/MaterialCreateCh" &
    "ange/v1/types")>
    Partial Public Class ZXMATM02TypeIDOCE1MARAME1MARCM

        Private mSGFNField As String

        Private wERKSField As String

        Private pSTATField As String

        Private lVORMField As String

        Private bWTTYField As String

        Private mAABCField As String

        Private kZKRIField As String

        Private eKGRPField As String

        Private aUSMEField As String

        Private dISPRField As String

        Private dISMMField As String

        Private dISPOField As String

        Private pLIFZField As String

        Private wEBAZField As String

        Private pERKZField As String

        Private aUSSSField As String

        Private dISLSField As String

        Private bESKZField As String

        Private sOBSLField As String

        Private mINBEField As String

        Private eISBEField As String

        Private bSTMIField As String

        Private bSTMAField As String

        Private bSTFEField As String

        Private bSTRFField As String

        Private mABSTField As String

        Private lOSFXField As String

        Private sBDKZField As String

        Private lAGPRField As String

        Private aLTSLField As String

        Private kZAUSField As String

        Private aUSDTField As String

        Private nFMATField As String

        Private kZBEDField As String

        Private mISKZField As String

        Private fHORIField As String

        Private pFREIField As String

        Private fFREIField As String

        Private rGEKZField As String

        Private fEVORField As String

        Private bEARZField As String

        Private rUEZTField As String

        Private tRANZField As String

        Private bASMGField As String

        Private dZEITField As String

        Private mAXLZField As String

        Private lZEIHField As String

        Private kZPROField As String

        Private gPMKZField As String

        Private uEETOField As String

        Private uEETKField As String

        Private uNETOField As String

        Private wZEITField As String

        Private aTPKZField As String

        Private vZUSLField As String

        Private hERBLField As String

        Private iNSMKField As String

        Private sSQSSField As String

        Private kZDKZField As String

        Private uMLMCField As String

        Private lADGRField As String

        Private xCHPFField As String

        Private uSEQUField As String

        Private lGRADField As String

        Private aUFTLField As String

        Private pLVARField As String

        Private oTYPEField As String

        Private oBJIDField As String

        Private mTVFPField As String

        Private pERIVField As String

        Private kZKFKField As String

        Private vRVEZField As String

        Private vBAMGField As String

        Private vBEAZField As String

        Private lIZYKField As String

        Private bWSCLField As String

        Private kAUTBField As String

        Private kORDBField As String

        Private sTAWNField As String

        Private hERKLField As String

        Private hERKRField As String

        Private eXPMEField As String

        Private mTVERField As String

        Private pRCTRField As String

        Private tRAMEField As String

        Private mRPPPField As String

        Private sAUFTField As String

        Private fXHORField As String

        Private vRMODField As String

        Private vINT1Field As String

        Private vINT2Field As String

        Private sTLALField As String

        Private sTLANField As String

        Private pLNNRField As String

        Private aPLALField As String

        Private lOSGRField As String

        Private sOBSKField As String

        Private fRTMEField As String

        Private lGPROField As String

        Private dISGRField As String

        Private kAUSFField As String

        Private qZGTPField As String

        Private tAKZTField As String

        Private rWPROField As String

        Private cOPAMField As String

        Private aBCINField As String

        Private aWSLSField As String

        Private sERNPField As String

        Private sTDPDField As String

        Private sFEPRField As String

        Private xMCNGField As String

        Private qSSYSField As String

        Private lFRHYField As String

        Private rDPRFField As String

        Private vRBMTField As String

        Private vRBWKField As String

        Private vRBDTField As String

        Private vRBFKField As String

        Private aUTRUField As String

        Private pREFEField As String

        Private pRENCField As String

        Private pRENOField As String

        Private pRENDField As String

        Private pRENEField As String

        Private pRENGField As String

        Private iTARKField As String

        Private pRFRQField As String

        Private kZKUPField As String

        Private sTRGRField As String

        Private lGFSBField As String

        Private sCHGTField As String

        Private cCFIXField As String

        Private ePRIOField As String

        Private qMATAField As String

        Private pLNTYField As String

        Private mMSTAField As String

        Private sFCPFField As String

        Private sHFLGField As String

        Private sHZETField As String

        Private mDACHField As String

        Private kZECHField As String

        Private mMSTDField As String

        Private mFRGRField As String

        Private fVIDKField As String

        Private iNDUSField As String

        Private mOWNRField As String

        Private mOGRUField As String

        Private cASNRField As String

        Private gPNUMField As String

        Private sTEUCField As String

        Private fABKZField As String

        Private mATGRField As String

        Private lOGGRField As String

        Private vSPVBField As String

        Private dPLFSField As String

        Private dPLPUField As String

        Private dPLHOField As String

        Private mINLSField As String

        Private mAXLSField As String

        Private fIXLSField As String

        Private lTINCField As String

        Private cOMPLField As String

        Private cONVTField As String

        Private fPRFMField As String

        Private sHPROField As String

        Private fXPRUField As String

        Private kZPSPField As String

        Private oCMPFField As String

        Private aPOKZField As String

        Private aHDISField As String

        Private eISLOField As String

        Private nCOSTField As String

        Private mEGRUField As String

        Private rOTATION_DATEField As String

        Private uCHKZField As String

        Private uCMATField As String

        Private iUID_RELEVANTField As String

        Private iUID_TYPEField As String

        Private uID_IEAField As String

        Private sGT_COVSField As String

        Private sGT_STATCField As String

        Private sGT_PRCMField As String

        Private sGT_CHINTField As String

        Private sGT_STK_PRTField As String

        Private sGT_DEFSCField As String

        Private e1MARC1Field As ZXMATM02TypeIDOCE1MARAME1MARCME1MARC1

        Private e1MARDMField() As ZXMATM02TypeIDOCE1MARAME1MARCME1MARDM

        Private e1MFHMMField As ZXMATM02TypeIDOCE1MARAME1MARCME1MFHMM

        Private e1MPGDMField As ZXMATM02TypeIDOCE1MARAME1MARCME1MPGDM

        Private e1MPOPMField As ZXMATM02TypeIDOCE1MARAME1MARCME1MPOPM

        Private e1MPRWMField() As ZXMATM02TypeIDOCE1MARAME1MARCME1MPRWM

        Private e1MVEGMField() As ZXMATM02TypeIDOCE1MARAME1MARCME1MVEGM

        Private e1MVEUMField() As ZXMATM02TypeIDOCE1MARAME1MARCME1MVEUM

        Private e1MKALMField() As ZXMATM02TypeIDOCE1MARAME1MARCME1MKALM

        Private sEGMENTField As ZXMATM02TypeIDOCE1MARAME1MARCMSEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property MSGFN() As String
            Get
                Return Me.mSGFNField
            End Get
            Set
                Me.mSGFNField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public Property WERKS() As String
            Get
                Return Me.wERKSField
            End Get
            Set
                Me.wERKSField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>
        Public Property PSTAT() As String
            Get
                Return Me.pSTATField
            End Get
            Set
                Me.pSTATField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=3)>
        Public Property LVORM() As String
            Get
                Return Me.lVORMField
            End Get
            Set
                Me.lVORMField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=4)>
        Public Property BWTTY() As String
            Get
                Return Me.bWTTYField
            End Get
            Set
                Me.bWTTYField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=5)>
        Public Property MAABC() As String
            Get
                Return Me.mAABCField
            End Get
            Set
                Me.mAABCField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=6)>
        Public Property KZKRI() As String
            Get
                Return Me.kZKRIField
            End Get
            Set
                Me.kZKRIField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=7)>
        Public Property EKGRP() As String
            Get
                Return Me.eKGRPField
            End Get
            Set
                Me.eKGRPField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=8)>
        Public Property AUSME() As String
            Get
                Return Me.aUSMEField
            End Get
            Set
                Me.aUSMEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=9)>
        Public Property DISPR() As String
            Get
                Return Me.dISPRField
            End Get
            Set
                Me.dISPRField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=10)>
        Public Property DISMM() As String
            Get
                Return Me.dISMMField
            End Get
            Set
                Me.dISMMField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=11)>
        Public Property DISPO() As String
            Get
                Return Me.dISPOField
            End Get
            Set
                Me.dISPOField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=12)>
        Public Property PLIFZ() As String
            Get
                Return Me.pLIFZField
            End Get
            Set
                Me.pLIFZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=13)>
        Public Property WEBAZ() As String
            Get
                Return Me.wEBAZField
            End Get
            Set
                Me.wEBAZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=14)>
        Public Property PERKZ() As String
            Get
                Return Me.pERKZField
            End Get
            Set
                Me.pERKZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=15)>
        Public Property AUSSS() As String
            Get
                Return Me.aUSSSField
            End Get
            Set
                Me.aUSSSField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=16)>
        Public Property DISLS() As String
            Get
                Return Me.dISLSField
            End Get
            Set
                Me.dISLSField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=17)>
        Public Property BESKZ() As String
            Get
                Return Me.bESKZField
            End Get
            Set
                Me.bESKZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=18)>
        Public Property SOBSL() As String
            Get
                Return Me.sOBSLField
            End Get
            Set
                Me.sOBSLField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=19)>
        Public Property MINBE() As String
            Get
                Return Me.mINBEField
            End Get
            Set
                Me.mINBEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=20)>
        Public Property EISBE() As String
            Get
                Return Me.eISBEField
            End Get
            Set
                Me.eISBEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=21)>
        Public Property BSTMI() As String
            Get
                Return Me.bSTMIField
            End Get
            Set
                Me.bSTMIField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=22)>
        Public Property BSTMA() As String
            Get
                Return Me.bSTMAField
            End Get
            Set
                Me.bSTMAField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=23)>
        Public Property BSTFE() As String
            Get
                Return Me.bSTFEField
            End Get
            Set
                Me.bSTFEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=24)>
        Public Property BSTRF() As String
            Get
                Return Me.bSTRFField
            End Get
            Set
                Me.bSTRFField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=25)>
        Public Property MABST() As String
            Get
                Return Me.mABSTField
            End Get
            Set
                Me.mABSTField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=26)>
        Public Property LOSFX() As String
            Get
                Return Me.lOSFXField
            End Get
            Set
                Me.lOSFXField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=27)>
        Public Property SBDKZ() As String
            Get
                Return Me.sBDKZField
            End Get
            Set
                Me.sBDKZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=28)>
        Public Property LAGPR() As String
            Get
                Return Me.lAGPRField
            End Get
            Set
                Me.lAGPRField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=29)>
        Public Property ALTSL() As String
            Get
                Return Me.aLTSLField
            End Get
            Set
                Me.aLTSLField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=30)>
        Public Property KZAUS() As String
            Get
                Return Me.kZAUSField
            End Get
            Set
                Me.kZAUSField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=31)>
        Public Property AUSDT() As String
            Get
                Return Me.aUSDTField
            End Get
            Set
                Me.aUSDTField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=32)>
        Public Property NFMAT() As String
            Get
                Return Me.nFMATField
            End Get
            Set
                Me.nFMATField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=33)>
        Public Property KZBED() As String
            Get
                Return Me.kZBEDField
            End Get
            Set
                Me.kZBEDField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=34)>
        Public Property MISKZ() As String
            Get
                Return Me.mISKZField
            End Get
            Set
                Me.mISKZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=35)>
        Public Property FHORI() As String
            Get
                Return Me.fHORIField
            End Get
            Set
                Me.fHORIField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=36)>
        Public Property PFREI() As String
            Get
                Return Me.pFREIField
            End Get
            Set
                Me.pFREIField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=37)>
        Public Property FFREI() As String
            Get
                Return Me.fFREIField
            End Get
            Set
                Me.fFREIField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=38)>
        Public Property RGEKZ() As String
            Get
                Return Me.rGEKZField
            End Get
            Set
                Me.rGEKZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=39)>
        Public Property FEVOR() As String
            Get
                Return Me.fEVORField
            End Get
            Set
                Me.fEVORField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=40)>
        Public Property BEARZ() As String
            Get
                Return Me.bEARZField
            End Get
            Set
                Me.bEARZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=41)>
        Public Property RUEZT() As String
            Get
                Return Me.rUEZTField
            End Get
            Set
                Me.rUEZTField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=42)>
        Public Property TRANZ() As String
            Get
                Return Me.tRANZField
            End Get
            Set
                Me.tRANZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=43)>
        Public Property BASMG() As String
            Get
                Return Me.bASMGField
            End Get
            Set
                Me.bASMGField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=44)>
        Public Property DZEIT() As String
            Get
                Return Me.dZEITField
            End Get
            Set
                Me.dZEITField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=45)>
        Public Property MAXLZ() As String
            Get
                Return Me.mAXLZField
            End Get
            Set
                Me.mAXLZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=46)>
        Public Property LZEIH() As String
            Get
                Return Me.lZEIHField
            End Get
            Set
                Me.lZEIHField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=47)>
        Public Property KZPRO() As String
            Get
                Return Me.kZPROField
            End Get
            Set
                Me.kZPROField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=48)>
        Public Property GPMKZ() As String
            Get
                Return Me.gPMKZField
            End Get
            Set
                Me.gPMKZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=49)>
        Public Property UEETO() As String
            Get
                Return Me.uEETOField
            End Get
            Set
                Me.uEETOField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=50)>
        Public Property UEETK() As String
            Get
                Return Me.uEETKField
            End Get
            Set
                Me.uEETKField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=51)>
        Public Property UNETO() As String
            Get
                Return Me.uNETOField
            End Get
            Set
                Me.uNETOField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=52)>
        Public Property WZEIT() As String
            Get
                Return Me.wZEITField
            End Get
            Set
                Me.wZEITField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=53)>
        Public Property ATPKZ() As String
            Get
                Return Me.aTPKZField
            End Get
            Set
                Me.aTPKZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=54)>
        Public Property VZUSL() As String
            Get
                Return Me.vZUSLField
            End Get
            Set
                Me.vZUSLField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=55)>
        Public Property HERBL() As String
            Get
                Return Me.hERBLField
            End Get
            Set
                Me.hERBLField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=56)>
        Public Property INSMK() As String
            Get
                Return Me.iNSMKField
            End Get
            Set
                Me.iNSMKField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=57)>
        Public Property SSQSS() As String
            Get
                Return Me.sSQSSField
            End Get
            Set
                Me.sSQSSField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=58)>
        Public Property KZDKZ() As String
            Get
                Return Me.kZDKZField
            End Get
            Set
                Me.kZDKZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=59)>
        Public Property UMLMC() As String
            Get
                Return Me.uMLMCField
            End Get
            Set
                Me.uMLMCField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=60)>
        Public Property LADGR() As String
            Get
                Return Me.lADGRField
            End Get
            Set
                Me.lADGRField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=61)>
        Public Property XCHPF() As String
            Get
                Return Me.xCHPFField
            End Get
            Set
                Me.xCHPFField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=62)>
        Public Property USEQU() As String
            Get
                Return Me.uSEQUField
            End Get
            Set
                Me.uSEQUField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=63)>
        Public Property LGRAD() As String
            Get
                Return Me.lGRADField
            End Get
            Set
                Me.lGRADField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=64)>
        Public Property AUFTL() As String
            Get
                Return Me.aUFTLField
            End Get
            Set
                Me.aUFTLField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=65)>
        Public Property PLVAR() As String
            Get
                Return Me.pLVARField
            End Get
            Set
                Me.pLVARField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=66)>
        Public Property OTYPE() As String
            Get
                Return Me.oTYPEField
            End Get
            Set
                Me.oTYPEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=67)>
        Public Property OBJID() As String
            Get
                Return Me.oBJIDField
            End Get
            Set
                Me.oBJIDField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=68)>
        Public Property MTVFP() As String
            Get
                Return Me.mTVFPField
            End Get
            Set
                Me.mTVFPField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=69)>
        Public Property PERIV() As String
            Get
                Return Me.pERIVField
            End Get
            Set
                Me.pERIVField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=70)>
        Public Property KZKFK() As String
            Get
                Return Me.kZKFKField
            End Get
            Set
                Me.kZKFKField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=71)>
        Public Property VRVEZ() As String
            Get
                Return Me.vRVEZField
            End Get
            Set
                Me.vRVEZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=72)>
        Public Property VBAMG() As String
            Get
                Return Me.vBAMGField
            End Get
            Set
                Me.vBAMGField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=73)>
        Public Property VBEAZ() As String
            Get
                Return Me.vBEAZField
            End Get
            Set
                Me.vBEAZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=74)>
        Public Property LIZYK() As String
            Get
                Return Me.lIZYKField
            End Get
            Set
                Me.lIZYKField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=75)>
        Public Property BWSCL() As String
            Get
                Return Me.bWSCLField
            End Get
            Set
                Me.bWSCLField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=76)>
        Public Property KAUTB() As String
            Get
                Return Me.kAUTBField
            End Get
            Set
                Me.kAUTBField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=77)>
        Public Property KORDB() As String
            Get
                Return Me.kORDBField
            End Get
            Set
                Me.kORDBField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=78)>
        Public Property STAWN() As String
            Get
                Return Me.sTAWNField
            End Get
            Set
                Me.sTAWNField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=79)>
        Public Property HERKL() As String
            Get
                Return Me.hERKLField
            End Get
            Set
                Me.hERKLField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=80)>
        Public Property HERKR() As String
            Get
                Return Me.hERKRField
            End Get
            Set
                Me.hERKRField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=81)>
        Public Property EXPME() As String
            Get
                Return Me.eXPMEField
            End Get
            Set
                Me.eXPMEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=82)>
        Public Property MTVER() As String
            Get
                Return Me.mTVERField
            End Get
            Set
                Me.mTVERField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=83)>
        Public Property PRCTR() As String
            Get
                Return Me.pRCTRField
            End Get
            Set
                Me.pRCTRField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=84)>
        Public Property TRAME() As String
            Get
                Return Me.tRAMEField
            End Get
            Set
                Me.tRAMEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=85)>
        Public Property MRPPP() As String
            Get
                Return Me.mRPPPField
            End Get
            Set
                Me.mRPPPField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=86)>
        Public Property SAUFT() As String
            Get
                Return Me.sAUFTField
            End Get
            Set
                Me.sAUFTField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=87)>
        Public Property FXHOR() As String
            Get
                Return Me.fXHORField
            End Get
            Set
                Me.fXHORField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=88)>
        Public Property VRMOD() As String
            Get
                Return Me.vRMODField
            End Get
            Set
                Me.vRMODField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=89)>
        Public Property VINT1() As String
            Get
                Return Me.vINT1Field
            End Get
            Set
                Me.vINT1Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=90)>
        Public Property VINT2() As String
            Get
                Return Me.vINT2Field
            End Get
            Set
                Me.vINT2Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=91)>
        Public Property STLAL() As String
            Get
                Return Me.sTLALField
            End Get
            Set
                Me.sTLALField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=92)>
        Public Property STLAN() As String
            Get
                Return Me.sTLANField
            End Get
            Set
                Me.sTLANField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=93)>
        Public Property PLNNR() As String
            Get
                Return Me.pLNNRField
            End Get
            Set
                Me.pLNNRField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=94)>
        Public Property APLAL() As String
            Get
                Return Me.aPLALField
            End Get
            Set
                Me.aPLALField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=95)>
        Public Property LOSGR() As String
            Get
                Return Me.lOSGRField
            End Get
            Set
                Me.lOSGRField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=96)>
        Public Property SOBSK() As String
            Get
                Return Me.sOBSKField
            End Get
            Set
                Me.sOBSKField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=97)>
        Public Property FRTME() As String
            Get
                Return Me.fRTMEField
            End Get
            Set
                Me.fRTMEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=98)>
        Public Property LGPRO() As String
            Get
                Return Me.lGPROField
            End Get
            Set
                Me.lGPROField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=99)>
        Public Property DISGR() As String
            Get
                Return Me.dISGRField
            End Get
            Set
                Me.dISGRField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=100)>
        Public Property KAUSF() As String
            Get
                Return Me.kAUSFField
            End Get
            Set
                Me.kAUSFField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=101)>
        Public Property QZGTP() As String
            Get
                Return Me.qZGTPField
            End Get
            Set
                Me.qZGTPField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=102)>
        Public Property TAKZT() As String
            Get
                Return Me.tAKZTField
            End Get
            Set
                Me.tAKZTField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=103)>
        Public Property RWPRO() As String
            Get
                Return Me.rWPROField
            End Get
            Set
                Me.rWPROField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=104)>
        Public Property COPAM() As String
            Get
                Return Me.cOPAMField
            End Get
            Set
                Me.cOPAMField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=105)>
        Public Property ABCIN() As String
            Get
                Return Me.aBCINField
            End Get
            Set
                Me.aBCINField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=106)>
        Public Property AWSLS() As String
            Get
                Return Me.aWSLSField
            End Get
            Set
                Me.aWSLSField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=107)>
        Public Property SERNP() As String
            Get
                Return Me.sERNPField
            End Get
            Set
                Me.sERNPField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=108)>
        Public Property STDPD() As String
            Get
                Return Me.sTDPDField
            End Get
            Set
                Me.sTDPDField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=109)>
        Public Property SFEPR() As String
            Get
                Return Me.sFEPRField
            End Get
            Set
                Me.sFEPRField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=110)>
        Public Property XMCNG() As String
            Get
                Return Me.xMCNGField
            End Get
            Set
                Me.xMCNGField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=111)>
        Public Property QSSYS() As String
            Get
                Return Me.qSSYSField
            End Get
            Set
                Me.qSSYSField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=112)>
        Public Property LFRHY() As String
            Get
                Return Me.lFRHYField
            End Get
            Set
                Me.lFRHYField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=113)>
        Public Property RDPRF() As String
            Get
                Return Me.rDPRFField
            End Get
            Set
                Me.rDPRFField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=114)>
        Public Property VRBMT() As String
            Get
                Return Me.vRBMTField
            End Get
            Set
                Me.vRBMTField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=115)>
        Public Property VRBWK() As String
            Get
                Return Me.vRBWKField
            End Get
            Set
                Me.vRBWKField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=116)>
        Public Property VRBDT() As String
            Get
                Return Me.vRBDTField
            End Get
            Set
                Me.vRBDTField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=117)>
        Public Property VRBFK() As String
            Get
                Return Me.vRBFKField
            End Get
            Set
                Me.vRBFKField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=118)>
        Public Property AUTRU() As String
            Get
                Return Me.aUTRUField
            End Get
            Set
                Me.aUTRUField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=119)>
        Public Property PREFE() As String
            Get
                Return Me.pREFEField
            End Get
            Set
                Me.pREFEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=120)>
        Public Property PRENC() As String
            Get
                Return Me.pRENCField
            End Get
            Set
                Me.pRENCField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=121)>
        Public Property PRENO() As String
            Get
                Return Me.pRENOField
            End Get
            Set
                Me.pRENOField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=122)>
        Public Property PREND() As String
            Get
                Return Me.pRENDField
            End Get
            Set
                Me.pRENDField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=123)>
        Public Property PRENE() As String
            Get
                Return Me.pRENEField
            End Get
            Set
                Me.pRENEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=124)>
        Public Property PRENG() As String
            Get
                Return Me.pRENGField
            End Get
            Set
                Me.pRENGField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=125)>
        Public Property ITARK() As String
            Get
                Return Me.iTARKField
            End Get
            Set
                Me.iTARKField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=126)>
        Public Property PRFRQ() As String
            Get
                Return Me.pRFRQField
            End Get
            Set
                Me.pRFRQField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=127)>
        Public Property KZKUP() As String
            Get
                Return Me.kZKUPField
            End Get
            Set
                Me.kZKUPField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=128)>
        Public Property STRGR() As String
            Get
                Return Me.sTRGRField
            End Get
            Set
                Me.sTRGRField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=129)>
        Public Property LGFSB() As String
            Get
                Return Me.lGFSBField
            End Get
            Set
                Me.lGFSBField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=130)>
        Public Property SCHGT() As String
            Get
                Return Me.sCHGTField
            End Get
            Set
                Me.sCHGTField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=131)>
        Public Property CCFIX() As String
            Get
                Return Me.cCFIXField
            End Get
            Set
                Me.cCFIXField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=132)>
        Public Property EPRIO() As String
            Get
                Return Me.ePRIOField
            End Get
            Set
                Me.ePRIOField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=133)>
        Public Property QMATA() As String
            Get
                Return Me.qMATAField
            End Get
            Set
                Me.qMATAField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=134)>
        Public Property PLNTY() As String
            Get
                Return Me.pLNTYField
            End Get
            Set
                Me.pLNTYField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=135)>
        Public Property MMSTA() As String
            Get
                Return Me.mMSTAField
            End Get
            Set
                Me.mMSTAField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=136)>
        Public Property SFCPF() As String
            Get
                Return Me.sFCPFField
            End Get
            Set
                Me.sFCPFField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=137)>
        Public Property SHFLG() As String
            Get
                Return Me.sHFLGField
            End Get
            Set
                Me.sHFLGField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=138)>
        Public Property SHZET() As String
            Get
                Return Me.sHZETField
            End Get
            Set
                Me.sHZETField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=139)>
        Public Property MDACH() As String
            Get
                Return Me.mDACHField
            End Get
            Set
                Me.mDACHField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=140)>
        Public Property KZECH() As String
            Get
                Return Me.kZECHField
            End Get
            Set
                Me.kZECHField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=141)>
        Public Property MMSTD() As String
            Get
                Return Me.mMSTDField
            End Get
            Set
                Me.mMSTDField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=142)>
        Public Property MFRGR() As String
            Get
                Return Me.mFRGRField
            End Get
            Set
                Me.mFRGRField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=143)>
        Public Property FVIDK() As String
            Get
                Return Me.fVIDKField
            End Get
            Set
                Me.fVIDKField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=144)>
        Public Property INDUS() As String
            Get
                Return Me.iNDUSField
            End Get
            Set
                Me.iNDUSField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=145)>
        Public Property MOWNR() As String
            Get
                Return Me.mOWNRField
            End Get
            Set
                Me.mOWNRField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=146)>
        Public Property MOGRU() As String
            Get
                Return Me.mOGRUField
            End Get
            Set
                Me.mOGRUField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=147)>
        Public Property CASNR() As String
            Get
                Return Me.cASNRField
            End Get
            Set
                Me.cASNRField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=148)>
        Public Property GPNUM() As String
            Get
                Return Me.gPNUMField
            End Get
            Set
                Me.gPNUMField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=149)>
        Public Property STEUC() As String
            Get
                Return Me.sTEUCField
            End Get
            Set
                Me.sTEUCField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=150)>
        Public Property FABKZ() As String
            Get
                Return Me.fABKZField
            End Get
            Set
                Me.fABKZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=151)>
        Public Property MATGR() As String
            Get
                Return Me.mATGRField
            End Get
            Set
                Me.mATGRField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=152)>
        Public Property LOGGR() As String
            Get
                Return Me.lOGGRField
            End Get
            Set
                Me.lOGGRField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=153)>
        Public Property VSPVB() As String
            Get
                Return Me.vSPVBField
            End Get
            Set
                Me.vSPVBField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=154)>
        Public Property DPLFS() As String
            Get
                Return Me.dPLFSField
            End Get
            Set
                Me.dPLFSField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=155)>
        Public Property DPLPU() As String
            Get
                Return Me.dPLPUField
            End Get
            Set
                Me.dPLPUField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=156)>
        Public Property DPLHO() As String
            Get
                Return Me.dPLHOField
            End Get
            Set
                Me.dPLHOField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=157)>
        Public Property MINLS() As String
            Get
                Return Me.mINLSField
            End Get
            Set
                Me.mINLSField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=158)>
        Public Property MAXLS() As String
            Get
                Return Me.mAXLSField
            End Get
            Set
                Me.mAXLSField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=159)>
        Public Property FIXLS() As String
            Get
                Return Me.fIXLSField
            End Get
            Set
                Me.fIXLSField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=160)>
        Public Property LTINC() As String
            Get
                Return Me.lTINCField
            End Get
            Set
                Me.lTINCField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=161)>
        Public Property COMPL() As String
            Get
                Return Me.cOMPLField
            End Get
            Set
                Me.cOMPLField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=162)>
        Public Property CONVT() As String
            Get
                Return Me.cONVTField
            End Get
            Set
                Me.cONVTField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=163)>
        Public Property FPRFM() As String
            Get
                Return Me.fPRFMField
            End Get
            Set
                Me.fPRFMField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=164)>
        Public Property SHPRO() As String
            Get
                Return Me.sHPROField
            End Get
            Set
                Me.sHPROField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=165)>
        Public Property FXPRU() As String
            Get
                Return Me.fXPRUField
            End Get
            Set
                Me.fXPRUField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=166)>
        Public Property KZPSP() As String
            Get
                Return Me.kZPSPField
            End Get
            Set
                Me.kZPSPField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=167)>
        Public Property OCMPF() As String
            Get
                Return Me.oCMPFField
            End Get
            Set
                Me.oCMPFField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=168)>
        Public Property APOKZ() As String
            Get
                Return Me.aPOKZField
            End Get
            Set
                Me.aPOKZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=169)>
        Public Property AHDIS() As String
            Get
                Return Me.aHDISField
            End Get
            Set
                Me.aHDISField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=170)>
        Public Property EISLO() As String
            Get
                Return Me.eISLOField
            End Get
            Set
                Me.eISLOField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=171)>
        Public Property NCOST() As String
            Get
                Return Me.nCOSTField
            End Get
            Set
                Me.nCOSTField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=172)>
        Public Property MEGRU() As String
            Get
                Return Me.mEGRUField
            End Get
            Set
                Me.mEGRUField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=173)>
        Public Property ROTATION_DATE() As String
            Get
                Return Me.rOTATION_DATEField
            End Get
            Set
                Me.rOTATION_DATEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=174)>
        Public Property UCHKZ() As String
            Get
                Return Me.uCHKZField
            End Get
            Set
                Me.uCHKZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=175)>
        Public Property UCMAT() As String
            Get
                Return Me.uCMATField
            End Get
            Set
                Me.uCMATField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=176)>
        Public Property IUID_RELEVANT() As String
            Get
                Return Me.iUID_RELEVANTField
            End Get
            Set
                Me.iUID_RELEVANTField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=177)>
        Public Property IUID_TYPE() As String
            Get
                Return Me.iUID_TYPEField
            End Get
            Set
                Me.iUID_TYPEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=178)>
        Public Property UID_IEA() As String
            Get
                Return Me.uID_IEAField
            End Get
            Set
                Me.uID_IEAField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=179)>
        Public Property SGT_COVS() As String
            Get
                Return Me.sGT_COVSField
            End Get
            Set
                Me.sGT_COVSField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=180)>
        Public Property SGT_STATC() As String
            Get
                Return Me.sGT_STATCField
            End Get
            Set
                Me.sGT_STATCField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=181)>
        Public Property SGT_PRCM() As String
            Get
                Return Me.sGT_PRCMField
            End Get
            Set
                Me.sGT_PRCMField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=182)>
        Public Property SGT_CHINT() As String
            Get
                Return Me.sGT_CHINTField
            End Get
            Set
                Me.sGT_CHINTField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=183)>
        Public Property SGT_STK_PRT() As String
            Get
                Return Me.sGT_STK_PRTField
            End Get
            Set
                Me.sGT_STK_PRTField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=184)>
        Public Property SGT_DEFSC() As String
            Get
                Return Me.sGT_DEFSCField
            End Get
            Set
                Me.sGT_DEFSCField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=185)>
        Public Property E1MARC1() As ZXMATM02TypeIDOCE1MARAME1MARCME1MARC1
            Get
                Return Me.e1MARC1Field
            End Get
            Set
                Me.e1MARC1Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("E1MARDM", Order:=186)>
        Public Property E1MARDM() As ZXMATM02TypeIDOCE1MARAME1MARCME1MARDM()
            Get
                Return Me.e1MARDMField
            End Get
            Set
                Me.e1MARDMField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=187)>
        Public Property E1MFHMM() As ZXMATM02TypeIDOCE1MARAME1MARCME1MFHMM
            Get
                Return Me.e1MFHMMField
            End Get
            Set
                Me.e1MFHMMField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=188)>
        Public Property E1MPGDM() As ZXMATM02TypeIDOCE1MARAME1MARCME1MPGDM
            Get
                Return Me.e1MPGDMField
            End Get
            Set
                Me.e1MPGDMField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=189)>
        Public Property E1MPOPM() As ZXMATM02TypeIDOCE1MARAME1MARCME1MPOPM
            Get
                Return Me.e1MPOPMField
            End Get
            Set
                Me.e1MPOPMField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("E1MPRWM", Order:=190)>
        Public Property E1MPRWM() As ZXMATM02TypeIDOCE1MARAME1MARCME1MPRWM()
            Get
                Return Me.e1MPRWMField
            End Get
            Set
                Me.e1MPRWMField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("E1MVEGM", Order:=191)>
        Public Property E1MVEGM() As ZXMATM02TypeIDOCE1MARAME1MARCME1MVEGM()
            Get
                Return Me.e1MVEGMField
            End Get
            Set
                Me.e1MVEGMField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("E1MVEUM", Order:=192)>
        Public Property E1MVEUM() As ZXMATM02TypeIDOCE1MARAME1MARCME1MVEUM()
            Get
                Return Me.e1MVEUMField
            End Get
            Set
                Me.e1MVEUMField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("E1MKALM", Order:=193)>
        Public Property E1MKALM() As ZXMATM02TypeIDOCE1MARAME1MARCME1MKALM()
            Get
                Return Me.e1MKALMField
            End Get
            Set
                Me.e1MKALMField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property SEGMENT() As ZXMATM02TypeIDOCE1MARAME1MARCMSEGMENT
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
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/MaterialCreateCh" &
    "ange/v1/types")>
    Partial Public Class ZXMATM02TypeIDOCE1MARAME1MARCME1MARC1

        Private nFMAT_EXTERNALField As String

        Private nFMAT_VERSIONField As String

        Private nFMAT_GUIDField As String

        Private sTDPD_EXTERNALField As String

        Private sTDPD_VERSIONField As String

        Private sTDPD_GUIDField As String

        Private vRBMT_EXTERNALField As String

        Private vRBMT_VERSIONField As String

        Private vRBMT_GUIDField As String

        Private sEGMENTField As ZXMATM02TypeIDOCE1MARAME1MARCME1MARC1SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property NFMAT_EXTERNAL() As String
            Get
                Return Me.nFMAT_EXTERNALField
            End Get
            Set
                Me.nFMAT_EXTERNALField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public Property NFMAT_VERSION() As String
            Get
                Return Me.nFMAT_VERSIONField
            End Get
            Set
                Me.nFMAT_VERSIONField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>
        Public Property NFMAT_GUID() As String
            Get
                Return Me.nFMAT_GUIDField
            End Get
            Set
                Me.nFMAT_GUIDField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=3)>
        Public Property STDPD_EXTERNAL() As String
            Get
                Return Me.sTDPD_EXTERNALField
            End Get
            Set
                Me.sTDPD_EXTERNALField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=4)>
        Public Property STDPD_VERSION() As String
            Get
                Return Me.sTDPD_VERSIONField
            End Get
            Set
                Me.sTDPD_VERSIONField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=5)>
        Public Property STDPD_GUID() As String
            Get
                Return Me.sTDPD_GUIDField
            End Get
            Set
                Me.sTDPD_GUIDField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=6)>
        Public Property VRBMT_EXTERNAL() As String
            Get
                Return Me.vRBMT_EXTERNALField
            End Get
            Set
                Me.vRBMT_EXTERNALField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=7)>
        Public Property VRBMT_VERSION() As String
            Get
                Return Me.vRBMT_VERSIONField
            End Get
            Set
                Me.vRBMT_VERSIONField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=8)>
        Public Property VRBMT_GUID() As String
            Get
                Return Me.vRBMT_GUIDField
            End Get
            Set
                Me.vRBMT_GUIDField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property SEGMENT() As ZXMATM02TypeIDOCE1MARAME1MARCME1MARC1SEGMENT
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
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/MaterialCreateCh" &
    "ange/v1/types")>
    Public Enum ZXMATM02TypeIDOCE1MARAME1MARCME1MARC1SEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Diagnostics.DebuggerStepThroughAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/MaterialCreateCh" &
    "ange/v1/types")>
    Partial Public Class ZXMATM02TypeIDOCE1MARAME1MARCME1MARDM

        Private mSGFNField As String

        Private lGORTField As String

        Private pSTATField As String

        Private lVORMField As String

        Private dISKZField As String

        Private lSOBSField As String

        Private lMINBField As String

        Private lBSTFField As String

        Private hERKLField As String

        Private eXPPGField As String

        Private eXVERField As String

        Private lGPBEField As String

        Private pRCTLField As String

        Private lWMKBField As String

        Private bSKRFField As String

        Private sEGMENTField As ZXMATM02TypeIDOCE1MARAME1MARCME1MARDMSEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property MSGFN() As String
            Get
                Return Me.mSGFNField
            End Get
            Set
                Me.mSGFNField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public Property LGORT() As String
            Get
                Return Me.lGORTField
            End Get
            Set
                Me.lGORTField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>
        Public Property PSTAT() As String
            Get
                Return Me.pSTATField
            End Get
            Set
                Me.pSTATField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=3)>
        Public Property LVORM() As String
            Get
                Return Me.lVORMField
            End Get
            Set
                Me.lVORMField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=4)>
        Public Property DISKZ() As String
            Get
                Return Me.dISKZField
            End Get
            Set
                Me.dISKZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=5)>
        Public Property LSOBS() As String
            Get
                Return Me.lSOBSField
            End Get
            Set
                Me.lSOBSField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=6)>
        Public Property LMINB() As String
            Get
                Return Me.lMINBField
            End Get
            Set
                Me.lMINBField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=7)>
        Public Property LBSTF() As String
            Get
                Return Me.lBSTFField
            End Get
            Set
                Me.lBSTFField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=8)>
        Public Property HERKL() As String
            Get
                Return Me.hERKLField
            End Get
            Set
                Me.hERKLField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=9)>
        Public Property EXPPG() As String
            Get
                Return Me.eXPPGField
            End Get
            Set
                Me.eXPPGField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=10)>
        Public Property EXVER() As String
            Get
                Return Me.eXVERField
            End Get
            Set
                Me.eXVERField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=11)>
        Public Property LGPBE() As String
            Get
                Return Me.lGPBEField
            End Get
            Set
                Me.lGPBEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=12)>
        Public Property PRCTL() As String
            Get
                Return Me.pRCTLField
            End Get
            Set
                Me.pRCTLField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=13)>
        Public Property LWMKB() As String
            Get
                Return Me.lWMKBField
            End Get
            Set
                Me.lWMKBField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=14)>
        Public Property BSKRF() As String
            Get
                Return Me.bSKRFField
            End Get
            Set
                Me.bSKRFField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property SEGMENT() As ZXMATM02TypeIDOCE1MARAME1MARCME1MARDMSEGMENT
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
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/MaterialCreateCh" &
    "ange/v1/types")>
    Public Enum ZXMATM02TypeIDOCE1MARAME1MARCME1MARDMSEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Diagnostics.DebuggerStepThroughAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/MaterialCreateCh" &
    "ange/v1/types")>
    Partial Public Class ZXMATM02TypeIDOCE1MARAME1MARCME1MFHMM

        Private mSGFNField As String

        Private oBJTYField As String

        Private oBJIDField As String

        Private zAEHLField As String

        Private oBJTY_VField As String

        Private oBJID_VField As String

        Private kZKBLField As String

        Private sTEUFField As String

        Private sTEUF_REFField As String

        Private fGRU1Field As String

        Private fGRU2Field As String

        Private pLANVField As String

        Private kTSCHField As String

        Private kTSCH_REFField As String

        Private bZOFFBField As String

        Private bZOFFB_REFField As String

        Private oFFSTBField As String

        Private eHOFFBField As String

        Private oFFSTB_REFField As String

        Private bZOFFEField As String

        Private bZOFFE_REFField As String

        Private oFFSTEField As String

        Private eHOFFEField As String

        Private oFFSTE_REFField As String

        Private mGFORMField As String

        Private mGFORM_REFField As String

        Private eWFORMField As String

        Private eWFORM_REFField As String

        Private pAR01Field As String

        Private pAR02Field As String

        Private pAR03Field As String

        Private pAR04Field As String

        Private pAR05Field As String

        Private pAR06Field As String

        Private pARU1Field As String

        Private pARU2Field As String

        Private pARU3Field As String

        Private pARU4Field As String

        Private pARU5Field As String

        Private pARU6Field As String

        Private pARV1Field As String

        Private pARV2Field As String

        Private pARV3Field As String

        Private pARV4Field As String

        Private pARV5Field As String

        Private pARV6Field As String

        Private sEGMENTField As ZXMATM02TypeIDOCE1MARAME1MARCME1MFHMMSEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property MSGFN() As String
            Get
                Return Me.mSGFNField
            End Get
            Set
                Me.mSGFNField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public Property OBJTY() As String
            Get
                Return Me.oBJTYField
            End Get
            Set
                Me.oBJTYField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>
        Public Property OBJID() As String
            Get
                Return Me.oBJIDField
            End Get
            Set
                Me.oBJIDField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=3)>
        Public Property ZAEHL() As String
            Get
                Return Me.zAEHLField
            End Get
            Set
                Me.zAEHLField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=4)>
        Public Property OBJTY_V() As String
            Get
                Return Me.oBJTY_VField
            End Get
            Set
                Me.oBJTY_VField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=5)>
        Public Property OBJID_V() As String
            Get
                Return Me.oBJID_VField
            End Get
            Set
                Me.oBJID_VField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=6)>
        Public Property KZKBL() As String
            Get
                Return Me.kZKBLField
            End Get
            Set
                Me.kZKBLField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=7)>
        Public Property STEUF() As String
            Get
                Return Me.sTEUFField
            End Get
            Set
                Me.sTEUFField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=8)>
        Public Property STEUF_REF() As String
            Get
                Return Me.sTEUF_REFField
            End Get
            Set
                Me.sTEUF_REFField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=9)>
        Public Property FGRU1() As String
            Get
                Return Me.fGRU1Field
            End Get
            Set
                Me.fGRU1Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=10)>
        Public Property FGRU2() As String
            Get
                Return Me.fGRU2Field
            End Get
            Set
                Me.fGRU2Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=11)>
        Public Property PLANV() As String
            Get
                Return Me.pLANVField
            End Get
            Set
                Me.pLANVField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=12)>
        Public Property KTSCH() As String
            Get
                Return Me.kTSCHField
            End Get
            Set
                Me.kTSCHField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=13)>
        Public Property KTSCH_REF() As String
            Get
                Return Me.kTSCH_REFField
            End Get
            Set
                Me.kTSCH_REFField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=14)>
        Public Property BZOFFB() As String
            Get
                Return Me.bZOFFBField
            End Get
            Set
                Me.bZOFFBField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=15)>
        Public Property BZOFFB_REF() As String
            Get
                Return Me.bZOFFB_REFField
            End Get
            Set
                Me.bZOFFB_REFField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=16)>
        Public Property OFFSTB() As String
            Get
                Return Me.oFFSTBField
            End Get
            Set
                Me.oFFSTBField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=17)>
        Public Property EHOFFB() As String
            Get
                Return Me.eHOFFBField
            End Get
            Set
                Me.eHOFFBField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=18)>
        Public Property OFFSTB_REF() As String
            Get
                Return Me.oFFSTB_REFField
            End Get
            Set
                Me.oFFSTB_REFField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=19)>
        Public Property BZOFFE() As String
            Get
                Return Me.bZOFFEField
            End Get
            Set
                Me.bZOFFEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=20)>
        Public Property BZOFFE_REF() As String
            Get
                Return Me.bZOFFE_REFField
            End Get
            Set
                Me.bZOFFE_REFField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=21)>
        Public Property OFFSTE() As String
            Get
                Return Me.oFFSTEField
            End Get
            Set
                Me.oFFSTEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=22)>
        Public Property EHOFFE() As String
            Get
                Return Me.eHOFFEField
            End Get
            Set
                Me.eHOFFEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=23)>
        Public Property OFFSTE_REF() As String
            Get
                Return Me.oFFSTE_REFField
            End Get
            Set
                Me.oFFSTE_REFField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=24)>
        Public Property MGFORM() As String
            Get
                Return Me.mGFORMField
            End Get
            Set
                Me.mGFORMField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=25)>
        Public Property MGFORM_REF() As String
            Get
                Return Me.mGFORM_REFField
            End Get
            Set
                Me.mGFORM_REFField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=26)>
        Public Property EWFORM() As String
            Get
                Return Me.eWFORMField
            End Get
            Set
                Me.eWFORMField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=27)>
        Public Property EWFORM_REF() As String
            Get
                Return Me.eWFORM_REFField
            End Get
            Set
                Me.eWFORM_REFField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=28)>
        Public Property PAR01() As String
            Get
                Return Me.pAR01Field
            End Get
            Set
                Me.pAR01Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=29)>
        Public Property PAR02() As String
            Get
                Return Me.pAR02Field
            End Get
            Set
                Me.pAR02Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=30)>
        Public Property PAR03() As String
            Get
                Return Me.pAR03Field
            End Get
            Set
                Me.pAR03Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=31)>
        Public Property PAR04() As String
            Get
                Return Me.pAR04Field
            End Get
            Set
                Me.pAR04Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=32)>
        Public Property PAR05() As String
            Get
                Return Me.pAR05Field
            End Get
            Set
                Me.pAR05Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=33)>
        Public Property PAR06() As String
            Get
                Return Me.pAR06Field
            End Get
            Set
                Me.pAR06Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=34)>
        Public Property PARU1() As String
            Get
                Return Me.pARU1Field
            End Get
            Set
                Me.pARU1Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=35)>
        Public Property PARU2() As String
            Get
                Return Me.pARU2Field
            End Get
            Set
                Me.pARU2Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=36)>
        Public Property PARU3() As String
            Get
                Return Me.pARU3Field
            End Get
            Set
                Me.pARU3Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=37)>
        Public Property PARU4() As String
            Get
                Return Me.pARU4Field
            End Get
            Set
                Me.pARU4Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=38)>
        Public Property PARU5() As String
            Get
                Return Me.pARU5Field
            End Get
            Set
                Me.pARU5Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=39)>
        Public Property PARU6() As String
            Get
                Return Me.pARU6Field
            End Get
            Set
                Me.pARU6Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=40)>
        Public Property PARV1() As String
            Get
                Return Me.pARV1Field
            End Get
            Set
                Me.pARV1Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=41)>
        Public Property PARV2() As String
            Get
                Return Me.pARV2Field
            End Get
            Set
                Me.pARV2Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=42)>
        Public Property PARV3() As String
            Get
                Return Me.pARV3Field
            End Get
            Set
                Me.pARV3Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=43)>
        Public Property PARV4() As String
            Get
                Return Me.pARV4Field
            End Get
            Set
                Me.pARV4Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=44)>
        Public Property PARV5() As String
            Get
                Return Me.pARV5Field
            End Get
            Set
                Me.pARV5Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=45)>
        Public Property PARV6() As String
            Get
                Return Me.pARV6Field
            End Get
            Set
                Me.pARV6Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property SEGMENT() As ZXMATM02TypeIDOCE1MARAME1MARCME1MFHMMSEGMENT
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
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/MaterialCreateCh" &
    "ange/v1/types")>
    Public Enum ZXMATM02TypeIDOCE1MARAME1MARCME1MFHMMSEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Diagnostics.DebuggerStepThroughAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/MaterialCreateCh" &
    "ange/v1/types")>
    Partial Public Class ZXMATM02TypeIDOCE1MARAME1MARCME1MPGDM

        Private mSGFNField As String

        Private pRGRPField As String

        Private pRWRKField As String

        Private uMREFField As String

        Private pRGRP_EXTERNALField As String

        Private pRGRP_VERSIONField As String

        Private pRGRP_GUIDField As String

        Private sEGMENTField As ZXMATM02TypeIDOCE1MARAME1MARCME1MPGDMSEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property MSGFN() As String
            Get
                Return Me.mSGFNField
            End Get
            Set
                Me.mSGFNField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public Property PRGRP() As String
            Get
                Return Me.pRGRPField
            End Get
            Set
                Me.pRGRPField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>
        Public Property PRWRK() As String
            Get
                Return Me.pRWRKField
            End Get
            Set
                Me.pRWRKField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=3)>
        Public Property UMREF() As String
            Get
                Return Me.uMREFField
            End Get
            Set
                Me.uMREFField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=4)>
        Public Property PRGRP_EXTERNAL() As String
            Get
                Return Me.pRGRP_EXTERNALField
            End Get
            Set
                Me.pRGRP_EXTERNALField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=5)>
        Public Property PRGRP_VERSION() As String
            Get
                Return Me.pRGRP_VERSIONField
            End Get
            Set
                Me.pRGRP_VERSIONField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=6)>
        Public Property PRGRP_GUID() As String
            Get
                Return Me.pRGRP_GUIDField
            End Get
            Set
                Me.pRGRP_GUIDField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property SEGMENT() As ZXMATM02TypeIDOCE1MARAME1MARCME1MPGDMSEGMENT
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
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/MaterialCreateCh" &
    "ange/v1/types")>
    Public Enum ZXMATM02TypeIDOCE1MARAME1MARCME1MPGDMSEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Diagnostics.DebuggerStepThroughAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/MaterialCreateCh" &
    "ange/v1/types")>
    Partial Public Class ZXMATM02TypeIDOCE1MARAME1MARCME1MPOPM

        Private mSGFNField As String

        Private vERSPField As String

        Private pROPRField As String

        Private mODAWField As String

        Private mODAVField As String

        Private kZPARField As String

        Private oPGRAField As String

        Private kZINIField As String

        Private pRMODField As String

        Private aLPHAField As String

        Private bETA1Field As String

        Private gAMMAField As String

        Private dELTAField As String

        Private ePSILField As String

        Private sIGGRField As String

        Private pERKZField As String

        Private pRDATField As String

        Private pERANField As String

        Private pERINField As String

        Private pERIOField As String

        Private pEREXField As String

        Private aNZPRField As String

        Private fIMONField As String

        Private gWERTField As String

        Private gWER1Field As String

        Private gWER2Field As String

        Private vMGWEField As String

        Private vMGW1Field As String

        Private vMGW2Field As String

        Private tWERTField As String

        Private vMTWEField As String

        Private pRMADField As String

        Private vMMADField As String

        Private fSUMMField As String

        Private vMFSUField As String

        Private gEWGRField As String

        Private tHKOFField As String

        Private aUSNAField As String

        Private pROABField As String

        Private sEGMENTField As ZXMATM02TypeIDOCE1MARAME1MARCME1MPOPMSEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property MSGFN() As String
            Get
                Return Me.mSGFNField
            End Get
            Set
                Me.mSGFNField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public Property VERSP() As String
            Get
                Return Me.vERSPField
            End Get
            Set
                Me.vERSPField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>
        Public Property PROPR() As String
            Get
                Return Me.pROPRField
            End Get
            Set
                Me.pROPRField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=3)>
        Public Property MODAW() As String
            Get
                Return Me.mODAWField
            End Get
            Set
                Me.mODAWField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=4)>
        Public Property MODAV() As String
            Get
                Return Me.mODAVField
            End Get
            Set
                Me.mODAVField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=5)>
        Public Property KZPAR() As String
            Get
                Return Me.kZPARField
            End Get
            Set
                Me.kZPARField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=6)>
        Public Property OPGRA() As String
            Get
                Return Me.oPGRAField
            End Get
            Set
                Me.oPGRAField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=7)>
        Public Property KZINI() As String
            Get
                Return Me.kZINIField
            End Get
            Set
                Me.kZINIField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=8)>
        Public Property PRMOD() As String
            Get
                Return Me.pRMODField
            End Get
            Set
                Me.pRMODField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=9)>
        Public Property ALPHA() As String
            Get
                Return Me.aLPHAField
            End Get
            Set
                Me.aLPHAField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=10)>
        Public Property BETA1() As String
            Get
                Return Me.bETA1Field
            End Get
            Set
                Me.bETA1Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=11)>
        Public Property GAMMA() As String
            Get
                Return Me.gAMMAField
            End Get
            Set
                Me.gAMMAField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=12)>
        Public Property DELTA() As String
            Get
                Return Me.dELTAField
            End Get
            Set
                Me.dELTAField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=13)>
        Public Property EPSIL() As String
            Get
                Return Me.ePSILField
            End Get
            Set
                Me.ePSILField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=14)>
        Public Property SIGGR() As String
            Get
                Return Me.sIGGRField
            End Get
            Set
                Me.sIGGRField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=15)>
        Public Property PERKZ() As String
            Get
                Return Me.pERKZField
            End Get
            Set
                Me.pERKZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=16)>
        Public Property PRDAT() As String
            Get
                Return Me.pRDATField
            End Get
            Set
                Me.pRDATField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=17)>
        Public Property PERAN() As String
            Get
                Return Me.pERANField
            End Get
            Set
                Me.pERANField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=18)>
        Public Property PERIN() As String
            Get
                Return Me.pERINField
            End Get
            Set
                Me.pERINField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=19)>
        Public Property PERIO() As String
            Get
                Return Me.pERIOField
            End Get
            Set
                Me.pERIOField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=20)>
        Public Property PEREX() As String
            Get
                Return Me.pEREXField
            End Get
            Set
                Me.pEREXField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=21)>
        Public Property ANZPR() As String
            Get
                Return Me.aNZPRField
            End Get
            Set
                Me.aNZPRField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=22)>
        Public Property FIMON() As String
            Get
                Return Me.fIMONField
            End Get
            Set
                Me.fIMONField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=23)>
        Public Property GWERT() As String
            Get
                Return Me.gWERTField
            End Get
            Set
                Me.gWERTField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=24)>
        Public Property GWER1() As String
            Get
                Return Me.gWER1Field
            End Get
            Set
                Me.gWER1Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=25)>
        Public Property GWER2() As String
            Get
                Return Me.gWER2Field
            End Get
            Set
                Me.gWER2Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=26)>
        Public Property VMGWE() As String
            Get
                Return Me.vMGWEField
            End Get
            Set
                Me.vMGWEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=27)>
        Public Property VMGW1() As String
            Get
                Return Me.vMGW1Field
            End Get
            Set
                Me.vMGW1Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=28)>
        Public Property VMGW2() As String
            Get
                Return Me.vMGW2Field
            End Get
            Set
                Me.vMGW2Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=29)>
        Public Property TWERT() As String
            Get
                Return Me.tWERTField
            End Get
            Set
                Me.tWERTField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=30)>
        Public Property VMTWE() As String
            Get
                Return Me.vMTWEField
            End Get
            Set
                Me.vMTWEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=31)>
        Public Property PRMAD() As String
            Get
                Return Me.pRMADField
            End Get
            Set
                Me.pRMADField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=32)>
        Public Property VMMAD() As String
            Get
                Return Me.vMMADField
            End Get
            Set
                Me.vMMADField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=33)>
        Public Property FSUMM() As String
            Get
                Return Me.fSUMMField
            End Get
            Set
                Me.fSUMMField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=34)>
        Public Property VMFSU() As String
            Get
                Return Me.vMFSUField
            End Get
            Set
                Me.vMFSUField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=35)>
        Public Property GEWGR() As String
            Get
                Return Me.gEWGRField
            End Get
            Set
                Me.gEWGRField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=36)>
        Public Property THKOF() As String
            Get
                Return Me.tHKOFField
            End Get
            Set
                Me.tHKOFField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=37)>
        Public Property AUSNA() As String
            Get
                Return Me.aUSNAField
            End Get
            Set
                Me.aUSNAField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=38)>
        Public Property PROAB() As String
            Get
                Return Me.pROABField
            End Get
            Set
                Me.pROABField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property SEGMENT() As ZXMATM02TypeIDOCE1MARAME1MARCME1MPOPMSEGMENT
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
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/MaterialCreateCh" &
    "ange/v1/types")>
    Public Enum ZXMATM02TypeIDOCE1MARAME1MARCME1MPOPMSEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Diagnostics.DebuggerStepThroughAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/MaterialCreateCh" &
    "ange/v1/types")>
    Partial Public Class ZXMATM02TypeIDOCE1MARAME1MARCME1MPRWM

        Private mSGFNField As String

        Private eRTAGField As String

        Private pRWRTField As String

        Private kOPRWField As String

        Private sAIINField As String

        Private fIXKZField As String

        Private eXPRWField As String

        Private aNTEIField As String

        Private sEGMENTField As ZXMATM02TypeIDOCE1MARAME1MARCME1MPRWMSEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property MSGFN() As String
            Get
                Return Me.mSGFNField
            End Get
            Set
                Me.mSGFNField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public Property ERTAG() As String
            Get
                Return Me.eRTAGField
            End Get
            Set
                Me.eRTAGField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>
        Public Property PRWRT() As String
            Get
                Return Me.pRWRTField
            End Get
            Set
                Me.pRWRTField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=3)>
        Public Property KOPRW() As String
            Get
                Return Me.kOPRWField
            End Get
            Set
                Me.kOPRWField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=4)>
        Public Property SAIIN() As String
            Get
                Return Me.sAIINField
            End Get
            Set
                Me.sAIINField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=5)>
        Public Property FIXKZ() As String
            Get
                Return Me.fIXKZField
            End Get
            Set
                Me.fIXKZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=6)>
        Public Property EXPRW() As String
            Get
                Return Me.eXPRWField
            End Get
            Set
                Me.eXPRWField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=7)>
        Public Property ANTEI() As String
            Get
                Return Me.aNTEIField
            End Get
            Set
                Me.aNTEIField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property SEGMENT() As ZXMATM02TypeIDOCE1MARAME1MARCME1MPRWMSEGMENT
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
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/MaterialCreateCh" &
    "ange/v1/types")>
    Public Enum ZXMATM02TypeIDOCE1MARAME1MARCME1MPRWMSEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Diagnostics.DebuggerStepThroughAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/MaterialCreateCh" &
    "ange/v1/types")>
    Partial Public Class ZXMATM02TypeIDOCE1MARAME1MARCME1MVEGM

        Private mSGFNField As String

        Private eRTAGField As String

        Private vBWRTField As String

        Private kOVBWField As String

        Private kZEXIField As String

        Private aNTEIField As String

        Private sEGMENTField As ZXMATM02TypeIDOCE1MARAME1MARCME1MVEGMSEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property MSGFN() As String
            Get
                Return Me.mSGFNField
            End Get
            Set
                Me.mSGFNField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public Property ERTAG() As String
            Get
                Return Me.eRTAGField
            End Get
            Set
                Me.eRTAGField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>
        Public Property VBWRT() As String
            Get
                Return Me.vBWRTField
            End Get
            Set
                Me.vBWRTField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=3)>
        Public Property KOVBW() As String
            Get
                Return Me.kOVBWField
            End Get
            Set
                Me.kOVBWField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=4)>
        Public Property KZEXI() As String
            Get
                Return Me.kZEXIField
            End Get
            Set
                Me.kZEXIField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=5)>
        Public Property ANTEI() As String
            Get
                Return Me.aNTEIField
            End Get
            Set
                Me.aNTEIField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property SEGMENT() As ZXMATM02TypeIDOCE1MARAME1MARCME1MVEGMSEGMENT
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
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/MaterialCreateCh" &
    "ange/v1/types")>
    Public Enum ZXMATM02TypeIDOCE1MARAME1MARCME1MVEGMSEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Diagnostics.DebuggerStepThroughAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/MaterialCreateCh" &
    "ange/v1/types")>
    Partial Public Class ZXMATM02TypeIDOCE1MARAME1MARCME1MVEUM

        Private mSGFNField As String

        Private eRTAGField As String

        Private vBWRTField As String

        Private kOVBWField As String

        Private kZEXIField As String

        Private aNTEIField As String

        Private sEGMENTField As ZXMATM02TypeIDOCE1MARAME1MARCME1MVEUMSEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property MSGFN() As String
            Get
                Return Me.mSGFNField
            End Get
            Set
                Me.mSGFNField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public Property ERTAG() As String
            Get
                Return Me.eRTAGField
            End Get
            Set
                Me.eRTAGField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>
        Public Property VBWRT() As String
            Get
                Return Me.vBWRTField
            End Get
            Set
                Me.vBWRTField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=3)>
        Public Property KOVBW() As String
            Get
                Return Me.kOVBWField
            End Get
            Set
                Me.kOVBWField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=4)>
        Public Property KZEXI() As String
            Get
                Return Me.kZEXIField
            End Get
            Set
                Me.kZEXIField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=5)>
        Public Property ANTEI() As String
            Get
                Return Me.aNTEIField
            End Get
            Set
                Me.aNTEIField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property SEGMENT() As ZXMATM02TypeIDOCE1MARAME1MARCME1MVEUMSEGMENT
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
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/MaterialCreateCh" &
    "ange/v1/types")>
    Public Enum ZXMATM02TypeIDOCE1MARAME1MARCME1MVEUMSEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Diagnostics.DebuggerStepThroughAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/MaterialCreateCh" &
    "ange/v1/types")>
    Partial Public Class ZXMATM02TypeIDOCE1MARAME1MARCME1MKALM

        Private mSGFNField As String

        Private vERIDField As String

        Private bDATUField As String

        Private aDATUField As String

        Private sTLALField As String

        Private sTLANField As String

        Private pLNTYField As String

        Private pLNNRField As String

        Private aLNALField As String

        Private bESKZField As String

        Private sOBSLField As String

        Private lOSGRField As String

        Private mDV01Field As String

        Private mDV02Field As String

        Private tEXT1Field As String

        Private eWAHRField As String

        Private vERTOField As String

        Private sERKZField As String

        Private bSTMIField As String

        Private bSTMAField As String

        Private rGEKZField As String

        Private aLORTField As String

        Private pLTYGField As String

        Private pLNNGField As String

        Private aLNAGField As String

        Private pLTYMField As String

        Private pLNNMField As String

        Private aLNAMField As String

        Private cSPLTField As String

        Private mATKOField As String

        Private eLPROField As String

        Private pRVBEField As String

        Private mATKO_EXTERNALField As String

        Private mATKO_VERSIONField As String

        Private mATKO_GUIDField As String

        Private sEGMENTField As ZXMATM02TypeIDOCE1MARAME1MARCME1MKALMSEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property MSGFN() As String
            Get
                Return Me.mSGFNField
            End Get
            Set
                Me.mSGFNField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public Property VERID() As String
            Get
                Return Me.vERIDField
            End Get
            Set
                Me.vERIDField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>
        Public Property BDATU() As String
            Get
                Return Me.bDATUField
            End Get
            Set
                Me.bDATUField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=3)>
        Public Property ADATU() As String
            Get
                Return Me.aDATUField
            End Get
            Set
                Me.aDATUField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=4)>
        Public Property STLAL() As String
            Get
                Return Me.sTLALField
            End Get
            Set
                Me.sTLALField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=5)>
        Public Property STLAN() As String
            Get
                Return Me.sTLANField
            End Get
            Set
                Me.sTLANField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=6)>
        Public Property PLNTY() As String
            Get
                Return Me.pLNTYField
            End Get
            Set
                Me.pLNTYField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=7)>
        Public Property PLNNR() As String
            Get
                Return Me.pLNNRField
            End Get
            Set
                Me.pLNNRField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=8)>
        Public Property ALNAL() As String
            Get
                Return Me.aLNALField
            End Get
            Set
                Me.aLNALField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=9)>
        Public Property BESKZ() As String
            Get
                Return Me.bESKZField
            End Get
            Set
                Me.bESKZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=10)>
        Public Property SOBSL() As String
            Get
                Return Me.sOBSLField
            End Get
            Set
                Me.sOBSLField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=11)>
        Public Property LOSGR() As String
            Get
                Return Me.lOSGRField
            End Get
            Set
                Me.lOSGRField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=12)>
        Public Property MDV01() As String
            Get
                Return Me.mDV01Field
            End Get
            Set
                Me.mDV01Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=13)>
        Public Property MDV02() As String
            Get
                Return Me.mDV02Field
            End Get
            Set
                Me.mDV02Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=14)>
        Public Property TEXT1() As String
            Get
                Return Me.tEXT1Field
            End Get
            Set
                Me.tEXT1Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=15)>
        Public Property EWAHR() As String
            Get
                Return Me.eWAHRField
            End Get
            Set
                Me.eWAHRField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=16)>
        Public Property VERTO() As String
            Get
                Return Me.vERTOField
            End Get
            Set
                Me.vERTOField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=17)>
        Public Property SERKZ() As String
            Get
                Return Me.sERKZField
            End Get
            Set
                Me.sERKZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=18)>
        Public Property BSTMI() As String
            Get
                Return Me.bSTMIField
            End Get
            Set
                Me.bSTMIField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=19)>
        Public Property BSTMA() As String
            Get
                Return Me.bSTMAField
            End Get
            Set
                Me.bSTMAField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=20)>
        Public Property RGEKZ() As String
            Get
                Return Me.rGEKZField
            End Get
            Set
                Me.rGEKZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=21)>
        Public Property ALORT() As String
            Get
                Return Me.aLORTField
            End Get
            Set
                Me.aLORTField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=22)>
        Public Property PLTYG() As String
            Get
                Return Me.pLTYGField
            End Get
            Set
                Me.pLTYGField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=23)>
        Public Property PLNNG() As String
            Get
                Return Me.pLNNGField
            End Get
            Set
                Me.pLNNGField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=24)>
        Public Property ALNAG() As String
            Get
                Return Me.aLNAGField
            End Get
            Set
                Me.aLNAGField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=25)>
        Public Property PLTYM() As String
            Get
                Return Me.pLTYMField
            End Get
            Set
                Me.pLTYMField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=26)>
        Public Property PLNNM() As String
            Get
                Return Me.pLNNMField
            End Get
            Set
                Me.pLNNMField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=27)>
        Public Property ALNAM() As String
            Get
                Return Me.aLNAMField
            End Get
            Set
                Me.aLNAMField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=28)>
        Public Property CSPLT() As String
            Get
                Return Me.cSPLTField
            End Get
            Set
                Me.cSPLTField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=29)>
        Public Property MATKO() As String
            Get
                Return Me.mATKOField
            End Get
            Set
                Me.mATKOField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=30)>
        Public Property ELPRO() As String
            Get
                Return Me.eLPROField
            End Get
            Set
                Me.eLPROField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=31)>
        Public Property PRVBE() As String
            Get
                Return Me.pRVBEField
            End Get
            Set
                Me.pRVBEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=32)>
        Public Property MATKO_EXTERNAL() As String
            Get
                Return Me.mATKO_EXTERNALField
            End Get
            Set
                Me.mATKO_EXTERNALField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=33)>
        Public Property MATKO_VERSION() As String
            Get
                Return Me.mATKO_VERSIONField
            End Get
            Set
                Me.mATKO_VERSIONField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=34)>
        Public Property MATKO_GUID() As String
            Get
                Return Me.mATKO_GUIDField
            End Get
            Set
                Me.mATKO_GUIDField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property SEGMENT() As ZXMATM02TypeIDOCE1MARAME1MARCME1MKALMSEGMENT
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
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/MaterialCreateCh" &
    "ange/v1/types")>
    Public Enum ZXMATM02TypeIDOCE1MARAME1MARCME1MKALMSEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/MaterialCreateCh" &
    "ange/v1/types")>
    Public Enum ZXMATM02TypeIDOCE1MARAME1MARCMSEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Diagnostics.DebuggerStepThroughAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/MaterialCreateCh" &
    "ange/v1/types")>
    Partial Public Class ZXMATM02TypeIDOCE1MARAME1MARMM

        Private mSGFNField As String

        Private mEINHField As String

        Private uMREZField As String

        Private uMRENField As String

        Private eAN11Field As String

        Private nUMTPField As String

        Private lAENGField As String

        Private bREITField As String

        Private hOEHEField As String

        Private mEABMField As String

        Private vOLUMField As String

        Private vOLEHField As String

        Private bRGEWField As String

        Private gEWEIField As String

        Private mESUBField As String

        Private gTIN_VARIANTField As String

        Private _CWM_TY2TQField As String

        Private nEST_FTRField As String

        Private mAX_STACKField As String

        Private cAPAUSEField As String

        Private e1MEANMField() As ZXMATM02TypeIDOCE1MARAME1MARMME1MEANM

        Private sEGMENTField As ZXMATM02TypeIDOCE1MARAME1MARMMSEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property MSGFN() As String
            Get
                Return Me.mSGFNField
            End Get
            Set
                Me.mSGFNField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public Property MEINH() As String
            Get
                Return Me.mEINHField
            End Get
            Set
                Me.mEINHField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>
        Public Property UMREZ() As String
            Get
                Return Me.uMREZField
            End Get
            Set
                Me.uMREZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=3)>
        Public Property UMREN() As String
            Get
                Return Me.uMRENField
            End Get
            Set
                Me.uMRENField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=4)>
        Public Property EAN11() As String
            Get
                Return Me.eAN11Field
            End Get
            Set
                Me.eAN11Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=5)>
        Public Property NUMTP() As String
            Get
                Return Me.nUMTPField
            End Get
            Set
                Me.nUMTPField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=6)>
        Public Property LAENG() As String
            Get
                Return Me.lAENGField
            End Get
            Set
                Me.lAENGField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=7)>
        Public Property BREIT() As String
            Get
                Return Me.bREITField
            End Get
            Set
                Me.bREITField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=8)>
        Public Property HOEHE() As String
            Get
                Return Me.hOEHEField
            End Get
            Set
                Me.hOEHEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=9)>
        Public Property MEABM() As String
            Get
                Return Me.mEABMField
            End Get
            Set
                Me.mEABMField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=10)>
        Public Property VOLUM() As String
            Get
                Return Me.vOLUMField
            End Get
            Set
                Me.vOLUMField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=11)>
        Public Property VOLEH() As String
            Get
                Return Me.vOLEHField
            End Get
            Set
                Me.vOLEHField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=12)>
        Public Property BRGEW() As String
            Get
                Return Me.bRGEWField
            End Get
            Set
                Me.bRGEWField = Value
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
        Public Property MESUB() As String
            Get
                Return Me.mESUBField
            End Get
            Set
                Me.mESUBField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=15)>
        Public Property GTIN_VARIANT() As String
            Get
                Return Me.gTIN_VARIANTField
            End Get
            Set
                Me.gTIN_VARIANTField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("_-CWM_-TY2TQ", Order:=16)>
        Public Property _CWM_TY2TQ() As String
            Get
                Return Me._CWM_TY2TQField
            End Get
            Set
                Me._CWM_TY2TQField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=17)>
        Public Property NEST_FTR() As String
            Get
                Return Me.nEST_FTRField
            End Get
            Set
                Me.nEST_FTRField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=18)>
        Public Property MAX_STACK() As String
            Get
                Return Me.mAX_STACKField
            End Get
            Set
                Me.mAX_STACKField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=19)>
        Public Property CAPAUSE() As String
            Get
                Return Me.cAPAUSEField
            End Get
            Set
                Me.cAPAUSEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("E1MEANM", Order:=20)>
        Public Property E1MEANM() As ZXMATM02TypeIDOCE1MARAME1MARMME1MEANM()
            Get
                Return Me.e1MEANMField
            End Get
            Set
                Me.e1MEANMField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property SEGMENT() As ZXMATM02TypeIDOCE1MARAME1MARMMSEGMENT
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
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/MaterialCreateCh" &
    "ange/v1/types")>
    Partial Public Class ZXMATM02TypeIDOCE1MARAME1MARMME1MEANM

        Private mSGFNField As String

        Private mEINHField As String

        Private lFNUMField As String

        Private eAN11Field As String

        Private eANTPField As String

        Private hPEANField As String

        Private sEGMENTField As ZXMATM02TypeIDOCE1MARAME1MARMME1MEANMSEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property MSGFN() As String
            Get
                Return Me.mSGFNField
            End Get
            Set
                Me.mSGFNField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public Property MEINH() As String
            Get
                Return Me.mEINHField
            End Get
            Set
                Me.mEINHField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>
        Public Property LFNUM() As String
            Get
                Return Me.lFNUMField
            End Get
            Set
                Me.lFNUMField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=3)>
        Public Property EAN11() As String
            Get
                Return Me.eAN11Field
            End Get
            Set
                Me.eAN11Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=4)>
        Public Property EANTP() As String
            Get
                Return Me.eANTPField
            End Get
            Set
                Me.eANTPField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=5)>
        Public Property HPEAN() As String
            Get
                Return Me.hPEANField
            End Get
            Set
                Me.hPEANField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property SEGMENT() As ZXMATM02TypeIDOCE1MARAME1MARMME1MEANMSEGMENT
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
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/MaterialCreateCh" &
    "ange/v1/types")>
    Public Enum ZXMATM02TypeIDOCE1MARAME1MARMME1MEANMSEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/MaterialCreateCh" &
    "ange/v1/types")>
    Public Enum ZXMATM02TypeIDOCE1MARAME1MARMMSEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Diagnostics.DebuggerStepThroughAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/MaterialCreateCh" &
    "ange/v1/types")>
    Partial Public Class ZXMATM02TypeIDOCE1MARAME1MBEWM

        Private mSGFNField As String

        Private bWKEYField As String

        Private bWTARField As String

        Private lVORMField As String

        Private vPRSVField As String

        Private vERPRField As String

        Private sTPRSField As String

        Private pEINHField As String

        Private bKLASField As String

        Private vMVPRField As String

        Private vMVERField As String

        Private vMSTPField As String

        Private vMPEIField As String

        Private vMBKLField As String

        Private vJVPRField As String

        Private vJVERField As String

        Private vJSTPField As String

        Private lFGJAField As String

        Private lFMONField As String

        Private bWTTYField As String

        Private zKPRSField As String

        Private zKDATField As String

        Private bWPRSField As String

        Private bWPRHField As String

        Private vJBWSField As String

        Private vJBWHField As String

        Private vVJLBField As String

        Private vVMLBField As String

        Private vVSALField As String

        Private zPLPRField As String

        Private zPLP1Field As String

        Private zPLP2Field As String

        Private zPLP3Field As String

        Private zPLD1Field As String

        Private zPLD2Field As String

        Private zPLD3Field As String

        Private kALKZField As String

        Private kALKLField As String

        Private xLIFOField As String

        Private mYPOLField As String

        Private bWPH1Field As String

        Private bWPS1Field As String

        Private aBWKZField As String

        Private pSTATField As String

        Private kALN1Field As String

        Private kALNRField As String

        Private bWVA1Field As String

        Private bWVA2Field As String

        Private bWVA3Field As String

        Private vERS1Field As String

        Private vERS2Field As String

        Private vERS3Field As String

        Private hRKFTField As String

        Private kOSGRField As String

        Private pPRDZField As String

        Private pPRDLField As String

        Private pPRDVField As String

        Private pDATZField As String

        Private pDATLField As String

        Private pDATVField As String

        Private eKALRField As String

        Private vPLPRField As String

        Private mLMAAField As String

        Private mLASTField As String

        Private vJBKLField As String

        Private vJPEIField As String

        Private hKMATField As String

        Private eKLASField As String

        Private qKLASField As String

        Private mTUSEField As String

        Private mTORGField As String

        Private oWNPRField As String

        Private bWPEIField As String

        Private cON_FIN_VALLEVELField As String

        Private cON_FIN_VALPROCField As String

        Private sEGMENTField As ZXMATM02TypeIDOCE1MARAME1MBEWMSEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property MSGFN() As String
            Get
                Return Me.mSGFNField
            End Get
            Set
                Me.mSGFNField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public Property BWKEY() As String
            Get
                Return Me.bWKEYField
            End Get
            Set
                Me.bWKEYField = Value
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
        <System.Xml.Serialization.XmlElementAttribute(Order:=3)>
        Public Property LVORM() As String
            Get
                Return Me.lVORMField
            End Get
            Set
                Me.lVORMField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=4)>
        Public Property VPRSV() As String
            Get
                Return Me.vPRSVField
            End Get
            Set
                Me.vPRSVField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=5)>
        Public Property VERPR() As String
            Get
                Return Me.vERPRField
            End Get
            Set
                Me.vERPRField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=6)>
        Public Property STPRS() As String
            Get
                Return Me.sTPRSField
            End Get
            Set
                Me.sTPRSField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=7)>
        Public Property PEINH() As String
            Get
                Return Me.pEINHField
            End Get
            Set
                Me.pEINHField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=8)>
        Public Property BKLAS() As String
            Get
                Return Me.bKLASField
            End Get
            Set
                Me.bKLASField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=9)>
        Public Property VMVPR() As String
            Get
                Return Me.vMVPRField
            End Get
            Set
                Me.vMVPRField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=10)>
        Public Property VMVER() As String
            Get
                Return Me.vMVERField
            End Get
            Set
                Me.vMVERField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=11)>
        Public Property VMSTP() As String
            Get
                Return Me.vMSTPField
            End Get
            Set
                Me.vMSTPField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=12)>
        Public Property VMPEI() As String
            Get
                Return Me.vMPEIField
            End Get
            Set
                Me.vMPEIField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=13)>
        Public Property VMBKL() As String
            Get
                Return Me.vMBKLField
            End Get
            Set
                Me.vMBKLField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=14)>
        Public Property VJVPR() As String
            Get
                Return Me.vJVPRField
            End Get
            Set
                Me.vJVPRField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=15)>
        Public Property VJVER() As String
            Get
                Return Me.vJVERField
            End Get
            Set
                Me.vJVERField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=16)>
        Public Property VJSTP() As String
            Get
                Return Me.vJSTPField
            End Get
            Set
                Me.vJSTPField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=17)>
        Public Property LFGJA() As String
            Get
                Return Me.lFGJAField
            End Get
            Set
                Me.lFGJAField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=18)>
        Public Property LFMON() As String
            Get
                Return Me.lFMONField
            End Get
            Set
                Me.lFMONField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=19)>
        Public Property BWTTY() As String
            Get
                Return Me.bWTTYField
            End Get
            Set
                Me.bWTTYField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=20)>
        Public Property ZKPRS() As String
            Get
                Return Me.zKPRSField
            End Get
            Set
                Me.zKPRSField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=21)>
        Public Property ZKDAT() As String
            Get
                Return Me.zKDATField
            End Get
            Set
                Me.zKDATField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=22)>
        Public Property BWPRS() As String
            Get
                Return Me.bWPRSField
            End Get
            Set
                Me.bWPRSField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=23)>
        Public Property BWPRH() As String
            Get
                Return Me.bWPRHField
            End Get
            Set
                Me.bWPRHField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=24)>
        Public Property VJBWS() As String
            Get
                Return Me.vJBWSField
            End Get
            Set
                Me.vJBWSField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=25)>
        Public Property VJBWH() As String
            Get
                Return Me.vJBWHField
            End Get
            Set
                Me.vJBWHField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=26)>
        Public Property VVJLB() As String
            Get
                Return Me.vVJLBField
            End Get
            Set
                Me.vVJLBField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=27)>
        Public Property VVMLB() As String
            Get
                Return Me.vVMLBField
            End Get
            Set
                Me.vVMLBField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=28)>
        Public Property VVSAL() As String
            Get
                Return Me.vVSALField
            End Get
            Set
                Me.vVSALField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=29)>
        Public Property ZPLPR() As String
            Get
                Return Me.zPLPRField
            End Get
            Set
                Me.zPLPRField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=30)>
        Public Property ZPLP1() As String
            Get
                Return Me.zPLP1Field
            End Get
            Set
                Me.zPLP1Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=31)>
        Public Property ZPLP2() As String
            Get
                Return Me.zPLP2Field
            End Get
            Set
                Me.zPLP2Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=32)>
        Public Property ZPLP3() As String
            Get
                Return Me.zPLP3Field
            End Get
            Set
                Me.zPLP3Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=33)>
        Public Property ZPLD1() As String
            Get
                Return Me.zPLD1Field
            End Get
            Set
                Me.zPLD1Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=34)>
        Public Property ZPLD2() As String
            Get
                Return Me.zPLD2Field
            End Get
            Set
                Me.zPLD2Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=35)>
        Public Property ZPLD3() As String
            Get
                Return Me.zPLD3Field
            End Get
            Set
                Me.zPLD3Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=36)>
        Public Property KALKZ() As String
            Get
                Return Me.kALKZField
            End Get
            Set
                Me.kALKZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=37)>
        Public Property KALKL() As String
            Get
                Return Me.kALKLField
            End Get
            Set
                Me.kALKLField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=38)>
        Public Property XLIFO() As String
            Get
                Return Me.xLIFOField
            End Get
            Set
                Me.xLIFOField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=39)>
        Public Property MYPOL() As String
            Get
                Return Me.mYPOLField
            End Get
            Set
                Me.mYPOLField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=40)>
        Public Property BWPH1() As String
            Get
                Return Me.bWPH1Field
            End Get
            Set
                Me.bWPH1Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=41)>
        Public Property BWPS1() As String
            Get
                Return Me.bWPS1Field
            End Get
            Set
                Me.bWPS1Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=42)>
        Public Property ABWKZ() As String
            Get
                Return Me.aBWKZField
            End Get
            Set
                Me.aBWKZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=43)>
        Public Property PSTAT() As String
            Get
                Return Me.pSTATField
            End Get
            Set
                Me.pSTATField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=44)>
        Public Property KALN1() As String
            Get
                Return Me.kALN1Field
            End Get
            Set
                Me.kALN1Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=45)>
        Public Property KALNR() As String
            Get
                Return Me.kALNRField
            End Get
            Set
                Me.kALNRField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=46)>
        Public Property BWVA1() As String
            Get
                Return Me.bWVA1Field
            End Get
            Set
                Me.bWVA1Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=47)>
        Public Property BWVA2() As String
            Get
                Return Me.bWVA2Field
            End Get
            Set
                Me.bWVA2Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=48)>
        Public Property BWVA3() As String
            Get
                Return Me.bWVA3Field
            End Get
            Set
                Me.bWVA3Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=49)>
        Public Property VERS1() As String
            Get
                Return Me.vERS1Field
            End Get
            Set
                Me.vERS1Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=50)>
        Public Property VERS2() As String
            Get
                Return Me.vERS2Field
            End Get
            Set
                Me.vERS2Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=51)>
        Public Property VERS3() As String
            Get
                Return Me.vERS3Field
            End Get
            Set
                Me.vERS3Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=52)>
        Public Property HRKFT() As String
            Get
                Return Me.hRKFTField
            End Get
            Set
                Me.hRKFTField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=53)>
        Public Property KOSGR() As String
            Get
                Return Me.kOSGRField
            End Get
            Set
                Me.kOSGRField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=54)>
        Public Property PPRDZ() As String
            Get
                Return Me.pPRDZField
            End Get
            Set
                Me.pPRDZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=55)>
        Public Property PPRDL() As String
            Get
                Return Me.pPRDLField
            End Get
            Set
                Me.pPRDLField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=56)>
        Public Property PPRDV() As String
            Get
                Return Me.pPRDVField
            End Get
            Set
                Me.pPRDVField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=57)>
        Public Property PDATZ() As String
            Get
                Return Me.pDATZField
            End Get
            Set
                Me.pDATZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=58)>
        Public Property PDATL() As String
            Get
                Return Me.pDATLField
            End Get
            Set
                Me.pDATLField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=59)>
        Public Property PDATV() As String
            Get
                Return Me.pDATVField
            End Get
            Set
                Me.pDATVField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=60)>
        Public Property EKALR() As String
            Get
                Return Me.eKALRField
            End Get
            Set
                Me.eKALRField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=61)>
        Public Property VPLPR() As String
            Get
                Return Me.vPLPRField
            End Get
            Set
                Me.vPLPRField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=62)>
        Public Property MLMAA() As String
            Get
                Return Me.mLMAAField
            End Get
            Set
                Me.mLMAAField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=63)>
        Public Property MLAST() As String
            Get
                Return Me.mLASTField
            End Get
            Set
                Me.mLASTField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=64)>
        Public Property VJBKL() As String
            Get
                Return Me.vJBKLField
            End Get
            Set
                Me.vJBKLField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=65)>
        Public Property VJPEI() As String
            Get
                Return Me.vJPEIField
            End Get
            Set
                Me.vJPEIField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=66)>
        Public Property HKMAT() As String
            Get
                Return Me.hKMATField
            End Get
            Set
                Me.hKMATField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=67)>
        Public Property EKLAS() As String
            Get
                Return Me.eKLASField
            End Get
            Set
                Me.eKLASField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=68)>
        Public Property QKLAS() As String
            Get
                Return Me.qKLASField
            End Get
            Set
                Me.qKLASField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=69)>
        Public Property MTUSE() As String
            Get
                Return Me.mTUSEField
            End Get
            Set
                Me.mTUSEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=70)>
        Public Property MTORG() As String
            Get
                Return Me.mTORGField
            End Get
            Set
                Me.mTORGField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=71)>
        Public Property OWNPR() As String
            Get
                Return Me.oWNPRField
            End Get
            Set
                Me.oWNPRField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=72)>
        Public Property BWPEI() As String
            Get
                Return Me.bWPEIField
            End Get
            Set
                Me.bWPEIField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=73)>
        Public Property CON_FIN_VALLEVEL() As String
            Get
                Return Me.cON_FIN_VALLEVELField
            End Get
            Set
                Me.cON_FIN_VALLEVELField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=74)>
        Public Property CON_FIN_VALPROC() As String
            Get
                Return Me.cON_FIN_VALPROCField
            End Get
            Set
                Me.cON_FIN_VALPROCField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property SEGMENT() As ZXMATM02TypeIDOCE1MARAME1MBEWMSEGMENT
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
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/MaterialCreateCh" &
    "ange/v1/types")>
    Public Enum ZXMATM02TypeIDOCE1MARAME1MBEWMSEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Diagnostics.DebuggerStepThroughAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/MaterialCreateCh" &
    "ange/v1/types")>
    Partial Public Class ZXMATM02TypeIDOCE1MARAME1MLGNM

        Private mSGFNField As String

        Private lGNUMField As String

        Private lVORMField As String

        Private lGBKZField As String

        Private lTKZEField As String

        Private lTKZAField As String

        Private lHMG1Field As String

        Private lHMG2Field As String

        Private lHMG3Field As String

        Private lHME1Field As String

        Private lHME2Field As String

        Private lHME3Field As String

        Private lETY1Field As String

        Private lETY2Field As String

        Private lETY3Field As String

        Private lVSMEField As String

        Private kZZULField As String

        Private bLOCKField As String

        Private kZMBFField As String

        Private bSSKZField As String

        Private mKAPVField As String

        Private bEZMEField As String

        Private pLKPTField As String

        Private vOMEMField As String

        Private l2SKRField As String

        Private e1MLGTMField() As ZXMATM02TypeIDOCE1MARAME1MLGNME1MLGTM

        Private sEGMENTField As ZXMATM02TypeIDOCE1MARAME1MLGNMSEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property MSGFN() As String
            Get
                Return Me.mSGFNField
            End Get
            Set
                Me.mSGFNField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public Property LGNUM() As String
            Get
                Return Me.lGNUMField
            End Get
            Set
                Me.lGNUMField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>
        Public Property LVORM() As String
            Get
                Return Me.lVORMField
            End Get
            Set
                Me.lVORMField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=3)>
        Public Property LGBKZ() As String
            Get
                Return Me.lGBKZField
            End Get
            Set
                Me.lGBKZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=4)>
        Public Property LTKZE() As String
            Get
                Return Me.lTKZEField
            End Get
            Set
                Me.lTKZEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=5)>
        Public Property LTKZA() As String
            Get
                Return Me.lTKZAField
            End Get
            Set
                Me.lTKZAField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=6)>
        Public Property LHMG1() As String
            Get
                Return Me.lHMG1Field
            End Get
            Set
                Me.lHMG1Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=7)>
        Public Property LHMG2() As String
            Get
                Return Me.lHMG2Field
            End Get
            Set
                Me.lHMG2Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=8)>
        Public Property LHMG3() As String
            Get
                Return Me.lHMG3Field
            End Get
            Set
                Me.lHMG3Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=9)>
        Public Property LHME1() As String
            Get
                Return Me.lHME1Field
            End Get
            Set
                Me.lHME1Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=10)>
        Public Property LHME2() As String
            Get
                Return Me.lHME2Field
            End Get
            Set
                Me.lHME2Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=11)>
        Public Property LHME3() As String
            Get
                Return Me.lHME3Field
            End Get
            Set
                Me.lHME3Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=12)>
        Public Property LETY1() As String
            Get
                Return Me.lETY1Field
            End Get
            Set
                Me.lETY1Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=13)>
        Public Property LETY2() As String
            Get
                Return Me.lETY2Field
            End Get
            Set
                Me.lETY2Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=14)>
        Public Property LETY3() As String
            Get
                Return Me.lETY3Field
            End Get
            Set
                Me.lETY3Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=15)>
        Public Property LVSME() As String
            Get
                Return Me.lVSMEField
            End Get
            Set
                Me.lVSMEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=16)>
        Public Property KZZUL() As String
            Get
                Return Me.kZZULField
            End Get
            Set
                Me.kZZULField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=17)>
        Public Property BLOCK() As String
            Get
                Return Me.bLOCKField
            End Get
            Set
                Me.bLOCKField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=18)>
        Public Property KZMBF() As String
            Get
                Return Me.kZMBFField
            End Get
            Set
                Me.kZMBFField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=19)>
        Public Property BSSKZ() As String
            Get
                Return Me.bSSKZField
            End Get
            Set
                Me.bSSKZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=20)>
        Public Property MKAPV() As String
            Get
                Return Me.mKAPVField
            End Get
            Set
                Me.mKAPVField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=21)>
        Public Property BEZME() As String
            Get
                Return Me.bEZMEField
            End Get
            Set
                Me.bEZMEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=22)>
        Public Property PLKPT() As String
            Get
                Return Me.pLKPTField
            End Get
            Set
                Me.pLKPTField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=23)>
        Public Property VOMEM() As String
            Get
                Return Me.vOMEMField
            End Get
            Set
                Me.vOMEMField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=24)>
        Public Property L2SKR() As String
            Get
                Return Me.l2SKRField
            End Get
            Set
                Me.l2SKRField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("E1MLGTM", Order:=25)>
        Public Property E1MLGTM() As ZXMATM02TypeIDOCE1MARAME1MLGNME1MLGTM()
            Get
                Return Me.e1MLGTMField
            End Get
            Set
                Me.e1MLGTMField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property SEGMENT() As ZXMATM02TypeIDOCE1MARAME1MLGNMSEGMENT
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
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/MaterialCreateCh" &
    "ange/v1/types")>
    Partial Public Class ZXMATM02TypeIDOCE1MARAME1MLGNME1MLGTM

        Private mSGFNField As String

        Private lGTYPField As String

        Private lVORMField As String

        Private lGPLAField As String

        Private lPMAXField As String

        Private lPMINField As String

        Private mAMNGField As String

        Private nSMNGField As String

        Private kOBERField As String

        Private rDMNGField As String

        Private sEGMENTField As ZXMATM02TypeIDOCE1MARAME1MLGNME1MLGTMSEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property MSGFN() As String
            Get
                Return Me.mSGFNField
            End Get
            Set
                Me.mSGFNField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public Property LGTYP() As String
            Get
                Return Me.lGTYPField
            End Get
            Set
                Me.lGTYPField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>
        Public Property LVORM() As String
            Get
                Return Me.lVORMField
            End Get
            Set
                Me.lVORMField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=3)>
        Public Property LGPLA() As String
            Get
                Return Me.lGPLAField
            End Get
            Set
                Me.lGPLAField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=4)>
        Public Property LPMAX() As String
            Get
                Return Me.lPMAXField
            End Get
            Set
                Me.lPMAXField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=5)>
        Public Property LPMIN() As String
            Get
                Return Me.lPMINField
            End Get
            Set
                Me.lPMINField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=6)>
        Public Property MAMNG() As String
            Get
                Return Me.mAMNGField
            End Get
            Set
                Me.mAMNGField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=7)>
        Public Property NSMNG() As String
            Get
                Return Me.nSMNGField
            End Get
            Set
                Me.nSMNGField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=8)>
        Public Property KOBER() As String
            Get
                Return Me.kOBERField
            End Get
            Set
                Me.kOBERField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=9)>
        Public Property RDMNG() As String
            Get
                Return Me.rDMNGField
            End Get
            Set
                Me.rDMNGField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property SEGMENT() As ZXMATM02TypeIDOCE1MARAME1MLGNME1MLGTMSEGMENT
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
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/MaterialCreateCh" &
    "ange/v1/types")>
    Public Enum ZXMATM02TypeIDOCE1MARAME1MLGNME1MLGTMSEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/MaterialCreateCh" &
    "ange/v1/types")>
    Public Enum ZXMATM02TypeIDOCE1MARAME1MLGNMSEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Diagnostics.DebuggerStepThroughAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/MaterialCreateCh" &
    "ange/v1/types")>
    Partial Public Class ZXMATM02TypeIDOCE1MARAME1MVKEM

        Private mSGFNField As String

        Private vKORGField As String

        Private vTWEGField As String

        Private lVORMField As String

        Private vERSGField As String

        Private bONUSField As String

        Private pROVGField As String

        Private sKTOFField As String

        Private vMSTAField As String

        Private vMSTDField As String

        Private aUMNGField As String

        Private lFMNGField As String

        Private eFMNGField As String

        Private sCMNGField As String

        Private sCHMEField As String

        Private vRKMEField As String

        Private mTPOSField As String

        Private dWERKField As String

        Private pRODHField As String

        Private pMATNField As String

        Private kONDMField As String

        Private kTGRMField As String

        Private mVGR1Field As String

        Private mVGR2Field As String

        Private mVGR3Field As String

        Private mVGR4Field As String

        Private mVGR5Field As String

        Private sSTUFField As String

        Private pFLKSField As String

        Private lSTFLField As String

        Private lSTVZField As String

        Private lSTAKField As String

        Private pRAT1Field As String

        Private pRAT2Field As String

        Private pRAT3Field As String

        Private pRAT4Field As String

        Private pRAT5Field As String

        Private pRAT6Field As String

        Private pRAT7Field As String

        Private pRAT8Field As String

        Private pRAT9Field As String

        Private pRATAField As String

        Private vAVMEField As String

        Private rDPRFField As String

        Private mEGRUField As String

        Private pMATN_EXTERNALField As String

        Private pMATN_VERSIONField As String

        Private pMATN_GUIDField As String

        Private sEGMENTField As ZXMATM02TypeIDOCE1MARAME1MVKEMSEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property MSGFN() As String
            Get
                Return Me.mSGFNField
            End Get
            Set
                Me.mSGFNField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public Property VKORG() As String
            Get
                Return Me.vKORGField
            End Get
            Set
                Me.vKORGField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>
        Public Property VTWEG() As String
            Get
                Return Me.vTWEGField
            End Get
            Set
                Me.vTWEGField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=3)>
        Public Property LVORM() As String
            Get
                Return Me.lVORMField
            End Get
            Set
                Me.lVORMField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=4)>
        Public Property VERSG() As String
            Get
                Return Me.vERSGField
            End Get
            Set
                Me.vERSGField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=5)>
        Public Property BONUS() As String
            Get
                Return Me.bONUSField
            End Get
            Set
                Me.bONUSField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=6)>
        Public Property PROVG() As String
            Get
                Return Me.pROVGField
            End Get
            Set
                Me.pROVGField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=7)>
        Public Property SKTOF() As String
            Get
                Return Me.sKTOFField
            End Get
            Set
                Me.sKTOFField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=8)>
        Public Property VMSTA() As String
            Get
                Return Me.vMSTAField
            End Get
            Set
                Me.vMSTAField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=9)>
        Public Property VMSTD() As String
            Get
                Return Me.vMSTDField
            End Get
            Set
                Me.vMSTDField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=10)>
        Public Property AUMNG() As String
            Get
                Return Me.aUMNGField
            End Get
            Set
                Me.aUMNGField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=11)>
        Public Property LFMNG() As String
            Get
                Return Me.lFMNGField
            End Get
            Set
                Me.lFMNGField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=12)>
        Public Property EFMNG() As String
            Get
                Return Me.eFMNGField
            End Get
            Set
                Me.eFMNGField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=13)>
        Public Property SCMNG() As String
            Get
                Return Me.sCMNGField
            End Get
            Set
                Me.sCMNGField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=14)>
        Public Property SCHME() As String
            Get
                Return Me.sCHMEField
            End Get
            Set
                Me.sCHMEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=15)>
        Public Property VRKME() As String
            Get
                Return Me.vRKMEField
            End Get
            Set
                Me.vRKMEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=16)>
        Public Property MTPOS() As String
            Get
                Return Me.mTPOSField
            End Get
            Set
                Me.mTPOSField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=17)>
        Public Property DWERK() As String
            Get
                Return Me.dWERKField
            End Get
            Set
                Me.dWERKField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=18)>
        Public Property PRODH() As String
            Get
                Return Me.pRODHField
            End Get
            Set
                Me.pRODHField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=19)>
        Public Property PMATN() As String
            Get
                Return Me.pMATNField
            End Get
            Set
                Me.pMATNField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=20)>
        Public Property KONDM() As String
            Get
                Return Me.kONDMField
            End Get
            Set
                Me.kONDMField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=21)>
        Public Property KTGRM() As String
            Get
                Return Me.kTGRMField
            End Get
            Set
                Me.kTGRMField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=22)>
        Public Property MVGR1() As String
            Get
                Return Me.mVGR1Field
            End Get
            Set
                Me.mVGR1Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=23)>
        Public Property MVGR2() As String
            Get
                Return Me.mVGR2Field
            End Get
            Set
                Me.mVGR2Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=24)>
        Public Property MVGR3() As String
            Get
                Return Me.mVGR3Field
            End Get
            Set
                Me.mVGR3Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=25)>
        Public Property MVGR4() As String
            Get
                Return Me.mVGR4Field
            End Get
            Set
                Me.mVGR4Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=26)>
        Public Property MVGR5() As String
            Get
                Return Me.mVGR5Field
            End Get
            Set
                Me.mVGR5Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=27)>
        Public Property SSTUF() As String
            Get
                Return Me.sSTUFField
            End Get
            Set
                Me.sSTUFField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=28)>
        Public Property PFLKS() As String
            Get
                Return Me.pFLKSField
            End Get
            Set
                Me.pFLKSField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=29)>
        Public Property LSTFL() As String
            Get
                Return Me.lSTFLField
            End Get
            Set
                Me.lSTFLField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=30)>
        Public Property LSTVZ() As String
            Get
                Return Me.lSTVZField
            End Get
            Set
                Me.lSTVZField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=31)>
        Public Property LSTAK() As String
            Get
                Return Me.lSTAKField
            End Get
            Set
                Me.lSTAKField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=32)>
        Public Property PRAT1() As String
            Get
                Return Me.pRAT1Field
            End Get
            Set
                Me.pRAT1Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=33)>
        Public Property PRAT2() As String
            Get
                Return Me.pRAT2Field
            End Get
            Set
                Me.pRAT2Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=34)>
        Public Property PRAT3() As String
            Get
                Return Me.pRAT3Field
            End Get
            Set
                Me.pRAT3Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=35)>
        Public Property PRAT4() As String
            Get
                Return Me.pRAT4Field
            End Get
            Set
                Me.pRAT4Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=36)>
        Public Property PRAT5() As String
            Get
                Return Me.pRAT5Field
            End Get
            Set
                Me.pRAT5Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=37)>
        Public Property PRAT6() As String
            Get
                Return Me.pRAT6Field
            End Get
            Set
                Me.pRAT6Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=38)>
        Public Property PRAT7() As String
            Get
                Return Me.pRAT7Field
            End Get
            Set
                Me.pRAT7Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=39)>
        Public Property PRAT8() As String
            Get
                Return Me.pRAT8Field
            End Get
            Set
                Me.pRAT8Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=40)>
        Public Property PRAT9() As String
            Get
                Return Me.pRAT9Field
            End Get
            Set
                Me.pRAT9Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=41)>
        Public Property PRATA() As String
            Get
                Return Me.pRATAField
            End Get
            Set
                Me.pRATAField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=42)>
        Public Property VAVME() As String
            Get
                Return Me.vAVMEField
            End Get
            Set
                Me.vAVMEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=43)>
        Public Property RDPRF() As String
            Get
                Return Me.rDPRFField
            End Get
            Set
                Me.rDPRFField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=44)>
        Public Property MEGRU() As String
            Get
                Return Me.mEGRUField
            End Get
            Set
                Me.mEGRUField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=45)>
        Public Property PMATN_EXTERNAL() As String
            Get
                Return Me.pMATN_EXTERNALField
            End Get
            Set
                Me.pMATN_EXTERNALField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=46)>
        Public Property PMATN_VERSION() As String
            Get
                Return Me.pMATN_VERSIONField
            End Get
            Set
                Me.pMATN_VERSIONField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=47)>
        Public Property PMATN_GUID() As String
            Get
                Return Me.pMATN_GUIDField
            End Get
            Set
                Me.pMATN_GUIDField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property SEGMENT() As ZXMATM02TypeIDOCE1MARAME1MVKEMSEGMENT
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
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/MaterialCreateCh" &
    "ange/v1/types")>
    Public Enum ZXMATM02TypeIDOCE1MARAME1MVKEMSEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Diagnostics.DebuggerStepThroughAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/MaterialCreateCh" &
    "ange/v1/types")>
    Partial Public Class ZXMATM02TypeIDOCE1MARAME1MLANM

        Private mSGFNField As String

        Private aLANDField As String

        Private tATY1Field As String

        Private tAXM1Field As String

        Private tATY2Field As String

        Private tAXM2Field As String

        Private tATY3Field As String

        Private tAXM3Field As String

        Private tATY4Field As String

        Private tAXM4Field As String

        Private tATY5Field As String

        Private tAXM5Field As String

        Private tATY6Field As String

        Private tAXM6Field As String

        Private tATY7Field As String

        Private tAXM7Field As String

        Private tATY8Field As String

        Private tAXM8Field As String

        Private tATY9Field As String

        Private tAXM9Field As String

        Private tAXIMField As String

        Private sEGMENTField As ZXMATM02TypeIDOCE1MARAME1MLANMSEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property MSGFN() As String
            Get
                Return Me.mSGFNField
            End Get
            Set
                Me.mSGFNField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public Property ALAND() As String
            Get
                Return Me.aLANDField
            End Get
            Set
                Me.aLANDField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>
        Public Property TATY1() As String
            Get
                Return Me.tATY1Field
            End Get
            Set
                Me.tATY1Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=3)>
        Public Property TAXM1() As String
            Get
                Return Me.tAXM1Field
            End Get
            Set
                Me.tAXM1Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=4)>
        Public Property TATY2() As String
            Get
                Return Me.tATY2Field
            End Get
            Set
                Me.tATY2Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=5)>
        Public Property TAXM2() As String
            Get
                Return Me.tAXM2Field
            End Get
            Set
                Me.tAXM2Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=6)>
        Public Property TATY3() As String
            Get
                Return Me.tATY3Field
            End Get
            Set
                Me.tATY3Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=7)>
        Public Property TAXM3() As String
            Get
                Return Me.tAXM3Field
            End Get
            Set
                Me.tAXM3Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=8)>
        Public Property TATY4() As String
            Get
                Return Me.tATY4Field
            End Get
            Set
                Me.tATY4Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=9)>
        Public Property TAXM4() As String
            Get
                Return Me.tAXM4Field
            End Get
            Set
                Me.tAXM4Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=10)>
        Public Property TATY5() As String
            Get
                Return Me.tATY5Field
            End Get
            Set
                Me.tATY5Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=11)>
        Public Property TAXM5() As String
            Get
                Return Me.tAXM5Field
            End Get
            Set
                Me.tAXM5Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=12)>
        Public Property TATY6() As String
            Get
                Return Me.tATY6Field
            End Get
            Set
                Me.tATY6Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=13)>
        Public Property TAXM6() As String
            Get
                Return Me.tAXM6Field
            End Get
            Set
                Me.tAXM6Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=14)>
        Public Property TATY7() As String
            Get
                Return Me.tATY7Field
            End Get
            Set
                Me.tATY7Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=15)>
        Public Property TAXM7() As String
            Get
                Return Me.tAXM7Field
            End Get
            Set
                Me.tAXM7Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=16)>
        Public Property TATY8() As String
            Get
                Return Me.tATY8Field
            End Get
            Set
                Me.tATY8Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=17)>
        Public Property TAXM8() As String
            Get
                Return Me.tAXM8Field
            End Get
            Set
                Me.tAXM8Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=18)>
        Public Property TATY9() As String
            Get
                Return Me.tATY9Field
            End Get
            Set
                Me.tATY9Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=19)>
        Public Property TAXM9() As String
            Get
                Return Me.tAXM9Field
            End Get
            Set
                Me.tAXM9Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=20)>
        Public Property TAXIM() As String
            Get
                Return Me.tAXIMField
            End Get
            Set
                Me.tAXIMField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property SEGMENT() As ZXMATM02TypeIDOCE1MARAME1MLANMSEGMENT
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
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/MaterialCreateCh" &
    "ange/v1/types")>
    Public Enum ZXMATM02TypeIDOCE1MARAME1MLANMSEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Diagnostics.DebuggerStepThroughAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/MaterialCreateCh" &
    "ange/v1/types")>
    Partial Public Class ZXMATM02TypeIDOCE1MARAME1MTXHM

        Private mSGFNField As String

        Private tDOBJECTField As String

        Private tDNAMEField As String

        Private tDIDField As String

        Private tDSPRASField As String

        Private tDTEXTTYPEField As String

        Private sPRAS_ISOField As String

        Private e1MTXLMField() As ZXMATM02TypeIDOCE1MARAME1MTXHME1MTXLM

        Private sEGMENTField As ZXMATM02TypeIDOCE1MARAME1MTXHMSEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property MSGFN() As String
            Get
                Return Me.mSGFNField
            End Get
            Set
                Me.mSGFNField = Value
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
        Public Property TDNAME() As String
            Get
                Return Me.tDNAMEField
            End Get
            Set
                Me.tDNAMEField = Value
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
        Public Property SPRAS_ISO() As String
            Get
                Return Me.sPRAS_ISOField
            End Get
            Set
                Me.sPRAS_ISOField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("E1MTXLM", Order:=7)>
        Public Property E1MTXLM() As ZXMATM02TypeIDOCE1MARAME1MTXHME1MTXLM()
            Get
                Return Me.e1MTXLMField
            End Get
            Set
                Me.e1MTXLMField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property SEGMENT() As ZXMATM02TypeIDOCE1MARAME1MTXHMSEGMENT
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
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/MaterialCreateCh" &
    "ange/v1/types")>
    Partial Public Class ZXMATM02TypeIDOCE1MARAME1MTXHME1MTXLM

        Private mSGFNField As String

        Private tDFORMATField As String

        Private tDLINEField As String

        Private sEGMENTField As ZXMATM02TypeIDOCE1MARAME1MTXHME1MTXLMSEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property MSGFN() As String
            Get
                Return Me.mSGFNField
            End Get
            Set
                Me.mSGFNField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public Property TDFORMAT() As String
            Get
                Return Me.tDFORMATField
            End Get
            Set
                Me.tDFORMATField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>
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
        Public Property SEGMENT() As ZXMATM02TypeIDOCE1MARAME1MTXHME1MTXLMSEGMENT
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
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/MaterialCreateCh" &
    "ange/v1/types")>
    Public Enum ZXMATM02TypeIDOCE1MARAME1MTXHME1MTXLMSEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/MaterialCreateCh" &
    "ange/v1/types")>
    Public Enum ZXMATM02TypeIDOCE1MARAME1MTXHMSEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Diagnostics.DebuggerStepThroughAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/MaterialCreateCh" &
    "ange/v1/types")>
    Partial Public Class ZXMATM02TypeIDOCE1MARAME1CUCFG

        Private pOSEXField As String

        Private cONFIG_IDField As String

        Private rOOT_IDField As String

        Private sCEField As String

        Private kBNAMEField As String

        Private kBVERSIONField As String

        Private cOMPLETEField As String

        Private cONSISTENTField As String

        Private cFGINFOField As String

        Private kBPROFILEField As String

        Private kBLANGUAGEField As String

        Private cBASE_IDField As String

        Private cBASE_ID_TYPEField As String

        Private e1CUINSField() As ZXMATM02TypeIDOCE1MARAME1CUCFGE1CUINS

        Private e1CUVALField() As ZXMATM02TypeIDOCE1MARAME1CUCFGE1CUVAL

        Private e1CUCOMField() As ZXMATM02TypeIDOCE1MARAME1CUCFGE1CUCOM

        Private sEGMENTField As ZXMATM02TypeIDOCE1MARAME1CUCFGSEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property POSEX() As String
            Get
                Return Me.pOSEXField
            End Get
            Set
                Me.pOSEXField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public Property CONFIG_ID() As String
            Get
                Return Me.cONFIG_IDField
            End Get
            Set
                Me.cONFIG_IDField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>
        Public Property ROOT_ID() As String
            Get
                Return Me.rOOT_IDField
            End Get
            Set
                Me.rOOT_IDField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=3)>
        Public Property SCE() As String
            Get
                Return Me.sCEField
            End Get
            Set
                Me.sCEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=4)>
        Public Property KBNAME() As String
            Get
                Return Me.kBNAMEField
            End Get
            Set
                Me.kBNAMEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=5)>
        Public Property KBVERSION() As String
            Get
                Return Me.kBVERSIONField
            End Get
            Set
                Me.kBVERSIONField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=6)>
        Public Property COMPLETE() As String
            Get
                Return Me.cOMPLETEField
            End Get
            Set
                Me.cOMPLETEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=7)>
        Public Property CONSISTENT() As String
            Get
                Return Me.cONSISTENTField
            End Get
            Set
                Me.cONSISTENTField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=8)>
        Public Property CFGINFO() As String
            Get
                Return Me.cFGINFOField
            End Get
            Set
                Me.cFGINFOField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=9)>
        Public Property KBPROFILE() As String
            Get
                Return Me.kBPROFILEField
            End Get
            Set
                Me.kBPROFILEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=10)>
        Public Property KBLANGUAGE() As String
            Get
                Return Me.kBLANGUAGEField
            End Get
            Set
                Me.kBLANGUAGEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=11)>
        Public Property CBASE_ID() As String
            Get
                Return Me.cBASE_IDField
            End Get
            Set
                Me.cBASE_IDField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=12)>
        Public Property CBASE_ID_TYPE() As String
            Get
                Return Me.cBASE_ID_TYPEField
            End Get
            Set
                Me.cBASE_ID_TYPEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("E1CUINS", Order:=13)>
        Public Property E1CUINS() As ZXMATM02TypeIDOCE1MARAME1CUCFGE1CUINS()
            Get
                Return Me.e1CUINSField
            End Get
            Set
                Me.e1CUINSField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("E1CUVAL", Order:=14)>
        Public Property E1CUVAL() As ZXMATM02TypeIDOCE1MARAME1CUCFGE1CUVAL()
            Get
                Return Me.e1CUVALField
            End Get
            Set
                Me.e1CUVALField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("E1CUCOM", Order:=15)>
        Public Property E1CUCOM() As ZXMATM02TypeIDOCE1MARAME1CUCFGE1CUCOM()
            Get
                Return Me.e1CUCOMField
            End Get
            Set
                Me.e1CUCOMField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property SEGMENT() As ZXMATM02TypeIDOCE1MARAME1CUCFGSEGMENT
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
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/MaterialCreateCh" &
    "ange/v1/types")>
    Partial Public Class ZXMATM02TypeIDOCE1MARAME1CUCFGE1CUINS

        Private iNST_IDField As String

        Private oBJ_TYPEField As String

        Private cLASS_TYPEField As String

        Private oBJ_KEYField As String

        Private oBJ_TXTField As String

        Private qUANTITYField As String

        Private aUTHORField As String

        Private qUANTITY_UNITField As String

        Private cOMPLETEField As String

        Private cONSISTENTField As String

        Private oBJECT_GUIDField As String

        Private pERSIST_IDField As String

        Private pERSIST_ID_TYPEField As String

        Private sEGMENTField As ZXMATM02TypeIDOCE1MARAME1CUCFGE1CUINSSEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property INST_ID() As String
            Get
                Return Me.iNST_IDField
            End Get
            Set
                Me.iNST_IDField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public Property OBJ_TYPE() As String
            Get
                Return Me.oBJ_TYPEField
            End Get
            Set
                Me.oBJ_TYPEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>
        Public Property CLASS_TYPE() As String
            Get
                Return Me.cLASS_TYPEField
            End Get
            Set
                Me.cLASS_TYPEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=3)>
        Public Property OBJ_KEY() As String
            Get
                Return Me.oBJ_KEYField
            End Get
            Set
                Me.oBJ_KEYField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=4)>
        Public Property OBJ_TXT() As String
            Get
                Return Me.oBJ_TXTField
            End Get
            Set
                Me.oBJ_TXTField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=5)>
        Public Property QUANTITY() As String
            Get
                Return Me.qUANTITYField
            End Get
            Set
                Me.qUANTITYField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=6)>
        Public Property AUTHOR() As String
            Get
                Return Me.aUTHORField
            End Get
            Set
                Me.aUTHORField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=7)>
        Public Property QUANTITY_UNIT() As String
            Get
                Return Me.qUANTITY_UNITField
            End Get
            Set
                Me.qUANTITY_UNITField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=8)>
        Public Property COMPLETE() As String
            Get
                Return Me.cOMPLETEField
            End Get
            Set
                Me.cOMPLETEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=9)>
        Public Property CONSISTENT() As String
            Get
                Return Me.cONSISTENTField
            End Get
            Set
                Me.cONSISTENTField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=10)>
        Public Property OBJECT_GUID() As String
            Get
                Return Me.oBJECT_GUIDField
            End Get
            Set
                Me.oBJECT_GUIDField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=11)>
        Public Property PERSIST_ID() As String
            Get
                Return Me.pERSIST_IDField
            End Get
            Set
                Me.pERSIST_IDField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=12)>
        Public Property PERSIST_ID_TYPE() As String
            Get
                Return Me.pERSIST_ID_TYPEField
            End Get
            Set
                Me.pERSIST_ID_TYPEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property SEGMENT() As ZXMATM02TypeIDOCE1MARAME1CUCFGE1CUINSSEGMENT
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
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/MaterialCreateCh" &
    "ange/v1/types")>
    Public Enum ZXMATM02TypeIDOCE1MARAME1CUCFGE1CUINSSEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Diagnostics.DebuggerStepThroughAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/MaterialCreateCh" &
    "ange/v1/types")>
    Partial Public Class ZXMATM02TypeIDOCE1MARAME1CUCFGE1CUVAL

        Private iNST_IDField As String

        Private cHARCField As String

        Private cHARC_TXTField As String

        Private vALUEField As String

        Private vALUE_TXTField As String

        Private aUTHORField As String

        Private vALUE_TOField As String

        Private vALCODEField As String

        Private sEGMENTField As ZXMATM02TypeIDOCE1MARAME1CUCFGE1CUVALSEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property INST_ID() As String
            Get
                Return Me.iNST_IDField
            End Get
            Set
                Me.iNST_IDField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public Property CHARC() As String
            Get
                Return Me.cHARCField
            End Get
            Set
                Me.cHARCField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>
        Public Property CHARC_TXT() As String
            Get
                Return Me.cHARC_TXTField
            End Get
            Set
                Me.cHARC_TXTField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=3)>
        Public Property VALUE() As String
            Get
                Return Me.vALUEField
            End Get
            Set
                Me.vALUEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=4)>
        Public Property VALUE_TXT() As String
            Get
                Return Me.vALUE_TXTField
            End Get
            Set
                Me.vALUE_TXTField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=5)>
        Public Property AUTHOR() As String
            Get
                Return Me.aUTHORField
            End Get
            Set
                Me.aUTHORField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=6)>
        Public Property VALUE_TO() As String
            Get
                Return Me.vALUE_TOField
            End Get
            Set
                Me.vALUE_TOField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=7)>
        Public Property VALCODE() As String
            Get
                Return Me.vALCODEField
            End Get
            Set
                Me.vALCODEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property SEGMENT() As ZXMATM02TypeIDOCE1MARAME1CUCFGE1CUVALSEGMENT
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
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/MaterialCreateCh" &
    "ange/v1/types")>
    Public Enum ZXMATM02TypeIDOCE1MARAME1CUCFGE1CUVALSEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Diagnostics.DebuggerStepThroughAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/MaterialCreateCh" &
    "ange/v1/types")>
    Partial Public Class ZXMATM02TypeIDOCE1MARAME1CUCFGE1CUCOM

        Private mSGFNField As String

        Private c_PROFILEField As String

        Private cLASSTYPEField As String

        Private oRGAREASField As String

        Private sTATUSField As String

        Private bOMAPPLField As String

        Private fLAVAILCHField As String

        Private bOMEXPLField As String

        Private tASKLEXPLField As String

        Private iNITSCREENField As String

        Private fLASSEMBLYField As String

        Private fLRESULTField As String

        Private fLMDATAField As String

        Private fLCASONLYField As String

        Private fLMANCHANGField As String

        Private fLHOLDBOMField As String

        Private fLDELETEField As String

        Private dESIGNField As String

        Private nEUTRField As String

        Private cHAR_VALUField As String

        Private a_LAISOField As String

        Private sCOPE_CHARField As String

        Private sCOPE_VALUField As String

        Private fL_EXCLUDEField As String

        Private dISPLAYField As String

        Private pRICINGField As String

        Private cONFIGURField As String

        Private dEFVALU_DEField As String

        Private fL_MARKField As String

        Private dEFVALU_CCField As String

        Private tYPM_SELField As String

        Private tYPM_STRAField As String

        Private fL_SC_CHARField As String

        Private fL_SC_DEPField As String

        Private fL_SC_KNField As String

        Private fL_SC_CMPFField As String

        Private mULTIL_STRUField As String

        Private fL_DPSEUField As String

        Private oB_FIXField As String

        Private oB_INSTField As String

        Private fL_EOASLField As String

        Private fL_SAASLField As String

        Private fL_OBJ_MATField As String

        Private fL_OBJ_DOCField As String

        Private fL_OBJ_CLSField As String

        Private fL_OBJ_TXTField As String

        Private fL_SDRELField As String

        Private fL_KORELField As String

        Private fL_FERELField As String

        Private fL_INRELField As String

        Private fL_KARELField As String

        Private pOSTYPENField As String

        Private sORTF1Field As String

        Private sORTF2Field As String

        Private sORTF3Field As String

        Private sORTF4Field As String

        Private sORTF5Field As String

        Private cLASSF1Field As String

        Private cLASSF2Field As String

        Private cLASSF3Field As String

        Private cLASSF4Field As String

        Private cLASSF5Field As String

        Private pRIOField As String

        Private pRSTLField As String

        Private uMBEWField As String

        Private fLBROWSERField As String

        Private fL_PROF_OBOMField As String

        Private sEGMENTField As ZXMATM02TypeIDOCE1MARAME1CUCFGE1CUCOMSEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property MSGFN() As String
            Get
                Return Me.mSGFNField
            End Get
            Set
                Me.mSGFNField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public Property C_PROFILE() As String
            Get
                Return Me.c_PROFILEField
            End Get
            Set
                Me.c_PROFILEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>
        Public Property CLASSTYPE() As String
            Get
                Return Me.cLASSTYPEField
            End Get
            Set
                Me.cLASSTYPEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=3)>
        Public Property ORGAREAS() As String
            Get
                Return Me.oRGAREASField
            End Get
            Set
                Me.oRGAREASField = Value
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
        Public Property BOMAPPL() As String
            Get
                Return Me.bOMAPPLField
            End Get
            Set
                Me.bOMAPPLField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=6)>
        Public Property FLAVAILCH() As String
            Get
                Return Me.fLAVAILCHField
            End Get
            Set
                Me.fLAVAILCHField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=7)>
        Public Property BOMEXPL() As String
            Get
                Return Me.bOMEXPLField
            End Get
            Set
                Me.bOMEXPLField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=8)>
        Public Property TASKLEXPL() As String
            Get
                Return Me.tASKLEXPLField
            End Get
            Set
                Me.tASKLEXPLField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=9)>
        Public Property INITSCREEN() As String
            Get
                Return Me.iNITSCREENField
            End Get
            Set
                Me.iNITSCREENField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=10)>
        Public Property FLASSEMBLY() As String
            Get
                Return Me.fLASSEMBLYField
            End Get
            Set
                Me.fLASSEMBLYField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=11)>
        Public Property FLRESULT() As String
            Get
                Return Me.fLRESULTField
            End Get
            Set
                Me.fLRESULTField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=12)>
        Public Property FLMDATA() As String
            Get
                Return Me.fLMDATAField
            End Get
            Set
                Me.fLMDATAField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=13)>
        Public Property FLCASONLY() As String
            Get
                Return Me.fLCASONLYField
            End Get
            Set
                Me.fLCASONLYField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=14)>
        Public Property FLMANCHANG() As String
            Get
                Return Me.fLMANCHANGField
            End Get
            Set
                Me.fLMANCHANGField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=15)>
        Public Property FLHOLDBOM() As String
            Get
                Return Me.fLHOLDBOMField
            End Get
            Set
                Me.fLHOLDBOMField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=16)>
        Public Property FLDELETE() As String
            Get
                Return Me.fLDELETEField
            End Get
            Set
                Me.fLDELETEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=17)>
        Public Property DESIGN() As String
            Get
                Return Me.dESIGNField
            End Get
            Set
                Me.dESIGNField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=18)>
        Public Property NEUTR() As String
            Get
                Return Me.nEUTRField
            End Get
            Set
                Me.nEUTRField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=19)>
        Public Property CHAR_VALU() As String
            Get
                Return Me.cHAR_VALUField
            End Get
            Set
                Me.cHAR_VALUField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=20)>
        Public Property A_LAISO() As String
            Get
                Return Me.a_LAISOField
            End Get
            Set
                Me.a_LAISOField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=21)>
        Public Property SCOPE_CHAR() As String
            Get
                Return Me.sCOPE_CHARField
            End Get
            Set
                Me.sCOPE_CHARField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=22)>
        Public Property SCOPE_VALU() As String
            Get
                Return Me.sCOPE_VALUField
            End Get
            Set
                Me.sCOPE_VALUField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=23)>
        Public Property FL_EXCLUDE() As String
            Get
                Return Me.fL_EXCLUDEField
            End Get
            Set
                Me.fL_EXCLUDEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=24)>
        Public Property DISPLAY() As String
            Get
                Return Me.dISPLAYField
            End Get
            Set
                Me.dISPLAYField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=25)>
        Public Property PRICING() As String
            Get
                Return Me.pRICINGField
            End Get
            Set
                Me.pRICINGField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=26)>
        Public Property CONFIGUR() As String
            Get
                Return Me.cONFIGURField
            End Get
            Set
                Me.cONFIGURField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=27)>
        Public Property DEFVALU_DE() As String
            Get
                Return Me.dEFVALU_DEField
            End Get
            Set
                Me.dEFVALU_DEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=28)>
        Public Property FL_MARK() As String
            Get
                Return Me.fL_MARKField
            End Get
            Set
                Me.fL_MARKField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=29)>
        Public Property DEFVALU_CC() As String
            Get
                Return Me.dEFVALU_CCField
            End Get
            Set
                Me.dEFVALU_CCField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=30)>
        Public Property TYPM_SEL() As String
            Get
                Return Me.tYPM_SELField
            End Get
            Set
                Me.tYPM_SELField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=31)>
        Public Property TYPM_STRA() As String
            Get
                Return Me.tYPM_STRAField
            End Get
            Set
                Me.tYPM_STRAField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=32)>
        Public Property FL_SC_CHAR() As String
            Get
                Return Me.fL_SC_CHARField
            End Get
            Set
                Me.fL_SC_CHARField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=33)>
        Public Property FL_SC_DEP() As String
            Get
                Return Me.fL_SC_DEPField
            End Get
            Set
                Me.fL_SC_DEPField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=34)>
        Public Property FL_SC_KN() As String
            Get
                Return Me.fL_SC_KNField
            End Get
            Set
                Me.fL_SC_KNField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=35)>
        Public Property FL_SC_CMPF() As String
            Get
                Return Me.fL_SC_CMPFField
            End Get
            Set
                Me.fL_SC_CMPFField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=36)>
        Public Property MULTIL_STRU() As String
            Get
                Return Me.mULTIL_STRUField
            End Get
            Set
                Me.mULTIL_STRUField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=37)>
        Public Property FL_DPSEU() As String
            Get
                Return Me.fL_DPSEUField
            End Get
            Set
                Me.fL_DPSEUField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=38)>
        Public Property OB_FIX() As String
            Get
                Return Me.oB_FIXField
            End Get
            Set
                Me.oB_FIXField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=39)>
        Public Property OB_INST() As String
            Get
                Return Me.oB_INSTField
            End Get
            Set
                Me.oB_INSTField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=40)>
        Public Property FL_EOASL() As String
            Get
                Return Me.fL_EOASLField
            End Get
            Set
                Me.fL_EOASLField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=41)>
        Public Property FL_SAASL() As String
            Get
                Return Me.fL_SAASLField
            End Get
            Set
                Me.fL_SAASLField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=42)>
        Public Property FL_OBJ_MAT() As String
            Get
                Return Me.fL_OBJ_MATField
            End Get
            Set
                Me.fL_OBJ_MATField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=43)>
        Public Property FL_OBJ_DOC() As String
            Get
                Return Me.fL_OBJ_DOCField
            End Get
            Set
                Me.fL_OBJ_DOCField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=44)>
        Public Property FL_OBJ_CLS() As String
            Get
                Return Me.fL_OBJ_CLSField
            End Get
            Set
                Me.fL_OBJ_CLSField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=45)>
        Public Property FL_OBJ_TXT() As String
            Get
                Return Me.fL_OBJ_TXTField
            End Get
            Set
                Me.fL_OBJ_TXTField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=46)>
        Public Property FL_SDREL() As String
            Get
                Return Me.fL_SDRELField
            End Get
            Set
                Me.fL_SDRELField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=47)>
        Public Property FL_KOREL() As String
            Get
                Return Me.fL_KORELField
            End Get
            Set
                Me.fL_KORELField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=48)>
        Public Property FL_FEREL() As String
            Get
                Return Me.fL_FERELField
            End Get
            Set
                Me.fL_FERELField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=49)>
        Public Property FL_INREL() As String
            Get
                Return Me.fL_INRELField
            End Get
            Set
                Me.fL_INRELField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=50)>
        Public Property FL_KAREL() As String
            Get
                Return Me.fL_KARELField
            End Get
            Set
                Me.fL_KARELField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=51)>
        Public Property POSTYPEN() As String
            Get
                Return Me.pOSTYPENField
            End Get
            Set
                Me.pOSTYPENField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=52)>
        Public Property SORTF1() As String
            Get
                Return Me.sORTF1Field
            End Get
            Set
                Me.sORTF1Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=53)>
        Public Property SORTF2() As String
            Get
                Return Me.sORTF2Field
            End Get
            Set
                Me.sORTF2Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=54)>
        Public Property SORTF3() As String
            Get
                Return Me.sORTF3Field
            End Get
            Set
                Me.sORTF3Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=55)>
        Public Property SORTF4() As String
            Get
                Return Me.sORTF4Field
            End Get
            Set
                Me.sORTF4Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=56)>
        Public Property SORTF5() As String
            Get
                Return Me.sORTF5Field
            End Get
            Set
                Me.sORTF5Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=57)>
        Public Property CLASSF1() As String
            Get
                Return Me.cLASSF1Field
            End Get
            Set
                Me.cLASSF1Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=58)>
        Public Property CLASSF2() As String
            Get
                Return Me.cLASSF2Field
            End Get
            Set
                Me.cLASSF2Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=59)>
        Public Property CLASSF3() As String
            Get
                Return Me.cLASSF3Field
            End Get
            Set
                Me.cLASSF3Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=60)>
        Public Property CLASSF4() As String
            Get
                Return Me.cLASSF4Field
            End Get
            Set
                Me.cLASSF4Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=61)>
        Public Property CLASSF5() As String
            Get
                Return Me.cLASSF5Field
            End Get
            Set
                Me.cLASSF5Field = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=62)>
        Public Property PRIO() As String
            Get
                Return Me.pRIOField
            End Get
            Set
                Me.pRIOField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=63)>
        Public Property PRSTL() As String
            Get
                Return Me.pRSTLField
            End Get
            Set
                Me.pRSTLField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=64)>
        Public Property UMBEW() As String
            Get
                Return Me.uMBEWField
            End Get
            Set
                Me.uMBEWField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=65)>
        Public Property FLBROWSER() As String
            Get
                Return Me.fLBROWSERField
            End Get
            Set
                Me.fLBROWSERField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=66)>
        Public Property FL_PROF_OBOM() As String
            Get
                Return Me.fL_PROF_OBOMField
            End Get
            Set
                Me.fL_PROF_OBOMField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property SEGMENT() As ZXMATM02TypeIDOCE1MARAME1CUCFGE1CUCOMSEGMENT
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
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/MaterialCreateCh" &
    "ange/v1/types")>
    Public Enum ZXMATM02TypeIDOCE1MARAME1CUCFGE1CUCOMSEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/MaterialCreateCh" &
    "ange/v1/types")>
    Public Enum ZXMATM02TypeIDOCE1MARAME1CUCFGSEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/MaterialCreateCh" &
    "ange/v1/types")>
    Public Enum ZXMATM02TypeIDOCE1MARAMSEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Diagnostics.DebuggerStepThroughAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/MaterialCreateCh" &
    "ange/v1/types")>
    Partial Public Class ZXMATM02TypeIDOCE1UPSLINK

        Private uPSNAMField As String

        Private oRGNAMField As String

        Private mESTYPField As String

        Private oBJIDField As String

        Private oBJVALField As String

        Private sEGMENTField As ZXMATM02TypeIDOCE1UPSLINKSEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Property UPSNAM() As String
            Get
                Return Me.uPSNAMField
            End Get
            Set
                Me.uPSNAMField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public Property ORGNAM() As String
            Get
                Return Me.oRGNAMField
            End Get
            Set
                Me.oRGNAMField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>
        Public Property MESTYP() As String
            Get
                Return Me.mESTYPField
            End Get
            Set
                Me.mESTYPField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=3)>
        Public Property OBJID() As String
            Get
                Return Me.oBJIDField
            End Get
            Set
                Me.oBJIDField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=4)>
        Public Property OBJVAL() As String
            Get
                Return Me.oBJVALField
            End Get
            Set
                Me.oBJVALField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property SEGMENT() As ZXMATM02TypeIDOCE1UPSLINKSEGMENT
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
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/MaterialCreateCh" &
    "ange/v1/types")>
    Public Enum ZXMATM02TypeIDOCE1UPSLINKSEGMENT

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.2556.0"),
 System.SerializableAttribute(),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/MaterialCreateCh" &
    "ange/v1/types")>
    Public Enum ZXMATM02TypeIDOCBEGIN

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum



    <System.Diagnostics.DebuggerStepThroughAttribute(),
 System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),
 System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),
 System.ServiceModel.MessageContractAttribute(WrapperName:="createOrChangeMaterial", WrapperNamespace:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/MaterialCreateCh" &
    "ange/v1", IsWrapped:=True)>
    Partial Public Class createOrChangeMaterialRequest

        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/MaterialCreateCh" &
        "ange/v1/types", Order:=0),
     System.Xml.Serialization.XmlElementAttribute([Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/MaterialCreateCh" &
        "ange/v1/types")>
        Public context As TCContext

        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/MaterialCreateCh" &
        "ange/v1/types", Order:=1),
     System.Xml.Serialization.XmlElementAttribute([Namespace]:="http://services.tint.telekom.net/SupAndPartMgmt/LogWarehouseMgmt/MaterialCreateCh" &
        "ange/v1/types")>
        Public data As CreateOrChangeMaterialData

        Public Sub New()
            MyBase.New
        End Sub

        Public Sub New(ByVal context As TCContext, ByVal data As CreateOrChangeMaterialData)
            MyBase.New
            Me.context = context
            Me.data = data
        End Sub
    End Class

    <System.Diagnostics.DebuggerStepThroughAttribute(),
 System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),
 System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),
 System.ServiceModel.MessageContractAttribute(WrapperName:="empty", WrapperNamespace:="http://schemas.telekom.net/csdg_v01.02", IsWrapped:=True)>
    Partial Public Class createOrChangeMaterialResponse

        Public Sub New()
            MyBase.New
        End Sub
    End Class

    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>
    Public Interface ImaterialCreateChangeConsumerChannel
        Inherits ImaterialCreateChange, System.ServiceModel.IClientChannel
    End Interface

    <System.Diagnostics.DebuggerStepThroughAttribute(),
 System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>
    Partial Public Class MaterialCreateChangeConsumerClient
        Inherits System.ServiceModel.ClientBase(Of ImaterialCreateChange)
        Implements ImaterialCreateChange

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
        Function MaterialCreateChangeConsumer_createOrChangeMaterial(ByVal request As createOrChangeMaterialRequest) As createOrChangeMaterialResponse Implements ImaterialCreateChange.createOrChangeMaterial
            Return MyBase.Channel.createOrChangeMaterial(request)
        End Function

        Public Sub createOrChangeMaterial(ByVal context As TCContext, ByVal data As CreateOrChangeMaterialData)
            Dim inValue As createOrChangeMaterialRequest = New createOrChangeMaterialRequest()
            inValue.context = context
            inValue.data = data
            Dim retVal As createOrChangeMaterialResponse = CType(Me, ImaterialCreateChange).createOrChangeMaterial(inValue)
        End Sub

        '<System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>
        'Function MaterialCreateChangeConsumer_createOrChangeMaterialAsync(ByVal request As createOrChangeMaterialRequest) As System.Threading.Tasks.Task(Of createOrChangeMaterialResponse) Implements ImaterialCreateChangeConsumer.createOrChangeMaterialAsync
        '    Return MyBase.Channel.createOrChangeMaterialAsync(request)
        'End Function

        'Public Function createOrChangeMaterialAsync(ByVal context As TCContext, ByVal data As CreateOrChangeMaterialData) As System.Threading.Tasks.Task(Of createOrChangeMaterialResponse)
        '    Dim inValue As createOrChangeMaterialRequest = New createOrChangeMaterialRequest()
        '    inValue.context = context
        '    inValue.data = data
        '    Return CType(Me, ImaterialCreateChangeConsumer).createOrChangeMaterialAsync(inValue)
        'End Function
    End Class
End Namespace

