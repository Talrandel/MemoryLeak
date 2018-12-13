using GalaSoft.MvvmLight;

namespace MemoryLeaksDemo.CollectionBindingLeak
{
    class SampleItem : ObservableObject
    {
        private string _sampleProperty;

        public string SampleProperty
        {
            get { return _sampleProperty; }
            set { Set(ref _sampleProperty, value); }
        }
    }
}