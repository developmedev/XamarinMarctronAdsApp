using Xamarin.Forms;
using XamarinMarctronAdsApp.Models;
using XamarinMarctronAdsApp.ViewModels;

namespace XamarinMarctronAdsApp.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}