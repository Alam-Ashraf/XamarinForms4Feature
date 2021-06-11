using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamarinForms4Feature.ViewModel;

namespace XamarinForms4Feature.Pages.MediaElementView
{
    public partial class CustomControlingMediaPage : ContentPage
    {
        private bool polling;

        private CustomControlingMediaViewModel _customControlingMediaViewModel;

        public CustomControlingMediaPage()
        {
            InitializeComponent();

            BindingContext = _customControlingMediaViewModel = new CustomControlingMediaViewModel(Media);
        }

        private void Media_MediaEnded(System.Object sender, System.EventArgs e)
        {
            Media.Stop();

            _customControlingMediaViewModel.IsPlaying = false;
            _customControlingMediaViewModel.IsShowing = true;

            positionSlider.Value = 0;
            _customControlingMediaViewModel.CurrentPos = new TimeSpan();
        }


        protected override void OnAppearing()
        {
            base.OnAppearing();

            positionSlider.Minimum = 0;
            positionSlider.Maximum = Media.Duration.Value.Seconds;

            if (Media.Duration != null)
                _customControlingMediaViewModel.TotalDuration = (TimeSpan)Media.Duration;
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();

            // Stop Timer
            _customControlingMediaViewModel.IsTimerRunning = false;
        }


        void OnPositionSliderValueChanged(System.Object sender, Xamarin.Forms.ValueChangedEventArgs e)
        {
            _customControlingMediaViewModel.IsTimerRunning = false;
            Media.Pause();

            _customControlingMediaViewModel.CurrentPos = TimeSpan.FromSeconds(e.NewValue);

            //Media.Position = positionSlider.Position;
            //positionSlider.Value = positionSlider.Value;
            //Media.Position = TimeSpan.FromSeconds(e.NewValue);
            //positionLabel.Text = Media.Position.ToString("hh\\:mm\\:ss");

            _customControlingMediaViewModel.IsTimerRunning = true;
            Media.Play();
        }
    }
}
