using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;

namespace book
{
    public partial class API_Search : Form
    {
        string purl;

        public API_Search()
        {
            InitializeComponent();
        }

        public bookfrm Parentfrm;

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("검색어를 입력해주세요.");
                return;
            }
            string query = textBox1.Text; // 검색할 문자열

            string url = "https://openapi.naver.com/v1/search/book_adv.xml?d_isbn=" + query; // 결과가 JSON 포맷
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Headers.Add("X-Naver-Client-Id", "fqfcnVNWchhKzYWCKnjp"); // 클라이언트 아이디
            request.Headers.Add("X-Naver-Client-Secret", "iV9656KEFx");       // 클라이언트 시크릿
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            string status = response.StatusCode.ToString();
            if (status == "OK")
            {
                Stream stream = response.GetResponseStream();
                StreamReader reader = new StreamReader(stream, Encoding.UTF8);
                string text = reader.ReadToEnd();

                text = text.Replace("<title>Naver Open API - book_adv ::''</title><link>https://search.naver.com</link>", null);
                text = text.Replace("&lt;b&gt;", null);
                text = text.Replace("&lt;/b&gt;", null);

                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();
                dataGridView1.Columns.Add("bisbn", "isbn");
                dataGridView1.Columns.Add("bname", "도서명");
                dataGridView1.Columns.Add("bperson", "저자");
                dataGridView1.Columns.Add("bcompany", "출판사");
                dataGridView1.Columns.Add("bprice", "가격");
                dataGridView1.Columns.Add("bdate", "출판일");
                    
                dataGridView1.Rows.Add();
                string isbn = parsing_str(text, "<isbn>", "</isbn>");
                dataGridView1.Rows[0].Cells[0].Value = isbn.Substring(isbn.Length - 13);
                dataGridView1.Rows[0].Cells[1].Value = parsing_str(text, "<item><title>", "</title><link>");
                dataGridView1.Rows[0].Cells[2].Value = parsing_str(text, "<author>", "</author>");
                dataGridView1.Rows[0].Cells[3].Value = parsing_str(text, "<publisher>", "</publisher>");
                dataGridView1.Rows[0].Cells[4].Value = parsing_str(text, "<price>", "</price>");
                dataGridView1.Rows[0].Cells[5].Value = parsing_str(text, "<pubdate>", "</pubdate>");
                purl = parsing_str(text, "<image>", "</image>");
                pictureBox1.ImageLocation = purl;

                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            else
            {
                Console.WriteLine("Error 발생=" + status);
            }
        }

        string parsing_str(string Astr, string Sstr, string Estr)
        {
            int start_str = Astr.IndexOf(Sstr);
            int start_length = Sstr.Length;
            int end_str = Astr.IndexOf(Estr);
            int end_length = Estr.Length;
            int middle_str_length = end_str - start_str;

            string parsing = Astr.Substring(start_str + start_length, middle_str_length - end_length + 1);

            return parsing;
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Parentfrm.bisbn.Text = dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
            Parentfrm.bname.Text = dataGridView1.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
            Parentfrm.bperson.Text = dataGridView1.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
            Parentfrm.bcompany.Text = dataGridView1.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
            Parentfrm.bprice.Text = dataGridView1.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
            string bdate_str = dataGridView1.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();
            Parentfrm.bdate.Text = bdate_str.Substring(0, 4) + "-" + bdate_str.Substring(4, 2) + "-" + bdate_str.Substring(6, 2);
            Parentfrm.bpictxt.Text = purl;
            Parentfrm.bpic.ImageLocation = purl;
            this.Dispose();
        }
    }
}
