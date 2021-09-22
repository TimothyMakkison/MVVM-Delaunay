using TriangleInscriber.Helpers.HelperClasses;

namespace TriangleInscriber.MainWindowViewModel
{
    internal class MainWindowViewModel : ObservableObject
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