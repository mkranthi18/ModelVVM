using ModelVVM.Model;
using ModelVVM.Views;
using Xamarin.Forms;

namespace ModelVVM
{
    public partial class App : Application
    {
		public static DataAccess dbUtils;

		public App()
		{
			InitializeComponent();

			MainPage = new NavigationPage(new Login()); 
		}
			public static DataAccess DAUtil
        {
            get
            {
                if (dbUtils == null)
                {
                    dbUtils = new DataAccess();
                }
                return dbUtils;
            }
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
