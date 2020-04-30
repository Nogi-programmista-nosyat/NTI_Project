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
    public partial class reptForm : Form
    {
        public List<devCommit> dataList = new List<devCommit>();

        public reptForm()
        {
            InitializeComponent();
        }

        private void reptForm_Load(object sender, EventArgs e)
        {
            //data.DataSource = dataList;
            //DataGridViewCell id0 = new DataGridViewTextBoxCell();
            //DataGridViewCell brand0 = new DataGridViewTextBoxCell();

            for (int i = 0; i < dataList.Count; i++)
            {
                ////создание строки
                //DataGridViewRow row0 = new DataGridViewRow();
                ////добавление ячеек в строку
                //row0.Cells.AddRange(id0, brand0);
                ////добавление строки в таблицу
                //data.Rows.Add(row0);
                //if ((dataList[i].loading > 79) && (dataList[i].loading < 96))
                //{
                //    this.data.Rows.Add(dataList[i].id);
                //}

                if ((dataList[i].loading > 79) && (dataList[i].loading < 96))
                    reptLabel.Text += "Устройство " + dataList[i].dev_id + " на " + dataList[i].loading + " % " +  dataList[i].date + "\n";

            }
        }
    }
}
