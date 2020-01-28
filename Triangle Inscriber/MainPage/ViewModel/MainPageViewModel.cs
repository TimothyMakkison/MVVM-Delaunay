using Triangle_Inscriber.Helpers.Helper_Classes;
using System.Windows;
using System.Windows.Input;
using System.Collections.Generic;

namespace Triangle_Inscriber.MainPage
{
    public class MainPageViewModel : ObservableObject, IPageViewModel
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

        public static Circle Red { get; set; } = new Circle(100, 300,10);
        public static Circle Green { get; set; } = new Circle(300, 100,10);
        public static Circle Blue { get; set; } = new Circle(200, 400,10);
        #endregion

        public List<Circle> Dots { get; set; } = new List<Circle>() { Red, Green, Blue};

        #endregion

        //private ICommand _mouseTestCommand;
        //public ICommand MouseTestCommand
        //{
        //    get
        //    {
        //        if (_mouseTestCommand == null)
        //        {
        //            _mouseTestCommand = new RelayCommand(eventArgs => OnMouseUp(eventArgs), null);
        //        }
        //        return _mouseTestCommand;
        //    }
        //}
        //private void OnMouseUp(object t)
        //{
        //    var e = (MouseButtonEventArgs)t;
        //    var m = 
        //    var mousePos = e.GetPosition();
        //    MessageBox.Show(mousePos.ToString());
        //    Model.OnUserClick(mousePos);
        //}


    }
}
