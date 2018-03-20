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
            this.graphPanel = new System.Windows.Forms.Panel();
            this.buttonClear = new System.Windows.Forms.Button();
            this.labelPoint = new System.Windows.Forms.Label();
            this.labelShapePointCount = new System.Windows.Forms.Label();
            this.labelShapePointCountVal = new System.Windows.Forms.Label();
            this.labelConvHullPntCnt = new System.Windows.Forms.Label();
            this.labelConvHullPntCntVal = new System.Windows.Forms.Label();
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
            this.buttonClear.Location = new System.Drawing.Point(158, 311);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 381);
            this.Controls.Add(this.labelConvHullPntCntVal);
            this.Controls.Add(this.labelConvHullPntCnt);
            this.Controls.Add(this.labelShapePointCountVal);
            this.Controls.Add(this.labelShapePointCount);
            this.Controls.Add(this.labelPoint);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.graphPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(420, 420);
            this.MinimumSize = new System.Drawing.Size(420, 420);
            this.Name = "Form1";
            this.Text = "Shape Recognizer";
            this.Load += new System.EventHandler(this.Form1_Load);
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
    }
}

