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

            //1 столбец, текстовый
            DataGridViewTextBoxColumn column0 = new DataGridViewTextBoxColumn();
            column0.Name = "id";
            column0.HeaderText = "ID ";
            //2 столбец, текстовый
            DataGridViewTextBoxColumn column1 = new DataGridViewTextBoxColumn();
            column1.Name = "load";
            column1.HeaderText = "Загрузка, %";
            DataGridViewTextBoxColumn column2 = new DataGridViewTextBoxColumn();
            column2.Name = "data";
            column2.HeaderText = "Дата ";
            data.Columns.AddRange(column0, column1, column2);

            for (int i = 0; i < dataList.Count; i++)
            {
               
                if ((dataList[i].loading > 79) && (dataList[i].loading < 96))
                { 
                    //ячейки для 1 строки
                    DataGridViewCell id0 = new DataGridViewTextBoxCell();
                    DataGridViewCell load0 = new DataGridViewTextBoxCell();
                    DataGridViewCell data0 = new DataGridViewTextBoxCell();
                    id0.Value = dataList[i].dev_id;
                    load0.Value = dataList[i].loading;
                    data0.Value = dataList[i].date;

                    //создание строки
                    DataGridViewRow row0 = new DataGridViewRow();

                    //добавление ячеек в строку
                    row0.Cells.AddRange(id0, load0, data0);

                    //добавление строки в таблицу
                    data.Rows.Add(row0);

                }

                //текст (лабел)
                //if ((dataList[i].loading > 79) && (dataList[i].loading < 96))
                //    reptLabel.Text += "Устройство " + dataList[i].dev_id + " на " + dataList[i].loading + " % " +  dataList[i].date + "\n";

            }
        }

        private void data_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            data.Rows[e.RowIndex].HeaderCell.Value =(e.RowIndex + 1).ToString();
        }
    }
}
