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
    public partial class AskCard : Form
    {
        private string answer = "";
        public Panel formViewerPanel = new Panel();
        public CreatePassword lockScreen = new CreatePassword();
        private int id = 0;
        public AskCard()
        {
            InitializeComponent();
        }

        private void AskCard_Load(object sender, EventArgs e)
        {
            readAsk();
        }
        private void readAsk()
        {
            string ask = "";
            bool isExists = false;
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\csharp projelerim\Picture Security System\Picture Security System\Database1.mdf';Integrated Security=True");
            string query = "SELECT * From [Login]";
            using(SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    id = Convert.ToInt32(reader["Id"]);
                    ask = reader["SecurityAsk"].ToString();
                    answer = reader["SecurityAnswer"].ToString();
                }
                reader.Close();
                connection.Close();
                isExists = true;
            }
            if (isExists)
            {
                askLabel.Text = ask;
            }
        }

        private void next_Click(object sender, EventArgs e)
        {
            if (Decrypt(answer).Equals(answerBox.Text))
            {
                ChangePassword change = new ChangePassword();
                change.TopLevel = false;
                change.Dock = DockStyle.Fill;
                change.id = id;
                change.formViewerPanel = formViewerPanel;
                change.lockScreen = lockScreen;
                formViewerPanel.Controls.Clear();
                formViewerPanel.Controls.Add(change);
                change.Show();
            }
            else
            {
                WarningCard warning = new WarningCard();
                warning.warningMode = true;
                warning.headerLabel.Text = "Yanlış Cevap!";
                warning.detailsLabel.Text = "Güvenlik sorusunu yanlış cevapladınız!";
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
