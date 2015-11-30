using System;
using System.Text;
using System.Data;
using System.Collections;
using System.Text.RegularExpressions;

namespace ZConsultaBuro
{
	/// <summary>
	/// Esta clase se utiliza para para las consultas al buro de credito
	/// </summary>
    class FormatoINTL
    {
		private ConnexionSAP conn;
        private ArrayList requeridos = new ArrayList();
        private bool existenRequeritos = true;
		public FormatoINTL(ConnexionSAP consultaSap)
		{
			this.conn = consultaSap;
		}
        private string encabezadoINTL = string.Empty ;
        private string segmentoDeNombrePN = string.Empty ;
        private string segmentoDeDireccionPA = string.Empty;
        private string segmentoDeEmpleoPE = string.Empty;
        private string segmentoDeCuentasPI = string.Empty;
        private string segmentoParaAutenificacionAU = string.Empty;
        private string segmentodeFinES = string.Empty ;
		private char[] ubicacion = new char[88];

		#region  DataTables de los segmentos

		private DataTable dataTableSegmentoPN;
		private DataTable dataTableEncabezadoIntl;
		private DataTable dataTableSegmentoPA;

		#endregion

	    #region Encabezado INTL
        public string EncabezadoINTL ()
        {

			string etiqueta = string.Empty;
			string version = string.Empty;
			string RefOperador = string.Empty;
			string producto = string.Empty;
			string pais = string.Empty;
			string buroID = string.Empty;
			string claveUsuario = string.Empty;
			string passUsuario = string.Empty;
			string tipoConsulta = string.Empty;
			string tipoContrato = string.Empty;
			string moneda = string.Empty;
			string importeContrato = string.Empty;
			string idioma = string.Empty;
			string tipoSalida = string.Empty;
			string bloqueRespuesta = string.Empty;
			string impresoraID = string.Empty;
			string usoFuturo = string.Empty;

			foreach(DataRow dataRow in dataTableEncabezadoIntl.Rows)
			{
				foreach(DataColumn dataColumn in dataTableEncabezadoIntl.Columns)
				{
					string val = dataRow[dataColumn].ToString();
					//Console.WriteLine("Columna: "+dataColumn.ColumnName.ToUpper()+"\n Valor :"+  val+"\n Longitud: "+val.Length);
					string columna = dataColumn.ColumnName.ToUpper();
					string valor = val.ToUpper();
					int longitud = val.Length;

					//Console.WriteLine();
					switch(columna)
					{

						case "ETIQUETA": 
							etiqueta  = this.lineaformatoIntlEncabezado(1,valor,4);
							break;
						case "VERSION": 
							version  = this.lineaformatoIntlEncabezado(5,valor,2);
							break;
						case "REF_OPERADOR": 
							RefOperador  = this.lineaformatoIntlEncabezado(7,valor,25);
							break;
						case "PRODUCTO": 
							producto  = this.lineaformatoIntlEncabezado(32,valor,3);
							break;
						case "PAIS": 
							pais  = this.lineaformatoIntlEncabezado(35,valor,2);
							break;
						case "ID_BURO": 
							buroID  = this.lineaformatoIntlEncabezado(37,valor,4);
							break;
						case "CLAVE_USUARIO": 
							claveUsuario  = this.lineaformatoIntlEncabezado(41,conn.getBCu(),10);
							break;
						case "PASS_USUARIO": 
							passUsuario  = this.lineaformatoIntlEncabezado(51,conn.getBCp(),8);
							break;
						case "TIPO_CONSULTA": 
							tipoConsulta  = this.lineaformatoIntlEncabezado(59,valor,1);
							break;
						case "TIPO_CONTRATO": 
							tipoContrato  = this.lineaformatoIntlEncabezado(60,valor,2);
							break;
						case "MONEDA":
                            //moneda = this.lineaformatoIntlEncabezado(62, "  ", 2);
							moneda  = this.lineaformatoIntlEncabezado(62,valor,2);
							break;
						case "IMPORTE_CONTRATO":
                            int temp = int.Parse(valor);
                            if (temp < 0)
                            {
                                importeContrato = this.lineaformatoIntlEncabezado(64, valor, 9);
                            }
                            else
                            {
                                importeContrato = this.lineaformatoIntlEncabezado(64, "         ", 9);
                            }
							break;
						case "IDIOMA": 
							idioma  = this.lineaformatoIntlEncabezado(73,valor,2);
							break;
						case "TIPO_SALIDA": 
							tipoSalida  = this.lineaformatoIntlEncabezado(75,valor,2);
							break;
						case "BLOQUE_RESPUESTA": 
							bloqueRespuesta  = this.lineaformatoIntlEncabezado(77,valor,1);
							break;
						case "ID_IMPRESORA": 
							impresoraID  = this.lineaformatoIntlEncabezado(78,valor,4);
							break;
						case "USO_FUTURO": 
							usoFuturo  = this.lineaformatoIntlEncabezado(82,valor,7);
							break;
					}
				}
			}

			encabezadoINTL=this.charToString(ubicacion);

			//Console.WriteLine("\n SEGMENTO DE EncabezadoINTL PN \n");
			//Console.WriteLine(encabezadoINTL);

            return encabezadoINTL;
        }
		#endregion
		
