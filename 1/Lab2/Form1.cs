using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics graph = Graphics.FromImage(bmp);
            Pen pen = new Pen(Color.Black);

            drawLine(graph, pen, Color.Cyan, 15, 150, 150, 15);

            drawRectangle(graph, pen, Color.Maroon, 85, 80, 170, 170);

            drawEllipse(graph, pen, Color.Blue, 86, 125, 168, 125);

            drawArc(graph, pen, Color.Black, 86, 43, 168, 81, 0, 180);

            drawTriangle(graph, pen, Color.Magenta, 256, 80, 256, 250, 370, 80);

            drawFifthangle(graph, pen, Color.YellowGreen, 165, 145, 125, 185, 145, 225, 185, 225, 205, 185);

            pictureBox1.Image = bmp;
        }

        private void drawLine(Graphics graph, Pen pen, Color color, int x1, int y1, int x2, int y2)
        {
            pen.Color = color;
            graph.DrawLine(pen, x1, y1, x2, y2);
        }

        private void drawRectangle(Graphics graph, Pen pen, Color color, int x1, int y1, int x2, int y2)
        {
            pen.Color = color;
            graph.DrawRectangle(pen, x1, y1, x2, y2);
        }

        private void drawEllipse(Graphics graph, Pen pen, Color color, int x, int y, int width, int height)
        {
            pen.Color = color;
            graph.DrawEllipse(pen, x, y, width, height);
        }

        private void drawArc(Graphics graph, Pen pen, Color color, int x, int y, int width, int height, int startAngle, int sweepAngle)
        {
            pen.Color = color;
            graph.DrawArc(pen, x, y, width, height, startAngle, sweepAngle);
        }

        private void drawTriangle(Graphics graph, Pen pen, Color color, int x1, int y1, int x2, int y2, int x3, int y3)
        {
            pen.Color = color;
            Point[] points = new Point[3];
            points[0].X = x1; points[0].Y = y1;
            points[1].X = x2; points[1].Y = y2;
            points[2].X = x3; points[2].Y = y3;
            graph.DrawPolygon(pen, points);
        }

        private void drawFifthangle(Graphics graph, Pen pen, Color color, int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4, int x5, int y5)
        {
            pen.Color = color;
            Point[] points = new Point[5];
            points[0].X = x1; points[0].Y = y1;
            points[1].X = x2; points[1].Y = y2;
            points[2].X = x3; points[2].Y = y3;
            points[3].X = x4; points[3].Y = y4;
            points[4].X = x5; points[4].Y = y5;
            graph.DrawPolygon(pen, points);
        }
    }
}
