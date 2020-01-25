using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinForms4Feature.Model;
using XamarinForms4Feature.Pages.Popups;

namespace XamarinForms4Feature.Pages.Common
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CollectionViewItem : StackLayout
    {
        private double _scale = 0;

        public CollectionViewItem()
        {
            InitializeComponent();

            _scale = FrameContainer.Scale;
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

        protected override void OnChildAdded(Element child)
        {
            base.OnChildAdded(child);

            Task.Delay(2000).ContinueWith(t => AnimateItem());
        }

        private async void AnimateItem()
        {
            await FrameContainer.ScaleTo(_scale * 0.8, 200);
            await FrameContainer.ScaleTo(_scale, 200);
        }


    }
}