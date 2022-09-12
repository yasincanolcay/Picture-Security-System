using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Picture_Security_System
{
    public partial class CreatePassword : Form
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
        bool isLoginPage = true;
        public CreatePassword()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));//form border yuvarla
        }

        private void closePicture_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizePicture_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void topPanel_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void topPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void topPanel_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void CreatePassword_Load(object sender, EventArgs e)
        {
            AccountControl();
        }
        private void AccountControl()
        {
            bool isHave = false;
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\csharp projelerim\Picture Security System\Picture Security System\Database1.mdf';Integrated Security=True");
            string query = "SELECT * From [Login]";
            using(SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isHave = true;
                }
                reader.Close();
                connection.Close();
            }
            if (isHave)
            {
                LoginCard card = new LoginCard();
                card.TopLevel = false;
                card.Dock = DockStyle.Fill;
                card.lockScreen = this;
                viewerPanel.Controls.Add(card);
                card.Show();
            }
            else
            {
                RegisterCard card = new RegisterCard();
                card.TopLevel = false;
                card.Dock = DockStyle.Fill;
                card.formViewerPanel = viewerPanel;
                viewerPanel.Controls.Add(card);
                card.Show();
                changePassword.Visible = false;
            }
        }
        private void leftPanel_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void leftPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void leftPanel_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void changePassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (isLoginPage)
            {
                AskCard ask = new AskCard();
                ask.TopLevel = false;
                ask.Dock = DockStyle.Fill;
                ask.formViewerPanel = viewerPanel;
                ask.lockScreen = this;
                viewerPanel.Controls.Clear();
                viewerPanel.Controls.Add(ask);
                ask.Show();
                changePassword.Text = "Giriş Yapın";
                isLoginPage = false;
            }
            else
            {
                LoginCard card = new LoginCard();
                card.TopLevel = false;
                card.Dock = DockStyle.Fill;
                card.lockScreen = this;
                viewerPanel.Controls.Clear();
                viewerPanel.Controls.Add(card);
                card.Show();
                changePassword.Text = "Şifreyi Sıfırlayın";
                isLoginPage = true;
            }
        }
    }
}
