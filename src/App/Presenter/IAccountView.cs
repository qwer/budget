using System;
using System.Collections.Generic;
using Budget.Model;
 
namespace Budget.App.Presenter
{
	public interface IAccountView
	{
		Account Account { get; }
		ICommand SaveCommand { get; }
		ICommand UndoCommand { get; }
	}
}
