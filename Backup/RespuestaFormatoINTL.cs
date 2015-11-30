using System;
using System.Collections;

namespace ZConsultaBuro
{
	/// <summary>
	/// Summary description for RespuestaFormatoINTL.
	/// </summary>
	public class RespuestaFormatoINTL
	{
		private ConnexionSAP conn;
		public RespuestaFormatoINTL()
		{
		}
		public RespuestaFormatoINTL(ConnexionSAP puente)
		{
			this.conn = puente;
		}

		private ArrayList etiSecc = new ArrayList(); 
		private ArrayList valSecc = new ArrayList();
		#region Z00_BURO
		
		private Z00_BURO_INTL encabezadoINTL = new Z00_BURO_INTL();
		private Z00_BURO_INTLTable encabezadoINTLTable = new Z00_BURO_INTLTable();

		private Z00_BURO_PN seccionNombres = new Z00_BURO_PN();
		private Z00_BURO_PNTable seccionNombresTable = new Z00_BURO_PNTable();

		private Z00_BURO_PA seccionDireccion = new Z00_BURO_PA();
		private Z00_BURO_PATable seccionDireccionTable = new Z00_BURO_PATable();

		private Z00_BURO_PE seccionEmpleos = new Z00_BURO_PE();
		private Z00_BURO_PETable seccionEmpleosTable = new Z00_BURO_PETable();

		private Z00_BURO_TL seccionCreditos = new Z00_BURO_TL();
		private Z00_BURO_TLTable seccionCreditosTable = new Z00_BURO_TLTable();

		private Z00_BURO_IQ seccionConsultasRepCredito = new Z00_BURO_IQ();
		private Z00_BURO_IQTable seccionConsultasRepCreditoTable = new Z00_BURO_IQTable();

		private Z00_BURO_RS seccionResumenRep = new Z00_BURO_RS();
		private Z00_BURO_RSTable seccionResumenRepTable = new Z00_BURO_RSTable();

		private Z00_BURO_HI seccionHankAlertCD = new Z00_BURO_HI();
		private Z00_BURO_HITable seccionHankAlertCDTable = new Z00_BURO_HITable();

		private Z00_BURO_HR seccionHankAlertCDReg = new Z00_BURO_HR();
		private Z00_BURO_HRTable seccionHankAlertCDRegTable = new Z00_BURO_HRTable();

		private Z00_BURO_CR seccionDeclaracionesDelCliente = new Z00_BURO_CR();
		private Z00_BURO_CRTable seccionDeclaracionesDelClienteTable = new Z00_BURO_CRTable();

		private Z00_BURO_SC seccionScoreBuro = new Z00_BURO_SC();
		private Z00_BURO_SCTable seccionScoreBuroTable = new Z00_BURO_SCTable();

		private Z00_BURO_UR errorReferenciaErrorUsuario = new Z00_BURO_UR();
		private Z00_BURO_URTable errorReferenciaErrorUsuarioTable = new Z00_BURO_URTable();

		private Z00_BURO_AR errorReferenciaErrorAutentificacion = new Z00_BURO_AR();
		private Z00_BURO_ARTable errorReferenciaErrorAutentificacionTable = new Z00_BURO_ARTable();
		#endregion

