using MemoryLeaksDemo.Infrastructure;
using System;
using System.Windows;
using System.Windows.Threading;

namespace MemoryLeaksDemo.DispatcherTimerLeak
{
    public partial class DispatcherTimerLeakView
    {
        private HeavyObject _heavyObject = new HeavyObject();
        private DispatcherTimer _timer;

        public DispatcherTimerLeakView()
        {
            InitializeComponent();
            _timer = new DispatcherTimer();
            _timer.Interval = new TimeSpan(0, 0, 0, 1);
            _timer.Tick += _timer_Tick;
            _timer.Start();
        }

        private void _timer_Tick(object sender, EventArgs e)
        {
            SampleTextBlock.Text = DateTime.Now.ToLongTimeString();
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            if (RepairLeakCheckBox.IsChecked == true)
            {
                _timer.Stop();
                _timer.Tick -= _timer_Tick;
            }
        }
    }
}