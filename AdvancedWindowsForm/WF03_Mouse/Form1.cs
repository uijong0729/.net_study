using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF03_Mouse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void Form1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("click");
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("mouse click");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("버튼 눌렸네");
        }


        string str = "";

        //마우스 이동
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            //좌표값
            str = "X : " + e.X + ", Y : " + e.Y;
            
            //화면 갱신
            Invalidate();
        }

        //화면 그리기
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawString(str, Font, Brushes.Blue, 10, 10);
        }




    }
}
