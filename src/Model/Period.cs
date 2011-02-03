using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Budget.Model
{
	public class Period
	{
		public enum PeriodType
		{
			Daily, Weekly, Monthly, Annual, Custom
		}

		public event EventHandler Changed;
		private void OnChanged()
		{
			if (Changed != null)
				Changed(this, null);
		}

		private PeriodType type = PeriodType.Monthly;
		public PeriodType Type
		{
			get { return type; }
			set { type = value; OnChanged(); }
		}

		private int day = 1;
		public int Day
		{
			get { return day; }
			set
			{
				if (Type == PeriodType.Daily || Type == PeriodType.Weekly)
					throw new Exception();

				if (value < 1 || value > 31)
					throw new Exception();

				if (Type == PeriodType.Monthly && value > 28)
					throw new Exception();

				day = value;
				OnChanged();
			}
		}

		private int weekDay = 1;
		public int WeekDay
		{
			get { return weekDay; }
			set
			{
				if (Type != PeriodType.Weekly)
					throw new Exception();

				if (value < 1 || value > 7)
					throw new Exception();

				weekDay = value;
				OnChanged();
			}
		}

		private int month = 1;
		public int Month
		{
			get { return month; }
			set
			{
				if (Type != PeriodType.Annual)
					throw new Exception();

				if (value < 1 || value > 12)
					throw new Exception();

				month = value;
				OnChanged();
			}
		}

		private int hour;
		public int Hour
		{
			get { return hour; }
			set { hour = value; OnChanged(); }
		}
		private int minute;
		public int Minute
		{
			get { return minute; }
			set { minute = value; OnChanged(); }
		}
		private int second;
		public int Second
		{
			get { return second; }
			set { second = value; OnChanged(); }
		}

		private TimeSpan timeSpan = new TimeSpan(0, 1, 0);
		public TimeSpan TimeSpan
		{
			get { return timeSpan; }
			set
			{
				if (Type != PeriodType.Custom)
					throw new Exception();
				timeSpan = value;
				OnChanged();
			}
		}

		public Period()
		{
		}

		public Period(string s)
		{
			if (s.Length < 1)
				throw new Exception();

			if (s[0] == 'c')
			{
				Type = PeriodType.Custom;
				timeSpan = TimeSpan.Parse(s.Substring(1));
			}
			else
			{
				DateTime date = DateTime.Parse(s.Substring(1));

				Hour = date.Hour;
				Minute = date.Minute;
				Second = date.Second;

				switch (s[0])
				{
					case 'd':
						Type = PeriodType.Daily;
						break;
					case 'w':
						Type = PeriodType.Weekly;
						WeekDay = date.Day;
						break;
					case 'm':
						Type = PeriodType.Monthly;
						Day = date.Day;
						break;
					case 'y':
						Type = PeriodType.Annual;
						Month = date.Month;
						Day = date.Day;
						break;
					default:
						throw new Exception();
				}
			}
		}

		public override string ToString()
		{
			switch (Type)
			{
				case PeriodType.Daily:
					return "d" + new DateTime(1, 1, 1, Hour, Minute, Second).ToString();
				case PeriodType.Weekly:
					return "w" + new DateTime(1, 1, WeekDay, Hour, Minute, Second).ToString();
				case PeriodType.Monthly:
					return "m" + new DateTime(1, 1, Day, Hour, Minute, Second).ToString();
				case PeriodType.Annual:
					return "y" + new DateTime(1, Month, Day, Hour, Minute, Second).ToString();
				default:
				case PeriodType.Custom:
					return "c" + timeSpan.ToString();
			}
		}

		public string Format
		{
			get
			{
				string time = " в " + (new DateTime(1, 1, 1, Hour, Minute, Second)).ToShortTimeString();
				switch (Type)
				{
					case PeriodType.Daily:
						return String.Format("ежедневно{0}", time);
					case PeriodType.Weekly:
						return String.Format("еженедельно в {0}{1}", ((DayOfWeek)(WeekDay % 7)), time);
					case PeriodType.Monthly:
						return String.Format("ежемесячно {0}-го{1}", Day, time);
					case PeriodType.Annual:
						return String.Format("ежегодно {0,2}.{1,2}{2}", Month, Day, time);
					default:
					case PeriodType.Custom:
						return String.Format("периодически {0}", timeSpan);
				}
			}
		}

		private bool CompareTime(DateTime time)
		{
			return
				Hour > time.Hour ||
				Hour == time.Hour &&
					(Minute > time.Minute ||
					 Minute == time.Minute &&
						Second > time.Second);
		}

		public DateTime GetNearestEvent(DateTime datetime)
		{
			switch (Type)
			{
				case PeriodType.Daily:
					return new DateTime(datetime.Year, datetime.Month, datetime.Day,
									Hour, Minute, Second).
							AddDays(CompareTime(datetime) ? 0 : 1);

				case PeriodType.Weekly:
					int wd1 = WeekDay % 7;
					int wd2 = (int)datetime.DayOfWeek;
					return new DateTime(datetime.Year, datetime.Month, datetime.Day,
							Hour, Minute, Second).AddDays(wd1 - wd2 +
								((wd1 > wd2 || wd1 == wd2 && CompareTime(datetime))
								? 0 : 7));

				case PeriodType.Monthly:
					return new DateTime(datetime.Year, datetime.Month, Day,
							Hour, Minute, Second).AddMonths(
								(Day > datetime.Day ||
								Day == datetime.Day && CompareTime(datetime))
								? 0 : 1);

				case PeriodType.Annual:
					return new DateTime(datetime.Year, Month, Day,
						Hour, Minute, Second).AddYears(
							(Month > datetime.Month ||
							Month == datetime.Month &&
								(Day > datetime.Day ||
								Day == datetime.Day && CompareTime(datetime)))
								? 0 : 1);
				default:
				case PeriodType.Custom:
					return TimeSpan.TotalSeconds < 1
						? DateTime.MaxValue
						: datetime + TimeSpan;
			}
		}
	}
}
