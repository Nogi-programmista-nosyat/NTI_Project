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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.id = new System.Windows.Forms.MenuStrip();
            this.typeCombo = new System.Windows.Forms.ToolStripComboBox();
            this.id_dev = new System.Windows.Forms.ToolStripMenuItem();
            this.par = new System.Windows.Forms.ToolStripMenuItem();
            this.времяРаботыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.уроеньПотребленияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.уровеньНагрузкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.температураToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.уровеньВибрацииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.chartTemp = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.id_devMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.id.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTemp)).BeginInit();
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
            "Диаграмма",
            "График",
            "Таблица"});
            this.typeCombo.Name = "typeCombo";
            this.typeCombo.Size = new System.Drawing.Size(121, 28);
            // 
            // id_dev
            // 
            this.id_dev.Name = "id_dev";
            this.id_dev.Size = new System.Drawing.Size(127, 28);
            this.id_dev.Text = "Оборудование";
            // 
            // par
            // 
            this.par.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.времяРаботыToolStripMenuItem,
            this.уроеньПотребленияToolStripMenuItem,
            this.уровеньНагрузкиToolStripMenuItem,
            this.температураToolStripMenuItem,
            this.уровеньВибрацииToolStripMenuItem});
            this.par.Name = "par";
            this.par.Size = new System.Drawing.Size(93, 28);
            this.par.Text = "Параметр";
            this.par.Click += new System.EventHandler(this.par_Click);
            // 
            // времяРаботыToolStripMenuItem
            // 
            this.времяРаботыToolStripMenuItem.Checked = true;
            this.времяРаботыToolStripMenuItem.CheckOnClick = true;
            this.времяРаботыToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.времяРаботыToolStripMenuItem.Name = "времяРаботыToolStripMenuItem";
            this.времяРаботыToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.времяРаботыToolStripMenuItem.Text = "Время работы";
            // 
            // уроеньПотребленияToolStripMenuItem
            // 
            this.уроеньПотребленияToolStripMenuItem.Checked = true;
            this.уроеньПотребленияToolStripMenuItem.CheckOnClick = true;
            this.уроеньПотребленияToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.уроеньПотребленияToolStripMenuItem.Name = "уроеньПотребленияToolStripMenuItem";
            this.уроеньПотребленияToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.уроеньПотребленияToolStripMenuItem.Text = "Уроень потребления";
            // 
            // уровеньНагрузкиToolStripMenuItem
            // 
            this.уровеньНагрузкиToolStripMenuItem.Checked = true;
            this.уровеньНагрузкиToolStripMenuItem.CheckOnClick = true;
            this.уровеньНагрузкиToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.уровеньНагрузкиToolStripMenuItem.Name = "уровеньНагрузкиToolStripMenuItem";
            this.уровеньНагрузкиToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.уровеньНагрузкиToolStripMenuItem.Text = "Уровень нагрузки";
            // 
            // температураToolStripMenuItem
            // 
            this.температураToolStripMenuItem.Checked = true;
            this.температураToolStripMenuItem.CheckOnClick = true;
            this.температураToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.температураToolStripMenuItem.Name = "температураToolStripMenuItem";
            this.температураToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.температураToolStripMenuItem.Text = "Температура";
            // 
            // уровеньВибрацииToolStripMenuItem
            // 
            this.уровеньВибрацииToolStripMenuItem.Checked = true;
            this.уровеньВибрацииToolStripMenuItem.CheckOnClick = true;
            this.уровеньВибрацииToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.уровеньВибрацииToolStripMenuItem.Name = "уровеньВибрацииToolStripMenuItem";
            this.уровеньВибрацииToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.уровеньВибрацииToolStripMenuItem.Text = "Уровень вибрации";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(451, 10);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(146, 22);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(622, 10);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(146, 22);
            this.dateTimePicker2.TabIndex = 5;
            // 
            // chartTemp
            // 
            chartArea1.Name = "ChartArea1";
            this.chartTemp.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartTemp.Legends.Add(legend1);
            this.chartTemp.Location = new System.Drawing.Point(39, 56);
            this.chartTemp.Name = "chartTemp";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Температура";
            this.chartTemp.Series.Add(series1);
            this.chartTemp.Size = new System.Drawing.Size(665, 314);
            this.chartTemp.TabIndex = 6;
            this.chartTemp.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "Наверно машина";
            this.chartTemp.Titles.Add(title1);
            this.chartTemp.Click += new System.EventHandler(this.chartTemp_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 26);
            this.button1.TabIndex = 7;
            this.button1.Text = "Построить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // teleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chartTemp);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.id);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MainMenuStrip = this.id;
            this.Name = "teleForm";
            this.Text = "teleForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.teleForm_FormClosed);
            this.Load += new System.EventHandler(this.teleForm_Load);
            this.Click += new System.EventHandler(this.teleForm_Click);
            this.id.ResumeLayout(false);
            this.id.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTemp)).EndInit();
            this.id_devMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.MenuStrip id;
        private System.Windows.Forms.ToolStripComboBox typeCombo;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTemp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip id_devMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem id_dev;
        private System.Windows.Forms.ToolStripMenuItem par;
        private System.Windows.Forms.ToolStripMenuItem времяРаботыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem уроеньПотребленияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem уровеньНагрузкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem температураToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem уровеньВибрацииToolStripMenuItem;
    }
}