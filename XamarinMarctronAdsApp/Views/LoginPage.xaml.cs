using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinMarctronAdsApp.ViewModels;

namespace XamarinMarctronAdsApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            this.BindingContext = new LoginViewModel();
        }
    }
}