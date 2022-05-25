using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace FavouriteApp
{
   public class Flyoutitem
    {
        /*details you see on the flyout page*/
        public string Title { get; set; }
        
        /* where you store the page*/
        public Type Navpages { get; set; }
    }

}
