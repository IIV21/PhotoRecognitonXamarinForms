using PhotoRecognitonXamarinForms.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            FullScreenImage.IsVisible = true;
        }
    }
}