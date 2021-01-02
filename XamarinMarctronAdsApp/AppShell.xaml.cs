using System;
using System.Collections.Generic;
using Xamarin.Forms;
using XamarinMarctronAdsApp.ViewModels;
using XamarinMarctronAdsApp.Views;

namespace XamarinMarctronAdsApp
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
