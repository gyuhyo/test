using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace book
{
    public partial class mainfrm : Form
    {
        bookfrm f1;
        rntfrm f3;
        stufrm f2;
        returnbook f4;
        rentDetail f5;
        rntchart f6;

        public mainfrm()
        {
            InitializeComponent();
            
        }
        private Point mousePoint;

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if ((formIsExist(typeof(stufrm)) == null))
            {
                f2 = new stufrm();
                f2.TopLevel = false;
                f2.TopMost = true;
                panel3.Controls.Add(f2);
                f2.Show();
                f2.BringToFront();
            }
            else
            {
                f2.BringToFront();
            }
            label2.ForeColor = Color.White;
            label3.ForeColor = Color.Black;
            label4.ForeColor = Color.White;
            label9.ForeColor = Color.White;
            label10.ForeColor = Color.White;
            label11.ForeColor = Color.White;
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y);
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                this.Location = new Point(this.Left - (mousePoint.X - e.X),
                    this.Top - (mousePoint.Y - e.Y));
            }
        }

        private Form formIsExist(Type tp)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == tp)
                {
                    return form;
                }
            }
            return null;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if ((formIsExist(typeof(bookfrm)) == null))
            {
                f1 = new bookfrm();
                f1.TopLevel = false;
                f1.TopMost = true;
                panel3.Controls.Add(f1);
                f1.Show();
                f1.BringToFront();
            }
            else
            {
                f1.BringToFront();
            }
            label3.ForeColor = Color.White;
            label2.ForeColor = Color.Black;
            label4.ForeColor = Color.White;
            label9.ForeColor = Color.White;
            label10.ForeColor = Color.White;
            label11.ForeColor = Color.White;

        }

        private void label4_Click(object sender, EventArgs e)
        {
            if ((formIsExist(typeof(rntfrm)) == null))
            {
                f3 = new rntfrm();
                f3.TopLevel = false;
                f3.TopMost = true;
                panel3.Controls.Add(f3);
                f3.Show();
                f3.BringToFront();
            }
            else
            {
                f3.BringToFront();
            }
            label3.ForeColor = Color.White;
            label4.ForeColor = Color.Black;
            label2.ForeColor = Color.White;
            label9.ForeColor = Color.White;
            label10.ForeColor = Color.White;
            label11.ForeColor = Color.White;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mainfrm_Load(object sender, EventArgs e)
        {
            f1 = new bookfrm();
            f1.TopLevel = false;
            f1.TopMost = true;
            panel3.Controls.Add(f1);
            f1.Show();
            f1.BringToFront();

            label3.ForeColor = Color.White;
            label2.ForeColor = Color.Black;
            label4.ForeColor = Color.White;
            label9.ForeColor = Color.White;
            label10.ForeColor = Color.White;
            label11.ForeColor = Color.White;
        }

        void sql_memo()
        {
            /*
            create table bookinfo(
            bookisbn char(13) primary key,
            bookname varchar(20),
            bookperson varchar(100),
            bookcompany varchar(30),
            bookprice int,
            bookcnt int,
            bookdate char(10),
            bookpic varchar(50));
            */

            /*
            create table stuinfo(
            stunum char(9) primary key,
            stuname varchar(20),
            stutel varchar(11),
            stuaddr varchar(50),
            stupic varchar(50));
            */

            /*
            create table rntinfo(
            rntdate char(10),
            rntnum char(9),
            rntisbn char(13),
            rntcnt int,
            rntpdate char(10),
            rntrdate char(10),
            sysdate char(19) not null);
            */
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                this.Location = new Point(this.Left - (mousePoint.X - e.X),
                    this.Top - (mousePoint.Y - e.Y));
            }
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y);
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                this.Location = new Point(this.Left - (mousePoint.X - e.X),
                    this.Top - (mousePoint.Y - e.Y));
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            if ((formIsExist(typeof(returnbook)) == null))
            {
                f4 = new returnbook();
                f4.TopLevel = false;
                f4.TopMost = true;
                panel3.Controls.Add(f4);
                f4.Show();
                f4.BringToFront();
            }
            else
            {
                f4.BringToFront();
            }
            label3.ForeColor = Color.White;
            label4.ForeColor = Color.White;
            label2.ForeColor = Color.White;
            label9.ForeColor = Color.Black;
            label10.ForeColor = Color.White;
            label11.ForeColor = Color.White;
        }

        private void label10_Click(object sender, EventArgs e)
        {
            if ((formIsExist(typeof(rentDetail)) == null))
            {
                f5 = new rentDetail();
                f5.TopLevel = false;
                f5.TopMost = true;
                panel3.Controls.Add(f5);
                f5.Show();
                f5.BringToFront();
            }
            else
            {
                f5.BringToFront();
            }
            label3.ForeColor = Color.White;
            label4.ForeColor = Color.White;
            label2.ForeColor = Color.White;
            label9.ForeColor = Color.White;
            label10.ForeColor = Color.Black;
            label11.ForeColor = Color.White;
        }

        private void label11_Click(object sender, EventArgs e)
        {
            if ((formIsExist(typeof(rntchart)) == null))
            {
                f6 = new rntchart();
                f6.TopLevel = false;
                f6.TopMost = true;
                panel3.Controls.Add(f6);
                f6.Show();
                f6.BringToFront();
            }
            else
            {
                f6.BringToFront();
            }
            label3.ForeColor = Color.White;
            label4.ForeColor = Color.White;
            label2.ForeColor = Color.White;
            label9.ForeColor = Color.White;
            label10.ForeColor = Color.White;
            label11.ForeColor = Color.Black;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
