using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class start : Form
    {
        Timer t1 = new Timer();
        public start()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            t1.Interval = 10;
            t1.Tick += new EventHandler(fadeIn);
            t1.Start();
            
          //  Form1 ss = new Form1();
          //  ss.Show();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            login ss = new login();
            ss.Show();
            Opacity = 0.5;
        }
        void fadeIn(object sender, EventArgs e)
        {
            if (Opacity >= 0)
                Opacity -= 0.02;
            else
            { this.Close(); t1.Stop(); }
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
