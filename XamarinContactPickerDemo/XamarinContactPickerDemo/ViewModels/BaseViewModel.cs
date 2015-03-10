using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using XamarinContactPickerDemo.Annotations;

namespace XamarinContactPickerDemo.ViewModels
{
    public class BaseViewModel:INotifyPropertyChanged
    {
        public String PageTitle { get; set; }
        private bool _bussyState;

        public bool BussyState
        {
            get { return _bussyState; }
            set
            {
                _bussyState = value; 
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
