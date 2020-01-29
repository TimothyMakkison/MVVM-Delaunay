using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Collections.Generic;

namespace Triangle_Inscriber.MainPage
{
    public class InterativeCanvas : Canvas
    {
        protected override void OnMouseUp(MouseButtonEventArgs e)
        {
            base.OnMouseUp(e);
            var mousePos = e.GetPosition(this);
            MessageBox.Show("Cursor position is " + mousePos.ToString());
            InteractiveCanvasModel.OnUserClick(mousePos);
        }
    }
}
