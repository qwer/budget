using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Data;
using Budget.Model;

namespace Budget.App
{
	public class Db
	{
		public Db()
		{
		}

		public event PropertyChangedEventHandler ConnectionStateChanged;
		
		private ConnectionState connectionState = ConnectionState.Closed;
		public ConnectionState ConnectionState
		{
			get { return connectionState; }
			set
			{
				if (connectionState == value)
					return;
				connectionState = value;
				if (ConnectionStateChanged != null)
					ConnectionStateChanged(this, null);
			}
		}

		public BudgetModelContainer Container { get; set; }

		public void Connect()
		{
			try
			{
				ConnectionState = ConnectionState.Connecting;

				ConnectionStringBuilder csb = new ConnectionStringBuilder();
				csb.DbPath = Properties.Settings.Default.DbPath;
				csb.Db = "BudgetModel";

				Container = new BudgetModelContainer(csb.ToString());
				ConnectionState = ConnectionState.Open;
				Container.Connection.StateChange += Connection_StateChange;
			}
			catch (Exception ex)
			{
				ConnectionState = ConnectionState.Closed;
				throw ex;
			}
		}

		void Connection_StateChange(object sender, StateChangeEventArgs e)
		{
			//ConnectionState = e.CurrentState;
		}
	}

}
