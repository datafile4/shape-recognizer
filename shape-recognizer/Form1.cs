using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shape_recognizer
{
    public partial class Form1 : Form
    {
        private Graphics graphObj;
        private Point _lastLoc;
        bool mouseIsDown = false;
        List<Point> points_list = new List<Point>();

        public Form1()
        {
            InitializeComponent();
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
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            if(graphObj != null)
            {
                graphObj.Clear(graphPanel.BackColor);
            }
        }
    }
}

