using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF04_GDI_
{
    public partial class Form1 : Form
    {
        Point[] circle;
        int count;

        public Form1()
        {
            InitializeComponent();

            circle = new Point[100];
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            for(int i = 0; i < count; i++)
            {
                //중심점을 기준으로 -10 X좌표 -10 Y좌표 20길이 20높이
                e.Graphics.DrawEllipse(Pens.Black, circle[i].X - 10, circle[i].Y - 10, 20, 20);

            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            circle[count].X = e.X;
            circle[count].Y = e.Y;
            count++;
            Invalidate(); //갱신
        }
    }
}
