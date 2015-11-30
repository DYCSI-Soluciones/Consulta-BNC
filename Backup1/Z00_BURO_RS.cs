
//------------------------------------------------------------------------------
// 
//     This code was generated by a SAP. NET Connector Proxy Generator Version 2.0
//     Created at 04/02/2011
//     Created from Windows
//
//     Changes to this file may cause incorrect behavior and will be lost if 
//     the code is regenerated.
// 
//------------------------------------------------------------------------------
using System;
using System.Text;
using System.Collections;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
using System.Web.Services;
using System.Web.Services.Description;
using System.Web.Services.Protocols;
using SAP.Connector;

namespace ZConsultaBuro
{

  /// <summary>
  /// 
  /// </summary>
  [RfcStructure(AbapName ="Z00_BURO_RS" , Length = 221, Length2 = 442)]
  [Serializable]
  public class Z00_BURO_RS : SAPStructure
  {
   

    /// <summary>
    /// Client
    /// </summary>
 
    [RfcField(AbapName = "MANDT", RfcType = RFCTYPE.RFCTYPE_CHAR, Length = 3, Length2 = 6, Offset = 0, Offset2 = 0)]
    [XmlElement("MANDT")]
    public string Mandt
    { 
       get
       {
          return _Mandt;
       }
       set
       {
          _Mandt = value;
       }
    }
    private string _Mandt;


    /// <summary>
    /// Contract Number
    /// </summary>
 
    [RfcField(AbapName = "ID_CONSULTA", RfcType = RFCTYPE.RFCTYPE_CHAR, Length = 13, Length2 = 26, Offset = 3, Offset2 = 6)]
    [XmlElement("ID_--5fCONSULTA")]
    public string Id_Consulta
    { 
       get
       {
          return _Id_Consulta;
       }
       set
       {
          _Id_Consulta = value;
       }
    }
    private string _Id_Consulta;


    /// <summary>
    /// 
    /// </summary>
 
    [RfcField(AbapName = "CONSECUTIVO", RfcType = RFCTYPE.RFCTYPE_NUM, Length = 3, Length2 = 6, Offset = 16, Offset2 = 32)]
    [XmlElement("CONSECUTIVO")]
    public string Consecutivo
    { 
       get
       {
          return _Consecutivo;
       }
       set
       {
          _Consecutivo = value;
       }
    }
    private string _Consecutivo;


    /// <summary>
    /// 
    /// </summary>
 
    [RfcField(AbapName = "FECHA_INGRESO", RfcType = RFCTYPE.RFCTYPE_DATE, Length = 8, Length2 = 16, Offset = 19, Offset2 = 38)]
    [XmlElement("FECHA_--5fINGRESO")]
    public string Fecha_Ingreso
    { 
       get
       {
          return _Fecha_Ingreso;
       }
       set
       {
          _Fecha_Ingreso = value;
       }
    }
    private string _Fecha_Ingreso;


    /// <summary>
    /// 
    /// </summary>
 
    [RfcField(AbapName = "NUM_MOP07", RfcType = RFCTYPE.RFCTYPE_NUM, Length = 2, Length2 = 4, Offset = 27, Offset2 = 54)]
    [XmlElement("NUM_--5fMOP07")]
    public string Num_Mop07
    { 
       get
       {
          return _Num_Mop07;
       }
       set
       {
          _Num_Mop07 = value;
       }
    }
    private string _Num_Mop07;


    /// <summary>
    /// 
    /// </summary>
 
    [RfcField(AbapName = "NUM_MOP06", RfcType = RFCTYPE.RFCTYPE_NUM, Length = 2, Length2 = 4, Offset = 29, Offset2 = 58)]
    [XmlElement("NUM_--5fMOP06")]
    public string Num_Mop06
    { 
       get
       {
          return _Num_Mop06;
       }
       set
       {
          _Num_Mop06 = value;
       }
    }
    private string _Num_Mop06;


    /// <summary>
    /// 
    /// </summary>
 
    [RfcField(AbapName = "NUM_MOP05", RfcType = RFCTYPE.RFCTYPE_NUM, Length = 2, Length2 = 4, Offset = 31, Offset2 = 62)]
    [XmlElement("NUM_--5fMOP05")]
    public string Num_Mop05
    { 
       get
       {
          return _Num_Mop05;
       }
       set
       {
          _Num_Mop05 = value;
       }
    }
    private string _Num_Mop05;


