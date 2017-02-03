using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Gallery_.Commands
{
    class DelegateCommands : ICommand
    {
        public DelegateCommands(Action execute)
        {
            _execute = execute;
        }

        public DelegateCommands()
        {
            throw new NotImplementedException();
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _execute();
        }

        public event EventHandler CanExecuteChanged;
        Action _execute;
    }

}
