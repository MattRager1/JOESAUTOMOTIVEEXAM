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
    public partial class Invoice : Form
    {
        public Invoice()
        {
            InitializeComponent();
        }

        private void calulationButton_Click(object sender, EventArgs e)
        {
            // Declaring variables
            double laborcost, partsused, partstotal, tax, taxamount, subtotal, finaltotal;

            //Getting the totals from the TextBox
            laborcost = double.Parse(textBox1.Text);
            partsused = double.Parse(textBox4.Text);
            partstotal = double.Parse(textBox3.Text);
            tax = double.Parse(textBox2.Text);

            //calculate the amount
            subtotal = laborcost + partsused + partstotal;
            taxamount = subtotal * 0.06;
            finaltotal = subtotal + taxamount;

            //Checking for the checkbox
            if (checkBox1.Checked)
            {
                finaltotal = finaltotal + 24.99;
            }
            //Display the Final total?
            textBox5.Text = finaltotal.ToString();
        }
    }
}
