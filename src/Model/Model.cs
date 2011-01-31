using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Budget.Model
{
	public enum AccountType
	{
		Regular = 0, Reserve = 1, Target = 2
	}

	public partial class Account
	{
		public override string ToString()
		{
			return Name;
		}

		public AccountType AccountType
		{
			get
			{
				return GetAccountType(Type);
			}
			set
			{
				switch (value)
				{
					default:
					case AccountType.Regular: Type = 0; break;
					case AccountType.Reserve: Type = 1; break;
					case AccountType.Target: Type = 2; break;
				}
			}
		}

		public static Model.AccountType GetAccountType(int type)
		{
			switch (type)
			{
				case 0: return AccountType.Regular;
				case 1: return AccountType.Reserve;
				case 2: return AccountType.Target;
				default: return AccountType.Regular;
			}
		}
	}
}
