using System;
using System.Collections.Generic;
using System.Linq;
using Budget.Model;

namespace Budget.App
{
	class AccountView : IAccountView
	{
		Db db;

		public AccountView(Db db)
		{
			this.db = db;
		}

		private ICommand saveCommand;

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

		private Account account;
		public Account Account
		{
			get { return account; }
			set { account = value; }
		}

		private void Save()
		{
			db.Container.SaveChanges();
		}

		public void Undo()
		{
			var entry = db.Container.ObjectStateManager.GetObjectStateEntry(Account.EntityKey);

			for (int i = 0; i < entry.OriginalValues.FieldCount; i++)
			{
				entry.CurrentValues.SetValue(i, entry.OriginalValues[i]);
			}

			entry.AcceptChanges();
		}

		bool CanSave()
		{
			return false;
		}
	}
}
