﻿namespace shape_recognizer
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
            this.AltAer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classifiedShapeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonClassify = new System.Windows.Forms.Button();
            this.comboBoxShapeClass = new System.Windows.Forms.ComboBox();
            this.buttonDataGridClear = new System.Windows.Forms.Button();
            this.buttonLoadImage = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialogImage = new System.Windows.Forms.OpenFileDialog();
            this.buttonSaveCSV = new System.Windows.Forms.Button();
            this.buttonLoadCSV = new System.Windows.Forms.Button();
            this.dataGridViewStatistics = new System.Windows.Forms.DataGridView();
            this.shapeClassDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lenPchDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pch2AchDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.altAchDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pchPerDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.achAerAltDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classifiedShapeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.labelStatistics = new System.Windows.Forms.Label();
            this.buttonLoadImageMult = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClassifiedShape)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classifiedShapeBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStatistics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classifiedShapeBindingSource1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(130, 1);
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
            this.achAerAltDataGridViewTextBoxColumn,
            this.AltAer});
            this.dataGridViewClassifiedShape.DataSource = this.classifiedShapeBindingSource;
            this.dataGridViewClassifiedShape.Location = new System.Drawing.Point(392, 12);
            this.dataGridViewClassifiedShape.Name = "dataGridViewClassifiedShape";
            this.dataGridViewClassifiedShape.ReadOnly = true;
            this.dataGridViewClassifiedShape.Size = new System.Drawing.Size(480, 150);
            this.dataGridViewClassifiedShape.TabIndex = 10;
            this.dataGridViewClassifiedShape.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridViewClassifiedShape_RowsAdded);
            // 
            // shapeClassDataGridViewTextBoxColumn
            // 
            this.shapeClassDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.shapeClassDataGridViewTextBoxColumn.DataPropertyName = "shapeClass";
            this.shapeClassDataGridViewTextBoxColumn.HeaderText = "shapeClass";
            this.shapeClassDataGridViewTextBoxColumn.Name = "shapeClassDataGridViewTextBoxColumn";
            this.shapeClassDataGridViewTextBoxColumn.ReadOnly = true;
            this.shapeClassDataGridViewTextBoxColumn.Width = 86;
            // 
            // lenPchDataGridViewTextBoxColumn
            // 
            this.lenPchDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.lenPchDataGridViewTextBoxColumn.DataPropertyName = "LenPch";
            this.lenPchDataGridViewTextBoxColumn.HeaderText = "LenPch";
            this.lenPchDataGridViewTextBoxColumn.Name = "lenPchDataGridViewTextBoxColumn";
            this.lenPchDataGridViewTextBoxColumn.ReadOnly = true;
            this.lenPchDataGridViewTextBoxColumn.Width = 69;
            // 
            // pch2AchDataGridViewTextBoxColumn
            // 
            this.pch2AchDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.pch2AchDataGridViewTextBoxColumn.DataPropertyName = "Pch2Ach";
            this.pch2AchDataGridViewTextBoxColumn.HeaderText = "Pch2Ach";
            this.pch2AchDataGridViewTextBoxColumn.Name = "pch2AchDataGridViewTextBoxColumn";
            this.pch2AchDataGridViewTextBoxColumn.ReadOnly = true;
            this.pch2AchDataGridViewTextBoxColumn.Width = 76;
            // 
            // altAchDataGridViewTextBoxColumn
            // 
            this.altAchDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.altAchDataGridViewTextBoxColumn.DataPropertyName = "AltAch";
            this.altAchDataGridViewTextBoxColumn.HeaderText = "AltAch";
            this.altAchDataGridViewTextBoxColumn.Name = "altAchDataGridViewTextBoxColumn";
            this.altAchDataGridViewTextBoxColumn.ReadOnly = true;
            this.altAchDataGridViewTextBoxColumn.Width = 63;
            // 
            // pchPerDataGridViewTextBoxColumn
            // 
            this.pchPerDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.pchPerDataGridViewTextBoxColumn.DataPropertyName = "PchPer";
            this.pchPerDataGridViewTextBoxColumn.HeaderText = "PchPer";
            this.pchPerDataGridViewTextBoxColumn.Name = "pchPerDataGridViewTextBoxColumn";
            this.pchPerDataGridViewTextBoxColumn.ReadOnly = true;
            this.pchPerDataGridViewTextBoxColumn.Width = 67;
            // 
            // achAerAltDataGridViewTextBoxColumn
            // 
            this.achAerAltDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.achAerAltDataGridViewTextBoxColumn.DataPropertyName = "AchAerAlt";
            this.achAerAltDataGridViewTextBoxColumn.HeaderText = "AchAerAlt";
            this.achAerAltDataGridViewTextBoxColumn.Name = "achAerAltDataGridViewTextBoxColumn";
            this.achAerAltDataGridViewTextBoxColumn.ReadOnly = true;
            this.achAerAltDataGridViewTextBoxColumn.Width = 79;
            // 
            // AltAer
            // 
            this.AltAer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.AltAer.DataPropertyName = "AltAer";
            this.AltAer.HeaderText = "AltAer";
            this.AltAer.Name = "AltAer";
            this.AltAer.ReadOnly = true;
            this.AltAer.Width = 60;
            // 
            // classifiedShapeBindingSource
            // 
            this.classifiedShapeBindingSource.DataSource = typeof(shape_recognizer.ClassifiedShape);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(211, 1);
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
            this.panel1.Location = new System.Drawing.Point(392, 431);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(371, 28);
            this.panel1.TabIndex = 12;
            // 
            // buttonClassify
            // 
            this.buttonClassify.Location = new System.Drawing.Point(292, 1);
            this.buttonClassify.Name = "buttonClassify";
            this.buttonClassify.Size = new System.Drawing.Size(75, 23);
            this.buttonClassify.TabIndex = 12;
            this.buttonClassify.Text = "Classify";
            this.buttonClassify.UseVisualStyleBackColor = true;
            this.buttonClassify.Click += new System.EventHandler(this.buttonClassify_Click);
            // 
            // comboBoxShapeClass
            // 
            this.comboBoxShapeClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxShapeClass.FormattingEnabled = true;
            this.comboBoxShapeClass.Location = new System.Drawing.Point(3, 3);
            this.comboBoxShapeClass.Name = "comboBoxShapeClass";
            this.comboBoxShapeClass.Size = new System.Drawing.Size(121, 21);
            this.comboBoxShapeClass.TabIndex = 1;
            // 
            // buttonDataGridClear
            // 
            this.buttonDataGridClear.Location = new System.Drawing.Point(392, 168);
            this.buttonDataGridClear.Name = "buttonDataGridClear";
            this.buttonDataGridClear.Size = new System.Drawing.Size(75, 23);
            this.buttonDataGridClear.TabIndex = 12;
            this.buttonDataGridClear.Text = "Clear";
            this.buttonDataGridClear.UseVisualStyleBackColor = true;
            this.buttonDataGridClear.Click += new System.EventHandler(this.buttonDataGridClear_Click);
            // 
            // buttonLoadImage
            // 
            this.buttonLoadImage.Location = new System.Drawing.Point(120, 309);
            this.buttonLoadImage.Name = "buttonLoadImage";
            this.buttonLoadImage.Size = new System.Drawing.Size(75, 23);
            this.buttonLoadImage.TabIndex = 1;
            this.buttonLoadImage.Text = "Load Image";
            this.buttonLoadImage.UseVisualStyleBackColor = true;
            this.buttonLoadImage.Click += new System.EventHandler(this.buttonLoadImage_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
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
            this.openFileDialogImage.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialogImage_FileOk);
            // 
            // buttonSaveCSV
            // 
            this.buttonSaveCSV.Location = new System.Drawing.Point(473, 168);
            this.buttonSaveCSV.Name = "buttonSaveCSV";
            this.buttonSaveCSV.Size = new System.Drawing.Size(94, 23);
            this.buttonSaveCSV.TabIndex = 13;
            this.buttonSaveCSV.Text = "Save to CSV";
            this.buttonSaveCSV.UseVisualStyleBackColor = true;
            this.buttonSaveCSV.Click += new System.EventHandler(this.buttonSaveCSV_Click);
            // 
            // buttonLoadCSV
            // 
            this.buttonLoadCSV.Location = new System.Drawing.Point(573, 168);
            this.buttonLoadCSV.Name = "buttonLoadCSV";
            this.buttonLoadCSV.Size = new System.Drawing.Size(95, 23);
            this.buttonLoadCSV.TabIndex = 14;
            this.buttonLoadCSV.Text = "Load From CSV";
            this.buttonLoadCSV.UseVisualStyleBackColor = true;
            this.buttonLoadCSV.Click += new System.EventHandler(this.buttonLoadCSV_Click);
            // 
            // dataGridViewStatistics
            // 
            this.dataGridViewStatistics.AutoGenerateColumns = false;
            this.dataGridViewStatistics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStatistics.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.shapeClassDataGridViewTextBoxColumn1,
            this.lenPchDataGridViewTextBoxColumn1,
            this.pch2AchDataGridViewTextBoxColumn1,
            this.altAchDataGridViewTextBoxColumn1,
            this.pchPerDataGridViewTextBoxColumn1,
            this.achAerAltDataGridViewTextBoxColumn1});
            this.dataGridViewStatistics.DataSource = this.classifiedShapeBindingSource1;
            this.dataGridViewStatistics.Location = new System.Drawing.Point(392, 239);
            this.dataGridViewStatistics.Name = "dataGridViewStatistics";
            this.dataGridViewStatistics.Size = new System.Drawing.Size(480, 150);
            this.dataGridViewStatistics.TabIndex = 15;
            // 
            // shapeClassDataGridViewTextBoxColumn1
            // 
            this.shapeClassDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.shapeClassDataGridViewTextBoxColumn1.DataPropertyName = "shapeClass";
            this.shapeClassDataGridViewTextBoxColumn1.HeaderText = "shapeClass";
            this.shapeClassDataGridViewTextBoxColumn1.Name = "shapeClassDataGridViewTextBoxColumn1";
            this.shapeClassDataGridViewTextBoxColumn1.ReadOnly = true;
            this.shapeClassDataGridViewTextBoxColumn1.Width = 86;
            // 
            // lenPchDataGridViewTextBoxColumn1
            // 
            this.lenPchDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.lenPchDataGridViewTextBoxColumn1.DataPropertyName = "LenPch";
            this.lenPchDataGridViewTextBoxColumn1.HeaderText = "LenPch";
            this.lenPchDataGridViewTextBoxColumn1.Name = "lenPchDataGridViewTextBoxColumn1";
            this.lenPchDataGridViewTextBoxColumn1.ReadOnly = true;
            this.lenPchDataGridViewTextBoxColumn1.Width = 69;
            // 
            // pch2AchDataGridViewTextBoxColumn1
            // 
            this.pch2AchDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.pch2AchDataGridViewTextBoxColumn1.DataPropertyName = "Pch2Ach";
            this.pch2AchDataGridViewTextBoxColumn1.HeaderText = "Pch2Ach";
            this.pch2AchDataGridViewTextBoxColumn1.Name = "pch2AchDataGridViewTextBoxColumn1";
            this.pch2AchDataGridViewTextBoxColumn1.ReadOnly = true;
            this.pch2AchDataGridViewTextBoxColumn1.Width = 76;
            // 
            // altAchDataGridViewTextBoxColumn1
            // 
            this.altAchDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.altAchDataGridViewTextBoxColumn1.DataPropertyName = "AltAch";
            this.altAchDataGridViewTextBoxColumn1.HeaderText = "AltAch";
            this.altAchDataGridViewTextBoxColumn1.Name = "altAchDataGridViewTextBoxColumn1";
            this.altAchDataGridViewTextBoxColumn1.ReadOnly = true;
            this.altAchDataGridViewTextBoxColumn1.Width = 63;
            // 
            // pchPerDataGridViewTextBoxColumn1
            // 
            this.pchPerDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.pchPerDataGridViewTextBoxColumn1.DataPropertyName = "PchPer";
            this.pchPerDataGridViewTextBoxColumn1.HeaderText = "PchPer";
            this.pchPerDataGridViewTextBoxColumn1.Name = "pchPerDataGridViewTextBoxColumn1";
            this.pchPerDataGridViewTextBoxColumn1.ReadOnly = true;
            this.pchPerDataGridViewTextBoxColumn1.Width = 67;
            // 
            // achAerAltDataGridViewTextBoxColumn1
            // 
            this.achAerAltDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.achAerAltDataGridViewTextBoxColumn1.DataPropertyName = "AchAerAlt";
            this.achAerAltDataGridViewTextBoxColumn1.HeaderText = "AchAerAlt";
            this.achAerAltDataGridViewTextBoxColumn1.Name = "achAerAltDataGridViewTextBoxColumn1";
            this.achAerAltDataGridViewTextBoxColumn1.ReadOnly = true;
            this.achAerAltDataGridViewTextBoxColumn1.Width = 79;
            // 
            // classifiedShapeBindingSource1
            // 
            this.classifiedShapeBindingSource1.DataSource = typeof(shape_recognizer.ClassifiedShape);
            // 
            // labelStatistics
            // 
            this.labelStatistics.AutoSize = true;
            this.labelStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStatistics.Location = new System.Drawing.Point(392, 212);
            this.labelStatistics.Name = "labelStatistics";
            this.labelStatistics.Size = new System.Drawing.Size(84, 24);
            this.labelStatistics.TabIndex = 16;
            this.labelStatistics.Text = "Features";
            // 
            // buttonLoadImageMult
            // 
            this.buttonLoadImageMult.Location = new System.Drawing.Point(675, 168);
            this.buttonLoadImageMult.Name = "buttonLoadImageMult";
            this.buttonLoadImageMult.Size = new System.Drawing.Size(103, 23);
            this.buttonLoadImageMult.TabIndex = 17;
            this.buttonLoadImageMult.Text = "Multiple Images";
            this.buttonLoadImageMult.UseVisualStyleBackColor = true;
            this.buttonLoadImageMult.Click += new System.EventHandler(this.buttonLoadImageMult_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.buttonLoadImage);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(307, 360);
            this.panel2.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 467);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.buttonLoadImageMult);
            this.Controls.Add(this.labelStatistics);
            this.Controls.Add(this.dataGridViewStatistics);
            this.Controls.Add(this.buttonLoadCSV);
            this.Controls.Add(this.buttonSaveCSV);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStatistics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classifiedShapeBindingSource1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonLoadImage;
        private System.Windows.Forms.OpenFileDialog openFileDialogImage;
        private System.Windows.Forms.Button buttonClassify;
        private System.Windows.Forms.Button buttonSaveCSV;
        private System.Windows.Forms.Button buttonLoadCSV;
        private System.Windows.Forms.DataGridView dataGridViewStatistics;
        private System.Windows.Forms.BindingSource classifiedShapeBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn shapeClassDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lenPchDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pch2AchDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn altAchDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pchPerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn achAerAltDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AltAer;
        private System.Windows.Forms.DataGridViewTextBoxColumn shapeClassDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lenPchDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pch2AchDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn altAchDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pchPerDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn achAerAltDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label labelStatistics;
        private System.Windows.Forms.Button buttonLoadImageMult;
        private System.Windows.Forms.Panel panel2;
    }
}

