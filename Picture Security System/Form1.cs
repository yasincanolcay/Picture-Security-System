using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Picture_Security_System
{
    public partial class Form1 : Form
    {
        //----FORM BORDER RADIUS DESIGN---//
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int NLeftRect
          , int NRightRect, int NTopRect, int NBottomRect, int NWidthEllipse, int NHeightEllipse);

        //----------------------------------------//
        //FORM EKRANDA SURUKLEMEK ICIN INT KONUM DEGISKENLERI VE BOOL
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        //----------------------------------------//
        public CreatePassword lockScreen = new CreatePassword();

        private bool sendTelegram = false;
        private string token = "";
        private string Tid = "";

        public Form1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));//form border yuvarla
            System.Windows.Forms.ThreadExceptionDialog.CheckForIllegalCrossThreadCalls = false;
        }
        private void readSettingsData()
        {
            bool isReady = false;
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\csharp projelerim\Picture Security System\Picture Security System\Database1.mdf';Integrated Security=True");
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
                        isReady = true;
                    }
                }
                reader.Close();
                connection.Close();
            }
            if (isReady && sendTelegram)
            {
                Thread th = new Thread(new ThreadStart(send));
                th.Start();
            }
        }
        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void panel3_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void closePicture_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizePicture_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void menuIconPanel_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void menuIconPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void menuIconPanel_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void menuPanel_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void menuPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void menuPanel_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void dashboardButton_Click(object sender, EventArgs e)
        {
            dashboardButton.BackColor = Color.FromArgb(46, 51, 73);
            favoritesButton.BackColor = Color.FromArgb(24, 30, 54);
            settingsButton.BackColor = Color.FromArgb(24, 30, 54);
            loadDashboardOrFavorite(false);
        }
        private void loadDashboardOrFavorite(bool favorite)
        {
            Dashboard dash = new Dashboard();
            dash.TopLevel = false;
            dash.Dock = DockStyle.Fill;
            dash.onlyFavorites = favorite;
            pageViewerPanel.Controls.Clear();
            pageViewerPanel.Controls.Add(dash);
            dash.Show();
        }
        private void loadSettingsPage()
        {
            SettingsPage settings = new SettingsPage();
            settings.TopLevel = false;
            settings.Dock = DockStyle.Fill;
            pageViewerPanel.Controls.Clear();
            pageViewerPanel.Controls.Add(settings);
            settings.Show();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            readSettingsData();
            loadDashboardOrFavorite(false);
        }
        private void send()
        {
            try
            {
                sendNotificationToTelegram("Picture Security\nUyarı: Yeni bir giriş yapıldı\n" + DateTime.Now.ToString());
            }
            catch
            {
                connectionPicture.Visible = true;
            }
        }
        private byte[] ImageToStream(string fileName)
        {
            MemoryStream stream = new MemoryStream();
            tryagain:
            try
            {
                Bitmap image = new Bitmap(fileName);
                var type = image.RawFormat;
                image.Save(stream, type);
            }
            catch
            {
                goto tryagain;
            }

            return stream.ToArray();
        }

        private void addPhotoPicture_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = ("Resim (*.jpg)|*.jpg|png (*.png)|*.png|gif (*.gif)|*.gif");
            openFileDialog1.Title = "Resim Dosyası Seçin";
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != "openFileDialog1" && openFileDialog1.FileName != "")
            {
                byte[] photoByte = { };
                photoByte = ImageToStream(openFileDialog1.FileName);
                ImportPhoto import = new ImportPhoto();
                import.photoByte = photoByte;
                import.ShowDialog();
            }
        }

        private void favoritesButton_Click(object sender, EventArgs e)
        {
            favoritesButton.BackColor = Color.FromArgb(46, 51, 73);
            dashboardButton.BackColor = Color.FromArgb(24, 30, 54);
            settingsButton.BackColor = Color.FromArgb(24, 30, 54);
            loadDashboardOrFavorite(true);
        }

        private void lockPicture_Click(object sender, EventArgs e)
        {
            lockScreen.Show();
            this.Close();
        }

        private void notifyPicture_Click(object sender, EventArgs e)
        {
            //GİZLİ SİMGE KISMINA INDIR
            Hide();
            notifyIcon1.Visible = true;
            notifyIcon1.ShowBalloonTip(3000);
        }
        private void settingsButton_Click(object sender, EventArgs e)
        {
            settingsButton.BackColor = Color.FromArgb(46, 51, 73);
            dashboardButton.BackColor = Color.FromArgb(24, 30, 54);
            favoritesButton.BackColor = Color.FromArgb(24, 30, 54);
            loadSettingsPage();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            notifyShowForm();
        }
        private void notifyShowForm()
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
        }

        private void gösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notifyShowForm();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Notifications send to your telegram account
        //Bildirimleri telegram hesabınıza gönderir
        private string sendNotificationToTelegram(string message)
        {
            string urlString = $"https://api.telegram.org/bot{token}/sendMessage?chat_id={Tid}&text={message}";
            WebClient webclient = new WebClient();
            return webclient.DownloadString(urlString);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
