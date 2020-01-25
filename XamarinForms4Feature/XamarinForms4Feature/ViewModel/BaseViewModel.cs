using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinForms4Feature.Model;

namespace XamarinForms4Feature.ViewModel
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public BaseViewModel()
        {

        }

        public void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public ObservableCollection<BannerImage> GetImageList1()
        {
            ObservableCollection<BannerImage> ImageList = new ObservableCollection<BannerImage>();

            ImageList.Add(new BannerImage()
            {
                HeaderColor = Color.FromHex("#F1948A"),
                ImageName = "Image pexels-photo-257840",
                ImageUrl = ImageSource.FromUri(new Uri("https://images.pexels.com/photos/257840/pexels-photo-257840.jpeg?cs=srgb&dl=agriculture-apple-blur-257840.jpg&fm=jpg"))
            });

            ImageList.Add(new BannerImage()
            {
                HeaderColor = Color.FromHex("#00FF00"),
                ImageName = "Image pexels-photo-257840",
                ImageUrl = ImageSource.FromFile("gif4.gif")
            });

            ImageList.Add(new BannerImage()
            {
                HeaderColor = Color.FromHex("#1ABC9C"),
                ImageName = "Image pexels-photo-853199",
                ImageUrl = ImageSource.FromUri(new Uri("https://images.pexels.com/photos/853199/pexels-photo-853199.jpeg?cs=srgb&dl=4k-wallpaper-background-beautiful-853199.jpg&fm=jpg"))
            });

            ImageList.Add(new BannerImage()
            {
                HeaderColor = Color.FromHex("#1B4F72"),
                ImageName = "Image pexels-photo-462118",
                ImageUrl = ImageSource.FromUri(new Uri("https://images.pexels.com/photos/462118/pexels-photo-462118.jpeg?cs=srgb&dl=bloom-blooming-blossom-462118.jpg&fm=jpg"))
            });

            ImageList.Add(new BannerImage()
            {
                HeaderColor = Color.FromHex("#F0048A"),
                ImageName = "Image pexels-photo-257840",
                ImageUrl = ImageSource.FromFile("gif5.gif")
            });

            ImageList.Add(new BannerImage()
            {
                HeaderColor = Color.FromHex("#6E2C00"),
                ImageName = "Image waterfall-thac-dray-nur",
                ImageUrl = ImageSource.FromUri(new Uri("https://images.pexels.com/photos/68147/waterfall-thac-dray-nur-buon-me-thuot-daklak-68147.jpeg?cs=srgb&dl=hd-wallpaper-landscape-long-exposure-68147.jpg&fm=jpg"))
            });

            ImageList.Add(new BannerImage()
            {
                HeaderColor = Color.FromHex("#F4D03F"),
                ImageName = "Image pexels-photo-753626",
                ImageUrl = ImageSource.FromUri(new Uri("https://images.pexels.com/photos/753626/pexels-photo-753626.jpeg?cs=srgb&dl=beach-bora-bora-clouds-753626.jpg&fm=jpg"))
            });

            ImageList.Add(new BannerImage()
            {
                HeaderColor = Color.FromHex("#9B59B6"),
                ImageName = "Image fall-autumn-red-season",
                ImageUrl = ImageSource.FromUri(new Uri("https://images.pexels.com/photos/33109/fall-autumn-red-season.jpg?cs=srgb&dl=autumn-colorful-colourful-33109.jpg&fm=jpg"))
            });

            ImageList.Add(new BannerImage()
            {
                HeaderColor = Color.FromHex("#641E16"),
                ImageName = "Image pexels-photo-556416",
                ImageUrl = ImageSource.FromUri(new Uri("https://images.pexels.com/photos/556416/pexels-photo-556416.jpeg?cs=srgb&dl=bridge-clouds-cloudy-556416.jpg&fm=jpg"))
            });

            ImageList.Add(new BannerImage()
            {
                HeaderColor = Color.FromHex("#5B2C6F"),
                ImageName = "Image pexels-photo-1402787",
                ImageUrl = ImageSource.FromUri(new Uri("https://images.pexels.com/photos/1402787/pexels-photo-1402787.jpeg?cs=srgb&dl=4k-wallpaper-audi-audi-r8-1402787.jpg&fm=jpg"))
            });

            ImageList.Add(new BannerImage()
            {
                HeaderColor = Color.FromHex("#0E6655"),
                ImageName = "Image rose-blue-flower-rose-blooms",
                ImageUrl = ImageSource.FromUri(new Uri("https://images.pexels.com/photos/67636/rose-blue-flower-rose-blooms-67636.jpeg?cs=srgb&dl=beauty-bloom-blue-67636.jpg&fm=jpg"))
            });

            ImageList.Add(new BannerImage()
            {
                HeaderColor = Color.FromHex("#B7950B"),
                ImageName = "Image pexels-photo-443446",
                ImageUrl = ImageSource.FromUri(new Uri("https://images.pexels.com/photos/443446/pexels-photo-443446.jpeg?cs=srgb&dl=daylight-forest-glossy-443446.jpg&fm=jpg"))
            });

            ImageList.Add(new BannerImage()
            {
                HeaderColor = Color.FromHex("#D7DBDD"),
                ImageName = "Image img5",
                ImageUrl = ImageSource.FromFile("img5.jpeg")
            });

            ImageList.Add(new BannerImage()
            {
                HeaderColor = Color.FromHex("#F7DC6F"),
                ImageName = "Image img6",
                ImageUrl = ImageSource.FromFile("img6.jpg")
            });

            ImageList.Add(new BannerImage()
            {
                HeaderColor = Color.FromHex("#7DCEA0"),
                ImageName = "Image img7",
                ImageUrl = ImageSource.FromFile("img7.jpg")
            });

            ImageList.Add(new BannerImage()
            {
                HeaderColor = Color.FromHex("#7FB3D5"),
                ImageName = "Image img8",
                ImageUrl = ImageSource.FromFile("img8.jpeg")
            });

            ImageList.Add(new BannerImage()
            {
                HeaderColor = Color.FromHex("#C39BD3"),
                ImageName = "Image img9",
                ImageUrl = ImageSource.FromFile("img9.jpeg")
            });


            return ImageList;
        }

        public ObservableCollection<BannerImage> GetImageList2()
        {
            ObservableCollection<BannerImage> ImageList = new ObservableCollection<BannerImage>();

            ImageList.Add(new BannerImage()
            {
                ImageName = "Image img6",
                ImageUrl = ImageSource.FromFile("img6.jpg")
            });

            ImageList.Add(new BannerImage()
            {
                ImageName = "Image pexels-photo-753626",
                ImageUrl = ImageSource.FromUri(new Uri("https://images.pexels.com/photos/753626/pexels-photo-753626.jpeg?cs=srgb&dl=beach-bora-bora-clouds-753626.jpg&fm=jpg"))
            });

            ImageList.Add(new BannerImage()
            {
                ImageName = "Image img7",
                ImageUrl = ImageSource.FromFile("img7.jpg")
            });


            ImageList.Add(new BannerImage()
            {
                ImageName = "Image pexels-photo-257840",
                ImageUrl = ImageSource.FromUri(new Uri("https://images.pexels.com/photos/257840/pexels-photo-257840.jpeg?cs=srgb&dl=agriculture-apple-blur-257840.jpg&fm=jpg"))
            });

            ImageList.Add(new BannerImage()
            {
                ImageName = "Image img8",
                ImageUrl = ImageSource.FromFile("img8.jpeg")
            });

            ImageList.Add(new BannerImage()
            {
                ImageName = "Image pexels-photo-853199",
                ImageUrl = ImageSource.FromUri(new Uri("https://images.pexels.com/photos/853199/pexels-photo-853199.jpeg?cs=srgb&dl=4k-wallpaper-background-beautiful-853199.jpg&fm=jpg"))
            });

            ImageList.Add(new BannerImage()
            {
                ImageName = "Image pexels-photo-462118",
                ImageUrl = ImageSource.FromUri(new Uri("https://images.pexels.com/photos/462118/pexels-photo-462118.jpeg?cs=srgb&dl=bloom-blooming-blossom-462118.jpg&fm=jpg"))
            });

            ImageList.Add(new BannerImage()
            {
                ImageName = "Image waterfall-thac-dray-nur",
                ImageUrl = ImageSource.FromUri(new Uri("https://images.pexels.com/photos/68147/waterfall-thac-dray-nur-buon-me-thuot-daklak-68147.jpeg?cs=srgb&dl=hd-wallpaper-landscape-long-exposure-68147.jpg&fm=jpg"))
            });


            ImageList.Add(new BannerImage()
            {
                ImageName = "Image pexels-photo-556416",
                ImageUrl = ImageSource.FromUri(new Uri("https://images.pexels.com/photos/556416/pexels-photo-556416.jpeg?cs=srgb&dl=bridge-clouds-cloudy-556416.jpg&fm=jpg"))
            });

            ImageList.Add(new BannerImage()
            {
                ImageName = "Image fall-autumn-red-season",
                ImageUrl = ImageSource.FromUri(new Uri("https://images.pexels.com/photos/33109/fall-autumn-red-season.jpg?cs=srgb&dl=autumn-colorful-colourful-33109.jpg&fm=jpg"))
            });

            ImageList.Add(new BannerImage()
            {
                ImageName = "Image pexels-photo-1402787",
                ImageUrl = ImageSource.FromUri(new Uri("https://images.pexels.com/photos/1402787/pexels-photo-1402787.jpeg?cs=srgb&dl=4k-wallpaper-audi-audi-r8-1402787.jpg&fm=jpg"))
            });

            ImageList.Add(new BannerImage()
            {
                ImageName = "Image img9",
                ImageUrl = ImageSource.FromFile("img9.jpeg")
            });

            ImageList.Add(new BannerImage()
            {
                ImageName = "Image rose-blue-flower-rose-blooms",
                ImageUrl = ImageSource.FromUri(new Uri("https://images.pexels.com/photos/67636/rose-blue-flower-rose-blooms-67636.jpeg?cs=srgb&dl=beauty-bloom-blue-67636.jpg&fm=jpg"))
            });

            ImageList.Add(new BannerImage()
            {
                ImageName = "Image pexels-photo-443446",
                ImageUrl = ImageSource.FromUri(new Uri("https://images.pexels.com/photos/443446/pexels-photo-443446.jpeg?cs=srgb&dl=daylight-forest-glossy-443446.jpg&fm=jpg"))
            });

            ImageList.Add(new BannerImage()
            {
                ImageName = "Image img5",
                ImageUrl = ImageSource.FromFile("img5.jpeg")
            });






            return ImageList;
        }

        public ObservableCollection<BannerImage> GetImageList3()
        {
            ObservableCollection<BannerImage> ImageList = new ObservableCollection<BannerImage>();

            ImageList.Add(new BannerImage()
            {
                ImageName = "Image img7",
                ImageUrl = ImageSource.FromFile("img7.jpg")
            });

            ImageList.Add(new BannerImage()
            {
                ImageName = "Image pexels-photo-753626",
                ImageUrl = ImageSource.FromUri(new Uri("https://images.pexels.com/photos/753626/pexels-photo-753626.jpeg?cs=srgb&dl=beach-bora-bora-clouds-753626.jpg&fm=jpg"))
            });

            ImageList.Add(new BannerImage()
            {
                ImageName = "Image img6",
                ImageUrl = ImageSource.FromFile("img6.jpg")
            });

            ImageList.Add(new BannerImage()
            {
                ImageName = "Image pexels-photo-462118",
                ImageUrl = ImageSource.FromUri(new Uri("https://images.pexels.com/photos/462118/pexels-photo-462118.jpeg?cs=srgb&dl=bloom-blooming-blossom-462118.jpg&fm=jpg"))
            });

            ImageList.Add(new BannerImage()
            {
                ImageName = "Image img8",
                ImageUrl = ImageSource.FromFile("img8.jpeg")
            });


            ImageList.Add(new BannerImage()
            {
                ImageName = "Image pexels-photo-257840",
                ImageUrl = ImageSource.FromUri(new Uri("https://images.pexels.com/photos/257840/pexels-photo-257840.jpeg?cs=srgb&dl=agriculture-apple-blur-257840.jpg&fm=jpg"))
            });

            ImageList.Add(new BannerImage()
            {
                ImageName = "Image waterfall-thac-dray-nur",
                ImageUrl = ImageSource.FromUri(new Uri("https://images.pexels.com/photos/68147/waterfall-thac-dray-nur-buon-me-thuot-daklak-68147.jpeg?cs=srgb&dl=hd-wallpaper-landscape-long-exposure-68147.jpg&fm=jpg"))
            });

            ImageList.Add(new BannerImage()
            {
                ImageName = "Image fall-autumn-red-season",
                ImageUrl = ImageSource.FromUri(new Uri("https://images.pexels.com/photos/33109/fall-autumn-red-season.jpg?cs=srgb&dl=autumn-colorful-colourful-33109.jpg&fm=jpg"))
            });

            ImageList.Add(new BannerImage()
            {
                ImageName = "Image pexels-photo-1402787",
                ImageUrl = ImageSource.FromUri(new Uri("https://images.pexels.com/photos/1402787/pexels-photo-1402787.jpeg?cs=srgb&dl=4k-wallpaper-audi-audi-r8-1402787.jpg&fm=jpg"))
            });

            ImageList.Add(new BannerImage()
            {
                ImageName = "Image img9",
                ImageUrl = ImageSource.FromFile("img9.jpeg")
            });

            ImageList.Add(new BannerImage()
            {
                ImageName = "Image pexels-photo-853199",
                ImageUrl = ImageSource.FromUri(new Uri("https://images.pexels.com/photos/853199/pexels-photo-853199.jpeg?cs=srgb&dl=4k-wallpaper-background-beautiful-853199.jpg&fm=jpg"))
            });

            ImageList.Add(new BannerImage()
            {
                ImageName = "Image pexels-photo-443446",
                ImageUrl = ImageSource.FromUri(new Uri("https://images.pexels.com/photos/443446/pexels-photo-443446.jpeg?cs=srgb&dl=daylight-forest-glossy-443446.jpg&fm=jpg"))
            });

            ImageList.Add(new BannerImage()
            {
                ImageName = "Image img5",
                ImageUrl = ImageSource.FromFile("img5.jpeg")
            });

            ImageList.Add(new BannerImage()
            {
                ImageName = "Image pexels-photo-556416",
                ImageUrl = ImageSource.FromUri(new Uri("https://images.pexels.com/photos/556416/pexels-photo-556416.jpeg?cs=srgb&dl=bridge-clouds-cloudy-556416.jpg&fm=jpg"))
            });

            ImageList.Add(new BannerImage()
            {
                ImageName = "Image rose-blue-flower-rose-blooms",
                ImageUrl = ImageSource.FromUri(new Uri("https://images.pexels.com/photos/67636/rose-blue-flower-rose-blooms-67636.jpeg?cs=srgb&dl=beauty-bloom-blue-67636.jpg&fm=jpg"))
            });

            return ImageList;
        }

        public ObservableCollection<BannerImage> GetImageList4()
        {
            ObservableCollection<BannerImage> ImageList = new ObservableCollection<BannerImage>();

            ImageList.Add(new BannerImage()
            {
                ImageName = "Image rose-blue-flower-rose-blooms",
                ImageUrl = ImageSource.FromUri(new Uri("https://images.pexels.com/photos/67636/rose-blue-flower-rose-blooms-67636.jpeg?cs=srgb&dl=beauty-bloom-blue-67636.jpg&fm=jpg"))
            });

            ImageList.Add(new BannerImage()
            {
                ImageName = "Image img5",
                ImageUrl = ImageSource.FromFile("img5.jpeg")
            });


            ImageList.Add(new BannerImage()
            {
                ImageName = "Image pexels-photo-462118",
                ImageUrl = ImageSource.FromUri(new Uri("https://images.pexels.com/photos/462118/pexels-photo-462118.jpeg?cs=srgb&dl=bloom-blooming-blossom-462118.jpg&fm=jpg"))
            });

            ImageList.Add(new BannerImage()
            {
                ImageName = "Image img8",
                ImageUrl = ImageSource.FromFile("img8.jpeg")
            });


            ImageList.Add(new BannerImage()
            {
                ImageName = "Image pexels-photo-1402787",
                ImageUrl = ImageSource.FromUri(new Uri("https://images.pexels.com/photos/1402787/pexels-photo-1402787.jpeg?cs=srgb&dl=4k-wallpaper-audi-audi-r8-1402787.jpg&fm=jpg"))
            });

            ImageList.Add(new BannerImage()
            {
                ImageName = "Image img9",
                ImageUrl = ImageSource.FromFile("img9.jpeg")
            });

            ImageList.Add(new BannerImage()
            {
                ImageName = "Image pexels-photo-556416",
                ImageUrl = ImageSource.FromUri(new Uri("https://images.pexels.com/photos/556416/pexels-photo-556416.jpeg?cs=srgb&dl=bridge-clouds-cloudy-556416.jpg&fm=jpg"))
            });

            ImageList.Add(new BannerImage()
            {
                ImageName = "Image fall-autumn-red-season",
                ImageUrl = ImageSource.FromUri(new Uri("https://images.pexels.com/photos/33109/fall-autumn-red-season.jpg?cs=srgb&dl=autumn-colorful-colourful-33109.jpg&fm=jpg"))
            });

            ImageList.Add(new BannerImage()
            {
                ImageName = "Image pexels-photo-443446",
                ImageUrl = ImageSource.FromUri(new Uri("https://images.pexels.com/photos/443446/pexels-photo-443446.jpeg?cs=srgb&dl=daylight-forest-glossy-443446.jpg&fm=jpg"))
            });

            ImageList.Add(new BannerImage()
            {
                ImageName = "Image img7",
                ImageUrl = ImageSource.FromFile("img7.jpg")
            });

            ImageList.Add(new BannerImage()
            {
                ImageName = "Image pexels-photo-257840",
                ImageUrl = ImageSource.FromUri(new Uri("https://images.pexels.com/photos/257840/pexels-photo-257840.jpeg?cs=srgb&dl=agriculture-apple-blur-257840.jpg&fm=jpg"))
            });

            ImageList.Add(new BannerImage()
            {
                ImageName = "Image pexels-photo-753626",
                ImageUrl = ImageSource.FromUri(new Uri("https://images.pexels.com/photos/753626/pexels-photo-753626.jpeg?cs=srgb&dl=beach-bora-bora-clouds-753626.jpg&fm=jpg"))
            });

            ImageList.Add(new BannerImage()
            {
                ImageName = "Image waterfall-thac-dray-nur",
                ImageUrl = ImageSource.FromUri(new Uri("https://images.pexels.com/photos/68147/waterfall-thac-dray-nur-buon-me-thuot-daklak-68147.jpeg?cs=srgb&dl=hd-wallpaper-landscape-long-exposure-68147.jpg&fm=jpg"))
            });

            ImageList.Add(new BannerImage()
            {
                ImageName = "Image pexels-photo-853199",
                ImageUrl = ImageSource.FromUri(new Uri("https://images.pexels.com/photos/853199/pexels-photo-853199.jpeg?cs=srgb&dl=4k-wallpaper-background-beautiful-853199.jpg&fm=jpg"))
            });


            ImageList.Add(new BannerImage()
            {
                ImageName = "Image img6",
                ImageUrl = ImageSource.FromFile("img6.jpg")
            });

            return ImageList;
        }

        public ObservableCollection<BannerImage> GetImageList5()
        {
            ObservableCollection<BannerImage> ImageList = new ObservableCollection<BannerImage>();

            ImageList.Add(new BannerImage()
            {
                IsSquareView = true,
                ImageName = "Image pexels-photo-753626",
                ImageUrl = ImageSource.FromUri(new Uri("https://images.pexels.com/photos/753626/pexels-photo-753626.jpeg?cs=srgb&dl=beach-bora-bora-clouds-753626.jpg&fm=jpg"))
            });

            ImageList.Add(new BannerImage()
            {
                IsSquareView = false,
                ImageName = "Image waterfall-thac-dray-nur",
                ImageUrl = ImageSource.FromUri(new Uri("https://images.pexels.com/photos/68147/waterfall-thac-dray-nur-buon-me-thuot-daklak-68147.jpeg?cs=srgb&dl=hd-wallpaper-landscape-long-exposure-68147.jpg&fm=jpg"))
            });

            ImageList.Add(new BannerImage()
            {
                IsSquareView = true,
                ImageName = "Image pexels-photo-462118",
                ImageUrl = ImageSource.FromUri(new Uri("https://images.pexels.com/photos/462118/pexels-photo-462118.jpeg?cs=srgb&dl=bloom-blooming-blossom-462118.jpg&fm=jpg"))
            });

            ImageList.Add(new BannerImage()
            {
                IsSquareView = false,
                ImageName = "Image pexels-photo-853199",
                ImageUrl = ImageSource.FromUri(new Uri("https://images.pexels.com/photos/853199/pexels-photo-853199.jpeg?cs=srgb&dl=4k-wallpaper-background-beautiful-853199.jpg&fm=jpg"))
            });

            ImageList.Add(new BannerImage()
            {
                IsSquareView = true,
                ImageName = "Image rose-blue-flower-rose-blooms",
                ImageUrl = ImageSource.FromUri(new Uri("https://images.pexels.com/photos/67636/rose-blue-flower-rose-blooms-67636.jpeg?cs=srgb&dl=beauty-bloom-blue-67636.jpg&fm=jpg"))
            });

            ImageList.Add(new BannerImage()
            {
                IsSquareView = false,
                ImageName = "Image img5",
                ImageUrl = ImageSource.FromFile("img5.jpeg")
            });

            ImageList.Add(new BannerImage()
            {
                IsSquareView = true,
                ImageName = "Image img8",
                ImageUrl = ImageSource.FromFile("img8.jpeg")
            });

            ImageList.Add(new BannerImage()
            {
                IsSquareView = false,
                ImageName = "Image pexels-photo-556416",
                ImageUrl = ImageSource.FromUri(new Uri("https://images.pexels.com/photos/556416/pexels-photo-556416.jpeg?cs=srgb&dl=bridge-clouds-cloudy-556416.jpg&fm=jpg"))
            });

            ImageList.Add(new BannerImage()
            {
                IsSquareView = true,
                ImageName = "Image fall-autumn-red-season",
                ImageUrl = ImageSource.FromUri(new Uri("https://images.pexels.com/photos/33109/fall-autumn-red-season.jpg?cs=srgb&dl=autumn-colorful-colourful-33109.jpg&fm=jpg"))
            });

            ImageList.Add(new BannerImage()
            {
                IsSquareView = false,
                ImageName = "Image pexels-photo-1402787",
                ImageUrl = ImageSource.FromUri(new Uri("https://images.pexels.com/photos/1402787/pexels-photo-1402787.jpeg?cs=srgb&dl=4k-wallpaper-audi-audi-r8-1402787.jpg&fm=jpg"))
            });

            ImageList.Add(new BannerImage()
            {
                IsSquareView = true,
                ImageName = "Image img9",
                ImageUrl = ImageSource.FromFile("img9.jpeg")
            });

            ImageList.Add(new BannerImage()
            {
                IsSquareView = false,
                ImageName = "Image pexels-photo-443446",
                ImageUrl = ImageSource.FromUri(new Uri("https://images.pexels.com/photos/443446/pexels-photo-443446.jpeg?cs=srgb&dl=daylight-forest-glossy-443446.jpg&fm=jpg"))
            });

            ImageList.Add(new BannerImage()
            {
                IsSquareView = true,
                ImageName = "Image img7",
                ImageUrl = ImageSource.FromFile("img7.jpg")
            });

            ImageList.Add(new BannerImage()
            {
                IsSquareView = false,
                ImageName = "Image pexels-photo-257840",
                ImageUrl = ImageSource.FromUri(new Uri("https://images.pexels.com/photos/257840/pexels-photo-257840.jpeg?cs=srgb&dl=agriculture-apple-blur-257840.jpg&fm=jpg"))
            });

            ImageList.Add(new BannerImage()
            {
                IsSquareView = true,
                ImageName = "Image img6",
                ImageUrl = ImageSource.FromFile("img6.jpg")
            });

            return ImageList;
        }

        public ObservableCollection<BannerImage> GetImageList6()
        {
            ObservableCollection<BannerImage> ImageList = new ObservableCollection<BannerImage>();

            ImageList.Add(new BannerImage()
            {
                IsSquareView = false,
                ImageName = "Image pexels-photo-1402787",
                ImageUrl = ImageSource.FromUri(new Uri("https://images.pexels.com/photos/1402787/pexels-photo-1402787.jpeg?cs=srgb&dl=4k-wallpaper-audi-audi-r8-1402787.jpg&fm=jpg"))
            });

            ImageList.Add(new BannerImage()
            {
                IsSquareView = true,
                ImageName = "Image pexels-photo-753626",
                ImageUrl = ImageSource.FromUri(new Uri("https://images.pexels.com/photos/753626/pexels-photo-753626.jpeg?cs=srgb&dl=beach-bora-bora-clouds-753626.jpg&fm=jpg"))
            });

            ImageList.Add(new BannerImage()
            {
                IsSquareView = false,
                ImageName = "Image waterfall-thac-dray-nur",
                ImageUrl = ImageSource.FromUri(new Uri("https://images.pexels.com/photos/68147/waterfall-thac-dray-nur-buon-me-thuot-daklak-68147.jpeg?cs=srgb&dl=hd-wallpaper-landscape-long-exposure-68147.jpg&fm=jpg"))
            });


            ImageList.Add(new BannerImage()
            {
                IsSquareView = true,
                ImageName = "Image img9",
                ImageUrl = ImageSource.FromFile("img9.jpeg")
            });

            ImageList.Add(new BannerImage()
            {
                IsSquareView = false,
                ImageName = "Image pexels-photo-443446",
                ImageUrl = ImageSource.FromUri(new Uri("https://images.pexels.com/photos/443446/pexels-photo-443446.jpeg?cs=srgb&dl=daylight-forest-glossy-443446.jpg&fm=jpg"))
            });

           
            ImageList.Add(new BannerImage()
            {
                IsSquareView = true,
                ImageName = "Image pexels-photo-462118",
                ImageUrl = ImageSource.FromUri(new Uri("https://images.pexels.com/photos/462118/pexels-photo-462118.jpeg?cs=srgb&dl=bloom-blooming-blossom-462118.jpg&fm=jpg"))
            });

            ImageList.Add(new BannerImage()
            {
                IsSquareView = false,
                ImageName = "Image pexels-photo-853199",
                ImageUrl = ImageSource.FromUri(new Uri("https://images.pexels.com/photos/853199/pexels-photo-853199.jpeg?cs=srgb&dl=4k-wallpaper-background-beautiful-853199.jpg&fm=jpg"))
            });

            ImageList.Add(new BannerImage()
            {
                IsSquareView = true,
                ImageName = "Image rose-blue-flower-rose-blooms",
                ImageUrl = ImageSource.FromUri(new Uri("https://images.pexels.com/photos/67636/rose-blue-flower-rose-blooms-67636.jpeg?cs=srgb&dl=beauty-bloom-blue-67636.jpg&fm=jpg"))
            });

            ImageList.Add(new BannerImage()
            {
                IsSquareView = false,
                ImageName = "Image img5",
                ImageUrl = ImageSource.FromFile("img5.jpeg")
            });

            ImageList.Add(new BannerImage()
            {
                IsSquareView = true,
                ImageName = "Image img8",
                ImageUrl = ImageSource.FromFile("img8.jpeg")
            });

            ImageList.Add(new BannerImage()
            {
                IsSquareView = false,
                ImageName = "Image pexels-photo-556416",
                ImageUrl = ImageSource.FromUri(new Uri("https://images.pexels.com/photos/556416/pexels-photo-556416.jpeg?cs=srgb&dl=bridge-clouds-cloudy-556416.jpg&fm=jpg"))
            });

            ImageList.Add(new BannerImage()
            {
                IsSquareView = true,
                ImageName = "Image fall-autumn-red-season",
                ImageUrl = ImageSource.FromUri(new Uri("https://images.pexels.com/photos/33109/fall-autumn-red-season.jpg?cs=srgb&dl=autumn-colorful-colourful-33109.jpg&fm=jpg"))
            });

            

            ImageList.Add(new BannerImage()
            {
                IsSquareView = true,
                ImageName = "Image img7",
                ImageUrl = ImageSource.FromFile("img7.jpg")
            });

            ImageList.Add(new BannerImage()
            {
                IsSquareView = false,
                ImageName = "Image pexels-photo-257840",
                ImageUrl = ImageSource.FromUri(new Uri("https://images.pexels.com/photos/257840/pexels-photo-257840.jpeg?cs=srgb&dl=agriculture-apple-blur-257840.jpg&fm=jpg"))
            });

            ImageList.Add(new BannerImage()
            {
                IsSquareView = true,
                ImageName = "Image img6",
                ImageUrl = ImageSource.FromFile("img6.jpg")
            });

            return ImageList;
        }
    }
}
