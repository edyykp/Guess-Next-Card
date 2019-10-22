using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Net;
using System.Configuration;
namespace WindowsFormsApp1
{
    
    public partial class register : Form
    {
        Boolean flag ;
         string connectionString=@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\login1.mdf;Integrated Security=True;Connect Timeout=30";
        Timer t1 = new Timer();
        Timer t2 = new Timer();
        public register()
        {
            InitializeComponent();
           
        }
        
        private void Form2_Load(object sender, EventArgs e)
        {
            flag = true;
            Opacity = 0;      

            t1.Interval = 10;  
            t1.Tick += new EventHandler(fadeIn);   
            t1.Start();
            this.Cursor = new Cursor(Application.StartupPath + "\\Cursor3.cur");
        }
        void fadeIn(object sender, EventArgs e)
        { if (flag)
            {
                if (Opacity >= 1)
                    t1.Stop();
                else
                    Opacity += 0.02;
            }
            else
            {
                if (Opacity > 0)
                    Opacity -= 0.02;
                else
                {       t1.Stop();
                this.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            flag = false;
            t1.Start();
        }
        void FadeOut(object sender, EventArgs e)
        {
            if (Opacity > 0)
                Opacity -= 0.025;
            else t2.Stop();
        }
        public void button1_Click(object sender, EventArgs e)
        {
            int ok = 0;
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
            { MessageBox.Show("Complete every blank space!"); }
            else
                if (textBox2.Text != textBox3.Text) MessageBox.Show("Wrong password!");
            else
                if (textBox4.Text.IndexOf("@")<0) MessageBox.Show("Please type an existing e-mail address");
            else
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("UserAdd", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@username", textBox1.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@password", textBox2.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@email", textBox4.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@prenume", textBox5.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@nume", textBox6.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@highscore", 1);
                    sqlCmd.ExecuteNonQuery();
                }


                using (var mail = new MailMessage())
                {
                    mail.From = new MailAddress("eduard.c.stoica10@gmail.com", "Eduard Stoica");

                    try
                    {
                        mail.To.Add(textBox4.Text.Trim());
                    }
                    catch(Exception ex)
                    {
                        ok = 1;
                        MessageBox.Show("Please type an existing e-mail address");
                    }
                    mail.Subject = "Hello";
                    mail.Body = "Hello, this is my game. Enjoy!";
                    using (var smtpServer = new SmtpClient("smtp.mail.yahoo.com", 587))
                    {
                        smtpServer.Credentials = new NetworkCredential("eduard.c.stoica10@gmail.com", "...........");
                        smtpServer.EnableSsl = true;
                        smtpServer.DeliveryMethod = SmtpDeliveryMethod.Network;
                        smtpServer.DeliveryFormat = SmtpDeliveryFormat.International;

                        try
                        {
                            smtpServer.Send(mail);
                        }
                        catch (Exception ex)
                        {

                        }
                    }
                }
                if(ok==0) MessageBox.Show("Register sucessful!");
            }
            Clear();
        }

        
        
        void Clear()
        {
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = textBox6.Text = "";
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
                if (!(button2.Font.Bold))
                {
                    button2.Font = new Font(button2.Font, FontStyle.Bold);
                }
                button2.BackColor = Color.Transparent;         
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            
                if ((button2.Font.Bold))
                {
                    button2.Font = new Font(button2.Font, FontStyle.Regular);
                }
                button2.BackColor = Color.Transparent;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            
                if (!(button1.Font.Bold))
                {
                    button1.Font = new Font(button1.Font, FontStyle.Bold);
                }
                button1.BackColor = Color.Transparent;
            
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            

                if ((button1.Font.Bold))
                {
                    button1.Font = new Font(button1.Font, FontStyle.Regular);
                }
                button1.BackColor = Color.Transparent;
            
        }
    }
}