		#region Segmento de nombre (PN)
		public string SegmentoDeNombre()
		{
			string apellidoPaterno = string.Empty;
			string apellidoMaterno = string.Empty;
			string apellidoAdicional = string.Empty;
			string primerNombre = string.Empty;
			string segundoNombre = string.Empty;
			string fechaNac = string.Empty;
			string NumRFC = string.Empty;
			string prefijo = string.Empty;
			string sufijo = string.Empty;
			string nacionalidad = string.Empty;
			string residencia = string.Empty;
			string licConducir = string.Empty;
			string edoCivil = string.Empty;
			string sexo = string.Empty;
			string cedulaProf = string.Empty;
			string regElectoral = string.Empty;
			string impuestoExt = string.Empty;
			string paisExt = string.Empty;
			string dependientes = string.Empty;
			string edadesDep = string.Empty;
			string fechaRecepcion = string.Empty;
			string fechaDefuncion = string.Empty;

			foreach(DataRow dataRow in dataTableSegmentoPN.Rows)
			{
				foreach(DataColumn dataColumn in dataTableSegmentoPN.Columns)
				{
					string val = dataRow[dataColumn].ToString();
                    //Console.WriteLine("Columna: "+dataColumn.ColumnName.ToUpper()+"\n Valor :"+  val+"\n Longitud: "+val.Length);
					string columna = dataColumn.ColumnName.ToUpper();
					string valor = val.ToUpper();
					int longitud = val.Length;

                    //Console.WriteLine();
					switch(columna)
					{
						case "APE_PATERNO": 
							apellidoPaterno = this.lineaformatoIntl("PN",valor,26);
                            this.verificarRequeridos(valor, columna);
							break;
						case "APE_MATERNO": 
							apellidoMaterno = this.lineaformatoIntl("00",valor,26);
                            this.verificarRequeridos(valor, columna);
							break;
						case "APE_ADICIONAL": 
							apellidoAdicional = this.lineaformatoIntl("01",valor,26);
							break;
						case "PRIMER_NOMBRE": 
							primerNombre = this.lineaformatoIntl("02", valor ,26);
                            this.verificarRequeridos(valor, columna);
							break;
						case "SEGUNDO_NOMBRE":
                            segundoNombre = this.lineaformatoIntl("03", valor, 26);
							break;
						case "FECHA_NACIMIENTO": 
							//fechaNac = this.lineaformatoIntl("04", this.cambiaFechaAFormatoBuro(valor) ,8);
                            //El formateo a la fecha de nacimiento ya se hizo desde ABAP -AHM.
                            fechaNac = this.lineaformatoIntl("04", valor, 8);
							break;
						case "RFC":
                            if (valor.Length >= 10)
                            {
                                if (this.validarRFC(valor))
                                {
                                    //valor = this.rellenarConBlancos(valor, 13);
                                    NumRFC = this.lineaformatoIntl("05", valor, 13);
                                }
                            }
							break;
						case "PREFIJO": 
							prefijo  = this.lineaformatoIntl("06",valor,4);
							break;
						case "SUFIJO": 
							sufijo  = this.lineaformatoIntl("07",valor,4);
							break;
						case "NACIONALIDAD": 
							nacionalidad  = this.lineaformatoIntl("08",valor,2);
							break;
						case "RESIDENCIA":
                            if (residencia != "")
                            {
                                residencia = this.lineaformatoIntl("09", valor, 1);
                            }
                            break;
						case "LIC_CONDUCIR": 
							licConducir  = this.lineaformatoIntl("10",valor,20);
							break;
						case "EDO_CIVIL":
                            //El formateo de Edo Civil para el Buró ya se hace desde SAP -AHM.
                            /*
                            switch (valor)
                            {
                                case "0":
                                    valor = "S";//Soltero
                                    break;
                                case "1":
                                    valor = "M";//Casado
                                    break;
                                case "2":
                                    valor = "M";//casado
                                    break;
                                case "3":
                                    valor = "F";//union libre
                                    break;
                                case "4":
                                    valor = "D";//Divorsiado/separado
                                    break;
                                case "5":
                                    valor = "W";//Viudo
                                    break;
                            }
                            */
							edoCivil  = this.lineaformatoIntl("11",valor,1);
							break;
						case "SEXO": 
							sexo  = this.lineaformatoIntl("12",valor,20);
							break;
						case "CEDULA_PROF": 
							cedulaProf  = this.lineaformatoIntl("13",valor,20);
							break;
						case "REG_ELECTORAL": 
							regElectoral  = this.lineaformatoIntl("14",valor,20);
							break;
						case "IMPUESTOS_EXT": 
							impuestoExt  = this.lineaformatoIntl("15",valor,20);
							break;
						case "PAIS_EXT": 
							paisExt  = this.lineaformatoIntl("16",valor,2);
							break;
						case "DEPENDIENTES":
							//dependientes  = this.lineaformatoIntl("17",valor,2);
							break;
						case "EDADES_DEP": 
							//edadesDep  = this.lineaformatoIntl("18",valor,30);
							break;
						/*case "FECHA_RECEPCION": 
							fechaRecepcion  = this.lineaformatoIntl("19",this.cambiaFechaAFormatoBuro(valor),4);
							break;
						case "FECHA_DEFUNCION": 
							fechaDefuncion  = this.lineaformatoIntl("20",this.cambiaFechaAFormatoBuro(valor),4);
							break;*/
					}
				}
			}
			segmentoDeNombrePN+=  apellidoPaterno ;
			segmentoDeNombrePN+=  apellidoMaterno ;
			segmentoDeNombrePN+=  apellidoAdicional ;
			segmentoDeNombrePN+=  primerNombre ;
			segmentoDeNombrePN+=  segundoNombre ;
			segmentoDeNombrePN+=  fechaNac ;
			segmentoDeNombrePN+=  NumRFC ;
			segmentoDeNombrePN+=  prefijo ;
			segmentoDeNombrePN+=  sufijo ;
			segmentoDeNombrePN+=  nacionalidad ;
			segmentoDeNombrePN+=  residencia ;
			segmentoDeNombrePN+=  licConducir ;
			segmentoDeNombrePN+=  edoCivil ;
			segmentoDeNombrePN+=  sexo ;
			segmentoDeNombrePN+=  cedulaProf ;
			segmentoDeNombrePN+=  regElectoral ;
			segmentoDeNombrePN+=  impuestoExt ;
			segmentoDeNombrePN+=  paisExt ;
			segmentoDeNombrePN+=  dependientes ;
			segmentoDeNombrePN+=  edadesDep ;
			segmentoDeNombrePN+=  fechaRecepcion ;
			segmentoDeNombrePN+=  fechaDefuncion ;
			//Console.WriteLine("\n SEGMENTO DE NOMBRE PN \n");
			//Console.WriteLine(segmentoDeNombrePN);
			return segmentoDeNombrePN;
		}

