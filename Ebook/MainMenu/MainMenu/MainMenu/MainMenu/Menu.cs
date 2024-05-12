using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainMenu
{
    public partial class Form1 : Form
    {
        bool sidebarExpand;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //faster
            sidebarTimer.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            //maximum size of sidebar
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if(sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop(); 
                }
            }
        }

        private void sidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }
           
        private void button2_Click(object sender, EventArgs e)
        {
            //hide other user tab
            userControl21.Hide();
            userControl31.Hide();
            userControl41.Hide();
            //show current tab
            userControl11.Show();
            userControl11.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            userControl11.Hide();
            userControl21.Hide();
            userControl31.Hide();
            userControl41.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //hide other user tab
            userControl11.Hide();
            userControl31.Hide();
            userControl41.Hide();
            //show current tab
            userControl21.Show();
            userControl21.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //hide other user tab
            userControl11.Hide();
            userControl21.Hide();
            userControl41.Hide();
            //show current tab
            userControl31.Show();
            userControl31.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //hide other user tab
            userControl21.Hide();
            userControl31.Hide();
            userControl11.Hide();
            //show current tab
            userControl41.Show();
            userControl41.BringToFront();
        }
    }
}