		public void respuestaEncabezadoINTL(string respuesta)
		{
			string encabezadoIntl = respuesta.Substring(0,49);

			string etiquetaDeSegmento = this.stringLongitudFija(1,encabezadoIntl,4);
			string version = this.stringLongitudFija(5,encabezadoIntl,2);
			string refOperador = this.stringLongitudFija(7,encabezadoIntl,25);
			string clavePais = this.stringLongitudFija(32,encabezadoIntl,2);
			string buroID = this.stringLongitudFija(34,encabezadoIntl,4);
			string claveOtorgante = this.stringLongitudFija(38,encabezadoIntl,10);
			string claveRetornoConPrincipal = this.stringLongitudFija(48,encabezadoIntl,1);
			string claveRetornoConSecundario = this.stringLongitudFija(49,encabezadoIntl,1);
			
			encabezadoINTL.Etiqueta = etiquetaDeSegmento;
			encabezadoINTL.Version = version;
			encabezadoINTL.Ref_Operador = refOperador;
			//encabezadoINTL.Producto;
			encabezadoINTL.Pais = clavePais;
			encabezadoINTL.Id_Buro = buroID;
			//encabezadoINTL.Clave_Usuario;
			//encabezadoINTL.Pass_Usuario;
			//encabezadoINTL.Tipo_Consulta;
			//encabezadoINTL.Tipo_Contrato;
			//encabezadoINTL.Moneda;
			//encabezadoINTL.Importe_Contrato;
			//encabezadoINTL.Idioma;
			//encabezadoINTL.Tipo_Salida;
			//encabezadoINTL.Bloque_Respuesta;
			//encabezadoINTL.Id_Impresora;
			//encabezadoINTL.Uso_Futuro;

			encabezadoINTLTable.Add(encabezadoINTL);


		}
		private string stringLongitudFija(int posicion , string valor, int longitud)
		{
			posicion--;
			valor = valor.Substring(posicion,longitud);
			return valor;
		}
		public void tablaDeValores(string respuesta)
		{
			bool salir = false;
			string etiqueta = string.Empty;
			string longitud= string.Empty;
			string palabra = string.Empty; 
			int longitudEntera=0;
			int posicion=0;

			while(salir==false)
			{
				try
				{
					etiqueta = respuesta.Substring(posicion,2);

					if(etiqueta != "CR")
					{
						etiSecc.Add(etiqueta);
						longitud = respuesta.Substring(posicion+2,2);
						longitudEntera = int.Parse(longitud);
						palabra = respuesta.Substring(posicion+4,longitudEntera);
						valSecc.Add(palabra);
						posicion = posicion + 4 +longitudEntera;
					}
					else
					{
						etiSecc.Add(etiqueta);
						longitud = respuesta.Substring(posicion+2,2);
						longitudEntera = int.Parse(longitud);
						palabra = respuesta.Substring(posicion+4,longitudEntera);
						int temp = int.Parse(palabra);
						valSecc.Add(palabra);
						posicion = posicion + 4 +longitudEntera;

						etiqueta = respuesta.Substring(posicion,2);
						etiSecc.Add(etiqueta);
						longitud = respuesta.Substring(posicion+2,2);
						//longitudEntera = int.Parse(longitud);
						palabra = respuesta.Substring(posicion+4,temp-10);
						//longitudEntera=;
						valSecc.Add(palabra);
						posicion = posicion + 4 +temp-10;
					}
				}
				catch(ArgumentOutOfRangeException e)
				{
					Console.WriteLine("Existe un error en el formato \n"+e.Message);
					Console.WriteLine("para Objeto de prueba \n etiqueta : "+etiqueta+"\n palabra:"+palabra+"\n");
					Console.ReadLine();
					//System.exit(0);

					break;
				}
				catch(FormatException e)
				{
					Console.WriteLine("Existe un error en el formato \n"+e.Message);
					Console.WriteLine("para Objeto de prueba \n etiqueta : "+etiqueta+"\n palabra:"+palabra+"\n");
					break;
				}
				catch(Exception e)
				{
					Console.WriteLine("Exception DESCONOCIDA \n"+e.Message);
					break;
				}
				if(posicion>=respuesta.Length)
				{
					salir=true;
				}
			}
		}
		public void tablasTemporalesASap()
		{
			int i=0;
			while(etiSecc.Count>i)
			{
				switch(etiSecc[i].ToString())
				{
					case "PN":
						Console.WriteLine("Seccion de Nombres");
						i=this.PN_respuestaSeccionNombres(i);
						break;
					case "PA":
						Console.WriteLine("Seccion de Direcciones"); 
						i=this.PA_respuestaSeccionDireccion(i);
						break;
					case "PE":
						Console.WriteLine("Seccion de Empleos"); 
						i=this.PE_respuestaSeccionEmpleos(i);
						break;
					case "TL":
						Console.WriteLine("Seccion de Creditos"); 
						i=this.TL_respuestaSeccionCreditos(i);
						break;
					case "IQ":
						Console.WriteLine("Consultas al reporte de credito");
						i=this.IQ_respuestaSeccionConsultasRepCredito(i);
						break;
					case "RS":
						Console.WriteLine("Reporte de Resumen");
						i=this.RS_respuestaSeccionResumenRep(i);
						break;
					case "HI":
						Console.WriteLine("Hack Alert-Coincidencia en los datos de consulta"); 
						i=this.HI_respuestaSeccionHankAlertCD(i);
						break;
					case "HR":
						Console.WriteLine("Hack Alert-Considencia por datos encontrados en la base de datos"); 
						i=this.HR_respuestaSeccionHankAlertCDReg(i);
						break;
					case "CR":
						Console.WriteLine("declaraciones del cliente"); 
						i=this.CR_respuestaSeccionDeclaracionesDelCliente(i);
						break;
					case "SC":
						Console.WriteLine("Score de buro de credito"); 
						i=this.SC_respuestaSeccionScoreBuro(i);
						break;
					case "UR":
						Console.WriteLine("Score de buro de credito"); 
						i=this.UR_respuestaErrorReferenciaErrorUsuario(i);
						break;
					case "AR":
						Console.WriteLine("Score de buro de credito"); 
						i=this.AR_respuestaErrorReferenciaErrorAutentificacion(i);
						break;
				}
				i++;
			}
		}

		public int PN_respuestaSeccionNombres(int estadoInc)
		{
			bool salir = false;
			while(salir == false)
			{
				switch(etiSecc[estadoInc].ToString())
				{
					case "PN":
						seccionNombres.Ape_Paterno = valSecc[estadoInc].ToString();
						break;
					case "00":
						seccionNombres.Ape_Materno = valSecc[estadoInc].ToString();
						break;
					case "01":
						seccionNombres.Ape_Adicional = valSecc[estadoInc].ToString();
						break;
					case "02":
						seccionNombres.Primer_Nombre = valSecc[estadoInc].ToString();
						break;
					case "03":
						seccionNombres.Segundo_Nombre= valSecc[estadoInc].ToString();
						break;
					case "04":
						seccionNombres.Fecha_Nacimiento = cambiaFechaAFormatoABAP(valSecc[estadoInc].ToString());
						break;
					case "05":
						seccionNombres.Rfc = valSecc[estadoInc].ToString();
						break;
					case "06":
						seccionNombres.Prefijo = valSecc[estadoInc].ToString();
						break;
					case "07":
						seccionNombres.Sufijo= valSecc[estadoInc].ToString();
						break;
					case "08":
						seccionNombres.Nacionalidad = valSecc[estadoInc].ToString();
						break;
					case "09":
						seccionNombres.Residencia = valSecc[estadoInc].ToString();
						break;
					case "10":
						seccionNombres.Lic_Conducir = valSecc[estadoInc].ToString();
						break;
					case "11":
						seccionNombres.Edo_Civil = valSecc[estadoInc].ToString();
						break;
					case "12":
						seccionNombres.Sexo = valSecc[estadoInc].ToString();
						break;
					case "13":
						seccionNombres.Cedula_Prof = valSecc[estadoInc].ToString();
						break;
					case "14":
						seccionNombres.Reg_Electoral = valSecc[estadoInc].ToString();
						break;
					case "15":
						seccionNombres.Impuestos_Ext = valSecc[estadoInc].ToString();
						break;
					case "16":
						seccionNombres.Pais_Ext = valSecc[estadoInc].ToString();
						break;
					case "17":
						seccionNombres.Dependientes = valSecc[estadoInc].ToString();
						break;
					case "18":
						seccionNombres.Edades_Dep= valSecc[estadoInc].ToString();
						break;
					case "19":
						seccionNombres.Fecha_Defuncion = cambiaFechaAFormatoABAP(valSecc[estadoInc].ToString());
						break;
					case "20":
						seccionNombres.Fecha_Defuncion = cambiaFechaAFormatoABAP(valSecc[estadoInc].ToString());
						break;
					default:
						salir= true;
						estadoInc=estadoInc-2;
						//seccionNombresTable.Add(seccionNombres);
						break;
				}
				estadoInc++;
			}
			seccionNombresTable.Add(seccionNombres);
			return estadoInc;
		}
	
