
namespace Picture_Security_System
{
    partial class ImportPhoto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportPhoto));
            this.ImageBox = new System.Windows.Forms.PictureBox();
            this.descriptionTextbox = new System.Windows.Forms.TextBox();
            this.addPhotoPic = new System.Windows.Forms.PictureBox();
            this.closePic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addPhotoPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePic)).BeginInit();
            this.SuspendLayout();
            // 
            // ImageBox
            // 
            this.ImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImageBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.ImageBox.Location = new System.Drawing.Point(0, 0);
            this.ImageBox.Name = "ImageBox";
            this.ImageBox.Size = new System.Drawing.Size(300, 254);
            this.ImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImageBox.TabIndex = 0;
            this.ImageBox.TabStop = false;
            // 
            // descriptionTextbox
            // 
            this.descriptionTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.descriptionTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descriptionTextbox.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.descriptionTextbox.ForeColor = System.Drawing.Color.White;
            this.descriptionTextbox.Location = new System.Drawing.Point(0, 257);
            this.descriptionTextbox.Name = "descriptionTextbox";
            this.descriptionTextbox.Size = new System.Drawing.Size(300, 16);
            this.descriptionTextbox.TabIndex = 1;
            this.descriptionTextbox.Text = "Title...";
            // 
            // addPhotoPic
            // 
            this.addPhotoPic.Image = ((System.Drawing.Image)(resources.GetObject("addPhotoPic.Image")));
            this.addPhotoPic.Location = new System.Drawing.Point(271, 275);
            this.addPhotoPic.Name = "addPhotoPic";
            this.addPhotoPic.Size = new System.Drawing.Size(25, 25);
            this.addPhotoPic.TabIndex = 2;
            this.addPhotoPic.TabStop = false;
            this.addPhotoPic.Click += new System.EventHandler(this.addPhotoPic_Click);
            // 
            // closePic
            // 
            this.closePic.Image = ((System.Drawing.Image)(resources.GetObject("closePic.Image")));
            this.closePic.Location = new System.Drawing.Point(240, 275);
            this.closePic.Name = "closePic";
            this.closePic.Size = new System.Drawing.Size(25, 25);
            this.closePic.TabIndex = 3;
            this.closePic.TabStop = false;
            this.closePic.Click += new System.EventHandler(this.closePic_Click);
            // 
            // ImportPhoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.closePic);
            this.Controls.Add(this.addPhotoPic);
            this.Controls.Add(this.descriptionTextbox);
            this.Controls.Add(this.ImageBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ImportPhoto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İçe Aktar";
            this.Load += new System.EventHandler(this.ImportPhoto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addPhotoPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ImageBox;
        private System.Windows.Forms.TextBox descriptionTextbox;
        private System.Windows.Forms.PictureBox addPhotoPic;
        private System.Windows.Forms.PictureBox closePic;
    }
}