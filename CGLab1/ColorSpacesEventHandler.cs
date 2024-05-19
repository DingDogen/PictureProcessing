using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using CGLab1.AddintionalForms;
using CGLab1.MathExtensions;

namespace CGLab1
{
    public partial class MainForm
    {
        private void button_YUVFind_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                pictureBox_OriginalRGBPicture.Image = new Bitmap(openFileDialog.FileName);

                ClearDataGridView(dataGridView_YUV_Y);
                ClearDataGridView(dataGridView_YUV_U);
                ClearDataGridView(dataGridView_YUV_V);

                CreateDataGridForPicture(new Bitmap(pictureBox_OriginalRGBPicture.Image), dataGridView_YUV_Y);
                CreateDataGridForPicture(new Bitmap(pictureBox_OriginalRGBPicture.Image), dataGridView_YUV_U);
                CreateDataGridForPicture(new Bitmap(pictureBox_OriginalRGBPicture.Image), dataGridView_YUV_V);
                CreateYuvImage(new Bitmap(openFileDialog.FileName));
            }
        }
        private void pictureBox_OriginalRGBPicture_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                pictureBox_OriginalRGBPicture.Image = new Bitmap(openFileDialog.FileName);

                ClearDataGridView(dataGridView_YUV_Y);
                ClearDataGridView(dataGridView_YUV_U);
                ClearDataGridView(dataGridView_YUV_V);

                CreateDataGridForPicture(new Bitmap(pictureBox_OriginalRGBPicture.Image), dataGridView_YUV_Y);
                CreateDataGridForPicture(new Bitmap(pictureBox_OriginalRGBPicture.Image), dataGridView_YUV_U);
                CreateDataGridForPicture(new Bitmap(pictureBox_OriginalRGBPicture.Image), dataGridView_YUV_V);
                CreateYuvImage(new Bitmap(openFileDialog.FileName));
            }
        }

        private void button_YUVSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                pictureBox_OriginalRGBPicture.Image.Save(saveFileDialog.FileName);
            }

        }


        private void pictureBox_YUVPicture_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                pictureBox_OriginalRGBPicture.Image.Save(saveFileDialog.FileName);
            }
        }

        //make universal replace to another place
        private void CreateDataGridForPicture(Bitmap bmp, DataGridView dataGrid)
        {
            for (int i = 0; i < bmp.Height; i++)
            {
                DataGridViewTextBoxColumn newCol = new DataGridViewTextBoxColumn()
                {
                    Width = 30,
                    ValueType = typeof(byte),
                    HeaderText = "",
                    Name = "Column" + i
                };

                dataGrid.Columns.Add(newCol);
                dataGrid.Rows.Add();
            }

        }

        //divide on methods
        private const double Gamma = 1.0d;
        private const double Kb = 0.114d; //unused bc formulas down are already used this kf
        private const double Kr = 0.299d; //unused bc formulas down are already used this kf
        private void CreateYuvImage(Bitmap bmp)
        {
            //create yuv values
            double[,] Y = new double[bmp.Height, bmp.Width];
            double[,] U = new double[bmp.Height, bmp.Width];
            double[,] V = new double[bmp.Height, bmp.Width];

            for (int i = 0; i < bmp.Height; i++)
            {
                for (int j = 0; j < bmp.Width; j++)
                {
                    //from stackoverflow
                    var pixel = bmp.GetPixel(j, i);
                    Y[i, j] = (((66 * pixel.R + 129 * pixel.G + 25 * pixel.B + 128) / 256) + 16) * Gamma;
                    U[i, j] = ((-38 * pixel.R - 74 * pixel.G + 112 * pixel.B + 128) / 256) + 128;
                    V[i, j] = ((112 * pixel.R - 94 * pixel.G - 18 * pixel.B + 128) / 256) + 128;

                    //from wiki
                    //var pixel = bmp.GetPixel(j, i);
                    //double mfR = pixel.R / 256;
                    //double mfG = pixel.G / 256;
                    //double mfB = pixel.B / 256;

                    ////Y[i, j] = Gamma;
                    //Y[i, j] = 16 + ((65.481 * mfR + 128.553 * mfG + 24.966 * mfB));
                    //U[i, j] = 128 + (-37.797 * mfR - 74.203 * mfG + 112d * mfB);
                    //V[i, j] = 128 + (112d + mfR - 93.786 * mfG - 18.214 * mfB);
                }
            }

            //init datagrids with yuv values
            for (int i = 0; i < bmp.Height; i++)
            {
                for (int j = 0; j < bmp.Width; j++)
                {
                    dataGridView_YUV_Y[i,j].Value = Y[i, j];
                    dataGridView_YUV_U[i, j].Value = U[i, j];
                    dataGridView_YUV_V[i, j].Value = V[i, j];
                }
            }

            //create from yuv values half tone image
            Bitmap colorYuv2gray = new Bitmap(bmp.Width, bmp.Height);
            Bitmap colorRgb2gray = new Bitmap(bmp.Width, bmp.Height);
            for (int i = 0; i < bmp.Height; i++)
            {
                for (int j = 0; j < bmp.Width; j++)
                {
                    //from original bmp rgb
                    Color originalPixel = bmp.GetPixel(j, i);
                    double greyValue_RGB= 0.2989d * originalPixel.R + 0.5870d * originalPixel.G + 0.1140d * originalPixel.B;
                    colorRgb2gray.SetPixel(j, i, Color.FromArgb(greyValue_RGB.Clamp(byte.MinValue, byte.MaxValue), greyValue_RGB.Clamp(byte.MinValue, byte.MaxValue), greyValue_RGB.Clamp(byte.MinValue, byte.MaxValue)));

                    //from yuv bmp
                    double greyValue_YUV = Y[i,j];
                    colorYuv2gray.SetPixel(j, i, Color.FromArgb(greyValue_YUV.Clamp(byte.MinValue, byte.MaxValue), greyValue_YUV.Clamp(byte.MinValue, byte.MaxValue), greyValue_YUV.Clamp(byte.MinValue, byte.MaxValue)));

                }
            }
            //pictureBox_YUVPicture.Image = colorYuv2gray;


            //create binary pic from half tone yuv  120%
            Bitmap grayYuv2Binary = new Bitmap(bmp.Width, bmp.Height);
            Bitmap grayRgb2Binary = new Bitmap(bmp.Width, bmp.Height);

            #region binarization 120%
            //calculate unique and mathes
            double[] uniqueValues_RGB = Y.Cast<double>().Distinct().ToArray(); //incorrect source
            double[] uniqueValues_YUV = Y.Cast<double>().Distinct().ToArray();

            Dictionary<double, int> mathes_RGB = new Dictionary<double, int>();
            Dictionary<double, int> mathes_YUV = new Dictionary<double, int>();

            for(int i =0; i < uniqueValues_RGB.Length; i++)
            {
                mathes_RGB.Add(uniqueValues_RGB[i], Y.Cast<double>().Where(elem => elem == uniqueValues_RGB[i]).Count());
                mathes_YUV.Add(uniqueValues_YUV[i], Y.Cast<double>().Where(elem => elem == uniqueValues_YUV[i]).Count());
            }
            mathes_RGB.OrderBy(elem => elem.Key); //сортировка по ключу
            mathes_YUV.OrderBy(elem => elem.Key); //сортировка по ключу

            //calculate max grey level
            int limit_RGB = (int)Math.Truncate((double)uniqueValues_RGB.Length * ((120d + 15d) / 255d));
            int limit_YUV = (int)Math.Truncate((double)uniqueValues_YUV.Length * ((120d + 20d) / 255d));

            //set color to limited
            for (int i = 0; i < bmp.Height; i++)
            {
                for (int j = 0; j < bmp.Width; j++)
                {
                    int color_RGB = colorRgb2gray.GetPixel(j,i).R; //gray value rgb
                    Color cur_RGB = color_RGB > limit_RGB ? Color.White : Color.Black;
                    grayRgb2Binary.SetPixel(j, i, cur_RGB);

                    int color_YUV = colorYuv2gray.GetPixel(j, i).R; //gray value yuv
                    Color cur_YUV = color_YUV > limit_YUV ? Color.White : Color.Black;
                    grayYuv2Binary.SetPixel(j, i, cur_YUV);

                }
            }

            #endregion

            //create rgb back from yuv
            Bitmap yuvToRgbBmp = new Bitmap(bmp.Width, bmp.Height);
            int[,] R = new int[bmp.Height, bmp.Width];
            int[,] G = new int[bmp.Height, bmp.Width];
            int[,] B = new int[bmp.Height, bmp.Width];

            for (int i = 0; i < bmp.Height; i++)
            {
                for (int j = 0; j < bmp.Width; j++)
                {
                    double mfR = (298.082 * Y[i, j]) / 256 + (408.583 * V[i, j]) / 256 - 222.921;
                    double mfG = (298.082 * Y[i, j]) / 256 - (100.291 * U[i, j]) / 256 - (208.120 * V[i, j]) / 256 + 135.576;
                    double mfB = (298.082 * Y[i, j]) / 256 + (516.412 * U[i, j]) / 256 - 276.836;

                    R[i, j] = (mfR).Clamp(byte.MinValue, byte.MaxValue);
                    G[i, j] = (mfG).Clamp(byte.MinValue, byte.MaxValue);
                    B[i, j] = (mfB).Clamp(byte.MinValue, byte.MaxValue);
                    yuvToRgbBmp.SetPixel(j, i, Color.FromArgb(R[i, j], G[i, j], B[i, j]));
                }
            }
            pictureBox_YUVPicture.Image = yuvToRgbBmp;


            _3PictureDemo form = new _3PictureDemo(new Bitmap(pictureBox_OriginalRGBPicture.Image), colorRgb2gray, grayRgb2Binary, yuvToRgbBmp, colorYuv2gray, grayYuv2Binary);
            form.Show();
        }

        private void ClearDataGridView(DataGridView dataGrid)
        {
            dataGrid.Rows.Clear();
            dataGrid.Columns.Clear();
            dataGrid.Refresh();
        }

        //функция для полутона
        //функция для бинарника
    }
}
