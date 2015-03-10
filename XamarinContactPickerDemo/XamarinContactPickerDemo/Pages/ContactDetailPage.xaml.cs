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
        public ContactDetailViewModel ViewModel { get; set; }
        public ContactDetailPage(Contact contact, Action<string> callbackAction)
        {
            this.ViewModel = new ContactDetailViewModel(contact);
            this.AppCallback = callbackAction;
            this.BindingContext = ViewModel;
            InitializeComponent();
        }

        public Action<string> AppCallback { get; set; }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            if (ViewModel!=null)
            {
                try
                {
                    await ViewModel.LeerDataContacto();
                }
                catch (Exception e)
                {

                    var a = e.Message;
                }
                
            }
        }
    }
}
