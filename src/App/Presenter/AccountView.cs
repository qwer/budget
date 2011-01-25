using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Budget.Model;

namespace Budget.App.Presenter
{
	class AccountView : IAccountView
	{
		Db db;

		public AccountView(Db db)
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
			var entry = GetState(Account);

			for (int i = 0; i < entry.OriginalValues.FieldCount; i++)
			{
				entry.CurrentValues.SetValue(i, entry.OriginalValues[i]);
			}

			entry.AcceptChanges();
		}

		private System.Data.Objects.ObjectStateEntry GetState(Account account)
		{
			return db.Container.ObjectStateManager.GetObjectStateEntry(account.EntityKey);
		}

		private bool CanUndo()
		{
			return 0 < Enumerable.Count(GetState(Account).GetModifiedProperties());
		}

		private void AccountPropertyChanged(object sender, PropertyChangedEventArgs e)
		{
			saveCommand.StateChanged();
			undoCommand.StateChanged();
		}
	}
}
