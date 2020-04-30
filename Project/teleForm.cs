using System;
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
    public partial class teleForm : Form
    {
        public user curuser = new user();
        List<devCommit> dataList = new List<devCommit>();

        public teleForm()
        {
            InitializeComponent();
            
        }

        public void teleForm_FormClosed(object sender, EventArgs e)
        {
            this.Hide();

        }


        private void visualizeAll()
        {
            chartTemp.Visible = true;

            if (typeCombo.SelectedIndex == 0)
            {
                
                chartTemp.Series["Температура"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                chartTemp.Series["Температура"].Points.AddXY("1", 10);
                chartTemp.Series["Температура"].Points.AddXY("2", 50);
                chartTemp.Series["Температура"].Points.AddXY("3", 100);

            }
            if (typeCombo.SelectedIndex == 1)
            {
                chartTemp.Series["Температура"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                chartTemp.Series["Температура"].Points.AddXY("1", 1000);
                chartTemp.Series["Температура"].Points.AddXY("2", 500);
                chartTemp.Series["Температура"].Points.AddXY("3", 10000);
            }
            if (typeCombo.SelectedIndex == 2)
            {
                chartTemp.Hide();
            }

        }


        private void button1_Click(object sender, EventArgs e)
        {
            visualizeAll();
        }


        private void teleForm_Load(object sender, EventArgs e)
        {
            WebRequests client = new WebRequests();
            dataList = client.getDevData(curuser.login, curuser.password);

            List<string> somedevs = new List<string>();

            for (int i = 0; i < dataList.Count; i++)
            {
                if (!somedevs.Contains(dataList[i].dev_id.ToString()))
                    somedevs.Add(dataList[i].dev_id.ToString());
                dataList[i].getDate();
            }

            for (int i = 0; i < somedevs.Count; i++)
            {
                ToolStripMenuItem newItem = new ToolStripMenuItem(somedevs[i]) { Checked = true, CheckOnClick = true };
                id_dev.DropDownItems.Add(newItem);
            }

            chartTemp.Visible = false;

        }

        private void par_Click(object sender, EventArgs e)
        {
            par.DropDown.AutoClose = false;
        }

        private void teleForm_Click(object sender, EventArgs e)
        {
            par.DropDown.Close();
        }

        private void chartTemp_Click(object sender, EventArgs e)
        {
            par.DropDown.Close();
        }
    }
}
