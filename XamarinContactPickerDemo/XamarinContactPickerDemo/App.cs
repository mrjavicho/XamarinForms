using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using XamarinContactPickerDemo.Pages;
using XamarinContactPickerDemo.ViewModels;

namespace XamarinContactPickerDemo
{
    public class App : Application
    {
        private Action<ContactViewModel> _navigateAction;
        private Action<string> _callContactAction;
        public App()
        {
            _navigateAction =  new Action<ContactViewModel>((contactViewModel) =>
            {
                var navigationPage = MainPage as NavigationPage;
                if (navigationPage != null)
                    navigationPage.PushAsync(new ContactDetailPage(contactViewModel, _callContactAction));
            });
            var btnIrAListado = new Button
            {
                AnchorY = 100,
                AnchorX = 50,
                BackgroundColor = Color.Red,
                Text = "Ir al listado",
                TextColor = Color.White,
            };

            btnIrAListado.Clicked += btnIrAListado_onClick;
            // The root page of your application
            MainPage = new NavigationPage( new InicioPage(_navigateAction));
            {
                //Content = new StackLayout
                //{
                //    VerticalOptions = LayoutOptions.Center,
                //    Children = {
                //        new Label {
                //            XAlign = TextAlignment.Center,
                //            Text = "Welcome to Xamarin Forms!"
                //        },
                //        btnIrAListado
                //    }
                //}
            };
        }

        private void btnIrAListado_onClick(object sender, EventArgs e)
        {
           
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
