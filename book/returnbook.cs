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
    public partial class returnbook : Form
    {
        private static string mysql_str = "server=203.227.206.254;port=3306;Database=p201987062;Uid=p201987062;Pwd=pp201987062;Charset=utf8"; // 데이터베이스 접속
        MySqlConnection conn = new MySqlConnection(mysql_str);
        MySqlCommand query;
        MySqlDataReader reader;

        public returnbook()
        {
            InitializeComponent();
        }

        void select_rnt()
        {
            String Sql;

            Sql = " select c.stunum stunum, c.stuname stuname, tmp.bookisbn bookisbn, tmp.bookname bookname, tmp.rntcnt rntcnt, tmp.rntdate rntdate, tmp.rntpdate rntpdate, tmp.rntrdate rntrdate, tmp.sysdate sysdate, datediff(tmp.rntpdate, curdate()) as datediff from stuinfo as c " +
                  " inner join (select a.*, b.* from rntinfo a inner join (select * from bookinfo where bookname like @bookname) as b on a.rntisbn = b.bookisbn where a.rntpdate <= curdate() and a.rntrdate is null) tmp on c.stunum = tmp.rntnum where c.stuname like @stuname";

            if (reader != null) { reader.Close(); }

            query = new MySqlCommand();
            query.Connection = conn;
            query.CommandText = Sql;
            query.Prepare();
            query.Parameters.AddWithValue("@bookname", textBox2.Text + "%");
            query.Parameters.AddWithValue("@stuname", textBox1.Text+"%");
            reader = query.ExecuteReader();

            result_gird();
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
            dataGridView1.Columns.Add("rrdate", "남은기간");

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
                dataGridView1.Rows[i].Cells[7].Value = reader["datediff"].ToString();
                i++;
            }
            reader.Close();
        }

        private void returnbook_Load(object sender, EventArgs e)
        {
            conn.Open();

            label1.Text = "조회 기준 : " + DateTime.Now.ToString("yyyy-MM-dd");

            select_rnt();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            select_rnt();
        }
    }
}
