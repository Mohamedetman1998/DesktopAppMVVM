using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Page_Navigation_App.Commands
{
    public class MvCommands : ICommand
    {

        public Action<object> DelegateForVoid { get; set; }
        public Predicate<object> DelegateForBool { get; set; }
         


        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }


        public MvCommands(Action<object> _execute, Predicate<object> _canExecute = null)
        {
            DelegateForVoid = _execute;
            DelegateForBool = _canExecute;
        }

     

        public bool CanExecute(object parameter) => DelegateForBool == null || DelegateForBool(parameter);   
        public void Execute(object parameter) => DelegateForVoid(parameter);

    }
}