    /// <summary>
    /// 
    /// </summary>
 
    [RfcField(AbapName = "NUM_MOP04", RfcType = RFCTYPE.RFCTYPE_NUM, Length = 2, Length2 = 4, Offset = 33, Offset2 = 66)]
    [XmlElement("NUM_--5fMOP04")]
    public string Num_Mop04
    { 
       get
       {
          return _Num_Mop04;
       }
       set
       {
          _Num_Mop04 = value;
       }
    }
    private string _Num_Mop04;


    /// <summary>
    /// 
    /// </summary>
 
    [RfcField(AbapName = "NUM_MOP03", RfcType = RFCTYPE.RFCTYPE_NUM, Length = 2, Length2 = 4, Offset = 35, Offset2 = 70)]
    [XmlElement("NUM_--5fMOP03")]
    public string Num_Mop03
    { 
       get
       {
          return _Num_Mop03;
       }
       set
       {
          _Num_Mop03 = value;
       }
    }
    private string _Num_Mop03;


    /// <summary>
    /// 
    /// </summary>
 
    [RfcField(AbapName = "NUM_MOP02", RfcType = RFCTYPE.RFCTYPE_NUM, Length = 2, Length2 = 4, Offset = 37, Offset2 = 74)]
    [XmlElement("NUM_--5fMOP02")]
    public string Num_Mop02
    { 
       get
       {
          return _Num_Mop02;
       }
       set
       {
          _Num_Mop02 = value;
       }
    }
    private string _Num_Mop02;


    /// <summary>
    /// 
    /// </summary>
 
    [RfcField(AbapName = "NUM_MOP01", RfcType = RFCTYPE.RFCTYPE_NUM, Length = 2, Length2 = 4, Offset = 39, Offset2 = 78)]
    [XmlElement("NUM_--5fMOP01")]
    public string Num_Mop01
    { 
       get
       {
          return _Num_Mop01;
       }
       set
       {
          _Num_Mop01 = value;
       }
    }
    private string _Num_Mop01;


    /// <summary>
    /// 
    /// </summary>
 
    [RfcField(AbapName = "NUM_MOP00", RfcType = RFCTYPE.RFCTYPE_NUM, Length = 2, Length2 = 4, Offset = 41, Offset2 = 82)]
    [XmlElement("NUM_--5fMOP00")]
    public string Num_Mop00
    { 
       get
       {
          return _Num_Mop00;
       }
       set
       {
          _Num_Mop00 = value;
       }
    }
    private string _Num_Mop00;


    /// <summary>
    /// 
    /// </summary>
 
    [RfcField(AbapName = "NUM_MOPUR", RfcType = RFCTYPE.RFCTYPE_NUM, Length = 2, Length2 = 4, Offset = 43, Offset2 = 86)]
    [XmlElement("NUM_--5fMOPUR")]
    public string Num_Mopur
    { 
       get
       {
          return _Num_Mopur;
       }
       set
       {
          _Num_Mopur = value;
       }
    }
    private string _Num_Mopur;


    /// <summary>
    /// 
    /// </summary>
 
    [RfcField(AbapName = "NUM_CUENTAS", RfcType = RFCTYPE.RFCTYPE_NUM, Length = 4, Length2 = 8, Offset = 45, Offset2 = 90)]
    [XmlElement("NUM_--5fCUENTAS")]
    public string Num_Cuentas
    { 
       get
       {
          return _Num_Cuentas;
       }
       set
       {
          _Num_Cuentas = value;
       }
    }
    private string _Num_Cuentas;


    /// <summary>
    /// 
    /// </summary>
 
    [RfcField(AbapName = "CUENTAS_FIJOS", RfcType = RFCTYPE.RFCTYPE_NUM, Length = 4, Length2 = 8, Offset = 49, Offset2 = 98)]
    [XmlElement("CUENTAS_--5fFIJOS")]
    public string Cuentas_Fijos
    { 
       get
       {
          return _Cuentas_Fijos;
       }
       set
       {
          _Cuentas_Fijos = value;
       }
    }
    private string _Cuentas_Fijos;


