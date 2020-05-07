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
using static System.IO.Directory;

namespace book
{
    public partial class stufrm : Form
    {
        private static string mysql_str = "server=203.227.206.254;port=3306;Database=p201987062;Uid=p201987062;Pwd=pp201987062;Charset=utf8"; // 데이터베이스 접속
        MySqlConnection conn = new MySqlConnection(mysql_str);
        MySqlCommand query;
        MySqlDataReader reader;
        string rdefined;
        int ChangePhoto = 0;
        string dir = @"stuimg/";
        String fname;

        public stufrm()
        {
            InitializeComponent();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            conn.Open();
        }

        void SearchBook(Boolean bcheck, string defined)
        {
            string Sql;

            // 중복검사를 하라는 인자값(bcheck == true)이 넘어 올 경우 학생의 유무를 검색함
            if (bcheck == true)
            {
                Sql = "select * from stuinfo where stunum = @stunum";

                if(reader != null) { reader.Close(); }

                query = new MySqlCommand();
                query.Connection = conn;
                query.CommandText = Sql;
                query.Prepare();
                query.Parameters.AddWithValue("@stunum", snum.Text);
            }
            else
            {
                // 중복검사를 하지 않을 경우
                // 이 학생의 대여중인 책의 권수와 학생의 정보를 불러옴

                Sql = "select a.*, ifnull(rntsum, 0) as rntsum from (select * from stuinfo where stunum like @shsnum and stuname like @shsname) a " +
                      "left join (select sum(rntcnt) as rntsum, rntnum from rntinfo where rntrdate is null group by rntisbn) b " +
                      "on a.stunum = b.rntnum";

                if (reader != null) { reader.Close(); }

                query = new MySqlCommand();
                query.Connection = conn;
                query.CommandText = Sql;
                query.Prepare();
                query.Parameters.AddWithValue("@shsnum", "%" + shsnum.Text + "%");
                query.Parameters.AddWithValue("@shsname", "%" + shsname.Text + "%");
            }
            reader = query.ExecuteReader();

            if (defined == "yes") // 중복검사를 실시 하는 경우
            {
                if (reader.Read())
                {
                    rdefined = "yes"; // 값이 있다고 알림
                }
                else
                {
                    rdefined = "no"; // 값이 없다고 알림
                }
            }
            else
            {
                result_gird();
            }
        }

        void result_gird()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("snum", "학번");
            dataGridView1.Columns.Add("sname", "이름");
            dataGridView1.Columns.Add("rcnt", "대여중");
            dataGridView1.Columns.Add("stel", "전화번호");
            dataGridView1.Columns.Add("saddr", "주소");
            dataGridView1.Columns.Add("spic", "이미지");

            int i = 0;

            while (reader.Read())
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = reader["stunum"].ToString(); ;
                dataGridView1.Rows[i].Cells[1].Value = reader["stuname"].ToString();
                dataGridView1.Rows[i].Cells[2].Value = reader["rntsum"].ToString();
                dataGridView1.Rows[i].Cells[3].Value = reader["stutel"].ToString();
                dataGridView1.Rows[i].Cells[4].Value = reader["stuaddr1"].ToString() + " " + reader["stuaddr2"].ToString();
                dataGridView1.Rows[i].Cells[5].Value = reader["stupic"].ToString();

