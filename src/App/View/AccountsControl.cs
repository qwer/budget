using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

using Budget.Model;
using Budget.App.Presenter;
using Budget.App.IoC;

namespace Budget.App.View
{
	public partial class AccountsControl : UserControl, IAccountsView
	{
		public AccountsControl()
		{
			InitializeComponent();
			IoCContainer.Instance.Inject(this);
		}

		protected override void OnVisibleChanged(EventArgs e)
		{
			base.OnVisibleChanged(e);
			if (Presenter != null)
				LoadAccounts();
		}

		IAccountsPresenter presenter;

		[Dependency]
		public IAccountsPresenter Presenter 
		{
			get { return presenter; }
			set
			{
				if (presenter != null)
					presenter.PropertyChanged -= ViewPropertyChanged;
				if (value == null)
					return;
				presenter = value;
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

		Dictionary<Account, ListViewItem> accountsToItems = new Dictionary<Account, ListViewItem>();

		private void LoadAccounts()
		{
			listView1.Items.Clear();
			accountsToItems.Clear();

			foreach (Account a in Presenter.Accounts)
				AddAccount(a);
		}

		private void AddAccount(Account a)
		{
			ListViewItem i = new ListViewItem(a.Name, GetGroup(a));
			i.SubItems.AddRange(new string[] {
					a.Balance.ToString(),
					a.Type == 2 ? a.Target.ToString() : "" 
				});
			i.Tag = a;

			listView1.Items.Add(i);
			accountsToItems[a] = i;

			a.PropertyChanged += Account_PropertyChanged; /* XXX ref */
		}

		private ListViewGroup GetGroup(Account a)
		{
			int groupIndex;
			switch (a.AccountType)
			{
				default:
				case AccountType.Regular: groupIndex = 1; break;
				case AccountType.Reserve: groupIndex = 2; break;
				case AccountType.Target: groupIndex = 0; break;
			}
			return listView1.Groups[groupIndex];
		}

		void Account_PropertyChanged(object sender, PropertyChangedEventArgs e)
		{
			Account a = (Account) sender;
			ListViewItem i = accountsToItems[a];
			ListViewGroup g = GetGroup(a);

			if (i.Group != g)
				i.Group = g;
		
			i.SubItems[0].Text = a.Name;
			i.SubItems[1].Text = a.Balance.ToString();
			i.SubItems[2].Text = a.Type == 2 ? a.Target.ToString() : "";
		}

		private void listView1_DoubleClick(object sender, EventArgs e)
		{
			if (listView1.SelectedItems.Count != 1)
				return;

			Presenter.ShowAccount((Account) listView1.SelectedItems[0].Tag);
		}
	}
}
