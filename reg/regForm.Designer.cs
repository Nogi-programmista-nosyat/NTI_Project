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
            this.postComboBox.Location = new System.Drawing.Point(208, 178);
            this.postComboBox.Name = "postComboBox";
            this.postComboBox.Size = new System.Drawing.Size(205, 24);
            this.postComboBox.TabIndex = 0;
            // 
            // postLabel
            // 
            this.postLabel.AutoSize = true;
            this.postLabel.Location = new System.Drawing.Point(121, 181);
            this.postLabel.Name = "postLabel";
            this.postLabel.Size = new System.Drawing.Size(81, 17);
            this.postLabel.TabIndex = 1;
            this.postLabel.Text = "Должность";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(121, 238);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(42, 17);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "ФИО";
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(208, 235);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(245, 22);
            this.nameText.TabIndex = 3;
            // 
            // sexLabel
            // 
            this.sexLabel.AutoSize = true;
            this.sexLabel.Location = new System.Drawing.Point(121, 291);
            this.sexLabel.Name = "sexLabel";
            this.sexLabel.Size = new System.Drawing.Size(34, 17);
            this.sexLabel.TabIndex = 4;
            this.sexLabel.Text = "Пол";
            // 
            // sexComboBox
            // 
            this.sexComboBox.FormattingEnabled = true;
            this.sexComboBox.Items.AddRange(new object[] {
            "Женский ",
            "Мужской"});
            this.sexComboBox.Location = new System.Drawing.Point(208, 284);
            this.sexComboBox.Name = "sexComboBox";
            this.sexComboBox.Size = new System.Drawing.Size(121, 24);
            this.sexComboBox.TabIndex = 5;
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Location = new System.Drawing.Point(121, 340);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(62, 17);
            this.ageLabel.TabIndex = 6;
            this.ageLabel.Text = "Возраст";
            // 
            // ageText
            // 
            this.ageText.Location = new System.Drawing.Point(208, 340);
            this.ageText.Name = "ageText";
            this.ageText.Size = new System.Drawing.Size(45, 22);
            this.ageText.TabIndex = 7;
            // 
            // mailLabel
            // 
            this.mailLabel.AutoSize = true;
            this.mailLabel.Location = new System.Drawing.Point(121, 388);
            this.mailLabel.Name = "mailLabel";
            this.mailLabel.Size = new System.Drawing.Size(49, 17);
            this.mailLabel.TabIndex = 8;
            this.mailLabel.Text = "Почта";
            // 
            // mailText
            // 
            this.mailText.Location = new System.Drawing.Point(208, 388);
            this.mailText.Name = "mailText";
            this.mailText.Size = new System.Drawing.Size(245, 22);
            this.mailText.TabIndex = 9;
            // 
            // expLabel
            // 
            this.expLabel.AutoSize = true;
            this.expLabel.Location = new System.Drawing.Point(121, 440);
            this.expLabel.Name = "expLabel";
            this.expLabel.Size = new System.Drawing.Size(41, 17);
            this.expLabel.TabIndex = 10;
            this.expLabel.Text = "Стаж";
            // 
            // expText
            // 
            this.expText.Location = new System.Drawing.Point(208, 440);
            this.expText.Name = "expText";
            this.expText.Size = new System.Drawing.Size(45, 22);
            this.expText.TabIndex = 11;
            // 
            // regButton2
            // 
            this.regButton2.Location = new System.Drawing.Point(190, 511);
            this.regButton2.Name = "regButton2";
            this.regButton2.Size = new System.Drawing.Size(139, 33);
            this.regButton2.TabIndex = 12;
            this.regButton2.Text = "Регистрация";
            this.regButton2.UseVisualStyleBackColor = true;
            this.regButton2.Click += new System.EventHandler(this.regButton2_Click);
            // 
            // regForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(537, 584);
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
            this.Text = "regForm";
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
    }
}