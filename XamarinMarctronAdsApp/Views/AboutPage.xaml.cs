using MarcTron.Plugin;
using System;
using System.ComponentModel;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinMarctronAdsApp.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
            MainThread.BeginInvokeOnMainThread(async() => {
               await Task.Delay(10000);
                myAds.IsVisible = true;

            });
            CrossMTAdmob.Current.LoadRewardedVideo("ca-app-pub-3940256099942544/5224354917");
        }
        public int count { get; set; }
        private void Button_Clicked(object sender, EventArgs e)
        {
            //myAds.IsVisible = false;

            var test = CrossMTAdmob.Current.IsRewardedVideoLoaded().ToString();
            CrossMTAdmob.Current.ShowRewardedVideo();
            CrossMTAdmob.Current.LoadRewardedVideo("ca-app-pub-3940256099942544/5224354917");
            count++;
            Test.Text = count.ToString();
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            myAds.IsVisible = true;
        }
    }
}