using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MIConvexHull;
using AForge.Imaging;
using CsvHelper;
using System.IO;
using System.Diagnostics;

namespace shape_recognizer
{
    public partial class Form1 : Form
    {
        private Graphics graphObj;
        private Point _lastLoc;
        bool mouseIsDown = false;
        List<Point> pointList = new List<Point>();
        List<Point> previousPointList = new List<Point>();
        Relations currentRelation;
        BindingSource dataGridViewBindingSource = new BindingSource();
        private List<ClassifiedShape> features;
        OpenFileDialog openFileDialogMultiple;

        public Form1()
        {
            InitializeComponent();
            InitializeOpenFileDialogMultiple();
            comboBoxShapeClass.DataSource = Enum.GetValues(typeof(ShapeClass));
        }

        private void InitializeOpenFileDialogMultiple()
        {
            openFileDialogMultiple = new OpenFileDialog();
            openFileDialogMultiple.Filter = "Images (*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|" +
                "All files (*.*)|*.*";
            openFileDialogMultiple.Multiselect = true;
            openFileDialogMultiple.Title = "Select Multiple Images:";
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

        private void DrawTriangle(Graphics graphics, Triangle triangle)
        {
            if (graphics != null)
            {
                var pen = new Pen(Color.Green);
                graphics.DrawLine(pen, triangle.A, triangle.B);
                graphics.DrawLine(pen, triangle.B, triangle.C);
                graphics.DrawLine(pen, triangle.C, triangle.A);
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
            currentRelation = recognizer.GetRelations();
            //Clean some shits
            previousPointList = pointList.ToList();
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
            
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0:                   
                    ClearCanvas();
                    break;
                case 1:
                    ImageHandler imageHandler = new ImageHandler(new Bitmap(pictureBox1.Image));                    
                    List<List<Point>> edges = imageHandler.GetEdges();
                    Bitmap tempDraw = new Bitmap(pictureBox1.Image);
                    Graphics graphics = Graphics.FromImage(tempDraw);
                    foreach(List<Point> edge in edges)
                    {
                        List<Point> desu = edge.OrderBy(x => Math.Atan2(x.X, x.Y)).ToList();                        
                        ShapeRecognition recognizer = new ShapeRecognition(new Polygon2D(desu));
                        Polygon2D convexHull = recognizer.ConvexHull;
                        List<Point> convexHullPoints = convexHull.Points;
                        for (int i = 1; i < convexHullPoints.Count(); i++)
                        {
                            graphics.DrawLine(new Pen(Color.Red), convexHullPoints[i - 1], convexHullPoints[i]);
                        }
                        labelShapePointCountVal.Text = pointList.Count.ToString();
                        labelConvHullPntCntVal.Text = convexHullPoints.Count().ToString();
                        graphics.DrawRectangle(new Pen(Color.Blue), recognizer.BoundingRectangle);
                        DrawTriangle(graphics, recognizer.NestedTriangle);
                        currentRelation = recognizer.GetRelations();                        
                    }
                    pictureBox1.Image = tempDraw;
                    break;
            }
            ShapeClass selectedClassItem = (ShapeClass)comboBoxShapeClass.SelectedItem;
            ClassifiedShape classifiedShape = new ClassifiedShape(currentRelation, selectedClassItem);
            //ShapeClass shapeClass = Classifier.Classify(classifiedShape, features);

            //string messageBoxText = "Class: " + shapeClass.ToString();
            //string caption = "Class";
            //MessageBoxButtons button = MessageBoxButtons.OK;
            //MessageBox.Show(messageBoxText, caption, button);
            classifiedShapeBindingSource.Add(classifiedShape);
        }

        private void buttonDataGridClear_Click(object sender, EventArgs e)
        {
            dataGridViewClassifiedShape.Rows.Clear();
            dataGridViewClassifiedShape.Refresh();
        }

        private void buttonLoadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog.FileName;
            }
        }

        private void buttonSavePolygon_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(300,300);
            using(Graphics graphics = Graphics.FromImage(bitmap))
            {
                graphics.DrawLines(new Pen(Color.White), previousPointList.ToArray());
            }
            bitmap.Save(@"C:\Users\datafile4\Desktop\samples\graphics.bmp",ImageFormat.Bmp);
            Serializer.SerializeList(previousPointList, @"C:\Users\datafile4\Desktop\samples\original.xml");
        }

        private List<ClassifiedShape> GroupHistory(List<ClassifiedShape> records)
        {
            var groupedList = records
               .GroupBy(u => new { shapeClass = u.shapeClass })
               .Select(g => new ClassifiedShape(new Relations
               {
                   AchAerAlt = g.Average(p => p.AchAerAlt),
                   PchPer = g.Average(p => p.PchPer),
                   AltAch = g.Average(p => p.AltAch),
                   Pch2Ach = g.Average(p => p.Pch2Ach),
                   LenPch = g.Average(p => p.LenPch),
                   AltAer = g.Average(p => p.AltAer)
               }, g.Key.shapeClass)).ToList<ClassifiedShape>();
            return groupedList;
        }

        private void buttonClassify_Click(object sender, EventArgs e)
        {
            //List<ClassifiedShape> records = new List<ClassifiedShape>();
            //foreach (DataGridViewRow i in dataGridViewClassifiedShape.Rows)
            //{
            //    records.Add(i.DataBoundItem as ClassifiedShape);
            //}
            //var groupedList = GroupHistory(records);
            //foreach(var i in groupedList)
            //{
            //    Debug.WriteLine(i.shapeClass + " " + i.PchPer + " " + i.AchAerAlt);
            //}
            
        }

        private void buttonSaveCSV_Click(object sender, EventArgs e)
        {
            List<ClassifiedShape> records = new List<ClassifiedShape>();
            foreach(DataGridViewRow i in dataGridViewClassifiedShape.Rows)
            {
                records.Add(i.DataBoundItem as ClassifiedShape);
            }
            Database.WriteDB(records);
        }

        private void buttonLoadCSV_Click(object sender, EventArgs e)
        {
            List<ClassifiedShape> records = Database.ReadDB();
            foreach (ClassifiedShape i in records)
            {
                classifiedShapeBindingSource.Add(i);
            }
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

        }

        private void dataGridViewClassifiedShape_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            dataGridViewStatistics.Rows.Clear();
            dataGridViewStatistics.Refresh();
            List<ClassifiedShape> records = new List<ClassifiedShape>();
            foreach (DataGridViewRow i in dataGridViewClassifiedShape.Rows)
            {
                records.Add(i.DataBoundItem as ClassifiedShape);
            }
            features = GroupHistory(records);
            foreach (var i in features)
            {
                classifiedShapeBindingSource1.Add(i);
            }
        }

        private void openFileDialogImage_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void buttonLoadImageMult_Click(object sender, EventArgs e)
        {
            
            if(openFileDialogMultiple.ShowDialog() == DialogResult.OK)
            {
                //null;
            }
        }
    }
}

