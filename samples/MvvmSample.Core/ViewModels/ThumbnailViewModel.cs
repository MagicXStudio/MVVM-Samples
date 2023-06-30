using CommunityToolkit.Mvvm.Collections;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MvvmSample.Core.Models;
using System.Linq;
using System.Threading.Tasks;

namespace MvvmSample.Core.ViewModels
{
    public partial class ThumbnailViewModel : ObservableObject
    {
        public ThumbnailViewModel()
        {
            Items = new ObservableGroupedCollection<string, ThumbnailItem>();
            foreach (var item in Enumerable.Range(0, 100))
            {
                var group = new ObservableGroup<string, ThumbnailItem>($"{item}") { new ThumbnailItem() { Name = $"{item * item}" } };
                Items.Add(group);
            }
        }

        public ObservableGroupedCollection<string, ThumbnailItem> Items { get; private set; }

        [RelayCommand]
        public async Task GetMoreItemsAsync()
        {
            await Task.CompletedTask;
        }

        [RelayCommand]
        private async Task ViewAsync()
        {
            await Task.CompletedTask;
        }

        [RelayCommand]
        private async Task EditAsync()
        {
            await Task.CompletedTask;
        }

        [RelayCommand]
        private async Task DeleteAsync()
        {
            await Task.CompletedTask;
        }
        [RelayCommand]
        private async Task AddAsync()
        {
            await Task.CompletedTask;
        }
    }
}
