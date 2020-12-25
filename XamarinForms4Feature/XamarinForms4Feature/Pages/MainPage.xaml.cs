using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinForms4Feature.Pages;
using XamarinForms4Feature.Pages.CarouselsView;
using XamarinForms4Feature.Pages.CollectionsView;
using XamarinForms4Feature.Pages.GifView;
using XamarinForms4Feature.Pages.MediaElementView;
using XamarinForms4Feature.Pages.SwipeView;

namespace XamarinForms4Feature
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnCarouselViewClick(object sender, EventArgs e)
        {
            await (App.Current as App).ClickEventAnimation(FrameCarousel);

            await Navigation.PushAsync(new CarouselViewPage());
        }

        private async void OnCollectionViewClick(object sender, EventArgs e)
        {
            await (App.Current as App).ClickEventAnimation(FrameCollection);

            await Navigation.PushAsync(new CollectionViewMenuPage());
        }

        private async void OnSwipeViewClick(object sender, EventArgs e)
        {
            await (App.Current as App).ClickEventAnimation(FrameSwipe);

            await Navigation.PushAsync(new SwipeViewPage());
        }

        private async void OnImageWithGifClick(object sender, EventArgs e)
        {
            await (App.Current as App).ClickEventAnimation(FrameImageWithGif);

            await Navigation.PushAsync(new GifPage());
        }

        private async void OnMediaElementClick(object sender, EventArgs e)
        {
            await (App.Current as App).ClickEventAnimation(FrameMediaElement);

            await Navigation.PushAsync(new MediaElementPage());
        }
    }
}
