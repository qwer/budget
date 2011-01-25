using System;
using System.Collections.Generic;
using Budget.Model;
 
namespace Budget.App.Presenter
{
	public interface IAccountPresenter
	{
		Account Account { get; }
		ICommand SaveCommand { get; }
		ICommand UndoCommand { get; }
	}
}
