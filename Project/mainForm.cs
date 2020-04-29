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
        bool flag = false;
        regForm reg = new regForm();
        loginForm login = new loginForm();
        idForm idform = new idForm();
        user curuser = new user();
        teleForm tele = new teleForm();

        public mainForm()
        {
            InitializeComponent();
        }


        public void loginForm_FormClosed(object sender, EventArgs e)
        {
            this.Close();
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
            /*WebRequests client = new WebRequests();
            user result = client.login("0","123");
            buttonEnter.Text = result.perm_level.ToString();*/
        }
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }


        public void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            this.ShowInTaskbar = false;
            e.Cancel = true;
            if (flag == true)
            {
                e.Cancel = false;
                flag = false;
            }

            
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            reg.ShowDialog();
            this.Show();

        }



        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            login.ShowDialog();           //new loginForm().Showlogin();
            if (login.result.sex < 3)
            {
                curuser = login.result;
                
                this.buttonEnter.Text = "Телеметрия";
                this.buttonEnter.Click -= button1_Click;
                this.buttonEnter.Click += new System.EventHandler(next_button1_Click);

                buttonReg1.Visible = false;

            }
            this.Show();

        }

        private void next_button1_Click(object sender, EventArgs e)
        {
            tele.ShowDialog();

        }

            private void exitButton_Click(object sender, EventArgs e)
        {
            
        }

        private void ВыходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flag = true;
            this.Close();
        }

        private void idButton_Click_1(object sender, EventArgs e)
        {
            idform.curuser = curuser;
            idform.ShowDialog();
        }
    }
}
