using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Shapes;
using System.Windows.Media;

namespace Square
{
    public partial class SquareClass : Figure
    {
        public void Drawing(WrapPanel wrappanel)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.Width = 200;
            rectangle.Height = 200;
            rectangle.Fill = Brushes.Green;
            rectangle.Stroke = Brushes.Black;
            rectangle.StrokeThickness = 2;
            wrappanel.Children.Add(rectangle);
        }
    }
}
