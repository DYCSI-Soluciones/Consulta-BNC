
using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;
using System.Threading;

namespace ZConsultaBuro
{
    public class ConnectTCPClient
    {
        RespuestaFormatoINTL respuesta;
        private string server;
        private Int32 port;

        #region Constructor
        public ConnectTCPClient(string Server,  Int32 Port)
        { 
            this.server = Server;
            this.port = Port;
        }
        #endregion

        ConnexionSAP conn;

        public void setConn(ConnexionSAP conex)
        {
            this.conn = conex;
            respuesta = new RespuestaFormatoINTL(conn);
        }

        #region Send
        public  String sendTCP (string message)
        {
            try
            {
                Byte[] data = System.Text.Encoding.ASCII.GetBytes(message);
                //data = this.agregarByteDeCierre(data);
                TcpClient client = new TcpClient();
                client.Connect(server, port);
                NetworkStream stream = client.GetStream();
                Byte[] cierre = new Byte[1];
                //byte[] lectura = new byte[9999];
                byte[] lectura = new byte[1024];
                cierre[0] = (byte)0x13;
                stream.Write(data, 0, data.Length);
                stream.WriteByte(cierre[0]);

                stream.ReadTimeout = 70000;
                StringBuilder Slectura = new StringBuilder();
                int numberOfBytesRead = 0;
                int i = 0;
                try{
                    do
                    {
                        
                        //numberOfBytesRead = stream.Read(lectura, 0, 100);
                        numberOfBytesRead = stream.Read(lectura, 0, 1023);
                        Slectura.Append(Encoding.ASCII.GetString(lectura, 0, numberOfBytesRead));
                        //Console.WriteLine(Slectura);
                        //Console.WriteLine("***********************");
                        Thread.Sleep(1000);
                        Thread.AllocateNamedDataSlot(Thread.CurrentThread.Name+i);
                        i++;
                    }
                    while (stream.DataAvailable);
                }
                    catch (Exception e )
                {
                    Console.WriteLine("Paso el error" + e); 
                    Console.ReadLine(); 

                }
                stream.Close();
                client.Close();
                //Console.ReadLine();
                String SlecturaFinal = Slectura.ToString();






                return SlecturaFinal;
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("ArgumentOutOfRangeException", e);
                System.Environment.Exit(0);
                return null;
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("Excepcion 3- Error al enviar la consulta \n", e);
                Console.WriteLine("Excepcion .NET: \n" + e);
                respuesta.RespuestaFinalAlRFC("3", conn.getConsul(), conn.getPartner());
                System.Environment.Exit(0);
                return null;
            }
            catch (SocketException e)
            {
                Console.WriteLine("Excepcion 2- No se ha podido conectar  con el servidor del Buro de Credito");
                Console.WriteLine("Posiblemente el Servidor este fuera de servicio o la configuracion");
                Console.WriteLine("del este sistema tenga un error en los parametros (servidor del buro,puerto del buro).\n");
                respuesta.RespuestaFinalAlRFC("2", conn.getConsul(), conn.getPartner());
                Console.WriteLine("Excepcion .NET: \n" + e);
                System.Environment.Exit(0);
                return null;
            }
            catch (ObjectDisposedException e)
            {
                Console.WriteLine("Excepcion 8- Error en el momento de conectarse al Buro de credito.\n");
                respuesta.RespuestaFinalAlRFC("8", conn.getConsul(), conn.getPartner());
                Console.WriteLine("Excepcion .NET: \n" + e);
                System.Environment.Exit(0);
                return null;
            }
            catch (System.IO.IOException e)
            {
                Console.WriteLine("Excepcion 4- El servidor tardo demasiado en enviar la respuesta,\n o se desconecto en este momento por favor intente de nuevo. \n");
                respuesta.RespuestaFinalAlRFC("4", conn.getConsul(), conn.getPartner());
                Console.WriteLine("Excepcion .NET: \n" + e);
                System.Environment.Exit(0);
                return null;
            }

            catch (Exception e)
            {
                Console.WriteLine("Excepcion 5- Un error desconocido a cuando envia el mensaje de consulta. \n");
                Console.WriteLine("Excepcion .NET: \n" + e);
                respuesta.RespuestaFinalAlRFC("5", conn.getConsul(), conn.getPartner());
                System.Environment.Exit(0);
                return null;
            }
        }

        #endregion

        #region Receive

        public void receiveTCP(byte[] buffer, int offset, int size, int timeout)
        {
            TcpClient tcpClient = new TcpClient(server, port);
            Socket socket = tcpClient.Client;
            socket.ReceiveTimeout = 1000 * timeout;
            timeout = 1000 * timeout;
            int startTickCount = Environment.TickCount;
            int received = 0; 
            do
            {
                if (Environment.TickCount > startTickCount + timeout)
                    throw new Exception("Timeout.");
                try
                {
                    received += socket.Receive(buffer, offset + received, size - received, SocketFlags.None);
                }
                catch (SocketException ex)
                {
                    if (ex.SocketErrorCode == SocketError.WouldBlock ||
                        ex.SocketErrorCode == SocketError.IOPending ||
                        ex.SocketErrorCode == SocketError.NoBufferSpaceAvailable)
                    {
                        Thread.Sleep(30);
                    }
                    else
                        throw ex; 
                }
            } while (received == 9 || received < 1);
            // } while (received < size);//(Environment.TickCount < startTickCount + timeout);//(received == 9 || received < 50);
        }
        public string stringMessageReceive (int sizeBuffer) 
        {
            byte[] sizeMessageToReceive = new byte[sizeBuffer];  // length of the text
            try
            { 
                this.receiveTCP(sizeMessageToReceive, 0, sizeMessageToReceive.Length, 20);
                string str = Encoding.UTF8.GetString(sizeMessageToReceive, 0, sizeMessageToReceive.Length);
                return str;

            }
            catch (Exception ex) 
            {
                Console.WriteLine("Excepcion 4- El servidor tardo demasiado en enviar la respuesta,\n o se desconecto en este momento por favor intente de nuevo. \n");
                respuesta.RespuestaFinalAlRFC("4", conn.getConsul(), conn.getPartner());
                Console.WriteLine("Excepcion .NET: \n"+ex);
                System.Environment.Exit(0);
                return null;
            }
        }

        private Byte[] agregarByteDeCierre(Byte[] data2)
        {       
            int i = 0;
            byte cierre = 0x13;
            Byte[] data = new Byte[data2.Length + 1];
            foreach (byte c in data2)
            {
                data[i] = data2[i];
                i++;
            }
            data[data2.Length] = cierre;
            return data;
        }
        #endregion

    }
}
