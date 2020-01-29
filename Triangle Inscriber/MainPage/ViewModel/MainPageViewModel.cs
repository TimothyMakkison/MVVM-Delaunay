using TriangleInscriber.Helpers.HelperClasses;

namespace TriangleInscriber.MainPage
{
    public class MainPageViewModel : ObservableObject, IPageViewModel
    {
        #region Properties
        public string Name => "Main Page";

        #region Vertices
        public static Circle Red => InteractiveCanvasModel.Red;
        public static Circle Green => InteractiveCanvasModel.Green;
        public static Circle Blue => InteractiveCanvasModel.Blue;
        #endregion

        #region CircleProperties
        public Circle InscribingCircle { get; set; } = InteractiveCanvasModel.InscribingCircle;
        #endregion

        #endregion
    }
}
