using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace shape_recognizer
{
    struct Relations
    {
        public double LenPch;
        public double Pch2Ach;
        public double AltAch;
        public double PchPer;
        public double AchAerAlt;
    }
    
    public enum ShapeClass {Rectangle, Cirle, Triangle, Line, Ellipse, Diamond };

    class ClassifiedShape
    {
        //public Relations relations { get; private set; }
        public ShapeClass shapeClass { get; private set; }
        public double LenPch { get; private set; }
        public double Pch2Ach { get; private set; }
        public double AltAch { get; private set; }
        public double PchPer { get; private set; }
        public double AchAerAlt { get; private set; }

        public ClassifiedShape(Relations relations, ShapeClass shapeClass)
        {
            // this.relations = relations;
            LenPch = relations.LenPch;
            Pch2Ach = relations.Pch2Ach;
            AltAch = relations.AltAch;
            PchPer = relations.PchPer;
            AchAerAlt = relations.AchAerAlt;
            this.shapeClass = shapeClass;
        }
    }
}