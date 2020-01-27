using Triangle_Inscriber.Helpers.Helper_Classes;
using System.Windows;
using System.Windows.Input;

namespace Triangle_Inscriber.MainPage
{
    class MainPageViewModel : ObservableObject, IPageViewModel
    {
        public string Name => "Main Page";

        #region Properties

        #region CircleProperties
        private double circleDiameter = 100;
        private FloatingPoint circleCenter = new FloatingPoint(-50, 0);

        public FloatingPoint CircleCenter
        {
            get => circleCenter;
            set
            {
                circleCenter = value;
                OnPropertyChanged();
            }
        }

        public double CircleDiameter
        {
            get => circleDiameter;
            set
            {
                circleDiameter = value;
                OnPropertyChanged();
            }
        }
        #endregion

        #region Vertices
        private FloatingPoint red = new FloatingPoint(100, 300);
        private FloatingPoint green = new FloatingPoint(300, 100);
        private FloatingPoint blue = new FloatingPoint(200, 400);

        public MainPageViewModel()
        {
            var encompassingCircle = TriangleInscriber.Inscribe(Red, Green, Blue);
            circleCenter = encompassingCircle.CirclePosition;
            circleDiameter = encompassingCircle.Diameter;
        }

        public FloatingPoint Red
        {
            get => red;
            set
            {
                red = value;
                OnPropertyChanged();
            }
        }
        public FloatingPoint Green
        {
            get => green;
            set
            {
                green = value;
                OnPropertyChanged();
            }
        }
        public FloatingPoint Blue
        {
            get => blue;
            set
            {
                blue = value;
                OnPropertyChanged();
            }
        }
        #endregion

        #endregion
    }
}
