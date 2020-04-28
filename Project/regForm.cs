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
        public regForm()
        {
            InitializeComponent();
            this.nameText.Size = new System.Drawing.Size(245, postComboBox.Size.Height);
            this.ageText.Size = new System.Drawing.Size(ageText.Size.Width, postComboBox.Size.Height);

        }

        public void regForm_FormClosed(object sender, EventArgs e)
        {
            this.Hide();
            mainForm main = new mainForm();
            main.Show();

        }

        private void regButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            idForm id = new idForm();
            id.Show();

        }
    }
}
