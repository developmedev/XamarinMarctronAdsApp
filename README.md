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




## License
[MIT] Developmedev Solutions
