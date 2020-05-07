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

namespace book
{
    public partial class rntfrm : Form
    {
        private static string mysql_str = "server=203.227.206.254;port=3306;Database=p201987062;Uid=p201987062;Pwd=pp201987062;Charset=utf8"; // 데이터베이스 접속
        MySqlConnection conn = new MySqlConnection(mysql_str);
        MySqlCommand query;
        MySqlDataReader reader;
        string rntSysdate;
        int click_rcnt;

        public rntfrm()
        {
            InitializeComponent();
        }

        private void insbtn_Click(object sender, EventArgs e)
        {
            if (rnum.Text == "")
            {
                MessageBox.Show("학번을 입력해주세요.");
                return;
            }

            if (risbn.Text == "")
            {
                MessageBox.Show("ISBN을 입력해주세요.");
                return;
            }

            if (rcnt.Text == "0")
            {
                MessageBox.Show("권수를 확인해주세요.");
                return;
            }

            if (Convert.ToInt16(bcnt.Text) < Convert.ToInt16(rcnt.Text))
            {
                MessageBox.Show("대여 가능수를 초과하였습니다.");
                return;
            }
            else
            {
                string Sql = "insert into rntinfo values(@rdate, @rnum, @risbn, @rcnt, @rpdate, @rrdate, @sysdate)";

                if (reader != null) { reader.Close(); }

                query = new MySqlCommand();
                query.Connection = conn;
                query.CommandText = Sql;
                query.Prepare();
                query.Parameters.AddWithValue("@rnum", rnum.Text);
                query.Parameters.AddWithValue("@risbn", risbn.Text);
                query.Parameters.AddWithValue("@rcnt", rcnt.Text);
                query.Parameters.AddWithValue("@rdate", rdate.Text);
                query.Parameters.AddWithValue("@rpdate", rpdate.Text);
                query.Parameters.AddWithValue("@rrdate", null);
                query.Parameters.AddWithValue("@sysdate", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

                query.ExecuteNonQuery();

                MessageBox.Show("등록 완료");

                // 검색어 초기화
                reset_shtxt();
                // 조회 호출
                select_rnt();
                // 초기화 진행
                edit_cancel();
            }

        }

        void select_rnt()
        {
            String Sql;

            Sql = "select c.stunum stunum" +
                  ", c.stuname stuname" +
                  ", tmp.bookisbn bookisbn" +
                  ", tmp.bookname bookname" +
                  ", tmp.rntcnt rntcnt" +
                  ", tmp.rntdate rntdate" +
                  ", tmp.rntpdate rntpdate" +
                  ", tmp.rntrdate rntrdate" +
                  ", tmp.sysdate sysdate" +
                  " from (select * from stuinfo where stunum like @shrsnum and stuname like @shrsname) c " +
                  "inner join" +
                  " (select a.*, b.* from rntinfo a inner join (select * from bookinfo where bookisbn like @shrbisbn and bookname like @shrbname) b on a.rntisbn = b.bookisbn) tmp" +
                  " on c.stunum = tmp.rntnum";

            if (reader != null) { reader.Close(); }

            query = new MySqlCommand();
            query.Connection = conn;
            query.CommandText = Sql;
            query.Prepare();
            query.Parameters.AddWithValue("@shrsnum", "%" + shrsnum.Text + "%");
            query.Parameters.AddWithValue("@shrsname", "%" + shrsname.Text + "%");
            query.Parameters.AddWithValue("@shrbisbn", "%" + shrbisbn.Text + "%");
            query.Parameters.AddWithValue("@shrbname", "%" + shrbname.Text + "%");

            reader = query.ExecuteReader();

            result_gird();
        }

        void reset_shtxt()
        {
            shrsnum.Text = "";
            shrsname.Text = "";
            shrbisbn.Text = "";
            shrbname.Text = "";
        }

        void result_gird()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("rsnum", "학번");
            dataGridView1.Columns.Add("rsname", "이름");
            dataGridView1.Columns.Add("rbisbn", "ISBN");
            dataGridView1.Columns.Add("rbname", "책이름");
            dataGridView1.Columns.Add("rcnt", "권수");
            dataGridView1.Columns.Add("rdate", "대여일자");
            dataGridView1.Columns.Add("rpdate", "반납예정일");
            dataGridView1.Columns.Add("rrdate", "반납일");
            dataGridView1.Columns.Add("rsysdate", "sysdate");

            int i = 0;

            while (reader.Read())
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = reader["stunum"].ToString();
                dataGridView1.Rows[i].Cells[1].Value = reader["stuname"].ToString();
                dataGridView1.Rows[i].Cells[2].Value = reader["bookisbn"].ToString();
                dataGridView1.Rows[i].Cells[3].Value = reader["bookname"].ToString();
                dataGridView1.Rows[i].Cells[4].Value = reader["rntcnt"].ToString();
                dataGridView1.Rows[i].Cells[5].Value = reader["rntdate"].ToString();
                dataGridView1.Rows[i].Cells[6].Value = reader["rntpdate"].ToString();
                dataGridView1.Rows[i].Cells[7].Value = reader["rntrdate"].ToString();
                dataGridView1.Rows[i].Cells[8].Value = reader["sysdate"].ToString();
                i++;
            }
            reader.Close();
            dataGridView1.Columns[8].Visible = false;
        }

        private void rntfrm_Load(object sender, EventArgs e)
        {
            conn.Open();

            // datepicker 을 오늘 날짜로 모두 초기화
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 학생 검색 폼을 띄움
            SearchStu SSfrm = new SearchStu();

            SSfrm.StartPosition = FormStartPosition.CenterParent;
            SSfrm.Parentfrm = this;
            SSfrm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // 도서 검색 폼을 띄움
            SearchBook SBfrm = new SearchBook();

            SBfrm.StartPosition = FormStartPosition.CenterParent;
            SBfrm.Parentfrm = this;
            SBfrm.ShowDialog();
        }

