using System.Windows.Controls;
using System.Windows.Input;

namespace TriangleInscriber.MainPage
{
    public class InterativeCanvas : Canvas
    {
        #region Fields
        private bool leftClick = false;
        private Circle closestCircle;
        private bool rightClick = false;

        private FloatingPoint previousMousePoint = new FloatingPoint(0, 0);
        #endregion

        #region Left click

        /// <summary>
        /// On LeftMouseDown left click is set to true, the closest canvas item is found and moved to cursor position.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);
            var mousePos = e.GetPosition(this);
            closestCircle = InteractiveCanvasModel.FindClosestItem(mousePos);
            InteractiveCanvasModel.MoveCanvasDot(mousePos, closestCircle);
            leftClick = true;
        }
        /// <summary>
        /// Sets left click mode to false once left click raises.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnMouseLeftButtonUp(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonUp(e);
            leftClick = false;
        }
        #endregion

        #region Right Click
        /// <summary>
        /// Sets right click mode to true.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnMouseRightButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseRightButtonDown(e);
            rightClick = true;
        }

        /// <summary>
        /// Sets right click mode to false.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnMouseRightButtonUp(MouseButtonEventArgs e)
        {
            base.OnMouseRightButtonUp(e);
            rightClick = false;
        }
        #endregion

        #region MouseMovement
        /// <summary>
        /// Performs actions depending on button states.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            var mousePos = e.GetPosition(this);
            if (leftClick)
            {
                //If left click is held the canvas item continues to be tracked to cursor.
                InteractiveCanvasModel.MoveCanvasDot(mousePos, closestCircle);
            }
            if (rightClick)
            {
                //If right click is held then canvas items are moved relative to the mouse.
                InteractiveCanvasModel.TransformCanvasItems(previousMousePoint - mousePos);
            }
            previousMousePoint = mousePos;
        }
        #endregion
    }
}
