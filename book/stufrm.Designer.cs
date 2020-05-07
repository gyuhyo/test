namespace book
{
    partial class stufrm
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
            this.delbtn = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.updbtn = new System.Windows.Forms.Label();
            this.insbtn = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.otheraddr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.zipcode = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.spictxt = new System.Windows.Forms.TextBox();
            this.spic = new System.Windows.Forms.PictureBox();
            this.saddr = new System.Windows.Forms.TextBox();
            this.stel = new System.Windows.Forms.TextBox();
            this.sname = new System.Windows.Forms.TextBox();
            this.snum = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.shsname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.shsnum = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.cancelbtn = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spic)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // delbtn
            // 
            this.delbtn.AutoSize = true;
            this.delbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delbtn.Enabled = false;
            this.delbtn.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.delbtn.Location = new System.Drawing.Point(649, 9);
            this.delbtn.Name = "delbtn";
            this.delbtn.Size = new System.Drawing.Size(39, 17);
            this.delbtn.TabIndex = 19;
            this.delbtn.Text = "삭 제";
            this.delbtn.Click += new System.EventHandler(this.delbtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(283, 114);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(450, 375);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // updbtn
            // 
            this.updbtn.AutoSize = true;
            this.updbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updbtn.Enabled = false;
            this.updbtn.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.updbtn.Location = new System.Drawing.Point(604, 9);
            this.updbtn.Name = "updbtn";
            this.updbtn.Size = new System.Drawing.Size(39, 17);
            this.updbtn.TabIndex = 18;
            this.updbtn.Text = "수 정";
            this.updbtn.Click += new System.EventHandler(this.updbtn_Click);
            // 
            // insbtn
            // 
            this.insbtn.AutoSize = true;
            this.insbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.insbtn.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.insbtn.Location = new System.Drawing.Point(559, 9);
            this.insbtn.Name = "insbtn";
            this.insbtn.Size = new System.Drawing.Size(39, 17);
            this.insbtn.TabIndex = 17;
            this.insbtn.Text = "등 록";
            this.insbtn.Click += new System.EventHandler(this.insbtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.otheraddr);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.zipcode);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.spictxt);
            this.groupBox1.Controls.Add(this.spic);
            this.groupBox1.Controls.Add(this.saddr);
            this.groupBox1.Controls.Add(this.stel);
            this.groupBox1.Controls.Add(this.sname);
            this.groupBox1.Controls.Add(this.snum);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Location = new System.Drawing.Point(3, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 415);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "학생정보";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 12);
            this.label2.TabIndex = 18;
            this.label2.Text = "나머지 주소";
            // 
            // otheraddr
            // 
            this.otheraddr.Enabled = false;
            this.otheraddr.Location = new System.Drawing.Point(77, 181);
            this.otheraddr.Name = "otheraddr";
            this.otheraddr.Size = new System.Drawing.Size(191, 21);
            this.otheraddr.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 16;
            this.label1.Text = "주소";
            // 
            // zipcode
            // 
            this.zipcode.Enabled = false;
            this.zipcode.Location = new System.Drawing.Point(77, 126);
            this.zipcode.Name = "zipcode";
            this.zipcode.Size = new System.Drawing.Size(102, 21);
            this.zipcode.TabIndex = 15;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(185, 126);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(83, 22);
            this.button3.TabIndex = 14;
            this.button3.Text = "우편검색";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(31, 290);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(41, 12);
            this.label19.TabIndex = 13;
            this.label19.Text = "이미지";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(77, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "불러오기";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // spictxt
            // 
            this.spictxt.Enabled = false;
            this.spictxt.Location = new System.Drawing.Point(77, 355);
            this.spictxt.Name = "spictxt";
            this.spictxt.Size = new System.Drawing.Size(191, 21);
            this.spictxt.TabIndex = 11;
            // 
            // spic
            // 
            this.spic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.spic.Location = new System.Drawing.Point(77, 217);
            this.spic.Name = "spic";
            this.spic.Size = new System.Drawing.Size(191, 132);
            this.spic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.spic.TabIndex = 10;
            this.spic.TabStop = false;
            // 
            // saddr
            // 
            this.saddr.Enabled = false;
            this.saddr.Location = new System.Drawing.Point(77, 154);
            this.saddr.Name = "saddr";
            this.saddr.Size = new System.Drawing.Size(191, 21);
            this.saddr.TabIndex = 8;
            // 
            // stel
            // 
            this.stel.Location = new System.Drawing.Point(77, 92);
            this.stel.Name = "stel";
            this.stel.Size = new System.Drawing.Size(191, 21);
            this.stel.TabIndex = 7;
            // 
            // sname
            // 
            this.sname.Location = new System.Drawing.Point(77, 56);
            this.sname.Name = "sname";
            this.sname.Size = new System.Drawing.Size(191, 21);
            this.sname.TabIndex = 6;
            // 
            // snum
            // 
            this.snum.Location = new System.Drawing.Point(77, 20);
            this.snum.MaxLength = 9;
            this.snum.Name = "snum";
            this.snum.Size = new System.Drawing.Size(191, 21);
            this.snum.TabIndex = 5;
            this.snum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.snum_KeyPress);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(18, 129);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(53, 12);
            this.label17.TabIndex = 3;
            this.label17.Text = "우편번호";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(18, 95);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 12);
            this.label16.TabIndex = 2;
            this.label16.Text = "전화번호";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(42, 59);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 12);
            this.label15.TabIndex = 1;
            this.label15.Text = "이름";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(42, 23);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 12);
            this.label14.TabIndex = 0;
            this.label14.Text = "학번";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Controls.Add(this.cancelbtn);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.insbtn);
            this.panel3.Controls.Add(this.updbtn);
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Controls.Add(this.delbtn);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(745, 501);
            this.panel3.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.shsname);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.shsnum);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Location = new System.Drawing.Point(283, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(450, 50);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "검색 조건";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(182, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 20;
            this.label6.Text = "이름";
            // 
            // shsname
            // 
            this.shsname.Location = new System.Drawing.Point(217, 18);
            this.shsname.Name = "shsname";
            this.shsname.Size = new System.Drawing.Size(98, 21);
            this.shsname.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 16;
            this.label4.Text = "학번";
            // 
            // shsnum
            // 
            this.shsnum.Location = new System.Drawing.Point(49, 18);
            this.shsnum.Name = "shsnum";
            this.shsnum.Size = new System.Drawing.Size(108, 21);
            this.shsnum.TabIndex = 14;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(324, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 28);
            this.button2.TabIndex = 15;
            this.button2.Text = "검 색";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cancelbtn
            // 
            this.cancelbtn.AutoSize = true;
            this.cancelbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelbtn.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cancelbtn.Location = new System.Drawing.Point(694, 9);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(39, 17);
            this.cancelbtn.TabIndex = 25;
            this.cancelbtn.Text = "취 소";
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // stufrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 501);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "stufrm";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spic)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label delbtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label updbtn;
        private System.Windows.Forms.Label insbtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox spictxt;
        private System.Windows.Forms.PictureBox spic;
        private System.Windows.Forms.TextBox stel;
        private System.Windows.Forms.TextBox sname;
        private System.Windows.Forms.TextBox snum;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label cancelbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.TextBox saddr;
        public System.Windows.Forms.TextBox otheraddr;
        public System.Windows.Forms.TextBox zipcode;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox shsname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox shsnum;
        private System.Windows.Forms.Button button2;
    }
}