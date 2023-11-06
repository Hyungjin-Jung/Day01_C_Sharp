using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // MessageBox.Show("안녕하세요우~");

            // 텍스트 박스에 메시지 출력
            textBox_print.Text = "이것은 \r\n 멀티라인 \r\n 텍스트박스 \r\n 인데요. ";
        }
    }
}
