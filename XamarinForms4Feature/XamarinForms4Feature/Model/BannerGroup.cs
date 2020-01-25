using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace XamarinForms4Feature.Model
{
    public class BannerGroup : ObservableCollection<BannerImage>
    {
        public string BannerHeader { get; set; }
        public string BannerFooter { get; set; }
        public ObservableCollection<BannerImage> BannerList { get; set; }

        public BannerGroup(string BannerHeader , string BannerFooter, ObservableCollection<BannerImage> BannerList) :base(BannerList)
        {
            this.BannerHeader = BannerHeader;
            this.BannerFooter = BannerFooter;
        }
    }
}
