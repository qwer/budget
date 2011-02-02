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
			if (e.PropertyName == "Period")
				OnPropertyChanged("PeriodString");
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
				Income.Name != null &&
				Income.Name.Length > 0;
		}

		private SimpleCommand undoCommand;
		public ICommand UndoCommand
		{
			get
			{
				return undoCommand ?? (undoCommand =
					new SimpleCommand(Undo, CanUndo));
			}
		}

		private void Undo()
		{
			db.Undo(Income);
		}

		private bool CanUndo()
		{
			return db.IsModified(Income);
		}

		public IEnumerable<Account> Accounts
		{
			get
			{
				return new List<Account>(db.Container.AccountSet.Where(
					delegate (Account a) { return Account.GetAccountType(a.Type) == AccountType.Regular; } ));
			}
		}

		public IEnumerable<string> Periods
		{
			get
			{
				return new List<string>(
					new string[] {
						"ежедневно",
						"еженедельно",
						"ежемесячно",
						"ежегодно",
						"период"
					}); 
			}
		}

		public int PeriodTypeIndex
		{
			get 
			{
				return (int) Income.Period2.Type;
			}
			set 
			{
				Income.Period2.Type = (Period.PeriodType) value;
			}
		}

		public string PeriodString
		{
			get
			{
				Period p = Income.Period2;
				switch (p.Type)
				{
					case Period.PeriodType.Annual:
						return String.Format("{0}.{1}", p.Month, p.Day);
					case Period.PeriodType.Monthly:
						return p.Day.ToString();
					case Period.PeriodType.Weekly:
						return p.WeekDay.ToString();
					case Period.PeriodType.Daily:
						return "";
					default:
					case Period.PeriodType.Custom:
						return p.TimeSpan.ToString();
				}
			}
			set
			{
				Period p = Income.Period2;
				value = value.Trim();
				switch (p.Type)
				{
					default:
					case Period.PeriodType.Custom:
						p.TimeSpan = TimeSpan.Parse(value);
						break;
					case Period.PeriodType.Daily:
						if (value.Length != 0)
							throw new Exception();
						break;
					case Period.PeriodType.Weekly:
						p.WeekDay = Int32.Parse(value);
						break;
					case Period.PeriodType.Monthly:
						p.Day = Int32.Parse(value);
						break;
					case Period.PeriodType.Annual:
						p.Month = Int32.Parse(value.Substring(0, value.IndexOf('.')).Trim());
						p.Day = Int32.Parse(value.Substring(value.IndexOf('.') + 1).Trim());
						break;
				}
			}
		}
	}
}
