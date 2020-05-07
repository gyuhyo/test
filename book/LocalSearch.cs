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
    public partial class LocalSearch : Form
    {
        int page, totalpage;
        public stufrm Parentfrm;

        public LocalSearch()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            SearchLocation(1);
        }

        void SearchLocation(int pg)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("검색어를 입력해주세요.");
                return;
            }

            page = pg;

            string query = textBox1.Text; // 검색할 문자열
            string ServiceKey = "bXhBhQG5MFxA10meMFHiAikfFLMIcKoSfdWohfH0HpzqrSfyA2FnAUVGFToGMclvAVLd%2BE%2BjD20QmnORFUd2Zg%3D%3D";
            string url = "http://openapi.epost.go.kr/postal/retrieveNewAdressAreaCdSearchAllService/retrieveNewAdressAreaCdSearchAllService/getNewAddressListAreaCdSearchAll?ServiceKey=" + ServiceKey +
                    "&srchwrd=" + query + "&countPerPage=10&currentPage=" + page;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            string status = response.StatusCode.ToString();
            if (status == "OK")
            {
                Stream stream = response.GetResponseStream();
                StreamReader reader = new StreamReader(stream, Encoding.UTF8);
                string text = reader.ReadToEnd();

                if (text.Contains("<totalPage></totalPage>") == true)
                {
                    MessageBox.Show("주소가 존재하지 않습니다.");
                    return;
                }

                totalpage = Convert.ToInt16(parsing_str(text, "<totalPage>", "</totalPage>"));

                label1.Text = page.ToString() + " / " + totalpage.ToString();

                string[] Textarr = text.Split(new string[] { "</newAddressListAreaCdSearchAll>" }, StringSplitOptions.None);

                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();
                dataGridView1.Columns.Add("zipno", "우편번호");
                dataGridView1.Columns.Add("Adress", "주소");


                for (int i = 0; i < Textarr.Length - 1; i++)
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[i].Cells[0].Value = parsing_str(Textarr[i], "<zipNo>", "</zipNo>");
                    dataGridView1.Rows[i].Cells[1].Value = parsing_str(Textarr[i], "<lnmAdres>", "</lnmAdres>");
                }
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                Cursor.Current = Cursors.Default;
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

        private void button3_Click(object sender, EventArgs e)
        {
            if (page == totalpage)
            {
                MessageBox.Show("마지막 페이지 입니다.");
                return;
            }

            Cursor.Current = Cursors.WaitCursor;
            SearchLocation(page + 1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                MessageBox.Show("첫 페이지 입니다.");
                return;
            }
            Cursor.Current = Cursors.WaitCursor;
            SearchLocation(page - 1);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Parentfrm.zipcode.Text = dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
            Parentfrm.saddr.Text = dataGridView1.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
            Parentfrm.otheraddr.Enabled = true;
            this.Dispose();
        }
    }
}
