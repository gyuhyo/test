namespace book
{
    partial class rentDetail
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.detaillst = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.booklst = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detaillst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booklst)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.detaillst);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.booklst);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(745, 501);
            this.panel3.TabIndex = 5;
            // 
            // detaillst
            // 
            this.detaillst.AllowUserToAddRows = false;
            this.detaillst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detaillst.Location = new System.Drawing.Point(12, 273);
            this.detaillst.Name = "detaillst";
            this.detaillst.ReadOnly = true;
            this.detaillst.RowHeadersVisible = false;
            this.detaillst.RowTemplate.Height = 23;
            this.detaillst.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.detaillst.Size = new System.Drawing.Size(721, 216);
            this.detaillst.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(330, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "전체 도서 목록을 검색할 경우 텍스트를 비워주세요.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "도 서 명 : ";
            // 
            // booklst
            // 
            this.booklst.AllowUserToAddRows = false;
            this.booklst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.booklst.Location = new System.Drawing.Point(12, 40);
            this.booklst.Name = "booklst";
            this.booklst.ReadOnly = true;
            this.booklst.RowHeadersVisible = false;
            this.booklst.RowTemplate.Height = 23;
            this.booklst.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.booklst.Size = new System.Drawing.Size(721, 216);
            this.booklst.TabIndex = 11;
            this.booklst.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.booklst_CellClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(249, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "검 색";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(83, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(160, 21);
            this.textBox1.TabIndex = 9;
            // 
            // rentDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 501);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "rentDetail";
            this.Text = "rentDetail";
            this.Load += new System.EventHandler(this.rentDetail_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detaillst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booklst)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView booklst;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView detaillst;
    }
}