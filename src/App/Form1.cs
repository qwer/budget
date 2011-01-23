using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data;
using System.Data.Objects;
using System.Threading.Tasks;

using Budget.Model;

namespace Budget.App
{
	public partial class Form1 : Form
	{
		Db db;

		public Form1()
		{
			InitializeComponent();
			db = new Db();
			db.ConnectionStateChanged += this.ConnectionStateChanged;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			Task task = new Task(Connect);
			task.Start();
		}

		private void ConnectionStateChanged(object sender, PropertyChangedEventArgs e)
		{
			if (InvokeRequired)
			{
				Invoke(new PropertyChangedEventHandler(ConnectionStateChanged), sender, e);
				return;
			}

			toolStripStatusLabel1.Text = db.ConnectionState.ToString();
			if (db.ConnectionState == ConnectionState.Open) 
				Connected();
		}

		private void Connect()
		{
			try
			{
				db.Connect();
			}
			catch (Exception ex)
			{
				Error.Show(ex);
			}

			Invoke(new Action(Connected));
		}

		private void Connected()
		{
			if (db.ConnectionState != ConnectionState.Open)
				return;

			accountBindingSource.DataSource = db.Container.AccountSet;

			LoadAccounts();
		}

		Dictionary<Account, ListViewItem> accountToItems = new Dictionary<Account,ListViewItem>();

		private void LoadAccounts()
		{
			listView1.Items.Clear();
			accountToItems.Clear();

			foreach (Account a in db.Container.AccountSet)
			{
				int groupIndex;
				switch (a.Type)
				{
					case 0: groupIndex = 1; break;
					case 1: groupIndex = 2; break;
					case 2: groupIndex = 0; break;
					default: groupIndex = 1; break;
				}
				
				ListViewItem i = new ListViewItem(a.Name, listView1.Groups[groupIndex]);
				i.SubItems.AddRange(new string[] { 
						a.Balance.ToString(), 
						a.Type == 2 ? a.Target.ToString() : "" 
				});
				i.Tag = a;

				listView1.Items.Add(i);
				accountToItems[a] = i;

				a.PropertyChanged += Account_PropertyChanged;
			}
		}

		void Account_PropertyChanged(object sender, PropertyChangedEventArgs e)
		{
			Account a = (Account) sender;
			ListViewItem i = accountToItems[a];

			i.SubItems[0].Text = a.Name;
			i.SubItems[1].Text = a.Balance.ToString();
			i.SubItems[2].Text = a.Type == 2 ? a.Target.ToString() : "";
		}

		private void listView1_DoubleClick(object sender, EventArgs e)
		{
			if (listView1.SelectedItems.Count != 1)
				return;

			ShowAccount((Account) listView1.SelectedItems[0].Tag);
		}

		AccountForm accountForm;
		AccountView accountView;

		private void ShowAccount(Account account)
		{
			if (accountView == null)
				accountView = new AccountView(db);
			if (accountForm == null)
				accountForm = new AccountForm(accountView);

			//MessageBox.Show(account.Name);
			accountView.Account = account;
			accountForm.ShowDialog();
		}
	}
}
