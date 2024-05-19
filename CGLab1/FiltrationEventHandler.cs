using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CGLab1
{
    public partial class MainForm
    {
        private int _filterSize = 1;
        private void pictureBox_FilterOriginalImage_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                pictureBox_FilterOriginalImage.Image = new Bitmap(openFileDialog.FileName);
                ClearDataGridView(dataGridView_MedianFilterValues);
            }
        }

        private void button_FiltrationFindImage_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                pictureBox_FilterOriginalImage.Image = new Bitmap(openFileDialog.FileName);
                ClearDataGridView(dataGridView_MedianFilterValues);
            }
        }

        private void button_FiltrationSaveImage_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                pictureBox_FilterChangedImage.Image.Save(saveFileDialog.FileName);
            }
        }

        private void button_UseFilter_Click(object sender, EventArgs e)
        {
            //add check if imamge is exsiting
            //do it for all 3 colors 
            //replace to another method
            var bmp = new Bitmap(pictureBox_FilterOriginalImage.Image);
            double[,] imageColorValues_R = new double[bmp.Height, bmp.Width];
            double[,] imageColorValues_G = new double[bmp.Height, bmp.Width];
            double[,] imageColorValues_B = new double[bmp.Height, bmp.Width];

            for (int i = 0; i < bmp.Height; i++)
            {
                for (int j = 0; j < bmp.Width; j++)
                {
                    var pixel = bmp.GetPixel(j, i);
                    imageColorValues_R[i,j] = pixel.R;
                    imageColorValues_G[i,j] = pixel.G;
                    imageColorValues_B[i,j] = pixel.B;
                }
            }

            double[,] medianValues_R = new double[bmp.Height, bmp.Width];
            double[,] medianValues_G = new double[bmp.Height, bmp.Width];
            double[,] medianValues_B = new double[bmp.Height, bmp.Width];
            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    double redMedian = FindMedianValueInMatrix(x, y, imageColorValues_R);
                    double greenMedian = FindMedianValueInMatrix(x, y, imageColorValues_G);
                    double blueMedian = FindMedianValueInMatrix(x, y, imageColorValues_B);

                    medianValues_R[y,x] = redMedian;
                    medianValues_G[y,x] = greenMedian;
                    medianValues_B[y,x] = blueMedian;
                }
            }


            //create image from medians
            Bitmap medianBmp = new Bitmap(bmp.Width, bmp.Height);
            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    Color pixel = Color.FromArgb(
                        Convert.ToByte(medianValues_R[y, x]),
                        Convert.ToByte(medianValues_G[y, x]),
                        Convert.ToByte(medianValues_B[y, x]));
                    medianBmp.SetPixel(x, y, pixel);
                }
            }
            pictureBox_FilterChangedImage.Image = medianBmp;
        }

        private double FindMedianValueInMatrix(int x, int y, double[,] grid) //j i
        {
            List<double> medianValues = new List<double>();

            int sz = (_filterSize) / 2; //5
            if (sz % 2 == 1)
            {
                for (int i = -sz; i < sz + 1; i++)
                {
                    for (int j = -sz; j < sz + 1; j++)
                    {
                        try
                        {
                            medianValues.Add(grid[y + i, x + j]);
                        }
                        catch (IndexOutOfRangeException)
                        {
                            medianValues.Add(byte.MaxValue);
                            continue;
                        }
                    }
                }
            }

            else
            {
                for (int i = -sz; i < sz; i++)
                {
                    for (int j = -sz; j < sz; j++)
                    {
                        try
                        {
                            medianValues.Add(grid[y + i, x + j]);
                        }
                        catch (IndexOutOfRangeException)
                        {
                            medianValues.Add(byte.MaxValue);
                            continue;
                        }
                    }
                }
            }


            //get median
            var sortedMedian = medianValues.OrderBy(i => i).ToList();
            int len = sortedMedian.Count;
            if (len % 2 == 1) { return sortedMedian[(int)(len / 2)]; }
           else { return sortedMedian[(len / 2)+1]; }
        }

        private void numericUpDown_FilterSize_ValueChanged(object sender, EventArgs e)
        {
            _filterSize  = (int)((sender as NumericUpDown).Value);
        }
    }
}
