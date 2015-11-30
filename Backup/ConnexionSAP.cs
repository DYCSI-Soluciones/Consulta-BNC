using System;

namespace ZConsultaBuro
{
	/// <summary>
	/// Summary description for ConnexionSAP.
	/// </summary>
	public class ConnexionSAP
	{
		public ConnexionSAP()
		{
		}
			
		private SAP.Connector.SAPConnection sapConnection;
		private SapConnectorClientToBC proxy;
		private string User= string.Empty;
		private string Password= string.Empty;
		private string AppServerHost= string.Empty;
		private short Client;
		private short SystemNumber;

		#region getters
		public string getPassword()
		{
			return this.Password;
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

		public short getSystemNumber()
		{
			return this.SystemNumber;
		}
		#endregion


		public ConnexionSAP(string user , string password , string appServerHost,short client , short systemNumber)
		{
		this.User= user;
		this.Password= password;
		this.AppServerHost= appServerHost;
		this.Client= client;
		this.SystemNumber = systemNumber;
			
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
