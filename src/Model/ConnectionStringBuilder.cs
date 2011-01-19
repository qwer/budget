using System;
using System.Collections.Generic;
using System.Data.EntityClient;
using System.Data.SqlServerCe;

namespace Budget.Model
{
	public class ConnectionStringBuilder
	{
		public ConnectionStringBuilder()
		{
		}

		public string Db { get; set; }
		public string DbPath { get; set; }

		public override string ToString()
		{
			string providerName = "System.Data.SqlServerCe.4.0";
			string providerString = "Data Source=" + DbPath;
			
			EntityConnectionStringBuilder entityBuilder =
			    new EntityConnectionStringBuilder();

			entityBuilder.Provider = providerName;
			entityBuilder.ProviderConnectionString = providerString;

			entityBuilder.Metadata = String.Format(
				@"res://*/{0}.csdl|" + 
				@"res://*/{0}.ssdl|" + 
				@"res://*/{0}.msl", Db);

			return entityBuilder.ToString();
		}
	}
}
