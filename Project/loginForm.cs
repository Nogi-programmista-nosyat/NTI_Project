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
    public partial class loginForm : Form
    {
        public user result = new user();


        public loginForm()
        {
            InitializeComponent();

            result.sex = 3;
            this.passText.AutoSize = false;
            this.passText.Size = new Size(this.passText.Size.Width, logText.Size.Height);
        }
        
        public void loginForm_FormClosed(object sender, EventArgs e)
        {
            this.Hide();
            
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            WebRequests client = new WebRequests();
            result = client.login(logText.Text, passText.Text);
            if (result.sex == 3) infoLabel.Text = "Неверный логин или пароль";
            else if (result.sex == 404) infoLabel.Text = "Ошибка в интернет соединении";
            else this.Hide();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
