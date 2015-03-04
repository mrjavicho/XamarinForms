using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using XamarinContactPickerDemo.ViewModels;

namespace XamarinContactPickerDemo.Pages
{
    public partial class ContactDetailPage : ContentPage
    {
        public ContactDetailPage(ContactViewModel viewModel, Action<string> callbackAction)
        {
            this.ViewModel = viewModel;
            this.AppCallback = callbackAction;
            this.BindingContext = ViewModel;
            InitializeComponent();
        }

        public ContactViewModel ViewModel { get; set; }

        public Action<string> AppCallback { get; set; }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            //
        }
    }
}
