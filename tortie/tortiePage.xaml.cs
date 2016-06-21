using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace tortie
{
	/// <summary>
	/// Tortie page.
	/// </summary>
	public partial class tortiePage : ContentPage
	{
		/// <summary>
		/// The ages.
		/// </summary>
		List<int> _ages;
		/// <summary>
		/// Gets the ages.
		/// </summary>
		/// <value>The ages.</value>
		public List<int> Ages
		{ 			get 			{ 				if (_ages == null) 				{ 					var list = new List<int>(); 					for (var i = 20; i <= 65; i++) 					{ 						list.Add(i); 					} 					_ages = list; 				} 				return _ages; 			}
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:tortie.tortiePage"/> class.
		/// </summary>
		public tortiePage()
		{
			BindingContext = new { Ages = Ages };
			
			InitializeComponent();
		}

		void Handle_OkButtonClicked(object sender, System.EventArgs e)
		{
			var personalData = new PersonalData
			{
				Age = int.Parse(agePicker.Items[agePicker.SelectedIndex]),
				RentMoney = int.Parse(RentMoneyEditor.Text)
			};

			Navigation.PushAsync(
				new ResultPage()
				{
					PersonalData = personalData
				});
		}
	}
}

