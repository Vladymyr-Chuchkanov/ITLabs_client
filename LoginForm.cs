using Nancy.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITLabs_client
{
    public partial class LoginForm : Form
    {
        
        string server = "http://localhost:8000?wsdl";
        public string email;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string login = this.input_login.Text;
            string post_str = "{ \"log_in\":{\"login\":\""+login+"\" }}";
            

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
                this.login_error_label.Text = "";
                if (json == "\"OK\"")
                {
                    email = login;
                    AccountForm f= new AccountForm(this);
                    f.Show();
                    this.Hide();
                }
                else { 
                    this.login_error_label.Text = json;
                }
            }
            //log_in(post_str, server);
            

        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            RegisterForm f = new RegisterForm(this);
            f.Show();
            this.Hide();
        }
        public void set_login(string login)
        {
            this.input_login.Text = login;
        }
    }
}
