using System;
using System.Threading.Tasks;
using Android.Content;
using Xamarin.Forms;
using XamarinForms4Feature.DependencyServices;
using XamarinForms4Feature.Droid.DependencyServices;

[assembly: Dependency(typeof(VideoPicker))]
namespace XamarinForms4Feature.Droid.DependencyServices
{
    public class VideoPicker : IVideoPicker
    {
        public Task<string> GetVideoFileAsync()
        {
            // Defint eht Intent for getting images
            Intent intent = new Intent();
            intent.SetType("video/*");
            intent.SetAction(Intent.ActionGetContent);

            // Get the MainActivity instance
            MainActivity activity = MainActivity.Current;

            // Start the picture-picker activity (resumes in MainActivity.cs)
            activity.StartActivityForResult(Intent.CreateChooser(intent, "SelectVideo"), MainActivity.PickImageId);

            // Save the TaskCompletionSource object as a MainActivity property;
            activity.PickImageTaskCompletionSource = new TaskCompletionSource<string>();

            // Return Task object
            return activity.PickImageTaskCompletionSource.Task;
        }
    }
}
