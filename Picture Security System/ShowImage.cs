using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Picture_Security_System
{
    public partial class ShowImage : Form
    {
        public byte[] photoByte = { };
        public ShowImage()
        {
            InitializeComponent();
        }

        private void ShowImage_Load(object sender, EventArgs e)
        {
            MemoryStream mem = new MemoryStream(photoByte);
            ImageBox.Image = Image.FromStream(mem);
        }
    }
}
