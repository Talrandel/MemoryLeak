using System.Windows;

namespace MemoryLeaksDemo.BindingLeak
{
    public partial class BindingLeakView : Window
    {
        public BindingLeakView()
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