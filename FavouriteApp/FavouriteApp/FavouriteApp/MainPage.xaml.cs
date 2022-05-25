using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FavouriteApp
{
    public partial class MainPage : FlyoutPage
    {

        public MainPage()
        {
            InitializeComponent();
            mainmenu.view.ItemSelected += OnSelectedItem;
         
        }

        private void OnSelectedItem(object sender, SelectedItemChangedEventArgs x)
        {
            var item = x.SelectedItem as Flyoutitem;
            if(item != null)
            {
                Detail = new NavigationPage(Activator.CreateInstance(item.Navpages) as Page); 
                mainmenu.view.SelectedItem = null;
                IsPresented = false;  
            } 

        }
    }
}
