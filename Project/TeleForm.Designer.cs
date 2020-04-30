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
            this.dev_checkAll = new System.Windows.Forms.ToolStripMenuItem();
            this.par = new System.Windows.Forms.ToolStripMenuItem();
            this.par_checkAll = new System.Windows.Forms.ToolStripMenuItem();
            this.времяРаботыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.уроеньПотребленияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.уровеньНагрузкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.уровеньВибрацииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.температураToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dPicker1 = new System.Windows.Forms.DateTimePicker();
            this.dPicker2 = new System.Windows.Forms.DateTimePicker();
            this.chartTemp = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.id_devMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.showButton = new System.Windows.Forms.Button();
            this.insertButton = new System.Windows.Forms.Button();
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
            "График",
            "Диаграмма",
            "Таблица"});
            this.typeCombo.Name = "typeCombo";
            this.typeCombo.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.typeCombo.Size = new System.Drawing.Size(160, 28);
            this.typeCombo.Text = "Вид отображения:";
            this.typeCombo.SelectedIndexChanged += new System.EventHandler(this.всеПоля_CheckedChanged);
            this.typeCombo.Click += new System.EventHandler(this.toolStripComboBox1_Click);
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
            this.времяРаботыToolStripMenuItem,
            this.уроеньПотребленияToolStripMenuItem,
            this.уровеньНагрузкиToolStripMenuItem,
            this.уровеньВибрацииToolStripMenuItem,
            this.температураToolStripMenuItem});
            this.par.Name = "par";
            this.par.Size = new System.Drawing.Size(93, 28);
            this.par.Text = "Параметр";
            this.par.Click += new System.EventHandler(this.Par_Click);
            // 
            // par_checkAll
            // 
            this.par_checkAll.CheckOnClick = true;
            this.par_checkAll.Name = "par_checkAll";
            this.par_checkAll.Size = new System.Drawing.Size(240, 26);
            this.par_checkAll.Text = "Отметить все";
            this.par_checkAll.Click += new System.EventHandler(this.par_checkAll_Click);
            // 
            // времяРаботыToolStripMenuItem
            // 
            this.времяРаботыToolStripMenuItem.CheckOnClick = true;
            this.времяРаботыToolStripMenuItem.Name = "времяРаботыToolStripMenuItem";
            this.времяРаботыToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.времяРаботыToolStripMenuItem.Text = "Время работы";
            this.времяРаботыToolStripMenuItem.CheckedChanged += new System.EventHandler(this.всеПоля_CheckedChanged);
            this.времяРаботыToolStripMenuItem.Click += new System.EventHandler(this.ВремяРаботыToolStripMenuItem_Click);
            // 
            // уроеньПотребленияToolStripMenuItem
            // 
            this.уроеньПотребленияToolStripMenuItem.CheckOnClick = true;
            this.уроеньПотребленияToolStripMenuItem.Name = "уроеньПотребленияToolStripMenuItem";
            this.уроеньПотребленияToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.уроеньПотребленияToolStripMenuItem.Text = "Уроень потребления";
            this.уроеньПотребленияToolStripMenuItem.CheckedChanged += new System.EventHandler(this.всеПоля_CheckedChanged);
            // 
            // уровеньНагрузкиToolStripMenuItem
            // 
            this.уровеньНагрузкиToolStripMenuItem.CheckOnClick = true;
            this.уровеньНагрузкиToolStripMenuItem.Name = "уровеньНагрузкиToolStripMenuItem";
            this.уровеньНагрузкиToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.уровеньНагрузкиToolStripMenuItem.Text = "Уровень нагрузки";
            this.уровеньНагрузкиToolStripMenuItem.CheckedChanged += new System.EventHandler(this.всеПоля_CheckedChanged);
            // 
            // уровеньВибрацииToolStripMenuItem
            // 
            this.уровеньВибрацииToolStripMenuItem.CheckOnClick = true;
            this.уровеньВибрацииToolStripMenuItem.Name = "уровеньВибрацииToolStripMenuItem";
            this.уровеньВибрацииToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.уровеньВибрацииToolStripMenuItem.Text = "Уровень вибрации";
            this.уровеньВибрацииToolStripMenuItem.CheckedChanged += new System.EventHandler(this.всеПоля_CheckedChanged);
            // 
            // температураToolStripMenuItem
            // 
            this.температураToolStripMenuItem.CheckOnClick = true;
            this.температураToolStripMenuItem.Name = "температураToolStripMenuItem";
            this.температураToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.температураToolStripMenuItem.Text = "Температура";
            this.температураToolStripMenuItem.CheckedChanged += new System.EventHandler(this.всеПоля_CheckedChanged);
            // 
            // dPicker1
            // 
            this.dPicker1.CustomFormat = "d.MM.yyyy HH:mm";
            this.dPicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dPicker1.Location = new System.Drawing.Point(407, 6);
            this.dPicker1.Name = "dPicker1";
            this.dPicker1.Size = new System.Drawing.Size(170, 22);
            this.dPicker1.TabIndex = 4;
            // 
            // dPicker2
            // 
            this.dPicker2.CustomFormat = "d.MM.yyyy HH:mm";
            this.dPicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dPicker2.Location = new System.Drawing.Point(599, 6);
            this.dPicker2.Name = "dPicker2";
            this.dPicker2.Size = new System.Drawing.Size(170, 22);
            this.dPicker2.TabIndex = 5;
            // 
            // chartTemp
            // 
            chartArea1.Name = "ChartArea1";
            this.chartTemp.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartTemp.Legends.Add(legend1);
            this.chartTemp.Location = new System.Drawing.Point(39, 70);
            this.chartTemp.Name = "chartTemp";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
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
            this.showButton.Location = new System.Drawing.Point(182, 403);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(244, 26);
            this.showButton.TabIndex = 10;
            this.showButton.Text = "Показать отчёт";
            this.showButton.UseVisualStyleBackColor = true;
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(501, 403);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(244, 26);
            this.insertButton.TabIndex = 11;
            this.insertButton.Text = "Добавить запись";
            this.insertButton.UseVisualStyleBackColor = true;
            // 
            // teleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chartTemp);
            this.Controls.Add(this.dPicker2);
            this.Controls.Add(this.dPicker1);
            this.Controls.Add(this.id);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MainMenuStrip = this.id;
            this.Name = "teleForm";
            this.Text = "teleForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.teleForm_FormClosed);
            this.Load += new System.EventHandler(this.teleForm_Load);
            this.Click += new System.EventHandler(this.TeleForm_Click);
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
        private System.Windows.Forms.DateTimePicker dPicker1;
        private System.Windows.Forms.DateTimePicker dPicker2;
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
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.ToolStripMenuItem dev_checkAll;
        private System.Windows.Forms.ToolStripMenuItem par_checkAll;
    }
}