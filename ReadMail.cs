using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Secure_Email_Commnucation_Syestem1
{
    public partial class ReadMail : Form
    {
        public ReadMail()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string value = textBox1.Text;
            char[] buffer = value.ToCharArray();
            for (int i = 0; i < buffer.Length; i++)
            {
                char letter = buffer[i];
                
                int shift = 3;
                
                
                    letter = (char)(letter - shift);
                    textBox4.Text += letter;
  
            }

           //for (int j = 0; j < buffer.Length; j++)
         //  {
                
          // }
        }
    }
}
