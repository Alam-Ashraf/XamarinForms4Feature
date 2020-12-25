using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinForms4Feature
{
    public partial class App : Application
    {
        public App()
        {
            Xamarin.Forms.Device.SetFlags(new List<string>() {
                                            "StateTriggers_Experimental",
                                             "IndicatorView_Experimental",
                                             "CarouselView_Experimental",
                                             "MediaElement_Experimental"
                                         });

            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
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


        public async Task ClickEventAnimation(View view)
        {
            await view.ScaleTo(1 * 0.9, 100);
            await view.ScaleTo(1, 100);
        }
    }
}
