using Triangle_Inscriber.Helpers.Helper_Classes;
using System.Windows;
using System.Windows.Input;
using System.Collections.Generic;

namespace Triangle_Inscriber.MainPage
{
    public class MainPageViewModel : ObservableObject, IPageViewModel
    {
        //#region Constructor
        //public MainPageViewModel()
        //{
        //    var encompassingCircle = TriangleInscriber.Inscribe(Red.Position, Green.Position, Blue.Position);
        //    Circle = encompassingCircle;
        //}
        //#endregion

        #region Properties
        public string Name => "Main Page";

        #region CircleProperties
        public Circle Circle { get; set; } = InteractiveCanvasModel.Circle;
        #endregion

        #region Vertices
        public Circle Red => InteractiveCanvasModel.Red;
        public Circle Green => InteractiveCanvasModel.Green;
        public Circle Blue => InteractiveCanvasModel.Blue;
        #endregion

        public List<Circle> Dots => InteractiveCanvasModel.Dots;

        #endregion
    }
}
