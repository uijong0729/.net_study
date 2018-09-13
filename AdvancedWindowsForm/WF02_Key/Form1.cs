using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF02_Key
{
    public partial class Form1 : Form
    {
       

        public Form1()
        {
            InitializeComponent();
        }

        //모든 키 눌림
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            //MessageBox.Show(e.KeyValue + " : Key Down");
            if (e.KeyCode == Keys.A && e.Shift && e.Control)
            {
                MessageBox.Show("KeyCode + 컨트롤 + 쉬프트 동시눌림" );
            }

            //KeyCode 와 Keys비교
            switch(e.KeyCode)
            {
                case Keys.A:
                    MessageBox.Show("A키");
                    break;
                case Keys.B:
                    MessageBox.Show("B키");
                    break;
                case Keys.C:
                    MessageBox.Show("C키");
                    break;
            }

            if(e.Modifiers == (Keys.Shift | Keys.Control))
            {
                MessageBox.Show("modifiers : shift + control");
            }

            // | 연산은 같이 눌리는 조건을 체크하는 것임
            if((e.KeyCode == Keys.A) && (e.Modifiers == (Keys.Shift | Keys.Alt)))
            {
                MessageBox.Show("A키와의 조합");
            }

            //KeyData를 이용하는 경우
            if(e.KeyData == (Keys.A | Keys.Shift | Keys.Control))
            {
                MessageBox.Show("A + shift + Control");
            }

        }

        //글자를 담을 객체
        StringBuilder sb = new StringBuilder();
        
        //문자 키 눌림
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            sb.Append(e.KeyChar);

            //화면갱신
            Invalidate();
        }

        //화면에 그리는 이벤트
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawString(sb.ToString(), Font, Brushes.Black, 10, 10);
        }
    }
}
