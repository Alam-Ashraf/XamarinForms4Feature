using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinForms4Feature.Model;

namespace XamarinForms4Feature.ViewModel
{
    public class CollectionViewPageViewModel : BaseViewModel
    {
        private ObservableCollection<BannerImage> _imageList1;
        private ObservableCollection<BannerImage> _imageList2;
        private ObservableCollection<BannerImage> _imageList3;
        private ObservableCollection<BannerImage> _imageList4;
        private ObservableCollection<BannerImage> _imageList5;
        private ObservableCollection<BannerImage> _imageList6;

        private ObservableCollection<BannerGroup> _imageList7;

        public CollectionViewPageViewModel()
        {
            _imageList1 = GetImageList1();
            _imageList2 = GetImageList2();
            _imageList3 = GetImageList3();
            _imageList4 = GetImageList4();
            _imageList6 = GetImageList6();

            // Load 5th Banner list after 10 Second
            Task.Delay(5000).ContinueWith(t => Get5thBannerList());

            CreateBannerHeaderList();
        }

        private void Get5thBannerList()
        {
            ImageList5 = GetImageList5();
        }

        private void CreateBannerHeaderList()
        {
            ImageList7 = new ObservableCollection<BannerGroup>();

            ImageList7.Add(new BannerGroup("Header 1", "Footer 1", new ObservableCollection<BannerImage>(ImageList1.Take(3))));
            ImageList7.Add(new BannerGroup("Header 2", "Footer 2", new ObservableCollection<BannerImage>(ImageList2.Take(2))));
            ImageList7.Add(new BannerGroup("Header 3", "Footer 3", new ObservableCollection<BannerImage>(ImageList3.Take(5))));
        }

        public ObservableCollection<BannerImage> ImageList1
        {
            get => _imageList1;

            set
            {
                _imageList1 = value;

                OnPropertyChanged();
            }
        }

        public ObservableCollection<BannerImage> ImageList2
        {
            get => _imageList2;

            set
            {
                _imageList2 = value;

                OnPropertyChanged();
            }
        }

        public ObservableCollection<BannerImage> ImageList3
        {
            get => _imageList3;

            set
            {
                _imageList3 = value;

                OnPropertyChanged();
            }
        }

        public ObservableCollection<BannerImage> ImageList4
        {
            get => _imageList4;

            set
            {
                _imageList4 = value;

                OnPropertyChanged();
            }
        }

        public ObservableCollection<BannerImage> ImageList5
        {
            get => _imageList5;

            set
            {
                _imageList5 = value;

                OnPropertyChanged();
            }
        }

        public ObservableCollection<BannerImage> ImageList6
        {
            get => _imageList6;

            set
            {
                _imageList6 = value;

                OnPropertyChanged();
            }
        }

        public ObservableCollection<BannerGroup> ImageList7
        {
            get => _imageList7;

            set
            {
                _imageList7 = value;

                OnPropertyChanged();
            }
        }
    }
}
