using CGLab1.AddintionalForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;


namespace CGLab1
{
	public partial class MainForm
	{
		//need for fast open of sm image
		List<string> imagesPathes = new List<string>();

		Dictionary<string, byte[,]> imagesBrightnessMatrixes = new Dictionary<string, byte[,]>();
		Dictionary<string, int[,]> imagesOccuranceMatrixes = new Dictionary<string, int[,]>();
		//needs for coocurances matrix
		Dictionary<string, byte[]> sortedUniqueBrightnessValues = new Dictionary<string, byte[]>();
		Dictionary<string, double[,]> imagesNormalizedMatrixes = new Dictionary<string, double[,]>();


		private void OnOpenTextureImageButtonClick(object sender, EventArgs e)
		{
			if (MultiSelectableOpenFileDialog.ShowDialog() == DialogResult.OK)
			{
				texturingImagesPropertiesDataGridView.Rows.Clear();
				texturingImagesPropertiesDataGridView.Refresh();

				//clear all collections related to previous images
				imagesBrightnessMatrixes.Clear();
				imagesOccuranceMatrixes.Clear();
				imagesNormalizedMatrixes.Clear();

				imagesPathes.Clear();
				texturingImageCollectionListView.Items.Clear();
				imageList.Images.Clear();

				//add all filename to path collection
				imagesPathes.AddRange(MultiSelectableOpenFileDialog.FileNames);

				//create image list of all open images
				for (int i = 0; i < MultiSelectableOpenFileDialog.FileNames.Length; i++)
				{
					var path = MultiSelectableOpenFileDialog.FileNames[i];

					imageList.Images.Add(Image.FromFile(path)); // add image icon
				}

				//set collection of accessible image to appropriate list
				texturingImageCollectionListView.LargeImageList = imageList;

				//set collection of listView items and set suitable icon for every
				for (int i = 0; i < MultiSelectableOpenFileDialog.FileNames.Length; i++)
				{
					var path = MultiSelectableOpenFileDialog.FileNames[i];

					ListViewItem lvi = new ListViewItem();
					lvi.Text = path.Remove(0, path.LastIndexOf('\\') + 1);
					lvi.ImageIndex = i;

					texturingImageCollectionListView.Items.Add(lvi); // add image to listview

				}

				FillTable();
			}
		}

		private void FillTable()
		{
			FillMatrixes();
			CreateDataGridRows();
		}

		private void CreateDataGridRows()
		{
			foreach (var path in imagesPathes)
			{
				texturingImagesPropertiesDataGridView.Rows.Add(
					//path.Remove(0,path.LastIndexOf("\\")+1),
					path,
					CreateButton(path),
					CreateButton(path),
					CreateButton(path),
					CalculateEnergy(imagesNormalizedMatrixes[path]),
					CalculateEntropy(imagesNormalizedMatrixes[path]),
					CalculateCorrelation(imagesNormalizedMatrixes[path])
					);
			}
		}

		private void FillMatrixes()
		{
			foreach (var path in imagesPathes)
			{
				CreateBrightnessMatrix(path);
				CreateCoocurancesMatrix(path);
				CreateNormalizedMatrix(path);
			}
		}

		private byte[,] CreateBrightnessMatrix(string imagePath)
		{
			if (imagesBrightnessMatrixes.ContainsKey(imagePath))
			{
				return imagesBrightnessMatrixes[imagePath];
			}


			using (Bitmap bitmap = new Bitmap(imagePath))
			{
				int width = bitmap.Width;
				int height = bitmap.Height;
				byte[,] brightnessMatrix = new byte[height, width];

				for (int y = 0; y < height; y++)
				{
					for (int x = 0; x < width; x++)
					{
						Color pixelColor = bitmap.GetPixel(x, y);
						byte brightness = (byte)(0.299 * pixelColor.R + 0.587 * pixelColor.G + 0.114 * pixelColor.B);
						brightnessMatrix[y, x] = brightness;
					}
				}

				imagesBrightnessMatrixes[imagePath] = brightnessMatrix;

				sortedUniqueBrightnessValues[imagePath] = GetUniqueValuesFromMatrix(brightnessMatrix);

				return brightnessMatrix;
			}
		}

		private byte[] GetUniqueValuesFromMatrix(byte[,] matrix)
		{
			return matrix.Cast<byte>().Distinct().OrderBy(x => x).ToArray();
		}

		private int[,] CreateCoocurancesMatrix(string path)
		{
			if (imagesOccuranceMatrixes.ContainsKey(path))
			{
				return imagesOccuranceMatrixes[path];
			}

			if (!imagesBrightnessMatrixes.ContainsKey(path))
			{
				return null;
			}

			(int wOffset, int hOffset) = (2, 2);

			var brightnessMatrix = imagesBrightnessMatrixes[path];
			var uniqueValues = sortedUniqueBrightnessValues[path];

			int height = brightnessMatrix.GetLength(0);
			int width = brightnessMatrix.GetLength(1);

			int[,] cooccurrenceMatrix = new int[uniqueValues.Length, uniqueValues.Length];

			for (int y = 0; y < height; y++)
			{
				for (int x = 0; x < width; x++)
				{
					byte currentBrightness = brightnessMatrix[y, x];

					int neighborX = x + wOffset;
					int neighborY = y + hOffset;

					// if pixel is still on image
					if (neighborX >= 0 && neighborX < width && neighborY >= 0 && neighborY < height)
					{
						var originalIndex = FindIndexByValue(uniqueValues, currentBrightness);
						var offsetIndex = FindIndexByValue(uniqueValues, brightnessMatrix[neighborY, neighborX]);
						cooccurrenceMatrix[originalIndex, offsetIndex]++;
					}
				}
			}

			imagesOccuranceMatrixes[path] = cooccurrenceMatrix;
			return cooccurrenceMatrix;
		}

