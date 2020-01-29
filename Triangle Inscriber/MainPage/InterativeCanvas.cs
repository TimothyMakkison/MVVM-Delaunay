using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Triangle_Inscriber.MainPage
{
    public class InterativeCanvas : Canvas
    {
        #region Left click
        private bool leftClick = false;

        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);
            var mousePos = e.GetPosition(this);
            InteractiveCanvasModel.OnLeftClick(mousePos);
            leftClick = true;
        }

        protected override void OnMouseLeftButtonUp(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonUp(e);
            leftClick = false;
        }
        #endregion

        #region Right Click
        private bool rightClick = false;

        protected override void OnMouseRightButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseRightButtonDown(e);
            rightClick = true;
        }

        protected override void OnMouseRightButtonUp(MouseButtonEventArgs e)
        {
            base.OnMouseRightButtonUp(e);
            rightClick = false;
        }
        #endregion

        #region MouseMovement
        private FloatingPoint previousMousePoint = new FloatingPoint(0,0);
        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            var mousePos = e.GetPosition(this);
            if (leftClick)
            {
                InteractiveCanvasModel.OnLeftClick(mousePos);
            }
            if (rightClick)
            {
                InteractiveCanvasModel.OnRightClick(previousMousePoint - mousePos);
            }
            previousMousePoint = mousePos;
        }
        #endregion
    }
}
