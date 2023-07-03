using CommunityToolkit.Mvvm.DependencyInjection;
using MvvmSample.Core.ViewModels;
using Windows.UI.Xaml.Controls;

namespace MvvmSampleUwp.Views;

/// <summary>
/// An empty page that can be used on its own or navigated to within a Frame.
/// </summary>
public sealed partial class BuildingTheUIPage : Page
{
    public BuildingTheUIPage()
    {
        this.InitializeComponent();
        DataContext = Ioc.Default.GetRequiredService<AwesomeActionViewModel>();
    }

    public AwesomeActionViewModel ViewModel => (AwesomeActionViewModel)DataContext;
}
