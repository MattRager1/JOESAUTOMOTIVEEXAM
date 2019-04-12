using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JOESAUTOMOTIVEEXAM
{
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox4.MaxLength = 50;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.MaxLength = 30;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.MaxLength = 50;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Open File Dialog
            OpenFileDialog open = new OpenFileDialog();

            //Image Filters
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif *.bmp)|*.jpg; *.jpeg";

            if (open.ShowDialog() == DialogResult.OK)
            {
                //Display image in a picture box
                pictureBox10.Image = new Bitmap(open.FileName);

                //image file path
                pictureBox10.Text = open.FileName;
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }
    }
}
