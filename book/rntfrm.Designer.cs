namespace book
{
    partial class rntfrm
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
            this.insbtn = new System.Windows.Forms.Label();
            this.updbtn = new System.Windows.Forms.Label();
            this.delbtn = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bcnt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbookinfo = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.rstuinfo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.rcnt = new System.Windows.Forms.NumericUpDown();
            this.rrdate = new System.Windows.Forms.DateTimePicker();
            this.rpdate = new System.Windows.Forms.DateTimePicker();
            this.rdate = new System.Windows.Forms.DateTimePicker();
            this.label20 = new System.Windows.Forms.Label();
            this.risbn = new System.Windows.Forms.TextBox();
            this.rnum = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.shrsname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.shrsnum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.shrbname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.shrbisbn = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.cancelbtn = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rcnt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // insbtn
            // 
            this.insbtn.AutoSize = true;
            this.insbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.insbtn.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.insbtn.Location = new System.Drawing.Point(559, 9);
            this.insbtn.Name = "insbtn";
            this.insbtn.Size = new System.Drawing.Size(39, 17);
            this.insbtn.TabIndex = 0;
            this.insbtn.Text = "등 록";
            this.insbtn.Click += new System.EventHandler(this.insbtn_Click);
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
            this.updbtn.TabIndex = 1;
            this.updbtn.Text = "수 정";
            this.updbtn.Click += new System.EventHandler(this.updbtn_Click);
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
            this.delbtn.TabIndex = 2;
            this.delbtn.Text = "삭 제";
            this.delbtn.Click += new System.EventHandler(this.delbtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.bcnt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rbookinfo);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.rstuinfo);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.rcnt);
            this.groupBox1.Controls.Add(this.rrdate);
            this.groupBox1.Controls.Add(this.rpdate);
            this.groupBox1.Controls.Add(this.rdate);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.risbn);
            this.groupBox1.Controls.Add(this.rnum);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Location = new System.Drawing.Point(3, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 298);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "대여정보";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new System.Drawing.Point(77, 270);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(48, 16);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "반납";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 24;
            this.label2.Text = "권";
            // 
            // bcnt
            // 
            this.bcnt.Enabled = false;
            this.bcnt.Location = new System.Drawing.Point(77, 139);
            this.bcnt.Name = "bcnt";
            this.bcnt.Size = new System.Drawing.Size(59, 21);
            this.bcnt.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 22;
            this.label1.Text = "대여 가능";
            // 
            // rbookinfo
            // 
            this.rbookinfo.Enabled = false;
            this.rbookinfo.Location = new System.Drawing.Point(77, 107);
            this.rbookinfo.Name = "rbookinfo";
            this.rbookinfo.Size = new System.Drawing.Size(191, 21);
            this.rbookinfo.TabIndex = 21;
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Location = new System.Drawing.Point(211, 78);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(57, 22);
            this.button3.TabIndex = 1;
            this.button3.Text = "검 색";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // rstuinfo
            // 
            this.rstuinfo.Enabled = false;
            this.rstuinfo.Location = new System.Drawing.Point(77, 48);
            this.rstuinfo.Name = "rstuinfo";
            this.rstuinfo.Size = new System.Drawing.Size(191, 21);
            this.rstuinfo.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(211, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 22);
            this.button1.TabIndex = 0;
            this.button1.Text = "검 색";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rcnt
            // 
            this.rcnt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rcnt.Location = new System.Drawing.Point(77, 171);
            this.rcnt.Name = "rcnt";
            this.rcnt.Size = new System.Drawing.Size(191, 21);
            this.rcnt.TabIndex = 2;
            // 
            // rrdate
            // 
            this.rrdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rrdate.Enabled = false;
            this.rrdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.rrdate.Location = new System.Drawing.Point(131, 267);
            this.rrdate.Name = "rrdate";
            this.rrdate.Size = new System.Drawing.Size(137, 21);
            this.rrdate.TabIndex = 6;
            // 
            // rpdate
            // 
            this.rpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rpdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.rpdate.Location = new System.Drawing.Point(77, 235);
            this.rpdate.Name = "rpdate";
            this.rpdate.Size = new System.Drawing.Size(191, 21);
            this.rpdate.TabIndex = 4;
            this.rpdate.ValueChanged += new System.EventHandler(this.rpdate_ValueChanged);
            // 
            // rdate
            // 
            this.rdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.rdate.Location = new System.Drawing.Point(77, 203);
            this.rdate.Name = "rdate";
            this.rdate.Size = new System.Drawing.Size(191, 21);
            this.rdate.TabIndex = 3;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(30, 207);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(41, 12);
            this.label20.TabIndex = 14;
            this.label20.Text = "대여일";
            // 
            // risbn
            // 
            this.risbn.Enabled = false;
            this.risbn.Location = new System.Drawing.Point(77, 79);
            this.risbn.Name = "risbn";
            this.risbn.Size = new System.Drawing.Size(128, 21);
            this.risbn.TabIndex = 6;
            // 
            // rnum
            // 
            this.rnum.Enabled = false;
            this.rnum.Location = new System.Drawing.Point(77, 20);
            this.rnum.Name = "rnum";
            this.rnum.Size = new System.Drawing.Size(128, 21);
            this.rnum.TabIndex = 5;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(30, 271);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(41, 12);
            this.label18.TabIndex = 4;
            this.label18.Text = "반납일";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 239);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 12);
            this.label17.TabIndex = 3;
            this.label17.Text = "반납예정일";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(14, 174);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(57, 12);
            this.label16.TabIndex = 2;
            this.label16.Text = "대여 권수";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(38, 83);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(33, 12);
            this.label15.TabIndex = 1;
            this.label15.Text = "ISBN";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(42, 24);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 12);
            this.label14.TabIndex = 0;
            this.label14.Text = "학번";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(283, 175);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(450, 314);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Controls.Add(this.cancelbtn);
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.delbtn);
            this.panel3.Controls.Add(this.updbtn);
            this.panel3.Controls.Add(this.insbtn);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(745, 501);
            this.panel3.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.shrsname);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.shrsnum);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.shrbname);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.shrbisbn);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Location = new System.Drawing.Point(283, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(450, 111);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "검색 조건";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(202, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 24;
            this.label3.Text = "이름";
            // 
            // shrsname
            // 
            this.shrsname.Location = new System.Drawing.Point(237, 19);
            this.shrsname.Name = "shrsname";
            this.shrsname.Size = new System.Drawing.Size(98, 21);
            this.shrsname.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 22;
            this.label5.Text = "학번";
            // 
            // shrsnum
            // 
            this.shrsnum.Location = new System.Drawing.Point(52, 19);
            this.shrsnum.Name = "shrsnum";
            this.shrsnum.Size = new System.Drawing.Size(108, 21);
            this.shrsnum.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(190, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 20;
            this.label6.Text = "도서명";
            // 
            // shrbname
            // 
            this.shrbname.Location = new System.Drawing.Point(237, 50);
            this.shrbname.Name = "shrbname";
            this.shrbname.Size = new System.Drawing.Size(207, 21);
            this.shrbname.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 12);
            this.label4.TabIndex = 16;
            this.label4.Text = "ISBN";
            // 
            // shrbisbn
            // 
            this.shrbisbn.Location = new System.Drawing.Point(52, 50);
            this.shrbisbn.Name = "shrbisbn";
            this.shrbisbn.Size = new System.Drawing.Size(108, 21);
            this.shrbisbn.TabIndex = 14;
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Location = new System.Drawing.Point(324, 76);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 28);
            this.button4.TabIndex = 15;
            this.button4.Text = "검 색";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // cancelbtn
            // 
            this.cancelbtn.AutoSize = true;
            this.cancelbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelbtn.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cancelbtn.Location = new System.Drawing.Point(694, 9);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(39, 17);
            this.cancelbtn.TabIndex = 17;
            this.cancelbtn.Text = "취 소";
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // rntfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 501);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "rntfrm";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.rntfrm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rcnt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label insbtn;
        private System.Windows.Forms.Label updbtn;
        private System.Windows.Forms.Label delbtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown rcnt;
        private System.Windows.Forms.DateTimePicker rrdate;
        private System.Windows.Forms.DateTimePicker rpdate;
        private System.Windows.Forms.DateTimePicker rdate;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox risbn;
        public System.Windows.Forms.TextBox rnum;
        public System.Windows.Forms.TextBox rstuinfo;
        public System.Windows.Forms.TextBox rbookinfo;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox bcnt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label cancelbtn;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox shrbname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox shrbisbn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox shrsname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox shrsnum;
    }
}