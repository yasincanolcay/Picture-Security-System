using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Picture_Security_System
{
    public partial class SettingsPage : Form
    {
        private SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\csharp projelerim\Picture Security System\Picture Security System\Database1.mdf';Integrated Security=True");
        string toggleOn = "icons/toggle_on_64px.png";
        string toggleOff = "icons/toggle_off_64px.png";
        private int id = 0;
        private bool startToggleCheck = false;
        private bool sendToggleCheck = false;
        bool isReady = false;
        public SettingsPage()
        {
            InitializeComponent();
        }

        private void SettingsPage_Load(object sender, EventArgs e)
        {
            ReadSettingsData();
        }
        private void ReadSettingsData()
        {
            string query = "SELECT * From [Settings]";
            using(SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    id = Convert.ToInt32(reader["Id"]);
                    if (Convert.ToInt32(reader["Start"]) == 1)
                    {
                        startToggle.Image = Image.FromFile(toggleOn);
                    }
                    if (Convert.ToInt32(reader["Send"]) == 1)
                    {
                        sendToggle.Image = Image.FromFile(toggleOn);
                    }
                    tokenBox.Text = reader["Token"].ToString();
                    idBox.Text = reader["Tid"].ToString();
                }
                reader.Close();
                connection.Close();
                isReady = true;
            }
        }
        private void updateSettings(dynamic parameters,string where)
        {
            if (isReady)
            {
                string query = "UPDATE Settings SET " + where + "=@param where Id=@id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@param", parameters);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }

        private void startToggle_Click(object sender, EventArgs e)
        {
            if (startToggleCheck)
            {
                //işaret kaldırıldı ise Regeditten açılışta çalıştırılacaklardan kaldır
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
                key.DeleteValue("Picture Security");
                updateSettings(0, "Start");
                startToggleCheck = false;
                startToggle.Image = Image.FromFile(toggleOff);
            }
            else
            {
                //işaretlendi ise Regedit e açılışta çalıştır olarak ekle
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
                key.SetValue("Picture Security", "\"" + Application.ExecutablePath + "\"");
                updateSettings(1, "Start");
                startToggleCheck = true;
                startToggle.Image = Image.FromFile(toggleOn);
            }
        }

        private void sendToggle_Click(object sender, EventArgs e)
        {
            if (sendToggleCheck)
            {
                updateSettings(0, "Send");
                sendToggleCheck = false;
                sendToggle.Image = Image.FromFile(toggleOff);
            }
            else
            {
                updateSettings(1, "Send");
                sendToggleCheck = true;
                sendToggle.Image = Image.FromFile(toggleOn);
            }
        }

        private void tokenBox_TextChanged(object sender, EventArgs e)
        {
            updateSettings(tokenBox.Text, "Token");
        }

        private void idBox_TextChanged(object sender, EventArgs e)
        {
            updateSettings(idBox.Text, "Tid");
        }
    }
}
