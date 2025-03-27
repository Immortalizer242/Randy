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


namespace RandomImagePicker
{
    public partial class Eh : Form
    {
        public Eh()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get all image files in the application's folder
            string[] imageFiles = Directory.GetFiles(Application.StartupPath)
                                  .Where(file => file.EndsWith(".jpg") || file.EndsWith(".png"))
                                  .ToArray();

            // Check if there are any images
            if (imageFiles.Length > 0)
            {
                Random random = new Random();
                int index = random.Next(imageFiles.Length);
                string randomImage = imageFiles[index];

                // Load and display the random image
                pictureBox1.Image = Image.FromFile(randomImage);
            }
            else
            {
                MessageBox.Show("No images found in the application folder.");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Eh_Load(object sender, EventArgs e)
        {

        }
    }
}