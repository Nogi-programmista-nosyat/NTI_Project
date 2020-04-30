namespace window3
{
    partial class reptForm
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
            this.reptLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // reptLabel
            // 
            this.reptLabel.AutoSize = true;
            this.reptLabel.Location = new System.Drawing.Point(31, 9);
            this.reptLabel.Name = "reptLabel";
            this.reptLabel.Size = new System.Drawing.Size(46, 17);
            this.reptLabel.TabIndex = 0;
            this.reptLabel.Text = "label1";
            // 
            // reptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reptLabel);
            this.Name = "reptForm";
            this.Text = "Отчет";
            this.Load += new System.EventHandler(this.reptForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label reptLabel;
    }
}