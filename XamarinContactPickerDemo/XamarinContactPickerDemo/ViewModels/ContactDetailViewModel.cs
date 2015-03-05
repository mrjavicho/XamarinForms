using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinContactPickerDemo.ViewModels
{
    public class ContactDetailViewModel:BaseViewModel
    {

        public Command GetContactDataCommand
        {
            get { return new Command(async () =>
            {
                


            });}
        }


    }
}
