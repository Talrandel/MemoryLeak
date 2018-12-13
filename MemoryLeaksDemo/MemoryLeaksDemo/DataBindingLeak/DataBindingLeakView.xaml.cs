using MemoryLeaksDemo.Infrastructure;
using System;
using System.Windows.Controls;
using System.Windows.Data;

namespace MemoryLeaksDemo.DataBindingLeak
{
    public partial class DataBindingLeakView
    {
        private HeavyObject _heavyObject = new HeavyObject();

        public DataBindingLeakView()
        {
            InitializeComponent();
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            if (RepairLeakCheckBox.IsChecked == true)
                BindingOperations.ClearBinding(SampleTextBlock, TextBlock.TextProperty);
        }
    }
}