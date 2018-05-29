using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using CsvHelper;
using CsvHelper.Configuration;

namespace shape_recognizer
{
    struct Relations
    {
        public double LenPch;
        public double Pch2Ach;
        public double AltAch;
        public double PchPer;
        public double AchAerAlt;
        public double AltAer;
    }
    
    public enum ShapeClass {Rectangle, Cirle, Triangle, Line, Ellipse, Diamond };

    [Serializable]
    class ClassifiedShape
    {
        //public Relations relations { get; private set; }
        
        public ShapeClass shapeClass { get; private set; }
        public double LenPch { get; private set; }
        public double Pch2Ach { get; private set; }
        public double AltAch { get; private set; }
        public double PchPer { get; private set; }
        public double AchAerAlt { get; private set; }
        public double AltAer { get; private set; }

        public ClassifiedShape(Relations relations, ShapeClass shapeClass)
        {
            // this.relations = relations;
            LenPch = Math.Round(relations.LenPch,5);
            Pch2Ach = Math.Round(relations.Pch2Ach, 5);
            AltAch = Math.Round(relations.AltAch, 5);
            PchPer = Math.Round(relations.PchPer, 5);
            AchAerAlt = Math.Round(relations.AchAerAlt, 5);
            AltAer = Math.Round(relations.AltAer, 5);
            this.shapeClass = shapeClass;
        }

        public override string ToString()
        {
            return "Class: " + shapeClass + " LenPch:" + LenPch 
                + " Pch2Ach:" + Pch2Ach + " AltAch:" + AltAch
                + " PchPer:"+ PchPer + " AchAerAlt:"+ AchAerAlt;
        }
    }
}