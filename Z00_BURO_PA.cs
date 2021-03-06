
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
  [RfcStructure(AbapName ="Z00_BURO_PA" , Length = 276, Length2 = 552)]
  [Serializable]
  public class Z00_BURO_PA : SAPStructure
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
 
    [RfcField(AbapName = "DIRECCION1", RfcType = RFCTYPE.RFCTYPE_CHAR, Length = 40, Length2 = 80, Offset = 19, Offset2 = 38)]
    [XmlElement("DIRECCION1")]
    public string Direccion1
    { 
       get
       {
          return _Direccion1;
       }
       set
       {
          _Direccion1 = value;
       }
    }
    private string _Direccion1;


    /// <summary>
    /// 
    /// </summary>
 
    [RfcField(AbapName = "DIRECCION2", RfcType = RFCTYPE.RFCTYPE_CHAR, Length = 40, Length2 = 80, Offset = 59, Offset2 = 118)]
    [XmlElement("DIRECCION2")]
    public string Direccion2
    { 
       get
       {
          return _Direccion2;
       }
       set
       {
          _Direccion2 = value;
       }
    }
    private string _Direccion2;


    /// <summary>
    /// 
    /// </summary>
 
    [RfcField(AbapName = "COLONIA", RfcType = RFCTYPE.RFCTYPE_CHAR, Length = 40, Length2 = 80, Offset = 99, Offset2 = 198)]
    [XmlElement("COLONIA")]
    public string Colonia
    { 
       get
       {
          return _Colonia;
       }
       set
       {
          _Colonia = value;
       }
    }
    private string _Colonia;


    /// <summary>
    /// 
    /// </summary>
 
    [RfcField(AbapName = "MUNICIPIO", RfcType = RFCTYPE.RFCTYPE_CHAR, Length = 40, Length2 = 80, Offset = 139, Offset2 = 278)]
    [XmlElement("MUNICIPIO")]
    public string Municipio
    { 
       get
       {
          return _Municipio;
       }
       set
       {
          _Municipio = value;
       }
    }
    private string _Municipio;


    /// <summary>
    /// 
    /// </summary>
 
    [RfcField(AbapName = "CIUDAD", RfcType = RFCTYPE.RFCTYPE_CHAR, Length = 40, Length2 = 80, Offset = 179, Offset2 = 358)]
    [XmlElement("CIUDAD")]
    public string Ciudad
    { 
       get
       {
          return _Ciudad;
       }
       set
       {
          _Ciudad = value;
       }
    }
    private string _Ciudad;


    /// <summary>
    /// 
    /// </summary>
 
    [RfcField(AbapName = "ESTADO", RfcType = RFCTYPE.RFCTYPE_CHAR, Length = 4, Length2 = 8, Offset = 219, Offset2 = 438)]
    [XmlElement("ESTADO")]
    public string Estado
    { 
       get
       {
          return _Estado;
       }
       set
       {
          _Estado = value;
       }
    }
    private string _Estado;


    /// <summary>
    /// 
    /// </summary>
 
    [RfcField(AbapName = "CP", RfcType = RFCTYPE.RFCTYPE_NUM, Length = 5, Length2 = 10, Offset = 223, Offset2 = 446)]
    [XmlElement("CP")]
    public string Cp
    { 
       get
       {
          return _Cp;
       }
       set
       {
          _Cp = value;
       }
    }
    private string _Cp;


    /// <summary>
    /// 
    /// </summary>
 
    [RfcField(AbapName = "FECHA_RESIDENCIA", RfcType = RFCTYPE.RFCTYPE_DATE, Length = 8, Length2 = 16, Offset = 228, Offset2 = 456)]
    [XmlElement("FECHA_--5fRESIDENCIA")]
    public string Fecha_Residencia
    { 
       get
       {
          return _Fecha_Residencia;
       }
       set
       {
          _Fecha_Residencia = value;
       }
    }
    private string _Fecha_Residencia;


    /// <summary>
    /// 
    /// </summary>
 
    [RfcField(AbapName = "TELEFONO", RfcType = RFCTYPE.RFCTYPE_NUM, Length = 11, Length2 = 22, Offset = 236, Offset2 = 472)]
    [XmlElement("TELEFONO")]
    public string Telefono
    { 
       get
       {
          return _Telefono;
       }
       set
       {
          _Telefono = value;
       }
    }
    private string _Telefono;


    /// <summary>
    /// 
    /// </summary>
 
    [RfcField(AbapName = "EXTENSION_TEL", RfcType = RFCTYPE.RFCTYPE_NUM, Length = 8, Length2 = 16, Offset = 247, Offset2 = 494)]
    [XmlElement("EXTENSION_--5fTEL")]
    public string Extension_Tel
    { 
       get
       {
          return _Extension_Tel;
       }
       set
       {
          _Extension_Tel = value;
       }
    }
    private string _Extension_Tel;


    /// <summary>
    /// 
    /// </summary>
 
    [RfcField(AbapName = "FAX", RfcType = RFCTYPE.RFCTYPE_NUM, Length = 11, Length2 = 22, Offset = 255, Offset2 = 510)]
    [XmlElement("FAX")]
    public string Fax
    { 
       get
       {
          return _Fax;
       }
       set
       {
          _Fax = value;
       }
    }
    private string _Fax;


    /// <summary>
    /// 
    /// </summary>
 
    [RfcField(AbapName = "TIPO_DOMICILIO", RfcType = RFCTYPE.RFCTYPE_CHAR, Length = 1, Length2 = 2, Offset = 266, Offset2 = 532)]
    [XmlElement("TIPO_--5fDOMICILIO")]
    public string Tipo_Domicilio
    { 
       get
       {
          return _Tipo_Domicilio;
       }
       set
       {
          _Tipo_Domicilio = value;
       }
    }
    private string _Tipo_Domicilio;


    /// <summary>
    /// 
    /// </summary>
 
    [RfcField(AbapName = "ID_ESP_DOM", RfcType = RFCTYPE.RFCTYPE_CHAR, Length = 1, Length2 = 2, Offset = 267, Offset2 = 534)]
    [XmlElement("ID_--5fESP_--5fDOM")]
    public string Id_Esp_Dom
    { 
       get
       {
          return _Id_Esp_Dom;
       }
       set
       {
          _Id_Esp_Dom = value;
       }
    }
    private string _Id_Esp_Dom;


    /// <summary>
    /// 
    /// </summary>
 
    [RfcField(AbapName = "FECHA_DIR", RfcType = RFCTYPE.RFCTYPE_DATE, Length = 8, Length2 = 16, Offset = 268, Offset2 = 536)]
    [XmlElement("FECHA_--5fDIR")]
    public string Fecha_Dir
    { 
       get
       {
          return _Fecha_Dir;
       }
       set
       {
          _Fecha_Dir = value;
       }
    }
    private string _Fecha_Dir;

  }

}
