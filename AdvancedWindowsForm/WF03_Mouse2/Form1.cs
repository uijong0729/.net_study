using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF03_Mouse2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //Point는 x와 y를 저장할 수 있는 구조체이다.
        List<Point> listPoint = new List<Point>();

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //마우스 클릭이 3번째일때 삼각형을 그린다.
            if(listPoint.Count == 3)
            {
                //색깔, X좌표, Y좌표
                e.Graphics.DrawLine(Pens.Black, listPoint[0], listPoint[1]);
                e.Graphics.DrawLine(Pens.Black, listPoint[1], listPoint[2]);
                e.Graphics.DrawLine(Pens.Black, listPoint[2], listPoint[0]);
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Point point = new Point(e.X, e.Y);

            //삼각형을 그리면 리스트 초기화
            if (listPoint.Count == 3)
            {
                listPoint.Clear();
            }

            //좌표값 저장
            listPoint.Add(point);

            //화면 갱신
            Invalidate();
        }
    }
}
