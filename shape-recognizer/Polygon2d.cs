using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace shape_recognizer
{    
    class Polygon2D
    {
        public List<Point> Points { get; private set; }
        public Polygon2D(List<Point> points)
        {
            this.Points = points;
        }

        public Polygon2D() {

        }
    }
}
