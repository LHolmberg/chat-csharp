using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace Chat
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e) // Go to Create Account
        {
            PasswordTxt.Visible = false;
            LoginBtn.Visible = false;
            UsernameTxt.Visible = false;
            label1.Visible = false;

            CreateAccPassword.Visible = true;
            CreateAccPort.Visible = true;
            CreateAccIP.Visible = true;
            CreateAccount.Visible = true;
            CreateAccUsername.Visible = true;
            BackBtn.Visible = true;
            label2.Visible = false;
            CreateAccIP.Text = GetLocalIp();
       
        }
        private string GetLocalIp()
        {
            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return "127.0.0.1";
        }
        private void button1_Click(object sender, EventArgs e) // Create Account
        {
            bool usedUsername = false;
            int userCount = 0;
            using (StreamReader r = new StreamReader("DATA.json"))
            {
                string json = r.ReadToEnd();
                List<User> items = JsonConvert.DeserializeObject<List<User>>(json);
                if (items.Count > 0)
                {
                    for (int i = 0; i < items.Count; i++)
                    {
                        if (items[i].username == CreateAccUsername.Text)
                            usedUsername = true;
                    }
                }
                userCount = items.Count;
            }
            if (usedUsername == false)
            {
                userID = userCount;
                string text = System.IO.File.ReadAllText(@"DATA.json");
                string res = "";
                for (int i = 0; i < text.Length; i++)
                {
                    if (i != text.Length - 1)
                    {
                        res += text[i];
                    }
                }
                res += "{ \"username\": \"" + CreateAccUsername.Text + "\", \"password\": \"" + CreateAccPassword.Text + "\", \"ip\": \"" + CreateAccIP.Text + "\", \"port\": \"" + Int32.Parse(CreateAccPort.Text) + "\"},]";
                File.WriteAllText("DATA.json", res);
                var form = new Form1();
                this.Hide();
                form.Show();
                
            } else
            {
                label2.Text = "The username you tried is already used, please use another one.";
                label2.Visible = true;
            }

        }

        public static int userID;
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            using (StreamReader r = new StreamReader("DATA.json"))
            {
                string json = r.ReadToEnd();
                List<User> items = JsonConvert.DeserializeObject<List<User>>(json);
                for(int i = 0; i < items.Count; i++)
                {
                    if(items[i].username == UsernameTxt.Text && items[i].password == PasswordTxt.Text)
                    {
                        var form = new Form1();
                        userID = i;
                        this.Hide();
                        form.Show();
                       
                    }
                }
                label2.Text = "The credentials you entered is wrong.";
                label2.Visible = true;
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            PasswordTxt.Visible = true;
            LoginBtn.Visible = true;
            UsernameTxt.Visible = true;
            label1.Visible = true;

            BackBtn.Visible = false;
            label2.Visible = false;
            CreateAccPassword.Visible = false;
            CreateAccount.Visible = false;
            CreateAccUsername.Visible = false;
            CreateAccIP.Visible = false;
            CreateAccPort.Visible = false;
        }

        private void CreateAccUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
    public class User
    {
        public string username;
        public string password;
        public string ip;
        public int port;
    }
}
