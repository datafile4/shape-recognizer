using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shape_recognizer
{
    static class Classifier
    {
        public static ShapeClass Classify(ClassifiedShape shape, List<ClassifiedShape> features)
        {
            Debug.WriteLine(shape.ToString());
            ShapeClass result = ShapeClass.Cirle;
            ClassifiedShape circleFeature = features.Find(item => item.shapeClass == ShapeClass.Cirle);
            if (shape.Pch2Ach <= circleFeature.Pch2Ach)
            {
                result = ShapeClass.Cirle;
            }
            else
            {
                ClassifiedShape triangleFeature = features.Find(item => item.shapeClass == ShapeClass.Triangle);
                if (shape.AltAch >= triangleFeature.AltAch)
                {
                    result = ShapeClass.Triangle;
                }
                else
                {
                    ClassifiedShape rectangleFeature = features.Find(item => item.shapeClass == ShapeClass.Rectangle);
                    if(shape.PchPer >= rectangleFeature.PchPer)
                    {
                        result = ShapeClass.Rectangle;
                    }
                    else
                    {
                        ClassifiedShape ellipseFeature = features.Find(item => item.shapeClass == ShapeClass.Ellipse);
                        if (ellipseFeature.AchAerAlt <= ellipseFeature.AchAerAlt)
                        {
                            result = ShapeClass.Ellipse;
                        }
                    }
                }
            }
            return result;
        }
    }
}
