using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Discount
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         double Subtotal;
         double DiscountPercent; 
         double DiscountAmount;
         double InvoiceTotal;    
         Subtotal = double.Parse(txtSubtotal.Text);
         if (Subtotal >=500) 
         {
             DiscountPercent = 0.2;
         }
         else if (Subtotal >= 250 && Subtotal < 500)
         {
             DiscountPercent = 0.15;
         }
         else if (Subtotal >= 100 && Subtotal < 250)
         {
             DiscountPercent = 0.1;
         }
         else
         {
             DiscountPercent = 0.0;
         }
         DiscountAmount = Subtotal * DiscountPercent;
         InvoiceTotal = Subtotal - DiscountAmount;
         txtDiscountPercent.Text = DiscountPercent.ToString("p1"); //p1 means percentage 
         txtDiscountAmount.Text = "$" + DiscountAmount.ToString();
         txtTotal.Text = "$" + InvoiceTotal.ToString();
         txtResult.Text = "Dear Customer you have to pay: $" + InvoiceTotal.ToString();
        }
    }
}
