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
        private List<Point> _points { get; set; }
        public struct Relations
        {
            private double _LenPch { get; set; }
            private double _Pch2Ach { get; set; }
            private double _AltAch { get; set; }
            private double _PchPer { get; set; }
            private double _AchAerAlt { get; set; }
        }
        private Relations _relations { get; set; }
        public Polygon2D(List<Point> points, Relations relations)
        {
            _relations = relations;
            _points = points;
        }
    }
}
