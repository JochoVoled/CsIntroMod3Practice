namespace CsIntroMod3Practice
{
    partial class MainForm
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.numPoints = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmdShow = new System.Windows.Forms.Button();
            this.cmdCalcPoint = new System.Windows.Forms.Button();
            this.cmdCalc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numPoints)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(119, 15);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(204, 22);
            this.txtName.TabIndex = 0;
            // 
            // dateStart
            // 
            this.dateStart.CustomFormat = "dd-MM-yyyy";
            this.dateStart.Location = new System.Drawing.Point(119, 79);
            this.dateStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(204, 22);
            this.dateStart.TabIndex = 2;
            this.dateStart.Value = new System.DateTime(2016, 9, 14, 10, 45, 49, 0);
            // 
            // dateEnd
            // 
            this.dateEnd.CustomFormat = "dd-MM-yyyy";
            this.dateEnd.Location = new System.Drawing.Point(119, 111);
            this.dateEnd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(204, 22);
            this.dateEnd.TabIndex = 3;
            this.dateEnd.Value = new System.DateTime(2016, 9, 14, 10, 45, 43, 0);
            // 
            // numPoints
            // 
            this.numPoints.Location = new System.Drawing.Point(119, 47);
            this.numPoints.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numPoints.Name = "numPoints";
            this.numPoints.Size = new System.Drawing.Size(205, 22);
            this.numPoints.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(20, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Course Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(67, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Points";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(41, 87);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Start Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(45, 118);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "End Date";
            // 
            // cmdShow
            // 
            this.cmdShow.Location = new System.Drawing.Point(-1, 150);
            this.cmdShow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdShow.Name = "cmdShow";
            this.cmdShow.Size = new System.Drawing.Size(100, 28);
            this.cmdShow.TabIndex = 9;
            this.cmdShow.Text = "Show";
            this.cmdShow.UseVisualStyleBackColor = true;
            this.cmdShow.Click += new System.EventHandler(this.cmdShow_Click);
            // 
            // cmdCalcPoint
            // 
            this.cmdCalcPoint.Location = new System.Drawing.Point(107, 150);
            this.cmdCalcPoint.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdCalcPoint.Name = "cmdCalcPoint";
            this.cmdCalcPoint.Size = new System.Drawing.Size(120, 28);
            this.cmdCalcPoint.TabIndex = 10;
            this.cmdCalcPoint.Text = "Calculate Points";
            this.cmdCalcPoint.UseVisualStyleBackColor = true;
            this.cmdCalcPoint.Click += new System.EventHandler(this.cmdCalcPoint_Click);
            // 
            // cmdCalc
            // 
            this.cmdCalc.Location = new System.Drawing.Point(238, 150);
            this.cmdCalc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdCalc.Name = "cmdCalc";
            this.cmdCalc.Size = new System.Drawing.Size(112, 28);
            this.cmdCalc.TabIndex = 11;
            this.cmdCalc.Text = "Calculate days";
            this.cmdCalc.UseVisualStyleBackColor = true;
            this.cmdCalc.Click += new System.EventHandler(this.cmdCalc_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 197);
            this.Controls.Add(this.cmdCalc);
            this.Controls.Add(this.cmdCalcPoint);
            this.Controls.Add(this.cmdShow);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numPoints);
            this.Controls.Add(this.dateEnd);
            this.Controls.Add(this.dateStart);
            this.Controls.Add(this.txtName);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "Create Course";
            ((System.ComponentModel.ISupportInitialize)(this.numPoints)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.Windows.Forms.NumericUpDown numPoints;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cmdShow;
        private System.Windows.Forms.Button cmdCalcPoint;
        private System.Windows.Forms.Button cmdCalc;
    }
}

