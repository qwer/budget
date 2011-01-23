using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Budget.Model;

namespace Budget.App
{
	public partial class AccountForm : Form
	{
		IAccountView view;

		public AccountForm(IAccountView view)
		{
			if (view == null)
				throw new ArgumentNullException();

			InitializeComponent();

			this.view = view;
			iAccountViewBindingSource.DataSource = view;
			button1.Click += new EventHandler(button1_Click);
		}

		protected override void OnShown(EventArgs e)
		{
			accountControl1.Account = view.Account;
			base.OnShown(e);
		}

		private void saveButton_Click(object sender, EventArgs e)
		{
			view.SaveCommand.Execute();
			Close();
		}

		void button1_Click(object sender, EventArgs e)
		{
			view.Undo();
			Close();
		}
	}
}
