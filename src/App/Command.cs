using System;
using System.ComponentModel;

namespace Budget.App
{
	public interface ICommand : INotifyPropertyChanged
	{
		void Execute();
		bool CanExecute { get; }
	}

	public class SimpleCommand : ICommand
	{
		private Action execute;
		private Func<bool> canExecute;

		public SimpleCommand(Action execute, Func<bool> canExecute)
		{
			if (execute == null)
				throw new ArgumentNullException("execute");

			this.execute = execute;
			this.canExecute = canExecute;
		}

		public void Execute()
		{
			execute();
		}

		public bool CanExecute
		{
			get
			{
				return canExecute != null ? canExecute() : true;
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		public void StateChanged()
		{
			if (PropertyChanged != null)
				PropertyChanged(this, new PropertyChangedEventArgs("CanExecute"));
		}
	}
}
