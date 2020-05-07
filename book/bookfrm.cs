using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.IO;
using System.Net;
using static System.IO.Directory;

namespace book
{
    public partial class bookfrm : Form
    {
        private static string mysql_str = "server=203.227.206.254;port=3306;Database=p201987062;Uid=p201987062;Pwd=pp201987062;Charset=utf8"; // 데이터베이스 접속
        MySqlConnection conn = new MySqlConnection(mysql_str);
        MySqlCommand query;
        MySqlDataReader reader;
        string rdefined;

        public bookfrm()
        {
            InitializeComponent();
        }

        private void bookfrm_Load(object sender, EventArgs e)
        {

            conn.Open();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SearchBook(false, "");
        }

        void SearchBook(Boolean bcheck, string defined)
        {
            string Sql;

            if (bcheck == true)
            {
                Sql = "select * from bookinfo where bookisbn = @chkisbn"; // 중복 체크 할 경우 isbn 으로 검사
                if (reader != null) { reader.Close(); }
                query = new MySqlCommand();
                query.Connection = conn;
                query.CommandText = Sql;
                query.Prepare();
                query.Parameters.AddWithValue("@chkisbn", bisbn.Text);
            }
            else
            {
                Sql = " select a.*, ifnull(rntsum, 0) as rntsum from (select * from bookinfo " +
                      " where bookname like @shbname " +
                      " and bookcompany like @shbcomp" +
                      " and bookisbn like @shbisbn" +
                      " and bookperson like @shbps" +
                      " ) as a left join " +
                      " (select rntisbn, sum(rntcnt) as rntsum from rntinfo where rntrdate is null group by rntisbn) b " +
                      " on a.bookisbn = b.rntisbn ";

                if (reader != null) { reader.Close(); }

                query = new MySqlCommand();
                query.Connection = conn;
                query.CommandText = Sql;
                query.Prepare();
                query.Parameters.AddWithValue("@shbname", "%" + shbname.Text + "%");
                query.Parameters.AddWithValue("@shbcomp", "%" + shbcomp.Text + "%");
                query.Parameters.AddWithValue("@shbisbn", "%" + shbisbn.Text + "%");
                query.Parameters.AddWithValue("@shbps", "%" + shbps.Text + "%");
            }

            reader = query.ExecuteReader();
           
          
            if (defined == "yes") // 중복 체크 여부 결정
            {
                if (reader.Read())
                {
                    rdefined = "yes"; // 중복
 
                }
                else
                {
                    rdefined = "no"; // 중복 아님
                }
            }
            else
            {
                result_gird(); // 그리드뷰에 값들을 넣을 함수 호출
            }
        }

        void result_gird()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("bisbn", "isbn");
            dataGridView1.Columns.Add("bname", "도서명");
            dataGridView1.Columns.Add("bperson", "저자");
            dataGridView1.Columns.Add("bcompany", "출판사");
            dataGridView1.Columns.Add("bprice", "가격");
            dataGridView1.Columns.Add("bdate", "출판일");
            dataGridView1.Columns.Add("bindate", "입고일");
            dataGridView1.Columns.Add("bdeldate", "폐기일");
            dataGridView1.Columns.Add("bplace", "소장위치");
            dataGridView1.Columns.Add("bcnt", "입고량");
            dataGridView1.Columns.Add("rcnt", "대여중");
            dataGridView1.Columns.Add("rcnt", "잔여량");
            dataGridView1.Columns.Add("bimg", "이미지");

            int i = 0;

            while (reader.Read())
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = reader["bookisbn"].ToString();
                dataGridView1.Rows[i].Cells[1].Value = reader["bookname"].ToString();
                dataGridView1.Rows[i].Cells[2].Value = reader["bookperson"].ToString();
                dataGridView1.Rows[i].Cells[3].Value = reader["bookcompany"].ToString();
                dataGridView1.Rows[i].Cells[4].Value = reader["bookprice"].ToString();
                dataGridView1.Rows[i].Cells[5].Value = reader["bookdate"].ToString();
                dataGridView1.Rows[i].Cells[6].Value = reader["bookindate"].ToString();
                dataGridView1.Rows[i].Cells[7].Value = reader["bookdeldate"].ToString();
                dataGridView1.Rows[i].Cells[8].Value = reader["bookplace"].ToString();
                dataGridView1.Rows[i].Cells[9].Value = reader["bookcnt"].ToString();
                dataGridView1.Rows[i].Cells[10].Value = reader["rntsum"].ToString();
                dataGridView1.Rows[i].Cells[11].Value = (reader["bookdeldate"].ToString() == "") ? Convert.ToInt16(reader["bookcnt"].ToString()) - Convert.ToInt16(reader["rntsum"].ToString()) : 0;
                dataGridView1.Rows[i].Cells[12].Value = reader["bookpic"].ToString();

