using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using XamarinContactPickerDemo.Model;
using XamarinContactPickerDemo.ViewModels;

namespace XamarinContactPickerDemo.Pages
{
    public partial class ContactDetailPage : ContentPage
    {
        public ContactDetailPage(Contact viewModel, Action<string> callbackAction)
        {
            this.ViewModel = viewModel;
            this.AppCallback = callbackAction;
            this.BindingContext = ViewModel;
            InitializeComponent();
        }

        public Contact ViewModel { get; set; }

        public Action<string> AppCallback { get; set; }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            //
        }
    }
}
