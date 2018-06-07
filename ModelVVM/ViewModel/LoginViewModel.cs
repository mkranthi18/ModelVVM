using System;
using System.Threading.Tasks;
using System.Windows.Input;
using ModelVVM.Model;
using ModelVVM.Views;
using Xamarin.Forms;

namespace ModelVVM.ViewModel
{
    public class LoginViewModel : BaseViewModel
    {
        private Employee _employee;
        public INavigation _navigation;
        public ICommand LoginCommand { get; private set; }
        public LoginViewModel(INavigation navigation)
        {
            _employee = new Employee();
            _navigation = navigation;


            LoginCommand = new Command(async () => await Login());
        }
        async Task Login()
        {
			var vlist = App.DAUtil.GetAllEmployees();
			if (_employee.Email != null)
			{
				var vList1 = App.DAUtil.GetEmployee(_employee.Email.ToString());
				_employee = new Employee
				{
					FirstName = vList1[0].FirstName.ToString(),
					//LastName = vList1[0].LastName.ToString(),
					//Vendor = vList1[0].Vendor.ToString(),
					//Location = vList1[0].Location.ToString(),
					//Client = vList1[0].Client.ToString(),
					Email = vList1[0].Email.ToString()

				};
				var detailPage = new Details();
                detailPage.BindingContext = _employee;

                await _navigation.PushAsync(detailPage);
           
			}
			else
			{
				await Application.Current.MainPage.DisplayAlert("Login", "something wrong", "Ok");
			}
                
        }
		public string Email
        {
            get
            {
                return _employee.Email;
            }
            set
            {
                _employee.Email = value;
                OnPropertyChanged("Email");
            }
        }
    }
}
