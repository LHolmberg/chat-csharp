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
    public partial class Form1 : Form
    {
        int friendId;
        Socket socket;
        EndPoint epLocal, epRemote;
        byte[] buffer;
        List<User> Users;

        public Form1()
        {
            InitializeComponent();
            SendBtn.Enabled = false;
        }

        private void SendBtn_Click(object sender, EventArgs e)
        {
            ASCIIEncoding enc = new ASCIIEncoding();
            byte[] msg = new byte[1500];
            msg = enc.GetBytes(SendTxt.Text);

            socket.Send(msg);
            if (SendTxt.Text != "")
            {
                listBox1.Items.Add(Users[MainMenu.userID].username + ": " + SendTxt.Text);
                SendTxt.Clear();
            }
        }

        private void SendTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MessageCallback(IAsyncResult ar)
        {
            try
            {
                int size = socket.EndReceiveFrom(
                    ar,
                    ref epRemote);

                if (size > 0)
                {
                    ASCIIEncoding enc = new ASCIIEncoding();
                    byte[] recievedData = new byte[1464];
                    recievedData = (byte[])ar.AsyncState;
                    string recievedMessage = enc.GetString(recievedData);
                    listBox1.Items.Add(comboBox1.SelectedItem.ToString() + ": " + recievedMessage);
                }

                buffer = new byte[1500];
                socket.BeginReceiveFrom(
                    buffer,
                    0,
                    buffer.Length,
                    SocketFlags.None,
                    ref epRemote,
                    new AsyncCallback(MessageCallback),
                    buffer);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            using (StreamReader r = new StreamReader("DATA.json"))
            {
                string json = r.ReadToEnd();
                List<User> items = JsonConvert.DeserializeObject<List<User>>(json);
                Users = items;
                for(int i = 0; i < items.Count; i++)
                {
                    comboBox1.Items.Add(items[i].username);
                }
                label3.Text = "Your Username: " + items[MainMenu.userID].username;
            }
            socket = new Socket(
               AddressFamily.InterNetwork,
               SocketType.Dgram,
               ProtocolType.Udp);

            socket.SetSocketOption(
                SocketOptionLevel.Socket,
                SocketOptionName.ReuseAddress,
                true);

            Disconnect.Enabled = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            try
            {
                epLocal = new IPEndPoint(
                    IPAddress.Parse(Users[MainMenu.userID].ip), Users[MainMenu.userID].port);
                socket.Bind(epLocal);

                epRemote = new IPEndPoint(IPAddress.Parse(Users[friendId].ip), Users[friendId].port);
                socket.Connect(epRemote);

                buffer = new byte[1500];
                socket.BeginReceiveFrom(
                    buffer,
                    0,
                    buffer.Length,
                    SocketFlags.None,
                    ref epRemote,
                    new AsyncCallback(MessageCallback),
                    buffer);

                SendBtn.Enabled = true;
                StartButton.Text = "Connected to " + Users[friendId].username;
                Disconnect.Enabled = true;
                Disconnect.Text = "Disconnect from " + Users[friendId].username;
                StartButton.Enabled = false;
                SendTxt.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private static bool IsSocketConnected(Socket socket)
        {
            try
            {
                return !(socket.Poll(1, SelectMode.SelectRead) && socket.Available == 0);
            }
            catch (SocketException) { return false; }
        }
        private void Disconnect_Click(object sender, EventArgs e)
        {
            try
            {
                socket.Shutdown(SocketShutdown.Both);
            }
            finally
            {
                socket.Close();
            }
            Disconnect.Enabled = false;
            Disconnect.Text = "Disconnect";

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            for(int i = 0; i < Users.Count; i++)
            {
                if (Users[i].username == Users[Int32.Parse(comboBox1.SelectedIndex.ToString())].username)
                    friendId = i;
                
            }
        }
    }
}
