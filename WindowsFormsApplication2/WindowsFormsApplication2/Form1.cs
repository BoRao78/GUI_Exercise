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
         /*   if (textBox1.Text.match("^[0-9]*$")
            {
                alert("只能输入字母或数字！");
                return false;
            }


            if (){
                textBox1.Text
            }
            int CRCtext = int(textBox1.Text);*/
            textBox2.Clear();
            textBox2.AppendText(textBox1.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 0 || e.KeyChar == 1 || e.KeyChar == '8')
            {
                e.Handled = true;
            }
            else
            {

            }
                 
        }
    }
}
