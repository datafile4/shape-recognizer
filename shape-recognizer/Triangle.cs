using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace shape_recognizer
{
    class Triangle:Polygon2D
    {
        public Point A { get; set; }
        public Point B { get; set; }
        public Point C { get; set; }
        public Triangle(List<Point> points) : base(points)
        {
            A = points[0];
            B = points[1];
            C = points[2];
        }

        public Triangle(Point A, Point B, Point C) : base()
        {
            this.A = A;
            this.B = B;
            this.B = B;
        }
    }
}
