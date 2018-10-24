using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF06_Timer
{
    public partial class Form1 : Form
    {
        Rectangle[] rectangle;
        
        public Form1()
        {
            InitializeComponent();
            rectangle = new Rectangle[100];
        }

        //0.3초마다 계속 실행되며 100개씩 출력된다.
        private void timer1_Tick(object sender, EventArgs e)
        {
            Random random = new Random();

            for (int i = 0; i < 100; i++)
            {
                rectangle[i].X = random.Next(200);
                rectangle[i].Y = random.Next(200);
                rectangle[i].Width = 60;
                rectangle[i].Height = 60;
            }

            Invalidate();
            
            //start : Enable = true
            
            //end : Enable = false

        }

        //실제로 그려라
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                e.Graphics.DrawRectangle(Pens.Black, rectangle[i]);
            }
        }
    }
}
