using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        Bitmap bmp;
        Color color;
        public Form1()
        {
            InitializeComponent();
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            color = Color.Black;
            ToolTip t = new ToolTip();
            t.SetToolTip(buttonLine, "x1, y1, x2, y2");
            t.SetToolTip(buttonRect, "x1, y1, Ширина, Высота");
            t.SetToolTip(buttonEllipse, "x1, y1, Ширина, Высота");
            t.SetToolTip(buttonArc, "x1, y1, Ширина, Высота, Начальный угол, Конечный угол");
            t.SetToolTip(buttonTriangle, "x1, y1, x2, y2, x3, y3");
            t.SetToolTip(buttonFifthangle, "x1, y1, x2, y2, x3, y3, x4, y4, x5, y5");
            MessageBox.Show("Значения в пропущенных полях будут равнятся нулю");
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = bmp;
        }

        private void buttonLine_Click(object sender, EventArgs e)
        {
            Graphics graph = Graphics.FromImage(bmp);
            drawLine(graph);
            pictureBox1.Image = bmp;
        }

        private void buttonRect_Click(object sender, EventArgs e)
        {
            Graphics graph = Graphics.FromImage(bmp);
            drawRectangle(graph);
            pictureBox1.Image = bmp;
        }

        private void buttonEllipse_Click(object sender, EventArgs e)
        {
            Graphics graph = Graphics.FromImage(bmp);
            drawEllipse(graph);
            pictureBox1.Image = bmp;
        }

        private void buttonArc_Click(object sender, EventArgs e)
        {
            Graphics graph = Graphics.FromImage(bmp);
            drawArc(graph);
            pictureBox1.Image = bmp;
        }

        private void buttonTriangle_Click(object sender, EventArgs e)
        {
            Graphics graph = Graphics.FromImage(bmp);
            drawTriangle(graph);
            pictureBox1.Image = bmp;
        }

        private void buttonFifthangle_Click(object sender, EventArgs e)
        {
            Graphics graph = Graphics.FromImage(bmp);
            drawFifthangle(graph);
            pictureBox1.Image = bmp;
        }

        private void drawLine(Graphics graph)
        {
            Pen pen = new Pen(colorDialog1.Color);
            int x1 = 0, y1 = 0, x2 = 0, y2 = 0;
            try
            {
                x1 = (int)Convert.ToInt32(textBox1.Text);
                y1 = (int)Convert.ToInt32(textBox2.Text);
                x2 = (int)Convert.ToInt32(textBox3.Text);
                y2 = (int)Convert.ToInt32(textBox4.Text);
            } catch (FormatException){}
            graph.DrawLine(pen, x1, y1, x2, y2);
        }

        private void drawRectangle(Graphics graph)
        {
            Pen pen = new Pen(color);
            int x1 = 0, y1 = 0, width = 0, height = 0;
            try
            {
                x1 = (int)Convert.ToInt32(textBox1.Text);
                y1 = (int)Convert.ToInt32(textBox2.Text);
                width = (int)Convert.ToInt32(textBox11.Text);
                height = (int)Convert.ToInt32(textBox12.Text);
            }
            catch (FormatException) { }
            graph.DrawRectangle(pen, x1, y1, width, height);
        }

        private void drawEllipse(Graphics graph)
        {
            Pen pen = new Pen(color);
            int x = 0, y = 0, width = 0, height = 0;
            try
            {
                x = (int)Convert.ToInt32(textBox1.Text);
                y = (int)Convert.ToInt32(textBox2.Text);
                width = (int)Convert.ToInt32(textBox11.Text);
                height = (int)Convert.ToInt32(textBox12.Text);
            }
            catch (FormatException) { }
            graph.DrawEllipse(pen, x, y, width, height);
        }

        private void drawArc(Graphics graph)
        {
            Pen pen = new Pen(color);
            int x = 0, y = 0, width = 0, height = 0, startAngle = 0, sweepAngle = 0;
            try
            {
                x = (int)Convert.ToInt32(textBox1.Text);
                y = (int)Convert.ToInt32(textBox2.Text);
                width = (int)Convert.ToInt32(textBox11.Text);
                height = (int)Convert.ToInt32(textBox12.Text);
                startAngle = (int)Convert.ToInt32(textBox13.Text);
                sweepAngle = (int)Convert.ToInt32(textBox14.Text);
            }
            catch (FormatException) { }
            graph.DrawArc(pen, x, y, width, height, startAngle, sweepAngle);
        }

        private void drawTriangle(Graphics graph)
        {
            Pen pen = new Pen(color);
            int x1 = 0, y1 = 0, x2 = 0, y2 = 0, x3 = 0, y3 = 0;
            try
            {
                x1 = (int)Convert.ToInt32(textBox1.Text);
                y1 = (int)Convert.ToInt32(textBox2.Text);
                x2 = (int)Convert.ToInt32(textBox3.Text);
                y2 = (int)Convert.ToInt32(textBox4.Text);
                x3 = (int)Convert.ToInt32(textBox5.Text);
                y3 = (int)Convert.ToInt32(textBox6.Text);
            }
            catch (FormatException) { }
            Point[] points = new Point[3];
            points[0].X = x1; points[0].Y = y1;
            points[1].X = x2; points[1].Y = y2;
            points[2].X = x3; points[2].Y = y3;
            graph.DrawPolygon(pen, points);
        }

        private void drawFifthangle(Graphics graph)
        {
            Pen pen = new Pen(color);
            int x1 = 0, y1 = 0, x2 = 0, y2 = 0, x3 = 0, y3 = 0, x4 = 0, y4 = 0, x5 = 0, y5 = 0;
            try
            {
                x1 = (int)Convert.ToInt32(textBox1.Text);
                y1 = (int)Convert.ToInt32(textBox2.Text);
                x2 = (int)Convert.ToInt32(textBox3.Text);
                y2 = (int)Convert.ToInt32(textBox4.Text);
                x3 = (int)Convert.ToInt32(textBox5.Text);
                y3 = (int)Convert.ToInt32(textBox6.Text);
                x4 = (int)Convert.ToInt32(textBox7.Text);
                y4 = (int)Convert.ToInt32(textBox8.Text);
                x5 = (int)Convert.ToInt32(textBox9.Text);
                y5 = (int)Convert.ToInt32(textBox10.Text);
            }
            catch (FormatException) { }
            Point[] points = new Point[5];
            points[0].X = x1; points[0].Y = y1;
            points[1].X = x2; points[1].Y = y2;
            points[2].X = x3; points[2].Y = y3;
            points[3].X = x4; points[3].Y = y4;
            points[4].X = x5; points[4].Y = y5;
            graph.DrawPolygon(pen, points);
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            colorDialog1.AllowFullOpen = false;
            colorDialog1.ShowHelp = true;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
                color = colorDialog1.Color;
        }
    }
}
