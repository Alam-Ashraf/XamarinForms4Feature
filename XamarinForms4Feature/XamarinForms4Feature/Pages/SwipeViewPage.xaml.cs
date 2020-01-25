using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinForms4Feature.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SwipeViewPage : ContentPage
    {
        public SwipeViewPage()
        {
            InitializeComponent();
        }


        private void OnFacebookClick(object sender, EventArgs e)
        {
            //DisplayAlert("", "Facebook clicked !!", "Ok");
        }

        private void OnLinkedinClick(object sender, EventArgs e)
        {
            //DisplayAlert("", "Linkedin clicked !!", "Ok");
        }
    }
}