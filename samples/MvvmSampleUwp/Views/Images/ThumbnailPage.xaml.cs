using CommunityToolkit.Mvvm.DependencyInjection;
using MvvmSample.Core.ViewModels;
using Windows.UI.Xaml.Controls;

// https://go.microsoft.com/fwlink/?LinkId=234238 上介绍了“空白页”项模板

namespace MediaPlayer.Views.Images
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class ThumbnailViewPage : Page
    {
        public ThumbnailViewPage()
        {
            this.InitializeComponent();
            DataContext = Ioc.Default.GetRequiredService<ThumbnailViewModel>();
        }
        public ThumbnailViewModel ViewModel => (ThumbnailViewModel)DataContext;
    }
}
