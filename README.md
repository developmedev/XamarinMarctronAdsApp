# Banner ads


## step 1 :

Add to manifest
```
<meta-data android:name="com.google.android.gms.ads.APPLICATION_ID" android:value="ca-app-pub-xxxxxxx~xxxxxx"></meta-data>
```


## step 2

Add to xaml reference

```
xmlns:controls="clr-namespace:MarcTron.Plugin.Controls;assembly=Plugin.MtAdmob"

```


## step3
Add this control in xaml
```
<StackLayout HorizontalOptions="EndAndExpand">
<controls:MTAdView x:Name="myAds" IsVisible="true" PersonalizedAds="true" AdsId="ca-app-pub-xxxxxxxxxx/xxxxxxxxx" VerticalOptions="EndAndExpand" >
                    <controls:MTAdView.HeightRequest>
                        <x:OnIdiom>
                            <x:OnIdiom.Phone>50</x:OnIdiom.Phone>
                            <x:OnIdiom.Tablet>90</x:OnIdiom.Tablet>
                            <x:OnIdiom.Desktop>90</x:OnIdiom.Desktop>
                        </x:OnIdiom>
                    </controls:MTAdView.HeightRequest>
                </controls:MTAdView>
            </StackLayout>

```
# Reward ads


## step 1 :

Add to constructor of the code behind or viewmodel
```

CrossMTAdmob.Current.LoadRewardedVideo("ca-app-pub-xxxxxxxxxx/xxxxxxx");
```


## step 2

Add behind button event to show ad

```
var test = CrossMTAdmob.Current.IsRewardedVideoLoaded().ToString();
                CrossMTAdmob.Current.ShowRewardedVideo();
                CrossMTAdmob.Current.LoadRewardedVideo("ca-app-pub-2000687856046168/6772815386");
```
# Reward ads events
Copy and paste events below
```
 int reward = 0;
private bool _shouldSetEvents = true;
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
            CrossMTAdmob.Current.LoadRewardedVideo("ca-app-pub-xxxxxxxxxxx/xxxxxxxx");
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
            CrossMTAdmob.Current.LoadRewardedVideo("ca-app-pub-xxxxxxxxxx/xxxxxxxxxx");
        }

        private void ShowReward_OnClicked(object sender, EventArgs e)
        {
            var test = CrossMTAdmob.Current.IsRewardedVideoLoaded().ToString();
            CrossMTAdmob.Current.LoadRewardedVideo("ca-app-pub-xxxxxxxxxx/xxxxxxxxxx");
            CrossMTAdmob.Current.ShowRewardedVideo();
        }

        private void IsRewardLoaded_OnClicked(object sender, EventArgs e)
        {
            var test = CrossMTAdmob.Current.IsRewardedVideoLoaded().ToString();
        }

        private void LoadInterstitial_OnClicked(object sender, EventArgs e)
        {
            CrossMTAdmob.Current.LoadInterstitial("ca-app-pub-xxxxxxxxx/xxxxxxxxxxxxxx");
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
```



## License
[MIT] Developmedev Solutions
