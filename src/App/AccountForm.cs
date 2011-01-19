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
		Db db;

		public AccountForm(Db db)
		{
			InitializeComponent();
			this.db = db;

			button1.Click += new EventHandler(button1_Click);
		}

		private Account account;
		public Account Account
		{
			get { return account; }
			set
			{
				account = value;
				accountControl1.Account = value;
			}
		}

		private void saveButton_Click(object sender, EventArgs e)
		{
			SaveChanges();
			Close();
		}

		void button1_Click(object sender, EventArgs e)
		{
			UndoChanges();
			Close();
		}

		private void SaveChanges()
		{
			db.Container.SaveChanges();
		}

		private void UndoChanges()
		{
			var entry = db.Container.ObjectStateManager.GetObjectStateEntry(Account.EntityKey);

			for (int i = 0; i < entry.OriginalValues.FieldCount; i++)
			{
				entry.CurrentValues.SetValue(i, entry.OriginalValues[i]);
			}

			entry.AcceptChanges();
		}

	}
}
