using System.Windows.Controls;
using System.Windows.Input;

namespace TriangleInscriber.MainPage
{
    /// <summary>
    /// Interaction logic for MainPageView.xaml
    /// </summary>
    public partial class MainPageView : UserControl
    {
        public MainPageView()
        {
            InitializeComponent();
        }

        private void Canvas_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            var vm = DataContext as MainPageViewModel;
            var a = e.GetPosition(sender as Canvas);
            vm.Points.Add(new DelaunatorSharp.Point(a.X, a.Y));
            vm.UpdatePolygons();
        }
    }
}