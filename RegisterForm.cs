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
    public partial class RegisterForm : Form
    {
        string server = "http://localhost:8000?wsdl";
        bool closed = false;
        LoginForm f0;
        public RegisterForm(LoginForm f)
        {
            f0 = f;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            string login = this.email_input.Text;
            string post_str = "{ \"register\":{\"login\":\"" + login + "\" }}";


            var temp = new Dictionary<string, string>() { { "login", login } };
            Dictionary<string, Dictionary<string, string>> test = new Dictionary<string, Dictionary<string, string>>() {
                {"log_in",temp }
            };

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
                string json = serializer.Deserialize<string>(result);
                this.register_label_error.Text = "";
                if (json == "\"OK\"")
                {
                    closed = true;
                    f0.set_login(login);
                    f0.Show();
                    this.Close();
                    
                }
                else
                {
                    this.register_label_error.Text = json;
                }
            }
            //log_in(post_str, server);
        }

        private void RegisterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!closed) { 
                f0.Show();
                this.Close();
            }
        }
    }
}
