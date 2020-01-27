using Triangle_Inscriber.Helpers.Helper_Classes;
using System.Windows;
using System.Windows.Input;

namespace Triangle_Inscriber.MainPage
{
    class MainPageViewModel : ObservableObject, IPageViewModel
    {
        #region Constructor
        public MainPageViewModel()
        {
            var encompassingCircle = TriangleInscriber.Inscribe(Red.Position, Green.Position, Blue.Position);
            Circle = encompassingCircle;
        }
        #endregion

        #region Properties
        public string Name => "Main Page";

        #region CircleProperties
        public Circle Circle { get; set; }
        #endregion

        #region Vertices

        public Circle Red { get; set; } = new Circle(100, 300,10);
        public Circle Green { get; set; } = new Circle(300, 100,10);
        public Circle Blue { get; set; } = new Circle(200, 400,10);
        #endregion

        #endregion
    }
}