		public int PA_respuestaSeccionDireccion(int estadoInc)
		{
			bool salir = false;
			int repeticiones=0;
			while(salir == false)
			{
				switch(etiSecc[estadoInc].ToString())
				{
					case "PA":
						if(repeticiones==0)
						{
							seccionDireccion.Direccion1= valSecc[estadoInc].ToString();
							repeticiones++;
						}
						else
						{
							if(repeticiones<4)
							{
								seccionDireccionTable.Add(seccionDireccion);
								seccionDireccion = new Z00_BURO_PA();
								//seccionDireccionTable.CreateNewRow();
								seccionDireccion.Direccion1 = valSecc[estadoInc].ToString();
								repeticiones++;
							}
							else
							{
								Console.WriteLine("Esta seccion solo puede repetirce 4 veces debe existir un error");
							}
						}
						break;
					case "00":
						seccionDireccion.Direccion2 = valSecc[estadoInc].ToString();
						break;
					case "01":
						seccionDireccion.Colonia = valSecc[estadoInc].ToString();
						break;
					case "02":
						seccionDireccion.Municipio = valSecc[estadoInc].ToString();
						break;
					case "03":
						seccionDireccion.Ciudad = valSecc[estadoInc].ToString();
						break;
					case "04":
						seccionDireccion.Estado = valSecc[estadoInc].ToString();
						break;
					case "05":
						seccionDireccion.Cp = valSecc[estadoInc].ToString();
						break;
					case "06":
						seccionDireccion.Fecha_Residencia = cambiaFechaAFormatoABAP(valSecc[estadoInc].ToString());
						break;
					case "07":
						seccionDireccion.Telefono= valSecc[estadoInc].ToString();
						break;
					case "08":
						seccionDireccion.Extension_Tel = valSecc[estadoInc].ToString();
						break;
					case "09":
						seccionDireccion.Fax = valSecc[estadoInc].ToString();
						break;
					case "10":
						seccionDireccion.Tipo_Domicilio = valSecc[estadoInc].ToString();
						break;
					case "11":
						seccionDireccion.Id_Esp_Dom = valSecc[estadoInc].ToString();
						break;
					case "12":
						seccionDireccion.Fecha_Dir = cambiaFechaAFormatoABAP(valSecc[estadoInc].ToString());
						break;
					default:
						salir= true;
						estadoInc=estadoInc-2;
						//seccionDireccionTable.Add(seccionDireccion);
						break;
				}
				estadoInc++;
			}
			seccionDireccionTable.Add(seccionDireccion);
			return estadoInc;
		}

		public int PE_respuestaSeccionEmpleos(int estadoInc)
		{
			bool salir = false;
			int repeticiones=0;
			while(salir == false)
			{
				switch(etiSecc[estadoInc].ToString())
				{
					case "PE":
						if(repeticiones==0)
						{
							seccionEmpleos.Razonsocial = valSecc[estadoInc].ToString();
							repeticiones++;
						}
						else
						{
							if(repeticiones<2)
							{
								seccionEmpleosTable.Add(seccionEmpleos);
								seccionEmpleos = new Z00_BURO_PE();
								//seccionEmpleosTable.CreateNewRow();
								seccionEmpleos.Razonsocial = valSecc[estadoInc].ToString();
								repeticiones++;
							}
							else
							{
								Console.WriteLine("Esta seccion solo puede repetirce 2 veces debe existir un error");
							}
						}
						break;
					case "00":
						seccionEmpleos.Direccion1 = valSecc[estadoInc].ToString();
						break;
					case "01":
						seccionEmpleos.Direccion2 = valSecc[estadoInc].ToString();
						break;
					case "02":
						seccionEmpleos.Colonia = valSecc[estadoInc].ToString();
						break;
					case "03":
						seccionEmpleos.Municipio = valSecc[estadoInc].ToString();
						break;
					case "04":
						seccionEmpleos.Ciudad= valSecc[estadoInc].ToString();
						break;
					case "05":
						seccionEmpleos.Estado = valSecc[estadoInc].ToString();
						break;
					case "06":
						seccionEmpleos.Cp = valSecc[estadoInc].ToString();
						break;
					case "07":
						seccionEmpleos.Telefono = valSecc[estadoInc].ToString();
						break;
					case "08":
						seccionEmpleos.Extension_Tel = valSecc[estadoInc].ToString();
						break;
					case "09":
						seccionEmpleos.Fax = valSecc[estadoInc].ToString();
						break;
					case "10":
						seccionEmpleos.Cargo = valSecc[estadoInc].ToString();
						break;
					case "11":
						seccionEmpleos.Fecha_Contrata = cambiaFechaAFormatoABAP(valSecc[estadoInc].ToString());
						break;
					case "12":
						seccionEmpleos.Moneda = valSecc[estadoInc].ToString();
						break;
					case "13":
						seccionEmpleos.Salario = valSecc[estadoInc].ToString();
						break;
					case "14":
						seccionEmpleos.Base = valSecc[estadoInc].ToString();
						break;
					case "15":
						seccionEmpleos.Num_Empleado = valSecc[estadoInc].ToString();
						break;
					case "16":
						seccionEmpleos.Fecha_Ult_Dia = cambiaFechaAFormatoABAP(valSecc[estadoInc].ToString());
						break;
					case "17":
						seccionEmpleos.Fecha_Registro= cambiaFechaAFormatoABAP(valSecc[estadoInc].ToString());
						break;
					case "18":
						seccionEmpleos.Fecha_Verif = cambiaFechaAFormatoABAP(valSecc[estadoInc].ToString());
						break;
					case "19":
						seccionEmpleos.Modo_Verif = valSecc[estadoInc].ToString();
						break;
					default:
						salir= true;
						estadoInc=estadoInc-2;
						//seccionDireccionTable.Add(seccionDireccion);
						break;
				}
				estadoInc++;
			}
			seccionEmpleosTable.Add(seccionEmpleos);
			return estadoInc;
		}

