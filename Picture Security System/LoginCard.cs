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
    public partial class LoginCard : Form
    {
        public CreatePassword lockScreen = new CreatePassword();
        public LoginCard()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            if(passwordBox.Text != string.Empty)
            {
                string password = "";
                bool isExists = false;
                SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\csharp projelerim\Picture Security System\Picture Security System\Database1.mdf';Integrated Security=True");
                string query = "SELECT * From [Login]";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        password = reader["Password"].ToString();
                    }
                    reader.Close();
                    connection.Close();
                    isExists = true;
                }
                if (isExists)
                {
                    if (Decrypt(password).Equals(passwordBox.Text))
                    {
                        lockScreen.Hide();
                        Form1 form = new Form1();
                        form.lockScreen = lockScreen;
                        form.Show();
                        passwordBox.Clear();
                        password = "";
                        isExists = false;
                    }
                    else
                    {
                        WarningCard warning = new WarningCard();
                        warning.warningMode = true;
                        warning.headerLabel.Text = "Yanlış Şifre!";
                        warning.detailsLabel.Text = "Yanlış şifre lütfen tekrar deneyin.";
                        warning.ShowDialog();
                    }
                }
                else
                {
                    WarningCard warning = new WarningCard();
                    warning.warningMode = true;
                    warning.headerLabel.Text = "Kullanıcı Bulunamadı!";
                    warning.detailsLabel.Text = "Girdiğiniz bilgilerle eşleşen kullanıcı yok.";
                    warning.ShowDialog();
                }
            }
            else
            {
                WarningCard warning = new WarningCard();
                warning.warningMode = true;
                warning.headerLabel.Text = "Şifre Boş!";
                warning.detailsLabel.Text = "Lütfen şifre alanını boş bırakmayın.";
                warning.ShowDialog();
            }
        }
        public static string Decrypt(string cipherText)
        {
            string EncryptionKey = "0ram@1234xxxxxxxxxxtttttuuuuuiiiiio";  //we can change the code converstion key as per our requirement, but the decryption key should be same as encryption key    
            cipherText = cipherText.Replace(" ", "+");
            byte[] cipherBytes = Convert.FromBase64String(cipherText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] {
            0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76
        });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                        cs.Close();
                    }
                    cipherText = Encoding.Unicode.GetString(ms.ToArray());
                }
            }
            return cipherText;
        }
    }
}
