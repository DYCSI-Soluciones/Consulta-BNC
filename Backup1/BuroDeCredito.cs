using System;
using System.Data;
using System.Text;
using System.Collections;


namespace ZConsultaBuro
{

	class BuroDeCredito
	{
		static void Main(string[] args)
		{
			#region TOMAR LOS ARGUMENTOS ENVIADOS DESDE ABAP

			string idConsulta=string.Empty;
			string partner=string.Empty;
			string user=string.Empty;
			string pass=string.Empty;
			string server=string.Empty;
			short sapID= -1;
			short client= -1;
			int portBC = -1;
			string userBC=string.Empty;
            string passBC = string.Empty;
			string serverBC=string.Empty;
            bool requeridosPendientes = false;
			bool flag= false;//ESTA FLAG ES PARA OBJETO DE PRUEBAS DESDE C#
				for (int i = 0; i < args.Length; i++)
				{
					flag=true;//ESTA FLAG ES PARA OBJETO DE PRUEBAS DESDE C#

					if(i%2 == 0)
					{
						switch(args[i])
						{
							case "ID_CONSULTA": 
								idConsulta = args[i+1];
                                if (idConsulta == "" || idConsulta == null || idConsulta == "X")
                                {
                                    Console.WriteLine("No incluye el 'Id de la consulta' este es necesario para realizar la conexion a SAP.");
                                    requeridosPendientes = true; 
                                }
								break;
							case "PARTNER": 
								partner = args[i+1];
                                if (partner == "" || partner == null || partner == "X")
                                {
                                    Console.WriteLine("No incluye el 'Id del BP' este es necesario para realizar la conexion a SAP.");
                                    requeridosPendientes = true;
                                }
								break;
							case "SAP_USERNAME": 
								user = args[i+1];
                                if (user == "" || user == null || user == "X")
                                {
                                    Console.WriteLine("No incluye el 'Id del Usuario SAP' este es necesario para realizar la conexion a SAP.");
                                    requeridosPendientes = true;
                                }
								break;
							case "SAP_PASS": 
								pass = args[i+1];
                                if (pass == "" || pass == null || pass == "X")
                                {
                                    Console.WriteLine("No incluye la 'contrasena del usuario SAP' este es necesario para realizar la conexion a SAP.");
                                    requeridosPendientes = true;
                                }
								break;
							case "SAP_SERVER": 
								server = args[i+1];
                                if (server == "" || server == null || server == "X")
                                {
                                    Console.WriteLine("No incluye la 'direccion del Servidor de SAP' este es necesario para realizar la conexion de SAP.");
                                    requeridosPendientes = true;
                                }
								break;
							case "SAP_ID": 
								sapID = short.Parse(args[i+1]);
                                if (sapID.ToString() == "" || sapID == -1 || sapID.ToString() == "X")
                                {
                                    Console.WriteLine("No incluye el 'Id del tipo de SAP' este es necesario para realizar la conexion.");
                                    requeridosPendientes = true;
                                }
								break;
							case "SAP_CLIENT": 
								client = short.Parse(args[i+1]);
                                if (client.ToString() == "" || client == -1 || client.ToString() == "X")
                                {
                                    Console.WriteLine("No incluye el Id del Mandante este es necesario para realizar la conexion a SAP.");
                                    requeridosPendientes = true;
                                }
								break;
							case "BURO_SERVER": 
								serverBC = args[i+1];
                                if (serverBC == "" || serverBC == null || serverBC == "X")
                                {
                                    Console.WriteLine("No incluye la direccion del Servodor del Buro este es necesario para realizar la conexion al Buro de Credito.");
                                    requeridosPendientes = true;
                                }
								break;
							case "BURO_PORT":
                                try
                                {
                                    portBC = int.Parse(args[i + 1]);
                                    if (portBC.ToString() == "" || portBC == -1 || portBC.ToString() == "X")
                                    {
                                        Console.WriteLine("No incluye el puerto del servidor del Buro de Credito este es necesario para realizar la conexion al Buro de Credito.");
                                        requeridosPendientes = true;
                                    }
                                }
                                catch (FormatException e)
                                {
                                    Console.WriteLine("*Existe un error en el formato de Puerto del Servidor de Buro de Credito.\n");
                                    requeridosPendientes = true;
                                    Console.WriteLine("Excepcion .NET: \n" + e);
                                }
								break;
							case "BURO_USER": 
								userBC = args[i+1];
                                if (userBC == "" || userBC == null || userBC == "X")
                                {
                                    Console.WriteLine("No incluye el Id del Usuario de buro este es necesario para realizar la consulta.");
                                    requeridosPendientes = true;
                                }
								break;
                            case "BURO_PASS":
                                passBC = args[i + 1];
                                if (passBC == "" || passBC == null || passBC == "X")
                                {
                                    Console.WriteLine("No incluye la contracena del Usuario de buro este es necesario para realizar la consulta.");
                                    requeridosPendientes = true;
                                }
                                break;
						}
                        if (requeridosPendientes) 
                            {
                                Console.WriteLine("*El programa no puede continuar si estos datos estan pendientes.\nPor favor completar los campos.");
                                System.Environment.Exit(0);
                            }
					}
				}
			#endregion
			#region REGION de OBJETO PRUEBAS DESDE C#
			if(flag== false)
			{
				Console.WriteLine("LA CONNEXION SE HARA CON LOS VALORES DE SIEMPRE" );

				idConsulta = "0000000000058";
                //partner   = "0001000050";1000066
                Console.Write("partner :");
                partner = "00010000" + Console.ReadLine(); 
                //partner   = "0001000062";
                //partner = "0000000032";
				
                user = "CTDEV";
				pass ="038dycsi";
                //user = "JROJAS";
                //pass ="naruto";
				server = "200.57.135.2";
				sapID = 0;
                //sapID = 1;
				client =38;
                

                ///serverBC = "128.9.55.102";
                ///portBC = 25000;
                
                serverBC = "200.57.135.2";
                portBC = 22;
                
                userBC = "ZM51551002";
                passBC = "G48vPxxN";
			}
			#endregion
			//ConnexionSAP conn = new ConnexionSAP("CTDEV","038dycsi","200.57.135.2",038,0);
            ConnexionSAP conn = new ConnexionSAP(user, pass, server, client, sapID, idConsulta, partner, userBC,passBC);
			FormatoINTL consul = new FormatoINTL(conn);
            string consulta = string.Empty;

            if (idConsulta != "" && partner != "")
            {
                consulta = consul.ConsultaFinalAlRFC(idConsulta, partner);
                //Console.WriteLine("Realizando consulta...\n");
                if (consulta.ToString() == "")
                {
                    Console.WriteLine("El contenido de consulta esta vacio.\n");
                    System.Environment.Exit(0);
                }
            }
            else
            {
                Console.WriteLine("Existe un error en los datos de IdConsulta y Partner.\n");
                System.Environment.Exit(0);
            }
            
            ConnectTCPClient tcpConn = new ConnectTCPClient(serverBC, portBC);
            //ConnectTCPClient tcpConn = new ConnectTCPClient("192.168.10.117", 22); 
            tcpConn.setConn(conn);
  
            //Console.WriteLine("Consulta: " + consulta);
            string mensajeDeRespuesta = tcpConn.sendTCP(consulta);
            //string mensajeDeRespuesta = tcpConn.stringMessageReceive(500);

            Z00_BURO_STR RespuestaLog = new Z00_BURO_STR();
            Z00_BURO_STRTable RespuestaLogTable = new Z00_BURO_STRTable();

			RespuestaFormatoINTL respuesta = new RespuestaFormatoINTL(conn);
            #region limpieza de caracteres
            //Console.WriteLine("Respuesta: " + mensajeDeRespuesta);
            //Console.ReadLine();
            //mensajeDeRespuesta = mensajeDeRespuesta.Replace("Welcome!\n", "");
            mensajeDeRespuesta = mensajeDeRespuesta.Replace("\0", "  ");
            mensajeDeRespuesta = mensajeDeRespuesta.Replace( "‼", " ");
            mensajeDeRespuesta = mensajeDeRespuesta.TrimEnd();
            mensajeDeRespuesta = mensajeDeRespuesta.TrimStart();

            //mensajeDeRespuesta
            //sValue = Conversion.Hex(sValue) 
            string aaaaa;
            aaaaa = respuesta.ConvertToHex(mensajeDeRespuesta[mensajeDeRespuesta.Length - 1].ToString());
            if (aaaaa == "3f")
            {
                mensajeDeRespuesta = mensajeDeRespuesta.Substring(0, mensajeDeRespuesta.Length - 1);
            }
            if (aaaaa == "13")
            {
                mensajeDeRespuesta = mensajeDeRespuesta.Substring(0, mensajeDeRespuesta.Length - 1);
            }
            if(mensajeDeRespuesta[mensajeDeRespuesta.Length-1].ToString()== "?")
            {
                mensajeDeRespuesta = mensajeDeRespuesta.Substring(0, mensajeDeRespuesta.Length - 1);
            }
            if (mensajeDeRespuesta[mensajeDeRespuesta.Length - 1].ToString() == "‼")
            {
                mensajeDeRespuesta = mensajeDeRespuesta.Substring(0, mensajeDeRespuesta.Length - 1);
            }
            #endregion

            #region Log en SAP
            string segmentoLog = "";
                ArrayList LogSegmentosList = new ArrayList();

                for (int i = 0; i < mensajeDeRespuesta.Length; i++ )
                {
                    segmentoLog = segmentoLog + mensajeDeRespuesta[i];
                    if (segmentoLog.Length == 254)
                    {
                        LogSegmentosList.Add(segmentoLog);
                        segmentoLog = "";
                    }
                }
                if (segmentoLog.Length > 0)
                {
                    LogSegmentosList.Add(segmentoLog);
                }

                foreach (string LineaLog in LogSegmentosList)
                {
                    RespuestaLog = new Z00_BURO_STR();
                    RespuestaLog.Texto = LineaLog;
                    RespuestaLogTable.Add(RespuestaLog);
                }
                respuesta.setLog(RespuestaLogTable);
            #endregion

                respuesta.recibirRespuesta(mensajeDeRespuesta);

            if (respuesta.getErroAR() == false && respuesta.getErroUR() == false)
            {
                respuesta.RespuestaFinalAlRFC("0", idConsulta, partner);
                Console.WriteLine("\n**Consulta realizada con exito**");
            }
            //Console.WriteLine("\n**Ejecucion realizada con exito**");
            else
            {
                if (respuesta.getErroAR() == false)
                {
                    respuesta.RespuestaFinalAlRFC("9", idConsulta, partner);
                    Console.WriteLine("\n**Consulta realizada: Por autentificacion no presenta respuesta**");
                }
                if (respuesta.getErroUR() == false)
                {
                    respuesta.RespuestaFinalAlRFC("10", idConsulta, partner);
                    Console.WriteLine("\n**Consulta realizada: Por condiciones de uso no presenta respuesta**");
                }
            }
            //Console.WriteLine("Respuesta: " + mensajeDeRespuesta);
            Console.ReadLine();
		}
	}
}
