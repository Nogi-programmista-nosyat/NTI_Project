﻿using System;
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
        public loginForm()
        {
            InitializeComponent();

            this.passText.AutoSize = false;
            this.passText.Size = new Size(this.passText.Size.Width, logText.Size.Height);
        }

        public void loginForm_FormClosed(object sender, EventArgs e)
        {
            this.Hide();
            mainForm main = new mainForm(); 
            main.Show();

        }


    }
}