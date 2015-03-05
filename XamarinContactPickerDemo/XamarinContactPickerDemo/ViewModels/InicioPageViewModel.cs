using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinContactPickerDemo.Model;

namespace XamarinContactPickerDemo.ViewModels
{
    public class InicioPageViewModel:BaseViewModel
    {
        public string OptionOneLabel { get; set; }
        public List<Contact> ContactList { get; set;}

        public InicioPageViewModel()
        {
            PageTitle = "Listado de contactos";
            OptionOneLabel = "Selecciona un listado";

            ContactList = new List<Contact>
            {
                new Contact("Pedro"),
                new Contact("Raúl"),
                new Contact("María"),
                new Contact("Abel"),
                new Contact("Mariana")
            };
        }
    }
}
