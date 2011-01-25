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
	public partial class AccountsControl : UserControl, IAccountsView
	{
		public AccountsControl()
		{
			InitializeComponent();
		}

		IAccountsPresenter presenter;
		public IAccountsPresenter Presenter 
		{
			get { return presenter; }
			set
			{
				if (presenter != null)
					presenter.PropertyChanged -= ViewPropertyChanged;
				presenter = value;
				if (presenter != null)
					presenter.PropertyChanged += ViewPropertyChanged;
			}
		}

		private void ViewPropertyChanged(object sender, PropertyChangedEventArgs e)
		{
			if (InvokeRequired)
			{
				Invoke(new PropertyChangedEventHandler(ViewPropertyChanged), sender, e);
				return;
			}

			if (e.PropertyName == "Accounts")
				LoadAccounts();
		}

		Dictionary<Account, ListViewItem> accountToItems = new Dictionary<Account, ListViewItem>();

		private void LoadAccounts()
		{
			listView1.Items.Clear();
			accountToItems.Clear();

			foreach (Account a in Presenter.Accounts)
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

				a.PropertyChanged += Account_PropertyChanged; /* XXX ref */
			}
		}

		void Account_PropertyChanged(object sender, PropertyChangedEventArgs e)
		{
			Account a = (Account)sender;
			ListViewItem i = accountToItems[a];

			i.SubItems[0].Text = a.Name;
			i.SubItems[1].Text = a.Balance.ToString();
			i.SubItems[2].Text = a.Type == 2 ? a.Target.ToString() : "";
		}

		private void listView1_DoubleClick(object sender, EventArgs e)
		{
			if (listView1.SelectedItems.Count != 1)
				return;

			Presenter.ShowAccount((Account)listView1.SelectedItems[0].Tag);
		}
	}
}
