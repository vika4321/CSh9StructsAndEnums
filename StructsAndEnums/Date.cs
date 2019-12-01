using System;

namespace StructsAndEnums
{
	//class Date - reference type, objects point to the same place
	struct Date //value type, objects are just copies
	{
		private int day;
		private Month month;
		private int year;
		public Date(int ccyy, Month mm, int dd)
		{
			this.day = dd - 1;
			this.month = mm;
			this.year = ccyy - 1900;
		}

		public override string ToString()
		{
			string data = String.Format("{0} {1} {2}", this.month, this.day + 1, this.year + 1900) ;
			return data;
		}

		public void AdvanceMonth()
		{
			this.month++;
			if (this.month == Month.December + 1)
			{
				this.month = Month.January;
				this.year++;
			}
		}
	}
}