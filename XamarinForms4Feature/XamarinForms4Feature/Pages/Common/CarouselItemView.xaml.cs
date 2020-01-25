using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinForms4Feature.Pages.Common
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CarouselItemView : StackLayout
    {
        private double _scale = 0;

        public CarouselItemView()
        {
            InitializeComponent();

            _scale = FrameContainer.Scale;
        }


        protected override void OnParentSet()
        {
            base.OnParentSet();

            if (Parent is CarouselView carouselView)
            {
                carouselView.CurrentItemChanged += CarouselView_CurrentItemChanged;
                carouselView.Scrolled += CarouselView_Scrolled;
            }
        }

        private async void CarouselView_Scrolled(object sender, ItemsViewScrolledEventArgs e)
        {
            if (e.HorizontalDelta < 0)
            {
                await FrameContainer.RotateTo(15);
                await FrameContainer.RotateTo(0);
            }
            else
            {
                await FrameContainer.RotateTo(-15);
                await FrameContainer.RotateTo(0);
            }
        }

        private async void CarouselView_CurrentItemChanged(object sender, CurrentItemChangedEventArgs e)
        {
            await FrameContainer.ScaleTo(_scale * .5, 500);
            await FrameContainer.ScaleTo(_scale, 500);
        }
    }
}