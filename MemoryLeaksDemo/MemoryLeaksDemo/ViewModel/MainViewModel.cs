using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using MemoryLeaksDemo.BindingLeak;
using MemoryLeaksDemo.DataBindingLeak;
using System;
using System.Windows.Input;
using MemoryLeaksDemo.CommandBindingLeak;

namespace MemoryLeaksDemo.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private string _totalMemory;

        public MainViewModel()
        {
            BindingLeakCommand = new RelayCommand(BindingLeak);
            CollectionBindingLeakCommand = new RelayCommand(CollectionBindingLeak);
            DataBindingLeakCommand = new RelayCommand(DataBindingLeak);
            CommandBindingLeakCommand = new RelayCommand(CommandBindingLeak);
            EventHandlerLeakCommand = new RelayCommand(EventHandlerLeak);
            MediaEffectLeakCommand = new RelayCommand(MediaEffectLeak);
            xNameLeakCommand = new RelayCommand(xNameLeak);
            GCCollectCommand = new RelayCommand(GCCollect);
        }

        public string TotalMemory
        {
            get { return _totalMemory; }
            set { Set(ref _totalMemory, value); }
        }

        private void BindingLeak()
        {
            var w1 = new BindingLeakView();
            w1.ShowDialog();
            TotalMemory = GC.GetTotalMemory(true).ToString();
        }

        private void CollectionBindingLeak()
        {
            // TODO: example!
            TotalMemory = GC.GetTotalMemory(true).ToString();
        }

        private void DataBindingLeak()
        {
            var w1 = new DataBindingLeakView();
            w1.ShowDialog();
            TotalMemory = GC.GetTotalMemory(true).ToString();
        }

        private void CommandBindingLeak()
        {
            var w1 = new CommandBindingLeakView(this);
            w1.Show();
            TotalMemory = GC.GetTotalMemory(true).ToString();
        }

        private void EventHandlerLeak()
        {
            // TODO: example!
            TotalMemory = GC.GetTotalMemory(true).ToString();
        }

        private void MediaEffectLeak()
        {
            // TODO: example!
            TotalMemory = GC.GetTotalMemory(true).ToString();
        }

        private void xNameLeak()
        {
            // TODO: example!
            TotalMemory = GC.GetTotalMemory(true).ToString();
        }

        private void GCCollect()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            TotalMemory = GC.GetTotalMemory(true).ToString();
        }

        public ICommand BindingLeakCommand { get; }

        public ICommand CollectionBindingLeakCommand { get; }

        public ICommand DataBindingLeakCommand { get; }

        public ICommand CommandBindingLeakCommand { get; }

        public ICommand EventHandlerLeakCommand { get; }

        public ICommand MediaEffectLeakCommand { get; }

        public ICommand xNameLeakCommand { get; }

        public ICommand GCCollectCommand { get; }
    }
}