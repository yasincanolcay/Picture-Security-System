using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Picture_Security_System
{
    public partial class WarningCard : Form
    {
        private SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\csharp projelerim\Picture Security System\Picture Security System\Database1.mdf';Integrated Security=True");

        public int id = 0;
        public bool warningMode = false;
        private bool sendTelegram = false;
        private string token = "";
        private string Tid = "";
        public WarningCard()
        {
            InitializeComponent();
            System.Windows.Forms.ThreadExceptionDialog.CheckForIllegalCrossThreadCalls = false;
        }

        private void closePicture_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (!warningMode)
            {
                string query = "DELETE Images where Id=@id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                Thread th = new Thread(new ThreadStart(send));
                th.Start();
                this.Close();
            }
            else
            {
                this.Close();
            }
        }
        private void send()
        {
            try
            {
                sendNotificationToTelegram("Picture Security\nUyarı: Bir adet fotoğraf silindi\n" + DateTime.Now.ToString());
            }
            catch { }
        }
        private void WarningCard_Load(object sender, EventArgs e)
        {
            if (warningMode)
            {
                deleteButton.Text = "Tamam";
            }
            else
            {
                readSettingsData();
            }
        }
        private void readSettingsData()
        {
            string query = "SELECT * From [Settings]";
            using (SqlCommand command = new SqlCommand(query, connection))
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
