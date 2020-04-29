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
            this.ageText.MaxLength = 2;
            this.expText.MaxLength = 2;

        }

        public void regForm_FormClosed(object sender, EventArgs e)
        {
            this.Hide();
            

        }

        private void regButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            idForm id = new idForm();
            id.Show();

        }

        private void ageText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Delete))
            {
                e.Handled = true;
            }
        }

        private void expText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Delete))
            {
                e.Handled = true;
            }
        }
    }
}
