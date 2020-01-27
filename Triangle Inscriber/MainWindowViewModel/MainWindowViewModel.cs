using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triangle_Inscriber.Helpers.Helper_Classes;
using System.Windows;
using System.Windows.Input;

namespace Triangle_Inscriber.MainWindowViewModel
{
    class MainWindowViewModel : ObservableObject
    {
        private IPageViewModel _currentPageViewModel = new MainPage.MainPageViewModel();
        /// <summary>
        /// Updates or returns current page
        /// </summary>
        public IPageViewModel CurrentPageViewModel
        {
            get
            {
                return _currentPageViewModel;
            }
            set
            {
                if (_currentPageViewModel != value)
                {
                    _currentPageViewModel = value;
                    OnPropertyChanged();

                }
            }
        }
    }
}