        private void updbtn_Click(object sender, EventArgs e)
        {
            string Sql = "update rntinfo set rntcnt = @rcnt, rntdate = @rdate, rntpdate = @rpdate, rntrdate = @rrdate where rntisbn = @risbn and sysdate = @rsysdate";

            if (reader != null) { reader.Close(); }

            query = new MySqlCommand();
            query.Connection = conn;
            query.CommandText = Sql;
            query.Prepare();
            query.Parameters.AddWithValue("@risbn", risbn.Text);
            query.Parameters.AddWithValue("@rcnt", rcnt.Text);
            query.Parameters.AddWithValue("@rdate", rdate.Text);
            query.Parameters.AddWithValue("@rpdate", rpdate.Text);
            query.Parameters.AddWithValue("@rsysdate", rntSysdate);

            if (checkBox1.Checked == true)
            {
                query.Parameters.AddWithValue("@rrdate", rrdate.Text);
            }
            else
            {
                query.Parameters.AddWithValue("@rrdate", null);
            }

            query.ExecuteNonQuery();

            MessageBox.Show("수정 완료");

            // 검색어 초기화
            reset_shtxt();
            select_rnt();
            edit_cancel();
        }
        private void delbtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("삭제후에는 복구할 수 없습니다.\n정말 삭제하시겠습니까?", "삭제", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string Sql = "delete from rntinfo where rntisbn = @risbn and sysdate = @rsysdate";

                if (reader != null) { reader.Close(); }

                query = new MySqlCommand();
                query.Connection = conn;
                query.CommandText = Sql;
                query.Prepare();
                query.Parameters.AddWithValue("@risbn", risbn.Text);
                query.Parameters.AddWithValue("@rsysdate", rntSysdate);

                query.ExecuteNonQuery();

                MessageBox.Show("삭제 완료");

                // 검색어 초기화
                reset_shtxt();
                select_rnt();
                edit_cancel();
            }
        }

        string select_bcnt(string bookisbn)
        {
            string Sql;

            // 대여할 책의 총 입고량을 불러옴
            Sql = "select (bookinfo.bookcnt - ifnull(sum(rntinfo.rntcnt), 0)) as sumbook from bookinfo inner join rntinfo " +
                  "on bookinfo.bookisbn = rntinfo.rntisbn where rntisbn = (select bookisbn from bookinfo where bookisbn = @cntbisbn) and rntinfo.rntrdate is null";

            if (reader != null) { reader.Close(); }

            query = new MySqlCommand();
            query.Connection = conn;
            query.CommandText = Sql;
            query.Prepare();
            query.Parameters.AddWithValue("@cntbisbn", bookisbn);

            reader = query.ExecuteReader();

            reader.Read();

            return (reader)["sumbook"].ToString();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            rnum.Text = dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
            rstuinfo.Text = "이름 [" + dataGridView1.Rows[e.RowIndex].Cells[1].FormattedValue.ToString() + "]";
            risbn.Text = dataGridView1.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
            rbookinfo.Text = "도서명 [" + dataGridView1.Rows[e.RowIndex].Cells[3].FormattedValue.ToString() + "]";
            bcnt.Text = select_bcnt(risbn.Text);
            rcnt.Value = Convert.ToInt16(dataGridView1.Rows[e.RowIndex].Cells[4].FormattedValue.ToString());
            click_rcnt = Convert.ToInt16(dataGridView1.Rows[e.RowIndex].Cells[4].FormattedValue.ToString());
            rdate.Text = dataGridView1.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();
            rpdate.Text = dataGridView1.Rows[e.RowIndex].Cells[6].FormattedValue.ToString();
            rrdate.Text = dataGridView1.Rows[e.RowIndex].Cells[7].FormattedValue.ToString();
            rntSysdate = dataGridView1.Rows[e.RowIndex].Cells[8].FormattedValue.ToString();

            if (dataGridView1.Rows[e.RowIndex].Cells[7].FormattedValue.ToString() == "" || dataGridView1.Rows[e.RowIndex].Cells[7].FormattedValue.ToString() == null)
            {
                checkBox1.Checked = false;
            }
            else
            {
                checkBox1.Checked = true;
            }

            insbtn.Enabled = false;
            updbtn.Enabled = true;
            delbtn.Enabled = true;
            checkBox1.Enabled = true;
            button1.Enabled = false;
            button3.Enabled = false;
        }

        void edit_cancel()
        {
            rnum.Text = "";
            rstuinfo.Text = "";
            risbn.Text = "";
            rbookinfo.Text = "";
            bcnt.Text = "";
            rcnt.Value = 0;
            rdate.Text = DateTime.Now.ToString("yyyy-MM-dd");
            rpdate.Text = DateTime.Now.ToString("yyyy-MM-dd");
            rrdate.Text = DateTime.Now.ToString("yyyy-MM-dd");
            rntSysdate = "";
            insbtn.Enabled = true;
            rrdate.Enabled = false;
            updbtn.Enabled = false;
            delbtn.Enabled = false;
            checkBox1.Enabled = false;
            checkBox1.Checked = false;
            button1.Enabled = true;
            button3.Enabled = true;
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            edit_cancel();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                rrdate.Enabled = true;
            }
            else
            {
                rrdate.Enabled = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            select_rnt();
        }

        private void rpdate_ValueChanged(object sender, EventArgs e)
        {
            if (rpdate.Value < rdate.Value)
            {
                MessageBox.Show("반납 예정일이 반납일 보다 작을 수 없습니다.");
                rpdate.Value = DateTime.Today;
                return;
            }
        }
    }
}
