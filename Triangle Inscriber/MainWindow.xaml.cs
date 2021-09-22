using System.Windows;

namespace TriangleInscriber
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void DragWindow_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
            => this.DragMove();

        private void MinimizeWindowButton_Click(object sender, RoutedEventArgs e)
            => this.WindowState = WindowState.Minimized;

        private bool maximized = false;

        private void ChangeWindowState_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = maximized ? WindowState.Normal : WindowState.Maximized;
            maximized = !maximized;
        }

        private void CloseWindow_Click(object sender, RoutedEventArgs e)
            => this.Close();
    }
}