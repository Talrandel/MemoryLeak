using MemoryLeaksDemo.Infrastructure;
using System;

namespace MemoryLeaksDemo.xNameLeak
{
    public partial class xNameLeakView
    {
        private HeavyObject _heavyObject = new HeavyObject();

        public xNameLeakView()
        {
            InitializeComponent();
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            if (RepairLeakCheckBox.IsChecked == true)
                UnregisterName("LeakyButton");
        }
    }
}