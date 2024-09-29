using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CGLab1.AddintionalForms
{
	public partial class MatrixPresenterForm : Form
	{
		public MatrixPresenterForm(double[,] data)
		{
			InitializeComponent();
			LoadData(data);
		}		
		public MatrixPresenterForm(int[,] data, byte[] uniqueValues)
		{
			InitializeComponent();
			LoadData(data, uniqueValues);
		}		
		public MatrixPresenterForm(byte[,] data)
		{
			InitializeComponent();
			LoadData(data);
		}

		//as its for coocurances matrix it always will square
		private void LoadData(int [,] data, byte[] uniqueValues)
		{
			// Получаем размеры массива
			int rows = data.GetLength(0);
			int columns = data.GetLength(1);

			// Устанавливаем количество строк и столбцов в DataGridView
			dataGridView.RowCount = rows + 1;
			dataGridView.ColumnCount = columns + 1;


			for(int i = 0 ; i < uniqueValues.Length; i++)
			{
					dataGridView.Rows[0].Cells[i+1].Value = uniqueValues[i];
					dataGridView.Rows[i+1].Cells[0].Value = uniqueValues[i];
			}

			// Заполняем DataGridView данными из массива
			for (int i = 1; i < dataGridView.RowCount; i++)
			{
				for (int j = 1; j < dataGridView.ColumnCount; j++)
				{
					dataGridView.Rows[i].Cells[j].Value = data[i-1, j-1];
				}
			}
		}
		private void LoadData(byte [,] data)
		{
			// Получаем размеры массива
			int rows = data.GetLength(0);
			int columns = data.GetLength(1);

			// Устанавливаем количество строк и столбцов в DataGridView
			dataGridView.RowCount = rows;
			dataGridView.ColumnCount = columns;

			// Заполняем DataGridView данными из массива
			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < columns; j++)
				{
					dataGridView.Rows[i].Cells[j].Value = data[i, j];
				}
			}
		}
		private void LoadData(double [,] data)
		{
			// Получаем размеры массива
			int rows = data.GetLength(0);
			int columns = data.GetLength(1);

			// Устанавливаем количество строк и столбцов в DataGridView
			dataGridView.RowCount = rows;
			dataGridView.ColumnCount = columns;

			// Заполняем DataGridView данными из массива
			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < columns; j++)
				{
					dataGridView.Rows[i].Cells[j].Value = data[i, j];
				}
			}
		}
	}
}
