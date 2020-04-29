namespace window3
{
    partial class regForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.postComboBox = new System.Windows.Forms.ComboBox();
            this.postLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameText = new System.Windows.Forms.TextBox();
            this.sexLabel = new System.Windows.Forms.Label();
            this.sexComboBox = new System.Windows.Forms.ComboBox();
            this.ageLabel = new System.Windows.Forms.Label();
            this.ageText = new System.Windows.Forms.TextBox();
            this.mailLabel = new System.Windows.Forms.Label();
            this.mailText = new System.Windows.Forms.TextBox();
            this.expLabel = new System.Windows.Forms.Label();
            this.expText = new System.Windows.Forms.TextBox();
            this.regButton2 = new System.Windows.Forms.Button();
            this.passRegText = new System.Windows.Forms.Label();
            this.passText = new System.Windows.Forms.TextBox();
            this.logText = new System.Windows.Forms.TextBox();
            this.logLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // postComboBox
            // 
            this.postComboBox.FormattingEnabled = true;
            this.postComboBox.Items.AddRange(new object[] {
            "Сотрудник",
            "Руководитель отдела",
            "Руководитель предприятия",
            "Администратор"});
            this.postComboBox.Location = new System.Drawing.Point(201, 75);
            this.postComboBox.Name = "postComboBox";
            this.postComboBox.Size = new System.Drawing.Size(205, 24);
            this.postComboBox.TabIndex = 0;
            // 
            // postLabel
            // 
            this.postLabel.AutoSize = true;
            this.postLabel.Location = new System.Drawing.Point(114, 78);
            this.postLabel.Name = "postLabel";
            this.postLabel.Size = new System.Drawing.Size(81, 17);
            this.postLabel.TabIndex = 1;
            this.postLabel.Text = "Должность";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(114, 171);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(42, 17);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "ФИО";
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(201, 168);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(245, 22);
            this.nameText.TabIndex = 3;
            this.nameText.TextChanged += new System.EventHandler(this.NameText_TextChanged);
            // 
            // sexLabel
            // 
            this.sexLabel.AutoSize = true;
            this.sexLabel.Location = new System.Drawing.Point(114, 224);
            this.sexLabel.Name = "sexLabel";
            this.sexLabel.Size = new System.Drawing.Size(34, 17);
            this.sexLabel.TabIndex = 4;
            this.sexLabel.Text = "Пол";
            // 
            // sexComboBox
            // 
            this.sexComboBox.FormattingEnabled = true;
            this.sexComboBox.Items.AddRange(new object[] {
            "Мужской",
            "Женский"});
            this.sexComboBox.Location = new System.Drawing.Point(201, 217);
            this.sexComboBox.Name = "sexComboBox";
            this.sexComboBox.Size = new System.Drawing.Size(121, 24);
            this.sexComboBox.TabIndex = 5;
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Location = new System.Drawing.Point(114, 273);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(62, 17);
            this.ageLabel.TabIndex = 6;
            this.ageLabel.Text = "Возраст";
            // 
            // ageText
            // 
            this.ageText.Location = new System.Drawing.Point(201, 273);
            this.ageText.Name = "ageText";
            this.ageText.Size = new System.Drawing.Size(45, 22);
            this.ageText.TabIndex = 7;
            this.ageText.TextChanged += new System.EventHandler(this.AgeText_TextChanged);
            // 
            // mailLabel
            // 
            this.mailLabel.AutoSize = true;
            this.mailLabel.Location = new System.Drawing.Point(114, 321);
            this.mailLabel.Name = "mailLabel";
            this.mailLabel.Size = new System.Drawing.Size(49, 17);
            this.mailLabel.TabIndex = 8;
            this.mailLabel.Text = "Почта";
            // 
            // mailText
            // 
            this.mailText.Location = new System.Drawing.Point(201, 321);
            this.mailText.Name = "mailText";
            this.mailText.Size = new System.Drawing.Size(245, 22);
            this.mailText.TabIndex = 9;
            // 
            // expLabel
            // 
            this.expLabel.AutoSize = true;
            this.expLabel.Location = new System.Drawing.Point(114, 373);
            this.expLabel.Name = "expLabel";
            this.expLabel.Size = new System.Drawing.Size(41, 17);
            this.expLabel.TabIndex = 10;
            this.expLabel.Text = "Стаж";
            // 
            // expText
            // 
            this.expText.Location = new System.Drawing.Point(201, 373);
            this.expText.Name = "expText";
            this.expText.Size = new System.Drawing.Size(45, 22);
            this.expText.TabIndex = 11;
            this.expText.TextChanged += new System.EventHandler(this.ExpText_TextChanged);
            // 
            // regButton2
            // 
            this.regButton2.Location = new System.Drawing.Point(183, 501);
            this.regButton2.Name = "regButton2";
            this.regButton2.Size = new System.Drawing.Size(139, 33);
            this.regButton2.TabIndex = 12;
            this.regButton2.Text = "Регистрация";
            this.regButton2.UseVisualStyleBackColor = true;
            this.regButton2.Click += new System.EventHandler(this.regButton2_Click);
            // 
            // passRegText
            // 
            this.passRegText.AutoSize = true;
            this.passRegText.Location = new System.Drawing.Point(114, 431);
            this.passRegText.Name = "passRegText";
            this.passRegText.Size = new System.Drawing.Size(57, 17);
            this.passRegText.TabIndex = 13;
            this.passRegText.Text = "Пароль";
            // 
            // passText
            // 
            this.passText.Location = new System.Drawing.Point(201, 426);
            this.passText.Name = "passText";
            this.passText.Size = new System.Drawing.Size(205, 22);
            this.passText.TabIndex = 14;
            this.passText.UseSystemPasswordChar = true;
            // 
            // logText
            // 
            this.logText.Location = new System.Drawing.Point(201, 122);
            this.logText.Name = "logText";
            this.logText.Size = new System.Drawing.Size(245, 22);
            this.logText.TabIndex = 16;
            this.logText.TextChanged += new System.EventHandler(this.LogText_TextChanged);
            // 
            // logLabel
            // 
            this.logLabel.AutoSize = true;
            this.logLabel.Location = new System.Drawing.Point(114, 125);
            this.logLabel.Name = "logLabel";
            this.logLabel.Size = new System.Drawing.Size(47, 17);
            this.logLabel.TabIndex = 15;
            this.logLabel.Text = "Логин";
            // 
            // regForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(537, 584);
            this.Controls.Add(this.logText);
            this.Controls.Add(this.logLabel);
            this.Controls.Add(this.passText);
            this.Controls.Add(this.passRegText);
            this.Controls.Add(this.regButton2);
            this.Controls.Add(this.expText);
            this.Controls.Add(this.expLabel);
            this.Controls.Add(this.mailText);
            this.Controls.Add(this.mailLabel);
            this.Controls.Add(this.ageText);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.sexComboBox);
            this.Controls.Add(this.sexLabel);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.postLabel);
            this.Controls.Add(this.postComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "regForm";
            this.Text = "Регистрация";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.regForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox postComboBox;
        private System.Windows.Forms.Label postLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Label sexLabel;
        private System.Windows.Forms.ComboBox sexComboBox;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.TextBox ageText;
        private System.Windows.Forms.Label mailLabel;
        private System.Windows.Forms.TextBox mailText;
        private System.Windows.Forms.Label expLabel;
        private System.Windows.Forms.TextBox expText;
        private System.Windows.Forms.Button regButton2;
        private System.Windows.Forms.Label passRegText;
        private System.Windows.Forms.TextBox passText;
        private System.Windows.Forms.TextBox logText;
        private System.Windows.Forms.Label logLabel;
    }
}