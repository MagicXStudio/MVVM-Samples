using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MvvmSample.Core.Services;
using System;
using System.Threading.Tasks;

namespace MvvmSample.Core.ViewModels;

public partial class CollectionsPageViewModel : ObservableObject
{
    private IFilesService FilesServices { get; }

    public CollectionsPageViewModel(IFilesService filesService)
    {
        FilesServices = filesService;
        OpenFileCommand = new AsyncRelayCommand<string>(OpenFileAsync);
    }

    public IAsyncRelayCommand<string> OpenFileCommand { get; }

    private async Task OpenFileAsync(string? name)
    {
        await Task.FromResult(Environment.CurrentDirectory);
    }
}
