using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;
using System.Windows.Media;
using System.Windows.Controls;

namespace Circle
{
    public partial class CircleClass : Figure
    {
        public void Drawing(WrapPanel wrappanel)
        {
            Ellipse el = new Ellipse();
            el.Width = 200;
            el.Height = 200;
            el.Fill = Brushes.Green;
            el.Stroke = Brushes.Red;
            el.StrokeThickness = 1;
            wrappanel.Children.Add(el);
        }
    }
}
