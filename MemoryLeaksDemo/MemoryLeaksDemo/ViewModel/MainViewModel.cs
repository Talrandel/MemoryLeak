using System;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using MemoryLeaksDemo.BindingLeak;
using MemoryLeaksDemo.DataBindingLeak;
using MemoryLeaksDemo.CommandBindingLeak;
using MemoryLeaksDemo.CollectionBindingLeak;
using MemoryLeaksDemo.xNameLeak;
using MemoryLeaksDemo.MediaEffectLeak;
using MemoryLeaksDemo.EventHandlerLeak;
using MemoryLeaksDemo.DispatcherTimerLeak;
using MemoryLeaksDemo.TextBoxUndoLeak;

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
            DispatcherTimerLeakCommand = new RelayCommand(DispatcherTimerLeak);
            TextBoxUndoLeakCommand = new RelayCommand(TextBoxUndoLeak);

            GCCollectCommand = new RelayCommand(GCCollect);

            TotalMemory = GC.GetTotalMemory(true).ToString();
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
            var w1 = new CollectionBindingLeakView();
            w1.ShowDialog();
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
            var w1 = new CommandBindingLeakView();
            w1.Show();
            TotalMemory = GC.GetTotalMemory(true).ToString();
        }

        private void EventHandlerLeak()
        {
            var w1 = new EventHandlerLeakView();
            w1.ShowDialog();
            TotalMemory = GC.GetTotalMemory(true).ToString();
        }

        private void MediaEffectLeak()
        {
            var w1 = new MediaEffectLeakView();
            w1.ShowDialog();
            TotalMemory = GC.GetTotalMemory(true).ToString();
        }

        private void xNameLeak()
        {
            var w1 = new xNameLeakView();
            w1.ShowDialog();
            TotalMemory = GC.GetTotalMemory(true).ToString();
        }

        private void DispatcherTimerLeak()
        {
            var w1 = new DispatcherTimerLeakView();
            w1.ShowDialog();
            TotalMemory = GC.GetTotalMemory(true).ToString();
        }

        private void TextBoxUndoLeak()
        {
            var w1 = new TextBoxUndoLeakView();
            w1.ShowDialog();
            TotalMemory = GC.GetTotalMemory(true).ToString();
        }

        private void GCCollect()
        {
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

        public ICommand DispatcherTimerLeakCommand { get; }

        public ICommand TextBoxUndoLeakCommand { get; }

        public ICommand GCCollectCommand { get; }
    }
}