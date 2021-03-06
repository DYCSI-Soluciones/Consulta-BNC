
//------------------------------------------------------------------------------
// 
//     This code was generated by a SAP. NET Connector Proxy Generator Version 2.0
//     Created at 16/12/2010
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
  [RfcStructure(AbapName ="Z00_BURO_AR" , Length = 96, Length2 = 192)]
  [Serializable]
  public class Z00_BURO_AR : SAPStructure
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
 
    [RfcField(AbapName = "REF_OPERADOR", RfcType = RFCTYPE.RFCTYPE_CHAR, Length = 25, Length2 = 50, Offset = 16, Offset2 = 32)]
    [XmlElement("REF_--5fOPERADOR")]
    public string Ref_Operador
    { 
       get
       {
          return _Ref_Operador;
       }
       set
       {
          _Ref_Operador = value;
       }
    }
    private string _Ref_Operador;


    /// <summary>
    /// 
    /// </summary>
 
    [RfcField(AbapName = "NO_AUTENTICADO", RfcType = RFCTYPE.RFCTYPE_CHAR, Length = 14, Length2 = 28, Offset = 41, Offset2 = 82)]
    [XmlElement("NO_--5fAUTENTICADO")]
    public string No_Autenticado
    { 
       get
       {
          return _No_Autenticado;
       }
       set
       {
          _No_Autenticado = value;
       }
    }
    private string _No_Autenticado;


    /// <summary>
    /// 
    /// </summary>
 
    [RfcField(AbapName = "CLAVE", RfcType = RFCTYPE.RFCTYPE_CHAR, Length = 18, Length2 = 36, Offset = 55, Offset2 = 110)]
    [XmlElement("CLAVE")]
    public string Clave
    { 
       get
       {
          return _Clave;
       }
       set
       {
          _Clave = value;
       }
    }
    private string _Clave;


    /// <summary>
    /// 
    /// </summary>
 
    [RfcField(AbapName = "ERROR_BURO", RfcType = RFCTYPE.RFCTYPE_CHAR, Length = 1, Length2 = 2, Offset = 73, Offset2 = 146)]
    [XmlElement("ERROR_--5fBURO")]
    public string Error_Buro
    { 
       get
       {
          return _Error_Buro;
       }
       set
       {
          _Error_Buro = value;
       }
    }
    private string _Error_Buro;


    /// <summary>
    /// 
    /// </summary>
 
    [RfcField(AbapName = "SEGMENTO", RfcType = RFCTYPE.RFCTYPE_CHAR, Length = 2, Length2 = 4, Offset = 74, Offset2 = 148)]
    [XmlElement("SEGMENTO")]
    public string Segmento
    { 
       get
       {
          return _Segmento;
       }
       set
       {
          _Segmento = value;
       }
    }
    private string _Segmento;


    /// <summary>
    /// 
    /// </summary>
 
    [RfcField(AbapName = "REQUERIDO1", RfcType = RFCTYPE.RFCTYPE_CHAR, Length = 4, Length2 = 8, Offset = 76, Offset2 = 152)]
    [XmlElement("REQUERIDO1")]
    public string Requerido1
    { 
       get
       {
          return _Requerido1;
       }
       set
       {
          _Requerido1 = value;
       }
    }
    private string _Requerido1;


    /// <summary>
    /// 
    /// </summary>
 
    [RfcField(AbapName = "REQUERIDO2", RfcType = RFCTYPE.RFCTYPE_CHAR, Length = 4, Length2 = 8, Offset = 80, Offset2 = 160)]
    [XmlElement("REQUERIDO2")]
    public string Requerido2
    { 
       get
       {
          return _Requerido2;
       }
       set
       {
          _Requerido2 = value;
       }
    }
    private string _Requerido2;


    /// <summary>
    /// 
    /// </summary>
 
    [RfcField(AbapName = "REQUERIDO3", RfcType = RFCTYPE.RFCTYPE_CHAR, Length = 4, Length2 = 8, Offset = 84, Offset2 = 168)]
    [XmlElement("REQUERIDO3")]
    public string Requerido3
    { 
       get
       {
          return _Requerido3;
       }
       set
       {
          _Requerido3 = value;
       }
    }
    private string _Requerido3;


    /// <summary>
    /// 
    /// </summary>
 
    [RfcField(AbapName = "REQUERIDO4", RfcType = RFCTYPE.RFCTYPE_CHAR, Length = 4, Length2 = 8, Offset = 88, Offset2 = 176)]
    [XmlElement("REQUERIDO4")]
    public string Requerido4
    { 
       get
       {
          return _Requerido4;
       }
       set
       {
          _Requerido4 = value;
       }
    }
    private string _Requerido4;


    /// <summary>
    /// 
    /// </summary>
 
    [RfcField(AbapName = "REQUERIDO5", RfcType = RFCTYPE.RFCTYPE_CHAR, Length = 4, Length2 = 8, Offset = 92, Offset2 = 184)]
    [XmlElement("REQUERIDO5")]
    public string Requerido5
    { 
       get
       {
          return _Requerido5;
       }
       set
       {
          _Requerido5 = value;
       }
    }
    private string _Requerido5;

  }

}
