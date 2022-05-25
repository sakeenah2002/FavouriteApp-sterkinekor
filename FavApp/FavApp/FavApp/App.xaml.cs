using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FavApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

              MainPage = new Buttons();
        }

        private void Button_Clicked(object sender,EventArgs e)
        {

        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
