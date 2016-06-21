using System;

namespace tortie
{
	public class RepeatExpense
	{
		public int Value
		{
			get
			{
				return GetTotalExpense();
			}
		}

		public string ValueString
		{
			get
			{
				return GetTotalExpense().ToString();
			}
		}

		public Expense Expense { get; set; }

		public int RepeatNum { get; set; }
		
		public RepeatExpense()
		{
		}

		public int GetTotalExpense()
		{
			var val = 0;
			for (var i = 0; i < RepeatNum; i++)
			{
				val += Expense.Value;
			}
			return val;
		}
	}
}

