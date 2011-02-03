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

	public partial class Income
	{
		private Period period2 = null;
		public Period Period2
		{
			get
			{
				if (period2 == null)
				{
					try
					{
						period2 = new Period(this.Period);
					}
					catch
					{
						period2 = new Period();
					}
					period2.Changed += period2_Changed;
				}
				return period2;
			}
		}

		private void period2_Changed(object sender, EventArgs e)
		{
			Period = Period2.ToString();
		}
	}
}
