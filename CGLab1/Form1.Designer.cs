namespace CGLab1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.button_FindImage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_InsertedImage = new System.Windows.Forms.Panel();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.dataGridView_Red = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_RedMatrix = new System.Windows.Forms.TabPage();
            this.tabPage_GreenMatrix = new System.Windows.Forms.TabPage();
            this.dataGridView_Green = new System.Windows.Forms.DataGridView();
            this.tabPage_BlueMatrix = new System.Windows.Forms.TabPage();
            this.dataGridView_Blue = new System.Windows.Forms.DataGridView();
            this.button_SaveImage = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown_Red = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Green = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Blue = new System.Windows.Forms.NumericUpDown();
            this.panel_changed = new System.Windows.Forms.Panel();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Red)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage_RedMatrix.SuspendLayout();
            this.tabPage_GreenMatrix.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Green)).BeginInit();
            this.tabPage_BlueMatrix.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Blue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Blue)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "\"Bitmap Image (.bmp)|*.bmp|All files (*.*)|*.*\"";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "bmp";
            this.saveFileDialog.Filter = "\"Bitmap Image (.bmp)|*.bmp|All files (*.*)|*.*\"";
            // 
            // button_FindImage
            // 
            this.button_FindImage.Location = new System.Drawing.Point(6, 259);
            this.button_FindImage.Name = "button_FindImage";
            this.button_FindImage.Size = new System.Drawing.Size(105, 31);
            this.button_FindImage.TabIndex = 31;
            this.button_FindImage.Text = "Найти";
            this.button_FindImage.UseVisualStyleBackColor = true;
            this.button_FindImage.Click += new System.EventHandler(this.button_FindImage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Исходное изображение:";
            // 
            // panel_InsertedImage
            // 
            this.panel_InsertedImage.AllowDrop = true;
            this.panel_InsertedImage.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel_InsertedImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_InsertedImage.Location = new System.Drawing.Point(6, 54);
            this.panel_InsertedImage.Name = "panel_InsertedImage";
            this.panel_InsertedImage.Size = new System.Drawing.Size(199, 199);
            this.panel_InsertedImage.TabIndex = 29;
            this.panel_InsertedImage.Click += new System.EventHandler(this.button_FindImage_Click);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.panel_changed);
            this.groupBox.Controls.Add(this.numericUpDown_Blue);
            this.groupBox.Controls.Add(this.numericUpDown_Green);
            this.groupBox.Controls.Add(this.numericUpDown_Red);
            this.groupBox.Controls.Add(this.label4);
            this.groupBox.Controls.Add(this.label3);
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Controls.Add(this.button_SaveImage);
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.Controls.Add(this.panel_InsertedImage);
            this.groupBox.Controls.Add(this.button_FindImage);
            this.groupBox.Location = new System.Drawing.Point(12, 12);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(212, 661);
            this.groupBox.TabIndex = 39;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Превью:";
            // 
            // dataGridView_Red
            // 
            this.dataGridView_Red.AllowUserToAddRows = false;
            this.dataGridView_Red.AllowUserToDeleteRows = false;
            this.dataGridView_Red.AllowUserToResizeColumns = false;
            this.dataGridView_Red.AllowUserToResizeRows = false;
            this.dataGridView_Red.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_Red.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_Red.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_Red.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Red.ColumnHeadersVisible = false;
            this.dataGridView_Red.Cursor = System.Windows.Forms.Cursors.Arrow;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Red.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_Red.Location = new System.Drawing.Point(6, 6);
            this.dataGridView_Red.Name = "dataGridView_Red";
            this.dataGridView_Red.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView_Red.RowHeadersVisible = false;
            this.dataGridView_Red.RowHeadersWidth = 62;
            this.dataGridView_Red.RowTemplate.Height = 28;
            this.dataGridView_Red.Size = new System.Drawing.Size(638, 626);
            this.dataGridView_Red.TabIndex = 40;
            this.dataGridView_Red.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_RedMatrix);
            this.tabControl1.Controls.Add(this.tabPage_GreenMatrix);
            this.tabControl1.Controls.Add(this.tabPage_BlueMatrix);
            this.tabControl1.Location = new System.Drawing.Point(248, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(661, 672);
            this.tabControl1.TabIndex = 41;
            // 
            // tabPage_RedMatrix
            // 
            this.tabPage_RedMatrix.Controls.Add(this.dataGridView_Red);
            this.tabPage_RedMatrix.Location = new System.Drawing.Point(4, 29);
            this.tabPage_RedMatrix.Name = "tabPage_RedMatrix";
            this.tabPage_RedMatrix.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_RedMatrix.Size = new System.Drawing.Size(653, 639);
            this.tabPage_RedMatrix.TabIndex = 0;
            this.tabPage_RedMatrix.Text = "Red";
            this.tabPage_RedMatrix.UseVisualStyleBackColor = true;
            // 
            // tabPage_GreenMatrix
            // 
            this.tabPage_GreenMatrix.Controls.Add(this.dataGridView_Green);
            this.tabPage_GreenMatrix.Location = new System.Drawing.Point(4, 29);
            this.tabPage_GreenMatrix.Name = "tabPage_GreenMatrix";
            this.tabPage_GreenMatrix.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_GreenMatrix.Size = new System.Drawing.Size(653, 639);
            this.tabPage_GreenMatrix.TabIndex = 1;
            this.tabPage_GreenMatrix.Text = "Green";
            this.tabPage_GreenMatrix.UseVisualStyleBackColor = true;
            // 
            // dataGridView_Green
            // 
            this.dataGridView_Green.AllowUserToAddRows = false;
            this.dataGridView_Green.AllowUserToDeleteRows = false;
            this.dataGridView_Green.AllowUserToResizeColumns = false;
            this.dataGridView_Green.AllowUserToResizeRows = false;
            this.dataGridView_Green.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_Green.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_Green.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_Green.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Green.ColumnHeadersVisible = false;
            this.dataGridView_Green.Cursor = System.Windows.Forms.Cursors.Arrow;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Green.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_Green.Location = new System.Drawing.Point(7, 6);
            this.dataGridView_Green.Name = "dataGridView_Green";
            this.dataGridView_Green.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView_Green.RowHeadersVisible = false;
            this.dataGridView_Green.RowHeadersWidth = 62;
            this.dataGridView_Green.RowTemplate.Height = 28;
            this.dataGridView_Green.Size = new System.Drawing.Size(638, 626);
            this.dataGridView_Green.TabIndex = 41;
            this.dataGridView_Green.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // tabPage_BlueMatrix
            // 
            this.tabPage_BlueMatrix.Controls.Add(this.dataGridView_Blue);
            this.tabPage_BlueMatrix.Location = new System.Drawing.Point(4, 29);
            this.tabPage_BlueMatrix.Name = "tabPage_BlueMatrix";
            this.tabPage_BlueMatrix.Size = new System.Drawing.Size(653, 639);
            this.tabPage_BlueMatrix.TabIndex = 2;
            this.tabPage_BlueMatrix.Text = "Blue";
            this.tabPage_BlueMatrix.UseVisualStyleBackColor = true;
            // 
            // dataGridView_Blue
            // 
            this.dataGridView_Blue.AllowUserToAddRows = false;
            this.dataGridView_Blue.AllowUserToDeleteRows = false;
            this.dataGridView_Blue.AllowUserToResizeColumns = false;
            this.dataGridView_Blue.AllowUserToResizeRows = false;
            this.dataGridView_Blue.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_Blue.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_Blue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_Blue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Blue.ColumnHeadersVisible = false;
            this.dataGridView_Blue.Cursor = System.Windows.Forms.Cursors.Arrow;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Blue.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_Blue.Location = new System.Drawing.Point(7, 6);
            this.dataGridView_Blue.Name = "dataGridView_Blue";
            this.dataGridView_Blue.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView_Blue.RowHeadersVisible = false;
            this.dataGridView_Blue.RowHeadersWidth = 62;
            this.dataGridView_Blue.RowTemplate.Height = 28;
            this.dataGridView_Blue.Size = new System.Drawing.Size(638, 626);
            this.dataGridView_Blue.TabIndex = 41;
            this.dataGridView_Blue.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // button_SaveImage
            // 
            this.button_SaveImage.Location = new System.Drawing.Point(6, 296);
            this.button_SaveImage.Name = "button_SaveImage";
            this.button_SaveImage.Size = new System.Drawing.Size(105, 31);
            this.button_SaveImage.TabIndex = 32;
            this.button_SaveImage.Text = "Сохранить";
            this.button_SaveImage.UseVisualStyleBackColor = true;
            this.button_SaveImage.Click += new System.EventHandler(this.button_SaveImage_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 565);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "Красный:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 597);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 34;
            this.label3.Text = "Зеленый:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 631);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 35;
            this.label4.Text = "Синий:";
            // 
            // numericUpDown_Red
            // 
            this.numericUpDown_Red.Location = new System.Drawing.Point(91, 565);
            this.numericUpDown_Red.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown_Red.Name = "numericUpDown_Red";
            this.numericUpDown_Red.Size = new System.Drawing.Size(114, 26);
            this.numericUpDown_Red.TabIndex = 36;
            this.numericUpDown_Red.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // numericUpDown_Green
            // 
            this.numericUpDown_Green.Location = new System.Drawing.Point(91, 597);
            this.numericUpDown_Green.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown_Green.Name = "numericUpDown_Green";
            this.numericUpDown_Green.Size = new System.Drawing.Size(114, 26);
            this.numericUpDown_Green.TabIndex = 37;
            this.numericUpDown_Green.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // numericUpDown_Blue
            // 
            this.numericUpDown_Blue.Location = new System.Drawing.Point(91, 629);
            this.numericUpDown_Blue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown_Blue.Name = "numericUpDown_Blue";
            this.numericUpDown_Blue.Size = new System.Drawing.Size(114, 26);
            this.numericUpDown_Blue.TabIndex = 38;
            this.numericUpDown_Blue.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // panel_changed
            // 
            this.panel_changed.AllowDrop = true;
            this.panel_changed.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel_changed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_changed.Location = new System.Drawing.Point(6, 343);
            this.panel_changed.Name = "panel_changed";
            this.panel_changed.Size = new System.Drawing.Size(199, 199);
            this.panel_changed.TabIndex = 30;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(920, 693);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox);
            this.Name = "Form1";
            this.Text = "Обработка изображений Л.р. 1, Барковец Р. 10702221";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Red)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage_RedMatrix.ResumeLayout(false);
            this.tabPage_GreenMatrix.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Green)).EndInit();
            this.tabPage_BlueMatrix.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Blue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Blue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button button_FindImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_InsertedImage;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.DataGridView dataGridView_Red;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_RedMatrix;
        private System.Windows.Forms.TabPage tabPage_GreenMatrix;
        private System.Windows.Forms.TabPage tabPage_BlueMatrix;
        private System.Windows.Forms.DataGridView dataGridView_Green;
        private System.Windows.Forms.DataGridView dataGridView_Blue;
        private System.Windows.Forms.Button button_SaveImage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown_Blue;
        private System.Windows.Forms.NumericUpDown numericUpDown_Green;
        private System.Windows.Forms.NumericUpDown numericUpDown_Red;
        private System.Windows.Forms.Panel panel_changed;
    }
}