		public int TL_respuestaSeccionCreditos(int estadoInc)
		{
			bool salir = false;
			int repeticiones=0;
			while(salir == false && estadoInc != etiSecc.Count)
			{
				switch(etiSecc[estadoInc].ToString())
				{
					case "TL":
						if(repeticiones==0)
						{
							seccionCreditos.Fecha_Actualiza = cambiaFechaAFormatoABAP(valSecc[estadoInc].ToString());
							repeticiones++;
						}
						else
						{
								seccionCreditosTable.Add(seccionCreditos);
								//seccionCreditosTable.CreateNewRow();
								seccionCreditos = new Z00_BURO_TL();
								seccionCreditos.Fecha_Actualiza = cambiaFechaAFormatoABAP(valSecc[estadoInc].ToString());
								repeticiones++;
						}
						break;
					case "00":
						seccionCreditos.Reg_Impugnado= valSecc[estadoInc].ToString();
						break;
					case "01":
						seccionCreditos.Otorgante= valSecc[estadoInc].ToString();
						break;
					case "02":
						seccionCreditos.Nombre_Otorgante= valSecc[estadoInc].ToString();
						break;
					case "03":
						if(valSecc[estadoInc].ToString().Length==1)
						{
							seccionCreditos.Sic= valSecc[estadoInc].ToString();
						}
						else
						{
							seccionCreditos.Telefono= valSecc[estadoInc].ToString();
						}
						break;
					case "04":
						seccionCreditos.Cuenta= valSecc[estadoInc].ToString();
						break;
					case "05":
						seccionCreditos.Tipo_Respon= valSecc[estadoInc].ToString();
						break;
					case "06":
						seccionCreditos.Tipo_Cuenta= valSecc[estadoInc].ToString();
						break;
					case "07":
						seccionCreditos.Tipo_Contrato= valSecc[estadoInc].ToString();
						break;
					case "08":
						seccionCreditos.Moneda= valSecc[estadoInc].ToString();
						break;
					case "09":
						seccionCreditos.Valor_Activo= valSecc[estadoInc].ToString();
						break;
					case "10":
						seccionCreditos.Num_Pagos= valSecc[estadoInc].ToString();
						break;
					case "11":
						seccionCreditos.Frecuencia= valSecc[estadoInc].ToString();
						break;
					case "12":
						seccionCreditos.Monto= valSecc[estadoInc].ToString();
						break;
					case "13":
						seccionCreditos.Fecha_Apertura= cambiaFechaAFormatoABAP(valSecc[estadoInc].ToString());
						break;
					case "14":
						seccionCreditos.Fecha_Ult_Pago= cambiaFechaAFormatoABAP(valSecc[estadoInc].ToString());
						break;
					case "15":
						seccionCreditos.Fecha_Ult_Compra= cambiaFechaAFormatoABAP(valSecc[estadoInc].ToString());
						break;
					case "16":
						seccionCreditos.Fecha_Cierre= cambiaFechaAFormatoABAP(valSecc[estadoInc].ToString());
						break;
					case "17":
						seccionCreditos.Fecha_Reporte= cambiaFechaAFormatoABAP(valSecc[estadoInc].ToString());
						break;
					case "18":
						seccionCreditos.Modo_Reporte = valSecc[estadoInc].ToString();
						break;
					case "19":
						seccionCreditos.Fecha_Cero = valSecc[estadoInc].ToString();
						break;
					case "20":
						seccionCreditos.Garantia=  valSecc[estadoInc].ToString();
						break;
					case "21":
						seccionCreditos.Credito_Max = valSecc[estadoInc].ToString();
						break;
					case "22":
						seccionCreditos.Saldo_Actual= valSecc[estadoInc].ToString();
						break;
					case "23":
						seccionCreditos.Limite_Credito= valSecc[estadoInc].ToString();
						break;
					case "24":
						seccionCreditos.Saldo_Vencido= valSecc[estadoInc].ToString();
						break;
					case "25":
						seccionCreditos.Pagos_Vencidos= valSecc[estadoInc].ToString();
						break;
					case "26":
						seccionCreditos.Mop= valSecc[estadoInc].ToString();
						break;
					case "27":
						seccionCreditos.Historico_Pagos= valSecc[estadoInc].ToString();
						break;
					case "28":
						seccionCreditos.Fecha_Rec_Hist= cambiaFechaAFormatoABAP(valSecc[estadoInc].ToString());
						break;
					case "29":
						seccionCreditos.Fecha_Ant_Hist = cambiaFechaAFormatoABAP(valSecc[estadoInc].ToString());
						break;
					case "30":
						seccionCreditos.Observacion= valSecc[estadoInc].ToString();
						break;
					case "31":
						seccionCreditos.Total_Pagos= valSecc[estadoInc].ToString();
						break;
					case "32":
						seccionCreditos.Calif_Mop02= valSecc[estadoInc].ToString();
						break;
					case "33":
						seccionCreditos.Calif_Mop03= valSecc[estadoInc].ToString();
						break;
					case "34":
						seccionCreditos.Calif_Mop04= valSecc[estadoInc].ToString();
						break;
					case "35":
						seccionCreditos.Calif_Mop05= valSecc[estadoInc].ToString();
						break;
					case "36":
						seccionCreditos.Hist_Mora_Saldo= valSecc[estadoInc].ToString();
						break;
					case "37":
						seccionCreditos.Hist_Mora_Fecha= cambiaFechaAFormatoABAP(valSecc[estadoInc].ToString());
						break;
					case "38":
						seccionCreditos.Hist_Mora_Mop02= valSecc[estadoInc].ToString();
						break;
					case "42":
						seccionCreditos.Fecha_Inicio= cambiaFechaAFormatoABAP(valSecc[estadoInc].ToString());
						break;
					default:
						salir= true;
						estadoInc=estadoInc-2;
						//seccionCreditosTable.Add(seccionCreditos);
						break;
				}
				estadoInc++;
			}
			seccionCreditosTable.Add(seccionCreditos);
			return estadoInc;
		}
		
