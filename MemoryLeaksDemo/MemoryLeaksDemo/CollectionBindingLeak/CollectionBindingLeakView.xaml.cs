using MemoryLeaksDemo.Infrastructure;

namespace MemoryLeaksDemo.CollectionBindingLeak
{
    public partial class CollectionBindingLeakView
    {
        private HeavyObject _heavyObject = new HeavyObject();

        public CollectionBindingLeakView()
        {
            InitializeComponent();
            DataContext = new CollectionBindingLeakViewModel();
        }
    }
}