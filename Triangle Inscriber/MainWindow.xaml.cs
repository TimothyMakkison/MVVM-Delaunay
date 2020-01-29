using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

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
