using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static Astronomy.PageTypes;

namespace Astronomy
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AstronomyMasterPage : ContentPage
    {
        public event EventHandler<PageType> PageSelected;
        public AstronomyMasterPage()
        {
            InitializeComponent();

            btnMoonPhase.Clicked += (s, e) => PageSelected?.Invoke(this, PageType.MoonPhase);
            btnSunrise.Clicked += (s, e) => PageSelected?.Invoke(this, PageType.Sunrise);
            btnAbout.Clicked += (s, e) => PageSelected?.Invoke(this, PageType.About);

            btnEarth.Clicked += (s, e) => PageSelected?.Invoke(this, PageType.Earth);
            btnMoon.Clicked += (s, e) => PageSelected?.Invoke(this, PageType.Moon);
            btnSun.Clicked += (s, e) => PageSelected?.Invoke(this, PageType.Sun);

        }
    }
}