                i++;
            }
            //dataGridView1.Columns[1].Frozen = true;
            dataGridView1.Columns[12].Visible = false;
            reader.Close();
        }

        private void insbtn_Click(object sender, EventArgs e)
        {
            if (bname.Text == "")
            {
                MessageBox.Show("도서명을 입력해주세요.");
                return;
            }

            if (bcompany.Text == "")
            {
                MessageBox.Show("출판사를 입력해주세요.");
                return;
            }

            if (bisbn.Text == "")
            {
                MessageBox.Show("ISBN을 입력해주세요.");
                return;
            }

            if (bisbn.TextLength != 13)
            {
                MessageBox.Show("ISBN이 13자리가 아닙니다.");
                return;
            }

            if (bdate.Text == "")
            {
                MessageBox.Show("출판일을 입력해주세요.");
                return;
            }

            if (bperson.Text == "")
            {
                MessageBox.Show("저자를 입력해주세요.");
                return;
            }

            if (bprice.Text == "")
            {
                MessageBox.Show("가격을 입력해주세요.");
                return;
            }

            if (bcnt.Value == 0)
            {
                MessageBox.Show("재고량이 [0] 입니다.");
                return;
            }

            if (bplace.Text == "")
            {
                MessageBox.Show("소장 위치가 없습니다.");
                return;
            }

            if (bpictxt.Text == "")
            {
                MessageBox.Show("도서 이미지가 없습니다.");
                return;
            }

            string Sql = "insert into bookinfo values(@bisbn, @bname, @bperson, @bcompany, @bprice, @bplace, @bcnt, @bdate, @bindate, @bdeldate, @bpictxt)";

            SearchBook(true, "yes"); // 중복 검사 함수 호출

            if (reader != null) { reader.Close(); }

            if (rdefined == "no") // 중복이 없을 경우
            {
                query = new MySqlCommand();
                query.Connection = conn;
                query.CommandText = Sql;
                query.Prepare();
                query.Parameters.AddWithValue("@bisbn", bisbn.Text);
                query.Parameters.AddWithValue("@bname", bname.Text);
                query.Parameters.AddWithValue("@bperson", bperson.Text);
                query.Parameters.AddWithValue("@bcompany", bcompany.Text);
                query.Parameters.AddWithValue("@bprice", bprice.Text);
                query.Parameters.AddWithValue("@bplace", bplace.Text);
                query.Parameters.AddWithValue("@bcnt", bcnt.Value);
                query.Parameters.AddWithValue("@bdate", bdate.Text);
                query.Parameters.AddWithValue("@bindate", bindate.Text);
                query.Parameters.AddWithValue("@bdeldate", null);
                query.Parameters.AddWithValue("@bpictxt", bpictxt.Text);

                query.ExecuteNonQuery();

                MessageBox.Show("등록 완료");

                edit_cancel();

                SearchBook(false, "no"); // 중복 검사 없이 바로 그리드뷰 호출
            }
            else
            {   // 중복이 있을 경우
                MessageBox.Show("이미 등록된 도서가 존재합니다.");
                return;
            }
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void updbtn_Click(object sender, EventArgs e)
        {
            string Sql = "update bookinfo set bookname = @bname, bookperson = @bperson, bookcompany = @bcompany, bookprice = @bprice, bookplace = @bplace, bookcnt = @bcnt, bookdate = @bdate, bookindate = @bindate, bookdeldate = @bdeldate, bookpic = @bpictxt where bookisbn = @bisbn";

            if (reader != null) { reader.Close(); }

            query = new MySqlCommand();
            query.Connection = conn;
            query.CommandText = Sql;
            query.Prepare();
            query.Parameters.AddWithValue("@bisbn", bisbn.Text);
            query.Parameters.AddWithValue("@bname", bname.Text);
            query.Parameters.AddWithValue("@bperson", bperson.Text);
            query.Parameters.AddWithValue("@bcompany", bcompany.Text);
            query.Parameters.AddWithValue("@bprice", bprice.Text);
            query.Parameters.AddWithValue("@bplace", bplace.Text);
            query.Parameters.AddWithValue("@bcnt", bcnt.Text);
            query.Parameters.AddWithValue("@bdate", bdate.Text);
            query.Parameters.AddWithValue("@bindate", bindate.Text);
            if (checkBox1.Checked == true)
            {
                query.Parameters.AddWithValue("@bdeldate", bdeldate.Text);
            }
            else
            {
                query.Parameters.AddWithValue("@bdeldate", null);
            }
            query.Parameters.AddWithValue("@bpictxt", bpictxt.Text);

            query.ExecuteNonQuery();

            MessageBox.Show("수정 완료");

            edit_cancel();

            SearchBook(false, "no");
        }

        private void delbtn_Click(object sender, EventArgs e)
        {
            string Sql = "delete from bookinfo where bookisbn = @bisbn";

            if (reader != null) { reader.Close(); }

            if (MessageBox.Show("삭제후에는 복구할 수 없습니다.\n정말 삭제하시겠습니까?", "삭제", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                query = new MySqlCommand();
                query.Connection = conn;
                query.CommandText = Sql;
                query.Prepare();
                query.Parameters.AddWithValue("@bisbn", bisbn.Text);

                query.ExecuteNonQuery();

                MessageBox.Show("삭제 완료");

                edit_cancel();

                SearchBook(false, "no");
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            bisbn.Text = dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
            bname.Text = dataGridView1.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
            bperson.Text = dataGridView1.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
            bcompany.Text = dataGridView1.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
            bprice.Text = dataGridView1.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
            bdate.Text = dataGridView1.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();
            bindate.Text = dataGridView1.Rows[e.RowIndex].Cells[6].FormattedValue.ToString();
            bdeldate.Text = dataGridView1.Rows[e.RowIndex].Cells[7].FormattedValue.ToString();
            bplace.Text = dataGridView1.Rows[e.RowIndex].Cells[8].FormattedValue.ToString();
            bcnt.Text = dataGridView1.Rows[e.RowIndex].Cells[9].FormattedValue.ToString();
            bpictxt.Text = dataGridView1.Rows[e.RowIndex].Cells[12].FormattedValue.ToString();
            bpic.ImageLocation = dataGridView1.Rows[e.RowIndex].Cells[12].FormattedValue.ToString();
            if (dataGridView1.Rows[e.RowIndex].Cells[7].FormattedValue.ToString() == "" || dataGridView1.Rows[e.RowIndex].Cells[7].FormattedValue.ToString() == null)
            {
                checkBox1.Checked = false;
            }
            else
            {
                checkBox1.Checked = true;
            }
            insbtn.Enabled = false;
            bisbn.Enabled = false;
            updbtn.Enabled = true;
            delbtn.Enabled = true;
            checkBox1.Enabled = true;
        }

        private void bprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt16(e.KeyChar) < 48 || Convert.ToInt16(e.KeyChar) > 57)
            {
                if (Convert.ToInt16(e.KeyChar) != 8)
                {
                    MessageBox.Show("숫자만 입력 가능합니다.");
                    e.Handled = true;
                    return;
                }
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            edit_cancel();
        }

        void edit_cancel() // 초기화 함수
        {
            bname.Text = "";
            bcompany.Text = "";
            bisbn.Text = "";
            bdate.Text = DateTime.Now.ToString("yyyy-MM-dd");
            bperson.Text = "";
            bprice.Text = "";
            bplace.Text = "";
            checkBox1.Checked = false;
            checkBox1.Enabled = false;
            bindate.Text = DateTime.Now.ToString("yyyy-MM-dd");
            bdeldate.Text = DateTime.Now.ToString("yyyy-MM-dd");
            bcnt.Value = 0;
            insbtn.Enabled = true;
            updbtn.Enabled = false;
            delbtn.Enabled = false;
            if (bpic.Image != null)
            {
                bpic.Image.Dispose();
                bpic.Image = null;
            }
            bpictxt.Text = "";
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            edit_cancel();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            API_Search APIfrm = new API_Search();

            APIfrm.StartPosition = FormStartPosition.CenterParent;
            APIfrm.Parentfrm = this;
            APIfrm.ShowDialog();
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void bdate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                bdeldate.Enabled = true;
            }
            else
            {
                bdeldate.Enabled = false;
            }
        }
    }
}
