using Xamarin.Forms;
using XamarinMarctronAdsApp.ViewModels;

namespace XamarinMarctronAdsApp.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}