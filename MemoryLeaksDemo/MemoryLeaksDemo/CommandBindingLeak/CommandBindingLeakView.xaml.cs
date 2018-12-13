using System;
using System.Windows.Input;
using System.Windows.Threading;

namespace MemoryLeaksDemo.CommandBindingLeak
{
    public partial class CommandBindingLeakView
    {
        private RoutedCommand _command;
        private CommandBinding _commandBinding;
        private MainWindow _mainWindow;

        public CommandBindingLeakView(MainWindow mainWindow)
        {
            InitializeComponent();
            //DataContext = new CollectionBindingLeakViewModel();
            _mainWindow = mainWindow;
            _command = new RoutedCommand("ClearBox", GetType());
            _command.InputGestures.Add(new KeyGesture(Key.F5));
            _commandBinding = new CommandBinding(_command, F5CommandExecute);
            _mainWindow.CommandBindings.Add(_commandBinding);
        }

        private void F5CommandExecute(object sender, ExecutedRoutedEventArgs e)
        {
            Dispatcher.BeginInvoke(DispatcherPriority.ContextIdle, (Action)delegate
            {
                SampleLabel.Content = _mainWindow.SampleTextBox.Text;
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