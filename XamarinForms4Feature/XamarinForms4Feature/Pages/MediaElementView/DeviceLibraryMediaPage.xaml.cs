using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using XamarinForms4Feature.DependencyServices;

namespace XamarinForms4Feature.Pages.MediaElementView
{
    public partial class DeviceLibraryMediaPage : ContentPage
    {
        public DeviceLibraryMediaPage()
        {
            InitializeComponent();

            _ = PickVideo();
        }

        private async Task PickVideo()
        {
            var photo = await MediaPicker.PickVideoAsync();

            if (!string.IsNullOrWhiteSpace(photo.FullPath))
            {
                mediaElement.Source = new FileMediaSource
                {
                    File = photo.FullPath
                };
            }
            else
            {
                await DisplayAlert("", "No video found.", "ok");
            }
        }
    }
}
