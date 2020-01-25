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

namespace XamarinForms4Feature.Pages.Common
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CollectionViewItem2 : StackLayout
    {
        private double _scale = 0;

        public CollectionViewItem2()
        {
            InitializeComponent();

            _scale = GridContainer.Scale;

            Task.Delay(2000).ContinueWith(t => AnimateItem());
        }

        private async void OnImageClick(object sender, EventArgs e)
        {
            Image image = sender as Image;

            await (App.Current as App).ClickEventAnimation(sender as View);

            BannerImage bannerImage = image.BindingContext as BannerImage;

            if (image != null)
            {
                await PopupNavigation.Instance.PushAsync(new ShowImagePopup(bannerImage, image.TranslationX, image.TranslationY));
            }
        }

        private async void OnItemClick(object sender, EventArgs e)
        {
            await (App.Current as App).ClickEventAnimation(sender as View);
        }

        private async void AnimateItem()
        {
            await GridContainer.ScaleTo(_scale * 0.8, 200);
            await GridContainer.ScaleTo(_scale, 200);
        }

    }
}