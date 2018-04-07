﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MIConvexHull;
namespace shape_recognizer
{
    public partial class Form1 : Form
    {
        private Graphics graphObj;
        private Point _lastLoc;
        bool mouseIsDown = false;
        List<Point> points_list = new List<Point>();
        //List<Vertex> convexHull;
        //Label labelClassTriangle;
        //Label labelClassTriangleValue;
        //Label labelClassRectangle;
        //Label labelClassRectangleValue;
        //Label lableClassCirle;
        //Label lableClassCirleValue;
        Label labelLenpch;
        Label labelLenpchValue;
        Label labelPchach;
        Label labelPchachValue;
        Label labelAltach;
        Label labelAltachValue;
        Label labelPchper;
        Label labelPchperValue;

        public Form1()
        {
            InitializeComponent();
        }

        private Rectangle BoundingBox(List<Point> points)
        {
            var x_query = from Point p in points select p.X;
            int xmin = x_query.Min();
            int xmax = x_query.Max();

            var y_query = from Point p in points select p.Y;
            int ymin = y_query.Min();
            int ymax = y_query.Max();

            return new Rectangle(xmin, ymin, xmax - xmin, ymax - ymin);
        }

        private Point Centroid(IEnumerable<Vertex> convexHull)
        {
            //from https://en.wikipedia.org/wiki/Centroid#Centroid_of_a_polygon
            double polygonArea = 0;
            for (int i = 0; i < convexHull.Count() - 1; i++)
            {
                polygonArea += convexHull.ElementAt(i).Position[0] * convexHull.ElementAt(i + 1).Position[1] -
                    convexHull.ElementAt(i + 1).Position[0] * convexHull.ElementAt(i).Position[1];
            }
            polygonArea /= 2;

            Point center = new Point();
            for (int i = 0; i < convexHull.Count() - 1; i++)
            {
                center.X += (int)((convexHull.ElementAt(i).Position[0] + convexHull.ElementAt(i + 1).Position[0]) *
                    (convexHull.ElementAt(i).Position[0] * convexHull.ElementAt(i + 1).Position[1] -
                    convexHull.ElementAt(i + 1).Position[0] * convexHull.ElementAt(i).Position[1]));
            }
            center.X /= 6 * (int)polygonArea;

            for (int i = 0; i < convexHull.Count() - 1; i++)
            {
                center.Y += (int)((convexHull.ElementAt(i).Position[1] + convexHull.ElementAt(i + 1).Position[1]) *
                    (convexHull.ElementAt(i).Position[0] * convexHull.ElementAt(i + 1).Position[1] -
                    convexHull.ElementAt(i + 1).Position[0] * convexHull.ElementAt(i).Position[1]));
            }
            center.Y /= 6 * (int)polygonArea;

            return center;
        }

        private double AreaTriangle(Point a, Point b, Point c) => Math.Abs((a.X - c.X) * (b.Y - a.Y) - (a.X - b.X) * (c.Y - a.Y));
        private List<Point> DetectMaxTriangle(List<Point> _convexHull)
        {
            int A = 0, B = 1, C = 2;
            int bA = A, bB = B, bC = C; //best triple
            int n = _convexHull.Count();
            while (true)
            {
                while (true)
                {
                    while (AreaTriangle(_convexHull[A], _convexHull[B], _convexHull[C]) <= AreaTriangle(_convexHull[A], _convexHull[B], _convexHull[(C + 1) % n]))
                    {
                        C = (C + 1) % n;
                    }
                    if (AreaTriangle(_convexHull[A], _convexHull[B], _convexHull[C]) <= AreaTriangle(_convexHull[A], _convexHull[(B + 1) % n], _convexHull[C]))
                    {
                        B = (B + 1) % n;
                        continue;
                    }
                    else
                        break;
                }
                if (AreaTriangle(_convexHull[A], _convexHull[B], _convexHull[C]) > AreaTriangle(_convexHull[bA], _convexHull[bB], _convexHull[bC]))
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
            List<Point> result = new List<Point>() { _convexHull[bA], _convexHull[bB], _convexHull[bC] };
            return result;
        }

        private void DrawTriangle(List<Point> points)
        {
            if (graphObj != null || points.Count  <= 3)
            {
                var pen = new Pen(Color.Green);
                graphObj.DrawLine(pen, points[0], points[1]);
                graphObj.DrawLine(pen, points[1], points[2]);
                graphObj.DrawLine(pen, points[2], points[0]);
            } else
            {
                throw new Exception("Graph is null");
            }
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

        #region parameters for relations
        private double PerimeterOfPolygon(List<Point> polygon)
        {
            //perimeter of free shape will be sum of distances between all points
            double perimeter = 0;
            for (int i = 1; i < polygon.Count; i++)
            {
                //distance between two points
                perimeter += Math.Sqrt(Math.Pow(polygon[i].X - polygon[i - 1].X, 2) + Math.Pow(polygon[i].Y - polygon[i - 1].Y, 2));
            }
            //distance between last point and first point
            perimeter += Math.Sqrt(Math.Pow(polygon.Last().X - polygon.First().X, 2) + Math.Pow(polygon.Last().Y - polygon.First().Y, 2));
            return perimeter;
        }
        //https://web.archive.org/web/20100405070507/http://valis.cs.uiuc.edu/~sariel/research/CG/compgeom/msg00831.html
        //http://www.mathopenref.com/coordpolygonarea.html
        double PolygonArea(List<Point> polygon)
        {
            double area = 0;
            for(int i = 0; i<polygon.Count; i++)
            {
                int j = (i+1)% polygon.Count;
                area = area + polygon[i].X * polygon[j].Y;
                area = area - polygon[i].Y * polygon[j].X;
            }
            return area/2;
        }
        #endregion        
        private void graphPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseIsDown = true;
                graphObj = this.graphPanel.CreateGraphics();
                _lastLoc = e.Location;
                points_list.Add(e.Location);
            }
        }

