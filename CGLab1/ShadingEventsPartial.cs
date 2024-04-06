using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CGLab1
{
    public partial class Form1
    {
        //shading
        private void button_FindImage_Shading_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                panel_InsertedImage_Shading.BackgroundImage = new Bitmap(openFileDialog.FileName);
            }
        }

        private void panel_InsertedImage_Shading_MouseClick(object sender, MouseEventArgs e) //готов
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                panel_InsertedImage_Shading.BackgroundImage = new Bitmap(openFileDialog.FileName);
            }
        }

        private void button_SaveImage_Shading_Click(object sender, EventArgs e) //make universal one method for saving
        {
            if (panel_ChangedImage_Shading.BackgroundImage != null)
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {

                    Image img = panel_ChangedImage_Shading.BackgroundImage;
                    img.Save(saveFileDialog.FileName);
                    panel_ChangedImage_Shading.BackgroundImage = new Bitmap(saveFileDialog.FileName);
                }
            }
            else MessageBox.Show("Изображение не выбрано", "Ошибка");
        }

        //переименовать ?? отдельный метод??
        /// <summary>
        /// Метод принимает значения пикселей, создает гистрограмму выбранным методом и 
        /// создает Bitmap для хранения относителнього цвета каждого значения от 0(белый) до 255(черный)
        /// </summary>
        /// <param name="shadingMatrix">Матрица значений, которые соответствуют 
        /// относительному тону каждого пикселя на озображении</param>
        /// <param name="gistogramMethod">Метод, определяющий алгоритм создания гистрограммы значений</param>
        /// <returns>Растушеванное изображение</returns>
        /// TODO refoctor for gistogram method working
        private Bitmap CreateShadingImage(double[,] shadingMatrix) // add delegate for gistogramm creating
        {
            //Dictionary<double, int> valueMatches = GetMatches(shadingMatrix);
            Bitmap shadedImage = new Bitmap(shadingMatrix.GetLength(1), shadingMatrix.GetLength(0));

            double[] uniqueValues = GetUniquePixels(shadingMatrix);
            Dictionary<double, byte> colorValue = GetColorPairs(uniqueValues.OrderBy(i => i).ToArray());
            foreach (var i in colorValue)
            {
                Console.WriteLine("Key:" + i.Key + "| Value: " + i.Value);
            }
            for (int i = 0; i < shadingMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < shadingMatrix.GetLength(1); j++)
                {
                    shadedImage.SetPixel(j, i, Color.FromArgb(colorValue[shadingMatrix[i, j]], colorValue[shadingMatrix[i, j]], colorValue[shadingMatrix[i, j]]));
                }
            }
            return shadedImage;
        }

        private Dictionary<double, byte> GetColorPairs(double[] uniqueValues)
        {
            Dictionary<double, byte> colorValues = new Dictionary<double, byte>();
            var step = 255 / (uniqueValues.Count() - 1);
            for (var i = 0; i < uniqueValues.Length; i++)
            {
                var value = uniqueValues[i];
                colorValues.Add(value, (byte)(byte.MaxValue - i * step));
            }

            return colorValues;
        }

        //отедльный метод и статик функиця?
        private double[] GetUniquePixels(double[,] shadingMatrix)
        {
            return shadingMatrix.Cast<double>().Distinct().ToArray();
        }


        /// <summary>
        /// Считает количество совпадающих значений в shadingMarix
        /// </summary>
        /// <param name="shadingMatrix">Матрица значений чисел, полученных после растушевки одним из методов</param>
        /// <returns> Словарь key=matrix unique value value=count of this value</returns>
        /// TODO перенести в шейдинг провайдер 
        private Dictionary<double, int> GetMatches(double[,] shadingMatrix)
        {
            Dictionary<double, int> valueMatches = new Dictionary<double, int>();
            for (int i = 0; i < shadingMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < shadingMatrix.GetLength(1); j++)
                {
                    if (valueMatches.ContainsKey(shadingMatrix[i, j]))
                    {
                        valueMatches[shadingMatrix[i, j]]++;
                    }
                    else
                    {
                        valueMatches.Add(shadingMatrix[i, j], 1);
                    }
                }
            }
            return valueMatches;
        }

        /// <summary>
        /// Создает растушеванное изображение на основе изображения из фона панели
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_MakeShading_Click(object sender, EventArgs e) //исчезает картинка при нажатии
        {
            if (panel_InsertedImage_Shading.BackgroundImage == null)
            {
                return;
            }

            //удалить хардкод!!! событие, которое бы выбирало, какой контрол нажат на табах
            dataGridView_EuclidShading.Rows.Clear();
            dataGridView_EuclidShading.Columns.Clear();

            CreateEmptyDataGridViewForBitmap(new Bitmap(panel_InsertedImage_Shading.BackgroundImage));

            Bitmap bmp = new Bitmap(panel_InsertedImage_Shading.BackgroundImage);
            if (!CheckIfBlackWhite(bmp))
            {
                MessageBox.Show("Изображение не бинарное");
                return;
            }


            ShadingProvider sp = new ShadingProvider(ConvertBWBitmapToBinary(bmp));
            double[,] shading = sp.EuclidShading();

            for (int i = 0; i < shading.GetLength(0); i++) // мб обединить с ргбшкой?
            {
                for (int j = 0; j < shading.GetLength(1); j++)
                {
                    dataGridView_EuclidShading.Rows[i].Cells[j].Value = shading[i, j];
                }
            }


            Bitmap shadedImage = CreateShadingImage(shading); // replace null by some method

            panel_ChangedImage_Shading.BackgroundImage = shadedImage;
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
                dataGridView_EuclidShading.Columns.Add(newCol);
                dataGridView_EuclidShading.Rows.Add();
            }
        }
    }
}
