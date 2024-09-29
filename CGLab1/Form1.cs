using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CGLab1
{
    public partial class MainForm : Form
    {
        private List<byte[,]> colorMarix = new List<byte[,]>();//матрица разложенных цветов
        private Dictionary<NumericUpDown, DataGridView> updowns_grids = new Dictionary<NumericUpDown, DataGridView>(3); //do i need this

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //replace to another file
            updowns_grids = new Dictionary<NumericUpDown, DataGridView>(3)
            {
                {numericUpDown_RgbView_Red, dataGridView_Red },
                {numericUpDown_RgbView_Green, dataGridView_Green },
                {numericUpDown_RgbView_Blue, dataGridView_Blue },
            };
            comboBox_BinarizationMethods.SelectedIndex = 0;
        }
	}
}
