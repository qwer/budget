using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Budget.Model;

namespace Budget.App
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
				accountBindingSource.DataSource = account;
			}
		}
	}
}
