namespace CGLab1
{
    partial class MainForm
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle45 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle46 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle47 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle48 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle49 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle50 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle51 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle52 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle53 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle54 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle55 = new System.Windows.Forms.DataGridViewCellStyle();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.tabPage_ColorSpacesConverter = new System.Windows.Forms.TabPage();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.pictureBox_YUVPicture = new System.Windows.Forms.PictureBox();
			this.pictureBox_OriginalRGBPicture = new System.Windows.Forms.PictureBox();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.button_YUVSave = new System.Windows.Forms.Button();
			this.label10 = new System.Windows.Forms.Label();
			this.button_YUVFind = new System.Windows.Forms.Button();
			this.tabControl_YUVMatrix = new System.Windows.Forms.TabControl();
			this.tabPage_Y = new System.Windows.Forms.TabPage();
			this.dataGridView_YUV_Y = new System.Windows.Forms.DataGridView();
			this.tabPage_U = new System.Windows.Forms.TabPage();
			this.dataGridView_YUV_U = new System.Windows.Forms.DataGridView();
			this.tabPage_V = new System.Windows.Forms.TabPage();
			this.dataGridView_YUV_V = new System.Windows.Forms.DataGridView();
			this.tabPage_Shading = new System.Windows.Forms.TabPage();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.button_MakeShading = new System.Windows.Forms.Button();
			this.comboBox_BinarizationMethods = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.tabControl_Shading = new System.Windows.Forms.TabControl();
			this.tabPage_WaveShading = new System.Windows.Forms.TabPage();
			this.dataGridView_WaveShading = new System.Windows.Forms.DataGridView();
			this.tabPage_EuclidShading = new System.Windows.Forms.TabPage();
			this.dataGridView_EuclidShading = new System.Windows.Forms.DataGridView();
			this.tabPage_ChessShading = new System.Windows.Forms.TabPage();
			this.dataGridView_ChessShading = new System.Windows.Forms.DataGridView();
			this.tabPage_CityShading = new System.Windows.Forms.TabPage();
			this.dataGridView_CityShading = new System.Windows.Forms.DataGridView();
			this.tabPage_View = new System.Windows.Forms.TabPage();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.pictureBox_ChangedRgbViewPicture = new System.Windows.Forms.PictureBox();
			this.pictureBox_OriginalRgbViewPicture = new System.Windows.Forms.PictureBox();
			this.numericUpDown_RgbView_Blue = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown_RgbView_Green = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown_RgbView_Red = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.button_RgbViewSavePicture = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.button_RgbViewFindPicture = new System.Windows.Forms.Button();
			this.tabControl_RGBViewer = new System.Windows.Forms.TabControl();
			this.tabPage_RedMatrix = new System.Windows.Forms.TabPage();
			this.dataGridView_Red = new System.Windows.Forms.DataGridView();
			this.tabPage_GreenMatrix = new System.Windows.Forms.TabPage();
			this.dataGridView_Green = new System.Windows.Forms.DataGridView();
			this.tabPage_BlueMatrix = new System.Windows.Forms.TabPage();
			this.dataGridView_Blue = new System.Windows.Forms.DataGridView();
			this.tabControl_Main = new System.Windows.Forms.TabControl();
			this.tabPage_Texturing = new System.Windows.Forms.TabPage();
			this.texturingImagesPropertiesDataGridView = new System.Windows.Forms.DataGridView();
			this.OpenTextureImageButton = new System.Windows.Forms.Button();
			this.texturingImageCollectionListView = new System.Windows.Forms.ListView();
			this.tabPage_Filtration = new System.Windows.Forms.TabPage();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.label12 = new System.Windows.Forms.Label();
			this.numericUpDown_FilterSize = new System.Windows.Forms.NumericUpDown();
			this.pictureBox_FilterChangedImage = new System.Windows.Forms.PictureBox();
			this.pictureBox_FilterOriginalImage = new System.Windows.Forms.PictureBox();
			this.button_FiltrationSaveImage = new System.Windows.Forms.Button();
			this.label11 = new System.Windows.Forms.Label();
			this.button_FiltrationFindImage = new System.Windows.Forms.Button();
			this.button_UseFilter = new System.Windows.Forms.Button();
			this.tabControl_Filtration = new System.Windows.Forms.TabControl();
			this.tabPage_MedianFilter = new System.Windows.Forms.TabPage();
			this.dataGridView_MedianFilterValues = new System.Windows.Forms.DataGridView();
			this.imageList = new System.Windows.Forms.ImageList(this.components);
			this.MultiSelectableOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.imageNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.showBrightnessMatrixColumn = new System.Windows.Forms.DataGridViewButtonColumn();
			this.showOccuranceMatrixColumn = new System.Windows.Forms.DataGridViewButtonColumn();
			this.showNormalizedMatrixColumn = new System.Windows.Forms.DataGridViewButtonColumn();
			this.energyValueColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.entropyValueColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.correlationValueColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.contrastValueColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.homogenValueColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.distanceValueColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tabPage_ColorSpacesConverter.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_YUVPicture)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_OriginalRGBPicture)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
			this.tabControl_YUVMatrix.SuspendLayout();
			this.tabPage_Y.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_YUV_Y)).BeginInit();
			this.tabPage_U.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_YUV_U)).BeginInit();
			this.tabPage_V.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_YUV_V)).BeginInit();
			this.tabPage_Shading.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.tabControl_Shading.SuspendLayout();
			this.tabPage_WaveShading.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_WaveShading)).BeginInit();
			this.tabPage_EuclidShading.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_EuclidShading)).BeginInit();
			this.tabPage_ChessShading.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_ChessShading)).BeginInit();
			this.tabPage_CityShading.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_CityShading)).BeginInit();
			this.tabPage_View.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_ChangedRgbViewPicture)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_OriginalRgbViewPicture)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_RgbView_Blue)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_RgbView_Green)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_RgbView_Red)).BeginInit();
			this.tabControl_RGBViewer.SuspendLayout();
			this.tabPage_RedMatrix.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_Red)).BeginInit();
			this.tabPage_GreenMatrix.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_Green)).BeginInit();
			this.tabPage_BlueMatrix.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_Blue)).BeginInit();
			this.tabControl_Main.SuspendLayout();
			this.tabPage_Texturing.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.texturingImagesPropertiesDataGridView)).BeginInit();
			this.tabPage_Filtration.SuspendLayout();
			this.groupBox4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_FilterSize)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_FilterChangedImage)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_FilterOriginalImage)).BeginInit();
			this.tabControl_Filtration.SuspendLayout();
			this.tabPage_MedianFilter.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_MedianFilterValues)).BeginInit();
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
			// tabPage_ColorSpacesConverter
			// 
			this.tabPage_ColorSpacesConverter.Controls.Add(this.groupBox2);
			this.tabPage_ColorSpacesConverter.Controls.Add(this.tabControl_YUVMatrix);
			this.tabPage_ColorSpacesConverter.Location = new System.Drawing.Point(4, 29);
			this.tabPage_ColorSpacesConverter.Name = "tabPage_ColorSpacesConverter";
			this.tabPage_ColorSpacesConverter.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage_ColorSpacesConverter.Size = new System.Drawing.Size(923, 689);
			this.tabPage_ColorSpacesConverter.TabIndex = 3;
			this.tabPage_ColorSpacesConverter.Text = "Преобразование";
			this.tabPage_ColorSpacesConverter.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.pictureBox_YUVPicture);
			this.groupBox2.Controls.Add(this.pictureBox_OriginalRGBPicture);
			this.groupBox2.Controls.Add(this.numericUpDown1);
			this.groupBox2.Controls.Add(this.numericUpDown2);
			this.groupBox2.Controls.Add(this.numericUpDown3);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Controls.Add(this.button_YUVSave);
			this.groupBox2.Controls.Add(this.label10);
			this.groupBox2.Controls.Add(this.button_YUVFind);
			this.groupBox2.Location = new System.Drawing.Point(6, 6);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(230, 662);
			this.groupBox2.TabIndex = 39;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Превью:";
			// 
			// pictureBox_YUVPicture
			// 
			this.pictureBox_YUVPicture.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.pictureBox_YUVPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.pictureBox_YUVPicture.Location = new System.Drawing.Point(6, 345);
			this.pictureBox_YUVPicture.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.pictureBox_YUVPicture.Name = "pictureBox_YUVPicture";
			this.pictureBox_YUVPicture.Size = new System.Drawing.Size(215, 215);
			this.pictureBox_YUVPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox_YUVPicture.TabIndex = 40;
			this.pictureBox_YUVPicture.TabStop = false;
			this.pictureBox_YUVPicture.Click += new System.EventHandler(this.pictureBox_YUVPicture_Click);
			// 
			// pictureBox_OriginalRGBPicture
			// 
			this.pictureBox_OriginalRGBPicture.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.pictureBox_OriginalRGBPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.pictureBox_OriginalRGBPicture.Location = new System.Drawing.Point(6, 46);
			this.pictureBox_OriginalRGBPicture.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.pictureBox_OriginalRGBPicture.Name = "pictureBox_OriginalRGBPicture";
			this.pictureBox_OriginalRGBPicture.Size = new System.Drawing.Size(215, 215);
			this.pictureBox_OriginalRGBPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox_OriginalRGBPicture.TabIndex = 39;
			this.pictureBox_OriginalRGBPicture.TabStop = false;
			this.pictureBox_OriginalRGBPicture.Click += new System.EventHandler(this.pictureBox_OriginalRGBPicture_Click);
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(92, 629);
			this.numericUpDown1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(114, 26);
			this.numericUpDown1.TabIndex = 38;
			this.numericUpDown1.Visible = false;
			// 
			// numericUpDown2
			// 
			this.numericUpDown2.Location = new System.Drawing.Point(92, 597);
			this.numericUpDown2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.numericUpDown2.Name = "numericUpDown2";
			this.numericUpDown2.Size = new System.Drawing.Size(114, 26);
			this.numericUpDown2.TabIndex = 37;
			this.numericUpDown2.Visible = false;
			// 
			// numericUpDown3
			// 
			this.numericUpDown3.Location = new System.Drawing.Point(92, 565);
			this.numericUpDown3.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.numericUpDown3.Name = "numericUpDown3";
			this.numericUpDown3.Size = new System.Drawing.Size(114, 26);
			this.numericUpDown3.TabIndex = 36;
			this.numericUpDown3.Visible = false;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(6, 631);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(60, 20);
			this.label6.TabIndex = 35;
			this.label6.Text = "Синий:";
			this.label6.Visible = false;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(4, 597);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(81, 20);
			this.label7.TabIndex = 34;
			this.label7.Text = "Зеленый:";
			this.label7.Visible = false;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(6, 565);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(78, 20);
			this.label9.TabIndex = 33;
			this.label9.Text = "Красный:";
			this.label9.Visible = false;
			// 
			// button_YUVSave
			// 
			this.button_YUVSave.Location = new System.Drawing.Point(6, 306);
			this.button_YUVSave.Name = "button_YUVSave";
			this.button_YUVSave.Size = new System.Drawing.Size(105, 31);
			this.button_YUVSave.TabIndex = 32;
			this.button_YUVSave.Text = "Сохранить";
			this.button_YUVSave.UseVisualStyleBackColor = true;
			this.button_YUVSave.Click += new System.EventHandler(this.button_YUVSave_Click);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(6, 22);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(190, 20);
			this.label10.TabIndex = 30;
			this.label10.Text = "Исходное изображение:";
			// 
			// button_YUVFind
			// 
			this.button_YUVFind.Location = new System.Drawing.Point(6, 269);
			this.button_YUVFind.Name = "button_YUVFind";
			this.button_YUVFind.Size = new System.Drawing.Size(105, 31);
			this.button_YUVFind.TabIndex = 31;
			this.button_YUVFind.Text = "Найти";
			this.button_YUVFind.UseVisualStyleBackColor = true;
			this.button_YUVFind.Click += new System.EventHandler(this.button_YUVFind_Click);
			// 
			// tabControl_YUVMatrix
			// 
			this.tabControl_YUVMatrix.Controls.Add(this.tabPage_Y);
			this.tabControl_YUVMatrix.Controls.Add(this.tabPage_U);
			this.tabControl_YUVMatrix.Controls.Add(this.tabPage_V);
			this.tabControl_YUVMatrix.Location = new System.Drawing.Point(242, 6);
			this.tabControl_YUVMatrix.Name = "tabControl_YUVMatrix";
			this.tabControl_YUVMatrix.SelectedIndex = 0;
			this.tabControl_YUVMatrix.Size = new System.Drawing.Size(662, 672);
			this.tabControl_YUVMatrix.TabIndex = 41;
			// 
			// tabPage_Y
			// 
			this.tabPage_Y.Controls.Add(this.dataGridView_YUV_Y);
			this.tabPage_Y.Location = new System.Drawing.Point(4, 29);
			this.tabPage_Y.Name = "tabPage_Y";
			this.tabPage_Y.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage_Y.Size = new System.Drawing.Size(654, 639);
			this.tabPage_Y.TabIndex = 0;
			this.tabPage_Y.Text = "Яркость Y";
			this.tabPage_Y.UseVisualStyleBackColor = true;
			// 
			// dataGridView_YUV_Y
			// 
			this.dataGridView_YUV_Y.AllowUserToAddRows = false;
			this.dataGridView_YUV_Y.AllowUserToDeleteRows = false;
			this.dataGridView_YUV_Y.AllowUserToResizeColumns = false;
			this.dataGridView_YUV_Y.AllowUserToResizeRows = false;
			this.dataGridView_YUV_Y.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataGridView_YUV_Y.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dataGridView_YUV_Y.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGridView_YUV_Y.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_YUV_Y.ColumnHeadersVisible = false;
			this.dataGridView_YUV_Y.Cursor = System.Windows.Forms.Cursors.Arrow;
			dataGridViewCellStyle45.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle45.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle45.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle45.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle45.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle45.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle45.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView_YUV_Y.DefaultCellStyle = dataGridViewCellStyle45;
			this.dataGridView_YUV_Y.Location = new System.Drawing.Point(6, 6);
			this.dataGridView_YUV_Y.Name = "dataGridView_YUV_Y";
			this.dataGridView_YUV_Y.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.dataGridView_YUV_Y.RowHeadersVisible = false;
			this.dataGridView_YUV_Y.RowHeadersWidth = 62;
			this.dataGridView_YUV_Y.RowTemplate.Height = 28;
			this.dataGridView_YUV_Y.Size = new System.Drawing.Size(638, 626);
			this.dataGridView_YUV_Y.TabIndex = 40;
			// 
			// tabPage_U
			// 
			this.tabPage_U.Controls.Add(this.dataGridView_YUV_U);
			this.tabPage_U.Location = new System.Drawing.Point(4, 29);
			this.tabPage_U.Name = "tabPage_U";
			this.tabPage_U.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage_U.Size = new System.Drawing.Size(654, 639);
			this.tabPage_U.TabIndex = 1;
			this.tabPage_U.Text = "Разность с синим U";
			this.tabPage_U.UseVisualStyleBackColor = true;
			// 
			// dataGridView_YUV_U
			// 
			this.dataGridView_YUV_U.AllowUserToAddRows = false;
			this.dataGridView_YUV_U.AllowUserToDeleteRows = false;
			this.dataGridView_YUV_U.AllowUserToResizeColumns = false;
			this.dataGridView_YUV_U.AllowUserToResizeRows = false;
			this.dataGridView_YUV_U.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataGridView_YUV_U.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dataGridView_YUV_U.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGridView_YUV_U.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_YUV_U.ColumnHeadersVisible = false;
			this.dataGridView_YUV_U.Cursor = System.Windows.Forms.Cursors.Arrow;
			dataGridViewCellStyle46.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle46.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle46.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle46.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle46.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle46.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle46.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView_YUV_U.DefaultCellStyle = dataGridViewCellStyle46;
			this.dataGridView_YUV_U.Location = new System.Drawing.Point(8, 6);
			this.dataGridView_YUV_U.Name = "dataGridView_YUV_U";
			this.dataGridView_YUV_U.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.dataGridView_YUV_U.RowHeadersVisible = false;
			this.dataGridView_YUV_U.RowHeadersWidth = 62;
			this.dataGridView_YUV_U.RowTemplate.Height = 28;
			this.dataGridView_YUV_U.Size = new System.Drawing.Size(638, 626);
			this.dataGridView_YUV_U.TabIndex = 41;
			// 
			// tabPage_V
			// 
			this.tabPage_V.Controls.Add(this.dataGridView_YUV_V);
			this.tabPage_V.Location = new System.Drawing.Point(4, 29);
			this.tabPage_V.Name = "tabPage_V";
			this.tabPage_V.Size = new System.Drawing.Size(654, 639);
			this.tabPage_V.TabIndex = 2;
			this.tabPage_V.Text = "Разность с красным V";
			this.tabPage_V.UseVisualStyleBackColor = true;
			// 
			// dataGridView_YUV_V
			// 
			this.dataGridView_YUV_V.AllowUserToAddRows = false;
			this.dataGridView_YUV_V.AllowUserToDeleteRows = false;
			this.dataGridView_YUV_V.AllowUserToResizeColumns = false;
			this.dataGridView_YUV_V.AllowUserToResizeRows = false;
			this.dataGridView_YUV_V.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataGridView_YUV_V.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dataGridView_YUV_V.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGridView_YUV_V.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_YUV_V.ColumnHeadersVisible = false;
			this.dataGridView_YUV_V.Cursor = System.Windows.Forms.Cursors.Arrow;
			dataGridViewCellStyle47.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle47.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle47.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle47.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle47.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle47.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle47.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView_YUV_V.DefaultCellStyle = dataGridViewCellStyle47;
			this.dataGridView_YUV_V.Location = new System.Drawing.Point(8, 6);
			this.dataGridView_YUV_V.Name = "dataGridView_YUV_V";
			this.dataGridView_YUV_V.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.dataGridView_YUV_V.RowHeadersVisible = false;
			this.dataGridView_YUV_V.RowHeadersWidth = 62;
			this.dataGridView_YUV_V.RowTemplate.Height = 28;
			this.dataGridView_YUV_V.Size = new System.Drawing.Size(638, 626);
			this.dataGridView_YUV_V.TabIndex = 41;
			// 
			// tabPage_Shading
			// 
			this.tabPage_Shading.Controls.Add(this.groupBox1);
			this.tabPage_Shading.Controls.Add(this.tabControl_Shading);
			this.tabPage_Shading.Location = new System.Drawing.Point(4, 29);
			this.tabPage_Shading.Name = "tabPage_Shading";
			this.tabPage_Shading.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage_Shading.Size = new System.Drawing.Size(923, 689);
			this.tabPage_Shading.TabIndex = 1;
			this.tabPage_Shading.Text = "Растушевка";
			this.tabPage_Shading.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.pictureBox1);
			this.groupBox1.Controls.Add(this.pictureBox2);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.button2);
			this.groupBox1.Controls.Add(this.button_MakeShading);
			this.groupBox1.Controls.Add(this.comboBox_BinarizationMethods);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Location = new System.Drawing.Point(3, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(230, 662);
			this.groupBox1.TabIndex = 42;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Превью:";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.pictureBox1.Location = new System.Drawing.Point(6, 345);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(215, 215);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 45;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.pictureBox2.Location = new System.Drawing.Point(6, 46);
			this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(215, 215);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 44;
			this.pictureBox2.TabStop = false;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(6, 306);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(105, 31);
			this.button1.TabIndex = 43;
			this.button1.Text = "Сохранить";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(6, 22);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(190, 20);
			this.label8.TabIndex = 41;
			this.label8.Text = "Исходное изображение:";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(6, 269);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(105, 31);
			this.button2.TabIndex = 42;
			this.button2.Text = "Найти";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button_MakeShading
			// 
			this.button_MakeShading.Location = new System.Drawing.Point(6, 622);
			this.button_MakeShading.Name = "button_MakeShading";
			this.button_MakeShading.Size = new System.Drawing.Size(215, 34);
			this.button_MakeShading.TabIndex = 35;
			this.button_MakeShading.Text = "Растушевать";
			this.button_MakeShading.UseVisualStyleBackColor = true;
			// 
			// comboBox_BinarizationMethods
			// 
			this.comboBox_BinarizationMethods.Cursor = System.Windows.Forms.Cursors.Default;
			this.comboBox_BinarizationMethods.FormattingEnabled = true;
			this.comboBox_BinarizationMethods.Items.AddRange(new object[] {
            "Метод средних",
            "Метод 120",
            "Метод Мод",
            "Метод 40%"});
			this.comboBox_BinarizationMethods.Location = new System.Drawing.Point(6, 588);
			this.comboBox_BinarizationMethods.Name = "comboBox_BinarizationMethods";
			this.comboBox_BinarizationMethods.Size = new System.Drawing.Size(215, 28);
			this.comboBox_BinarizationMethods.TabIndex = 34;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 565);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(158, 20);
			this.label5.TabIndex = 33;
			this.label5.Text = "Метод растушевки:";
			// 
			// tabControl_Shading
			// 
			this.tabControl_Shading.Controls.Add(this.tabPage_WaveShading);
			this.tabControl_Shading.Controls.Add(this.tabPage_EuclidShading);
			this.tabControl_Shading.Controls.Add(this.tabPage_ChessShading);
			this.tabControl_Shading.Controls.Add(this.tabPage_CityShading);
			this.tabControl_Shading.Location = new System.Drawing.Point(239, 8);
			this.tabControl_Shading.Name = "tabControl_Shading";
			this.tabControl_Shading.SelectedIndex = 0;
			this.tabControl_Shading.Size = new System.Drawing.Size(671, 672);
			this.tabControl_Shading.TabIndex = 43;
			// 
			// tabPage_WaveShading
			// 
			this.tabPage_WaveShading.Controls.Add(this.dataGridView_WaveShading);
			this.tabPage_WaveShading.Location = new System.Drawing.Point(4, 29);
			this.tabPage_WaveShading.Name = "tabPage_WaveShading";
			this.tabPage_WaveShading.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage_WaveShading.Size = new System.Drawing.Size(663, 639);
			this.tabPage_WaveShading.TabIndex = 0;
			this.tabPage_WaveShading.Text = "n-Волновая";
			this.tabPage_WaveShading.UseVisualStyleBackColor = true;
			// 
			// dataGridView_WaveShading
			// 
			this.dataGridView_WaveShading.AllowUserToAddRows = false;
			this.dataGridView_WaveShading.AllowUserToDeleteRows = false;
			this.dataGridView_WaveShading.AllowUserToResizeColumns = false;
			this.dataGridView_WaveShading.AllowUserToResizeRows = false;
			this.dataGridView_WaveShading.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataGridView_WaveShading.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dataGridView_WaveShading.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGridView_WaveShading.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_WaveShading.ColumnHeadersVisible = false;
			this.dataGridView_WaveShading.Cursor = System.Windows.Forms.Cursors.Arrow;
			dataGridViewCellStyle48.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle48.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle48.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle48.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle48.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle48.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle48.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView_WaveShading.DefaultCellStyle = dataGridViewCellStyle48;
			this.dataGridView_WaveShading.Location = new System.Drawing.Point(6, 6);
			this.dataGridView_WaveShading.Name = "dataGridView_WaveShading";
			this.dataGridView_WaveShading.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.dataGridView_WaveShading.RowHeadersVisible = false;
			this.dataGridView_WaveShading.RowHeadersWidth = 62;
			this.dataGridView_WaveShading.RowTemplate.Height = 28;
			this.dataGridView_WaveShading.Size = new System.Drawing.Size(638, 626);
			this.dataGridView_WaveShading.TabIndex = 40;
			// 
			// tabPage_EuclidShading
			// 
			this.tabPage_EuclidShading.Controls.Add(this.dataGridView_EuclidShading);
			this.tabPage_EuclidShading.Location = new System.Drawing.Point(4, 29);
			this.tabPage_EuclidShading.Name = "tabPage_EuclidShading";
			this.tabPage_EuclidShading.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage_EuclidShading.Size = new System.Drawing.Size(663, 639);
			this.tabPage_EuclidShading.TabIndex = 1;
			this.tabPage_EuclidShading.Text = "Евклидово рст.";
			this.tabPage_EuclidShading.UseVisualStyleBackColor = true;
			// 
			// dataGridView_EuclidShading
			// 
			this.dataGridView_EuclidShading.AllowUserToAddRows = false;
			this.dataGridView_EuclidShading.AllowUserToDeleteRows = false;
			this.dataGridView_EuclidShading.AllowUserToResizeColumns = false;
			this.dataGridView_EuclidShading.AllowUserToResizeRows = false;
			this.dataGridView_EuclidShading.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dataGridView_EuclidShading.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataGridView_EuclidShading.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dataGridView_EuclidShading.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGridView_EuclidShading.ColumnHeadersHeight = 34;
			this.dataGridView_EuclidShading.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dataGridView_EuclidShading.ColumnHeadersVisible = false;
			this.dataGridView_EuclidShading.Cursor = System.Windows.Forms.Cursors.Arrow;
			dataGridViewCellStyle49.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle49.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle49.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle49.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle49.Format = "N2";
			dataGridViewCellStyle49.NullValue = null;
			dataGridViewCellStyle49.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle49.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle49.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView_EuclidShading.DefaultCellStyle = dataGridViewCellStyle49;
			this.dataGridView_EuclidShading.Location = new System.Drawing.Point(8, 6);
			this.dataGridView_EuclidShading.MultiSelect = false;
			this.dataGridView_EuclidShading.Name = "dataGridView_EuclidShading";
			this.dataGridView_EuclidShading.ReadOnly = true;
			this.dataGridView_EuclidShading.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.dataGridView_EuclidShading.RowHeadersVisible = false;
			this.dataGridView_EuclidShading.RowHeadersWidth = 62;
			this.dataGridView_EuclidShading.RowTemplate.Height = 28;
			this.dataGridView_EuclidShading.Size = new System.Drawing.Size(638, 626);
			this.dataGridView_EuclidShading.TabIndex = 41;
			// 
			// tabPage_ChessShading
			// 
			this.tabPage_ChessShading.Controls.Add(this.dataGridView_ChessShading);
			this.tabPage_ChessShading.Location = new System.Drawing.Point(4, 29);
			this.tabPage_ChessShading.Name = "tabPage_ChessShading";
			this.tabPage_ChessShading.Size = new System.Drawing.Size(663, 639);
			this.tabPage_ChessShading.TabIndex = 2;
			this.tabPage_ChessShading.Text = "Шахматное рст.";
			this.tabPage_ChessShading.UseVisualStyleBackColor = true;
			// 
			// dataGridView_ChessShading
			// 
			this.dataGridView_ChessShading.AllowUserToAddRows = false;
			this.dataGridView_ChessShading.AllowUserToDeleteRows = false;
			this.dataGridView_ChessShading.AllowUserToResizeColumns = false;
			this.dataGridView_ChessShading.AllowUserToResizeRows = false;
			this.dataGridView_ChessShading.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataGridView_ChessShading.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dataGridView_ChessShading.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGridView_ChessShading.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_ChessShading.ColumnHeadersVisible = false;
			this.dataGridView_ChessShading.Cursor = System.Windows.Forms.Cursors.Arrow;
			dataGridViewCellStyle50.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle50.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle50.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle50.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle50.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle50.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle50.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView_ChessShading.DefaultCellStyle = dataGridViewCellStyle50;
			this.dataGridView_ChessShading.Location = new System.Drawing.Point(8, 6);
			this.dataGridView_ChessShading.Name = "dataGridView_ChessShading";
			this.dataGridView_ChessShading.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.dataGridView_ChessShading.RowHeadersVisible = false;
			this.dataGridView_ChessShading.RowHeadersWidth = 62;
			this.dataGridView_ChessShading.RowTemplate.Height = 28;
			this.dataGridView_ChessShading.Size = new System.Drawing.Size(638, 626);
			this.dataGridView_ChessShading.TabIndex = 41;
			// 
			// tabPage_CityShading
			// 
			this.tabPage_CityShading.Controls.Add(this.dataGridView_CityShading);
			this.tabPage_CityShading.Location = new System.Drawing.Point(4, 29);
			this.tabPage_CityShading.Name = "tabPage_CityShading";
			this.tabPage_CityShading.Size = new System.Drawing.Size(663, 639);
			this.tabPage_CityShading.TabIndex = 3;
			this.tabPage_CityShading.Text = "Городское рст.";
			this.tabPage_CityShading.UseVisualStyleBackColor = true;
			// 
			// dataGridView_CityShading
			// 
			this.dataGridView_CityShading.AllowUserToAddRows = false;
			this.dataGridView_CityShading.AllowUserToDeleteRows = false;
			this.dataGridView_CityShading.AllowUserToResizeColumns = false;
			this.dataGridView_CityShading.AllowUserToResizeRows = false;
			this.dataGridView_CityShading.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataGridView_CityShading.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dataGridView_CityShading.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGridView_CityShading.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_CityShading.ColumnHeadersVisible = false;
			this.dataGridView_CityShading.Cursor = System.Windows.Forms.Cursors.Arrow;
			dataGridViewCellStyle51.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle51.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle51.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle51.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle51.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle51.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle51.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView_CityShading.DefaultCellStyle = dataGridViewCellStyle51;
			this.dataGridView_CityShading.Location = new System.Drawing.Point(8, 6);
			this.dataGridView_CityShading.Name = "dataGridView_CityShading";
			this.dataGridView_CityShading.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.dataGridView_CityShading.RowHeadersVisible = false;
			this.dataGridView_CityShading.RowHeadersWidth = 62;
			this.dataGridView_CityShading.RowTemplate.Height = 28;
			this.dataGridView_CityShading.Size = new System.Drawing.Size(638, 626);
			this.dataGridView_CityShading.TabIndex = 42;
			// 
			// tabPage_View
			// 
			this.tabPage_View.Controls.Add(this.groupBox3);
			this.tabPage_View.Controls.Add(this.tabControl_RGBViewer);
			this.tabPage_View.Location = new System.Drawing.Point(4, 29);
			this.tabPage_View.Name = "tabPage_View";
			this.tabPage_View.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage_View.Size = new System.Drawing.Size(923, 689);
			this.tabPage_View.TabIndex = 0;
			this.tabPage_View.Text = "Просмотр";
			this.tabPage_View.UseVisualStyleBackColor = true;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.pictureBox_ChangedRgbViewPicture);
			this.groupBox3.Controls.Add(this.pictureBox_OriginalRgbViewPicture);
			this.groupBox3.Controls.Add(this.numericUpDown_RgbView_Blue);
			this.groupBox3.Controls.Add(this.numericUpDown_RgbView_Green);
			this.groupBox3.Controls.Add(this.numericUpDown_RgbView_Red);
			this.groupBox3.Controls.Add(this.label1);
			this.groupBox3.Controls.Add(this.label2);
			this.groupBox3.Controls.Add(this.label3);
			this.groupBox3.Controls.Add(this.button_RgbViewSavePicture);
			this.groupBox3.Controls.Add(this.label4);
			this.groupBox3.Controls.Add(this.button_RgbViewFindPicture);
			this.groupBox3.Location = new System.Drawing.Point(3, 6);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(230, 662);
			this.groupBox3.TabIndex = 42;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Превью:";
			// 
			// pictureBox_ChangedRgbViewPicture
			// 
			this.pictureBox_ChangedRgbViewPicture.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.pictureBox_ChangedRgbViewPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.pictureBox_ChangedRgbViewPicture.Location = new System.Drawing.Point(6, 345);
			this.pictureBox_ChangedRgbViewPicture.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.pictureBox_ChangedRgbViewPicture.Name = "pictureBox_ChangedRgbViewPicture";
			this.pictureBox_ChangedRgbViewPicture.Size = new System.Drawing.Size(215, 215);
			this.pictureBox_ChangedRgbViewPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox_ChangedRgbViewPicture.TabIndex = 40;
			this.pictureBox_ChangedRgbViewPicture.TabStop = false;
			this.pictureBox_ChangedRgbViewPicture.Click += new System.EventHandler(this.pictureBox_ChangedRgbViewPicture_Click);
			// 
			// pictureBox_OriginalRgbViewPicture
			// 
			this.pictureBox_OriginalRgbViewPicture.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.pictureBox_OriginalRgbViewPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.pictureBox_OriginalRgbViewPicture.Location = new System.Drawing.Point(6, 46);
			this.pictureBox_OriginalRgbViewPicture.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.pictureBox_OriginalRgbViewPicture.Name = "pictureBox_OriginalRgbViewPicture";
			this.pictureBox_OriginalRgbViewPicture.Size = new System.Drawing.Size(215, 215);
			this.pictureBox_OriginalRgbViewPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox_OriginalRgbViewPicture.TabIndex = 39;
			this.pictureBox_OriginalRgbViewPicture.TabStop = false;
			this.pictureBox_OriginalRgbViewPicture.Click += new System.EventHandler(this.pictureBox_OriginalRgbViewPicture_Click);
			// 
			// numericUpDown_RgbView_Blue
			// 
			this.numericUpDown_RgbView_Blue.Location = new System.Drawing.Point(92, 629);
			this.numericUpDown_RgbView_Blue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.numericUpDown_RgbView_Blue.Name = "numericUpDown_RgbView_Blue";
			this.numericUpDown_RgbView_Blue.Size = new System.Drawing.Size(129, 26);
			this.numericUpDown_RgbView_Blue.TabIndex = 38;
			this.numericUpDown_RgbView_Blue.ValueChanged += new System.EventHandler(this.NumericUpDown_valueChanged);
			// 
			// numericUpDown_RgbView_Green
			// 
			this.numericUpDown_RgbView_Green.Location = new System.Drawing.Point(92, 597);
			this.numericUpDown_RgbView_Green.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.numericUpDown_RgbView_Green.Name = "numericUpDown_RgbView_Green";
			this.numericUpDown_RgbView_Green.Size = new System.Drawing.Size(129, 26);
			this.numericUpDown_RgbView_Green.TabIndex = 37;
			this.numericUpDown_RgbView_Green.ValueChanged += new System.EventHandler(this.NumericUpDown_valueChanged);
			// 
			// numericUpDown_RgbView_Red
			// 
			this.numericUpDown_RgbView_Red.Location = new System.Drawing.Point(92, 565);
			this.numericUpDown_RgbView_Red.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.numericUpDown_RgbView_Red.Name = "numericUpDown_RgbView_Red";
			this.numericUpDown_RgbView_Red.Size = new System.Drawing.Size(129, 26);
			this.numericUpDown_RgbView_Red.TabIndex = 36;
			this.numericUpDown_RgbView_Red.ValueChanged += new System.EventHandler(this.NumericUpDown_valueChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 631);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(60, 20);
			this.label1.TabIndex = 35;
			this.label1.Text = "Синий:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(4, 597);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(81, 20);
			this.label2.TabIndex = 34;
			this.label2.Text = "Зеленый:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 565);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(78, 20);
			this.label3.TabIndex = 33;
			this.label3.Text = "Красный:";
			// 
			// button_RgbViewSavePicture
			// 
			this.button_RgbViewSavePicture.Location = new System.Drawing.Point(6, 306);
			this.button_RgbViewSavePicture.Name = "button_RgbViewSavePicture";
			this.button_RgbViewSavePicture.Size = new System.Drawing.Size(105, 31);
			this.button_RgbViewSavePicture.TabIndex = 32;
			this.button_RgbViewSavePicture.Text = "Сохранить";
			this.button_RgbViewSavePicture.UseVisualStyleBackColor = true;
			this.button_RgbViewSavePicture.Click += new System.EventHandler(this.button_RgbViewSavePicture_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 22);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(190, 20);
			this.label4.TabIndex = 30;
			this.label4.Text = "Исходное изображение:";
			// 
			// button_RgbViewFindPicture
			// 
			this.button_RgbViewFindPicture.Location = new System.Drawing.Point(6, 269);
			this.button_RgbViewFindPicture.Name = "button_RgbViewFindPicture";
			this.button_RgbViewFindPicture.Size = new System.Drawing.Size(105, 31);
			this.button_RgbViewFindPicture.TabIndex = 31;
			this.button_RgbViewFindPicture.Text = "Найти";
			this.button_RgbViewFindPicture.UseVisualStyleBackColor = true;
			this.button_RgbViewFindPicture.Click += new System.EventHandler(this.button_RgbViewFindPicture_Click);
			// 
			// tabControl_RGBViewer
			// 
			this.tabControl_RGBViewer.Controls.Add(this.tabPage_RedMatrix);
			this.tabControl_RGBViewer.Controls.Add(this.tabPage_GreenMatrix);
			this.tabControl_RGBViewer.Controls.Add(this.tabPage_BlueMatrix);
			this.tabControl_RGBViewer.Location = new System.Drawing.Point(242, 6);
			this.tabControl_RGBViewer.Name = "tabControl_RGBViewer";
			this.tabControl_RGBViewer.SelectedIndex = 0;
			this.tabControl_RGBViewer.Size = new System.Drawing.Size(662, 672);
			this.tabControl_RGBViewer.TabIndex = 41;
			this.tabControl_RGBViewer.SelectedIndexChanged += new System.EventHandler(this.tabControl_RGBViewer_SelectedIndexChanged);
			// 
			// tabPage_RedMatrix
			// 
			this.tabPage_RedMatrix.Controls.Add(this.dataGridView_Red);
			this.tabPage_RedMatrix.Location = new System.Drawing.Point(4, 29);
			this.tabPage_RedMatrix.Name = "tabPage_RedMatrix";
			this.tabPage_RedMatrix.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage_RedMatrix.Size = new System.Drawing.Size(654, 639);
			this.tabPage_RedMatrix.TabIndex = 0;
			this.tabPage_RedMatrix.Text = "Red";
			this.tabPage_RedMatrix.UseVisualStyleBackColor = true;
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
			dataGridViewCellStyle52.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle52.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle52.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle52.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle52.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle52.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle52.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView_Red.DefaultCellStyle = dataGridViewCellStyle52;
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
			// tabPage_GreenMatrix
			// 
			this.tabPage_GreenMatrix.Controls.Add(this.dataGridView_Green);
			this.tabPage_GreenMatrix.Location = new System.Drawing.Point(4, 29);
			this.tabPage_GreenMatrix.Name = "tabPage_GreenMatrix";
			this.tabPage_GreenMatrix.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage_GreenMatrix.Size = new System.Drawing.Size(654, 639);
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
			dataGridViewCellStyle53.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle53.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle53.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle53.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle53.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle53.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle53.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView_Green.DefaultCellStyle = dataGridViewCellStyle53;
			this.dataGridView_Green.Location = new System.Drawing.Point(8, 6);
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
			this.tabPage_BlueMatrix.Size = new System.Drawing.Size(654, 639);
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
			dataGridViewCellStyle54.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle54.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle54.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle54.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle54.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle54.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle54.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView_Blue.DefaultCellStyle = dataGridViewCellStyle54;
			this.dataGridView_Blue.Location = new System.Drawing.Point(8, 6);
			this.dataGridView_Blue.Name = "dataGridView_Blue";
			this.dataGridView_Blue.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.dataGridView_Blue.RowHeadersVisible = false;
			this.dataGridView_Blue.RowHeadersWidth = 62;
			this.dataGridView_Blue.RowTemplate.Height = 28;
			this.dataGridView_Blue.Size = new System.Drawing.Size(638, 626);
			this.dataGridView_Blue.TabIndex = 41;
			this.dataGridView_Blue.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
			// 
			// tabControl_Main
			// 
			this.tabControl_Main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl_Main.Controls.Add(this.tabPage_Texturing);
			this.tabControl_Main.Controls.Add(this.tabPage_View);
			this.tabControl_Main.Controls.Add(this.tabPage_Shading);
			this.tabControl_Main.Controls.Add(this.tabPage_ColorSpacesConverter);
			this.tabControl_Main.Controls.Add(this.tabPage_Filtration);
			this.tabControl_Main.Location = new System.Drawing.Point(12, 9);
			this.tabControl_Main.Name = "tabControl_Main";
			this.tabControl_Main.SelectedIndex = 0;
			this.tabControl_Main.Size = new System.Drawing.Size(931, 722);
			this.tabControl_Main.TabIndex = 42;
			// 
			// tabPage_Texturing
			// 
			this.tabPage_Texturing.Controls.Add(this.texturingImagesPropertiesDataGridView);
			this.tabPage_Texturing.Controls.Add(this.OpenTextureImageButton);
			this.tabPage_Texturing.Controls.Add(this.texturingImageCollectionListView);
			this.tabPage_Texturing.Location = new System.Drawing.Point(4, 29);
			this.tabPage_Texturing.Name = "tabPage_Texturing";
			this.tabPage_Texturing.Size = new System.Drawing.Size(923, 689);
			this.tabPage_Texturing.TabIndex = 6;
			this.tabPage_Texturing.Text = "Текстуры";
			this.tabPage_Texturing.UseVisualStyleBackColor = true;
			// 
			// texturingImagesPropertiesDataGridView
			// 
			this.texturingImagesPropertiesDataGridView.AllowUserToAddRows = false;
			this.texturingImagesPropertiesDataGridView.AllowUserToDeleteRows = false;
			this.texturingImagesPropertiesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.texturingImagesPropertiesDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.texturingImagesPropertiesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.texturingImagesPropertiesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.imageNameColumn,
            this.showBrightnessMatrixColumn,
            this.showOccuranceMatrixColumn,
            this.showNormalizedMatrixColumn,
            this.energyValueColumn,
            this.entropyValueColumn,
            this.correlationValueColumn,
            this.contrastValueColumn,
            this.homogenValueColumn,
            this.distanceValueColumn});
			this.texturingImagesPropertiesDataGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.texturingImagesPropertiesDataGridView.Location = new System.Drawing.Point(141, 4);
			this.texturingImagesPropertiesDataGridView.Name = "texturingImagesPropertiesDataGridView";
			this.texturingImagesPropertiesDataGridView.ReadOnly = true;
			this.texturingImagesPropertiesDataGridView.RowHeadersVisible = false;
			this.texturingImagesPropertiesDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
			this.texturingImagesPropertiesDataGridView.RowTemplate.Height = 28;
			this.texturingImagesPropertiesDataGridView.Size = new System.Drawing.Size(779, 672);
			this.texturingImagesPropertiesDataGridView.TabIndex = 2;
			this.texturingImagesPropertiesDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.texturingImagesPropertiesDataGridView_CellContentClick);
			// 
			// OpenTextureImageButton
			// 
			this.OpenTextureImageButton.Location = new System.Drawing.Point(4, 637);
			this.OpenTextureImageButton.Name = "OpenTextureImageButton";
			this.OpenTextureImageButton.Size = new System.Drawing.Size(131, 39);
			this.OpenTextureImageButton.TabIndex = 1;
			this.OpenTextureImageButton.Text = "Open";
			this.OpenTextureImageButton.UseVisualStyleBackColor = true;
			this.OpenTextureImageButton.Click += new System.EventHandler(this.OnOpenTextureImageButtonClick);
			// 
			// texturingImageCollectionListView
			// 
			this.texturingImageCollectionListView.HideSelection = false;
			this.texturingImageCollectionListView.Location = new System.Drawing.Point(4, 3);
			this.texturingImageCollectionListView.MultiSelect = false;
			this.texturingImageCollectionListView.Name = "texturingImageCollectionListView";
			this.texturingImageCollectionListView.Size = new System.Drawing.Size(131, 628);
			this.texturingImageCollectionListView.TabIndex = 0;
			this.texturingImageCollectionListView.UseCompatibleStateImageBehavior = false;
			// 
			// tabPage_Filtration
			// 
			this.tabPage_Filtration.Controls.Add(this.groupBox4);
			this.tabPage_Filtration.Controls.Add(this.tabControl_Filtration);
			this.tabPage_Filtration.Location = new System.Drawing.Point(4, 29);
			this.tabPage_Filtration.Name = "tabPage_Filtration";
			this.tabPage_Filtration.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage_Filtration.Size = new System.Drawing.Size(923, 689);
			this.tabPage_Filtration.TabIndex = 5;
			this.tabPage_Filtration.Text = "Фильтрация";
			this.tabPage_Filtration.UseVisualStyleBackColor = true;
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.label12);
			this.groupBox4.Controls.Add(this.numericUpDown_FilterSize);
			this.groupBox4.Controls.Add(this.pictureBox_FilterChangedImage);
			this.groupBox4.Controls.Add(this.pictureBox_FilterOriginalImage);
			this.groupBox4.Controls.Add(this.button_FiltrationSaveImage);
			this.groupBox4.Controls.Add(this.label11);
			this.groupBox4.Controls.Add(this.button_FiltrationFindImage);
			this.groupBox4.Controls.Add(this.button_UseFilter);
			this.groupBox4.Location = new System.Drawing.Point(3, 8);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(230, 662);
			this.groupBox4.TabIndex = 42;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Превью:";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(6, 569);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(69, 20);
			this.label12.TabIndex = 47;
			this.label12.Text = "Размер:";
			// 
			// numericUpDown_FilterSize
			// 
			this.numericUpDown_FilterSize.Location = new System.Drawing.Point(81, 567);
			this.numericUpDown_FilterSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDown_FilterSize.Name = "numericUpDown_FilterSize";
			this.numericUpDown_FilterSize.Size = new System.Drawing.Size(140, 26);
			this.numericUpDown_FilterSize.TabIndex = 46;
			this.numericUpDown_FilterSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDown_FilterSize.ValueChanged += new System.EventHandler(this.numericUpDown_FilterSize_ValueChanged);
			// 
			// pictureBox_FilterChangedImage
			// 
			this.pictureBox_FilterChangedImage.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.pictureBox_FilterChangedImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.pictureBox_FilterChangedImage.Location = new System.Drawing.Point(6, 345);
			this.pictureBox_FilterChangedImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.pictureBox_FilterChangedImage.Name = "pictureBox_FilterChangedImage";
			this.pictureBox_FilterChangedImage.Size = new System.Drawing.Size(215, 215);
			this.pictureBox_FilterChangedImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox_FilterChangedImage.TabIndex = 45;
			this.pictureBox_FilterChangedImage.TabStop = false;
			// 
			// pictureBox_FilterOriginalImage
			// 
			this.pictureBox_FilterOriginalImage.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.pictureBox_FilterOriginalImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.pictureBox_FilterOriginalImage.Location = new System.Drawing.Point(6, 46);
			this.pictureBox_FilterOriginalImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.pictureBox_FilterOriginalImage.Name = "pictureBox_FilterOriginalImage";
			this.pictureBox_FilterOriginalImage.Size = new System.Drawing.Size(215, 215);
			this.pictureBox_FilterOriginalImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox_FilterOriginalImage.TabIndex = 44;
			this.pictureBox_FilterOriginalImage.TabStop = false;
			this.pictureBox_FilterOriginalImage.Click += new System.EventHandler(this.pictureBox_FilterOriginalImage_Click);
			// 
			// button_FiltrationSaveImage
			// 
			this.button_FiltrationSaveImage.Location = new System.Drawing.Point(6, 306);
			this.button_FiltrationSaveImage.Name = "button_FiltrationSaveImage";
			this.button_FiltrationSaveImage.Size = new System.Drawing.Size(105, 31);
			this.button_FiltrationSaveImage.TabIndex = 43;
			this.button_FiltrationSaveImage.Text = "Сохранить";
			this.button_FiltrationSaveImage.UseVisualStyleBackColor = true;
			this.button_FiltrationSaveImage.Click += new System.EventHandler(this.button_FiltrationSaveImage_Click);
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(6, 22);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(190, 20);
			this.label11.TabIndex = 41;
			this.label11.Text = "Исходное изображение:";
			// 
			// button_FiltrationFindImage
			// 
			this.button_FiltrationFindImage.Location = new System.Drawing.Point(6, 269);
			this.button_FiltrationFindImage.Name = "button_FiltrationFindImage";
			this.button_FiltrationFindImage.Size = new System.Drawing.Size(105, 31);
			this.button_FiltrationFindImage.TabIndex = 42;
			this.button_FiltrationFindImage.Text = "Найти";
			this.button_FiltrationFindImage.UseVisualStyleBackColor = true;
			this.button_FiltrationFindImage.Click += new System.EventHandler(this.button_FiltrationFindImage_Click);
			// 
			// button_UseFilter
			// 
			this.button_UseFilter.Location = new System.Drawing.Point(10, 622);
			this.button_UseFilter.Name = "button_UseFilter";
			this.button_UseFilter.Size = new System.Drawing.Size(211, 34);
			this.button_UseFilter.TabIndex = 35;
			this.button_UseFilter.Text = "Фитрация";
			this.button_UseFilter.UseVisualStyleBackColor = true;
			this.button_UseFilter.Click += new System.EventHandler(this.button_UseFilter_Click);
			// 
			// tabControl_Filtration
			// 
			this.tabControl_Filtration.Controls.Add(this.tabPage_MedianFilter);
			this.tabControl_Filtration.Location = new System.Drawing.Point(239, 8);
			this.tabControl_Filtration.Name = "tabControl_Filtration";
			this.tabControl_Filtration.SelectedIndex = 0;
			this.tabControl_Filtration.Size = new System.Drawing.Size(671, 672);
			this.tabControl_Filtration.TabIndex = 43;
			// 
			// tabPage_MedianFilter
			// 
			this.tabPage_MedianFilter.Controls.Add(this.dataGridView_MedianFilterValues);
			this.tabPage_MedianFilter.Location = new System.Drawing.Point(4, 29);
			this.tabPage_MedianFilter.Name = "tabPage_MedianFilter";
			this.tabPage_MedianFilter.Size = new System.Drawing.Size(663, 639);
			this.tabPage_MedianFilter.TabIndex = 3;
			this.tabPage_MedianFilter.Text = "Медианная";
			this.tabPage_MedianFilter.UseVisualStyleBackColor = true;
			// 
			// dataGridView_MedianFilterValues
			// 
			this.dataGridView_MedianFilterValues.AllowUserToAddRows = false;
			this.dataGridView_MedianFilterValues.AllowUserToDeleteRows = false;
			this.dataGridView_MedianFilterValues.AllowUserToResizeColumns = false;
			this.dataGridView_MedianFilterValues.AllowUserToResizeRows = false;
			this.dataGridView_MedianFilterValues.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataGridView_MedianFilterValues.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dataGridView_MedianFilterValues.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGridView_MedianFilterValues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_MedianFilterValues.ColumnHeadersVisible = false;
			this.dataGridView_MedianFilterValues.Cursor = System.Windows.Forms.Cursors.Arrow;
			dataGridViewCellStyle55.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle55.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle55.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle55.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle55.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle55.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle55.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView_MedianFilterValues.DefaultCellStyle = dataGridViewCellStyle55;
			this.dataGridView_MedianFilterValues.Location = new System.Drawing.Point(8, 6);
			this.dataGridView_MedianFilterValues.Name = "dataGridView_MedianFilterValues";
			this.dataGridView_MedianFilterValues.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.dataGridView_MedianFilterValues.RowHeadersVisible = false;
			this.dataGridView_MedianFilterValues.RowHeadersWidth = 62;
			this.dataGridView_MedianFilterValues.RowTemplate.Height = 28;
			this.dataGridView_MedianFilterValues.Size = new System.Drawing.Size(638, 626);
			this.dataGridView_MedianFilterValues.TabIndex = 42;
			// 
			// imageList
			// 
			this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imageList.ImageSize = new System.Drawing.Size(16, 16);
			this.imageList.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// MultiSelectableOpenFileDialog
			// 
			this.MultiSelectableOpenFileDialog.FileName = "openFileDialog1";
			this.MultiSelectableOpenFileDialog.Multiselect = true;
			// 
			// imageNameColumn
			// 
			this.imageNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.imageNameColumn.FillWeight = 227.2727F;
			this.imageNameColumn.HeaderText = "Image name";
			this.imageNameColumn.MinimumWidth = 8;
			this.imageNameColumn.Name = "imageNameColumn";
			this.imageNameColumn.ReadOnly = true;
			this.imageNameColumn.Width = 134;
			// 
			// showBrightnessMatrixColumn
			// 
			this.showBrightnessMatrixColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.showBrightnessMatrixColumn.FillWeight = 89.18641F;
			this.showBrightnessMatrixColumn.HeaderText = "Brightness";
			this.showBrightnessMatrixColumn.MinimumWidth = 8;
			this.showBrightnessMatrixColumn.Name = "showBrightnessMatrixColumn";
			this.showBrightnessMatrixColumn.ReadOnly = true;
			this.showBrightnessMatrixColumn.UseColumnTextForButtonValue = true;
			this.showBrightnessMatrixColumn.Width = 91;
			// 
			// showOccuranceMatrixColumn
			// 
			this.showOccuranceMatrixColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.showOccuranceMatrixColumn.FillWeight = 89.18641F;
			this.showOccuranceMatrixColumn.HeaderText = "Co-occurance";
			this.showOccuranceMatrixColumn.MinimumWidth = 8;
			this.showOccuranceMatrixColumn.Name = "showOccuranceMatrixColumn";
			this.showOccuranceMatrixColumn.ReadOnly = true;
			this.showOccuranceMatrixColumn.UseColumnTextForButtonValue = true;
			this.showOccuranceMatrixColumn.Width = 114;
			// 
			// showNormalizedMatrixColumn
			// 
			this.showNormalizedMatrixColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.showNormalizedMatrixColumn.FillWeight = 89.18641F;
			this.showNormalizedMatrixColumn.HeaderText = "Normalized";
			this.showNormalizedMatrixColumn.MinimumWidth = 8;
			this.showNormalizedMatrixColumn.Name = "showNormalizedMatrixColumn";
			this.showNormalizedMatrixColumn.ReadOnly = true;
			this.showNormalizedMatrixColumn.UseColumnTextForButtonValue = true;
			this.showNormalizedMatrixColumn.Width = 94;
			// 
			// energyValueColumn
			// 
			this.energyValueColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.energyValueColumn.FillWeight = 89.18641F;
			this.energyValueColumn.HeaderText = "ENRG";
			this.energyValueColumn.MinimumWidth = 8;
			this.energyValueColumn.Name = "energyValueColumn";
			this.energyValueColumn.ReadOnly = true;
			this.energyValueColumn.Width = 92;
			// 
			// entropyValueColumn
			// 
			this.entropyValueColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.entropyValueColumn.FillWeight = 89.18641F;
			this.entropyValueColumn.HeaderText = "ENT";
			this.entropyValueColumn.MinimumWidth = 8;
			this.entropyValueColumn.Name = "entropyValueColumn";
			this.entropyValueColumn.ReadOnly = true;
			this.entropyValueColumn.Width = 76;
			// 
			// correlationValueColumn
			// 
			this.correlationValueColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.correlationValueColumn.FillWeight = 89.18641F;
			this.correlationValueColumn.HeaderText = "CORL";
			this.correlationValueColumn.MinimumWidth = 8;
			this.correlationValueColumn.Name = "correlationValueColumn";
			this.correlationValueColumn.ReadOnly = true;
			this.correlationValueColumn.Width = 89;
			// 
			// contrastValueColumn
			// 
			this.contrastValueColumn.HeaderText = "CNTR";
			this.contrastValueColumn.MinimumWidth = 8;
			this.contrastValueColumn.Name = "contrastValueColumn";
			this.contrastValueColumn.ReadOnly = true;
			this.contrastValueColumn.Width = 88;
			// 
			// homogenValueColumn
			// 
			this.homogenValueColumn.HeaderText = "GMG";
			this.homogenValueColumn.MinimumWidth = 8;
			this.homogenValueColumn.Name = "homogenValueColumn";
			this.homogenValueColumn.ReadOnly = true;
			this.homogenValueColumn.Width = 84;
			// 
			// distanceValueColumn
			// 
			this.distanceValueColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.distanceValueColumn.FillWeight = 37.60873F;
			this.distanceValueColumn.HeaderText = "DIST";
			this.distanceValueColumn.MinimumWidth = 8;
			this.distanceValueColumn.Name = "distanceValueColumn";
			this.distanceValueColumn.ReadOnly = true;
			this.distanceValueColumn.Width = 82;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(952, 748);
			this.Controls.Add(this.tabControl_Main);
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Обработка изображений Барковец Р. 10702221";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.tabPage_ColorSpacesConverter.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_YUVPicture)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_OriginalRGBPicture)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
			this.tabControl_YUVMatrix.ResumeLayout(false);
			this.tabPage_Y.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_YUV_Y)).EndInit();
			this.tabPage_U.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_YUV_U)).EndInit();
			this.tabPage_V.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_YUV_V)).EndInit();
			this.tabPage_Shading.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.tabControl_Shading.ResumeLayout(false);
			this.tabPage_WaveShading.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_WaveShading)).EndInit();
			this.tabPage_EuclidShading.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_EuclidShading)).EndInit();
			this.tabPage_ChessShading.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_ChessShading)).EndInit();
			this.tabPage_CityShading.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_CityShading)).EndInit();
			this.tabPage_View.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_ChangedRgbViewPicture)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_OriginalRgbViewPicture)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_RgbView_Blue)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_RgbView_Green)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_RgbView_Red)).EndInit();
			this.tabControl_RGBViewer.ResumeLayout(false);
			this.tabPage_RedMatrix.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_Red)).EndInit();
			this.tabPage_GreenMatrix.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_Green)).EndInit();
			this.tabPage_BlueMatrix.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_Blue)).EndInit();
			this.tabControl_Main.ResumeLayout(false);
			this.tabPage_Texturing.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.texturingImagesPropertiesDataGridView)).EndInit();
			this.tabPage_Filtration.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_FilterSize)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_FilterChangedImage)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_FilterOriginalImage)).EndInit();
			this.tabControl_Filtration.ResumeLayout(false);
			this.tabPage_MedianFilter.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_MedianFilterValues)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.TabPage tabPage_ColorSpacesConverter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button_YUVSave;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button_YUVFind;
        private System.Windows.Forms.TabControl tabControl_YUVMatrix;
        private System.Windows.Forms.TabPage tabPage_Y;
        private System.Windows.Forms.DataGridView dataGridView_YUV_Y;
        private System.Windows.Forms.TabPage tabPage_U;
        private System.Windows.Forms.DataGridView dataGridView_YUV_U;
        private System.Windows.Forms.TabPage tabPage_V;
        private System.Windows.Forms.DataGridView dataGridView_YUV_V;
        private System.Windows.Forms.TabPage tabPage_Shading;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_MakeShading;
        private System.Windows.Forms.ComboBox comboBox_BinarizationMethods;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabControl tabControl_Shading;
        private System.Windows.Forms.TabPage tabPage_WaveShading;
        private System.Windows.Forms.DataGridView dataGridView_WaveShading;
        private System.Windows.Forms.TabPage tabPage_EuclidShading;
        private System.Windows.Forms.DataGridView dataGridView_EuclidShading;
        private System.Windows.Forms.TabPage tabPage_ChessShading;
        private System.Windows.Forms.DataGridView dataGridView_ChessShading;
        private System.Windows.Forms.TabPage tabPage_CityShading;
        private System.Windows.Forms.DataGridView dataGridView_CityShading;
        private System.Windows.Forms.TabPage tabPage_View;
        private System.Windows.Forms.TabControl tabControl_RGBViewer;
        private System.Windows.Forms.TabPage tabPage_RedMatrix;
        private System.Windows.Forms.DataGridView dataGridView_Red;
        private System.Windows.Forms.TabPage tabPage_GreenMatrix;
        private System.Windows.Forms.DataGridView dataGridView_Green;
        private System.Windows.Forms.TabPage tabPage_BlueMatrix;
        private System.Windows.Forms.DataGridView dataGridView_Blue;
        private System.Windows.Forms.TabControl tabControl_Main;
        private System.Windows.Forms.PictureBox pictureBox_YUVPicture;
        private System.Windows.Forms.PictureBox pictureBox_OriginalRGBPicture;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBox_ChangedRgbViewPicture;
        private System.Windows.Forms.PictureBox pictureBox_OriginalRgbViewPicture;
        private System.Windows.Forms.NumericUpDown numericUpDown_RgbView_Blue;
        private System.Windows.Forms.NumericUpDown numericUpDown_RgbView_Green;
        private System.Windows.Forms.NumericUpDown numericUpDown_RgbView_Red;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_RgbViewSavePicture;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_RgbViewFindPicture;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabPage tabPage_Filtration;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox pictureBox_FilterChangedImage;
        private System.Windows.Forms.PictureBox pictureBox_FilterOriginalImage;
        private System.Windows.Forms.Button button_FiltrationSaveImage;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button_FiltrationFindImage;
        private System.Windows.Forms.Button button_UseFilter;
        private System.Windows.Forms.TabControl tabControl_Filtration;
        private System.Windows.Forms.TabPage tabPage_MedianFilter;
        private System.Windows.Forms.DataGridView dataGridView_MedianFilterValues;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown numericUpDown_FilterSize;
		private System.Windows.Forms.TabPage tabPage_Texturing;
		private System.Windows.Forms.ImageList imageList;
		private System.Windows.Forms.ListView texturingImageCollectionListView;
		private System.Windows.Forms.Button OpenTextureImageButton;
		private System.Windows.Forms.OpenFileDialog MultiSelectableOpenFileDialog;
		private System.Windows.Forms.DataGridView texturingImagesPropertiesDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn imageNameColumn;
		private System.Windows.Forms.DataGridViewButtonColumn showBrightnessMatrixColumn;
		private System.Windows.Forms.DataGridViewButtonColumn showOccuranceMatrixColumn;
		private System.Windows.Forms.DataGridViewButtonColumn showNormalizedMatrixColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn energyValueColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn entropyValueColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn correlationValueColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn contrastValueColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn homogenValueColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn distanceValueColumn;
	}
}

