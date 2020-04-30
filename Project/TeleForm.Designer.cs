namespace window3
{
    partial class teleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.id = new System.Windows.Forms.MenuStrip();
            this.typeCombo = new System.Windows.Forms.ToolStripComboBox();
            this.id_dev = new System.Windows.Forms.ToolStripMenuItem();
            this.dev_checkAll = new System.Windows.Forms.ToolStripMenuItem();
            this.par = new System.Windows.Forms.ToolStripMenuItem();
            this.par_checkAll = new System.Windows.Forms.ToolStripMenuItem();
            this.work_time = new System.Windows.Forms.ToolStripMenuItem();
            this.power = new System.Windows.Forms.ToolStripMenuItem();
            this.loading = new System.Windows.Forms.ToolStripMenuItem();
            this.vibr = new System.Windows.Forms.ToolStripMenuItem();
            this.temp = new System.Windows.Forms.ToolStripMenuItem();
            this.dPicker1 = new System.Windows.Forms.DateTimePicker();
            this.dPicker2 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.id_devMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.showButton = new System.Windows.Forms.Button();
            this.insertButton = new System.Windows.Forms.Button();
            this.infoBox = new System.Windows.Forms.Panel();
            this.id.SuspendLayout();
            this.id_devMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // id
            // 
            this.id.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.id.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.typeCombo,
            this.id_dev,
            this.par});
            this.id.Location = new System.Drawing.Point(0, 0);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(800, 32);
            this.id.TabIndex = 3;
            this.id.Text = "menuStrip1";
            // 
            // typeCombo
            // 
            this.typeCombo.Items.AddRange(new object[] {
            "График",
            "Диаграмма",
            "Таблица"});
            this.typeCombo.Name = "typeCombo";
            this.typeCombo.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.typeCombo.Size = new System.Drawing.Size(160, 28);
            this.typeCombo.Text = "Вид отображения:";
            this.typeCombo.SelectedIndexChanged += new System.EventHandler(this.всеПоля_CheckedChanged);
            // 
            // id_dev
            // 
            this.id_dev.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dev_checkAll});
            this.id_dev.Name = "id_dev";
            this.id_dev.Size = new System.Drawing.Size(127, 28);
            this.id_dev.Text = "Оборудование";
            // 
            // dev_checkAll
            // 
            this.dev_checkAll.CheckOnClick = true;
            this.dev_checkAll.Name = "dev_checkAll";
            this.dev_checkAll.Size = new System.Drawing.Size(184, 26);
            this.dev_checkAll.Text = "Отметить все";
            this.dev_checkAll.Click += new System.EventHandler(this.dev_checkAll_Click);
            // 
            // par
            // 
            this.par.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.par_checkAll,
            this.work_time,
            this.power,
            this.loading,
            this.vibr,
            this.temp});
            this.par.Name = "par";
            this.par.Size = new System.Drawing.Size(93, 28);
            this.par.Text = "Параметр";
            // 
            // par_checkAll
            // 
            this.par_checkAll.CheckOnClick = true;
            this.par_checkAll.Name = "par_checkAll";
            this.par_checkAll.Size = new System.Drawing.Size(270, 26);
            this.par_checkAll.Text = "Отметить все";
            this.par_checkAll.Click += new System.EventHandler(this.par_checkAll_Click);
            // 
            // work_time
            // 
            this.work_time.CheckOnClick = true;
            this.work_time.Name = "work_time";
            this.work_time.Size = new System.Drawing.Size(270, 26);
            this.work_time.Text = "Время работы";
            this.work_time.CheckedChanged += new System.EventHandler(this.всеПоля_CheckedChanged);
            // 
            // power
            // 
            this.power.CheckOnClick = true;
            this.power.Name = "power";
            this.power.Size = new System.Drawing.Size(270, 26);
            this.power.Text = "Потребляемая мощность";
            this.power.CheckedChanged += new System.EventHandler(this.всеПоля_CheckedChanged);
            // 
            // loading
            // 
            this.loading.CheckOnClick = true;
            this.loading.Name = "loading";
            this.loading.Size = new System.Drawing.Size(270, 26);
            this.loading.Text = "Уровень нагрузки";
            this.loading.CheckedChanged += new System.EventHandler(this.всеПоля_CheckedChanged);
            // 
            // vibr
            // 
            this.vibr.CheckOnClick = true;
            this.vibr.Name = "vibr";
            this.vibr.Size = new System.Drawing.Size(270, 26);
            this.vibr.Text = "Уровень вибрации";
            this.vibr.CheckedChanged += new System.EventHandler(this.всеПоля_CheckedChanged);
            // 
            // temp
            // 
            this.temp.CheckOnClick = true;
            this.temp.Name = "temp";
            this.temp.Size = new System.Drawing.Size(270, 26);
            this.temp.Text = "Температура";
            this.temp.CheckedChanged += new System.EventHandler(this.всеПоля_CheckedChanged);
            // 
            // dPicker1
            // 
            this.dPicker1.CustomFormat = "d.MM.yyyy HH:mm";
            this.dPicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dPicker1.Location = new System.Drawing.Point(407, 6);
            this.dPicker1.Name = "dPicker1";
            this.dPicker1.Size = new System.Drawing.Size(170, 22);
            this.dPicker1.TabIndex = 4;
            this.dPicker1.ValueChanged += new System.EventHandler(this.DPicker_ValueChanged);
            // 
            // dPicker2
            // 
            this.dPicker2.CustomFormat = "d.MM.yyyy HH:mm";
            this.dPicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dPicker2.Location = new System.Drawing.Point(599, 6);
            this.dPicker2.Name = "dPicker2";
            this.dPicker2.Size = new System.Drawing.Size(170, 22);
            this.dPicker2.TabIndex = 5;
            this.dPicker2.ValueChanged += new System.EventHandler(this.DPicker_ValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(46, 510);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 26);
            this.button1.TabIndex = 7;
            this.button1.Text = "Построить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // id_devMenu
            // 
            this.id_devMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.id_devMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fdToolStripMenuItem,
            this.toolStripMenuItem1});
            this.id_devMenu.Name = "id_devMenu";
            this.id_devMenu.Size = new System.Drawing.Size(93, 52);
            // 
            // fdToolStripMenuItem
            // 
            this.fdToolStripMenuItem.Name = "fdToolStripMenuItem";
            this.fdToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.fdToolStripMenuItem.Text = "fd";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(92, 24);
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(189, 510);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(244, 26);
            this.showButton.TabIndex = 10;
            this.showButton.Text = "Показать отчёт";
            this.showButton.UseVisualStyleBackColor = true;
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(508, 510);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(244, 26);
            this.insertButton.TabIndex = 11;
            this.insertButton.Text = "Добавить запись";
            this.insertButton.UseVisualStyleBackColor = true;
            // 
            // infoBox
            // 
            this.infoBox.AutoScroll = true;
            this.infoBox.Location = new System.Drawing.Point(35, 69);
            this.infoBox.Name = "infoBox";
            this.infoBox.Size = new System.Drawing.Size(717, 407);
            this.infoBox.TabIndex = 12;
            // 
            // teleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 557);
            this.Controls.Add(this.infoBox);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dPicker2);
            this.Controls.Add(this.dPicker1);
            this.Controls.Add(this.id);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MainMenuStrip = this.id;
            this.Name = "teleForm";
            this.Text = "teleForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.teleForm_FormClosed);
            this.Load += new System.EventHandler(this.teleForm_Load);
            this.id.ResumeLayout(false);
            this.id.PerformLayout();
            this.id_devMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.MenuStrip id;
        private System.Windows.Forms.ToolStripComboBox typeCombo;
        private System.Windows.Forms.DateTimePicker dPicker1;
        private System.Windows.Forms.DateTimePicker dPicker2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip id_devMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem id_dev;
        private System.Windows.Forms.ToolStripMenuItem par;
        private System.Windows.Forms.ToolStripMenuItem work_time;
        private System.Windows.Forms.ToolStripMenuItem power;
        private System.Windows.Forms.ToolStripMenuItem loading;
        private System.Windows.Forms.ToolStripMenuItem temp;
        private System.Windows.Forms.ToolStripMenuItem vibr;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.ToolStripMenuItem dev_checkAll;
        private System.Windows.Forms.ToolStripMenuItem par_checkAll;
        private System.Windows.Forms.Panel infoBox;
    }
}