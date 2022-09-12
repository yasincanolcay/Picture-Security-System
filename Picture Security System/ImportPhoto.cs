using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Picture_Security_System
{
    public partial class ImportPhoto : Form
    {
        private SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\csharp projelerim\Picture Security System\Picture Security System\Database1.mdf';Integrated Security=True");

        public byte[] photoByte = { };
        private bool sendTelegram = false;
        private string token = "";
        private string Tid = "";

        public ImportPhoto()
        {
            InitializeComponent();
            System.Windows.Forms.ThreadExceptionDialog.CheckForIllegalCrossThreadCalls = false;
        }

        private void closePic_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ImportPhoto_Load(object sender, EventArgs e)
        {
            MemoryStream mem = new MemoryStream(photoByte);
            ImageBox.Image = Image.FromStream(mem);
            readSettingsData();
        }
        private void readSettingsData()
        {
            string query = "SELECT * From [Settings]";
            using(SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    if (Convert.ToInt32(reader["Send"]) == 1)
                    {
                        sendTelegram = true;
                        token = reader["Token"].ToString();
                        Tid = reader["Tid"].ToString();
                    }
                }
                reader.Close();
                connection.Close();
            }
        }
        private void addPhotoPic_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO [Images] (Image,Description,Favorite) VALUES (@image,@des,@fav)";
            using(SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@image", photoByte);
                command.Parameters.AddWithValue("@des", descriptionTextbox.Text);
                command.Parameters.AddWithValue("@fav", 0);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            Thread th = new Thread(new ThreadStart(send));
            th.Start();
            this.Close();
        }
        private void send()
        {
            try
            {
                sendNotificationToTelegram("Picture Security\nUyarı: Bir adet fotoğraf eklendi\n" + DateTime.Now.ToString());
            }
            catch { }
        }
        //Notifications send to your telegram account
        //Bildirimleri telegram hesabınıza gönderir
        private string sendNotificationToTelegram(string message)
        {
            string urlString = $"https://api.telegram.org/bot{token}/sendMessage?chat_id={Tid}&text={message}";
            WebClient webclient = new WebClient();
            return webclient.DownloadString(urlString);
        }
    }
}
