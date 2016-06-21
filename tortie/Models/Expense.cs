using System;
namespace tortie
{
	public class Expense
	{
		int _value;
		public int Value
		{
			get
			{
				return _value;
			}
			set
			{
				_value = value;
			}
		}
		
		public Expense()
		{
		}
	}
}

