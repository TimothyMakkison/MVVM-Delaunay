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
        public InteractiveCanvasModel Model {get;set;}

        protected override void OnMouseUp(MouseButtonEventArgs e)
        {
            base.OnMouseUp(e);
            var mousePos = e.GetPosition(this);
            MessageBox.Show(mousePos.ToString());
            //Model.OnUserClick(mousePos);
        }
    }
}