		#endregion

		#region Segmento de direccion (PA)

		public string SegmentoDeDireccion()
		{
		string direccion1 = string.Empty;
		string direccion2 = string.Empty;
		string colonia = string.Empty;
		string municipio = string.Empty;
		string ciudad = string.Empty;
		string estado = string.Empty;
		string codigoPostal = string.Empty;
		string fechaResidencia = string.Empty;
		string telefono = string.Empty;
		string extTelefono = string.Empty;
		string fax = string.Empty;
		string tipoDomicilio = string.Empty;
		string indEspDom = string.Empty;
			foreach(DataRow dataRow in dataTableSegmentoPA.Rows)
			{
				foreach(DataColumn dataColumn in dataTableSegmentoPA.Columns)
				{
					string val = dataRow[dataColumn].ToString();
                    //Console.WriteLine("Columna: "+dataColumn.ColumnName.ToUpper()+"\n Valor :"+  val+"\n Longitud: "+val.Length);
					string columna = dataColumn.ColumnName.ToUpper();
					string valor = val.ToUpper();
					int longitud = val.Length;

                    //Console.WriteLine();
					switch(columna)
					{
						case "DIRECCION1": 
							direccion1  = this.lineaformatoIntl("PA",valor,40);
                            this.verificarRequeridos(valor, columna);
							break;
						case "DIRECCION2": 
							direccion2  = this.lineaformatoIntl("00",valor,40);
							break;
						case "COLONIA": 
							colonia  = this.lineaformatoIntl("01",valor,40);
							break;
						case "MUNICIPIO": 
							municipio    = this.lineaformatoIntl("02",valor,40);
							break;
						case "CIUDAD": 
							ciudad   = this.lineaformatoIntl("03",valor,40);
							break;
						case "ESTADO":
                            /*
                            switch (valor)
                            {
                                case "BC":
                                    valor = "BCN";
                                    break;
                                case "CMP":
                                    valor = "CAM";
                                    break;
                                case "MEX":
                                    valor = "EM";
                                    break;
                                case "MCH":
                                    valor = "MICH";
                                    break;
                                case "TMS":
                                    valor = "TAM";
                                    break;
                                case "TLX":
                                    valor = "TLA";
                                    break;
                            }
                            */
							estado  = this.lineaformatoIntl("04",valor,4);
                            this.verificarRequeridos(valor, columna);
							break;
						case "CP": 
							codigoPostal  = this.lineaformatoIntl("05",valor,5);
                            this.verificarRequeridos(valor, columna);
							break;
						case "FECHA_RESIDENCIA": 
							fechaResidencia  = this.lineaformatoIntl("06",this.cambiaFechaAFormatoBuro(valor),8);
							break;
						case "TELEFONO": 
							fechaResidencia  = this.lineaformatoIntl("07",valor,11);
							break;
						case "EXTENSION_TEL":
                            if (valor != "00000000")
                            {
                                extTelefono = this.lineaformatoIntl("08", valor, 08);
                            }
							break;
						case "FAX":
                            if (valor != "00000000000")
                            {
                                fax = this.lineaformatoIntl("09", valor, 11);
                            }
							break;
						case "TIPO_DOMICILIO": 
							tipoDomicilio  = this.lineaformatoIntl("10",valor,1);
							break;
						case "ID_ESP_DOM": 
							indEspDom  = this.lineaformatoIntl("11",valor,1);
							break;
					}
				}
			}

			segmentoDeDireccionPA+=  direccion1 ;
			segmentoDeDireccionPA+=  direccion2 ;
			segmentoDeDireccionPA+=  colonia ;
			segmentoDeDireccionPA+=  municipio ;
			segmentoDeDireccionPA+=  ciudad ;
			segmentoDeDireccionPA+=  estado ;
			segmentoDeDireccionPA+=  codigoPostal ;
			segmentoDeDireccionPA+=  fechaResidencia ;
			segmentoDeDireccionPA+=  telefono ;
			segmentoDeDireccionPA+=  extTelefono ;
			segmentoDeDireccionPA+=  fax ;
			segmentoDeDireccionPA+=  tipoDomicilio ;
			segmentoDeDireccionPA+=  indEspDom ;

			//Console.WriteLine("\n SEGMENTO DE DIRECCION PN \n");
			//Console.WriteLine(segmentoDeDireccionPA);

			return segmentoDeDireccionPA;
		}
		#endregion

