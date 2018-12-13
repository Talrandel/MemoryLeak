using MemoryLeaksDemo.ViewModel;

namespace MemoryLeaksDemo
{
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
            MainWindowInstance = this;
        }

        public static MainWindow MainWindowInstance { get; private set; }
    }
}