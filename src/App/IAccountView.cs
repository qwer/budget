using System;
using System.Collections.Generic;
using Budget.Model;
 
namespace Budget.App
{
	public interface IAccountView
	{
		ICommand SaveCommand { get; }
		Account Account { get; }
		void Undo();
	}
}
