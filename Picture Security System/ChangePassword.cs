using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Picture_Security_System
{
    public partial class ChangePassword : Form
    {
        public int id = 0;
        public Panel formViewerPanel = new Panel();
        public CreatePassword lockScreen = new CreatePassword();

        public ChangePassword()
        {
            InitializeComponent();
        }

        private void next_Click(object sender, EventArgs e)
        {
            if (passwordBox.Text != string.Empty && againPasswordBox.Text != string.Empty && passwordBox.Text == againPasswordBox.Text)
            {
                SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\csharp projelerim\Picture Security System\Picture Security System\Database1.mdf';Integrated Security=True");
                string query = "UPDATE Login SET Password=@password where Id=@id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    string password = Encrypt(passwordBox.Text);
                    command.Parameters.AddWithValue("@password", password);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                LoginCard login = new LoginCard();
                login.TopLevel = false;
                login.Dock = DockStyle.Fill;
                login.lockScreen = lockScreen;
                formViewerPanel.Controls.Clear();
                formViewerPanel.Controls.Add(login);
                login.Show();
            }
            else
            {
                WarningCard warning = new WarningCard();
                warning.warningMode = true;
                warning.headerLabel.Text = "Geçersiz Bilgiler!";
                warning.detailsLabel.Text = "Şifre alanı boş veya eşleşmiyor!";
                warning.ShowDialog();
            }
        }
        public static string Encrypt(string encryptString)
        {
            string EncryptionKey = "0ram@1234xxxxxxxxxxtttttuuuuuiiiiio";  //we can change the code converstion key as per our requirement    
            byte[] clearBytes = Encoding.Unicode.GetBytes(encryptString);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] {
            0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76
        });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    encryptString = Convert.ToBase64String(ms.ToArray());
                }
            }
            return encryptString;
        }
    }
}
