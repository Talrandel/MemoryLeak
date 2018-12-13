using MemoryLeaksDemo.Infrastructure;
using System.Windows;
using System;
using System.Windows.Controls;

namespace MemoryLeaksDemo.EventHandlerLeak
{
    public partial class EventHandlerLeakView
    {
        private HeavyObject _heavyObject = new HeavyObject();

        public EventHandlerLeakView()
        {
            InitializeComponent();
            StaticSampleObject.StaticSampleEvent += StaticSampleObject_StaticSampleEvent;
            SampleTextBox.TextChanged += SampleTextBox_TextChanged;
        }

        private void SampleTextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            TextChangedHandlerTextBlock.Text = ((TextBox)(e.OriginalSource)).Text;
        }

        private void StaticSampleObject_StaticSampleEvent()
        {
            for (int i = 0; i < 10; i++)
            {
                var x = i;
            }
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            if (RepairLeakCheckBox.IsChecked == true)
            {
                StaticSampleObject.StaticSampleEvent -= StaticSampleObject_StaticSampleEvent;
                SampleTextBox.TextChanged -= SampleTextBox_TextChanged;
            }
        }
    }
}