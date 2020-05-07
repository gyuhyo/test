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
    public partial class rentDetail : Form
    {
        private static string mysql_str = "server=203.227.206.254;port=3306;Database=p201987062;Uid=p201987062;Pwd=pp201987062;Charset=utf8"; // 데이터베이스 접속
        MySqlConnection conn = new MySqlConnection(mysql_str);
        MySqlCommand query;
        MySqlDataReader reader;

        public rentDetail()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Sql;
            Sql = "select bookinfo.bookisbn as bookisbn" +
                  ", bookinfo.bookname as bookname" +
                  ", bookinfo.bookcnt as bookcnt" +
                  ", bookinfo.bookdeldate as bookdel" +
                  ", ifnull(rntinfo.rntcnt, 0) as rntcnt" +
                  ", (bookcnt - ifnull(rntcnt,0) ) as nowcnt" +
                  " from(select * from bookinfo where bookname like @searchtxt) as bookinfo" +
                  " left join" +
                  " (select rntisbn, sum(rntcnt) rntcnt from rntinfo where rntrdate is null group by rntisbn) as rntinfo" +
                  " on bookinfo.bookisbn = rntinfo.rntisbn" +
                  " order by bookname asc";

            if (reader != null) { reader.Close(); }

            query = new MySqlCommand();
            query.Connection = conn;
            query.CommandText = Sql;
            query.Prepare();
            query.Parameters.AddWithValue("@searchtxt", "%" + textBox1.Text + "%");

            reader = query.ExecuteReader();

            booklst.Rows.Clear();
            booklst.Columns.Clear();

            booklst.Columns.Add("bisbn", "ISBN");
            booklst.Columns.Add("bname", "도서명");
            booklst.Columns.Add("bcnt", "입고량");
            booklst.Columns.Add("rcnt", "대여량");
            booklst.Columns.Add("ncnt", "잔여량");

            int i = 0;

            while (reader.Read())
            {
                booklst.Rows.Add();
                booklst.Rows[i].Cells[0].Value = reader["bookisbn"].ToString(); ;
                booklst.Rows[i].Cells[1].Value = reader["bookname"].ToString();
                booklst.Rows[i].Cells[2].Value = reader["bookcnt"].ToString();
                booklst.Rows[i].Cells[3].Value = reader["rntcnt"].ToString();
                booklst.Rows[i].Cells[4].Value = (reader["bookdel"].ToString() == "") ? reader["nowcnt"].ToString() : "0";

                i++;
            }
            reader.Close();
            booklst.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void rentDetail_Load(object sender, EventArgs e)
        {
            conn.Open();
        }

        private void booklst_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string Sql;
            Sql = "select stuinfo.stunum stunum" +
                  ", stuinfo.stuname stuname" +
                  ", rntinfo.rntcnt rntcnt" +
                  ", rntinfo.rntdate rntdate" +
                  ", rntinfo.rntrdate rntrdate" +
                  " from stuinfo" +
                  " inner join" +
                  " (select * from rntinfo where rntisbn = @shrisbn) as rntinfo" +
                  " on stuinfo.stunum = rntinfo.rntnum" +
                  " order by rntdate desc";

            if (reader != null) { reader.Close(); }

            query = new MySqlCommand();
            query.Connection = conn;
            query.CommandText = Sql;
            query.Prepare();
            query.Parameters.AddWithValue("@shrisbn", booklst.Rows[e.RowIndex].Cells[0].FormattedValue.ToString());

            reader = query.ExecuteReader();

            detaillst.Rows.Clear();
            detaillst.Columns.Clear();

            detaillst.Columns.Add("snum", "학번");
            detaillst.Columns.Add("sname", "이름");
            detaillst.Columns.Add("rcnt", "수량");
            detaillst.Columns.Add("rdate", "대여일자");
            detaillst.Columns.Add("rrdate", "반납일자");
            detaillst.Columns.Add("rrinfo", "반납여부");
            int i = 0;

            while (reader.Read())
            {
                detaillst.Rows.Add();
                detaillst.Rows[i].Cells[0].Value = reader["stunum"].ToString();
                detaillst.Rows[i].Cells[1].Value = reader["stuname"].ToString();
                detaillst.Rows[i].Cells[2].Value = reader["rntcnt"].ToString();
                detaillst.Rows[i].Cells[3].Value = reader["rntdate"].ToString();
                detaillst.Rows[i].Cells[4].Value = reader["rntrdate"].ToString();
                detaillst.Rows[i].Cells[5].Value = (reader["rntrdate"].ToString()) == "" ? "미반납" : "반납완료";
                if (detaillst.Rows[i].Cells[5].FormattedValue.ToString() == "미반납")
                {
                    detaillst.Rows[i].Cells[5].Style.ForeColor = Color.Red;
                }
                else
                {
                    detaillst.Rows[i].Cells[5].Style.ForeColor = Color.Green;
                }
                i++;
            }
            reader.Close();
            detaillst.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
    }
}