    /// <summary>
    /// 
    /// </summary>
 
    [RfcField(AbapName = "CUENTAS_REVOL", RfcType = RFCTYPE.RFCTYPE_NUM, Length = 4, Length2 = 8, Offset = 53, Offset2 = 106)]
    [XmlElement("CUENTAS_--5fREVOL")]
    public string Cuentas_Revol
    { 
       get
       {
          return _Cuentas_Revol;
       }
       set
       {
          _Cuentas_Revol = value;
       }
    }
    private string _Cuentas_Revol;


    /// <summary>
    /// 
    /// </summary>
 
    [RfcField(AbapName = "CUENTAS_CERRADAS", RfcType = RFCTYPE.RFCTYPE_NUM, Length = 4, Length2 = 8, Offset = 57, Offset2 = 114)]
    [XmlElement("CUENTAS_--5fCERRADAS")]
    public string Cuentas_Cerradas
    { 
       get
       {
          return _Cuentas_Cerradas;
       }
       set
       {
          _Cuentas_Cerradas = value;
       }
    }
    private string _Cuentas_Cerradas;


    /// <summary>
    /// 
    /// </summary>
 
    [RfcField(AbapName = "CUENTAS_NEG", RfcType = RFCTYPE.RFCTYPE_NUM, Length = 4, Length2 = 8, Offset = 61, Offset2 = 122)]
    [XmlElement("CUENTAS_--5fNEG")]
    public string Cuentas_Neg
    { 
       get
       {
          return _Cuentas_Neg;
       }
       set
       {
          _Cuentas_Neg = value;
       }
    }
    private string _Cuentas_Neg;


    /// <summary>
    /// 
    /// </summary>
 
    [RfcField(AbapName = "CUENTAS_MOP", RfcType = RFCTYPE.RFCTYPE_NUM, Length = 4, Length2 = 8, Offset = 65, Offset2 = 130)]
    [XmlElement("CUENTAS_--5fMOP")]
    public string Cuentas_Mop
    { 
       get
       {
          return _Cuentas_Mop;
       }
       set
       {
          _Cuentas_Mop = value;
       }
    }
    private string _Cuentas_Mop;


    /// <summary>
    /// 
    /// </summary>
 
    [RfcField(AbapName = "CUENTAS_DISPUTA", RfcType = RFCTYPE.RFCTYPE_NUM, Length = 2, Length2 = 4, Offset = 69, Offset2 = 138)]
    [XmlElement("CUENTAS_--5fDISPUTA")]
    public string Cuentas_Disputa
    { 
       get
       {
          return _Cuentas_Disputa;
       }
       set
       {
          _Cuentas_Disputa = value;
       }
    }
    private string _Cuentas_Disputa;


    /// <summary>
    /// 
    /// </summary>
 
    [RfcField(AbapName = "SOLICITUDES", RfcType = RFCTYPE.RFCTYPE_NUM, Length = 2, Length2 = 4, Offset = 71, Offset2 = 142)]
    [XmlElement("SOLICITUDES")]
    public string Solicitudes
    { 
       get
       {
          return _Solicitudes;
       }
       set
       {
          _Solicitudes = value;
       }
    }
    private string _Solicitudes;


    /// <summary>
    /// 
    /// </summary>
 
    [RfcField(AbapName = "NUEVA_DIRECCION", RfcType = RFCTYPE.RFCTYPE_CHAR, Length = 1, Length2 = 2, Offset = 73, Offset2 = 146)]
    [XmlElement("NUEVA_--5fDIRECCION")]
    public string Nueva_Direccion
    { 
       get
       {
          return _Nueva_Direccion;
       }
       set
       {
          _Nueva_Direccion = value;
       }
    }
    private string _Nueva_Direccion;


    /// <summary>
    /// 
    /// </summary>
 
    [RfcField(AbapName = "ALERTA", RfcType = RFCTYPE.RFCTYPE_CHAR, Length = 8, Length2 = 16, Offset = 74, Offset2 = 148)]
    [XmlElement("ALERTA")]
    public string Alerta
    { 
       get
       {
          return _Alerta;
       }
       set
       {
          _Alerta = value;
       }
    }
    private string _Alerta;


