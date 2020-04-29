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

        private void button1_Click(object sender, EventArgs e)
        {
            chartTemp.ChartAreas[0].AxisX.ScaleView.Zoom(0,4);
            chartTemp.ChartAreas[0].CursorX.IsUserEnabled = true;
            chartTemp.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            chartTemp.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            chartTemp.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = true;

            chartTemp.ChartAreas[0].AxisY.ScaleView.Zoom(0, 50);
            chartTemp.ChartAreas[0].CursorY.IsUserEnabled = true;
            chartTemp.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;
            chartTemp.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
            chartTemp.ChartAreas[0].AxisY.ScrollBar.IsPositionedInside = true;


            int s = 0;
            for (int i = 1; i < 4; i++)
            {
                chartTemp.Series["Температура"].Points.AddXY( i+1 , s + 10);
                s+=40;
            }

            //chartTemp.Series["Температура"].Points.AddXY("1", 10);
            //chartTemp.Series["Температура"].Points.AddXY("2", 50);
            //chartTemp.Series["Температура"].Points.AddXY("3", 100);

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

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
                
            }

            for (int i = 0; i < somedevs.Count; i++)
            {
                ToolStripMenuItem newItem = new ToolStripMenuItem(somedevs[i]) { Checked = true, CheckOnClick = true };
                id_dev.DropDownItems.Add(newItem);
            }

            List<string> somedevs = new List<string>();

            for (int i = 0; i<dataList.Count; i++)
            {
                if (!somedevs.Contains(dataList[i].dev_id.ToString()))
                    somedevs.Add(dataList[i].dev_id.ToString());
            }

            for (int i=0; i<somedevs.Count; i++)
            {
                ToolStripMenuItem newItem = new ToolStripMenuItem(somedevs[i]) { Checked = true, CheckOnClick = true };
                itemToolStripMenuItem.DropDownItems.Add(newItem);
            }


            ToolStripMenuItem saveItem = new ToolStripMenuItem("Сохранить") { Checked = true, CheckOnClick = true };
            itemToolStripMenuItem.DropDownItems.Add(saveItem);

            this.typeCombo.Items.AddRange(new object[] {
            "Диаграмма",
            "График",
            "Таблица"});

        }
        public void visualizeAll()
        {
            
            if (typeCombo.SelectedIndex==0)
            {
            }
            if (typeCombo.SelectedIndex == 1)
            {

            }
            if (typeCombo.SelectedIndex == 2)
            {

            }
        }
    }
}
