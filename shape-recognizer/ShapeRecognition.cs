using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using MIConvexHull;

namespace shape_recognizer
{
    class ShapeRecognition
    {
        public Polygon2D OriginalPolygon { get; private set; }
        public Polygon2D ConvexHull { get; private set; }
        public Rectangle BoundingRectangle { get; private set; }
        public Triangle NestedTriangle { get; private set; }
        public Relations Relations { get; private set; }

        public ShapeRecognition(Polygon2D OriginalPolygon)
        {
            this.OriginalPolygon = OriginalPolygon;
            ConvexHull = GetConvexHull();
            BoundingRectangle = BoundingBox();
            NestedTriangle = DetectMaxTriangle();
        }

        public Relations GetRelations()
        {
            Relations relations = new Relations();
            double areaCH = PolygonArea(ConvexHull);
            double perimeterCH = PerimeterOfPolygon(ConvexHull);
            double areaRectangle = BoundingRectangle.Width * BoundingRectangle.Height;
            double areaTriangle = AreaTriangle(NestedTriangle);
            relations.AltAch = areaTriangle / areaCH;
            relations.LenPch = PerimeterOfPolygon(OriginalPolygon) / perimeterCH;
            relations.Pch2Ach = perimeterCH / areaCH;
            relations.PchPer = perimeterCH / (2 * (BoundingRectangle.Width + BoundingRectangle.Height));
            relations.AchAerAlt = Math.Pow(areaCH, 2) / (areaRectangle * areaTriangle);
            relations.AltAer = areaTriangle / areaRectangle;
            return relations;
        }

        private Rectangle BoundingBox()
        {
            var x_query = from Point p in OriginalPolygon.Points select p.X;
            int xmin = x_query.Min();
            int xmax = x_query.Max();

            var y_query = from Point p in OriginalPolygon.Points select p.Y;
            int ymin = y_query.Min();
            int ymax = y_query.Max();

            return new Rectangle(xmin, ymin, xmax - xmin, ymax - ymin);
        }

        private List<Point> VertexToPoint(List<Vertex> vertices)
        {
            List<Point> points = new List<Point>();
            foreach (Vertex _vertex in vertices)
            {
                points.Add(new Point((int)_vertex.Position[0], (int)_vertex.Position[1]));
            }
            return points;
        }
        private double AreaTriangle(Triangle triangle)
        {
            return Math.Abs((triangle.A.X - triangle.C.X) * (triangle.B.Y - triangle.A.Y) -
                (triangle.A.X - triangle.B.X) * (triangle.C.Y - triangle.A.Y));
        }

        private Triangle DetectMaxTriangle()
        {
            int A = 0, B = 1, C = 2;
            int bA = A, bB = B, bC = C; //best triple
            List<Point> _convexHull = ConvexHull.Points;
            int n = _convexHull.Count();
            while (true)
            {
                while (true)
                {
                    while (AreaTriangle(new Triangle(_convexHull[A], _convexHull[B], _convexHull[C])) <= AreaTriangle(new Triangle(_convexHull[A], _convexHull[B], _convexHull[(C + 1) % n])))
                    {
                        C = (C + 1) % n;
                    }
                    if (AreaTriangle(new Triangle(_convexHull[A], _convexHull[B], _convexHull[C])) <= AreaTriangle(new Triangle(_convexHull[A], _convexHull[(B + 1) % n], _convexHull[C])))
                    {
                        B = (B + 1) % n;
                        continue;
                    }
                    else
                        break;
                }
                if (AreaTriangle(new Triangle(_convexHull[A], _convexHull[B], _convexHull[C])) > AreaTriangle(new Triangle(_convexHull[bA], _convexHull[bB], _convexHull[bC])))
                {
                    bA = A;
                    bB = B;
                    bC = C;
                }

                A = (A + 1) % n;
                if (A == B)
                    B = (B + 1) % n;
                if (B == C)
                    C = (C + 1) % n;
                if (A == 0)
                    break;
            }
            Triangle result = new Triangle(_convexHull[bA], _convexHull[bB], _convexHull[bC]);
            return result;
        }

        private double PerimeterOfPolygon(Polygon2D polygon)
        {
            //perimeter of free shape will be sum of distances between all points
            double perimeter = 0;
            for (int i = 1; i < polygon.Points.Count; i++)
            {
                //distance between two points
                perimeter += Math.Sqrt(Math.Pow(polygon.Points[i].X - polygon.Points[i - 1].X, 2) + Math.Pow(polygon.Points[i].Y - polygon.Points[i - 1].Y, 2));
            }
            //distance between last point and first point
            perimeter += Math.Sqrt(Math.Pow(polygon.Points.Last().X - polygon.Points.First().X, 2) + Math.Pow(polygon.Points.Last().Y - polygon.Points.First().Y, 2));
            return perimeter;
        }

        public Polygon2D GetConvexHull()
        {
            var vertices = new Vertex[OriginalPolygon.Points.Count];
            for (int i = 0; i < OriginalPolygon.Points.Count; i++)
            {
                vertices[i] = new Vertex(OriginalPolygon.Points[i].X, OriginalPolygon.Points[i].Y);
            }
            return new Polygon2D(VertexToPoint(MIConvexHull.ConvexHull.Create(vertices).Points.ToList()));
        }

        //https://web.archive.org/web/20100405070507/http://valis.cs.uiuc.edu/~sariel/research/CG/compgeom/msg00831.html
        //http://www.mathopenref.com/coordpolygonarea.html
        private double PolygonArea(Polygon2D polygon)
        {
            double area = 0;
            for (int i = 0; i < polygon.Points.Count; i++)
            {
                int j = (i + 1) % polygon.Points.Count;
                area = area + polygon.Points[i].X * polygon.Points[j].Y;
                area = area - polygon.Points[i].Y * polygon.Points[j].X;
            }
            return area / 2;
        }

        private double FeatureLenPch()
        {
            return PerimeterOfPolygon(OriginalPolygon) / PerimeterOfPolygon(ConvexHull);
        }

        private double FeaturePch2Ach()
        {
            return PerimeterOfPolygon(ConvexHull) / PolygonArea(ConvexHull);
        }

        private double FeaturePchPer()
        {
            return PerimeterOfPolygon(ConvexHull) / (2 * (BoundingRectangle.Width + BoundingRectangle.Height));
        }

        private double FeatureAltAch()
        {
            return AreaTriangle(NestedTriangle) / PolygonArea(ConvexHull);
        }

        //public Relations ProcessImage(Image image)
        //{
        //    ImageHandler imageHandler = new ImageHandler(new Bitmap(image));
        //    List<List<Point>> edges = imageHandler.GetEdges();
        //    foreach (List<Point> edge in edges)
        //    {
        //        List<Point> sortedPoints = edge.OrderBy(x => Math.Atan2(x.X, x.Y)).ToList();

        //    }
        //}
    }
}
