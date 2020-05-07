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
    public partial class rntchart : Form
    {
        private static string mysql_str = "server=203.227.206.254;port=3306;Database=p201987062;Uid=p201987062;Pwd=pp201987062;Charset=utf8"; // 데이터베이스 접속
        MySqlConnection conn = new MySqlConnection(mysql_str);
        MySqlCommand query;
        MySqlDataReader reader;

        public rntchart()
        {
            InitializeComponent();
        }

        private void rntchart_Load(object sender, EventArgs e)
        {
            conn.Open();
        }

        void getChart()
        {
            string SeriesName;

            String Sql;

            Sql = "select" +
                " bookinfo.bookname as bookname" +
                ", rntinfo.rntsum as rntsum from bookinfo" +
                " inner join" +
                " (select rntisbn" +
                ", sum(rntcnt) as rntsum from rntinfo" +
                " where DATE(rntdate) between @firstDate and @secondDate" +
                " group by rntisbn) rntinfo" +
                " on bookinfo.bookisbn = rntinfo.rntisbn" +
                " order by rntinfo.rntsum desc";

            if (reader != null) { reader.Close(); }

            query = new MySqlCommand();
            query.Connection = conn;
            query.CommandText = Sql;
            query.Prepare();
            query.Parameters.AddWithValue("@firstDate", firtstDate.Value);
            query.Parameters.AddWithValue("@secondDate", SecondDate.Value);

            reader = query.ExecuteReader();

            chartA.Series.Clear();

            int i = 1;
            while(reader.Read())
            {
                if (reader["bookname"].ToString().Length > 20)
                {
                    SeriesName = reader["bookname"].ToString().Substring(0, 20) + "... (" + reader["rntsum"].ToString() + ")";
                }
                else
                {
                    SeriesName = reader["bookname"].ToString() + " (" + reader["rntsum"].ToString() + ")";
                }
                chartA.Series.Add(SeriesName);
                chartA.Series[SeriesName].Points.AddXY(i, Convert.ToInt32(reader["rntsum"].ToString()));  // X=1
                i++;
            }
        }

        private void firtstDate_ValueChanged(object sender, EventArgs e)
        {
            getChart();
        }

        private void SecondDate_ValueChanged(object sender, EventArgs e)
        {
            getChart();
        }
    }
}
