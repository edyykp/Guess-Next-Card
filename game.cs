using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Properties;
using System.Data.SqlClient;


namespace WindowsFormsApp1
{
    public partial class game : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\login1.mdf;Integrated Security=True;Connect Timeout=30";
        Timer t1 = new Timer();
        int nr = 0;
        string s = "1";
        int p = 0, x, l = 0,y;
        public game()
        {
            
            InitializeComponent();
  
        }
  
        private void Form3_Load(object sender, EventArgs e)
        {
            Opacity = 0;
            this.Cursor = new Cursor(Application.StartupPath + "\\Cursor3.cur");



            label4.Text = Convert.ToString(login.hs);
            t1.Interval = 10;
               t1.Tick += new EventHandler(fadeIn);
               t1.Start();
          
        }
        
        void fadeIn(object sender, EventArgs e)
        {
            if (Opacity >= 1)
                t1.Stop();
            else
                Opacity += 0.02;
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (p == 1) {pictureBox5.ImageLocation = string.Format(@"Images\{0}.png", x); }
            if (l > 1) pictureBox6.ImageLocation = string.Format(@"Images\{0}.png", y);
            p = 1;
            l++;
            Random rnd = new Random();
            y = x;
            x = rnd.Next(2, 53);
            slidePic.ImageLocation = string.Format(@"Images\{0}.png", x);
            if(x==3||x==4||x==7||x==8||x==11||x==12||x==14||x==16||x==19||x==20||x==23||x==24||x==27||x==28||x==31||x==32||x==35||x==36||x==39||x==40||x==43||x==44||x==47||x==48||x==51||x==52)
            {
                int q = Convert.ToInt32(label3.Text);
                q = q * 2;
                label3.Text = Convert.ToString(q);
                int w = Convert.ToInt32(label4.Text);
                if (w < q)
                    label4.Text = Convert.ToString(q);
                nr++;
            }
            else if (nr > 5) { nr = 0; s = label3.Text; }
            else
            {
                label3.Text = s;
                nr = 0;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (p == 1) {pictureBox5.ImageLocation = string.Format(@"Images\{0}.png", x);}
            if (l > 1) pictureBox6.ImageLocation = string.Format(@"Images\{0}.png", y);
            p = 1;
            l++;
            Random rnd = new Random();
            y = x;
            x = rnd.Next(2, 53);
            slidePic.ImageLocation = string.Format(@"Images\{0}.png", x);
            if(x==2||x==5||x==9||x==10||x==6||x==13||x==15||x==18||x==17||x==21||x==22||x==25||x==26||x==29||x==30||x==33||x==34||x==37||x==38||x==41||x==42||x==45||x==46||x==49||x==50||x==53)
            {
                int q = Convert.ToInt32(label3.Text);
                q = q * 2;
                label3.Text = Convert.ToString(q);
                int w = Convert.ToInt32(label4.Text);
                if (w < q)
                    label4.Text = Convert.ToString(q);
                nr++;
            }
            else if (nr > 5) { nr = 0; s = label3.Text; }
            else
            {
                label3.Text = s;
                nr = 0;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (p == 1) {pictureBox5.ImageLocation = string.Format(@"Images\{0}.png", x); }
            if (l > 1) pictureBox6.ImageLocation = string.Format(@"Images\{0}.png", y);
            p = 1;
            l++;
            Random rnd = new Random();
            y = x;
            x = rnd.Next(2, 53);
            slidePic.ImageLocation = string.Format(@"Images\{0}.png", x);
            if (x == 4 || x == 8 || x == 12 || x == 16 || x == 20 || x == 24 || x == 28 || x == 32 || x == 36 || x == 40 || x == 44 || x == 48 || x == 52)
            {

                int q = Convert.ToInt32(label3.Text);
                q = q * 4;
                label3.Text = Convert.ToString(q);
                int w = Convert.ToInt32(label4.Text);
                if (w < q)
                   label4.Text = Convert.ToString(q);
                nr++;
            }
            else if (nr > 5) { nr = 0; s = label3.Text; }
            else
            {
                label3.Text = s;
                nr = 0;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (p == 1) {pictureBox5.ImageLocation = string.Format(@"Images\{0}.png", x); }
            if (l > 1) pictureBox6.ImageLocation = string.Format(@"Images\{0}.png", y);
            p = 1;
            l++;
            Random rnd = new Random();
            y = x;
            x = rnd.Next(2, 53);
            slidePic.ImageLocation = string.Format(@"Images\{0}.png", x);
           
            if (x == 3 || x == 7 || x == 11 || x == 14 || x == 19 || x == 23 || x == 27 || x == 31 || x == 35 || x == 39 || x == 43 || x == 47 || x == 51)
            {

                int q = Convert.ToInt32(label3.Text);
                q = q * 4;
                label3.Text = Convert.ToString(q);
                int w = Convert.ToInt32(label4.Text);
                if (w < q)
                    label4.Text = Convert.ToString(q);
                nr++;
            }
            else if (nr > 5) { nr = 0; s = label3.Text; }
            else
            {
                label3.Text = s;
                nr = 0;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (p == 1) {pictureBox5.ImageLocation = string.Format(@"Images\{0}.png", x); }
            if (l > 1) pictureBox6.ImageLocation = string.Format(@"Images\{0}.png", y);
            p = 1;
            l++;
            Random rnd = new Random();
            y = x;
            x = rnd.Next(2, 53);
            slidePic.ImageLocation = string.Format(@"Images\{0}.png", x);
            if (x == 2 || x == 6 || x == 10 || x == 15 || x == 18 || x == 22 || x == 26 || x == 30 || x == 34 || x == 38 || x == 42 || x == 46 || x == 50)
            {
                int q = Convert.ToInt32(label3.Text);
                q = q * 4;
                label3.Text = Convert.ToString(q);
                int w = Convert.ToInt32(label4.Text);
                if (w < q)
                    label4.Text = Convert.ToString(q);
                nr++;
            }
            else if (nr > 5) { nr = 0; s = label3.Text; }
            else
            {
                label3.Text = s;
                nr = 0;
            }
        }

        private void roundButton1_MouseEnter(object sender, EventArgs e)
        {
            if (!(roundButton1.Font.Bold))
            {
                roundButton1.Font = new Font(roundButton1.Font, FontStyle.Bold);
            }
            roundButton1.BackColor = Color.SteelBlue;
        }

        private void roundButton1_MouseLeave(object sender, EventArgs e)
        {
            if ((roundButton1.Font.Bold))
            {
                roundButton1.Font = new Font(roundButton1.Font, FontStyle.Regular);
            }
            roundButton1.BackColor = Color.SteelBlue;
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            help ss = new help();
            ss.Show();
        }

        private void roundButton2_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlCommand sqlcmd = new SqlCommand("", sqlCon);
                SqlCommand sqlcmd1 = new SqlCommand("", sqlCon);

                int x = int.Parse(label4.Text);
                  if (login.hs < x)
                    {   sqlcmd.CommandText = $@"update user2 set highscore='" + x + "' where username= '" + login.username + "'";
                sqlcmd.ExecuteNonQuery();
            }
                sqlCon.Close();
            }
            login ss = new login();
            ss.Show();
            this.Hide();
          
        }

        private void roundButton2_MouseEnter(object sender, EventArgs e)
        {
            roundButton2.BackgroundImage = Resources.mouseenter;
        }

        private void roundButton2_MouseLeave(object sender, EventArgs e)
        {
            roundButton2.BackgroundImage = Resources.simple;
        }

        private void roundButton2_MouseDown(object sender, MouseEventArgs e)
        {
            roundButton2.BackgroundImage = Resources.mousedown;
        }

        private void roundButton2_MouseUp(object sender, MouseEventArgs e)
        {
            roundButton2.BackgroundImage = Resources.simple;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (p == 1) {pictureBox5.ImageLocation = string.Format(@"Images\{0}.png", x); }
            if (l > 1) pictureBox6.ImageLocation = string.Format(@"Images\{0}.png",y);
            p = 1;
            l++;
            Random rnd = new Random();
            y = x;
            x = rnd.Next(2, 53);
            slidePic.ImageLocation = string.Format(@"Images\{0}.png", x);
            if(x==5||x==9||x==13||x==17||x==21||x==25||x==29||x==33||x==37||x==41||x==45||x==49||x==53)
            {
                int q = Convert.ToInt32(label3.Text);
                q = q * 4;
                label3.Text = Convert.ToString(q);
                int w=Convert.ToInt32(label4.Text);
                if(w<q)
                    label4.Text = Convert.ToString(q);
                nr++;
            }
            else if(nr>5) { nr = 0; s = label3.Text; }
            else 
            {
                label3.Text = s;
                nr = 0;
            }
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
           
        }

        
    }
}
