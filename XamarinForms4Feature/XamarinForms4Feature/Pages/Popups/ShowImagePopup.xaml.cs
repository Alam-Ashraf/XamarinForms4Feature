using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinForms4Feature.Model;

namespace XamarinForms4Feature.Pages.Popups
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ShowImagePopup : PopupPage
    {
        public ShowImagePopup(BannerImage bannerImage, double x, double y)
        {
            InitializeComponent();

            BannerImage.Source = bannerImage.ImageUrl;
        }


        private async void OnBackgroundImageClick(object sender, EventArgs e)
        {
            await PopupNavigation.Instance.PopAsync();
        }
    }
}