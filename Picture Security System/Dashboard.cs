using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Picture_Security_System
{
    public partial class Dashboard : Form
    {
        private SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\csharp projelerim\Picture Security System\Picture Security System\Database1.mdf';Integrated Security=True");
        public bool onlyFavorites = false;
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            if (!onlyFavorites)
            {
                loadData();
            }
            else
            {
                loadFavorites();
            }
        }
        private void loadData()
        {
            flowLayoutPanel1.Controls.Clear();
            string query = "SELECT * From [Images]";
            using (SqlCommand command = new SqlCommand(query,connection))
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ImageCard card = new ImageCard();
                    card.TopLevel = false;
                    card.id = Convert.ToInt32(reader["Id"]);
                    Byte[] data = new byte[0];
                    data = (Byte[])(reader["Image"]);
                    card.photoByte = data;
                    card.descriptionLabel.Text = reader["Description"].ToString();
                    if (Convert.ToInt32(reader["Favorite"]) == 1)
                        card.favorite = true;
                    flowLayoutPanel1.Controls.Add(card);
                    card.Show();
                }
                reader.Close();
                connection.Close();
            }
            ForScroll scroll = new ForScroll();
            scroll.TopLevel = false;
            flowLayoutPanel1.Controls.Add(scroll);
            scroll.Show();
        }
        private void loadFavorites()
        {
            flowLayoutPanel1.Controls.Clear();
            string query = "SELECT * From [Images] where Favorite='"+1+"'";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ImageCard card = new ImageCard();
                    card.TopLevel = false;
                    card.id = Convert.ToInt32(reader["Id"]);
                    Byte[] data = new byte[0];
                    data = (Byte[])(reader["Image"]);
                    card.photoByte = data;
                    card.descriptionLabel.Text = reader["Description"].ToString();
                    if (Convert.ToInt32(reader["Favorite"]) == 1)
                        card.favorite = true;
                    flowLayoutPanel1.Controls.Add(card);
                    card.Show();
                }
                reader.Close();
                connection.Close();
            }
            ForScroll scroll = new ForScroll();
            scroll.TopLevel = false;
            flowLayoutPanel1.Controls.Add(scroll);
            scroll.Show();
        }
    }
}
