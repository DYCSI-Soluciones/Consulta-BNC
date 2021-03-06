
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
  [RfcStructure(AbapName ="Z00_BURO_STR" , Length = 273, Length2 = 546)]
  [Serializable]
  public class Z00_BURO_STR : SAPStructure
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
 
    [RfcField(AbapName = "TEXTO", RfcType = RFCTYPE.RFCTYPE_CHAR, Length = 254, Length2 = 508, Offset = 19, Offset2 = 38)]
    [XmlElement("TEXTO")]
    public string Texto
    { 
       get
       {
          return _Texto;
       }
       set
       {
          _Texto = value;
       }
    }
    private string _Texto;

  }

}
