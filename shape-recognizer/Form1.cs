using System;
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
        IEnumerable<Vertex> convexHull;

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

        private Point[] MaximalTriangle(IEnumerable<Vertex> points)
        {
            //sort points
            Point[] result = new Point[3];
            return result;
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
                center.X += (int)((convexHull.ElementAt(i).Position[0] + convexHull.ElementAt(i+1).Position[0])*
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

        private double AreaTriangle(Point a, Point b, Point c)
        {
            return Math.Abs((a.X - c.X) * (b.Y - a.Y) - (a.X - b.X) * (c.Y - a.Y));
        }

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

        private void graphPanel_MouseUp(object sender, MouseEventArgs e)
        {
            mouseIsDown = false;
            var vertices = new Vertex[points_list.Count];
            for (int i = 0; i < points_list.Count; i++)
            {
                vertices[i] = new Vertex(points_list[i].X, points_list[i].Y);
            }
            convexHull = ConvexHull.Create(vertices).Points;
            for (int i = 1; i < convexHull.Count(); i++)
            {
                graphObj.DrawLine(new Pen(Color.Red), new Point((int)convexHull.ElementAt(i - 1).Position[0], (int)convexHull.ElementAt(i - 1).Position[1]),
                    new Point((int)convexHull.ElementAt(i).Position[0], (int)convexHull.ElementAt(i).Position[1]));
            }
            labelShapePointCountVal.Text = points_list.Count.ToString();
            labelConvHullPntCntVal.Text = convexHull.Count().ToString();
            Rectangle boundingBox = BoundingBox(points_list);
            graphObj.DrawRectangle(new Pen(Color.Black), boundingBox);
            points_list.Clear();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            if (graphObj != null)
            {
                graphObj.Clear(graphPanel.BackColor);
                labelConvHullPntCntVal.Text = "";
                labelShapePointCountVal.Text = "";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

