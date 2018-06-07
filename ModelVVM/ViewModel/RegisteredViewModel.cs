using System;
using System.Threading.Tasks;
using System.Windows.Input;
using ModelVVM.Model;
using ModelVVM.Views;
using Xamarin.Forms;

namespace ModelVVM.ViewModel
{
	public class RegisteredViewModel:BaseViewModel
    {
		private Employee _employee;
		public INavigation _navigation;
		public ICommand AddCommand { get; private set; } 
		public RegisteredViewModel(INavigation navigation)
        {
			_employee = new Employee();
			_navigation = navigation;


            AddCommand = new Command(async () => await AddContact());
            
        }
        

        async Task AddContact()
        {
            
                bool isUserAccept = await Application.Current.MainPage.DisplayAlert("Add Contact", "Do you want to save Contact details?", "OK", "Cancel");
                if (isUserAccept)
                {
				App.DAUtil.SaveEmployee(_employee);
                    await _navigation.PushAsync(new Login());
                }
            
            else
            {
			await Application.Current.MainPage.DisplayAlert("Add Contact", "something wrong", "Ok");
            }
        }
        public string FirstName
        {
            get
            {
                return _employee.FirstName;
            }
            set
            {
				_employee.FirstName = value;
				OnPropertyChanged("FirstName");
            }
        }
		public string LastName
        {
            get
            {
                return _employee.LastName;
            }
            set
            {
				_employee.LastName = value;
				OnPropertyChanged("LastName");
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

		public string Vendor
        {
            get
            {
				return _employee.Vendor;
            }
            set
            {
				_employee.Vendor = value;
                OnPropertyChanged("Vendor");
            }
        }
		public string Location
        {
            get
            {
				return _employee.Location;
            }
            set
            {
				_employee.Location = value;
                OnPropertyChanged("Location");
            }
        }

		public string Client
        {
            get
            {
				return _employee.Client;
            }
            set
            {
				_employee.Client = value;
                OnPropertyChanged("Client");
            }
        }
    }
}
