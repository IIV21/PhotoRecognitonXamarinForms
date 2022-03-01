using PhotoRecognitonXamarinForms.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PhotoRecognitonXamarinForms.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PhotoRecognitionMainPage : ContentPage
    {
        public PhotoRecognitionMainPage()
        {
            InitializeComponent();
            BindingContext = new PhotoRecognitionViewModel();
        }
    }
}