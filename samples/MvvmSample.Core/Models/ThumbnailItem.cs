using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Threading.Tasks;

namespace MvvmSample.Core.Models
{
    public partial class ThumbnailItem : ObservableObject
    {
        public ThumbnailItem()
        {
        }
        public string Name { get; set; }

        public Picture Picture { get; set; }

        public string Email { get; set; }


        [RelayCommand]
        public async Task ShowAsync()
        {
            await Task.CompletedTask;
        }
    }
}
