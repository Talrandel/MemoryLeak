using GalaSoft.MvvmLight;

namespace MemoryLeaksDemo.BindingLeak
{
    class PersonNormal : ObservableObject
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { Set(ref _name, value); }
        }
    }
}