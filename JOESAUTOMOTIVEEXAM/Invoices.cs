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
    public partial class Invoices : Form
    {
        public Invoices()
        {
            InitializeComponent();
        }

        private void calulationButton_Click(object sender, EventArgs e)
        {
            // Declaring variables
            double laborcost, partsused, taxamount, subtotal, finaltotal;

            //Getting the totals from the TextBox
            laborcost = double.Parse(textBox1.Text);
            partsused = double.Parse(textBox4.Text);
                   
            //calculate the amount
            subtotal = laborcost + partsused;
            taxamount = subtotal * 0.06;
            finaltotal = subtotal + taxamount;

            //Checking for the checkbox
            if (checkBox1.Checked)
            {
                finaltotal = finaltotal + 24.99;
            }
            //Displays the Final total
            textBox5.Text = finaltotal.ToString();
            textBox2.Text = taxamount.ToString();
            textBox3.Text = subtotal.ToString();
        }
    }
}
