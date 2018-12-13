using System;
using System.Windows.Controls;
using System.Windows.Data;

namespace MemoryLeaksDemo.DataBindingLeak
{
    public partial class DataBindingLeakView
    {
        public DataBindingLeakView()
        {
            InitializeComponent();
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            // IsChecked = bool?
            if (RepairLeakCheckBox.IsChecked == true)
                BindingOperations.ClearBinding(SampleTextBlock, TextBlock.TextProperty);
        }
    }
}