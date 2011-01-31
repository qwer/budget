using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

using Budget.Model;

namespace Budget.App.Presenter
{
	class IncomePresenter : ObservableObject, IIncomePresenter
	{
		Db db;

		public IncomePresenter(Db db)
		{
			this.db = db;
		}

		private Income income;
		public Income Income
		{
			get { return income; }
			set 
			{
				if (income != null)
					income.PropertyChanged -= Income_PropertyChanged;
				income = value;
				if (income != null)
					income.PropertyChanged += Income_PropertyChanged;
				OnPropertyChanged("Income");
			}
		}

		private void Income_PropertyChanged(object sender, PropertyChangedEventArgs e)
		{
			saveCommand.StateChanged();
			undoCommand.StateChanged();
		}

		private SimpleCommand saveCommand;
		public ICommand SaveCommand 
		{
			get 
			{
				return saveCommand ?? (saveCommand = 
					new SimpleCommand(Save, CanSave));
			}
		}

		private void Save()
		{
			db.AddIncome(Income);
		}

		private bool CanSave()
		{
			return Income.Account != null &&
				Income.Name.Length > 0;
		}

		private SimpleCommand undoCommand;
		public ICommand UndoCommand
		{
			get
			{
				return undoCommand ?? (undoCommand =
					new SimpleCommand(Save, CanSave));
			}
		}

		public IEnumerable<Account> Accounts
		{
			get
			{
				return new List<Account>(db.Container.AccountSet.Where(
					delegate (Account a) { return Account.GetAccountType(a.Type) == AccountType.Regular; } ));
			}
		}
	}
}
