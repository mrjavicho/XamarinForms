using System;
using Xamarin.Forms;
using XamarinContactPickerDemo.Model;
using XamarinContactPickerDemo.ViewModels;

namespace XamarinContactPickerDemo.Pages
{
    public partial class InicioPage : ContentPage
    {
        public InicioPageViewModel ViewModel { get; set; }
        public InicioPage(Action<Contact> callbackAction)
        {
            this.AppCallback = callbackAction;
            InitializeComponent();
            ViewModel = new InicioPageViewModel();
            this.BindingContext = ViewModel;
        }

        public Action<Contact> AppCallback { get; set; }
        private void ListViewTareas_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (AppCallback!=null)
            {
                var selectedViewModel = e.SelectedItem as Contact;
                AppCallback(selectedViewModel);
            }
        }
    }
}
