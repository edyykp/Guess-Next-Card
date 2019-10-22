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
using System.Windows;
using WindowsFormsApp1.Properties;
using System.Diagnostics;

namespace WindowsFormsApp1
{
    
    public partial class login : Form
    {
        public static int hs;
        public static string username;
        Timer t1 = new Timer();
        Timer t2 = new Timer();
        public login()
        {
           
            InitializeComponent();
           
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
      
        private void Form1_Load(object sender, EventArgs e)
        {
          
            
            if (Properties.Settings.Default.username != string.Empty)
            {
                textBox1.Text = Properties.Settings.Default.username;
                textBox2.Text = Properties.Settings.Default.password;
                checkBox1.Checked = true;
            }
            this.Cursor = new Cursor(Application.StartupPath + "\\Cursor3.cur");
            
           Opacity = 1;
           
 
            
            
        }
        Boolean flag=false;
        void fadeIn(object sender, EventArgs e)
        {
            if (!flag)
            {
                if (Opacity >= 1)
                    t1.Stop();
                else
                    Opacity += 0.02;
            }
            else
            {
                if (Opacity >= 0)
                    Opacity -= 0.02;
                else t2.Stop(); 
            
            }
        }
       
        private bool CompareStrings(string string1, string string2)
        {
            return String.Compare(string1, string2, true, System.Globalization.CultureInfo.InvariantCulture) == 0 ? true : false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
          
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\login1.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand sda = new SqlCommand("select * from user2 where username='"+textBox1.Text+"' and password ='"+textBox2.Text+"'", con);
                SqlDataReader dr;

                dr = sda.ExecuteReader();
            
            int ok = 0;
            while (dr.Read())
            {

                if (this.CompareStrings(dr["username"].ToString(), textBox1.Text) &&
                    this.CompareStrings(dr["password"].ToString(), textBox2.Text))
                {
                    username = dr["username"].ToString();
                    hs =Convert.ToInt32(dr["highscore"]);
                    game ss = new game();
                    ss.Show();

                    ok = 1;
                }
            }
            if (ok == 0) MessageBox.Show("incorect");

            textBox1.Clear();
            textBox2.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           // this.Hide();
            register ss = new register();
            ss.Show();
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
        

        private void button3_MouseEnter_1(object sender, EventArgs e)
        {
            if (!(button3.Font.Bold))
            {
                button3.Font = new Font(button3.Font, FontStyle.Bold);
            }
            button3.BackColor = Color.Transparent;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            if ((button3.Font.Bold))
            {
                button3.Font = new Font(button3.Font, FontStyle.Regular);
            }
            button3.BackColor = Color.Transparent;
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                Properties.Settings.Default.username = textBox1.Text;
                Properties.Settings.Default.password = textBox2.Text;
                Properties.Settings.Default.Save();
            }
            else

            {
                Properties.Settings.Default.Reset();
                textBox1.Text = textBox2.Text = "";
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            textBox2.PasswordChar = '\0';
            pictureBox1.BackgroundImage = Resources.rosu;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            textBox2.PasswordChar = '•';
            pictureBox1.BackgroundImage = Resources.alb;
        }
       
    }
}
