using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinContactPickerDemo.ViewModels
{
    public class InicioPageViewModel:BaseViewModel
    {
        public string OptionOneLabel { get; set; }
        public List<ContactViewModel> ContactList { get; set;}

        public InicioPageViewModel()
        {
            PageTitle = "Listado de contactos";
            OptionOneLabel = "Selecciona un listado";

            ContactList = new List<ContactViewModel>
            {
                new ContactViewModel("Pedro"),
                new ContactViewModel("Raúl"),
                new ContactViewModel("María"),
                new ContactViewModel("Abel"),
                new ContactViewModel("Mariana")
            };
        }
    }
}
