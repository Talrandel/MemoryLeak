using System.Windows;

namespace MemoryLeaksDemo.BindingLeak
{
    public partial class BindingLeakWindow : Window
    {
        public BindingLeakWindow()
        {
            InitializeComponent();
            DataContext = new BindingLeakViewModel();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}