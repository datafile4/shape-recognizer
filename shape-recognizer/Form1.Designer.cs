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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonSave = new System.Windows.Forms.Button();
            this.shapeClassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lenPchDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pch2AchDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.altAchDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pchPerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.achAerAltDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classifiedShapeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxShapeClass = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classifiedShapeBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // graphPanel
            // 
            this.graphPanel.BackColor = System.Drawing.Color.White;
            this.graphPanel.Location = new System.Drawing.Point(12, 12);
            this.graphPanel.Name = "graphPanel";
            this.graphPanel.Size = new System.Drawing.Size(373, 293);
            this.graphPanel.TabIndex = 0;
            this.graphPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.graphPanel_MouseDown);
            this.graphPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.graphPanel_MouseMove);
            this.graphPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.graphPanel_MouseUp);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(12, 311);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 1;
            this.buttonClear.Text = "Clear";
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
            this.labelShapePointCount.Location = new System.Drawing.Point(9, 359);
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
            this.labelConvHullPntCnt.Location = new System.Drawing.Point(198, 359);
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
            this.labelCHPerimeter.Location = new System.Drawing.Point(9, 380);
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
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.shapeClassDataGridViewTextBoxColumn,
            this.lenPchDataGridViewTextBoxColumn,
            this.pch2AchDataGridViewTextBoxColumn,
            this.altAchDataGridViewTextBoxColumn,
            this.pchPerDataGridViewTextBoxColumn,
            this.achAerAltDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.classifiedShapeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(392, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(480, 150);
            this.dataGridView1.TabIndex = 10;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(94, 310);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 11;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // shapeClassDataGridViewTextBoxColumn
            // 
            this.shapeClassDataGridViewTextBoxColumn.DataPropertyName = "shapeClass";
            this.shapeClassDataGridViewTextBoxColumn.HeaderText = "shapeClass";
            this.shapeClassDataGridViewTextBoxColumn.Name = "shapeClassDataGridViewTextBoxColumn";
            this.shapeClassDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lenPchDataGridViewTextBoxColumn
            // 
            this.lenPchDataGridViewTextBoxColumn.DataPropertyName = "LenPch";
            this.lenPchDataGridViewTextBoxColumn.HeaderText = "LenPch";
            this.lenPchDataGridViewTextBoxColumn.Name = "lenPchDataGridViewTextBoxColumn";
            this.lenPchDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pch2AchDataGridViewTextBoxColumn
            // 
            this.pch2AchDataGridViewTextBoxColumn.DataPropertyName = "Pch2Ach";
            this.pch2AchDataGridViewTextBoxColumn.HeaderText = "Pch2Ach";
            this.pch2AchDataGridViewTextBoxColumn.Name = "pch2AchDataGridViewTextBoxColumn";
            this.pch2AchDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // altAchDataGridViewTextBoxColumn
            // 
            this.altAchDataGridViewTextBoxColumn.DataPropertyName = "AltAch";
            this.altAchDataGridViewTextBoxColumn.HeaderText = "AltAch";
            this.altAchDataGridViewTextBoxColumn.Name = "altAchDataGridViewTextBoxColumn";
            this.altAchDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pchPerDataGridViewTextBoxColumn
            // 
            this.pchPerDataGridViewTextBoxColumn.DataPropertyName = "PchPer";
            this.pchPerDataGridViewTextBoxColumn.HeaderText = "PchPer";
            this.pchPerDataGridViewTextBoxColumn.Name = "pchPerDataGridViewTextBoxColumn";
            this.pchPerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // achAerAltDataGridViewTextBoxColumn
            // 
            this.achAerAltDataGridViewTextBoxColumn.DataPropertyName = "AchAerAlt";
            this.achAerAltDataGridViewTextBoxColumn.HeaderText = "AchAerAlt";
            this.achAerAltDataGridViewTextBoxColumn.Name = "achAerAltDataGridViewTextBoxColumn";
            this.achAerAltDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // classifiedShapeBindingSource
            // 
            this.classifiedShapeBindingSource.DataSource = typeof(shape_recognizer.ClassifiedShape);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBoxShapeClass);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(392, 169);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 100);
            this.panel1.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(167, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBoxShapeClass
            // 
            this.comboBoxShapeClass.FormattingEnabled = true;
            this.comboBoxShapeClass.Location = new System.Drawing.Point(4, 47);
            this.comboBoxShapeClass.Name = "comboBoxShapeClass";
            this.comboBoxShapeClass.Size = new System.Drawing.Size(121, 21);
            this.comboBoxShapeClass.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 401);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelCHPerimeterValue);
            this.Controls.Add(this.labelCHPerimeter);
            this.Controls.Add(this.labelConvHullPntCntVal);
            this.Controls.Add(this.labelConvHullPntCnt);
            this.Controls.Add(this.labelShapePointCountVal);
            this.Controls.Add(this.labelShapePointCount);
            this.Controls.Add(this.labelPoint);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.graphPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 768);
            this.MinimumSize = new System.Drawing.Size(900, 440);
            this.Name = "Form1";
            this.Text = "Shape Recognizer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classifiedShapeBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn shapeClassDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lenPchDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pch2AchDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn altAchDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pchPerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn achAerAltDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource classifiedShapeBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxShapeClass;
        private System.Windows.Forms.Button button1;
    }
}

