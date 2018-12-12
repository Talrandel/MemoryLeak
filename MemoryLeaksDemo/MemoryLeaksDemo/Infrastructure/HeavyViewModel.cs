using GalaSoft.MvvmLight;

namespace MemoryLeaksDemo.Infrastructure
{
    class HeavyViewModel : ViewModelBase
    {
        private readonly byte[] _trash = new byte[50 * 1024 * 1024];
    }
}
