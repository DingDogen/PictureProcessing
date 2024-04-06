using CGLab1.AddintionlaForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CGLab1
{
    public partial class MainForm : Form
    {
        private bool isImageInsertedView = false;
        private List<byte[,]> colorMarix = new List<byte[,]>();//матрица разложенных цветов
        private Dictionary<NumericUpDown, DataGridView> updowns_grids = new Dictionary<NumericUpDown, DataGridView>(3);
        private const int imageSideLength = 20; //delete 
        private Point selectedCell = new Point();
        private bool isBinaryView = false;


        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < imageSideLength; i++)
            {
                DataGridViewTextBoxColumn newCol = new DataGridViewTextBoxColumn()
                {
                    Width = 20,
                    ValueType = typeof(byte),
                    HeaderText = "",
                    Name = "Column" + i
                };
                dataGridView_Red.Columns.Add(newCol);
                dataGridView_Red.Rows.Add();

                dataGridView_Green.Columns.Add(newCol.Clone() as DataGridViewTextBoxColumn);
                dataGridView_Green.Rows.Add();

                dataGridView_Blue.Columns.Add(newCol.Clone() as DataGridViewTextBoxColumn);
                dataGridView_Blue.Rows.Add();
            }

            updowns_grids = new Dictionary<NumericUpDown, DataGridView>(3)
            {
                {numericUpDown_Red, dataGridView_Red },
                {numericUpDown_Green, dataGridView_Green },
                {numericUpDown_Blue, dataGridView_Blue },
            };
            comboBox_BinarizationMethods.SelectedIndex = 0;

        }

        //TODO вынести в отдельный класс??
        private bool CheckIfBlackWhite(Bitmap bmp) //готов
        {
            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    if (bmp.GetPixel(x, y) != Color.FromArgb(0, 0, 0) && bmp.GetPixel(x, y) != Color.FromArgb(255, 255, 255))
                    {
                        return false;
                    }

                }
            }
            return true;
        }

        //TODO вынести в отдельный класс??
        private Bitmap ConvertBWBitmapToBinary(Bitmap bmp) //готов
        {
            Bitmap newBmp = new Bitmap(bmp);
            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    if (bmp.GetPixel(x, y) == Color.FromArgb(0, 0, 0))
                    {
                        newBmp.SetPixel(x, y, Color.FromArgb(1, 1, 1));
                    }
                    else if (bmp.GetPixel(x, y) == Color.FromArgb(255, 255, 255))
                    {
                        newBmp.SetPixel(x, y, Color.FromArgb(0, 0, 0));
                    }

                }
            }
            return newBmp;

        }

    }
}
