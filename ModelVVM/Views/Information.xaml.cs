using System;
using System.Collections.Generic;
using SQLite.Net;
using Xamarin.Forms;

using SQLite;

using SQLite.Net.Attributes;
using ModelVVM.Model;

namespace ModelVVM.Views
{
    public partial class Information : ContentPage
    {

		async void SubmitCancel(object sender, System.EventArgs e)
        {
			await Navigation.PushAsync(new Login());
        }

		async void SubmitSuccess(object sender, System.EventArgs e)
		{
			var vEmployee = new Employee()
			{
				FirstName = FirstName.Text,
				LastName = LastName.Text,
				Email = Email.Text,
				Location = Location.Text,
				Client = Client.Text,
				Vendor = Vendor.Text,
				// dob = Date.Text
			};
			App.DAUtil.SaveEmployee(vEmployee);
			//

			await Navigation.PushAsync(new Login());
		}

        public Information()
        {
            InitializeComponent();
        }

		public interface ISQLite
		{
			SQLiteConnection GetConnection();
		}
    }
}