		public int IQ_respuestaSeccionConsultasRepCredito(int estadoInc)
		{
				bool salir = false;
				int repeticiones=0;
				while(salir == false && estadoInc < etiSecc.Count)
				{
					switch(etiSecc[estadoInc].ToString())
					{
						case "IQ":
							if(repeticiones==0)
							{
								seccionConsultasRepCredito.Fecha_Consulta = cambiaFechaAFormatoABAP(valSecc[estadoInc].ToString());
								repeticiones++;
							}
							else
							{
								seccionConsultasRepCreditoTable.Add(seccionConsultasRepCredito);
								//seccionConsultasRepCreditoTable.CreateNewRow();
								seccionConsultasRepCredito = new Z00_BURO_IQ();
								seccionConsultasRepCredito.Fecha_Consulta = valSecc[estadoInc].ToString();
								repeticiones++;
							}
							break;
						case "00":
							seccionConsultasRepCredito.Id_Buro = valSecc[estadoInc].ToString();
							break;
						case "01":
							seccionConsultasRepCredito.Otorgante= valSecc[estadoInc].ToString();
							break;
						case "02":
							seccionConsultasRepCredito.Nombre_Otorgante= valSecc[estadoInc].ToString();
							break;
						case "03":
							seccionConsultasRepCredito.Telefono= valSecc[estadoInc].ToString();
							break;
						case "04":
							seccionConsultasRepCredito.Tipo_Contrato= valSecc[estadoInc].ToString();
							break;
						case "05":
							seccionConsultasRepCredito.Moneda= valSecc[estadoInc].ToString();
							break;
						case "06":
							seccionConsultasRepCredito.Importe= valSecc[estadoInc].ToString();
							break;
						case "07":
							seccionConsultasRepCredito.Tipo_Respon= valSecc[estadoInc].ToString();
							break;
						case "08":
							seccionConsultasRepCredito.Consumidor_Nuevo= valSecc[estadoInc].ToString();
							break;
						case "09":
							if(valSecc[estadoInc].ToString().Length==1)
							{
								seccionConsultasRepCredito.Sic= valSecc[estadoInc].ToString();
							}
							else
							{
								seccionConsultasRepCredito.Resultado= valSecc[estadoInc].ToString();
							}
							break;
						default:
							salir= true;
							estadoInc=estadoInc-2;
							//seccionConsultasRepCreditoTable.Add(seccionConsultasRepCredito);
							break;
					}
					estadoInc++;
				}
				seccionConsultasRepCreditoTable.Add(seccionConsultasRepCredito);
				return estadoInc;
		}