		#region Segmento de FIN (ES)
		public string SegmentoDeCierre(string total)
		{
            if (total != "")
            {
                string etiquetaDeSegmentoDeCierre = "ES05";// Es preferente crear una tabla por si lo requerimientos de la etiqueta
                int lengthBytes = System.Text.Encoding.UTF8.GetByteCount(total);
                lengthBytes = lengthBytes + 15;
                segmentodeFinES = etiquetaDeSegmentoDeCierre + lengthBytes.ToString("00000") + "0002**";
                total = total + segmentodeFinES;
                return total;
            }
            else 
            {
                return "";
            }
		}
		#endregion

		#region Tools
		private string lineaformatoIntl(string etiqueta,string valor,int longitudMaxima)
		{
            if (valor != "")
            {
                string lineaFormateada = string.Empty;
                lineaFormateada = etiqueta;
                lineaFormateada += valor.Length.ToString("00");
                if (valor.Length > longitudMaxima)
                {
                    valor = valor.Substring(0, longitudMaxima);
                }
                lineaFormateada += valor;
                return lineaFormateada;
            }
            else
            {
                return "";
            }
			
		}

		private string lineaformatoIntlEncabezado(int posicion,string valor,int longitudMaxima)
		{
			posicion=posicion-1;
			if(valor.Length!=0)
			{
				for(int i = 0 ; i<longitudMaxima;i++)
				{
					ubicacion[posicion+i]=valor[i];
				}
			}
			string lineaFormateada= string.Empty;
			if(valor.Length>longitudMaxima)
			{
				valor = valor.Substring(0,longitudMaxima);
			}
			lineaFormateada += valor;
			return lineaFormateada;
		}

