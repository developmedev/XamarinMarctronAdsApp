# XamarinMarctronAdsApp
For Youtube user to build on
Banner ads

step 1 :
<meta-data android:name="com.google.android.gms.ads.APPLICATION_ID" android:value="ca-app-pub-2000687856046168~7738412697"></meta-data>
step 2 :
xmlns:controls="clr-namespace:MarcTron.Plugin.Controls;assembly=Plugin.MtAdmob"
step 3 :
<StackLayout HorizontalOptions="EndAndExpand">
<controls:MTAdView x:Name="myAds" IsVisible="true" PersonalizedAds="true" AdsId="ca-app-pub-2000687856046168/5428137648" VerticalOptions="EndAndExpand" >
                    <controls:MTAdView.HeightRequest>
                        <x:OnIdiom>
                            <x:OnIdiom.Phone>50</x:OnIdiom.Phone>
                            <x:OnIdiom.Tablet>90</x:OnIdiom.Tablet>
                            <x:OnIdiom.Desktop>90</x:OnIdiom.Desktop>
                        </x:OnIdiom>
                    </controls:MTAdView.HeightRequest>
                </controls:MTAdView>
            </StackLayout>

Reward Ads
Step 1 : 
CrossMTAdmob.Current.LoadRewardedVideo("ca-app-pub-2000687856046168/6772815386");

Step 2 :
 var test = CrossMTAdmob.Current.IsRewardedVideoLoaded().ToString();
                CrossMTAdmob.Current.ShowRewardedVideo();
                CrossMTAdmob.Current.LoadRewardedVideo("ca-app-pub-2000687856046168/6772815386");
