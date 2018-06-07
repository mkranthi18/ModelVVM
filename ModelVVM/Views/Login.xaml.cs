using System;
using System.Collections.Generic;
using ModelVVM.Model;
using ModelVVM.ViewModel;
using Xamarin.Forms;

namespace ModelVVM.Views
{
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
			BindingContext = new LoginViewModel(Navigation);
        }
		//public async void LoginButton(object sender, System.EventArgs e)
       
   //     {
			//var vList1 = App.DAUtil.GetEmployee(Email.Text);
			//var vlist = App.DAUtil.GetAllEmployees();
   //         var emp = new Employee
   //         {
   //             FirstName = vList1[0].FirstName.ToString(),
   //             LastName = vList1[0].LastName.ToString(),
   //             Vendor = vList1[0].Vendor.ToString(),
   //             Location = vList1[0].Location.ToString(),
   //             Client = vList1[0].Client.ToString(),
   //             Email = vList1[0].Email.ToString()

   //         };
   //         var detailPage = new Details();
			//detailPage.BindingContext = emp;
			//await Navigation.PushAsync(detailPage);
        //}
		async void Signup_Clicked(object sender, System.EventArgs e)
		{
			await Navigation.PushAsync(new Register());
		}
    }
}
