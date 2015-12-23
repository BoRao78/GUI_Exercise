using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e){
            //码字10011
            int VerCode = 0x13;
            int CRCOrg = int.Parse(textBox1.Text);
            CRCOrg = CRCOrg / 100 * 4 + (CRCOrg / 10 - CRCOrg / 100 * 10) * 2 + CRCOrg % 10;//字符串转换为二进制数
            int CRCCode = CRCOrg = CRCOrg * 16;
            int m = 4;
            while(m>=1) {
                if (CRCCode >= (VerCode * m))
                    CRCCode = CRCCode ^ (VerCode * m);
                m = m / 2;        
            }
            textBox2.Clear();
            textBox2.AppendText(Convert.ToString(CRCOrg + CRCCode, 2).PadLeft(7, '0'));//不满7位补零
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '0' || e.KeyChar == '1' || e.KeyChar == (char)8) {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Binary Only");
            }
                 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '0' || e.KeyChar == '1' || e.KeyChar == (char)8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Binary Only");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int HMOrg = int.Parse(textBox4.Text);
            int HM3 = HMOrg % 10;
            int HM4 = HMOrg % 100 / 10;
            int HM5 = HMOrg % 1000 / 100;
            int HM6 = HMOrg / 1000;
            int HM2 = HM6 ^ HM5 ^ HM4;
            int HM1 = HM6 ^ HM5 ^ HM3;
            int HM0 = HM6 ^ HM4 ^ HM3;
            textBox3.Clear();
            textBox3.AppendText(Convert.ToString( HM6*64+HM5*32+HM4*16+HM3*8+HM2*4+HM1*2+HM0, 2).PadLeft(7,'0'));
        }
    }
}