		private double[,] CreateNormalizedMatrix(string path)
		{
			if (imagesNormalizedMatrixes.ContainsKey(path))
			{
				return imagesNormalizedMatrixes[path];
			}

			var coocuranceMatrix = imagesOccuranceMatrixes[path];

			int height = coocuranceMatrix.GetLength(0);
			int width = coocuranceMatrix.GetLength(1);
			double[,] normalizedMatrix = new double[height, width];

			// Вычисляем сумму всех элементов матрицы совместной встречаемости
			double totalSum = 0;
			for (int i = 0; i < height; i++)
			{
				for (int j = 0; j < width; j++)
				{
					totalSum += coocuranceMatrix[i, j];
				}
			}

			// Нормализуем матрицу
			for (int i = 0; i < height; i++)
			{
				for (int j = 0; j < width; j++)
				{
					normalizedMatrix[i, j] = totalSum > 0 ? Math.Round((coocuranceMatrix[i, j] / totalSum),3) : 0;
				}
			}

			imagesNormalizedMatrixes[path] = normalizedMatrix;

			return normalizedMatrix;
		}

		private static int FindIndexByValue<T>(T[] array, T value)
		{
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i].Equals(value))
				{
					return i;
				}
			}
			return -1;
		}

		private Button CreateButton(object tag)
		{
			Button button = new Button
			{
				Text = "Show",
				Dock = DockStyle.Fill,
				Tag = tag
			};
			return button;
		}

		private double CalculateEnergy(double[,] normalizedMatrix)
		{
			double energy = 0.0;
			int rows = normalizedMatrix.GetLength(0);
			int cols = normalizedMatrix.GetLength(1);

			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < cols; j++)
				{
					energy += Math.Pow(normalizedMatrix[i, j], 2);
				}
			}

			return energy;
		}

		private double CalculateEntropy(double[,] normalizedMatrix)
		{
			double entropy = 0.0;
			int rows = normalizedMatrix.GetLength(0);
			int cols = normalizedMatrix.GetLength(1);

			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < cols; j++)
				{
					double value = normalizedMatrix[i, j];
					if (value > 0)
					{
						entropy += value * Math.Log(value, 2);
					}
				}
			}

			return -entropy; // Возвращаем отрицательное значение, согласно формуле		
		}

		private double CalculateCorrelation(double[,] normalizedMatrix)
		{
			int rows = normalizedMatrix.GetLength(0);
			int cols = normalizedMatrix.GetLength(1);

			// Вычисляем средние значения
			double mu_x = 0.0, mu_y = 0.0;
			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < cols; j++)
				{
					mu_x += i * normalizedMatrix[i, j];
					mu_y += j * normalizedMatrix[i, j];
				}
			}

			// Вычисляем стандартные отклонения
			double sigma_x = 0.0, sigma_y = 0.0;
			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < cols; j++)
				{
					sigma_x += Math.Pow(i - mu_x, 2) * normalizedMatrix[i, j];
					sigma_y += Math.Pow(j - mu_y, 2) * normalizedMatrix[i, j];
				}
			}
			sigma_x = Math.Sqrt(sigma_x);
			sigma_y = Math.Sqrt(sigma_y);

			// Вычисляем корреляцию
			double correlation = 0.0;
			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < cols; j++)
				{
					correlation += (i - mu_x) * (j - mu_y) * normalizedMatrix[i, j];
				}
			}

			correlation /= (sigma_x * sigma_y);
			return correlation;
		}

		private void texturingImagesPropertiesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0) // row is not header
			{
				int columnIndex = e.ColumnIndex; // Получаем индекс столбца
				
				string path = texturingImagesPropertiesDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();

				if (columnIndex == texturingImagesPropertiesDataGridView.Columns["showBrightnessMatrixColumn"].Index)
				{
					var values = imagesBrightnessMatrixes[path];
					MatrixPresenterForm f = new MatrixPresenterForm(values);
					f.Show();
				}
				else if (columnIndex == texturingImagesPropertiesDataGridView.Columns["showOccuranceMatrixColumn"].Index)
				{
					var values = imagesOccuranceMatrixes[path];
					MatrixPresenterForm f = new MatrixPresenterForm(values, sortedUniqueBrightnessValues[path]);
					f.Show();
				}
				else if (columnIndex == texturingImagesPropertiesDataGridView.Columns["showNormalizedMatrixColumn"].Index)
				{
					var values = imagesNormalizedMatrixes[path];
					MatrixPresenterForm f = new MatrixPresenterForm(values);
					f.Show();
				}
			}
		}

	}
}
