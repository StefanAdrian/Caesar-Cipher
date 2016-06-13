using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caesar_Cipher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char temp;
            char[] encryptedText = textBox.Text.ToCharArray();
            for (int i = 0; i < encryptedText.Length; i++)
            {
                if (encryptedText[i] == ' ')
                {
                    continue;
                }
                else
                {
                    temp = (char)(encryptedText[i] + Convert.ToInt32(keyTextBox.Text));
                    if (temp > 'z')
                    {
                        temp = (char)(temp - 26);
                    }
                    else if (temp < 'a')
                    {
                        temp = (char)(temp + 26);
                    }
                    encryptedText[i] = temp;
                }
            }
            string result = new string(encryptedText);
            resultTextBox.Text = result;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            char temp;
            char[] decryptedText = textBox.Text.ToCharArray();
            for (int i = 0; i < decryptedText.Length; i++)
            {
                if (decryptedText[i] == ' ')
                {
                    continue;
                }
                else
                {
                    temp = (char)(decryptedText[i] - Convert.ToInt32(keyTextBox.Text));
                    if (temp > 'z')
                    {
                        temp = (char)(temp - 26);
                    }
                    else if (temp < 'a')
                    {
                        temp = (char)(temp + 26);
                    }
                    decryptedText[i] = temp;
                }
            }
            string result = new string(decryptedText);
            resultTextBox.Text = result;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
