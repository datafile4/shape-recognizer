namespace shape_recognizer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.graphPanel = new System.Windows.Forms.Panel();
            this.buttonClear = new System.Windows.Forms.Button();
            this.labelPoint = new System.Windows.Forms.Label();
            this.labelShapePointCount = new System.Windows.Forms.Label();
            this.labelShapePointCountVal = new System.Windows.Forms.Label();
            this.labelConvHullPntCnt = new System.Windows.Forms.Label();
            this.labelConvHullPntCntVal = new System.Windows.Forms.Label();
            this.labelCHPerimeter = new System.Windows.Forms.Label();
            this.labelCHPerimeterValue = new System.Windows.Forms.Label();
            this.dataGridViewClassifiedShape = new System.Windows.Forms.DataGridView();
            this.shapeClassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lenPchDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pch2AchDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.altAchDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pchPerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.achAerAltDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classifiedShapeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonClassify = new System.Windows.Forms.Button();
            this.comboBoxShapeClass = new System.Windows.Forms.ComboBox();
            this.buttonDataGridClear = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonSavePolygon = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonLoadImage = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialogImage = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClassifiedShape)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classifiedShapeBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // graphPanel
            // 
            this.graphPanel.BackColor = System.Drawing.Color.White;
            this.graphPanel.Location = new System.Drawing.Point(6, 6);
            this.graphPanel.Name = "graphPanel";
            this.graphPanel.Size = new System.Drawing.Size(300, 300);
            this.graphPanel.TabIndex = 0;
            this.graphPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.graphPanel_MouseDown);
            this.graphPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.graphPanel_MouseMove);
            this.graphPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.graphPanel_MouseUp);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(131, 47);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 1;
            this.buttonClear.Text = "Forget";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // labelPoint
            // 
            this.labelPoint.AutoSize = true;
            this.labelPoint.Location = new System.Drawing.Point(350, 316);
            this.labelPoint.Name = "labelPoint";
            this.labelPoint.Size = new System.Drawing.Size(0, 13);
            this.labelPoint.TabIndex = 2;
            // 
            // labelShapePointCount
            // 
            this.labelShapePointCount.AutoSize = true;
            this.labelShapePointCount.Location = new System.Drawing.Point(9, 410);
            this.labelShapePointCount.Name = "labelShapePointCount";
            this.labelShapePointCount.Size = new System.Drawing.Size(65, 13);
            this.labelShapePointCount.TabIndex = 3;
            this.labelShapePointCount.Text = "Point Count:";
            // 
            // labelShapePointCountVal
            // 
            this.labelShapePointCountVal.AutoSize = true;
            this.labelShapePointCountVal.Location = new System.Drawing.Point(80, 359);
            this.labelShapePointCountVal.Name = "labelShapePointCountVal";
            this.labelShapePointCountVal.Size = new System.Drawing.Size(0, 13);
            this.labelShapePointCountVal.TabIndex = 4;
            // 
            // labelConvHullPntCnt
            // 
            this.labelConvHullPntCnt.AutoSize = true;
            this.labelConvHullPntCnt.Location = new System.Drawing.Point(198, 410);
            this.labelConvHullPntCnt.Name = "labelConvHullPntCnt";
            this.labelConvHullPntCnt.Size = new System.Drawing.Size(83, 13);
            this.labelConvHullPntCnt.TabIndex = 5;
            this.labelConvHullPntCnt.Text = "CH Point Count:";
            // 
            // labelConvHullPntCntVal
            // 
            this.labelConvHullPntCntVal.AutoSize = true;
            this.labelConvHullPntCntVal.Location = new System.Drawing.Point(287, 359);
            this.labelConvHullPntCntVal.Name = "labelConvHullPntCntVal";
            this.labelConvHullPntCntVal.Size = new System.Drawing.Size(0, 13);
            this.labelConvHullPntCntVal.TabIndex = 6;
            // 
            // labelCHPerimeter
            // 
            this.labelCHPerimeter.AutoSize = true;
            this.labelCHPerimeter.Location = new System.Drawing.Point(9, 431);
            this.labelCHPerimeter.Name = "labelCHPerimeter";
            this.labelCHPerimeter.Size = new System.Drawing.Size(75, 13);
            this.labelCHPerimeter.TabIndex = 7;
            this.labelCHPerimeter.Text = "CH Perimeter: ";
            // 
            // labelCHPerimeterValue
            // 
            this.labelCHPerimeterValue.AutoSize = true;
            this.labelCHPerimeterValue.Location = new System.Drawing.Point(80, 380);
            this.labelCHPerimeterValue.Name = "labelCHPerimeterValue";
            this.labelCHPerimeterValue.Size = new System.Drawing.Size(0, 13);
            this.labelCHPerimeterValue.TabIndex = 8;
            // 
            // dataGridViewClassifiedShape
            // 
            this.dataGridViewClassifiedShape.AutoGenerateColumns = false;
            this.dataGridViewClassifiedShape.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClassifiedShape.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.shapeClassDataGridViewTextBoxColumn,
            this.lenPchDataGridViewTextBoxColumn,
            this.pch2AchDataGridViewTextBoxColumn,
            this.altAchDataGridViewTextBoxColumn,
            this.pchPerDataGridViewTextBoxColumn,
            this.achAerAltDataGridViewTextBoxColumn});
            this.dataGridViewClassifiedShape.DataSource = this.classifiedShapeBindingSource;
            this.dataGridViewClassifiedShape.Location = new System.Drawing.Point(392, 12);
            this.dataGridViewClassifiedShape.Name = "dataGridViewClassifiedShape";
            this.dataGridViewClassifiedShape.ReadOnly = true;
            this.dataGridViewClassifiedShape.Size = new System.Drawing.Size(480, 150);
            this.dataGridViewClassifiedShape.TabIndex = 10;
            // 
            // shapeClassDataGridViewTextBoxColumn
            // 
            this.shapeClassDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.shapeClassDataGridViewTextBoxColumn.DataPropertyName = "shapeClass";
            this.shapeClassDataGridViewTextBoxColumn.HeaderText = "shapeClass";
            this.shapeClassDataGridViewTextBoxColumn.Name = "shapeClassDataGridViewTextBoxColumn";
            this.shapeClassDataGridViewTextBoxColumn.ReadOnly = true;
            this.shapeClassDataGridViewTextBoxColumn.Width = 86;
            // 
            // lenPchDataGridViewTextBoxColumn
            // 
            this.lenPchDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.lenPchDataGridViewTextBoxColumn.DataPropertyName = "LenPch";
            this.lenPchDataGridViewTextBoxColumn.HeaderText = "LenPch";
            this.lenPchDataGridViewTextBoxColumn.Name = "lenPchDataGridViewTextBoxColumn";
            this.lenPchDataGridViewTextBoxColumn.ReadOnly = true;
            this.lenPchDataGridViewTextBoxColumn.Width = 69;
            // 
            // pch2AchDataGridViewTextBoxColumn
            // 
            this.pch2AchDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.pch2AchDataGridViewTextBoxColumn.DataPropertyName = "Pch2Ach";
            this.pch2AchDataGridViewTextBoxColumn.HeaderText = "Pch2Ach";
            this.pch2AchDataGridViewTextBoxColumn.Name = "pch2AchDataGridViewTextBoxColumn";
            this.pch2AchDataGridViewTextBoxColumn.ReadOnly = true;
            this.pch2AchDataGridViewTextBoxColumn.Width = 76;
            // 
            // altAchDataGridViewTextBoxColumn
            // 
            this.altAchDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.altAchDataGridViewTextBoxColumn.DataPropertyName = "AltAch";
            this.altAchDataGridViewTextBoxColumn.HeaderText = "AltAch";
            this.altAchDataGridViewTextBoxColumn.Name = "altAchDataGridViewTextBoxColumn";
            this.altAchDataGridViewTextBoxColumn.ReadOnly = true;
            this.altAchDataGridViewTextBoxColumn.Width = 63;
            // 
            // pchPerDataGridViewTextBoxColumn
            // 
            this.pchPerDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.pchPerDataGridViewTextBoxColumn.DataPropertyName = "PchPer";
            this.pchPerDataGridViewTextBoxColumn.HeaderText = "PchPer";
            this.pchPerDataGridViewTextBoxColumn.Name = "pchPerDataGridViewTextBoxColumn";
            this.pchPerDataGridViewTextBoxColumn.ReadOnly = true;
            this.pchPerDataGridViewTextBoxColumn.Width = 67;
            // 
            // achAerAltDataGridViewTextBoxColumn
            // 
            this.achAerAltDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.achAerAltDataGridViewTextBoxColumn.DataPropertyName = "AchAerAlt";
            this.achAerAltDataGridViewTextBoxColumn.HeaderText = "AchAerAlt";
            this.achAerAltDataGridViewTextBoxColumn.Name = "achAerAltDataGridViewTextBoxColumn";
            this.achAerAltDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // classifiedShapeBindingSource
            // 
            this.classifiedShapeBindingSource.DataSource = typeof(shape_recognizer.ClassifiedShape);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(212, 47);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 11;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.buttonClassify);
            this.panel1.Controls.Add(this.comboBoxShapeClass);
            this.panel1.Controls.Add(this.buttonSave);
            this.panel1.Controls.Add(this.buttonClear);
            this.panel1.Location = new System.Drawing.Point(391, 205);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 100);
            this.panel1.TabIndex = 12;
            // 
            // buttonClassify
            // 
            this.buttonClassify.Location = new System.Drawing.Point(294, 47);
            this.buttonClassify.Name = "buttonClassify";
            this.buttonClassify.Size = new System.Drawing.Size(75, 23);
            this.buttonClassify.TabIndex = 12;
            this.buttonClassify.Text = "Classify";
            this.buttonClassify.UseVisualStyleBackColor = true;
            this.buttonClassify.Click += new System.EventHandler(this.buttonClassify_Click);
            // 
            // comboBoxShapeClass
            // 
            this.comboBoxShapeClass.FormattingEnabled = true;
            this.comboBoxShapeClass.Location = new System.Drawing.Point(4, 47);
            this.comboBoxShapeClass.Name = "comboBoxShapeClass";
            this.comboBoxShapeClass.Size = new System.Drawing.Size(121, 21);
            this.comboBoxShapeClass.TabIndex = 1;
            // 
            // buttonDataGridClear
            // 
            this.buttonDataGridClear.Location = new System.Drawing.Point(603, 168);
            this.buttonDataGridClear.Name = "buttonDataGridClear";
            this.buttonDataGridClear.Size = new System.Drawing.Size(75, 23);
            this.buttonDataGridClear.TabIndex = 12;
            this.buttonDataGridClear.Text = "Clear";
            this.buttonDataGridClear.UseVisualStyleBackColor = true;
            this.buttonDataGridClear.Click += new System.EventHandler(this.buttonDataGridClear_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(321, 381);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonSavePolygon);
            this.tabPage1.Controls.Add(this.graphPanel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(313, 355);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Draw Shape";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonSavePolygon
            // 
            this.buttonSavePolygon.Location = new System.Drawing.Point(108, 312);
            this.buttonSavePolygon.Name = "buttonSavePolygon";
            this.buttonSavePolygon.Size = new System.Drawing.Size(75, 23);
            this.buttonSavePolygon.TabIndex = 0;
            this.buttonSavePolygon.Text = "Save";
            this.buttonSavePolygon.UseVisualStyleBackColor = true;
            this.buttonSavePolygon.Click += new System.EventHandler(this.buttonSavePolygon_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonLoadImage);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(313, 355);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Upload Image";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonLoadImage
            // 
            this.buttonLoadImage.Location = new System.Drawing.Point(120, 313);
            this.buttonLoadImage.Name = "buttonLoadImage";
            this.buttonLoadImage.Size = new System.Drawing.Size(75, 23);
            this.buttonLoadImage.TabIndex = 1;
            this.buttonLoadImage.Text = "Load Image";
            this.buttonLoadImage.UseVisualStyleBackColor = true;
            this.buttonLoadImage.Click += new System.EventHandler(this.buttonLoadImage_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(7, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 300);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialogImage
            // 
            this.openFileDialogImage.FileName = "openFileDialog1";
            this.openFileDialogImage.Filter = "Jpeg Images|*.jpg";
            this.openFileDialogImage.Title = "Open Image:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 467);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.buttonDataGridClear);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewClassifiedShape);
            this.Controls.Add(this.labelCHPerimeterValue);
            this.Controls.Add(this.labelCHPerimeter);
            this.Controls.Add(this.labelConvHullPntCntVal);
            this.Controls.Add(this.labelConvHullPntCnt);
            this.Controls.Add(this.labelShapePointCountVal);
            this.Controls.Add(this.labelShapePointCount);
            this.Controls.Add(this.labelPoint);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 768);
            this.MinimumSize = new System.Drawing.Size(900, 440);
            this.Name = "Form1";
            this.Text = "Shape Recognizer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClassifiedShape)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classifiedShapeBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel graphPanel;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label labelPoint;
        private System.Windows.Forms.Label labelShapePointCount;
        private System.Windows.Forms.Label labelShapePointCountVal;
        private System.Windows.Forms.Label labelConvHullPntCnt;
        private System.Windows.Forms.Label labelConvHullPntCntVal;
        private System.Windows.Forms.Label labelCHPerimeter;
        private System.Windows.Forms.Label labelCHPerimeterValue;
        private System.Windows.Forms.DataGridView dataGridViewClassifiedShape;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.BindingSource classifiedShapeBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxShapeClass;
        private System.Windows.Forms.Button buttonDataGridClear;
        private System.Windows.Forms.DataGridViewTextBoxColumn shapeClassDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lenPchDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pch2AchDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn altAchDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pchPerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn achAerAltDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonLoadImage;
        private System.Windows.Forms.OpenFileDialog openFileDialogImage;
        private System.Windows.Forms.Button buttonSavePolygon;
        private System.Windows.Forms.Button buttonClassify;
    }
}

