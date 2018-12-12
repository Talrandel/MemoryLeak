using System;
using System.Windows;

namespace MemoryLeaksDemo.xNameLeak
{
    /// <summary>
    /// Interaction logic for xNameLeakView.xaml
    /// </summary>
    public partial class xNameLeakView : Window
    {
        public xNameLeakView()
        {
            InitializeComponent();
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            UnregisterName("LeakyButton");
        }
    }
}