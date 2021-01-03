using MarcTron.Plugin;
using MarcTron.Plugin.CustomEventArgs;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinMarctronAdsApp.Views
{
    public partial class AboutPage : ContentPage
    {
        int reward = 0;
        private bool _shouldSetEvents = true;
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
            //CrossMTAdmob.Current.LoadRewardedVideo("ca-app-pub-3940256099942544/5224354917");
            SetEvents();

            //count++;
            //Test.Text = count.ToString();
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
        }
        void SetEvents()
        {
            if (_shouldSetEvents)
            {
                _shouldSetEvents = false;
                CrossMTAdmob.Current.OnRewardedVideoStarted += Current_OnRewardedVideoStarted;
                CrossMTAdmob.Current.OnRewarded += Current_OnRewarded;
                CrossMTAdmob.Current.OnRewardedVideoAdClosed += Current_OnRewardedVideoAdClosed;
                CrossMTAdmob.Current.OnRewardedVideoAdFailedToLoad += Current_OnRewardedVideoAdFailedToLoad;
                CrossMTAdmob.Current.OnRewardedVideoAdLeftApplication += Current_OnRewardedVideoAdLeftApplication;
                CrossMTAdmob.Current.OnRewardedVideoAdLoaded += Current_OnRewardedVideoAdLoaded;
                CrossMTAdmob.Current.OnRewardedVideoAdOpened += Current_OnRewardedVideoAdOpened;
                CrossMTAdmob.Current.OnRewardedVideoAdCompleted += Current_OnRewardedVideoAdCompleted;

                //CrossMTAdmob.Current.OnInterstitialLoaded += Current_OnInterstitialLoaded;
                //CrossMTAdmob.Current.OnInterstitialOpened += Current_OnInterstitialOpened;
                //CrossMTAdmob.Current.OnInterstitialClosed += Current_OnInterstitialClosed;
            }
        }

        private void DisableEvents()
        {
            _shouldSetEvents = true;
            CrossMTAdmob.Current.OnRewardedVideoStarted -= Current_OnRewardedVideoStarted;
            CrossMTAdmob.Current.OnRewarded -= Current_OnRewarded;
            CrossMTAdmob.Current.OnRewardedVideoAdClosed -= Current_OnRewardedVideoAdClosed;
            CrossMTAdmob.Current.OnRewardedVideoAdFailedToLoad -= Current_OnRewardedVideoAdFailedToLoad;
            CrossMTAdmob.Current.OnRewardedVideoAdLeftApplication -= Current_OnRewardedVideoAdLeftApplication;
            CrossMTAdmob.Current.OnRewardedVideoAdLoaded -= Current_OnRewardedVideoAdLoaded;
            CrossMTAdmob.Current.OnRewardedVideoAdOpened -= Current_OnRewardedVideoAdOpened;

            //CrossMTAdmob.Current.OnInterstitialLoaded -= Current_OnInterstitialLoaded;
            //CrossMTAdmob.Current.OnInterstitialOpened -= Current_OnInterstitialOpened;
            //CrossMTAdmob.Current.OnInterstitialClosed -= Current_OnInterstitialClosed;
        }
        private void Current_OnInterstitialClosed(object sender, EventArgs e)
        {
            Debug.WriteLine("OnInterstitialClosed");
        }

        private void Current_OnInterstitialOpened(object sender, EventArgs e)
        {
            Debug.WriteLine("OnInterstitialOpened");
        }

        private void Current_OnInterstitialLoaded(object sender, EventArgs e)
        {
            Debug.WriteLine("OnInterstitialLoaded");
        }

        private void Current_OnRewardedVideoAdOpened(object sender, EventArgs e)
        {
            Debug.WriteLine("OnRewardedVideoAdOpened");
        }

        private void Current_OnRewardedVideoAdLoaded(object sender, EventArgs e)
        {
            Debug.WriteLine("OnRewardedVideoAdLoaded");
        }

        private void Current_OnRewardedVideoAdLeftApplication(object sender, EventArgs e)
        {
            Debug.WriteLine("OnRewardedVideoAdLeftApplication");
        }

        private void Current_OnRewardedVideoAdFailedToLoad(object sender, MTEventArgs e)
        {
            Debug.WriteLine("OnRewardedVideoAdFailedToLoad");
        }

        private void Current_OnRewardedVideoAdClosed(object sender, EventArgs e)
        {
            CrossMTAdmob.Current.LoadRewardedVideo("ca-app-pub-2000687856046168/8183902079");
            var test = CrossMTAdmob.Current.IsRewardedVideoLoaded().ToString();
        }



        private void Current_OnRewarded(object sender, MTEventArgs e)
        {
            Debug.WriteLine($"OnRewarded: {e.RewardType} - {e.RewardAmount}");
            reward = reward + e.RewardAmount;
            Test.Text = "Reward Points : " + reward;
            //Downloads.Text = reward.ToString();
        }

        private void Current_OnRewardedVideoStarted(object sender, EventArgs e)
        {
            Debug.WriteLine("OnRewardedVideoStarted");
        }

        private void Current_OnRewardedVideoAdCompleted(object sender, EventArgs e)
        {
            Debug.WriteLine("OnRewardedVideoAdCompleted");
        }

        private void MyAds_AdVOpened(object sender, EventArgs e)
        {
            Console.WriteLine("MyAds_AdVOpened");
        }

        private void MyAds_AdVImpression(object sender, EventArgs e)
        {
            Console.WriteLine("MyAds_AdVImpression");
        }

        private void MyAds_AdVClosed(object sender, EventArgs e)
        {
            Console.WriteLine("MyAds_AdVClosed");
        }

        private void MyAdsAdsClicked(object sender, EventArgs e)
        {
            Console.WriteLine("MyAdsAdsClicked");
        }

        private void LoadReward_OnClicked(object sender, EventArgs e)
        {
            CrossMTAdmob.Current.LoadRewardedVideo("ca-app-pub-2000687856046168/8183902079");
        }

        private void ShowReward_OnClicked(object sender, EventArgs e)
        {
            var test = CrossMTAdmob.Current.IsRewardedVideoLoaded().ToString();
            CrossMTAdmob.Current.LoadRewardedVideo("ca-app-pub-2000687856046168/8183902079");
            CrossMTAdmob.Current.ShowRewardedVideo();
        }

        private void IsRewardLoaded_OnClicked(object sender, EventArgs e)
        {
            var test = CrossMTAdmob.Current.IsRewardedVideoLoaded().ToString();
        }

        private void LoadInterstitial_OnClicked(object sender, EventArgs e)
        {
            CrossMTAdmob.Current.LoadInterstitial("ca-app-pub-3940256099942544/1033173712");
        }

        private void ShowInterstitial_OnClicked(object sender, EventArgs e)
        {
            CrossMTAdmob.Current.ShowInterstitial();
        }

        private void IsLoadedInterstitial_OnClicked(object sender, EventArgs e)
        {
            var test = CrossMTAdmob.Current.IsInterstitialLoaded().ToString();
        }

        private void NextPage(object sender, EventArgs e)
        {
            DisableEvents();
            //Navigation.PushAsync(new SecondPage());
        }

    }
}