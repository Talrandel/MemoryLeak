using MemoryLeaksDemo.Infrastructure;
using System;
using System.Windows.Input;
using System.Windows.Threading;

namespace MemoryLeaksDemo.CommandBindingLeak
{
    public partial class CommandBindingLeakView
    {
        private HeavyObject _heavyObject = new HeavyObject();

        private RoutedCommand _command;
        private CommandBinding _commandBinding;
        private MainWindow _mainWindow;

        public CommandBindingLeakView()
        {
            InitializeComponent();
            _mainWindow = MainWindow.MainWindowInstance;
            _command = new RoutedCommand("ClearBox", GetType());
            _command.InputGestures.Add(new KeyGesture(Key.F5));
            _commandBinding = new CommandBinding(_command, F5CommandExecute);
            _mainWindow.CommandBindings.Add(_commandBinding);
        }

        private void F5CommandExecute(object sender, ExecutedRoutedEventArgs e)
        {
            Dispatcher.BeginInvoke(DispatcherPriority.ContextIdle, (Action)delegate
            {
                SampleTextBlock.Text = _mainWindow.SampleTextBox.Text;
            });
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            if (RepairLeakCheckBox.IsChecked == true)
            {
                if (_commandBinding != null)
                    _mainWindow.CommandBindings.Remove(_commandBinding);
            }
        }
    }
}