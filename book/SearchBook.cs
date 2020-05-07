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
    public partial class SearchBook : Form
    {
        private static string mysql_str = "server=203.227.206.254;port=3306;Database=p201987062;Uid=p201987062;Pwd=pp201987062;Charset=utf8"; // 데이터베이스 접속
        MySqlConnection conn = new MySqlConnection(mysql_str);
        MySqlCommand query;
        MySqlDataReader reader;

        public rntfrm Parentfrm;

        public SearchBook()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SearchBooks();
        }

        void SearchBooks()
        {
            string Sql;
            //select bookinfo.*, ifnull(bookinfo.bookcnt - rt.rsum, 0) as rsum from (select * from bookinfo where bookname like '%' ) as bookinfo left join (select rntisbn, sum(rntcnt) as rsum from rntinfo group by rntisbn) as rt on bookinfo.bookisbn = rt.rntisbn;
            Sql = "select bkinfo.*, ifnull(bkinfo.bookcnt - ifnull(rt.rsum, 0), 0) as rsum" +
                  " from (select * from bookinfo where bookname like @searchtxt and bookdeldate is null) as bkinfo" +
                  " left join (select rntisbn, sum(rntcnt) as rsum from rntinfo group by rntisbn) as rt" +
                  " on bkinfo.bookisbn = rt.rntisbn";

            if (reader != null) { reader.Close(); }

            query = new MySqlCommand();
            query.Connection = conn;
            query.CommandText = Sql;
            query.Prepare();
            query.Parameters.AddWithValue("@searchtxt", "%" + textBox1.Text + "%");

            reader = query.ExecuteReader();

            result_gird();

        }

        void result_gird()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("bisbn", "ISBN");
            dataGridView1.Columns.Add("bname", "도서명");
            dataGridView1.Columns.Add("bperson", "저자");
            dataGridView1.Columns.Add("bcnt", "남은재고");

            int i = 0;

            while (reader.Read())
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = reader["bookisbn"].ToString(); ;
                dataGridView1.Rows[i].Cells[1].Value = reader["bookname"].ToString();
                dataGridView1.Rows[i].Cells[2].Value = reader["bookperson"].ToString();
                dataGridView1.Rows[i].Cells[3].Value = reader["rsum"].ToString();

                i++;
            }
            reader.Close();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Parentfrm.risbn.Text = dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
            Parentfrm.rbookinfo.Text = "도서명 [" + dataGridView1.Rows[e.RowIndex].Cells[1].FormattedValue.ToString() + "]";
            Parentfrm.bcnt.Text = dataGridView1.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
            this.Dispose();
        }

        private void SearchBook_Load(object sender, EventArgs e)
        {
            conn.Open();
        }
    }
}
