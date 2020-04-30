using System;
using System.Collections.Generic;
using System.Windows.Forms;

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
            chartTemp.Visible = true;

            if (typeCombo.SelectedIndex == 0)
            {
                
                chartTemp.Series["Температура"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                chartTemp.Series["Температура"].Points.AddXY("1", 10);
                chartTemp.Series["Температура"].Points.AddXY("2", 50);
                chartTemp.Series["Температура"].Points.AddXY("3", 100);

            }
            if (typeCombo.SelectedIndex == 1)
            {
                chartTemp.Series["Температура"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                chartTemp.Series["Температура"].Points.AddXY("1", 1000);
                chartTemp.Series["Температура"].Points.AddXY("2", 500);
                chartTemp.Series["Температура"].Points.AddXY("3", 10000);
            }
            if (typeCombo.SelectedIndex == 2)
            {
                chartTemp.Hide();
            }

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {
            
        }
        
        private void teleForm_Load(object sender, EventArgs e)
        {
            WebRequests client = new WebRequests();
            id_dev.DropDown.AutoClose = false;
            par.DropDown.AutoClose = false;
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

        private void teleForm_Click(object sender, EventArgs e)
        {
            par.DropDown.Close();
            id_dev.DropDown.Close();
        }

        private void chartTemp_Click(object sender, EventArgs e)
        {
            par.DropDown.Close();
            id_dev.DropDown.Close();
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

        private void ВремяРаботыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void Par_Click(object sender, EventArgs e)
        {
            par.DropDown.AutoClose = false;
        }

        private void TeleForm_Click(object sender, EventArgs e)
        {
            id_dev.DropDown.Close();
            par.DropDown.Close();
        }
    }
}
