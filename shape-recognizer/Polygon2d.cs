using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace shape_recognizer
{
    public struct Relations
    {
        public double LenPch;
        public double Pch2Ach;
        public double AltAch;
        public double PchPer;
        public double AchAerAlt;
    }
    class Polygon2D
    {
        private List<Point> _points { get; set; }       
        //private Relations _relations { get; set; }
        public Polygon2D(List<Point> points, Relations relations)
        {
            //_relations = relations;
            _points = points;
        }
    }
}
