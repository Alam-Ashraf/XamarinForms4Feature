using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinForms4Feature.Pages.MediaElementView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MediaElementPage : ContentPage
    {
        public MediaElementPage()
        {
            InitializeComponent();
        }

        private async void OnRemoteMediaClick(object sender, EventArgs e)
        {
            await (App.Current as App).ClickEventAnimation(FrameRemoteMedia);

            await Navigation.PushAsync(new RemoteMediaPage());
        }

        private async void OnLocalMediaClick(object sender, EventArgs e)
        {
            await (App.Current as App).ClickEventAnimation(FrameLocalMedia);

            await Navigation.PushAsync(new LocalMediaPage());
        }

        private async void OnLocalOrTempMediaClick(object sender, EventArgs e)
        {
            await (App.Current as App).ClickEventAnimation(FrameLocalOrTemp);

            await CopyVideoIfNotExists("ms-appx:///video.mp4");

            await Navigation.PushAsync(new MediaElementPageFromFileOrTemp());
        }

        // This method copies the video from the app package to the app data
        // directory for your app. To copy the video to the temp directory
        // for your app, comment out the first line of code, and uncomment
        // the second line of code.
        public static async Task CopyVideoIfNotExists(string filename)
        {
            string folder = FileSystem.AppDataDirectory;
            //string folder = Path.GetTempPath();
            string videoFile = Path.Combine(folder, "XamarinVideo.mp4");

            if (!File.Exists(videoFile))
            {
                using (Stream inputStream = await FileSystem.OpenAppPackageFileAsync(filename))
                {
                    using (FileStream outputStream = File.Create(videoFile))
                    {
                        await inputStream.CopyToAsync(outputStream);
                    }
                }
            }
        }
    }
}