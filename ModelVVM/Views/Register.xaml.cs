using System;
using System.Collections.Generic;
using ModelVVM.Model;
using SQLite.Net;
using Xamarin.Forms;
using ModelVVM.ViewModel;

namespace ModelVVM.Views
{
    public partial class Register : ContentPage
    {
        public Register()
        {
            InitializeComponent();
			BindingContext = new RegisteredViewModel(Navigation);
        }

		//async void SubmitCancel(object sender, System.EventArgs e)
        //{
        //    await Navigation.PushAsync(new Login());
        //}

		//async void Register_Clicked(object sender, System.EventArgs e)
        //{
        //    var vEmployee = new Employee()
        //    {
        //        FirstName = FirstName.Text,
        //        LastName = LastName.Text,
        //        Email = Email.Text,
        //        Location = Location.Text,
        //        Client = Client.Text,
        //        Vendor = Vendor.Text,
        //        // dob = Date.Text
        //    };
        //    App.DAUtil.SaveEmployee(vEmployee);
        //    //

        //    await Navigation.PushAsync(new Login());
        //}
		      
		public interface ISQLite
        {
            SQLiteConnection GetConnection();
        }
    }
}
