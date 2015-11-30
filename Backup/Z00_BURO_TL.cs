
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
  [RfcStructure(AbapName ="Z00_BURO_TL" , Length = 344, Length2 = 688)]
  [Serializable]
  public class Z00_BURO_TL : SAPStructure
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
 
    [RfcField(AbapName = "FECHA_ACTUALIZA", RfcType = RFCTYPE.RFCTYPE_DATE, Length = 8, Length2 = 16, Offset = 19, Offset2 = 38)]
    [XmlElement("FECHA_--5fACTUALIZA")]
    public string Fecha_Actualiza
    { 
       get
       {
          return _Fecha_Actualiza;
       }
       set
       {
          _Fecha_Actualiza = value;
       }
    }
    private string _Fecha_Actualiza;


    /// <summary>
    /// 
    /// </summary>
 
    [RfcField(AbapName = "REG_IMPUGNADO", RfcType = RFCTYPE.RFCTYPE_NUM, Length = 4, Length2 = 8, Offset = 27, Offset2 = 54)]
    [XmlElement("REG_--5fIMPUGNADO")]
    public string Reg_Impugnado
    { 
       get
       {
          return _Reg_Impugnado;
       }
       set
       {
          _Reg_Impugnado = value;
       }
    }
    private string _Reg_Impugnado;


    /// <summary>
    /// 
    /// </summary>
 
    [RfcField(AbapName = "OTORGANTE", RfcType = RFCTYPE.RFCTYPE_CHAR, Length = 10, Length2 = 20, Offset = 31, Offset2 = 62)]
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
 
    [RfcField(AbapName = "NOMBRE_OTORGANTE", RfcType = RFCTYPE.RFCTYPE_CHAR, Length = 16, Length2 = 32, Offset = 41, Offset2 = 82)]
    [XmlElement("NOMBRE_--5fOTORGANTE")]
    public string Nombre_Otorgante
    { 
       get
       {
          return _Nombre_Otorgante;
       }
       set
       {
          _Nombre_Otorgante = value;
       }
    }
    private string _Nombre_Otorgante;


    /// <summary>
    /// 
    /// </summary>
 
    [RfcField(AbapName = "TELEFONO", RfcType = RFCTYPE.RFCTYPE_NUM, Length = 11, Length2 = 22, Offset = 57, Offset2 = 114)]
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
 
    [RfcField(AbapName = "SIC", RfcType = RFCTYPE.RFCTYPE_NUM, Length = 11, Length2 = 22, Offset = 68, Offset2 = 136)]
    [XmlElement("SIC")]
    public string Sic
    { 
       get
       {
          return _Sic;
       }
       set
       {
          _Sic = value;
       }
    }
    private string _Sic;


    /// <summary>
    /// 
    /// </summary>
 
    [RfcField(AbapName = "CUENTA", RfcType = RFCTYPE.RFCTYPE_CHAR, Length = 25, Length2 = 50, Offset = 79, Offset2 = 158)]
    [XmlElement("CUENTA")]
    public string Cuenta
    { 
       get
       {
          return _Cuenta;
       }
       set
       {
          _Cuenta = value;
       }
    }
    private string _Cuenta;


    /// <summary>
    /// 
    /// </summary>
 
    [RfcField(AbapName = "TIPO_RESPON", RfcType = RFCTYPE.RFCTYPE_CHAR, Length = 1, Length2 = 2, Offset = 104, Offset2 = 208)]
    [XmlElement("TIPO_--5fRESPON")]
    public string Tipo_Respon
    { 
       get
       {
          return _Tipo_Respon;
       }
       set
       {
          _Tipo_Respon = value;
       }
    }
    private string _Tipo_Respon;


    /// <summary>
    /// 
    /// </summary>
 
    [RfcField(AbapName = "TIPO_CUENTA", RfcType = RFCTYPE.RFCTYPE_CHAR, Length = 1, Length2 = 2, Offset = 105, Offset2 = 210)]
    [XmlElement("TIPO_--5fCUENTA")]
    public string Tipo_Cuenta
    { 
       get
       {
          return _Tipo_Cuenta;
       }
       set
       {
          _Tipo_Cuenta = value;
       }
    }
    private string _Tipo_Cuenta;


    /// <summary>
    /// 
    /// </summary>
 
    [RfcField(AbapName = "TIPO_CONTRATO", RfcType = RFCTYPE.RFCTYPE_CHAR, Length = 2, Length2 = 4, Offset = 106, Offset2 = 212)]
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
 
    [RfcField(AbapName = "MONEDA", RfcType = RFCTYPE.RFCTYPE_CHAR, Length = 2, Length2 = 4, Offset = 108, Offset2 = 216)]
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
 
    [RfcField(AbapName = "VALOR_ACTIVO", RfcType = RFCTYPE.RFCTYPE_NUM, Length = 9, Length2 = 18, Offset = 110, Offset2 = 220)]
    [XmlElement("VALOR_--5fACTIVO")]
    public string Valor_Activo
    { 
       get
       {
          return _Valor_Activo;
       }
       set
       {
          _Valor_Activo = value;
       }
    }
    private string _Valor_Activo;


    /// <summary>
    /// 
    /// </summary>
 
    [RfcField(AbapName = "NUM_PAGOS", RfcType = RFCTYPE.RFCTYPE_NUM, Length = 4, Length2 = 8, Offset = 119, Offset2 = 238)]
    [XmlElement("NUM_--5fPAGOS")]
    public string Num_Pagos
    { 
       get
       {
          return _Num_Pagos;
       }
       set
       {
          _Num_Pagos = value;
       }
    }
    private string _Num_Pagos;


    /// <summary>
    /// 
    /// </summary>
 
    [RfcField(AbapName = "FRECUENCIA", RfcType = RFCTYPE.RFCTYPE_CHAR, Length = 1, Length2 = 2, Offset = 123, Offset2 = 246)]
    [XmlElement("FRECUENCIA")]
    public string Frecuencia
    { 
       get
       {
          return _Frecuencia;
       }
       set
       {
          _Frecuencia = value;
       }
    }
    private string _Frecuencia;


    /// <summary>
    /// 
    /// </summary>
 
    [RfcField(AbapName = "MONTO", RfcType = RFCTYPE.RFCTYPE_NUM, Length = 9, Length2 = 18, Offset = 124, Offset2 = 248)]
    [XmlElement("MONTO")]
    public string Monto
    { 
       get
       {
          return _Monto;
       }
       set
       {
          _Monto = value;
       }
    }
    private string _Monto;


    /// <summary>
    /// 
    /// </summary>
 
    [RfcField(AbapName = "FECHA_APERTURA", RfcType = RFCTYPE.RFCTYPE_DATE, Length = 8, Length2 = 16, Offset = 133, Offset2 = 266)]
    [XmlElement("FECHA_--5fAPERTURA")]
    public string Fecha_Apertura
    { 
       get
       {
          return _Fecha_Apertura;
       }
       set
       {
          _Fecha_Apertura = value;
       }
    }
    private string _Fecha_Apertura;


    /// <summary>
    /// 
    /// </summary>
 
    [RfcField(AbapName = "FECHA_ULT_PAGO", RfcType = RFCTYPE.RFCTYPE_DATE, Length = 8, Length2 = 16, Offset = 141, Offset2 = 282)]
    [XmlElement("FECHA_--5fULT_--5fPAGO")]
    public string Fecha_Ult_Pago
    { 
       get
       {
          return _Fecha_Ult_Pago;
       }
       set
       {
          _Fecha_Ult_Pago = value;
       }
    }
    private string _Fecha_Ult_Pago;


    /// <summary>
    /// 
    /// </summary>
 
    [RfcField(AbapName = "FECHA_ULT_COMPRA", RfcType = RFCTYPE.RFCTYPE_DATE, Length = 8, Length2 = 16, Offset = 149, Offset2 = 298)]
    [XmlElement("FECHA_--5fULT_--5fCOMPRA")]
    public string Fecha_Ult_Compra
    { 
       get
       {
          return _Fecha_Ult_Compra;
       }
       set
       {
          _Fecha_Ult_Compra = value;
       }
    }
    private string _Fecha_Ult_Compra;


    /// <summary>
    /// 
    /// </summary>
 
    [RfcField(AbapName = "FECHA_CIERRE", RfcType = RFCTYPE.RFCTYPE_DATE, Length = 8, Length2 = 16, Offset = 157, Offset2 = 314)]
    [XmlElement("FECHA_--5fCIERRE")]
    public string Fecha_Cierre
    { 
       get
       {
          return _Fecha_Cierre;
       }
       set
       {
          _Fecha_Cierre = value;
       }
    }
    private string _Fecha_Cierre;


    /// <summary>
    /// 
    /// </summary>
 
    [RfcField(AbapName = "FECHA_REPORTE", RfcType = RFCTYPE.RFCTYPE_DATE, Length = 8, Length2 = 16, Offset = 165, Offset2 = 330)]
    [XmlElement("FECHA_--5fREPORTE")]
    public string Fecha_Reporte
    { 
       get
       {
          return _Fecha_Reporte;
       }
       set
       {
          _Fecha_Reporte = value;
       }
    }
    private string _Fecha_Reporte;


    /// <summary>
    /// 
    /// </summary>
 
    [RfcField(AbapName = "MODO_REPORTE", RfcType = RFCTYPE.RFCTYPE_CHAR, Length = 1, Length2 = 2, Offset = 173, Offset2 = 346)]
    [XmlElement("MODO_--5fREPORTE")]
    public string Modo_Reporte
    { 
       get
       {
          return _Modo_Reporte;
       }
       set
       {
          _Modo_Reporte = value;
       }
    }
    private string _Modo_Reporte;


    /// <summary>
    /// 
    /// </summary>
 
    [RfcField(AbapName = "FECHA_CERO", RfcType = RFCTYPE.RFCTYPE_DATE, Length = 8, Length2 = 16, Offset = 174, Offset2 = 348)]
    [XmlElement("FECHA_--5fCERO")]
    public string Fecha_Cero
    { 
       get
       {
          return _Fecha_Cero;
       }
       set
       {
          _Fecha_Cero = value;
       }
    }
    private string _Fecha_Cero;


    /// <summary>
    /// 
    /// </summary>
 
    [RfcField(AbapName = "GARANTIA", RfcType = RFCTYPE.RFCTYPE_CHAR, Length = 40, Length2 = 80, Offset = 182, Offset2 = 364)]
    [XmlElement("GARANTIA")]
    public string Garantia
    { 
       get
       {
          return _Garantia;
       }
       set
       {
          _Garantia = value;
       }
    }
    private string _Garantia;


    /// <summary>
    /// 
    /// </summary>
 
    [RfcField(AbapName = "CREDITO_MAX", RfcType = RFCTYPE.RFCTYPE_NUM, Length = 9, Length2 = 18, Offset = 222, Offset2 = 444)]
    [XmlElement("CREDITO_--5fMAX")]
    public string Credito_Max
    { 
       get
       {
          return _Credito_Max;
       }
       set
       {
          _Credito_Max = value;
       }
    }
    private string _Credito_Max;


    /// <summary>
    /// 
    /// </summary>
 
    [RfcField(AbapName = "SALDO_ACTUAL", RfcType = RFCTYPE.RFCTYPE_NUM, Length = 9, Length2 = 18, Offset = 231, Offset2 = 462)]
    [XmlElement("SALDO_--5fACTUAL")]
    public string Saldo_Actual
    { 
       get
       {
          return _Saldo_Actual;
       }
       set
       {
          _Saldo_Actual = value;
       }
    }
    private string _Saldo_Actual;


    /// <summary>
    /// 
    /// </summary>
 
    [RfcField(AbapName = "LIMITE_CREDITO", RfcType = RFCTYPE.RFCTYPE_NUM, Length = 9, Length2 = 18, Offset = 240, Offset2 = 480)]
    [XmlElement("LIMITE_--5fCREDITO")]
    public string Limite_Credito
    { 
       get
       {
          return _Limite_Credito;
       }
       set
       {
          _Limite_Credito = value;
       }
    }
    private string _Limite_Credito;


    /// <summary>
    /// 
    /// </summary>
 
    [RfcField(AbapName = "SALDO_VENCIDO", RfcType = RFCTYPE.RFCTYPE_NUM, Length = 9, Length2 = 18, Offset = 249, Offset2 = 498)]
    [XmlElement("SALDO_--5fVENCIDO")]
    public string Saldo_Vencido
    { 
       get
       {
          return _Saldo_Vencido;
       }
       set
       {
          _Saldo_Vencido = value;
       }
    }
    private string _Saldo_Vencido;


    /// <summary>
    /// 
    /// </summary>
 
    [RfcField(AbapName = "PAGOS_VENCIDOS", RfcType = RFCTYPE.RFCTYPE_NUM, Length = 4, Length2 = 8, Offset = 258, Offset2 = 516)]
    [XmlElement("PAGOS_--5fVENCIDOS")]
    public string Pagos_Vencidos
    { 
       get
       {
          return _Pagos_Vencidos;
       }
       set
       {
          _Pagos_Vencidos = value;
       }
    }
    private string _Pagos_Vencidos;


    /// <summary>
    /// 
    /// </summary>
 
    [RfcField(AbapName = "MOP", RfcType = RFCTYPE.RFCTYPE_CHAR, Length = 2, Length2 = 4, Offset = 262, Offset2 = 524)]
    [XmlElement("MOP")]
    public string Mop
    { 
       get
       {
          return _Mop;
       }
       set
       {
          _Mop = value;
       }
    }
    private string _Mop;


    /// <summary>
    /// 
    /// </summary>
 
    [RfcField(AbapName = "HISTORICO_PAGOS", RfcType = RFCTYPE.RFCTYPE_CHAR, Length = 24, Length2 = 48, Offset = 264, Offset2 = 528)]
    [XmlElement("HISTORICO_--5fPAGOS")]
    public string Historico_Pagos
    { 
       get
       {
          return _Historico_Pagos;
       }
       set
       {
          _Historico_Pagos = value;
       }
    }
    private string _Historico_Pagos;


    /// <summary>
    /// 
    /// </summary>
 
    [RfcField(AbapName = "FECHA_REC_HIST", RfcType = RFCTYPE.RFCTYPE_DATE, Length = 8, Length2 = 16, Offset = 288, Offset2 = 576)]
    [XmlElement("FECHA_--5fREC_--5fHIST")]
    public string Fecha_Rec_Hist
    { 
       get
       {
          return _Fecha_Rec_Hist;
       }
       set
       {
          _Fecha_Rec_Hist = value;
       }
    }
    private string _Fecha_Rec_Hist;


    /// <summary>
    /// 
    /// </summary>
 
    [RfcField(AbapName = "FECHA_ANT_HIST", RfcType = RFCTYPE.RFCTYPE_DATE, Length = 8, Length2 = 16, Offset = 296, Offset2 = 592)]
    [XmlElement("FECHA_--5fANT_--5fHIST")]
    public string Fecha_Ant_Hist
    { 
       get
       {
          return _Fecha_Ant_Hist;
       }
       set
       {
          _Fecha_Ant_Hist = value;
       }
    }
    private string _Fecha_Ant_Hist;


    /// <summary>
    /// 
    /// </summary>
 
    [RfcField(AbapName = "OBSERVACION", RfcType = RFCTYPE.RFCTYPE_CHAR, Length = 2, Length2 = 4, Offset = 304, Offset2 = 608)]
    [XmlElement("OBSERVACION")]
    public string Observacion
    { 
       get
       {
          return _Observacion;
       }
       set
       {
          _Observacion = value;
       }
    }
    private string _Observacion;


    /// <summary>
    /// 
    /// </summary>
 
    [RfcField(AbapName = "TOTAL_PAGOS", RfcType = RFCTYPE.RFCTYPE_NUM, Length = 3, Length2 = 6, Offset = 306, Offset2 = 612)]
    [XmlElement("TOTAL_--5fPAGOS")]
    public string Total_Pagos
    { 
       get
       {
          return _Total_Pagos;
       }
       set
       {
          _Total_Pagos = value;
       }
    }
    private string _Total_Pagos;


    /// <summary>
    /// 
    /// </summary>
 
    [RfcField(AbapName = "CALIF_MOP02", RfcType = RFCTYPE.RFCTYPE_NUM, Length = 2, Length2 = 4, Offset = 309, Offset2 = 618)]
    [XmlElement("CALIF_--5fMOP02")]
    public string Calif_Mop02
    { 
       get
       {
          return _Calif_Mop02;
       }
       set
       {
          _Calif_Mop02 = value;
       }
    }
    private string _Calif_Mop02;


    /// <summary>
    /// 
    /// </summary>
 
    [RfcField(AbapName = "CALIF_MOP03", RfcType = RFCTYPE.RFCTYPE_NUM, Length = 2, Length2 = 4, Offset = 311, Offset2 = 622)]
    [XmlElement("CALIF_--5fMOP03")]
    public string Calif_Mop03
    { 
       get
       {
          return _Calif_Mop03;
       }
       set
       {
          _Calif_Mop03 = value;
       }
    }
    private string _Calif_Mop03;


    /// <summary>
    /// 
    /// </summary>
 
    [RfcField(AbapName = "CALIF_MOP04", RfcType = RFCTYPE.RFCTYPE_NUM, Length = 2, Length2 = 4, Offset = 313, Offset2 = 626)]
    [XmlElement("CALIF_--5fMOP04")]
    public string Calif_Mop04
    { 
       get
       {
          return _Calif_Mop04;
       }
       set
       {
          _Calif_Mop04 = value;
       }
    }
    private string _Calif_Mop04;


    /// <summary>
    /// 
    /// </summary>
 
    [RfcField(AbapName = "CALIF_MOP05", RfcType = RFCTYPE.RFCTYPE_NUM, Length = 2, Length2 = 4, Offset = 315, Offset2 = 630)]
    [XmlElement("CALIF_--5fMOP05")]
    public string Calif_Mop05
    { 
       get
       {
          return _Calif_Mop05;
       }
       set
       {
          _Calif_Mop05 = value;
       }
    }
    private string _Calif_Mop05;


    /// <summary>
    /// 
    /// </summary>
 
    [RfcField(AbapName = "HIST_MORA_SALDO", RfcType = RFCTYPE.RFCTYPE_NUM, Length = 9, Length2 = 18, Offset = 317, Offset2 = 634)]
    [XmlElement("HIST_--5fMORA_--5fSALDO")]
    public string Hist_Mora_Saldo
    { 
       get
       {
          return _Hist_Mora_Saldo;
       }
       set
       {
          _Hist_Mora_Saldo = value;
       }
    }
    private string _Hist_Mora_Saldo;


    /// <summary>
    /// 
    /// </summary>
 
    [RfcField(AbapName = "HIST_MORA_FECHA", RfcType = RFCTYPE.RFCTYPE_DATE, Length = 8, Length2 = 16, Offset = 326, Offset2 = 652)]
    [XmlElement("HIST_--5fMORA_--5fFECHA")]
    public string Hist_Mora_Fecha
    { 
       get
       {
          return _Hist_Mora_Fecha;
       }
       set
       {
          _Hist_Mora_Fecha = value;
       }
    }
    private string _Hist_Mora_Fecha;


    /// <summary>
    /// 
    /// </summary>
 
    [RfcField(AbapName = "HIST_MORA_MOP02", RfcType = RFCTYPE.RFCTYPE_CHAR, Length = 2, Length2 = 4, Offset = 334, Offset2 = 668)]
    [XmlElement("HIST_--5fMORA_--5fMOP02")]
    public string Hist_Mora_Mop02
    { 
       get
       {
          return _Hist_Mora_Mop02;
       }
       set
       {
          _Hist_Mora_Mop02 = value;
       }
    }
    private string _Hist_Mora_Mop02;


    /// <summary>
    /// 
    /// </summary>
 
    [RfcField(AbapName = "FECHA_INICIO", RfcType = RFCTYPE.RFCTYPE_DATE, Length = 8, Length2 = 16, Offset = 336, Offset2 = 672)]
    [XmlElement("FECHA_--5fINICIO")]
    public string Fecha_Inicio
    { 
       get
       {
          return _Fecha_Inicio;
       }
       set
       {
          _Fecha_Inicio = value;
       }
    }
    private string _Fecha_Inicio;

  }

}
