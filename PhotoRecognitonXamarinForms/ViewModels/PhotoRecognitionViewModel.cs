using PhotoRecognition.ViewModels;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace PhotoRecognitonXamarinForms.ViewModels
{
    internal class PhotoRecognitionViewModel : BaseViewModel
    {
        public new ICommand PickPhoto { get; set; }
        public new ICommand TakePhoto { get; set; }
        public new ImageSource Image { get; set; }
        public new DetailsModel Items { get; set; }
        public string Description { get; set; }
        public bool IsLoading { get; set; }

        public PhotoRecognitionViewModel()
        {
            PickPhoto = new Command(async () => // alege o fotografie si apeleaza api
            {
                var result = await MediaPicker.PickPhotoAsync(new MediaPickerOptions());
                if (result != null)
                {
                    UpdateDescription();
                    IsLoading = true;
                    OnPropertyChanged(nameof(IsLoading));

                    var stream = await result.OpenReadAsync();
                    Image = ImageSource.FromStream(() => stream);
                    OnPropertyChanged(nameof(Image));

                    Services.ComputerVisionAzureService service = new Services.ComputerVisionAzureService();
                    Items = await service.AnalyzeFromStreamAsync(result.FullPath.ToString());
                    getImportantData();

                    IsLoading = false;
                    OnPropertyChanged(nameof(IsLoading));
                }
            });
            TakePhoto = new Command(async () =>  // face fotografie, o trimite la api
            {
                var result = await MediaPicker.CapturePhotoAsync();

                if (result != null)
                {
                    UpdateDescription();
                    IsLoading = true;
                    OnPropertyChanged(nameof(IsLoading));

                    var stream = await result.OpenReadAsync();
                    Image = ImageSource.FromStream(() => stream);
                    OnPropertyChanged(nameof(Image));

                    Services.ComputerVisionAzureService service = new Services.ComputerVisionAzureService();
                    Items = await service.AnalyzeFromStreamAsync(result.FullPath.ToString());
                    getImportantData();

                    IsLoading = false;
                    OnPropertyChanged(nameof(IsLoading));
                }
            });

            void getImportantData() // preia data intr-un format famili frendly
            {
                Description = "Description: " + Items.Description.Captions[0].Text + "\n\n";
                Description += "Tags: \n\t";
                foreach (string tag in Items.Description.Tags)
                    Description += tag + ",\n\t";
                foreach (Tag tag in Items.Tags)
                    Description += tag.Name.ToString() + ",\n\t";

                OnPropertyChanged(nameof(Description));
            }

            void UpdateDescription()  // sterge descrierea cat timp se incarca urmatoarea poza aleasa
            {
                Description = "";
                OnPropertyChanged(nameof(Description));
            }
        }
    }
}