                i++;
            }
            reader.Close();
        }

        private void insbtn_Click(object sender, EventArgs e)
        {
            if (snum.Text == "")
            {
                MessageBox.Show("학번을 입력해주세요.");
                return;
            }

            if (snum.TextLength != 9)
            {
                MessageBox.Show("학번이 9자리가 아닙니다.");
                return;
            }

            if (sname.Text == "")
            {
                MessageBox.Show("이름을 입력해주세요.");
                return;
            }

            if (stel.Text == "")
            {
                MessageBox.Show("전화번호를 입력해주세요.");
                return;
            }

            if (saddr.Text == "")
            {
                MessageBox.Show("주소를 입력해주세요.");
                return;
            }

            if (spictxt.Text == "")
            {
                MessageBox.Show("학생 이미지가 없습니다.");
                return;
            }

            fname = snum.Text + spictxt.Text;

            if (Exists(dir))
            {
                if (ChangePhoto == 1)
                {
                    spic.Image.Save(dir + fname);
                }
            }
            else
            {
                MessageBox.Show("해당 폴더 없음\n먼저 폴더를 생성하고 다시 실행해주세요.\n\n경로 : 응용프로그램 폴더\n폴더명 : stuimg");
                return;
            }

            string Sql = "insert into stuinfo values(@snum, @sname, @stel, @zipcode, @saddr1, @saddr2, @spic)";

            SearchBook(true, "yes"); // 검색 함수에 중복 체크 인자값을 넘김

            if (reader != null) { reader.Close(); }

            if (rdefined == "no") // 중복이 아닌 경우
            {
                query = new MySqlCommand();
                query.Connection = conn;
                query.CommandText = Sql;
                query.Prepare();
                query.Parameters.AddWithValue("@snum", snum.Text);
                query.Parameters.AddWithValue("@sname", sname.Text);
                query.Parameters.AddWithValue("@stel", stel.Text);
                query.Parameters.AddWithValue("@zipcode", zipcode.Text);
                query.Parameters.AddWithValue("@saddr1", saddr.Text);
                query.Parameters.AddWithValue("@saddr2", otheraddr.Text);
                query.Parameters.AddWithValue("@spic", fname);

                query.ExecuteNonQuery();

                MessageBox.Show("등록 완료");

                edit_cancel();

                SearchBook(false, "no"); // 그리드뷰를 업데이트 하기 위한 조회 함수 호출
            }
            else
            {
                // 중복인 경우
                MessageBox.Show("이미 등록된 학생이 존재합니다.");
                return;
            }
        }

        private void updbtn_Click(object sender, EventArgs e)
        {
            fname = snum.Text + spictxt.Text;

            if (Exists(dir))
            {
                if (ChangePhoto == 1)
                {
                    spic.Image.Save(dir + fname);
                }
            }
            else
            {
                MessageBox.Show("해당 폴더 없음\n먼저 폴더를 생성하고 다시 실행해주세요.\n\n경로 : 응용프로그램 폴더\n폴더명 : stuimg");
                return;
            }

            string Sql = "update stuinfo set stuname = @sname, stutel = @stel, stuzip = @zipcode, stuaddr1 = @saddr1, stuaddr2 = @saddr2, stupic = @spic where stunum = @snum";

            if (reader != null) { reader.Close(); }

            query = new MySqlCommand();
            query.Connection = conn;
            query.CommandText = Sql;
            query.Prepare();
            query.Parameters.AddWithValue("@snum", snum.Text);
            query.Parameters.AddWithValue("@sname", sname.Text);
            query.Parameters.AddWithValue("@stel", stel.Text);
            query.Parameters.AddWithValue("@zipcode", zipcode.Text);
            query.Parameters.AddWithValue("@saddr1", saddr.Text);
            query.Parameters.AddWithValue("@saddr2", otheraddr.Text);
            query.Parameters.AddWithValue("@spic", fname);

            query.ExecuteNonQuery();

            MessageBox.Show("수정 완료");

            edit_cancel();

            SearchBook(false, "no");
        }

        private void delbtn_Click(object sender, EventArgs e)
        {
            string Sql = "delete from stuinfo where stunum = @snum";

            if (reader != null) { reader.Close(); }

            if (MessageBox.Show("삭제후에는 복구할 수 없습니다.\n정말 삭제하시겠습니까?", "삭제", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                query = new MySqlCommand();
                query.Connection = conn;
                query.CommandText = Sql;
                query.Prepare();
                query.Parameters.AddWithValue("@snum", snum.Text);

                query.ExecuteNonQuery();

                MessageBox.Show("삭제 완료");

                edit_cancel();

                SearchBook(false, "no");
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            snum.Text = dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
            sname.Text = dataGridView1.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
            stel.Text = dataGridView1.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
            saddr.Text = dataGridView1.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
            spictxt.Text = dataGridView1.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();
            spic.Image = Image.FromFile(dir + spictxt.Text);
            spictxt.Text = dataGridView1.Rows[e.RowIndex].Cells[5].FormattedValue.ToString().Substring(dataGridView1.Rows[e.RowIndex].Cells[5].FormattedValue.ToString().LastIndexOf('.'));
            insbtn.Enabled = false;
            snum.Enabled = false;
            updbtn.Enabled = true;
            delbtn.Enabled = true;
        }

        private void snum_KeyPress(object sender, KeyPressEventArgs e)
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

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            edit_cancel();
        }

        void edit_cancel()
        {
            snum.Text = "";
            sname.Text = "";
            stel.Text = "";
            saddr.Text = "";
            spictxt.Text = "";
            insbtn.Enabled = true;
            snum.Enabled = true;
            updbtn.Enabled = false;
            delbtn.Enabled = false;
            if (spic.Image != null)
            {
                spic.Image.Dispose();
                spic.Image = null;
            }
            spictxt.Text = "";
            ChangePhoto = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LocalSearch APIfrm = new LocalSearch();

            APIfrm.StartPosition = FormStartPosition.CenterParent;
            APIfrm.Parentfrm = this;
            APIfrm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog pic1 = new OpenFileDialog();
            string fname;
            if (pic1.ShowDialog() == DialogResult.OK)
            {
                if (spic.Image != null)
                {
                    spic.Image.Dispose();
                }
                ChangePhoto = 1;
                spic.Image = Image.FromFile(pic1.FileName);
                fname = Path.GetFileName(pic1.FileName);
                spictxt.Text = fname.Substring(fname.LastIndexOf('.'));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SearchBook(false, "");
        }
    }
}
