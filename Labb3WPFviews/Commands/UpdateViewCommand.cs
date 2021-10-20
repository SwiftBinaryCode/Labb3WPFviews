using Labb3WPFviews.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Labb3WPFviews.Commands
{
    public class UpdateViewCommand : ICommand
    {
        private MainWindowViewModel viewmodel;

        public UpdateViewCommand(MainWindowViewModel viewmodel)
        {
            this.viewmodel = viewmodel;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (parameter.ToString() == "Play")
            {
                viewmodel.SelectedViewModel = new PlayViewModel();
            }
            else if (parameter.ToString() == "Edit")
            {
                viewmodel.SelectedViewModel = new EditViewModel();
            }
            else if (parameter.ToString() == "Create")
            {
                viewmodel.SelectedViewModel = new CreateViewModel();
            }
        }
    }
}