		private string cambiaFechaAFormatoBuro(string fechaAbap)
		{
			//ABAP..............:aaaammdd
			//Buro de credito...:ddmmaaaa

			string day,month,year,fechaBC;
			year = fechaAbap.Substring(0,4);
			month = fechaAbap.Substring(4,2);
			day = fechaAbap.Substring(6,2);
			fechaBC = day+month+year;
			return fechaBC;
		}
		
		private string rellenarConBlancos(string valor,int longitudMaxima)
		{
			if(valor.Length<longitudMaxima)
			{
				while(valor.Length<longitudMaxima)
				{
					valor+=" ";
				}
			}
			return valor;
		}
		private string charToString(char[] cadena)
		{
			string valor="";
				for(int i = 0 ; i<cadena.Length;i++)
				{
					valor = valor + cadena[i].ToString();
				}
			valor = valor.Replace("\0"," ");
			return valor;
		}
        private bool validarRFC(string rfc)
        {
            //El Registro Federal de Causantes (RFC)  JRH 9210065M1 
            // Si quieres que acepte mayuscula y minuscula [a-zA-Z]
            bool valido = false;
            if (Regex.IsMatch(rfc, @"^[a-zA-Z]{3,4}(\d{6})((\D|\d){3})?$"))
            {
                valido = true;
            }
            return valido;
        }

		#endregion

