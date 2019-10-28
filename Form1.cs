using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cipher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Result of encryption: ";
            string to_encrypt = textBox1.Text;
            label1.Text = label1.Text + to_encrypt;
            char[] non_encrypt = to_encrypt.ToArray<char>();
            byte[] encrypted = new byte[non_encrypt.Length];
            for (int i = 0; i < non_encrypt.Length; i++)
            {
                encrypted[i] = Encoding.GetEncoding(1251).GetBytes(non_encrypt[i]);
            }
            //byte[] bytes = Encoding.GetEncoding(1251).GetBytes(input);

            //label1.Text = non_encrypt[3].ToString();
        }
    }
}
