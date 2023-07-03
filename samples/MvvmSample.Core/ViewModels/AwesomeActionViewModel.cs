using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Threading.Tasks;

namespace MvvmSample.Core.ViewModels
{
    public partial class AwesomeActionViewModel : ObservableObject
    {
        public AwesomeActionViewModel()
        {

        }

        [RelayCommand]
        public void InitAsync()
        {
        }

        [RelayCommand]
        public void CopyAsync()
        {
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [RelayCommand]
        public void ClipboardAsync()
        {
        }

        [RelayCommand]
        public void GraphicsAsync()
        {
        }
    }
}
