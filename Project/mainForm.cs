using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace window3
{

    public partial class mainForm : Form
    {
        bool flag;

        public mainForm()
        {
            InitializeComponent();
        }

        

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            WebRequests client = new WebRequests();
            user result = client.login("0","123");
            //buttonEnter.Text = result.perm_level.ToString();
        }
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;

        }


        public void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
         
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
            e.Cancel = true;
            if (flag == true)
                e.Cancel = false;
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            regForm reg = new regForm();
            reg.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginForm login = new loginForm();           //new loginForm().Showlogin();
            login.Show();

        }

        

        public void mainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        

        private void exitButton_Click(object sender, FormClosedEventArgs e)
        {
            flag = true;
            this.Close();

        }

        //private void mainForm_Deactivate_1(object sender, EventArgs e)
        //{
        //    notifyIcon1.Visible = true;

        //}
    }
}
