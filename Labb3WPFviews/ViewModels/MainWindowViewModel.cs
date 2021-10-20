using Labb3WPFviews.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Labb3WPFviews.ViewModels
{
    class MainWindowViewModel : BaseViewModel
    {
        private BaseViewModel _selectedViewModel;

        public BaseViewModel SelectedViewModel

        {
            get { return _selectedViewModel;}
            set { _selectedViewModel = value; }
        }

        public ICommand UpdateViewCommand { get; set; }

        public MainWindowViewModel()
        {
                 UpdateViewCommand = new UpdateViewCommand(this);
        }

    }
}
