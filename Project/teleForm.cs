using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace window3
{
    public partial class teleForm : Form
    {
        public user curuser = new user();
        List<devCommit> dataList = new List<devCommit>();
        bool flagToChange = true;


        public teleForm()
        {
            InitializeComponent();
            
        }

        public void teleForm_FormClosed(object sender, EventArgs e)
        {
            this.Hide();

        }


        private void draw()
        {
            //chartTemp.Visible = true;
            int a, b = 0;
            int posY=0;
            //поиск крайних элементов бд в зависимости от даты
            foreach (devCommit tempCom in dataList)
            {
                if (tempCom.dattim.CompareTo(dPicker1.Value) >= 0)
                {
                    a = dataList.IndexOf(tempCom);
                    break;
                }
            }
            foreach (devCommit tempCom in dataList)
            {
                if (tempCom.dattim.CompareTo(dPicker2.Value) == 0)
                {
                    b = dataList.IndexOf(tempCom);
                    break;
                }else if (tempCom.dattim.CompareTo(dPicker2.Value) > 0)
                {
                    b = dataList.IndexOf(tempCom)-1;
                }

            }
            infoBox.Controls.Clear();
            if (typeCombo.SelectedIndex == 0)
            {
                foreach (ToolStripMenuItem curpar in par.DropDownItems)
                {
                    if (!curpar.Checked) continue;
                    Chart tempChart = new Chart();
                    ChartArea chartArea1 = new ChartArea();
                    Legend Legend1 = new Legend();
                    Title title = new Title();

                    title.Text = curpar.Text;
                    chartArea1.Name = "ChartArea1";
                    Legend1.Name = "Legend1";
                    tempChart.Name = curpar.Name;
                    tempChart.Text = curpar.Text;

                    tempChart.Size = new System.Drawing.Size(500,200);
                    tempChart.Location = new System.Drawing.Point(10,posY);posY += 250;
                    tempChart.Legends.Add(Legend1);
                    tempChart.Titles.Add(title);
                    tempChart.ChartAreas.Add(chartArea1);
                    infoBox.Controls.Add(tempChart);

                    foreach (ToolStripMenuItem id in id_dev.DropDownItems)
                    {
                        if (!id.Checked) continue;
                        Series ser = new Series();
                        ser.Legend = "Legend1";
                        ser.LegendText = id.Text;
                        ser.Name = "ser"+id.Text;
                        ser.ChartArea = "ChartArea1";
                        ser.ChartType = SeriesChartType.Line;
                        tempChart.Series.Add(ser);
                    }
                }
                /*chartTemp.Series["Температура"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                chartTemp.Series["Температура"].Points.AddXY("1", 10);
                chartTemp.Series["Температура"].Points.AddXY("2", 50);
                chartTemp.Series["Температура"].Points.AddXY("3", 100);*/

            }
            /*if (typeCombo.SelectedIndex == 1)
            {
                chartTemp.Series["Температура"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                chartTemp.Series["Температура"].Points.AddXY("1", 1000);
                chartTemp.Series["Температура"].Points.AddXY("2", 500);
                chartTemp.Series["Температура"].Points.AddXY("3", 10000);
            }
            if (typeCombo.SelectedIndex == 2)
            {
                chartTemp.Hide();
            }*/

        }
        
        private void teleForm_Load(object sender, EventArgs e)
        {
            WebRequests client = new WebRequests();
            id_dev.DropDown.AutoClose = false;
            par.DropDown.AutoClose = false;
            id_dev.DropDown.MouseLeave += new System.EventHandler(TeleForm_Leave);
            par.DropDown.MouseLeave += new System.EventHandler(TeleForm_Leave);
            dataList = client.getDevData(curuser.login, curuser.password);
            devListUpdate();
            for (int i = 0; i < dataList.Count; i++)
            {
                devCommit tempCom = dataList[i]; tempCom.getDate(); dataList[i] = tempCom;
            }
            dPicker1.MaxDate = dataList[dataList.Count - 1].dattim;
            dPicker1.MinDate = dataList[0].dattim;
            dPicker1.Value = dataList[0].dattim;
            dPicker2.MaxDate = dataList[dataList.Count - 1].dattim;
            dPicker2.MinDate = dataList[0].dattim;
            dPicker2.Value = dataList[dataList.Count - 1].dattim;
        }

        private void par_checkAll_Click(object sender, EventArgs e)
        {
            flagToChange = false;
            foreach(ToolStripMenuItem someItem in par.DropDownItems)
            {
                if (someItem == par_checkAll) continue;
                if (par_checkAll.Checked)
                    someItem.Checked = true;
                else
                    someItem.Checked = false;
            }
            draw(); flagToChange = true;
        }

        private void dev_checkAll_Click(object sender, EventArgs e)
        {
            flagToChange = false;
            foreach (ToolStripMenuItem someItem in id_dev.DropDownItems)
            {
                if (someItem == dev_checkAll) continue;
                if (dev_checkAll.Checked)
                    someItem.Checked = true;
                else
                    someItem.Checked = false;
            }
            draw(); flagToChange = true;
        }

        private void всеПоля_CheckedChanged(object sender, EventArgs e)
        {
            if (flagToChange)
            {
                ToolStripMenuItem curItem = new ToolStripMenuItem();
                if (curItem.GetType() == sender.GetType())
                {
                    curItem = (ToolStripMenuItem)sender;
                    if (curItem.OwnerItem == id_dev) dev_checkAll.Checked = false;
                    if (curItem.OwnerItem == par) par_checkAll.Checked = false;
                }
                draw();
            }
        }

        private void devListUpdate()
        {
            List<string> somedevs = new List<string>();
            id_dev.DropDownItems.Clear();
            id_dev.DropDownItems.Add(dev_checkAll);
            for (int i = 0; i < dataList.Count; i++)
            {
                if (!somedevs.Contains(dataList[i].dev_id.ToString()))
                    somedevs.Add(dataList[i].dev_id.ToString());
            }
            for (int i = 0; i < somedevs.Count; i++)
            {
                ToolStripMenuItem newItem = new ToolStripMenuItem(somedevs[i]) { CheckOnClick = true };
                newItem.CheckedChanged += new System.EventHandler(this.всеПоля_CheckedChanged);
                id_dev.DropDownItems.Add(newItem);
            }
        }

        private void TeleForm_Leave(object sender, EventArgs e)
        {
            par.DropDown.Close();
            id_dev.DropDown.Close();
        }

        private void DPicker_ValueChanged(object sender, EventArgs e)
        {
            if (dPicker1.Value.CompareTo(dPicker2.Value) > 0) dPicker1.Value = dPicker2.Value;
        }
    }
}
