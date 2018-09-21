using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF05_Image
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            string filepath = @"D:\notitle.png";
            
            /*
            Image myImage = Image.FromFile(@"D:\notitle.png");
            e.Graphics.DrawImage(myImage, 0, 0);
            */

            Bitmap myBit = new Bitmap(filepath);

            //이미지의 길이와 높이를 매개변수로해서 창의 크기 설정
            SetClientSizeCore(myBit.Width, myBit.Height);

            e.Graphics.DrawImage(myBit, 0, 0);
        }
    }
}
