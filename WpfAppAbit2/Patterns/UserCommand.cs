using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfAppAbit2.Patterns
{
    class UserCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private Action save;

        public UserCommand(Action save)
        {
            this.save = save;

        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            save();
        }
    }
}