		public string ConsultaFinalAlRFC(string idConsulta,string partner)
		{
			SapConnectorClientToBC proxy = conn.establecerConeccionSap();

			Z00_BURO_INTLTable resultadoIntl = new Z00_BURO_INTLTable();
			Z00_BURO_PNTable resultadoPN = new Z00_BURO_PNTable();
			Z00_BURO_PATable resultadoPA = new Z00_BURO_PATable();
			try
			{
				proxy.Connection.Open();
				proxy.Zrfc_Buro_Bp(idConsulta,partner,ref resultadoIntl,ref resultadoPA,ref resultadoPN);
				proxy.Connection.Close();
			}
			catch(SAP.Connector.RfcLogonException a)
			{
				Console.WriteLine("*Existe un error el Usuario o contrasena, el sistema no se ha podido conectar a SAP.");
                Console.WriteLine("Excepcion en .NET:  \n " + a);
                System.Environment.Exit(0);
			}
			catch(SAP.Connector.RfcCommunicationException a)
			{
				Console.WriteLine("*No se encontrado el Servidor o el usuario se tardo demacionado en aceptar que la conexion era segura.\n");
                Console.WriteLine("Excepcion en .NET:  \n " + a);
                System.Environment.Exit(0);
			}
			catch(SAP.Connector.RfcException a)
			{
                Console.WriteLine("*No se encontro el RFC.\n");
                Console.WriteLine("Excepcion en .NET:  \n " + a);
                System.Environment.Exit(0);
			}
            catch (Exception a)
            {
                Console.WriteLine("*Excepcion desconocida.\n");
                Console.WriteLine("Excepcion en .NET:  \n " + a);
                System.Environment.Exit(0);
            }

			dataTableEncabezadoIntl= resultadoIntl.ToADODataTable();
		    dataTableSegmentoPN = resultadoPN.ToADODataTable();
			dataTableSegmentoPA = resultadoPA.ToADODataTable();

			string Consulta;
			Consulta = EncabezadoINTL();
			Consulta += SegmentoDeNombre();
			Consulta += SegmentoDeDireccion();
			Consulta = SegmentoDeCierre(Consulta);
            if (Consulta != "")
            {
                #region Remplazar acentos y caracteres varios
                Consulta = Consulta.Replace("ñ", "n");
                Consulta = Consulta.Replace("Ñ", "N");
                Consulta = Consulta.Replace("á", "a");
                Consulta = Consulta.Replace("à", "a");
                Consulta = Consulta.Replace("ä", "a");
                Consulta = Consulta.Replace("é", "e");
                Consulta = Consulta.Replace("è", "e");
                Consulta = Consulta.Replace("ë", "e");
                Consulta = Consulta.Replace("í", "i");
                Consulta = Consulta.Replace("ì", "i");
                Consulta = Consulta.Replace("ï", "i");
                Consulta = Consulta.Replace("ó", "o");
                Consulta = Consulta.Replace("ò", "o");
                Consulta = Consulta.Replace("ö", "o");
                Consulta = Consulta.Replace("ú", "u");
                Consulta = Consulta.Replace("ù", "u");
                Consulta = Consulta.Replace("u", "u");
                Consulta = Consulta.Replace("Á", "A");
                Consulta = Consulta.Replace("À", "A");
                Consulta = Consulta.Replace("Ä", "A");
                Consulta = Consulta.Replace("É", "E");
                Consulta = Consulta.Replace("È", "E");
                Consulta = Consulta.Replace("Ë", "E");
                Consulta = Consulta.Replace("Í", "I");
                Consulta = Consulta.Replace("Ì", "I");
                Consulta = Consulta.Replace("Ï", "I");
                Consulta = Consulta.Replace("Ó", "O");
                Consulta = Consulta.Replace("Ò", "O");
                Consulta = Consulta.Replace("Ö", "O");
                Consulta = Consulta.Replace("Ú", "U");
                Consulta = Consulta.Replace("Ù", "U");
                Consulta = Consulta.Replace("Ü", "U");
                Consulta = Consulta.Replace("ç", "c");
                Consulta = Consulta.Replace("Ç", "C");
                Consulta = Consulta.Replace("|", " ");
                #endregion
            }
            if (existenRequeritos == false)
            {
                this.verificarRequeridos();
            }
            return Consulta;
		}

        private void verificarRequeridos(string valor,string columna)
        {
            if (valor.Trim() == "")
            {
                requeridos.Add(columna);
                existenRequeritos = false;
            }
        }

        private void verificarRequeridos()
        {
            Console.WriteLine("*Existen Campos requeridos para realizar la consulta.");
            Console.WriteLine("Favor de llenarlos para poder realizarla.");
            Console.WriteLine("A continuacion los campos que estan pendientes.\n");
            
            for (int i = 0; i < requeridos.Count;i++ )
            {
                Console.WriteLine("* " + requeridos[i]);
            }
            RespuestaFormatoINTL asd = new RespuestaFormatoINTL(conn);
            asd.RespuestaFinalAlRFC("6", conn.getConsul(), conn.getPartner());
            System.Environment.Exit(0); 
        }
    }
}
