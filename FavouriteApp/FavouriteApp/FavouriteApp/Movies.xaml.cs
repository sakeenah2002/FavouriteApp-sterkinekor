using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FavouriteApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Movies : ContentPage
    {
        public Movies()
        {
            InitializeComponent();
        }
    }
}