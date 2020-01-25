using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinForms4Feature.Model;
using XamarinForms4Feature.Pages.Popups;

namespace XamarinForms4Feature.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CollectionViewHorizontalPage : ContentPage
    {
        public CollectionViewHorizontalPage()
        {
            InitializeComponent();
        }

        private async void OnImageClick(object sender, EventArgs e)
        {
            Image image = sender as Image;

            BannerImage bannerImage = image.BindingContext as BannerImage;

            if (image != null)
            {
                await PopupNavigation.Instance.PushAsync(new ShowImagePopup(bannerImage, image.TranslationX, image.TranslationY));
            }
        }
    }
}