using System;

namespace MemoryLeaksDemo.WeakEventManagerExample
{
    class EventSourceSample
    {
        public event EventHandler<EventArgs> SampleEvent;

        public string SampleProperty { get; set; }

        public void OnSampleEventRaised()
        {
            SampleProperty = "New value";
        }
    }
}