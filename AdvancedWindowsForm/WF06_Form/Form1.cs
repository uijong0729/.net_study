using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF06_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Width = 500;
            Height = 500;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("폼 로드 이벤트");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //메시지 박스
            DialogResult result 
                = MessageBox.Show("종료 하시겠습니까?", 
                                    "종료", 
                                    MessageBoxButtons.YesNo);

            //저장된 결과를 비교 (메시지 박스의 결과는 bool타입이 아니라 DialogResult타입)
            if(result == DialogResult.No)
            {
                e.Cancel = true;
            }
            

            
        }
    }
}
