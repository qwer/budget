using System;
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

		IAccountPresenter presenter;
		public IAccountPresenter Presenter
		{
			get { return presenter; }
			set
			{
				if (value == null)
					return;
				presenter = value;
				iAccountPresenterBindingSource.DataSource = presenter;
			}
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
