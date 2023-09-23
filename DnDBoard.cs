using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hexgrid
{
    public partial class DnDBoard : Form
    {
        public DnDBoard()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            var graphics = e.Graphics;

            //Get the middle of the panel
            var x_0 = panel1.Width / 2;
            var y_0 = panel1.Height / 2;

            var shape = new PointF[6];

            var r = 70; //70 px radius 

            //Create 6 points
            for (int a = 0; a < 6; a++)
            {
                shape[a] = new PointF(
                    x_0 + r * (float)Math.Cos(a * 60 * Math.PI / 180f),
                    y_0 + r * (float)Math.Sin(a * 60 * Math.PI / 180f));
            }

            graphics.DrawPolygon(Pens.DimGray, shape);

            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.DimGray);
            graphics.FillPolygon(myBrush, shape);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            var graphics = e.Graphics;

            //Get the middle of the panel
            var x_0 = panel1.Width / 2;
            var y_0 = panel1.Height / 2;

            var shape = new PointF[6];

            var r = 70; //70 px radius 

            //Create 6 points
            for (int a = 0; a < 6; a++)
            {
                shape[a] = new PointF(
                    x_0 + r * (float)Math.Cos(a * 60 * Math.PI / 180f),
                    y_0 + r * (float)Math.Sin(a * 60 * Math.PI / 180f));
            }

            graphics.DrawPolygon(Pens.LightSeaGreen, shape);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            var graphics = e.Graphics;

            //Get the middle of the panel
            var x_0 = panel3.Width / 2;
            var y_0 = panel3.Height / 2;

            var shape = new PointF[6];

            var r = 70; //70 px radius 

            //Create 6 points
            for (int a = 0; a < 6; a++)
            {
                shape[a] = new PointF(
                    x_0 + r * (float)Math.Cos(a * 60 * Math.PI / 180f),
                    y_0 + r * (float)Math.Sin(a * 60 * Math.PI / 180f));
            }

            graphics.DrawPolygon(Pens.LightSeaGreen, shape);

            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.LightSeaGreen);
            graphics.FillPolygon(myBrush, shape);
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            var graphics = e.Graphics;

            //Get the middle of the panel
            var x_0 = panel5.Width / 2;
            var y_0 = panel5.Height / 2;

            var shape = new PointF[6];

            var r = 70; //70 px radius 

            //Create 6 points
            for (int a = 0; a < 6; a++)
            {
                shape[a] = new PointF(
                    x_0 + r * (float)Math.Cos(a * 60 * Math.PI / 180f),
                    y_0 + r * (float)Math.Sin(a * 60 * Math.PI / 180f));
            }

            graphics.DrawPolygon(Pens.DarkSlateBlue, shape);

            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.DarkSlateBlue);
            graphics.FillPolygon(myBrush, shape);
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {
            var graphics = e.Graphics;

            //Get the middle of the panel
            var x_0 = panel5.Width / 2;
            var y_0 = panel5.Height / 2;

            var shape = new PointF[6];

            var r = 70; //70 px radius 

            //Create 6 points
            for (int a = 0; a < 6; a++)
            {
                shape[a] = new PointF(
                    x_0 + r * (float)Math.Cos(a * 60 * Math.PI / 180f),
                    y_0 + r * (float)Math.Sin(a * 60 * Math.PI / 180f));
            }

            graphics.DrawPolygon(Pens.SandyBrown, shape);

            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.SandyBrown);
            graphics.FillPolygon(myBrush, shape);
        }


        private void panel9_Paint(object sender, PaintEventArgs e)
        {
            var graphics = e.Graphics;

            //Get the middle of the panel
            var x_0 = panel5.Width / 2;
            var y_0 = panel5.Height / 2;

            var shape = new PointF[6];

            var r = 70; //70 px radius 

            //Create 6 points
            for (int a = 0; a < 6; a++)
            {
                shape[a] = new PointF(
                    x_0 + r * (float)Math.Cos(a * 60 * Math.PI / 180f),
                    y_0 + r * (float)Math.Sin(a * 60 * Math.PI / 180f));
            }

            graphics.DrawPolygon(Pens.DimGray, shape);

            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.DimGray);
            graphics.FillPolygon(myBrush, shape);
        }


        private void panel11_Paint(object sender, PaintEventArgs e)
        {
            var graphics = e.Graphics;

            //Get the middle of the panel
            var x_0 = panel5.Width / 2;
            var y_0 = panel5.Height / 2;

            var shape = new PointF[6];

            var r = 70; //70 px radius 

            //Create 6 points
            for (int a = 0; a < 6; a++)
            {
                shape[a] = new PointF(
                    x_0 + r * (float)Math.Cos(a * 60 * Math.PI / 180f),
                    y_0 + r * (float)Math.Sin(a * 60 * Math.PI / 180f));
            }

            graphics.DrawPolygon(Pens.LightSeaGreen, shape);

            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.LightSeaGreen);
            graphics.FillPolygon(myBrush, shape);
        }


        private void panel13_Paint(object sender, PaintEventArgs e)
        {
            var graphics = e.Graphics;

            //Get the middle of the panel
            var x_0 = panel5.Width / 2;
            var y_0 = panel5.Height / 2;

            var shape = new PointF[6];

            var r = 70; //70 px radius 

            //Create 6 points
            for (int a = 0; a < 6; a++)
            {
                shape[a] = new PointF(
                    x_0 + r * (float)Math.Cos(a * 60 * Math.PI / 180f),
                    y_0 + r * (float)Math.Sin(a * 60 * Math.PI / 180f));
            }

            graphics.DrawPolygon(Pens.DarkCyan, shape);

            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.DarkCyan);
            graphics.FillPolygon(myBrush, shape);
        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {
            var graphics = e.Graphics;

            //Get the middle of the panel
            var x_0 = panel5.Width / 2;
            var y_0 = panel5.Height / 2;

            var shape = new PointF[6];

            var r = 70; //70 px radius 

            //Create 6 points
            for (int a = 0; a < 6; a++)
            {
                shape[a] = new PointF(
                    x_0 + r * (float)Math.Cos(a * 60 * Math.PI / 180f),
                    y_0 + r * (float)Math.Sin(a * 60 * Math.PI / 180f));
            }

            graphics.DrawPolygon(Pens.OrangeRed, shape);

            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.OrangeRed);
            graphics.FillPolygon(myBrush, shape);
        }

        private void panel17_Paint(object sender, PaintEventArgs e)
        {
            var graphics = e.Graphics;

            //Get the middle of the panel
            var x_0 = panel5.Width / 2;
            var y_0 = panel5.Height / 2;

            var shape = new PointF[6];

            var r = 70; //70 px radius 

            //Create 6 points
            for (int a = 0; a < 6; a++)
            {
                shape[a] = new PointF(
                    x_0 + r * (float)Math.Cos(a * 60 * Math.PI / 180f),
                    y_0 + r * (float)Math.Sin(a * 60 * Math.PI / 180f));
            }

            graphics.DrawPolygon(Pens.SandyBrown, shape);

            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.SandyBrown);
            graphics.FillPolygon(myBrush, shape);
        }

        private void panel19_Paint(object sender, PaintEventArgs e)
        {
            var graphics = e.Graphics;

            //Get the middle of the panel
            var x_0 = panel5.Width / 2;
            var y_0 = panel5.Height / 2;

            var shape = new PointF[6];

            var r = 70; //70 px radius 

            //Create 6 points
            for (int a = 0; a < 6; a++)
            {
                shape[a] = new PointF(
                    x_0 + r * (float)Math.Cos(a * 60 * Math.PI / 180f),
                    y_0 + r * (float)Math.Sin(a * 60 * Math.PI / 180f));
            }

            graphics.DrawPolygon(Pens.DimGray, shape);

            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.DimGray);
            graphics.FillPolygon(myBrush, shape);
        }

        private void panel21_Paint(object sender, PaintEventArgs e)
        {
            var graphics = e.Graphics;

            //Get the middle of the panel
            var x_0 = panel5.Width / 2;
            var y_0 = panel5.Height / 2;

            var shape = new PointF[6];

            var r = 70; //70 px radius 

            //Create 6 points
            for (int a = 0; a < 6; a++)
            {
                shape[a] = new PointF(
                    x_0 + r * (float)Math.Cos(a * 60 * Math.PI / 180f),
                    y_0 + r * (float)Math.Sin(a * 60 * Math.PI / 180f));
            }

            graphics.DrawPolygon(Pens.LightSeaGreen, shape);

            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.LightSeaGreen);
            graphics.FillPolygon(myBrush, shape);
        }

        private void panel23_Paint(object sender, PaintEventArgs e)
        {
            var graphics = e.Graphics;

            //Get the middle of the panel
            var x_0 = panel5.Width / 2;
            var y_0 = panel5.Height / 2;

            var shape = new PointF[6];

            var r = 70; //70 px radius 

            //Create 6 points
            for (int a = 0; a < 6; a++)
            {
                shape[a] = new PointF(
                    x_0 + r * (float)Math.Cos(a * 60 * Math.PI / 180f),
                    y_0 + r * (float)Math.Sin(a * 60 * Math.PI / 180f));
            }

            graphics.DrawPolygon(Pens.PaleTurquoise, shape);

            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.PaleTurquoise);
            graphics.FillPolygon(myBrush, shape);
        }

        private void panel31_Paint(object sender, PaintEventArgs e)
        {
            var graphics = e.Graphics;

            //Get the middle of the panel
            var x_0 = panel5.Width / 2;
            var y_0 = panel5.Height / 2;

            var shape = new PointF[6];

            var r = 70; //70 px radius 

            //Create 6 points
            for (int a = 0; a < 6; a++)
            {
                shape[a] = new PointF(
                    x_0 + r * (float)Math.Cos(a * 60 * Math.PI / 180f),
                    y_0 + r * (float)Math.Sin(a * 60 * Math.PI / 180f));
            }

            graphics.DrawPolygon(Pens.SandyBrown, shape);

            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.SandyBrown);
            graphics.FillPolygon(myBrush, shape);

        }

        private void panel29_Paint(object sender, PaintEventArgs e)
        {
            var graphics = e.Graphics;

            //Get the middle of the panel
            var x_0 = panel5.Width / 2;
            var y_0 = panel5.Height / 2;

            var shape = new PointF[6];

            var r = 70; //70 px radius 

            //Create 6 points
            for (int a = 0; a < 6; a++)
            {
                shape[a] = new PointF(
                    x_0 + r * (float)Math.Cos(a * 60 * Math.PI / 180f),
                    y_0 + r * (float)Math.Sin(a * 60 * Math.PI / 180f));
            }

            graphics.DrawPolygon(Pens.DimGray, shape);

            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.DimGray);
            graphics.FillPolygon(myBrush, shape);
        }

        private void panel27_Paint(object sender, PaintEventArgs e)
        {
            var graphics = e.Graphics;

            //Get the middle of the panel
            var x_0 = panel5.Width / 2;
            var y_0 = panel5.Height / 2;

            var shape = new PointF[6];

            var r = 70; //70 px radius 

            //Create 6 points
            for (int a = 0; a < 6; a++)
            {
                shape[a] = new PointF(
                    x_0 + r * (float)Math.Cos(a * 60 * Math.PI / 180f),
                    y_0 + r * (float)Math.Sin(a * 60 * Math.PI / 180f));
            }

            graphics.DrawPolygon(Pens.LightSeaGreen, shape);

            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.LightSeaGreen);
            graphics.FillPolygon(myBrush, shape);
        }

        private void panel25_Paint(object sender, PaintEventArgs e)
        {
            var graphics = e.Graphics;

            //Get the middle of the panel
            var x_0 = panel5.Width / 2;
            var y_0 = panel5.Height / 2;

            var shape = new PointF[6];

            var r = 70; //70 px radius 

            //Create 6 points
            for (int a = 0; a < 6; a++)
            {
                shape[a] = new PointF(
                    x_0 + r * (float)Math.Cos(a * 60 * Math.PI / 180f),
                    y_0 + r * (float)Math.Sin(a * 60 * Math.PI / 180f));
            }

            graphics.DrawPolygon(Pens.DarkCyan, shape);

            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.DarkCyan);
            graphics.FillPolygon(myBrush, shape);
        }

        private void panel37_Paint(object sender, PaintEventArgs e)
        {
            var graphics = e.Graphics;

            //Get the middle of the panel
            var x_0 = panel5.Width / 2;
            var y_0 = panel5.Height / 2;

            var shape = new PointF[6];

            var r = 70; //70 px radius 

            //Create 6 points
            for (int a = 0; a < 6; a++)
            {
                shape[a] = new PointF(
                    x_0 + r * (float)Math.Cos(a * 60 * Math.PI / 180f),
                    y_0 + r * (float)Math.Sin(a * 60 * Math.PI / 180f));
            }

            graphics.DrawPolygon(Pens.SandyBrown, shape);

            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.SandyBrown);
            graphics.FillPolygon(myBrush, shape);

        }

        private void panel35_Paint(object sender, PaintEventArgs e)
        {
            var graphics = e.Graphics;

            //Get the middle of the panel
            var x_0 = panel5.Width / 2;
            var y_0 = panel5.Height / 2;

            var shape = new PointF[6];

            var r = 70; //70 px radius 

            //Create 6 points
            for (int a = 0; a < 6; a++)
            {
                shape[a] = new PointF(
                    x_0 + r * (float)Math.Cos(a * 60 * Math.PI / 180f),
                    y_0 + r * (float)Math.Sin(a * 60 * Math.PI / 180f));
            }

            graphics.DrawPolygon(Pens.DimGray, shape);

            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.DimGray);
            graphics.FillPolygon(myBrush, shape);
        }

        private void panel33_Paint(object sender, PaintEventArgs e)
        {
            var graphics = e.Graphics;

            //Get the middle of the panel
            var x_0 = panel5.Width / 2;
            var y_0 = panel5.Height / 2;

            var shape = new PointF[6];

            var r = 70; //70 px radius 

            //Create 6 points
            for (int a = 0; a < 6; a++)
            {
                shape[a] = new PointF(
                    x_0 + r * (float)Math.Cos(a * 60 * Math.PI / 180f),
                    y_0 + r * (float)Math.Sin(a * 60 * Math.PI / 180f));
            }

            graphics.DrawPolygon(Pens.LightSeaGreen, shape);

            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.LightSeaGreen);
            graphics.FillPolygon(myBrush, shape);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void nextDayButton_Click(object sender, EventArgs e)
        {

        }
    }
}
