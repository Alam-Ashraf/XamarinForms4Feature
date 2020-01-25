using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinForms4Feature.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CollectionViewMenuPage : ContentPage
    {
        public CollectionViewMenuPage()
        {
            InitializeComponent();
        }

        private async void OnCollectioViewAsVerticalClick(object sender, EventArgs e)
        {
            await (App.Current as App).ClickEventAnimation(sender as View);

            await Navigation.PushAsync(new CollectionViewPage());
        }

        private async void OnCollectioViewAsHorizontal(object sender, EventArgs e)
        {
            await (App.Current as App).ClickEventAnimation(sender as View);

            await Navigation.PushAsync(new CollectionViewHorizontalPage());
        }

        private async void OnCollectioViewAsGridClick(object sender, EventArgs e)
        {
            await (App.Current as App).ClickEventAnimation(sender as View);

            await Navigation.PushAsync(new CollectionViewGridPage());
        }

        private async void OnCollectioViewAsContextMenuClick(object sender, EventArgs e)
        {
            await (App.Current as App).ClickEventAnimation(sender as View);

            await Navigation.PushAsync(new CollectionViewContextMenuPage());
        }

        private async void OnCollectioViewAsGroupClick(object sender, EventArgs e)
        {
            await(App.Current as App).ClickEventAnimation(sender as View);

            await Navigation.PushAsync(new CollectionViewGroupPage());
        }
    }
}