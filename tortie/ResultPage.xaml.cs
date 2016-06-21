using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace tortie
{
	public partial class ResultPage : ContentPage
	{
		ObservableCollection<RepeatExpense> _expenses = new ObservableCollection<RepeatExpense>();

		PersonalData _personalData;
		public PersonalData PersonalData
		{
			set
			{
				_personalData = value;
				for (var i = 1; i <= 50; i++)
				{
					_expenses.Add(new RepeatExpense { Expense = new Expense { Value = _personalData.RentMoney }, RepeatNum = (12 * i) });
				}
			}
		}
		
		public ResultPage()
		{
			InitializeComponent();

			ExpenseListView.ItemsSource = _expenses;
		}
	}
}

