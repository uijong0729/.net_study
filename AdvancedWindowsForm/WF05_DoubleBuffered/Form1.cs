using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF05_DoubleBuffered
{
    public partial class Form1 : Form
    {
        //이중 버퍼링에 사용할 수 있는 그래픽 버퍼를 만드는 메서드를 제공합니다.
        BufferedGraphicsContext context;
        BufferedGraphics graphics;
        Image image;

        public Form1()
        {
            InitializeComponent();

            //참조
            context = BufferedGraphicsManager.Current;

            //버퍼 크기 설정 (창 크기)
            context.MaximumBuffer = new Size(800, 600);

            //지정된 Graphics의 픽셀 형식을 사용하여 지정된 크기의 그래픽 버퍼를 만듭니다.
            graphics = context.Allocate(CreateGraphics(), new Rectangle(0, 0, 800, 600));

            //버퍼 지우고 배경색 깔아놓기
            graphics.Graphics.Clear(Color.Yellow);

            image = Image.FromFile(@"D:\notitle.png");
            SetClientSizeCore(800, 600);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Random rand = new Random();
            //실제로 화면에 출력
            for (int i = 0; i < 100; i++)
            {
                //Random.Next(0, 300); 지정 된 범위 내에서 임의의 정수 반환
                graphics.Graphics.DrawImage(image, rand.Next(0, 700), rand.Next(0, 500));
            }

            //백 버퍼에 있는 내용을 가져와서 화면에 그림
            graphics.Render(e.Graphics);


            //리소스를 이용한 이미지 가져오기
            Bitmap bitmap = Properties.Resources.Image1;
            e.Graphics.DrawImage(bitmap, 0, 0);
            
        }
    }
}
