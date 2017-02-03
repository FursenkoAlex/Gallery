using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Gallery_.Commands
{
    class OpenFolderCommand:ICommand
    {
        private Action action;

        public OpenFolderCommand(Action action)
        {
            this.action = action;
        }


        public OpenFolderCommand()
        {
            throw new NotImplementedException();
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            action();
        }

        public event EventHandler CanExecuteChanged;
    }
}
