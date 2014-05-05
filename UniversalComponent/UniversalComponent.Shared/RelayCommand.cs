using System;
using System.Windows.Input;

namespace UniversalComponent.ViewModels
{
    public class RelayCommand : ICommand
    {
        private readonly Action _action;
        private readonly Func<bool> _predicate;

        public RelayCommand(Action action, Func<bool> predicate)
        {
            _action = action;
            _predicate = predicate;
        }

        public bool CanExecute(object parameter)
        {
            return _predicate();
        }

        public void Execute(object parameter)
        {
            _action();
        }

        public event EventHandler CanExecuteChanged;
    }
}