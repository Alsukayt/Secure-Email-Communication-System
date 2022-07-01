using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace Secure_Email_Commnucation_Syestem1
{
    public partial class Sendmail : Form
    {
        string message;
        public Sendmail()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            char[] buffer = textBox4.Text.ToCharArray();
            for (int i = 0; i < buffer.Length; i++)
            {
                char letter = buffer[i];

                int shift = 3;
               
                
                    letter = (char)(letter + shift);
                    buffer[i] = letter;
       


            }

            for (int j = 0; j < buffer.Length; j++)
            {
                message += buffer[j];
            }

            
                MailMessage mail = new MailMessage();
                SmtpClient smtpserver = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress(textBox1.Text);
                textBox1.Text = "okduhdum@gmail.com";
                mail.To.Add(textBox2.Text);
                mail.Subject = textBox3.Text;
                mail.Body = message;
                smtpserver.Port = 587;
                smtpserver.Credentials = new System.Net.NetworkCredential(textBox1.Text, "m12345678s");
                smtpserver.EnableSsl = true;
                smtpserver.Send(mail);
                MessageBox.Show("Your Email is sent Successfully");

            

        }
    }
}