		public int RS_respuestaSeccionResumenRep(int estadoInc)
		{
			//seccionCreditos
			bool salir = false;
			int repeticiones=0;
			while(salir == false && estadoInc != etiSecc.Count)
			{
				switch(etiSecc[estadoInc].ToString())
				{
					case "RS":
						if(repeticiones==0)
						{
							seccionResumenRep.Fecha_Ingreso = valSecc[estadoInc].ToString();
							repeticiones++;
						}
						else
						{
							if(repeticiones<3)
							{
								seccionResumenRepTable.Add(seccionResumenRep);
								//seccionResumenRepTable.CreateNewRow();
								seccionResumenRep = new Z00_BURO_RS();
								seccionResumenRep.Fecha_Ingreso = valSecc[estadoInc].ToString();
								repeticiones++;
							}
							else
							{
								Console.WriteLine("Esta seccion solo puede repetirce 3 veces debe existir un error");
							}
						}
						break;
					case "00":
						seccionResumenRep.Num_Mop07= valSecc[estadoInc].ToString();
						break;
					case "01":
						seccionResumenRep.Num_Mop06= valSecc[estadoInc].ToString();
						break;
					case "02":
						seccionResumenRep.Num_Mop05= valSecc[estadoInc].ToString();
						break;
					case "03":
						seccionResumenRep.Num_Mop04= valSecc[estadoInc].ToString();
						break;
					case "04":
						seccionResumenRep.Num_Mop03= valSecc[estadoInc].ToString();
						break;
					case "05":
						seccionResumenRep.Num_Mop02= valSecc[estadoInc].ToString();
						break;
					case "06":
						seccionResumenRep.Num_Mop01= valSecc[estadoInc].ToString();
						break;
					case "07":
						seccionResumenRep.Num_Mop00= valSecc[estadoInc].ToString();
						break;
					case "08":
						seccionResumenRep.Num_Mopur= valSecc[estadoInc].ToString();
						break;
					case "09":
						seccionResumenRep.Num_Cuentas= valSecc[estadoInc].ToString();
						break;
					case "10":
						seccionResumenRep.Cuentas_Fijos= valSecc[estadoInc].ToString();
						break;
					case "11":
						seccionResumenRep.Cuentas_Revol= valSecc[estadoInc].ToString();
						break;
					case "12":
						seccionResumenRep.Cuentas_Cerradas= valSecc[estadoInc].ToString();
						break;
					case "13":
						seccionResumenRep.Cuentas_Neg= valSecc[estadoInc].ToString();
						break;
					case "14":
						seccionResumenRep.Cuentas_Mop= valSecc[estadoInc].ToString();
						break;
					case "15":
						seccionResumenRep.Cuentas_Disputa= valSecc[estadoInc].ToString();
						break;
					case "16":
						seccionResumenRep.Solicitudes= valSecc[estadoInc].ToString();
						break;
					case "17":
						seccionResumenRep.Nueva_Direccion= valSecc[estadoInc].ToString();
						break;
					case "18":
						seccionResumenRep.Alerta= valSecc[estadoInc].ToString();
						break;
					case "19":
						seccionResumenRep.Declaraciones= valSecc[estadoInc].ToString();
						break;
					case "20":
						seccionResumenRep.Moneda= valSecc[estadoInc].ToString();
						break;
					case "21":
						seccionResumenRep.Tot_Creditos_Rev= valSecc[estadoInc].ToString();
						break;
					case "22":
						seccionResumenRep.Tot_Limites_Rev= valSecc[estadoInc].ToString();
						break;
					case "23":
						seccionResumenRep.Tot_Saldos_Rev= valSecc[estadoInc].ToString();
						break;
					case "24":
						seccionResumenRep.Tot_Ven_Rev = valSecc[estadoInc].ToString();
						break;
					case "25":
						seccionResumenRep.Tot_Pagos_Rev = valSecc[estadoInc].ToString();
						break;
					case "26":
						seccionResumenRep.Por_Lim_Rev = valSecc[estadoInc].ToString();
						break;
					case "27":
						seccionResumenRep.Tot_Creditos_Hip = valSecc[estadoInc].ToString();
						break;
					case "28":
						seccionResumenRep.Tot_Saldos_Hip= valSecc[estadoInc].ToString();
						break;
					case "29":
						seccionResumenRep.Tot_Ven_Hip= valSecc[estadoInc].ToString();
						break;
					case "30":
						seccionResumenRep.Tot_Saldos_Hip= valSecc[estadoInc].ToString();
						break;
					case "31":
						seccionResumenRep.Num_Mop96= valSecc[estadoInc].ToString();
						break;
					case "32":
						seccionResumenRep.Num_Mop97= valSecc[estadoInc].ToString();
						break;
					case "33":
						seccionResumenRep.Num_Mop99= valSecc[estadoInc].ToString();
						break;
					case "34":
						seccionResumenRep.F_Ant_Cuenta= cambiaFechaAFormatoABAP(valSecc[estadoInc].ToString());
						break;
					case "35":
						seccionResumenRep.F_Rec_Cuenta= cambiaFechaAFormatoABAP(valSecc[estadoInc].ToString());
						break;
					case "36":
						seccionResumenRep.Tot_Solicitudes= valSecc[estadoInc].ToString();
						break;
					case "37":
						seccionResumenRep.F_Rec_Reporte = cambiaFechaAFormatoABAP(valSecc[estadoInc].ToString());
						break;
					case "38":
						seccionResumenRep.Num_Cobranzas= valSecc[estadoInc].ToString();
						break;
					case "39":
						seccionResumenRep.Fecha_Cobranza= cambiaFechaAFormatoABAP(valSecc[estadoInc].ToString());
						break;
					case "40":
						seccionResumenRep.Tot_Solic_Cobra= valSecc[estadoInc].ToString();
						break;
					case "41":
						seccionResumenRep.F_Solic_Cobra= cambiaFechaAFormatoABAP(valSecc[estadoInc].ToString());
						break;
					default:
						salir= true;
						estadoInc=estadoInc-2;
						//seccionResumenRepTable.Add(seccionResumenRep);
						break;
				}
				estadoInc++;
			}
			seccionResumenRepTable.Add(seccionResumenRep);
			return estadoInc;
		}

		public int HI_respuestaSeccionHankAlertCD(int estadoInc)
		{
			bool salir = false;
			int repeticiones=0;
			while(salir == false && estadoInc!=etiSecc.Count)
			{
				switch(etiSecc[estadoInc].ToString())
				{
					case "HI":
						if(repeticiones==0)
						{
							seccionHankAlertCD.Fecha = cambiaFechaAFormatoABAP(valSecc[estadoInc].ToString());
							repeticiones++;
						}
						else
						{
							if(repeticiones<20)
							{
								seccionHankAlertCDTable.Add(seccionHankAlertCD);
								//seccionHankAlertCDTable.CreateNewRow();
								seccionHankAlertCD = new Z00_BURO_HI();
								seccionHankAlertCD.Fecha = cambiaFechaAFormatoABAP(valSecc[estadoInc].ToString());
								repeticiones++;
							}
							else
							{
								Console.WriteLine("Esta seccion solo puede repetirce 20 veces debe existir un error");
							}
						}
						break;
					case "00":
						seccionHankAlertCD.Codigo = valSecc[estadoInc].ToString();
						break;
					case "01":
						seccionHankAlertCD.Institucion = valSecc[estadoInc].ToString();
						break;
					case "02":
						seccionHankAlertCD.Mensaje = valSecc[estadoInc].ToString();
						break;
					default:
						salir= true;
						estadoInc=estadoInc-2;
						//seccionDireccionTable.Add(seccionDireccion);
						break;
				}
				estadoInc++;
			}
			seccionHankAlertCDTable.Add(seccionHankAlertCD);
			return estadoInc;
		}

		public int HR_respuestaSeccionHankAlertCDReg(int estadoInc)
		{
			bool salir = false;
			int repeticiones=0;
			while(salir == false && estadoInc < etiSecc.Count)
			{
				switch(etiSecc[estadoInc].ToString())
				{
					case "HR":
						if(repeticiones==0)
						{
							seccionHankAlertCDReg["Fecha"] = cambiaFechaAFormatoABAP(valSecc[estadoInc].ToString());
							repeticiones++;
						}
						else
						{
							if(repeticiones<20)
							{
								seccionHankAlertCDRegTable.Add(seccionHankAlertCDReg);
								seccionHankAlertCDReg = new Z00_BURO_HR();
								//seccionHankAlertCDRegTable.CreateNewRow();
								seccionHankAlertCDReg.Fecha = cambiaFechaAFormatoABAP(valSecc[estadoInc].ToString());
								repeticiones++;
							}
							else
							{
								Console.WriteLine("Esta seccion solo puede repetirce 20 veces debe existir un error");
							}
						}
						break;
					case "00":
						seccionHankAlertCDReg.Codigo = valSecc[estadoInc].ToString();
						break;
					case "01":
						seccionHankAlertCDReg.Institucion = valSecc[estadoInc].ToString();
						break;
					case "02":
						seccionHankAlertCDReg.Mensaje = valSecc[estadoInc].ToString();
						break;
					default:
						salir= true;
						estadoInc=estadoInc-2;
						//seccionDireccionTable.Add(seccionDireccion);
						break;
				}
				estadoInc++;
			}
			seccionHankAlertCDRegTable.Add(seccionHankAlertCDReg);
			return estadoInc;
		}

