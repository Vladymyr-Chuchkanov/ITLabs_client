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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITLabs_client
{
    public partial class AccountForm : Form
    {
        LoginForm f0;
        public string login;
        public string db;
        string server = "http://localhost:8000?wsdl";
        List<string> dbs;
        public AccountForm(LoginForm f)
        {
            f0 = f;
            login = f.email;
            dbs = new List<string>();
            
            string post_str = "{ \"get_dbs\":{\"login\":\"" + login + "\" }}";
           

            var httpWebRequest = (HttpWebRequest)WebRequest.Create(server);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {



                streamWriter.Write(post_str);
            }

            


            InitializeComponent();
            acc_name.Text = "account - " + login;
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
                foreach (var x in arr)
                {
                    dbs_list.Items.Add(x.Trim());
                    dbs.Add(x.Trim());
                }
                int i = 0;
            }
        }

        private void AccountForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            string post_str = "{ \"log_out\":{\"login\":\"" + login + "\" }}";
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(server);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";
            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {



                streamWriter.Write(post_str);
            }
            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            f0.Show();
        }

        private void open_btn_Click(object sender, EventArgs e)
        {
            var db0 = dbs_list.SelectedItem;
            error_label.Text = "";
            if (db0 == null)
            {
                error_label.Text="Оберіть базу!";
                return;
            }
            db = db0.ToString();
            DatabaseForm f = new DatabaseForm(this);
            f.Show();
            this.Hide();
        }

        private void add_db_btn_Click(object sender, EventArgs e)
        {
            string newdb = new_db_input.Text;
            error_label.Text = "";
            if (newdb == null || newdb == "" || dbs.Contains(newdb)||!Regex.IsMatch(newdb,@"[a-zA-Z_0-9]+"))
            {
                error_label.Text = "пусте ім'я або ім'я вже зайняте або символи не a-zA-Z_0-9!";
                return;
            }
            string post_str = "{ \"add_db\":{\"login\":\"" + login + "\",\"name\":\""+newdb+"\" }}";


            var httpWebRequest = (HttpWebRequest)WebRequest.Create(server);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                streamWriter.Write(post_str);
            }
            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();


            string post_str2 = "{ \"get_dbs\":{\"login\":\"" + login + "\" }}";


            var httpWebRequest2 = (HttpWebRequest)WebRequest.Create(server);
            httpWebRequest2.ContentType = "application/json";
            httpWebRequest2.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest2.GetRequestStream()))
            {



                streamWriter.Write(post_str2);
            }
            var httpResponse2 = (HttpWebResponse)httpWebRequest2.GetResponse();
            using (var streamReader = new StreamReader(httpResponse2.GetResponseStream()))
            {
                var serializer = new JavaScriptSerializer();
                var result = streamReader.ReadToEnd();
                var json = serializer.Deserialize<string>(result);
                json = json.Replace("\"", "");
                json = json.Replace("[", "");
                json = json.Replace("]", "");
                var arr = json.Split(",");
                dbs.Clear();
                dbs_list.Items.Clear();
                foreach (var x in arr)
                {
                    dbs_list.Items.Add(x.Trim());
                    dbs.Add(x.Trim());
                }
                new_db_input.Text = "";
            }

        }

        private void delete_db_btn_Click(object sender, EventArgs e)
        {
            var db0 = dbs_list.SelectedItem;
            error_label.Text = "";
            if (db0 == null)
            {
                error_label.Text = "Оберіть базу!";
                return;
            }
            string post_str = "{ \"delete_db\":{\"login\":\"" + login + "\",\"name\":\"" + db0 + "\" }}";


            var httpWebRequest = (HttpWebRequest)WebRequest.Create(server);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                streamWriter.Write(post_str);
            }
            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();


            string post_str2 = "{ \"get_dbs\":{\"login\":\"" + login + "\" }}";


            var httpWebRequest2 = (HttpWebRequest)WebRequest.Create(server);
            httpWebRequest2.ContentType = "application/json";
            httpWebRequest2.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest2.GetRequestStream()))
            {



                streamWriter.Write(post_str2);
            }
            var httpResponse2 = (HttpWebResponse)httpWebRequest2.GetResponse();
            using (var streamReader = new StreamReader(httpResponse2.GetResponseStream()))
            {
                var serializer = new JavaScriptSerializer();
                var result = streamReader.ReadToEnd();
                var json = serializer.Deserialize<string>(result);
                json = json.Replace("\"", "");
                json = json.Replace("[", "");
                json = json.Replace("]", "");
                var arr = json.Split(",");
                dbs.Clear();
                dbs_list.Text = "";
                dbs_list.Items.Clear();
                foreach (var x in arr)
                {
                    dbs_list.Items.Add(x.Trim());
                    dbs.Add(x.Trim());
                }
                new_db_input.Text = "";
            }
        }
    }
}
