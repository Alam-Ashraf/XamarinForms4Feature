using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinForms4Feature
{
    public partial class App : Application
    {
        public App()
        {
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
