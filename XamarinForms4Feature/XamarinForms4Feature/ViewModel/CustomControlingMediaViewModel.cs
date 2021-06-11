using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace XamarinForms4Feature.ViewModel
{
    public class CustomControlingMediaViewModel : BaseViewModel
    {
        #region Constructor

        public CustomControlingMediaViewModel(MediaElement Media)
        {
            _media = Media;

            PlayPauseComand = new Command(OnPlayAndPauseClicked);
            MediaCommand = new Command(OnMediaTapClicked);
            StopComand = new Command(OnMediaStopedClicked);
        }

        #endregion


        #region Handle Click Events

        private void OnPlayAndPauseClicked()
        {
            if (IsPlaying)
            {
                _media.Pause();
            }
            else
            {
                StartTimer();

                _media.Play();
            }

            IsPlaying = !IsPlaying;

            OnMediaTapClicked();
        }

        private void OnMediaTapClicked()
        {
            IsShowing = !IsShowing;

            if (IsShowing)
            {
                // Hide Play/Pause button after 5 Second
                Task.Delay(5000).ContinueWith(t => HidePlayAndPauseButton());
            }
        }

        private void OnMediaStopedClicked()
        {
            _media.Stop();

            IsPlaying = false;
            IsShowing = true;

            CurrentPos = new TimeSpan();
        }

        private void HidePlayAndPauseButton()
        {
            if(IsShowing)
            {
                IsShowing = false;
            }
        }


        private void StartTimer()
        {
            Device.StartTimer(TimeSpan.FromMilliseconds(1000), () =>
            {
                Device.BeginInvokeOnMainThread(() =>
                {
                    if (_media.CurrentState == MediaElementState.Playing)
                    {
                        CurrentPos = _media.Position;
                        //positionSlider.Position = Media.Position;
                        //positionSlider.Value = Media.Position.Seconds;
                    }
                });
                return IsTimerRunning;
            });
        }

        #endregion


        #region Properties

        public bool IsTimerRunning = true;

        private MediaElement _media;

        private bool _isPlaying;

        public bool IsPlaying
        {
            get => _isPlaying;

            set
            {
                _isPlaying = value;

                OnPropertyChanged();
            }
        }

        private bool _isShowing = true;

        public bool IsShowing
        {
            get => _isShowing;

            set
            {
                _isShowing = value;

                OnPropertyChanged();
            }
        }


        private TimeSpan _totalDuration;

        public TimeSpan TotalDuration
        {
            get => _totalDuration;

            set
            {
                _totalDuration = value;

                OnPropertyChanged();
            }
        }

        private TimeSpan _currentPos;

        public TimeSpan CurrentPos
        {
            get => _currentPos;

            set
            {
                _currentPos = value;

                OnPropertyChanged();

                CurrentPosSlider = _currentPos.Seconds;
            }
        }

        private double _currentPosSlider;

        public double CurrentPosSlider
        {
            get => _currentPosSlider;

            set
            {
                _currentPosSlider = value;

                OnPropertyChanged();
            }
        }


        public ICommand PlayPauseComand { get; set; }
        public ICommand MediaCommand { get; set; }
        public ICommand StopComand { get; set; }

        #endregion
    }
}
