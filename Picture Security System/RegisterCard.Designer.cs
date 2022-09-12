
namespace Picture_Security_System
{
    partial class RegisterCard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterCard));
            this.viewerPanel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.register = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.askBox = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.answerBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.viewerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.register)).BeginInit();
            this.SuspendLayout();
            // 
            // viewerPanel
            // 
            this.viewerPanel.Controls.Add(this.pictureBox2);
            this.viewerPanel.Controls.Add(this.register);
            this.viewerPanel.Controls.Add(this.label5);
            this.viewerPanel.Controls.Add(this.label4);
            this.viewerPanel.Controls.Add(this.label3);
            this.viewerPanel.Controls.Add(this.askBox);
            this.viewerPanel.Controls.Add(this.panel3);
            this.viewerPanel.Controls.Add(this.answerBox);
            this.viewerPanel.Controls.Add(this.panel1);
            this.viewerPanel.Controls.Add(this.passwordBox);
            this.viewerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewerPanel.Location = new System.Drawing.Point(0, 0);
            this.viewerPanel.Name = "viewerPanel";
            this.viewerPanel.Size = new System.Drawing.Size(300, 324);
            this.viewerPanel.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(125, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // register
            // 
            this.register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.register.Image = ((System.Drawing.Image)(resources.GetObject("register.Image")));
            this.register.Location = new System.Drawing.Point(100, 229);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(100, 78);
            this.register.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.register.TabIndex = 17;
            this.register.TabStop = false;
            this.register.Click += new System.EventHandler(this.register_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(53, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Soru";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(53, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Şifre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(53, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Cevap";
            // 
            // askBox
            // 
            this.askBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.askBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.askBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.askBox.ForeColor = System.Drawing.Color.White;
            this.askBox.FormattingEnabled = true;
            this.askBox.Items.AddRange(new object[] {
            "En sevdiğiniz okul arkadaşınızın adı nedir ?",
            "En sevdiğiniz yemek nedir ?",
            "Seyahat etmek istediğiniz ülke neresidir ?",
            "En büyük hayaliniz nedir ?"});
            this.askBox.Location = new System.Drawing.Point(56, 79);
            this.askBox.Name = "askBox";
            this.askBox.Size = new System.Drawing.Size(188, 32);
            this.askBox.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel3.Location = new System.Drawing.Point(56, 158);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(188, 3);
            this.panel3.TabIndex = 10;
            // 
            // answerBox
            // 
            this.answerBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.answerBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.answerBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.answerBox.ForeColor = System.Drawing.Color.White;
            this.answerBox.Location = new System.Drawing.Point(56, 132);
            this.answerBox.Name = "answerBox";
            this.answerBox.Size = new System.Drawing.Size(188, 26);
            this.answerBox.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Location = new System.Drawing.Point(56, 208);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 3);
            this.panel1.TabIndex = 8;
            // 
            // passwordBox
            // 
            this.passwordBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.passwordBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.passwordBox.Location = new System.Drawing.Point(56, 182);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(188, 26);
            this.passwordBox.TabIndex = 1;
            this.passwordBox.UseSystemPasswordChar = true;
            // 
            // RegisterCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(300, 324);
            this.Controls.Add(this.viewerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterCard";
            this.Text = "RegisterCard";
            this.viewerPanel.ResumeLayout(false);
            this.viewerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.register)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel viewerPanel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox register;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox askBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox answerBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox passwordBox;
    }
}