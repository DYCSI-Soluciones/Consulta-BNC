
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
  [RfcStructure(AbapName ="Z00_BURO_INTL" , Length = 116, Length2 = 232)]
  [Serializable]
  public class Z00_BURO_INTL : SAPStructure
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
 
    [RfcField(AbapName = "ETIQUETA", RfcType = RFCTYPE.RFCTYPE_CHAR, Length = 4, Length2 = 8, Offset = 16, Offset2 = 32)]
    [XmlElement("ETIQUETA")]
    public string Etiqueta
    { 
       get
       {
          return _Etiqueta;
       }
       set
       {
          _Etiqueta = value;
       }
    }
    private string _Etiqueta;


    /// <summary>
    /// 
    /// </summary>
 
    [RfcField(AbapName = "VERSION", RfcType = RFCTYPE.RFCTYPE_NUM, Length = 2, Length2 = 4, Offset = 20, Offset2 = 40)]
    [XmlElement("VERSION")]
    public string Version
    { 
       get
       {
          return _Version;
       }
       set
       {
          _Version = value;
       }
    }
    private string _Version;


    /// <summary>
    /// 
    /// </summary>
 
    [RfcField(AbapName = "REF_OPERADOR", RfcType = RFCTYPE.RFCTYPE_CHAR, Length = 25, Length2 = 50, Offset = 22, Offset2 = 44)]
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
 
    [RfcField(AbapName = "PRODUCTO", RfcType = RFCTYPE.RFCTYPE_NUM, Length = 3, Length2 = 6, Offset = 47, Offset2 = 94)]
    [XmlElement("PRODUCTO")]
    public string Producto
    { 
       get
       {
          return _Producto;
       }
       set
       {
          _Producto = value;
       }
    }
    private string _Producto;


    /// <summary>
    /// 
    /// </summary>
 
    [RfcField(AbapName = "PAIS", RfcType = RFCTYPE.RFCTYPE_CHAR, Length = 2, Length2 = 4, Offset = 50, Offset2 = 100)]
    [XmlElement("PAIS")]
    public string Pais
    { 
       get
       {
          return _Pais;
       }
       set
       {
          _Pais = value;
       }
    }
    private string _Pais;


    /// <summary>
    /// 
    /// </summary>
 
    [RfcField(AbapName = "ID_BURO", RfcType = RFCTYPE.RFCTYPE_NUM, Length = 4, Length2 = 8, Offset = 52, Offset2 = 104)]
    [XmlElement("ID_--5fBURO")]
    public string Id_Buro
    { 
       get
       {
          return _Id_Buro;
       }
       set
       {
          _Id_Buro = value;
       }
    }
    private string _Id_Buro;


    /// <summary>
    /// 
    /// </summary>
 
    [RfcField(AbapName = "CLAVE_USUARIO", RfcType = RFCTYPE.RFCTYPE_CHAR, Length = 10, Length2 = 20, Offset = 56, Offset2 = 112)]
    [XmlElement("CLAVE_--5fUSUARIO")]
    public string Clave_Usuario
    { 
       get
       {
          return _Clave_Usuario;
       }
       set
       {
          _Clave_Usuario = value;
       }
    }
    private string _Clave_Usuario;


    /// <summary>
    /// 
    /// </summary>
 
    [RfcField(AbapName = "PASS_USUARIO", RfcType = RFCTYPE.RFCTYPE_CHAR, Length = 8, Length2 = 16, Offset = 66, Offset2 = 132)]
    [XmlElement("PASS_--5fUSUARIO")]
    public string Pass_Usuario
    { 
       get
       {
          return _Pass_Usuario;
       }
       set
       {
          _Pass_Usuario = value;
       }
    }
    private string _Pass_Usuario;


    /// <summary>
    /// 
    /// </summary>
 
    [RfcField(AbapName = "TIPO_CONSULTA", RfcType = RFCTYPE.RFCTYPE_CHAR, Length = 1, Length2 = 2, Offset = 74, Offset2 = 148)]
    [XmlElement("TIPO_--5fCONSULTA")]
    public string Tipo_Consulta
    { 
       get
       {
          return _Tipo_Consulta;
       }
       set
       {
          _Tipo_Consulta = value;
       }
    }
    private string _Tipo_Consulta;


    /// <summary>
    /// 
    /// </summary>
 
    [RfcField(AbapName = "TIPO_CONTRATO", RfcType = RFCTYPE.RFCTYPE_CHAR, Length = 2, Length2 = 4, Offset = 75, Offset2 = 150)]
    [XmlElement("TIPO_--5fCONTRATO")]
    public string Tipo_Contrato
    { 
       get
       {
          return _Tipo_Contrato;
       }
       set
       {
          _Tipo_Contrato = value;
       }
    }
    private string _Tipo_Contrato;


    /// <summary>
    /// 
    /// </summary>
 
    [RfcField(AbapName = "MONEDA", RfcType = RFCTYPE.RFCTYPE_CHAR, Length = 2, Length2 = 4, Offset = 77, Offset2 = 154)]
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
 
    [RfcField(AbapName = "IMPORTE_CONTRATO", RfcType = RFCTYPE.RFCTYPE_NUM, Length = 9, Length2 = 18, Offset = 79, Offset2 = 158)]
    [XmlElement("IMPORTE_--5fCONTRATO")]
    public string Importe_Contrato
    { 
       get
       {
          return _Importe_Contrato;
       }
       set
       {
          _Importe_Contrato = value;
       }
    }
    private string _Importe_Contrato;


    /// <summary>
    /// 
    /// </summary>
 
    [RfcField(AbapName = "IDIOMA", RfcType = RFCTYPE.RFCTYPE_CHAR, Length = 2, Length2 = 4, Offset = 88, Offset2 = 176)]
    [XmlElement("IDIOMA")]
    public string Idioma
    { 
       get
       {
          return _Idioma;
       }
       set
       {
          _Idioma = value;
       }
    }
    private string _Idioma;


    /// <summary>
    /// 
    /// </summary>
 
    [RfcField(AbapName = "TIPO_SALIDA", RfcType = RFCTYPE.RFCTYPE_NUM, Length = 2, Length2 = 4, Offset = 90, Offset2 = 180)]
    [XmlElement("TIPO_--5fSALIDA")]
    public string Tipo_Salida
    { 
       get
       {
          return _Tipo_Salida;
       }
       set
       {
          _Tipo_Salida = value;
       }
    }
    private string _Tipo_Salida;


    /// <summary>
    /// 
    /// </summary>
 
    [RfcField(AbapName = "BLOQUE_RESPUESTA", RfcType = RFCTYPE.RFCTYPE_CHAR, Length = 1, Length2 = 2, Offset = 92, Offset2 = 184)]
    [XmlElement("BLOQUE_--5fRESPUESTA")]
    public string Bloque_Respuesta
    { 
       get
       {
          return _Bloque_Respuesta;
       }
       set
       {
          _Bloque_Respuesta = value;
       }
    }
    private string _Bloque_Respuesta;


    /// <summary>
    /// 
    /// </summary>
 
    [RfcField(AbapName = "ID_IMPRESORA", RfcType = RFCTYPE.RFCTYPE_CHAR, Length = 4, Length2 = 8, Offset = 93, Offset2 = 186)]
    [XmlElement("ID_--5fIMPRESORA")]
    public string Id_Impresora
    { 
       get
       {
          return _Id_Impresora;
       }
       set
       {
          _Id_Impresora = value;
       }
    }
    private string _Id_Impresora;


    /// <summary>
    /// 
    /// </summary>
 
    [RfcField(AbapName = "USO_FUTURO", RfcType = RFCTYPE.RFCTYPE_NUM, Length = 7, Length2 = 14, Offset = 97, Offset2 = 194)]
    [XmlElement("USO_--5fFUTURO")]
    public string Uso_Futuro
    { 
       get
       {
          return _Uso_Futuro;
       }
       set
       {
          _Uso_Futuro = value;
       }
    }
    private string _Uso_Futuro;


    /// <summary>
    /// 
    /// </summary>
 
    [RfcField(AbapName = "OTORGANTE", RfcType = RFCTYPE.RFCTYPE_CHAR, Length = 10, Length2 = 20, Offset = 104, Offset2 = 208)]
    [XmlElement("OTORGANTE")]
    public string Otorgante
    { 
       get
       {
          return _Otorgante;
       }
       set
       {
          _Otorgante = value;
       }
    }
    private string _Otorgante;


    /// <summary>
    /// 
    /// </summary>
 
    [RfcField(AbapName = "RC_PRINCIPAL", RfcType = RFCTYPE.RFCTYPE_CHAR, Length = 1, Length2 = 2, Offset = 114, Offset2 = 228)]
    [XmlElement("RC_--5fPRINCIPAL")]
    public string Rc_Principal
    { 
       get
       {
          return _Rc_Principal;
       }
       set
       {
          _Rc_Principal = value;
       }
    }
    private string _Rc_Principal;


    /// <summary>
    /// 
    /// </summary>
 
    [RfcField(AbapName = "RC_SECUNDARIO", RfcType = RFCTYPE.RFCTYPE_CHAR, Length = 1, Length2 = 2, Offset = 115, Offset2 = 230)]
    [XmlElement("RC_--5fSECUNDARIO")]
    public string Rc_Secundario
    { 
       get
       {
          return _Rc_Secundario;
       }
       set
       {
          _Rc_Secundario = value;
       }
    }
    private string _Rc_Secundario;

  }

}
