using System;

namespace ZConsultaBuro
{
	/// <summary>
	/// Summary description for ConnexionSAP.
	/// </summary>
	public class ConnexionSAP
	{
	
		private SAP.Connector.SAPConnection sapConnection;
		private SapConnectorClientToBC proxy;
		private string User= string.Empty;
		private string Password= string.Empty;
		private string AppServerHost= string.Empty;
		private short Client;
		private short SystemNumber;
        private string consultaId;
        private string partner;
        private string buroUsuario;
        private string buroPass;

		#region getters
		public string getPassword()
		{
			return this.Password;
		}
        public string getPartner()
        {
            return this.partner;
        }
		public string getUser()
		{
			return this.User;
		}

		public string getAppServerHost()
		{
			return this.AppServerHost;
		}

		public short getClient()
		{
			return this.Client;
		}
        public string getConsul()
        {
            return this.consultaId;
        }

		public short getSystemNumber()
		{
			return this.SystemNumber;
		}
        public string getBCu()
        {
            return this.buroUsuario;
        }
        public string getBCp()
        {
            return this.buroPass;
        }

		#endregion

		public ConnexionSAP(string user , string password , string appServerHost,short client , short systemNumber, string idConsulta , string part,string bcUsuario, string bcContra)
		{
		    this.User= user;
		    this.Password= password;
		    this.AppServerHost= appServerHost;
		    this.Client= client;
		    this.SystemNumber = systemNumber;
            this.consultaId = idConsulta;
            this.partner = part;
            this.buroUsuario = bcUsuario;
            this.buroPass = bcContra;
		}
		public SapConnectorClientToBC establecerConeccionSap()
		{
			SAP.Connector.Destination destinationG = new SAP.Connector.Destination();
			destinationG.Username = this.User; // SAP username
			destinationG.Password = this.Password; // SAP username's password
			destinationG.AppServerHost = this.AppServerHost; // SAP application server's ip number or id
			destinationG.Client = this.Client; // Client number
			destinationG.SystemNumber = this.SystemNumber; // application server system number
			sapConnection = new SAP.Connector.SAPConnection(destinationG);
			proxy = new SapConnectorClientToBC();
			proxy.Connection = sapConnection;
			return proxy;
		}
	}
}
