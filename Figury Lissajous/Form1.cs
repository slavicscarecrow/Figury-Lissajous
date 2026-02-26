using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figury_Lissajous
{
    public partial class Lissajous : Form
    {
        static int x_center, y_center;
        static int new_x, new_y;
        static int old_x, old_y;
        static int t = 0;

        Pen myPen = new Pen(Color.MediumVioletRed);
        Graphics g = null;

        public Lissajous()
        {
            InitializeComponent();
            x_center = panel1.Width / 2;
            y_center = panel1.Height / 2;
            old_x = x_center;
            old_y = y_center;
        }
        void DrawPoint()
        {
            Point[] points =
            {
                new Point(x_center, y_center),
                new Point(0,0)
            };
            g.DrawLines(myPen, points);
        }
        double Sinus(int amplitude, int frequency, int shift, int time)
        {
            return amplitude * Math.Sin(2 * Math.PI * frequency* 0.01 * time + (shift*0.01745329252));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Start")
            {
                button1.Text = "Stop";
            }
            else button1.Text = "Start";
            timer1.Enabled = !timer1.Enabled;
        }

        private void Draw(object sender, EventArgs e)
        {
 
            new_x = (int)Sinus(hScrollBar4.Value, hScrollBar6.Value, hScrollBar5.Value, t)+x_center;
            new_y = (int)Sinus(hScrollBar3.Value, hScrollBar1.Value, hScrollBar2.Value, t)+y_center;
            Point[] points =
           {
                new Point(old_x, old_y),
                new Point(new_x,new_y)
            };
            g.DrawLines(myPen, points);
            old_x = new_x;
            old_y = new_y;
            t++;
        }

        private void Lissajous_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void hScrollBar6_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void hScrollBar4_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Erase_Click(object sender, EventArgs e)
        {
            panel1.Refresh();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            myPen.Width = 5;
            g = panel1.CreateGraphics();
        }
    }
}