    /// <summary>
    /// 
    /// </summary>
 
    [RfcField(AbapName = "DECLARACIONES", RfcType = RFCTYPE.RFCTYPE_CHAR, Length = 1, Length2 = 2, Offset = 82, Offset2 = 164)]
    [XmlElement("DECLARACIONES")]
    public string Declaraciones
    { 
       get
       {
          return _Declaraciones;
       }
       set
       {
          _Declaraciones = value;
       }
    }
    private string _Declaraciones;


    /// <summary>
    /// 
    /// </summary>
 
    [RfcField(AbapName = "MONEDA", RfcType = RFCTYPE.RFCTYPE_CHAR, Length = 2, Length2 = 4, Offset = 83, Offset2 = 166)]
    [XmlElement("MONEDA")]
    public string Moneda
    { 
       get
       {
          return _Moneda;
       }
       set
       {
          _Moneda = value;
       }
    }
    private string _Moneda;


    /// <summary>
    /// 
    /// </summary>
 
    [RfcField(AbapName = "TOT_CREDITOS_REV", RfcType = RFCTYPE.RFCTYPE_CHAR, Length = 9, Length2 = 18, Offset = 85, Offset2 = 170)]
    [XmlElement("TOT_--5fCREDITOS_--5fREV")]
    public string Tot_Creditos_Rev
    { 
       get
       {
          return _Tot_Creditos_Rev;
       }
       set
       {
          _Tot_Creditos_Rev = value;
       }
    }
    private string _Tot_Creditos_Rev;


    /// <summary>
    /// 
    /// </summary>
 
    [RfcField(AbapName = "TOT_LIMITES_REV", RfcType = RFCTYPE.RFCTYPE_CHAR, Length = 9, Length2 = 18, Offset = 94, Offset2 = 188)]
    [XmlElement("TOT_--5fLIMITES_--5fREV")]
    public string Tot_Limites_Rev
    { 
       get
       {
          return _Tot_Limites_Rev;
       }
       set
       {
          _Tot_Limites_Rev = value;
       }
    }
    private string _Tot_Limites_Rev;


    /// <summary>
    /// 
    /// </summary>
 
    [RfcField(AbapName = "TOT_SALDOS_REV", RfcType = RFCTYPE.RFCTYPE_CHAR, Length = 9, Length2 = 18, Offset = 103, Offset2 = 206)]
    [XmlElement("TOT_--5fSALDOS_--5fREV")]
    public string Tot_Saldos_Rev
    { 
       get
       {
          return _Tot_Saldos_Rev;
       }
       set
       {
          _Tot_Saldos_Rev = value;
       }
    }
    private string _Tot_Saldos_Rev;


    /// <summary>
    /// 
    /// </summary>
 
    [RfcField(AbapName = "TOT_VEN_REV", RfcType = RFCTYPE.RFCTYPE_CHAR, Length = 9, Length2 = 18, Offset = 112, Offset2 = 224)]
    [XmlElement("TOT_--5fVEN_--5fREV")]
    public string Tot_Ven_Rev
    { 
       get
       {
          return _Tot_Ven_Rev;
       }
       set
       {
          _Tot_Ven_Rev = value;
       }
    }
    private string _Tot_Ven_Rev;


    /// <summary>
    /// 
    /// </summary>
 
    [RfcField(AbapName = "TOT_PAGOS_REV", RfcType = RFCTYPE.RFCTYPE_CHAR, Length = 9, Length2 = 18, Offset = 121, Offset2 = 242)]
    [XmlElement("TOT_--5fPAGOS_--5fREV")]
    public string Tot_Pagos_Rev
    { 
       get
       {
          return _Tot_Pagos_Rev;
       }
       set
       {
          _Tot_Pagos_Rev = value;
       }
    }
    private string _Tot_Pagos_Rev;


    /// <summary>
    /// 
    /// </summary>
 
    [RfcField(AbapName = "POR_LIM_REV", RfcType = RFCTYPE.RFCTYPE_CHAR, Length = 3, Length2 = 6, Offset = 130, Offset2 = 260)]
    [XmlElement("POR_--5fLIM_--5fREV")]
    public string Por_Lim_Rev
    { 
       get
       {
          return _Por_Lim_Rev;
       }
       set
       {
          _Por_Lim_Rev = value;
       }
    }
    private string _Por_Lim_Rev;


