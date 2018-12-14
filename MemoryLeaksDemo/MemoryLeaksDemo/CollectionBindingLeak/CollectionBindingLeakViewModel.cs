using GalaSoft.MvvmLight.Command;
using MemoryLeaksDemo.Infrastructure;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace MemoryLeaksDemo.CollectionBindingLeak
{
    class CollectionBindingLeakViewModel : HeavyViewModel
    {
        private List<SampleItem> _items;
        public List<SampleItem> Items
        {
            get { return _items; }
            set { Set(ref _items, value); }
        }

        //private ObservableCollection<SampleItem> _items;
        //public ObservableCollection<SampleItem> Items
        //{
        //    get { return _items; }
        //    set { Set(ref _items, value); }
        //}

        public CollectionBindingLeakViewModel()
        {
            Items = new List<SampleItem>()
            //Items = new ObservableCollection<SampleItem>()
            {
                new SampleItem { SampleProperty = "One" },
                new SampleItem { SampleProperty = "Two" },
                new SampleItem { SampleProperty = "Three" }
            };

            AddItemCommand = new RelayCommand(AddItem);
        }

        private void AddItem()
        {
            Items.Add(new SampleItem { SampleProperty = "New value" });
        }

        public ICommand AddItemCommand { get; }
    }
}