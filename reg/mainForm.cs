using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace window3
{
    public partial class mainForm : Form
    {
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            teleForm tele = new teleForm();
            tele.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginForm login = new loginForm();           //new loginForm().Showlogin();
            login.Show();

        }

        public void mainForm_FormClosed(object sender, EventArgs e)
        {
            Application.Exit();

        }


    }
}
