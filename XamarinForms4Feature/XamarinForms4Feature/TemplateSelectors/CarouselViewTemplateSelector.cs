using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using XamarinForms4Feature.Model;

namespace XamarinForms4Feature.TemplateSelectors
{
    public class CarouselViewTemplateSelector : DataTemplateSelector
    {
        public DataTemplate CurveTemplate { get; set; }
        public DataTemplate SquareTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            BannerImage banner = (BannerImage)item;
            return banner.IsSquareView ? SquareTemplate : CurveTemplate;
        }
    }
}
