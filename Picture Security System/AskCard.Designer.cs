
namespace Picture_Security_System
{
    partial class AskCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AskCard));
            this.viewerPanel = new System.Windows.Forms.Panel();
            this.next = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.answerBox = new System.Windows.Forms.TextBox();
            this.askLabel = new System.Windows.Forms.Label();
            this.viewerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.next)).BeginInit();
            this.SuspendLayout();
            // 
            // viewerPanel
            // 
            this.viewerPanel.Controls.Add(this.next);
            this.viewerPanel.Controls.Add(this.panel3);
            this.viewerPanel.Controls.Add(this.answerBox);
            this.viewerPanel.Controls.Add(this.askLabel);
            this.viewerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewerPanel.Location = new System.Drawing.Point(0, 0);
            this.viewerPanel.Name = "viewerPanel";
            this.viewerPanel.Size = new System.Drawing.Size(300, 324);
            this.viewerPanel.TabIndex = 2;
            // 
            // next
            // 
            this.next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.next.Image = ((System.Drawing.Image)(resources.GetObject("next.Image")));
            this.next.Location = new System.Drawing.Point(100, 234);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(100, 78);
            this.next.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.next.TabIndex = 12;
            this.next.TabStop = false;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel3.Location = new System.Drawing.Point(56, 215);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(188, 3);
            this.panel3.TabIndex = 10;
            // 
            // answerBox
            // 
            this.answerBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.answerBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.answerBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.answerBox.Location = new System.Drawing.Point(56, 189);
            this.answerBox.Name = "answerBox";
            this.answerBox.Size = new System.Drawing.Size(188, 26);
            this.answerBox.TabIndex = 9;
            // 
            // askLabel
            // 
            this.askLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.askLabel.ForeColor = System.Drawing.Color.White;
            this.askLabel.Location = new System.Drawing.Point(6, 62);
            this.askLabel.Name = "askLabel";
            this.askLabel.Size = new System.Drawing.Size(291, 74);
            this.askLabel.TabIndex = 0;
            this.askLabel.Text = "soru";
            this.askLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AskCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(300, 324);
            this.Controls.Add(this.viewerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AskCard";
            this.Text = "AskCard";
            this.Load += new System.EventHandler(this.AskCard_Load);
            this.viewerPanel.ResumeLayout(false);
            this.viewerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.next)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel viewerPanel;
        private System.Windows.Forms.PictureBox next;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox answerBox;
        private System.Windows.Forms.Label askLabel;
    }
}