        private void graphPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseIsDown)
            {
                paintCurrentPosition(e.Location, 2, Color.Blue);
                points_list.Add(e.Location);
            }
            labelPoint.Text = e.Location.X.ToString() + "," + e.Location.Y.ToString();
        }
        private void paintCurrentPosition(Point loc, int thickness, Color colorPen)
        {
            graphObj.DrawLine(new Pen(Color.Black), _lastLoc, loc);
            _lastLoc = loc;
        }
        //this is main function now
        private void graphPanel_MouseUp(object sender, MouseEventArgs e)
        {
            mouseIsDown = false;
            var vertices = new Vertex[points_list.Count];
            for (int i = 0; i < points_list.Count; i++)
            {
                vertices[i] = new Vertex(points_list[i].X, points_list[i].Y);
            }
            List<Vertex> convexHull = ConvexHull.Create(vertices).Points.ToList();
            List<Point> convexHullPoints = VertexToPoint(convexHull);
            for (int i = 1; i < convexHullPoints.Count(); i++)
            {
                graphObj.DrawLine(new Pen(Color.Red), convexHullPoints[i - 1], convexHullPoints[i]);
            }
            labelShapePointCountVal.Text = points_list.Count.ToString();
            labelConvHullPntCntVal.Text = convexHullPoints.Count().ToString();
            Rectangle boundingBox = BoundingBox(points_list);
            graphObj.DrawRectangle(new Pen(Color.Black), boundingBox);
            List<Point> biggestTriangle = DetectMaxTriangle(convexHullPoints);
            DrawTriangle(biggestTriangle);
            double perimeter = PerimeterOfPolygon(convexHullPoints);
            labelCHPerimeterValue.Text = Math.Round(perimeter,2).ToString();
            #region relations
            double pch = PerimeterOfPolygon(convexHullPoints);
            double triangleRelation = AreaTriangle(biggestTriangle[0], biggestTriangle[1], biggestTriangle[2]) /PolygonArea(convexHullPoints);
            labelAltachValue.Text = Math.Round(triangleRelation, 5).ToString();
            double lenPch = PerimeterOfPolygon(points_list) / pch;
            labelLenpchValue.Text = Math.Round(lenPch, 5).ToString();
            double pch2Arch =pch/ PolygonArea(convexHullPoints);
            labelPchachValue.Text = Math.Round(pch2Arch, 5).ToString();
            double pchPer = pch / (2 * (boundingBox.Width + boundingBox.Height));
            labelPchperValue.Text = Math.Round(pchPer, 5).ToString();
            #endregion
            points_list.Clear();
            vertices = null;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            if (graphObj != null)
            {
                graphObj.Clear(graphPanel.BackColor);
                labelConvHullPntCntVal.Text = "";
                labelShapePointCountVal.Text = "";
                labelCHPerimeterValue.Text = "";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //labelClassTriangle = new Label();
            //labelClassTriangle.Text = "Triangle";
            //tableLayoutPanelValues.Controls.Add(labelClassTriangle, 0, 0);
            //labelClassTriangleValue = new Label();
            //tableLayoutPanelValues.Controls.Add(labelClassTriangleValue, 1, 0);
            //labelClassRectangle = new Label();
            //labelClassRectangleValue = new Label();
            //labelClassRectangle.Text = "Rectangle";
            //tableLayoutPanelValues.Controls.Add(labelClassRectangle,0,1);
            //tableLayoutPanelValues.Controls.Add(labelClassRectangleValue, 1, 1);
            labelLenpch = new Label();
            labelLenpch.Text = "Len/Pch";
            tableLayoutPanelValues.Controls.Add(labelLenpch, 0, 0);
            labelPchach = new Label();
            labelPchach.Text = "Pch^2/Ach";
            tableLayoutPanelValues.Controls.Add(labelPchach, 0, 1);
            labelAltach = new Label();
            labelAltach.Text = "Alt/Ach";
            tableLayoutPanelValues.Controls.Add(labelAltach, 0, 2);
            labelPchper = new Label();
            labelPchper.Text = "Pch/Per";
            tableLayoutPanelValues.Controls.Add(labelPchper, 0, 3);
            labelLenpchValue = new Label();
            tableLayoutPanelValues.Controls.Add(labelLenpchValue, 1, 0);
            labelPchachValue = new Label();
            tableLayoutPanelValues.Controls.Add(labelPchachValue, 1, 1);
            labelAltachValue = new Label();
            tableLayoutPanelValues.Controls.Add(labelAltachValue, 1, 2);
            labelPchperValue = new Label();
            tableLayoutPanelValues.Controls.Add(labelPchperValue, 1, 3);
        }
    }
}

