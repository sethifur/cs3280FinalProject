using cs3280FinalProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace cs3280FinalProject.Commands
{
    class NewOrderUpdateCommand : ICommand
    {
        public NewOrderUpdateCommand(NewOrderViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        private NewOrderViewModel _viewModel;

        public event EventHandler CanExecuteChanged;

        #region ICommand Members

        public event System.EventHandler CanExicuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(Object parameter)
        {
            return _viewModel.CanUpdate;
        }

        public void Execute(Object parameter)
        {
            _viewModel.SaveChanges();
        }

        #endregion
    }
}
