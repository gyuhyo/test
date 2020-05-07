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
    public partial class SearchStu : Form
    {
        private static string mysql_str = "server=203.227.206.254;port=3306;Database=p201987062;Uid=p201987062;Pwd=pp201987062;Charset=utf8"; // 데이터베이스 접속
        MySqlConnection conn = new MySqlConnection(mysql_str);
        MySqlCommand query;
        MySqlDataReader reader;

        public rntfrm Parentfrm;

        public SearchStu()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "학번")
            {
                textBox1.MaxLength = 9;
            }
            else
            {
                textBox1.MaxLength = 32767;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SearchStus();
        }

        void SearchStus()
        {
            string Sql;

            if (comboBox1.Text == "학번")
            {
                Sql = "select * from stuinfo where stunum like @searchtxt";
            }
            else
            {
                Sql = "select * from stuinfo where stuname like @searchtxt";
            }

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

            dataGridView1.Columns.Add("snum", "학번");
            dataGridView1.Columns.Add("sname", "이름");
            dataGridView1.Columns.Add("stel", "전화번호");

            int i = 0;

            while (reader.Read())
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = reader["stunum"].ToString(); ;
                dataGridView1.Rows[i].Cells[1].Value = reader["stuname"].ToString();
                dataGridView1.Rows[i].Cells[2].Value = reader["stutel"].ToString();

                i++;
            }
            reader.Close();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void SearchStu_Load(object sender, EventArgs e)
        {
            conn.Open();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Parentfrm.rnum.Text = dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
            Parentfrm.rstuinfo.Text = "이름 [" + dataGridView1.Rows[e.RowIndex].Cells[1].FormattedValue.ToString() + "]";
            this.Dispose();
        }
    }
}
