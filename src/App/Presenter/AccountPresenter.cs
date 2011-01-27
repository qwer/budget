using System;
using System.ComponentModel;
using Budget.Model;

namespace Budget.App.Presenter
{
	class AccountPresenter : IAccountPresenter
	{
		Db db;

		public AccountPresenter(Db db)
		{
			this.db = db;
		}

		private SimpleCommand saveCommand;
		public ICommand SaveCommand
		{
			get
			{
				if (saveCommand == null)
					saveCommand = new SimpleCommand(
						Save, CanSave);
				return saveCommand;
			}
		}

		private SimpleCommand undoCommand;
		public ICommand UndoCommand
		{
			get
			{
				if (undoCommand == null)
					undoCommand = new SimpleCommand(
						Undo, CanUndo);
				return undoCommand;
			}
		}

		private Account account;
		public Account Account
		{
			get { return account; }
			set 
			{
				if (account != null)
					account.PropertyChanged -= AccountPropertyChanged;
				account = value;
				if (account != null)
					account.PropertyChanged += AccountPropertyChanged;
			}
		}

		private void Save()
		{
			try
			{
				db.Container.SaveChanges();
			}
			catch (Exception e)
			{
				Error.Show(e);
			}
		}

		private bool CanSave()
		{
			return account.Name.Length > 0;
		}

		private void Undo()
		{
			db.Undo(Account);
		}

		private bool CanUndo()
		{
			return db.IsModified(Account);
		}

		private void AccountPropertyChanged(object sender, PropertyChangedEventArgs e)
		{
			saveCommand.StateChanged();
			undoCommand.StateChanged();
		}
	}
}
