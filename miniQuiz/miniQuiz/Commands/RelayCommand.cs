using System;
using System.Windows.Input;

namespace miniQuiz.Commands
{
    public class RelayCommand : ICommand
    {
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        private readonly Action<object> execute;
        private readonly Func<object, bool> canExecute;

        public RelayCommand(Action<object> execute, Func<object, bool> canExecute)
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }

        public RelayCommand(Action<object> execute) : this(execute, null) { }

        public bool CanExecute(object parameter)
        {
            if (canExecute == null || canExecute(parameter))
            {
                return true;
            }
            return false;
        }

        public void Execute(object parameter)
        {
            execute(parameter);
        }
    }
}