    /// <summary>
    /// 
    /// </summary>
 
    [RfcField(AbapName = "TOT_CREDITOS_HIP", RfcType = RFCTYPE.RFCTYPE_CHAR, Length = 9, Length2 = 18, Offset = 133, Offset2 = 266)]
    [XmlElement("TOT_--5fCREDITOS_--5fHIP")]
    public string Tot_Creditos_Hip
    { 
       get
       {
          return _Tot_Creditos_Hip;
       }
       set
       {
          _Tot_Creditos_Hip = value;
       }
    }
    private string _Tot_Creditos_Hip;


    /// <summary>
    /// 
    /// </summary>
 
    [RfcField(AbapName = "TOT_SALDOS_HIP", RfcType = RFCTYPE.RFCTYPE_CHAR, Length = 9, Length2 = 18, Offset = 142, Offset2 = 284)]
    [XmlElement("TOT_--5fSALDOS_--5fHIP")]
    public string Tot_Saldos_Hip
    { 
       get
       {
          return _Tot_Saldos_Hip;
       }
       set
       {
          _Tot_Saldos_Hip = value;
       }
    }
    private string _Tot_Saldos_Hip;


    /// <summary>
    /// 
    /// </summary>
 
    [RfcField(AbapName = "TOT_VEN_HIP", RfcType = RFCTYPE.RFCTYPE_CHAR, Length = 9, Length2 = 18, Offset = 151, Offset2 = 302)]
    [XmlElement("TOT_--5fVEN_--5fHIP")]
    public string Tot_Ven_Hip
    { 
       get
       {
          return _Tot_Ven_Hip;
       }
       set
       {
          _Tot_Ven_Hip = value;
       }
    }
    private string _Tot_Ven_Hip;


    /// <summary>
    /// 
    /// </summary>
 
    [RfcField(AbapName = "TOT_PAGOS_HIP", RfcType = RFCTYPE.RFCTYPE_CHAR, Length = 9, Length2 = 18, Offset = 160, Offset2 = 320)]
    [XmlElement("TOT_--5fPAGOS_--5fHIP")]
    public string Tot_Pagos_Hip
    { 
       get
       {
          return _Tot_Pagos_Hip;
       }
       set
       {
          _Tot_Pagos_Hip = value;
       }
    }
    private string _Tot_Pagos_Hip;


    /// <summary>
    /// 
    /// </summary>
 
    [RfcField(AbapName = "NUM_MOP96", RfcType = RFCTYPE.RFCTYPE_NUM, Length = 2, Length2 = 4, Offset = 169, Offset2 = 338)]
    [XmlElement("NUM_--5fMOP96")]
    public string Num_Mop96
    { 
       get
       {
          return _Num_Mop96;
       }
       set
       {
          _Num_Mop96 = value;
       }
    }
    private string _Num_Mop96;


    /// <summary>
    /// 
    /// </summary>
 
    [RfcField(AbapName = "NUM_MOP97", RfcType = RFCTYPE.RFCTYPE_NUM, Length = 2, Length2 = 4, Offset = 171, Offset2 = 342)]
    [XmlElement("NUM_--5fMOP97")]
    public string Num_Mop97
    { 
       get
       {
          return _Num_Mop97;
       }
       set
       {
          _Num_Mop97 = value;
       }
    }
    private string _Num_Mop97;


    /// <summary>
    /// 
    /// </summary>
 
    [RfcField(AbapName = "NUM_MOP99", RfcType = RFCTYPE.RFCTYPE_NUM, Length = 2, Length2 = 4, Offset = 173, Offset2 = 346)]
    [XmlElement("NUM_--5fMOP99")]
    public string Num_Mop99
    { 
       get
       {
          return _Num_Mop99;
       }
       set
       {
          _Num_Mop99 = value;
       }
    }
    private string _Num_Mop99;


    /// <summary>
    /// 
    /// </summary>
 
