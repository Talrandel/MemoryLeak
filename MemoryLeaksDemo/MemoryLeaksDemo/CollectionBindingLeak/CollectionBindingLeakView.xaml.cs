﻿namespace MemoryLeaksDemo.CollectionBindingLeak
{
    public partial class CollectionBindingLeakView
    {
        public CollectionBindingLeakView()
        {
            InitializeComponent();
            DataContext = new CollectionBindingLeakViewModel();
        }
    }
}