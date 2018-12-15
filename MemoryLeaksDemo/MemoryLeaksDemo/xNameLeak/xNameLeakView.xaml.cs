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
            {
                // TODO: вызывать UnregisterName для всех элементов UI, имеющих атрибут x:Name
                UnregisterName("LeakyButton");
            }
        }
    }
}