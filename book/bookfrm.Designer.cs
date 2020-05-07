namespace book
{
    partial class bookfrm
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
            this.cancelbtn = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.shbisbn = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.bdeldate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.bindate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.bplace = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.bcnt = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.bdate = new System.Windows.Forms.DateTimePicker();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.bpictxt = new System.Windows.Forms.TextBox();
            this.bpic = new System.Windows.Forms.PictureBox();
            this.bprice = new System.Windows.Forms.TextBox();
            this.bperson = new System.Windows.Forms.TextBox();
            this.bisbn = new System.Windows.Forms.TextBox();
            this.bcompany = new System.Windows.Forms.TextBox();
            this.bname = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.delbtn = new System.Windows.Forms.Label();
            this.updbtn = new System.Windows.Forms.Label();
            this.insbtn = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.shbcomp = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.shbname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.shbps = new System.Windows.Forms.TextBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bcnt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bpic)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
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
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(745, 501);
            this.panel3.TabIndex = 3;
            // 
            // cancelbtn
            // 
            this.cancelbtn.AutoSize = true;
            this.cancelbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelbtn.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cancelbtn.Location = new System.Drawing.Point(694, 9);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(39, 17);
            this.cancelbtn.TabIndex = 18;
            this.cancelbtn.Text = "취 소";
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(324, 74);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 28);
            this.button2.TabIndex = 15;
            this.button2.Text = "검 색";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // shbisbn
            // 
            this.shbisbn.Location = new System.Drawing.Point(53, 17);
            this.shbisbn.Name = "shbisbn";
            this.shbisbn.Size = new System.Drawing.Size(108, 21);
            this.shbisbn.TabIndex = 14;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(283, 146);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(450, 343);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.bdeldate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.bindate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.bplace);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.bcnt);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.bdate);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.bpictxt);
            this.groupBox1.Controls.Add(this.bpic);
            this.groupBox1.Controls.Add(this.bprice);
            this.groupBox1.Controls.Add(this.bperson);
            this.groupBox1.Controls.Add(this.bisbn);
            this.groupBox1.Controls.Add(this.bcompany);
            this.groupBox1.Controls.Add(this.bname);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Location = new System.Drawing.Point(3, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 476);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "도서정보";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new System.Drawing.Point(77, 266);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(48, 16);
            this.checkBox1.TabIndex = 24;
            this.checkBox1.Text = "폐기";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // bdeldate
            // 
            this.bdeldate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bdeldate.Enabled = false;
            this.bdeldate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.bdeldate.Location = new System.Drawing.Point(127, 263);
            this.bdeldate.Name = "bdeldate";
            this.bdeldate.Size = new System.Drawing.Size(141, 21);
            this.bdeldate.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 23;
            this.label3.Text = "폐기일";
            // 
            // bindate
            // 
            this.bindate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bindate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.bindate.Location = new System.Drawing.Point(77, 236);
            this.bindate.Name = "bindate";
            this.bindate.Size = new System.Drawing.Size(191, 21);
            this.bindate.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 21;
            this.label2.Text = "입고일";
            // 
            // bplace
            // 
            this.bplace.Location = new System.Drawing.Point(77, 209);
            this.bplace.Name = "bplace";
            this.bplace.Size = new System.Drawing.Size(191, 21);
            this.bplace.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 18;
            this.label1.Text = "소장 위치";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(193, 20);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 21);
            this.button3.TabIndex = 17;
            this.button3.Text = "도서 검색";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // bcnt
            // 
            this.bcnt.Location = new System.Drawing.Point(77, 182);
            this.bcnt.Name = "bcnt";
            this.bcnt.Size = new System.Drawing.Size(191, 21);
            this.bcnt.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 186);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 16;
            this.label9.Text = "재고량";
            // 
            // bdate
            // 
            this.bdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bdate.Enabled = false;
            this.bdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.bdate.Location = new System.Drawing.Point(77, 101);
            this.bdate.Name = "bdate";
            this.bdate.Size = new System.Drawing.Size(191, 21);
            this.bdate.TabIndex = 8;
            this.bdate.ValueChanged += new System.EventHandler(this.bdate_ValueChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(30, 106);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(41, 12);
            this.label20.TabIndex = 14;
            this.label20.Text = "출판일";
            this.label20.Click += new System.EventHandler(this.label20_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(30, 377);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(41, 12);
            this.label19.TabIndex = 13;
            this.label19.Text = "이미지";
            // 
            // bpictxt
            // 
            this.bpictxt.Enabled = false;
            this.bpictxt.Location = new System.Drawing.Point(77, 441);
            this.bpictxt.Name = "bpictxt";
            this.bpictxt.Size = new System.Drawing.Size(191, 21);
            this.bpictxt.TabIndex = 11;
            // 
            // bpic
            // 
            this.bpic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bpic.Location = new System.Drawing.Point(77, 301);
            this.bpic.Name = "bpic";
            this.bpic.Size = new System.Drawing.Size(191, 134);
            this.bpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bpic.TabIndex = 10;
            this.bpic.TabStop = false;
            // 
            // bprice
            // 
            this.bprice.Enabled = false;
            this.bprice.Location = new System.Drawing.Point(77, 155);
            this.bprice.Name = "bprice";
            this.bprice.Size = new System.Drawing.Size(191, 21);
            this.bprice.TabIndex = 9;
            this.bprice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bprice_KeyPress);
            // 
            // bperson
            // 
            this.bperson.Enabled = false;
            this.bperson.Location = new System.Drawing.Point(77, 128);
            this.bperson.Name = "bperson";
            this.bperson.Size = new System.Drawing.Size(191, 21);
            this.bperson.TabIndex = 8;
            // 
            // bisbn
            // 
            this.bisbn.Enabled = false;
            this.bisbn.Location = new System.Drawing.Point(77, 74);
            this.bisbn.MaxLength = 13;
            this.bisbn.Name = "bisbn";
            this.bisbn.Size = new System.Drawing.Size(191, 21);
            this.bisbn.TabIndex = 7;
            // 
            // bcompany
            // 
            this.bcompany.Enabled = false;
            this.bcompany.Location = new System.Drawing.Point(77, 47);
            this.bcompany.Name = "bcompany";
            this.bcompany.Size = new System.Drawing.Size(191, 21);
            this.bcompany.TabIndex = 6;
            // 
            // bname
            // 
            this.bname.Enabled = false;
            this.bname.Location = new System.Drawing.Point(77, 20);
            this.bname.Name = "bname";
            this.bname.Size = new System.Drawing.Size(110, 21);
            this.bname.TabIndex = 5;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(42, 160);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(29, 12);
            this.label18.TabIndex = 4;
            this.label18.Text = "가격";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(42, 133);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(29, 12);
            this.label17.TabIndex = 3;
            this.label17.Text = "저자";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(38, 80);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(33, 12);
            this.label16.TabIndex = 2;
            this.label16.Text = "ISBN";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(30, 52);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 12);
            this.label15.TabIndex = 1;
            this.label15.Text = "출판사";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(30, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 12);
            this.label14.TabIndex = 0;
            this.label14.Text = "도서명";
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.shbps);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.shbname);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.shbcomp);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.shbisbn);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Location = new System.Drawing.Point(283, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(450, 111);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "검색 조건";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 12);
            this.label4.TabIndex = 16;
            this.label4.Text = "ISBN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 18;
            this.label5.Text = "출판사";
            // 
            // shbcomp
            // 
            this.shbcomp.Location = new System.Drawing.Point(53, 44);
            this.shbcomp.Name = "shbcomp";
            this.shbcomp.Size = new System.Drawing.Size(108, 21);
            this.shbcomp.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(190, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 20;
            this.label6.Text = "도서명";
            // 
            // shbname
            // 
            this.shbname.Location = new System.Drawing.Point(237, 17);
            this.shbname.Name = "shbname";
            this.shbname.Size = new System.Drawing.Size(207, 21);
            this.shbname.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(202, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 22;
            this.label7.Text = "저자";
            // 
            // shbps
            // 
            this.shbps.Location = new System.Drawing.Point(237, 47);
            this.shbps.Name = "shbps";
            this.shbps.Size = new System.Drawing.Size(207, 21);
            this.shbps.TabIndex = 21;
            // 
            // bookfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 501);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "bookfrm";
            this.Text = "bookfrm";
            this.Load += new System.EventHandler(this.bookfrm_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bcnt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bpic)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox shbisbn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label delbtn;
        private System.Windows.Forms.Label updbtn;
        private System.Windows.Forms.Label insbtn;
        private System.Windows.Forms.NumericUpDown bcnt;
        private System.Windows.Forms.Label cancelbtn;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.DateTimePicker bdate;
        public System.Windows.Forms.TextBox bprice;
        public System.Windows.Forms.TextBox bperson;
        public System.Windows.Forms.TextBox bisbn;
        public System.Windows.Forms.TextBox bcompany;
        public System.Windows.Forms.TextBox bname;
        public System.Windows.Forms.TextBox bpictxt;
        public System.Windows.Forms.PictureBox bpic;
        public System.Windows.Forms.TextBox bplace;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DateTimePicker bindate;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DateTimePicker bdeldate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox shbps;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox shbname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox shbcomp;
        private System.Windows.Forms.Label label4;
    }
}