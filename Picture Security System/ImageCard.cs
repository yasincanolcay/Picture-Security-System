using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Picture_Security_System
{
    public partial class ImageCard : Form
    {
        //----FORM BORDER RADIUS DESIGN---//
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int NLeftRect
          , int NRightRect, int NTopRect, int NBottomRect, int NWidthEllipse, int NHeightEllipse);

        public int id = 0;
        public byte[] photoByte = { };
        public bool favorite = false;
        string onFavorite = "icons/filled_heart_25px.png";
        string noFavorite = "icons/heart_25px.png";
        public ImageCard()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));//form border yuvarla
        }

        private void ImageCard_Load(object sender, EventArgs e)
        {
            MemoryStream mem = new MemoryStream(photoByte);
            ImageBox.Image = Image.FromStream(mem);
            updateFavImage();
        }

        private void addFavorite_Click(object sender, EventArgs e)
        {
            if (!favorite)
            {
                updateFavorite(1);
                favorite = true;
            }
            else
            {
                updateFavorite(0);
                favorite = false;
            }
            updateFavImage();
        }
        private void updateFavorite(int fav)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\csharp projelerim\Picture Security System\Picture Security System\Database1.mdf';Integrated Security=True");
            string query = "UPDATE Images SET Favorite=@fav where Id=@id";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@fav", fav);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        private void updateFavImage()
        {
            if (favorite)
            {
                addFavorite.Image = Image.FromFile(onFavorite);
            }
            else
            {
                addFavorite.Image = Image.FromFile(noFavorite);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ShowImage show = new ShowImage();
            show.photoByte = photoByte;
            show.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            WarningCard warning = new WarningCard();
            warning.id = id;
            warning.ShowDialog();
        }
    }
}
