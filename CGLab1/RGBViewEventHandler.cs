using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CGLab1
{
    public partial class MainForm
    {
        private bool cellSelected = false;
        private Point selectedCell;
        private void pictureBox_OriginalRgbViewPicture_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                pictureBox_OriginalRgbViewPicture.Image = new Bitmap(openFileDialog.FileName);
                ClearDataGridView(dataGridView_Red);
                ClearDataGridView(dataGridView_Green);
                ClearDataGridView(dataGridView_Blue);

                CreateDataGridForPicture(new Bitmap(pictureBox_OriginalRgbViewPicture.Image), dataGridView_Red);
                CreateDataGridForPicture(new Bitmap(pictureBox_OriginalRgbViewPicture.Image), dataGridView_Green);
                CreateDataGridForPicture(new Bitmap(pictureBox_OriginalRgbViewPicture.Image), dataGridView_Blue);

                CreateRGBView(new Bitmap(openFileDialog.FileName));

                pictureBox_ChangedRgbViewPicture.Image = new Bitmap(openFileDialog.FileName);
            }
        }

        private void button_RgbViewFindPicture_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                pictureBox_OriginalRGBPicture.Image = new Bitmap(openFileDialog.FileName);
                ClearDataGridView(dataGridView_Red);
                ClearDataGridView(dataGridView_Green);
                ClearDataGridView(dataGridView_Blue);

                CreateDataGridForPicture(new Bitmap(pictureBox_FilterOriginalImage.Image), dataGridView_Red);
                CreateDataGridForPicture(new Bitmap(pictureBox_FilterOriginalImage.Image), dataGridView_Green);
                CreateDataGridForPicture(new Bitmap(pictureBox_FilterOriginalImage.Image), dataGridView_Blue);

                CreateRGBView(new Bitmap(openFileDialog.FileName));

                pictureBox_ChangedRgbViewPicture.Image = new Bitmap(openFileDialog.FileName);
            }

        }

        private void button_RgbViewSavePicture_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                pictureBox_ChangedRgbViewPicture.Image.Save(saveFileDialog.FileName);
            }

        }

        private void pictureBox_ChangedRgbViewPicture_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                pictureBox_ChangedRgbViewPicture.Image.Save(saveFileDialog.FileName);
            }
        }

        private void CreateRGBView(Bitmap bmp)
        {
            for (int i = 0; i < bmp.Height; i++) //y
            {
                for(int j = 0; j < bmp.Width; j++) //x
                {
                    Color pixel = bmp.GetPixel(j, i);
                    dataGridView_Red[i,j].Value = pixel.R;
                    dataGridView_Green[i, j].Value = pixel.G;
                    dataGridView_Blue[i, j].Value = pixel.B;
                }
            }
        }

        private bool CheckIfBinary(Bitmap bmp) //готов
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

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Point cellCoords = new Point();
            cellCoords.X = e.ColumnIndex;
            cellCoords.Y = e.RowIndex;

            selectedCell = cellCoords;
            cellSelected = true;

            numericUpDown_RgbView_Red.Value = Convert.ToDecimal(dataGridView_Red[cellCoords.Y, cellCoords.X].Value);
            numericUpDown_RgbView_Green.Value = Convert.ToDecimal(dataGridView_Green[cellCoords.Y, cellCoords.X].Value);
            numericUpDown_RgbView_Blue.Value = Convert.ToDecimal(dataGridView_Blue[cellCoords.Y, cellCoords.X].Value);
        }

        private void tabControl_RGBViewer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cellSelected)
            {
                TabControl tabControl = sender as TabControl;
                TabPage selectedTabPage = tabControl.SelectedTab;

                DataGridView dataGrid = selectedTabPage.Controls.OfType<DataGridView>().First(); // get datagrid 
                dataGrid.ClearSelection();
                dataGrid[selectedCell.Y, selectedCell.X].Selected = true;
            }
        }

        private void NumericUpDown_valueChanged(object sender, EventArgs e)
        {
            if (cellSelected)
            {
                byte redValue = Convert.ToByte(numericUpDown_RgbView_Red.Value);
                byte greenValue = Convert.ToByte(numericUpDown_RgbView_Green.Value);
                byte blueValue = Convert.ToByte(numericUpDown_RgbView_Blue.Value);


                Color changedPixel = Color.FromArgb(redValue, greenValue, blueValue);

                Bitmap changedImage = new Bitmap(pictureBox_ChangedRgbViewPicture.Image);
                changedImage.SetPixel(selectedCell.X, selectedCell.Y, changedPixel);
                pictureBox_ChangedRgbViewPicture.Image = changedImage;

                dataGridView_Red[selectedCell.Y, selectedCell.X].Value = changedPixel.R;
                dataGridView_Green[selectedCell.Y, selectedCell.X].Value = changedPixel.G;
                dataGridView_Blue[selectedCell.Y, selectedCell.X].Value = changedPixel.B;
            }
        }
    }
}