		public int CR_respuestaSeccionDeclaracionesDelCliente(int estadoInc)
		{
			bool salir = false;
			while(salir == false)
			{
				switch(etiSecc[estadoInc].ToString())
				{
					case "CR":
						seccionDeclaracionesDelCliente.Longitud = valSecc[estadoInc].ToString();
						break;
					case "00":
						seccionDeclaracionesDelCliente.Declaracion1 = valSecc[estadoInc].ToString();
						int longitud =  valSecc[estadoInc].ToString().Length;
						if(longitud<250)
						{
						  seccionDeclaracionesDelCliente.Declaracion1 = valSecc[estadoInc].ToString().Substring(0,longitud);
							salir= true;
						}
						if(longitud<500 && longitud>250 )
						{
							seccionDeclaracionesDelCliente.Declaracion1 = valSecc[estadoInc].ToString().Substring(0,250);
							seccionDeclaracionesDelCliente.Declaracion2 = valSecc[estadoInc].ToString().Substring(250,longitud-250);
							salir= true;
						}
						if(longitud<750 && longitud>500 )
						{
							seccionDeclaracionesDelCliente.Declaracion1 = valSecc[estadoInc].ToString().Substring(0,250);
							seccionDeclaracionesDelCliente.Declaracion2 = valSecc[estadoInc].ToString().Substring(250,250);
							seccionDeclaracionesDelCliente.Declaracion3 = valSecc[estadoInc].ToString().Substring(500,longitud-500);
							salir= true;
						}
						if(longitud<100 && longitud>750 )
						{
							seccionDeclaracionesDelCliente.Declaracion1 = valSecc[estadoInc].ToString().Substring(0,250);
							seccionDeclaracionesDelCliente.Declaracion2 = valSecc[estadoInc].ToString().Substring(250,250);
							seccionDeclaracionesDelCliente.Declaracion3 = valSecc[estadoInc].ToString().Substring(500,500);
							seccionDeclaracionesDelCliente.Declaracion4 = valSecc[estadoInc].ToString().Substring(750,longitud-750);
							salir= true;
						}
						break;
					default:
						salir= true;
						estadoInc=estadoInc-2;
						//seccionNombresTable.Add(seccionNombres);
						break;
				}
				estadoInc++;
			}
			seccionDeclaracionesDelClienteTable.Add(seccionDeclaracionesDelCliente);
			return estadoInc;
		}

		public int SC_respuestaSeccionScoreBuro(int estadoInc)
		{
			bool salir = false;
			int repeticiones=0;
			while(salir == false)
			{
				switch(etiSecc[estadoInc].ToString())
				{
					case "SC":
						if(repeticiones==0)
						{
							seccionScoreBuro.Nombre= valSecc[estadoInc].ToString();
							repeticiones++;
						}
						else
						{
							if(repeticiones<15)
							{
								seccionScoreBuroTable.Add(seccionScoreBuro);
								//seccionScoreBuroTable.CreateNewRow();
								seccionScoreBuro = new Z00_BURO_SC();
								seccionScoreBuro.Nombre= valSecc[estadoInc].ToString();
								repeticiones++;
							}
							else
							{
								Console.WriteLine("Esta seccion solo puede repetirce 15 veces debe existir un error");
							}
						}
						break;
					case "00":
						seccionScoreBuro.Codigo = valSecc[estadoInc].ToString();
						break;
					case "01":
						seccionScoreBuro.Valor = valSecc[estadoInc].ToString();
						break;
					case "02":
						seccionScoreBuro.Razon1 = valSecc[estadoInc].ToString();
						break;
					case "03":
						seccionScoreBuro.Razon2 = valSecc[estadoInc].ToString();
						break;
					case "04":
						seccionScoreBuro.Razon3 = valSecc[estadoInc].ToString();
						break;
					case "06":
						seccionScoreBuro.Error = valSecc[estadoInc].ToString();
						break;
					default:
						salir= true;
						estadoInc=estadoInc-2;
						//seccionScoreBuroTable.Add(seccionScoreBuro);
						break;
				}
				estadoInc++;
			}
			seccionScoreBuroTable.Add(seccionScoreBuro);
			return estadoInc;
		}

