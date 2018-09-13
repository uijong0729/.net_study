using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF03_Mouse3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //C#에서 지원하는 사각형 구조체
        Rectangle rect;

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            string str = "left : " + rect.X +
                "top : " + rect.Y +
                "right : " + rect.Right +
                "bottom : " + rect.Bottom;

            e.Graphics.DrawRectangle(Pens.Black, rect);
            e.Graphics.DrawString(str, Font, Brushes.Blue, 10, 10);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            //변의 길이 : 마우스의 현재위치 - 처음 마우스를 눌렀던 위치 ( +1 )
            if(e.Button == MouseButtons.Left)
            {
                //rect는 구조체이므로 여기서 대입해도 된다.
                //길이정보에 대한 데이터 삽입
                rect.Width = e.X - rect.X + 1;
                rect.Height = e.Y - rect.Y + 1;
                Invalidate();
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            //마우스를 클릭했을때 클릭한 지점의 X와 Y좌표를 구조체에 입력하고
            //나머지 값은 초기화한다.
            rect.X = e.X;
            rect.Y = e.Y;

            //길이정보는 나중에 갱신
            rect.Width = 0;
            rect.Height = 0;
            Invalidate();
        }
    }


}
