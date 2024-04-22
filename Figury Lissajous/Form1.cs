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
    public partial class Form1 : Form
    {
        static int x_center, y_center;
        static int nowy_x, nowy_y;
        static int stary_x, stary_y;
        static int t = 0;

        Pen mojePioro = new Pen(Color.MediumVioletRed);
        Graphics g = null;

        public Form1()
        {
            InitializeComponent();
            x_center = panel1.Width / 2;
            y_center = panel1.Height / 2;
            stary_x = x_center;
            stary_y = y_center;
        }
        void RysujPunkt()
        {
            Point[] points =
            {
                new Point(x_center, y_center),
                new Point(0,0)
            };
            g.DrawLines(mojePioro, points);
        }
        double Sinus(int amplituda, int czestotliwosc, int przesuniecie, int czas)
        {
            return amplituda * Math.Sin(2 * Math.PI * czestotliwosc* 0.01 * czas + (przesuniecie*0.01745329252));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
        }

        private void Rysuj(object sender, EventArgs e)
        {
 
            nowy_x = (int)Sinus(hScrollBar4.Value, hScrollBar6.Value, hScrollBar5.Value, t)+x_center;
            nowy_y = (int)Sinus(hScrollBar3.Value, hScrollBar1.Value, hScrollBar2.Value, t)+y_center;
            Point[] points =
           {
                new Point(stary_x, stary_y),
                new Point(nowy_x,nowy_y)
            };
            g.DrawLines(mojePioro, points);
            stary_x = nowy_x;
            stary_y = nowy_y;
            t++;
        }

        private void Form1_Load(object sender, EventArgs e)
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

        private void Wymaz_Click(object sender, EventArgs e)
        {
            panel1.Refresh();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            mojePioro.Width = 5;
            g = panel1.CreateGraphics();
        }
    }
}
