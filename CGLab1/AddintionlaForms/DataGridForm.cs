using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CGLab1.AddintionlaForms
{
    public partial class DataGridForm : Form
    {
        Bitmap currentBmp;
        public DataGridForm(Bitmap bmp)
        {
            InitializeComponent();
            this.currentBmp = bmp;
        }

        private void DataGridForm_Load(object sender, EventArgs e)
        {
            CreateEmptyDataGridViewForBitmap(currentBmp);
            for(int i=0; i< dataGridView.Rows.Count; i++)
            {
                for(int j=0; j < dataGridView.Rows[i].Cells.Count;j++)
                {
                    dataGridView.Rows[i].Cells[j].Value = byte.MaxValue - currentBmp.GetPixel(j, i).R; //r=g=b
                }
            }
        }

        private void CreateEmptyDataGridViewForBitmap(Bitmap bmp)
        {
            if (bmp == null)
            {
                throw new ArgumentNullException("bmp", "В метод передан неинициализированный аргумент");
            }

            for (int i = 0; i < bmp.Width; i++)
            {
                DataGridViewTextBoxColumn newCol = new DataGridViewTextBoxColumn()
                {
                    Width = 50,
                    ValueType = typeof(byte),
                    HeaderText = "",
                    Name = "Column" + i
                };
                dataGridView.Columns.Add(newCol);
                dataGridView.Rows.Add();
            }
        }

    }
}
