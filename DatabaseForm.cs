using Nancy.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITLabs_client
{
    public partial class DatabaseForm : Form
    {
        public string login;
        public string dbname;
        List<string> tbls;
        string server = "http://localhost:8000?wsdl";
        AccountForm f;
        public DatabaseForm(AccountForm f0)
        {
            f = f0;
            login = f0.login;
            dbname = f0.db;
            InitializeComponent();
            dbname_label.Text ="database - " +dbname;
            login_label2.Text ="account - "+ login;

            string post_str = "{ \"get_tables_names\":{\"login\":\"" + login + "\",\"name\":\"" + dbname + "\" }}";


            var httpWebRequest = (HttpWebRequest)WebRequest.Create(server);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                streamWriter.Write(post_str);
            }
            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var serializer = new JavaScriptSerializer();
                var result = streamReader.ReadToEnd();
                var json = serializer.Deserialize<string>(result);
                json = json.Replace("\"", "");
                json = json.Replace("[", "");
                json = json.Replace("]", "");
                var arr = json.Split(",");
                tbls = new List<string>();
                foreach (var x in arr)
                {
                    tbls_list_left.Items.Add(x.Trim());
                    tbls_list_right.Items.Add(x.Trim());
                    tbls.Add(x.Trim());
                }
                int i = 0;
            }
        }

        private void DatabaseForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            f.Show();
        }

        private void table_mult_btn_Click(object sender, EventArgs e)
        {
            var db1 = tbls_list_left.SelectedItem;
            error_label.Text = "";
            if (db1 == null)
            {
                error_label.Text = "Оберіть базу!";
                return;
            }
            var db2 = tbls_list_right.SelectedItem;
            error_label.Text = "";
            if (db2 == null)
            {
                error_label.Text = "Оберіть базу!";
                return;
            }
            string post_str = "{ \"table_mult\":{\"login\":\"" + login + "\",\"dbname\":\"" + dbname + "\",\"tbl1\":\"" + db1 + "\",\"tbl2\":\"" + db2 + "\" }}";
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(server);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                streamWriter.Write(post_str);
            }
            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var serializer = new JavaScriptSerializer();
                var result = streamReader.ReadToEnd();
                var json = serializer.Deserialize<string>(result);
                json = json.Replace("]]", "]");
                var els = json.Split("],");
                table_mult_result.Items.Clear();
                var last = els.GetValue(els.Length-1).ToString();
                string t = last;
                t = t.Replace("\"", "");
                t = t.Replace("[", "");
                t = t.Replace("]", "");
                table_mult_result.Items.Add(t.Trim());
                foreach (var el in els)
                {
                    if (el != last) { 
                        t = el;
                        t = t.Replace("\"", "");
                        t = t.Replace("[", "");
                        table_mult_result.Items.Add(t.Trim());
                    }
                }
            }
        }
    }
}
