using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinContactPickerDemo.ViewModels
{
    public class ContactViewModel
    {
        private static readonly Random random = new Random();
        public String Name { get; set; }
        public Color Color { get; set; }

        public ContactViewModel( String name)
        {
            Name = name;
            var randomA = random.Next(0,255);
            var randomG = random.Next(0, 255);
            var randomB = random.Next(0, 255);
            Color =  Color.FromRgb(randomA, randomG, randomB);
        }
    }
}