		public int UR_respuestaErrorReferenciaErrorUsuario(int estadoInc)
		{
			bool salir = false;
			while(salir == false)
			{
				switch(etiSecc[estadoInc].ToString())
				{
					case "UR":
							errorReferenciaErrorUsuario.Ref_Operador= valSecc[estadoInc].ToString();
							break;
					case "00":
						errorReferenciaErrorUsuario.Solicitud= valSecc[estadoInc].ToString();
						break;
					case "01":
						errorReferenciaErrorUsuario.Version= valSecc[estadoInc].ToString();
						break;
					case "02":
						errorReferenciaErrorUsuario.Producto= valSecc[estadoInc].ToString();
						break;
					case "03":
						errorReferenciaErrorUsuario.Password= valSecc[estadoInc].ToString();
						break;
					case "04":
						errorReferenciaErrorUsuario.Segmento= valSecc[estadoInc].ToString();
						break;
					case "05":
						errorReferenciaErrorUsuario.Ult_Info_Valida= valSecc[estadoInc].ToString();
						break;
					case "06":
						errorReferenciaErrorUsuario.Info_Err_Consul= valSecc[estadoInc].ToString();
						break;
					case "07":
						errorReferenciaErrorUsuario.Valor_Err_Rel= valSecc[estadoInc].ToString();
						break;
					case "11":
						errorReferenciaErrorUsuario.Error_Buro= valSecc[estadoInc].ToString();
						break;
					case "12":
						errorReferenciaErrorUsuario.Etiqueta_Seg= valSecc[estadoInc].ToString();
						break;
					case "13":
						errorReferenciaErrorUsuario.Orden_Err= valSecc[estadoInc].ToString();
						break;
					case "14":
						errorReferenciaErrorUsuario.Num_Err_Seg= valSecc[estadoInc].ToString();
						break;
					case "16":
						errorReferenciaErrorUsuario.Requerido1= valSecc[estadoInc].ToString();
						break;
					default:
						salir= true;
						estadoInc=estadoInc-2;
						//errorReferenciaErrorUsuarioTable.Add(errorReferenciaErrorUsuario);
						break;
				}
				estadoInc++;
			}
			errorReferenciaErrorUsuarioTable.Add(errorReferenciaErrorUsuario);
			return estadoInc;
		}

		public int AR_respuestaErrorReferenciaErrorAutentificacion(int estadoInc)
		{
			bool salir = false;
			while(salir == false && estadoInc < etiSecc.Count)
			{
				switch(etiSecc[estadoInc].ToString())
				{
					case "AR":
						errorReferenciaErrorAutentificacion.Ref_Operador = valSecc[estadoInc].ToString();
						break;
					case "00":
						errorReferenciaErrorAutentificacion.No_Autenticado = valSecc[estadoInc].ToString();
						break;
					case "03":
						errorReferenciaErrorAutentificacion.Clave = valSecc[estadoInc].ToString();
						break;
					case "11":
						errorReferenciaErrorAutentificacion.Error_Buro = valSecc[estadoInc].ToString();
						break;
					case "12":
						errorReferenciaErrorAutentificacion.Segmento = valSecc[estadoInc].ToString();
						break;
					case "16":
						errorReferenciaErrorAutentificacion.Requerido1 = valSecc[estadoInc].ToString();
						break;
					default:
						salir= true;
						estadoInc=estadoInc-2;
						//errorReferenciaErrorAutentificacionTable.Add(errorReferenciaErrorAutentificacion);
						break;
				}
				estadoInc++;
			}
			errorReferenciaErrorAutentificacionTable.Add(errorReferenciaErrorAutentificacion);
			return estadoInc;
		}

		private string cambiaFechaAFormatoABAP(string fechaBuro)
		{
			//ABAP..............:aaaammdd
			//Buro de credito...:ddmmaaaa
			if (fechaBuro.Length == 8 && fechaBuro != "" )
			{
				string day,month,year,fechaBC;
				year = fechaBuro.Substring(4,4);
				month = fechaBuro.Substring(2,2);
				day = fechaBuro.Substring(0,2);
				fechaBC = year+month+day;
				return fechaBC;
			}
			return fechaBuro;
		}

		public void recibirRespuesta(string respuesta)
		{
			string Encabezado = string.Empty;
			string Contenido = string.Empty;
			string final = string.Empty;
			if(respuesta.Substring(0,4)== "INTL")
			{
				Encabezado = respuesta.Substring(0,49);
				Contenido = respuesta.Substring(49,respuesta.Length-28-49);
				final = respuesta.Substring(respuesta.Length-28,28);

				this.respuestaEncabezadoINTL(Encabezado);
				this.tablaDeValores(Contenido);
				this.tablasTemporalesASap();
			}
			if(respuesta.Substring(0,4)== "ERRR")
			{
			  Contenido = respuesta.Substring(4,respuesta.Length-15-4);
			  this.tablaDeValores(Contenido);
			  this.tablasTemporalesASap();
			}

		}
		public void RespuestaFinalAlRFC(string errorCode,string id_Consulta,string id_partner)
		{
			SapConnectorClientToBC proxy = conn.establecerConeccionSap();
			try
			{
				proxy.Connection.Open();
				proxy.Zrfc_Buro_Respuesta(errorCode,id_Consulta,id_partner,
					ref errorReferenciaErrorAutentificacionTable,
					ref seccionDeclaracionesDelClienteTable,
					ref seccionHankAlertCDTable,
					ref seccionHankAlertCDRegTable,
					ref encabezadoINTLTable,
					ref seccionConsultasRepCreditoTable,
					ref seccionDireccionTable,
					ref seccionEmpleosTable,
					ref seccionNombresTable,
					ref seccionResumenRepTable,
					ref seccionScoreBuroTable,
					ref seccionCreditosTable,
					ref errorReferenciaErrorUsuarioTable);
				proxy.Connection.Close();
			}
			catch(SAP.Connector.RfcLogonException a)
			{
				Console.WriteLine("Existe un error el Usuario o contraseña, el sistema no se ha podido conectar "+a);
			}
			catch(SAP.Connector.RfcCommunicationException a)
			{
				Console.WriteLine("El usuario se tardo demacionado en aceptar que la conexion era segura"+a);
			}
			catch(SAP.Connector.RfcMarshalException a)
			{
				Console.WriteLine("Error en la conversion de datos , probablemente la consulta este regresando caracteres que no correspondan correctamente"+a);
			}
			catch(SAP.Connector.RfcSystemException a)
			{
				Console.WriteLine("No se encontro el RFC"+a);
			}
			catch(SAP.Connector.RfcAbapException a)
			{
				Console.WriteLine("No se encontro el ID de la consulta "+a);
			}
			catch(SAP.Connector.RfcException a)
			{
				Console.WriteLine("No se encontro el RFC"+a);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.ToString());
			}
			finally {proxy.Connection.Close();}
		}
	}
}
