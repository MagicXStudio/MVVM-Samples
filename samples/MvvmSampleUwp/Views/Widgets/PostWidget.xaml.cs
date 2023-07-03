using CommunityToolkit.Mvvm.DependencyInjection;
using MvvmSample.Core.ViewModels.Widgets;
using Windows.UI.Xaml.Controls;

namespace MvvmSampleUwp.Views.Widgets;

public sealed partial class PostWidget : UserControl
{
    public PostWidget()
    {
        this.InitializeComponent();

        DataContext = Ioc.Default.GetRequiredService<PostWidgetViewModel>();

        this.Loaded += (s, e) => ViewModel.IsActive = true;
        this.Unloaded += (s, e) => ViewModel.IsActive = false;
    }

    /// <summary>
    /// 
    /// </summary>
    public PostWidgetViewModel ViewModel => (PostWidgetViewModel)DataContext;
}
