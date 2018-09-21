using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF04_Color
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            string str = "alpha: " + Color.Blue.A + ", red: " + Color.Blue.R +
                ", Green : " + Color.Blue.G + ", Blue : " + Color.Blue.B;

            e.Graphics.DrawString(str, Font, Brushes.Blue, 10, 10);


            Color myColor = Color.FromArgb(255, 0, 0);
            Pen myPen = new Pen(myColor);
            myPen.Width = 5.0f; //펜의 선 굵기
            e.Graphics.DrawLine(myPen, 10, 10, 100, 10);    //내가 정의한 Pen
            e.Graphics.DrawLine(Pens.Blue, 10, 20, 100, 20) ; //기본제공 Pens
            myPen.Dispose();

            SolidBrush myBrush = new SolidBrush(Color.Blue);
            e.Graphics.FillEllipse(myBrush, 10, 10, 100, 100);

            HatchBrush hatch = new HatchBrush(HatchStyle.Plaid, Color.Red, Color.Blue);
            e.Graphics.FillRectangle(hatch, 10, 10, 200, 200);

        }
    }
}
