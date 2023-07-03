using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Windows.UI.Xaml.Media.Imaging;

namespace MvvmSample.Core.ViewModels
{
    public partial class RayTracerViewModel : ObservableObject
    {
        public RayTracerViewModel()
        {

        }

        [RelayCommand]
        private void InitAsync()
        {


        }

        public BitmapImage Source { get; set; }

        [RelayCommand]
        private void StarAsync()
        {


        }

        [RelayCommand]
        private void StopAsync()
        {


        }
    }
}
