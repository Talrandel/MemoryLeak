using GalaSoft.MvvmLight;
using System.Windows.Input;

namespace MemoryLeaksDemo.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private string _totalMemory;

        public MainViewModel()
        {
            BindingLeakCommand = new DelegateCommand
        }

        public string TotalMemory
        {
            get { return _totalMemory; }
            set { Set(ref _totalMemory, value); }
        }

        private void BindingLeak()
        {

        }

        public ICommand BindingLeakCommand { get; }
    }
}