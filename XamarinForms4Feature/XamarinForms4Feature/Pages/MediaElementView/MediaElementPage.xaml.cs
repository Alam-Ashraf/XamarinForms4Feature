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

            await CopyVideoIfNotExists();

            await Navigation.PushAsync(new MediaElementPageFromFileOrTemp());
        }

        private async void OnDeviceLibraryMediaClick(System.Object sender, System.EventArgs e)
        {
            await(App.Current as App).ClickEventAnimation(FrameDeviceLibrary);

            await Navigation.PushAsync(new DeviceLibraryMediaPage());
        }

        private async void OnCustomControllingMediaClick(System.Object sender, System.EventArgs e)
        {
            await (App.Current as App).ClickEventAnimation(FrameCustomControllingLibrary);

            await Navigation.PushAsync(new CustomControlingMediaPage());
        }


        // This method copies the video from the app package to the app data  
        // directory for your app. To copy the video to the temp directory
        // for your app, comment out the first line of code, and uncomment
        // the second line of code.
        public static async Task CopyVideoIfNotExists()
        {
            try
            {
                string folderLocal = Path.GetTempPath();
                string localVideoFile = Path.Combine(folderLocal, "video_stored_in_local1.mp4");

                // Copy Package video in local folder 
                if (!File.Exists(localVideoFile))
                {
                    using (Stream inputStream = await FileSystem.OpenAppPackageFileAsync("video.mp4"))
                    {
                        using (FileStream outputStream = File.Create(localVideoFile))
                        {
                            await inputStream.CopyToAsync(outputStream);
                        }
                    }
                }


                // Copy Package video in temp folder 
                string folderTemp = FileSystem.AppDataDirectory;
                string tempVideoFile = Path.Combine(folderTemp, "video_stored_in_temp1.mp4");

                if (!File.Exists(tempVideoFile))
                {
                    using (Stream inputStream = await FileSystem.OpenAppPackageFileAsync("video.mp4"))
                    {
                        using (FileStream outputStream = File.Create(tempVideoFile))
                        {
                            await inputStream.CopyToAsync(outputStream);
                        }
                    }
                }
            }
            catch(Exception ex)
            {

            }
            
        }
        

    }
}