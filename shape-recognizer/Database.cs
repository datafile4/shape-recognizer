using System;
using System.Collections.Generic;
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

    class Database
    {
        public List<Polygon2D> Shapes { get; private set; }
        public List<string> Classes { get; private set; }
        public List<Relations> Features { get; private set; }

        public Database()
        {
            Classes = new List<string>();
            Shapes = new List<Polygon2D>();
            Features = new List<Relations>();
        }
    }
}
