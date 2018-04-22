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
        List<Point> pointList = new List<Point>();
        List<Polygon2D> polygonList = new List<Polygon2D>();
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

        private void DrawTriangle(Triangle triangle)
        {
            if (graphObj != null)
            {
                var pen = new Pen(Color.Green);
                graphObj.DrawLine(pen, triangle.A, triangle.B);
                graphObj.DrawLine(pen, triangle.B, triangle.C);
                graphObj.DrawLine(pen, triangle.C, triangle.A);
            }
            else
            {
                throw new Exception("Graph is null");
            }
        }

        private void graphPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseIsDown = true;
                graphObj = this.graphPanel.CreateGraphics();
                _lastLoc = e.Location;
                pointList.Add(e.Location);
            }
        }

        private void graphPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseIsDown)
            {
                paintCurrentPosition(e.Location, 2, Color.Blue);
                pointList.Add(e.Location);
            }
            labelPoint.Text = e.Location.X.ToString() + "," + e.Location.Y.ToString();
        }
        private void paintCurrentPosition(Point loc, int thickness, Color colorPen)
        {
            graphObj.DrawLine(new Pen(Color.Black), _lastLoc, loc);
            _lastLoc = loc;
        }

        private void RecordShape()
        {
            mouseIsDown = false;
            ShapeRecognition recognizer = new ShapeRecognition(new Polygon2D(pointList));
            Polygon2D convexHull = recognizer.ConvexHull;
            List<Point> convexHullPoints = convexHull.Points;
            for (int i = 1; i < convexHullPoints.Count(); i++)
            {
                graphObj.DrawLine(new Pen(Color.Red), convexHullPoints[i - 1], convexHullPoints[i]);
            }
            labelShapePointCountVal.Text = pointList.Count.ToString();
            labelConvHullPntCntVal.Text = convexHullPoints.Count().ToString();
            graphObj.DrawRectangle(new Pen(Color.Black), recognizer.BoundingRectangle);
            DrawTriangle(recognizer.NestedTriangle);
            Relations relations = recognizer.GetRelations();
            labelAltachValue.Text = Math.Round(relations.AltAch, 5).ToString();
            labelLenpchValue.Text = Math.Round(relations.LenPch, 5).ToString();
            labelPchachValue.Text = Math.Round(relations.Pch2Ach, 5).ToString();
            labelPchperValue.Text = Math.Round(relations.PchPer, 5).ToString();
            //Clean some shits
            pointList.Clear();
        }
        public void ClearCanvas()
        {
            if (graphObj != null)
            {
                graphObj.Clear(graphPanel.BackColor);
                labelConvHullPntCntVal.Text = "";
                labelShapePointCountVal.Text = "";
                labelCHPerimeterValue.Text = "";
            }
        }

        private void InitializeRelationLabels()
        {
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
        //this is main function now
        private void graphPanel_MouseUp(object sender, MouseEventArgs e)
        {
            RecordShape();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearCanvas();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeRelationLabels();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

        }
    }
}

