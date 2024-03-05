using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CGLab1
{
    public partial class Form1 : Form
    {
        private bool isImageInserted = false;
        private Bitmap bmpInsertedImage; //открытая картинка
        private List<byte[,]> colorMarix = new List<byte[,]>();//матрица разложенных цветов
        private Dictionary<NumericUpDown, DataGridView> updowns_grids = new Dictionary<NumericUpDown, DataGridView>(3);
        private const int imageSideLength = 20;
        private Point selectedCell = new Point();
        private bool isBinaryMode = false;

        private enum Colors
        {
            Red,
            Green,
            Blue,
        }

        public Form1()
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

        }

        /// <summary>
        /// Поиск картинки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_FindImage_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog.FileName;
                var openedBMP = new Bitmap(path);

                panel_InsertedImage.BackgroundImage = openedBMP;

                bmpInsertedImage = openedBMP;

                isImageInserted = true;

                if (CheckIfBlackWhite(bmpInsertedImage))
                {
                    isBinaryMode = true;
                    var bwbmp = ConvertBWBitmapToBinary(bmpInsertedImage);
                    colorMarix = DivideImageToRGBMatrixes(bwbmp);
                    InitializeRGBGrid(colorMarix[(byte)Colors.Red], dataGridView_Red);
                    InitializeRGBGrid(colorMarix[(byte)Colors.Green], dataGridView_Green);
                    InitializeRGBGrid(colorMarix[(byte)Colors.Blue], dataGridView_Blue);
                }
                else
                {
                    isBinaryMode=false;
                    colorMarix = DivideImageToRGBMatrixes(openedBMP);
                    InitializeRGBGrid(colorMarix[(byte)Colors.Red], dataGridView_Red);
                    InitializeRGBGrid(colorMarix[(byte)Colors.Green], dataGridView_Green);
                    InitializeRGBGrid(colorMarix[(byte)Colors.Blue], dataGridView_Blue);
                }
            }
        }


        /// <summary>
        /// Сохранение картинки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_SaveImage_Click(object sender, EventArgs e)
        {
            if (isImageInserted)
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {

                    Bitmap bmp = new Bitmap(20, 20);
                    for (int y = 0; y < bmp.Height; y++)
                    {
                        for (int x = 0; x < bmp.Width; x++)
                        {
                            Color color = Color.FromArgb(
    Convert.ToByte(dataGridView_Red[x, y].Value),
    Convert.ToByte(dataGridView_Green[x, y].Value),
    Convert.ToByte(dataGridView_Blue[x, y].Value));

                            if (isBinaryMode)
                            {
                                if (color == Color.FromArgb(1, 1, 1))
                                {
                                    bmp.SetPixel(x, y, Color.FromArgb(0, 0, 0));
                                }
                                if (color == Color.FromArgb(0, 0, 0))
                                {
                                    bmp.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                                }
                            }
                            else
                            {

                                bmp.SetPixel(x, y, color);
                            }
                        }
                    }

                    bmp.Save(saveFileDialog.FileName);
                    panel_changed.BackgroundImage = new Bitmap(saveFileDialog.FileName);
                }
            }
            else MessageBox.Show("Изображение не выбрано", "Ошибка");
        }


        /// <summary>
        /// Если картинка выбрана, то при нажатии мыши выделяется пиксель, который отображается в специальной панели, 
        /// определяются значения RGB для пикселя. При повторном нажатии пиксель меняется, но не сохранятеся.
        /// Если картинки нет, то открывается openFileDialog и картинка добавляется
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel_InsertedImage_MouseClick(object sender, MouseEventArgs e)
        {
            if (!isImageInserted)
            {

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string path = openFileDialog.FileName;
                    var openedBMP = new Bitmap(path); // открывается картинка и созраняется в памяти

                    panel_InsertedImage.BackgroundImage = openedBMP;

                    bmpInsertedImage = openedBMP;
                    isImageInserted = true;
                }
            }
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (isImageInserted)
            {
                DataGridView dg = sender as DataGridView;
                selectedCell.X = dg.CurrentCellAddress.X;
                selectedCell.Y = dg.CurrentCellAddress.Y;
                numericUpDown_Red.Value = (decimal)Convert.ToInt32(dataGridView_Red[selectedCell.X, selectedCell.Y].Value);
                numericUpDown_Green.Value = (decimal)Convert.ToInt32(dataGridView_Green[selectedCell.X, selectedCell.Y].Value);
                numericUpDown_Blue.Value = (decimal)Convert.ToInt32(dataGridView_Blue[selectedCell.X, selectedCell.Y].Value);
            }
            else
            {
                MessageBox.Show("Изображение не выбрано");
            }
        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (isImageInserted)
            {
                var updown = sender as NumericUpDown;
                DataGridView dg = updowns_grids[updown];
                dg[selectedCell.X, selectedCell.Y].Value = updown.Value;
            }
            else
            {
                MessageBox.Show("Изображение не выбрано");
            }
        }

        private List<byte[,]> DivideImageToRGBMatrixes(Bitmap bmp)
        {
            byte[,] matrixRed = new byte[imageSideLength, imageSideLength];
            byte[,] matrixGreen = new byte[imageSideLength, imageSideLength];
            byte[,] matrixBlue = new byte[imageSideLength, imageSideLength];

            for (int i = 0; i < imageSideLength; i++)
            {
                for (int j = 0; j < imageSideLength; j++)
                {
                    var pixel = bmp.GetPixel(j, i);
                    matrixRed[i, j] = pixel.R;
                    matrixGreen[i, j] = pixel.G;
                    matrixBlue[i, j] = pixel.B;
                }
            }

            return new List<byte[,]> { matrixRed, matrixGreen, matrixBlue };
        }

        private void InitializeRGBGrid(byte[,] matrix, DataGridView grid)
        {
            Parallel.For(0, imageSideLength, (i) =>
            {
                Parallel.For(0, imageSideLength, (j) =>
                {
                    grid.Rows[i].Cells[j].Value = matrix[i, j];
                });
            }); // не все значения инициализируются
            //for (int i = 0; i < imageSideLength; i++)
            //{
            //    for (int j = 0; j < imageSideLength; j++)
            //    {
            //        grid.Rows[i].Cells[j].Value = matrix[i, j];
            //    }
            //}
        }

        private bool CheckIfBlackWhite(Bitmap bmp)
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

        private Bitmap ConvertBWBitmapToBinary(Bitmap bmp)
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
                    if (bmp.GetPixel(x, y) == Color.FromArgb(255, 255, 255))
                    {
                        newBmp.SetPixel(x, y, Color.FromArgb(0, 0, 0));
                    }

                }
            }
            return newBmp;

        }
    }
}
