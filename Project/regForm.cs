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
    public partial class regForm : Form
    {
        public user curuser;
        String Name="";
        String Login = "";
        String Age = "";
        String Exp = "";
        public regForm()
        {
            InitializeComponent();
            this.nameText.Size = new System.Drawing.Size(245, postComboBox.Size.Height);
            this.ageText.Size = new System.Drawing.Size(ageText.Size.Width, postComboBox.Size.Height);

        }

        public void regForm_FormClosed(object sender, EventArgs e)
        {
            this.Hide();
            

        }

        private void regButton2_Click(object sender, EventArgs e)
        {
            
            curuser.name = nameText.Text;
            curuser.age = Convert.ToInt32(ageText.Text);
            curuser.login = logText.Text;
            curuser.password = passText.Text;
            curuser.mail = mailText.Text;
            curuser.perm_level = postComboBox.SelectedIndex;
            curuser.position = postComboBox.Text;
            curuser.experience = Convert.ToInt32(expText.Text);
            curuser.sex = sexComboBox.SelectedIndex;
            WebRequests client = new WebRequests();
            client.registration(curuser);
            this.Hide();
        }

        private void NameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void AgeText_TextChanged(object sender, EventArgs e)
        {

        }

        private void ExpText_TextChanged(object sender, EventArgs e)
        {

        }

        private void LogText_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
