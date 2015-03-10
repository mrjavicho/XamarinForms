using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinContactPickerDemo.Model;
using XamarinContactPickerDemo.Services;

namespace XamarinContactPickerDemo.ViewModels
{
    public class ContactDetailViewModel:BaseViewModel
    {

        public ContactDetailViewModel(Contact contact)
        {
            this.Contact = contact;
        }

        public async Task LeerDataContacto()
        {
            var numParams = random.Next(1, 3);
            BussyState = true;
            var content = await MeatyLoremService.GetLoremMeatP(numParams);
            BussyState = false;
            Contact.AboutMe = content;
            OnPropertyChanged("Contact");
        }

        public Contact Contact { get; set; }

        private static Random random = new Random();

    }
}
