namespace window3
{
    partial class idForm
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.expLabel = new System.Windows.Forms.Label();
            this.mailLabel = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.sexLabel = new System.Windows.Forms.Label();
            this.statLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(28, 25);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(50, 17);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "ФИО: ";
            // 
            // expLabel
            // 
            this.expLabel.AutoSize = true;
            this.expLabel.Location = new System.Drawing.Point(28, 60);
            this.expLabel.Name = "expLabel";
            this.expLabel.Size = new System.Drawing.Size(49, 17);
            this.expLabel.TabIndex = 3;
            this.expLabel.Text = "Стаж: ";
            // 
            // mailLabel
            // 
            this.mailLabel.AutoSize = true;
            this.mailLabel.Location = new System.Drawing.Point(28, 94);
            this.mailLabel.Name = "mailLabel";
            this.mailLabel.Size = new System.Drawing.Size(57, 17);
            this.mailLabel.TabIndex = 4;
            this.mailLabel.Text = "Почта: ";
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Location = new System.Drawing.Point(28, 127);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(70, 17);
            this.ageLabel.TabIndex = 5;
            this.ageLabel.Text = "Возраст: ";
            // 
            // sexLabel
            // 
            this.sexLabel.AutoSize = true;
            this.sexLabel.Location = new System.Drawing.Point(28, 160);
            this.sexLabel.Name = "sexLabel";
            this.sexLabel.Size = new System.Drawing.Size(42, 17);
            this.sexLabel.TabIndex = 6;
            this.sexLabel.Text = "Пол: ";
            // 
            // statLabel
            // 
            this.statLabel.AutoSize = true;
            this.statLabel.Location = new System.Drawing.Point(28, 192);
            this.statLabel.Name = "statLabel";
            this.statLabel.Size = new System.Drawing.Size(89, 17);
            this.statLabel.TabIndex = 7;
            this.statLabel.Text = "Должность: ";
            // 
            // idForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 244);
            this.Controls.Add(this.statLabel);
            this.Controls.Add(this.sexLabel);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.mailLabel);
            this.Controls.Add(this.expLabel);
            this.Controls.Add(this.nameLabel);
            this.Name = "idForm";
            this.Text = "Личный кабинет";
            this.Load += new System.EventHandler(this.idForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label expLabel;
        private System.Windows.Forms.Label mailLabel;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.Label sexLabel;
        private System.Windows.Forms.Label statLabel;
    }
}