using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF01_eventHandler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawString(
                "Hello World"   //그려낼 문자열
                , Font          //폰트 정보 : Form의 control을 상속받기 때문에 Font라고 써도 인식된다.
                , Brushes.Black //글자색
                , 10, 10);      //x, y좌표에 대한 정보

            //선
            e.Graphics.DrawLine(Pens.Red, 10, 10, 200, 10);
            //원
            e.Graphics.DrawEllipse(Pens.Blue, 10, 20, 100, 100);
            //사각형
            e.Graphics.DrawRectangle(Pens.Black, 130, 20, 100, 100);
        }
    }
}
