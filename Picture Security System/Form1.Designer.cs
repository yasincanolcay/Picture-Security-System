
namespace Picture_Security_System
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pageViewerPanel = new System.Windows.Forms.Panel();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.settingsButton = new System.Windows.Forms.Button();
            this.favoritesButton = new System.Windows.Forms.Button();
            this.menuIconPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dashboardButton = new System.Windows.Forms.Button();
            this.topPanel = new System.Windows.Forms.Panel();
            this.connectionPicture = new System.Windows.Forms.PictureBox();
            this.notifyPicture = new System.Windows.Forms.PictureBox();
            this.lockPicture = new System.Windows.Forms.PictureBox();
            this.addPhotoPicture = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.minimizePicture = new System.Windows.Forms.PictureBox();
            this.maximizePicture = new System.Windows.Forms.PictureBox();
            this.closePicture = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.gösterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuPanel.SuspendLayout();
            this.menuIconPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.connectionPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notifyPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lockPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addPhotoPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePicture)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pageViewerPanel
            // 
            this.pageViewerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pageViewerPanel.Location = new System.Drawing.Point(194, 29);
            this.pageViewerPanel.Name = "pageViewerPanel";
            this.pageViewerPanel.Size = new System.Drawing.Size(666, 441);
            this.pageViewerPanel.TabIndex = 2;
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.menuPanel.Controls.Add(this.settingsButton);
            this.menuPanel.Controls.Add(this.favoritesButton);
            this.menuPanel.Controls.Add(this.menuIconPanel);
            this.menuPanel.Controls.Add(this.dashboardButton);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(194, 470);
            this.menuPanel.TabIndex = 3;
            this.menuPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuPanel_MouseDown);
            this.menuPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menuPanel_MouseMove);
            this.menuPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.menuPanel_MouseUp);
            // 
            // settingsButton
            // 
            this.settingsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.settingsButton.FlatAppearance.BorderSize = 0;
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.settingsButton.ForeColor = System.Drawing.Color.White;
            this.settingsButton.Location = new System.Drawing.Point(44, 299);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(107, 41);
            this.settingsButton.TabIndex = 5;
            this.settingsButton.Text = "SETTINGS";
            this.settingsButton.UseVisualStyleBackColor = false;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // favoritesButton
            // 
            this.favoritesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.favoritesButton.FlatAppearance.BorderSize = 0;
            this.favoritesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.favoritesButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.favoritesButton.ForeColor = System.Drawing.Color.White;
            this.favoritesButton.Location = new System.Drawing.Point(44, 252);
            this.favoritesButton.Name = "favoritesButton";
            this.favoritesButton.Size = new System.Drawing.Size(107, 41);
            this.favoritesButton.TabIndex = 4;
            this.favoritesButton.Text = "FAVORITES";
            this.favoritesButton.UseVisualStyleBackColor = false;
            this.favoritesButton.Click += new System.EventHandler(this.favoritesButton_Click);
            // 
            // menuIconPanel
            // 
            this.menuIconPanel.Controls.Add(this.pictureBox1);
            this.menuIconPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuIconPanel.Location = new System.Drawing.Point(0, 0);
            this.menuIconPanel.Name = "menuIconPanel";
            this.menuIconPanel.Size = new System.Drawing.Size(194, 121);
            this.menuIconPanel.TabIndex = 3;
            this.menuIconPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuIconPanel_MouseDown);
            this.menuIconPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menuIconPanel_MouseMove);
            this.menuIconPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.menuIconPanel_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(47, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // dashboardButton
            // 
            this.dashboardButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.dashboardButton.FlatAppearance.BorderSize = 0;
            this.dashboardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboardButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dashboardButton.ForeColor = System.Drawing.Color.White;
            this.dashboardButton.Location = new System.Drawing.Point(44, 205);
            this.dashboardButton.Name = "dashboardButton";
            this.dashboardButton.Size = new System.Drawing.Size(107, 41);
            this.dashboardButton.TabIndex = 2;
            this.dashboardButton.Text = "DASBOARD";
            this.dashboardButton.UseVisualStyleBackColor = false;
            this.dashboardButton.Click += new System.EventHandler(this.dashboardButton_Click);
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.connectionPicture);
            this.topPanel.Controls.Add(this.notifyPicture);
            this.topPanel.Controls.Add(this.lockPicture);
            this.topPanel.Controls.Add(this.addPhotoPicture);
            this.topPanel.Controls.Add(this.panel1);
            this.topPanel.Controls.Add(this.minimizePicture);
            this.topPanel.Controls.Add(this.maximizePicture);
            this.topPanel.Controls.Add(this.closePicture);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(194, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(666, 29);
            this.topPanel.TabIndex = 4;
            this.topPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            this.topPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseMove);
            this.topPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseUp);
            // 
            // connectionPicture
            // 
            this.connectionPicture.Image = ((System.Drawing.Image)(resources.GetObject("connectionPicture.Image")));
            this.connectionPicture.Location = new System.Drawing.Point(95, 1);
            this.connectionPicture.Name = "connectionPicture";
            this.connectionPicture.Size = new System.Drawing.Size(25, 25);
            this.connectionPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.connectionPicture.TabIndex = 7;
            this.connectionPicture.TabStop = false;
            this.connectionPicture.Visible = false;
            // 
            // notifyPicture
            // 
            this.notifyPicture.Image = ((System.Drawing.Image)(resources.GetObject("notifyPicture.Image")));
            this.notifyPicture.Location = new System.Drawing.Point(64, 0);
            this.notifyPicture.Name = "notifyPicture";
            this.notifyPicture.Size = new System.Drawing.Size(25, 25);
            this.notifyPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.notifyPicture.TabIndex = 6;
            this.notifyPicture.TabStop = false;
            this.notifyPicture.Click += new System.EventHandler(this.notifyPicture_Click);
            // 
            // lockPicture
            // 
            this.lockPicture.Image = ((System.Drawing.Image)(resources.GetObject("lockPicture.Image")));
            this.lockPicture.Location = new System.Drawing.Point(33, 0);
            this.lockPicture.Name = "lockPicture";
            this.lockPicture.Size = new System.Drawing.Size(25, 25);
            this.lockPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.lockPicture.TabIndex = 5;
            this.lockPicture.TabStop = false;
            this.lockPicture.Click += new System.EventHandler(this.lockPicture_Click);
            // 
            // addPhotoPicture
            // 
            this.addPhotoPicture.Image = ((System.Drawing.Image)(resources.GetObject("addPhotoPicture.Image")));
            this.addPhotoPicture.Location = new System.Drawing.Point(2, 0);
            this.addPhotoPicture.Name = "addPhotoPicture";
            this.addPhotoPicture.Size = new System.Drawing.Size(25, 25);
            this.addPhotoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.addPhotoPicture.TabIndex = 4;
            this.addPhotoPicture.TabStop = false;
            this.addPhotoPicture.Click += new System.EventHandler(this.addPhotoPicture_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(58)))), ((int)(((byte)(80)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(666, 3);
            this.panel1.TabIndex = 3;
            // 
            // minimizePicture
            // 
            this.minimizePicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizePicture.Image = ((System.Drawing.Image)(resources.GetObject("minimizePicture.Image")));
            this.minimizePicture.Location = new System.Drawing.Point(579, 0);
            this.minimizePicture.Name = "minimizePicture";
            this.minimizePicture.Size = new System.Drawing.Size(25, 25);
            this.minimizePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimizePicture.TabIndex = 2;
            this.minimizePicture.TabStop = false;
            this.minimizePicture.Click += new System.EventHandler(this.minimizePicture_Click);
            // 
            // maximizePicture
            // 
            this.maximizePicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizePicture.Image = ((System.Drawing.Image)(resources.GetObject("maximizePicture.Image")));
            this.maximizePicture.Location = new System.Drawing.Point(610, 0);
            this.maximizePicture.Name = "maximizePicture";
            this.maximizePicture.Size = new System.Drawing.Size(25, 25);
            this.maximizePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.maximizePicture.TabIndex = 1;
            this.maximizePicture.TabStop = false;
            // 
            // closePicture
            // 
            this.closePicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closePicture.Image = ((System.Drawing.Image)(resources.GetObject("closePicture.Image")));
            this.closePicture.Location = new System.Drawing.Point(641, 0);
            this.closePicture.Name = "closePicture";
            this.closePicture.Size = new System.Drawing.Size(25, 25);
            this.closePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closePicture.TabIndex = 0;
            this.closePicture.TabStop = false;
            this.closePicture.Click += new System.EventHandler(this.closePicture_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "Picture Security arka planda açık";
            this.notifyIcon1.BalloonTipTitle = "Picture Security";
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Picture Security";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gösterToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.ShowImageMargin = false;
            this.contextMenuStrip1.Size = new System.Drawing.Size(94, 48);
            // 
            // gösterToolStripMenuItem
            // 
            this.gösterToolStripMenuItem.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gösterToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.gösterToolStripMenuItem.Name = "gösterToolStripMenuItem";
            this.gösterToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.gösterToolStripMenuItem.Text = "Göster";
            this.gösterToolStripMenuItem.Click += new System.EventHandler(this.gösterToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.çıkışToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(860, 470);
            this.Controls.Add(this.pageViewerPanel);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.menuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Picture Security";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuPanel.ResumeLayout(false);
            this.menuIconPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.connectionPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notifyPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lockPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addPhotoPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePicture)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pageViewerPanel;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Button dashboardButton;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel menuIconPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button favoritesButton;
        private System.Windows.Forms.PictureBox closePicture;
        private System.Windows.Forms.PictureBox minimizePicture;
        private System.Windows.Forms.PictureBox maximizePicture;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox addPhotoPicture;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox lockPicture;
        private System.Windows.Forms.PictureBox notifyPicture;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gösterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox connectionPicture;
    }
}

