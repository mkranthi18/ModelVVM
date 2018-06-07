using System;
using System.ComponentModel;

 namespace ModelVVM.ViewModel
{
	public class BaseViewModel:INotifyPropertyChanged
    {
        public BaseViewModel()
        {
        }
		protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this,
                    new PropertyChangedEventArgs(propertyName));
            }
        }


        #region INotifyPropertyChanged implementation

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion
    }
}
