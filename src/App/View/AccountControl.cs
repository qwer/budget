using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Budget.Model;
using Budget.App.Presenter;

namespace Budget.App.View
{
	public partial class AccountControl : UserControl
	{
		public AccountControl()
		{
			InitializeComponent();
		}

		private Account account;
		public Account Account
		{
			get { return account; }
			set
			{
				account = value;
				if (account != null)
					accountBindingSource.DataSource = account;
			}
		}
	}
}
