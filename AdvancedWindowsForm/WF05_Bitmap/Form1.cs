using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF05_Bitmap
{
    public partial class Form1 : Form
    {
        Bitmap bitmap;

        public Form1()
        {
            InitializeComponent();

            //생성자 영역이므로 이곳의 코드가 먼저 실행된다.

            //이미지 크기 고정값
            bitmap = new Bitmap(400, 300);
            //폼 클라이언트 크기 고정값
            SetClientSizeCore(400, 300);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //메모리에서 그려지는 부분
            Graphics bitGraphics = Graphics.FromImage(bitmap);
            
            /*
             * 매개변수가 없으면 그냥 클리어지만 
               매개변수를 지정하면 클리어 한 후 지정 색으로 화면을 채운다.
            */
            bitGraphics.Clear(Color.Yellow);
            
            for(int i = 0; i < 10; i++)
            {
                bitGraphics.DrawString("C# 프로그래밍", Font, Brushes.Blue, 10, 10*i);
                bitGraphics.DrawRectangle(Pens.Black, 100, 10*i, 200, 100);
            }

            e.Graphics.DrawImage(bitmap, 0, 0);
        }
    }
}
