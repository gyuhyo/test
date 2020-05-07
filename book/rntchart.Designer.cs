namespace book
{
    partial class rntchart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.firtstDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.SecondDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chartA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SecondDate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.firtstDate);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 54);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "검색 날짜";
            // 
            // firtstDate
            // 
            this.firtstDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.firtstDate.Location = new System.Drawing.Point(6, 20);
            this.firtstDate.Name = "firtstDate";
            this.firtstDate.Size = new System.Drawing.Size(110, 21);
            this.firtstDate.TabIndex = 0;
            this.firtstDate.ValueChanged += new System.EventHandler(this.firtstDate_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "~";
            // 
            // SecondDate
            // 
            this.SecondDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.SecondDate.Location = new System.Drawing.Point(142, 20);
            this.SecondDate.Name = "SecondDate";
            this.SecondDate.Size = new System.Drawing.Size(110, 21);
            this.SecondDate.TabIndex = 2;
            this.SecondDate.ValueChanged += new System.EventHandler(this.SecondDate_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chartA);
            this.groupBox2.Location = new System.Drawing.Point(12, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(721, 417);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CHART";
            // 
            // chartA
            // 
            chartArea2.Name = "ChartArea1";
            this.chartA.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartA.Legends.Add(legend2);
            this.chartA.Location = new System.Drawing.Point(6, 20);
            this.chartA.Name = "chartA";
            this.chartA.Size = new System.Drawing.Size(709, 391);
            this.chartA.TabIndex = 0;
            this.chartA.Text = "chart1";
            // 
            // rntchart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(745, 501);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "rntchart";
            this.Text = "rntchart";
            this.Load += new System.EventHandler(this.rntchart_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker SecondDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker firtstDate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartA;
    }
}