using Astronomy.Pages;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Astronomy
{
    class AstronomyMasterDetailPage : MasterDetailPage
    {
        public AstronomyMasterDetailPage()
        {
            var master = new AstronomyMasterPage();

            if (Device.RuntimePlatform == Device.iOS)
            {
                master.IconImageSource = ImageSource.FromFile("nav-menu-icon.png");
            }

            this.Master = master;

            this.Detail = new NavigationPage(new AboutPage());

            this.MasterBehavior = MasterBehavior.Popover;
        }
    }
}
