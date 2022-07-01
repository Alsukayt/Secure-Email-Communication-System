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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sendmail sm = new Sendmail();
            this.Hide();
            sm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReadMail rm = new ReadMail();
            this.Hide();
            rm.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