    [RfcField(AbapName = "F_ANT_CUENTA", RfcType = RFCTYPE.RFCTYPE_DATE, Length = 8, Length2 = 16, Offset = 175, Offset2 = 350)]
    [XmlElement("F_--5fANT_--5fCUENTA")]
    public string F_Ant_Cuenta
    { 
       get
       {
          return _F_Ant_Cuenta;
       }
       set
       {
          _F_Ant_Cuenta = value;
       }
    }
    private string _F_Ant_Cuenta;


    /// <summary>
    /// 
    /// </summary>
 
    [RfcField(AbapName = "F_REC_CUENTA", RfcType = RFCTYPE.RFCTYPE_DATE, Length = 8, Length2 = 16, Offset = 183, Offset2 = 366)]
    [XmlElement("F_--5fREC_--5fCUENTA")]
    public string F_Rec_Cuenta
    { 
       get
       {
          return _F_Rec_Cuenta;
       }
       set
       {
          _F_Rec_Cuenta = value;
       }
    }
    private string _F_Rec_Cuenta;


    /// <summary>
    /// 
    /// </summary>
 
    [RfcField(AbapName = "TOT_SOLICITUDES", RfcType = RFCTYPE.RFCTYPE_NUM, Length = 2, Length2 = 4, Offset = 191, Offset2 = 382)]
    [XmlElement("TOT_--5fSOLICITUDES")]
    public string Tot_Solicitudes
    { 
       get
       {
          return _Tot_Solicitudes;
       }
       set
       {
          _Tot_Solicitudes = value;
       }
    }
    private string _Tot_Solicitudes;


    /// <summary>
    /// 
    /// </summary>
 
    [RfcField(AbapName = "F_REC_REPORTE", RfcType = RFCTYPE.RFCTYPE_DATE, Length = 8, Length2 = 16, Offset = 193, Offset2 = 386)]
    [XmlElement("F_--5fREC_--5fREPORTE")]
    public string F_Rec_Reporte
    { 
       get
       {
          return _F_Rec_Reporte;
       }
       set
       {
          _F_Rec_Reporte = value;
       }
    }
    private string _F_Rec_Reporte;


    /// <summary>
    /// 
    /// </summary>
 
    [RfcField(AbapName = "NUM_COBRANZAS", RfcType = RFCTYPE.RFCTYPE_NUM, Length = 2, Length2 = 4, Offset = 201, Offset2 = 402)]
    [XmlElement("NUM_--5fCOBRANZAS")]
    public string Num_Cobranzas
    { 
       get
       {
          return _Num_Cobranzas;
       }
       set
       {
          _Num_Cobranzas = value;
       }
    }
    private string _Num_Cobranzas;


    /// <summary>
    /// 
    /// </summary>
 
    [RfcField(AbapName = "FECHA_COBRANZA", RfcType = RFCTYPE.RFCTYPE_DATE, Length = 8, Length2 = 16, Offset = 203, Offset2 = 406)]
    [XmlElement("FECHA_--5fCOBRANZA")]
    public string Fecha_Cobranza
    { 
       get
       {
          return _Fecha_Cobranza;
       }
       set
       {
          _Fecha_Cobranza = value;
       }
    }
    private string _Fecha_Cobranza;


    /// <summary>
    /// 
    /// </summary>
 
    [RfcField(AbapName = "TOT_SOLIC_COBRA", RfcType = RFCTYPE.RFCTYPE_NUM, Length = 2, Length2 = 4, Offset = 211, Offset2 = 422)]
    [XmlElement("TOT_--5fSOLIC_--5fCOBRA")]
    public string Tot_Solic_Cobra
    { 
       get
       {
          return _Tot_Solic_Cobra;
       }
       set
       {
          _Tot_Solic_Cobra = value;
       }
    }
    private string _Tot_Solic_Cobra;


    /// <summary>
    /// 
    /// </summary>
 
    [RfcField(AbapName = "F_SOLIC_COBRA", RfcType = RFCTYPE.RFCTYPE_DATE, Length = 8, Length2 = 16, Offset = 213, Offset2 = 426)]
    [XmlElement("F_--5fSOLIC_--5fCOBRA")]
    public string F_Solic_Cobra
    { 
       get
       {
          return _F_Solic_Cobra;
       }
       set
       {
          _F_Solic_Cobra = value;
       }
    }
    private string _F_Solic_Cobra;

  }

}
