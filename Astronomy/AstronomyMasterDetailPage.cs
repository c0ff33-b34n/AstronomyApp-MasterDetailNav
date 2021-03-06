using Astronomy.Pages;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using static Astronomy.PageTypes;

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

            master.PageSelected += MasterPageSelected;
            PresentDetailPage(PageType.Sunrise);
        }

        private void MasterPageSelected(object sender, PageType e)
        {
            PresentDetailPage(e);
        }

        void PresentDetailPage(PageType pageType)
        {
            Page page;

            switch (pageType)
            {
                case PageType.Sunrise:
                    page = new SunrisePage();
                    break;
                case PageType.MoonPhase:
                    page = new MoonPhasePage();
                    break;
                case PageType.Earth:
                    page = new AstronomicalBodyPage(SolarSystemData.Earth);
                    break;
                case PageType.Moon:
                    page = new AstronomicalBodyPage(SolarSystemData.Moon);
                    break;
                case PageType.Sun:
                    page = new AstronomicalBodyPage(SolarSystemData.Sun);
                    break;
                case PageType.About:
                default:
                    page = new AboutPage();
                    break;
            }

            Detail = new NavigationPage(page);

            IsPresented = false;
        }
    }
}
