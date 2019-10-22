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
    public partial class help : Form
    {
        Timer t1 = new Timer();
        public help()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            Opacity = 0.5;
            this.Cursor = new Cursor(Application.StartupPath + "\\Cursor3.cur");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            t1.Interval = 10;
            t1.Tick += new EventHandler(fadeIn);
            t1.Start();
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
            button1.FlatAppearance.BorderSize= 1;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            if ((button1.Font.Bold))
            {
                button1.Font = new Font(button1.Font, FontStyle.Regular);
            }
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 1;
        }
    }
}
