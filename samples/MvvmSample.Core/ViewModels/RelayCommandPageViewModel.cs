using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Input;
using CommunityToolkit.Mvvm.Input;
using MvvmSample.Core.Services;

namespace MvvmSample.Core.ViewModels;

public class RelayCommandPageViewModel : SamplePageViewModel
{
    public RelayCommandPageViewModel(IFilesService filesService)
        : base(filesService)
    {
        IncrementCounterCommand = new RelayCommand(IncrementCounter);
        GetFilesCommand = new AsyncRelayCommand(GetFiles);
    }

    /// <summary>
    /// Gets the <see cref="ICommand"/> responsible for incrementing <see cref="Counter"/>.
    /// </summary>
    public ICommand IncrementCounterCommand { get; }

    public ICommand GetFilesCommand { get; }

    private int counter;

    /// <summary>
    /// Gets the current value of the counter.
    /// </summary>
    public int Counter
    {
        get => counter;
        private set => SetProperty(ref counter, value);
    }

    /// <summary>
    /// Increments <see cref="Counter"/>.
    /// </summary>
    private void IncrementCounter() => Counter++;

    private Task<string[]> GetFiles() => Task.FromResult(Directory.GetFiles(Environment.CurrentDirectory));
}
