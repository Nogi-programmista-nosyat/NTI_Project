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
    public partial class idForm : Form
    {
        public user curuser;
        

        public idForm()
        {
            InitializeComponent();
            
        }

        private void idForm_Load(object sender, EventArgs e)
        {
            nameLabel.Text += curuser.name;
            ageLabel.Text += curuser.age.ToString();
            statLabel.Text += curuser.position;
            mailLabel.Text += curuser.mail;
            
            if (curuser.sex == 1)
                sexLabel.Text += "Женский";
            else
                sexLabel.Text += "Мужской";

            expLabel.Text += curuser.experience.ToString();
        }

        
    }
}
