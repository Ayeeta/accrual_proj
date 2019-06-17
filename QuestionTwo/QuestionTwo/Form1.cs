using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuestionTwo
{
    public partial class Form1 : Form
    {
        String imgName;
        
        int totalCost;
        int tomatoes = 300;
        int carrots = 100;
        int onions = 200;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
           imgName  = listBox1.SelectedItem.ToString();
          
            pictureBox1.Image = Image.FromFile(@"..\..\imgs\"+imgName+".jpg");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCost_Click(object sender, EventArgs e)
        {
          
            if (imgName == "Tomatoes")
            {
                lblCost.Text = tomatoes.ToString();
            }
            else if (imgName == "Onions")
            {
                lblCost.Text = onions.ToString();
            }
            else if (imgName == "Carrots")
            {
                lblCost.Text = carrots.ToString();
            }
            else 
            {
                lblCost.Text = "0";
            }
        }

        private void btnTotalCost_Click(object sender, EventArgs e)
        {
            if (imgName == "Tomatoes")
            {
                totalCost = tomatoes * Convert.ToInt32(txtQuantity.Text);
              
                lblTotalCost.Text = string.Format("{0:#,0.0}", totalCost);
            }
            else if (imgName == "Onions")
            {
                totalCost = onions * Convert.ToInt32(txtQuantity.Text);
                lblTotalCost.Text = string.Format("{0:#,0.0}", totalCost);
            }
            else if (imgName == "Carrots")
            {
                totalCost = carrots * Convert.ToInt32(txtQuantity.Text);
                lblTotalCost.Text = string.Format("{0:#,0.0}", totalCost);
            }
            else
            {
                lblTotalCost.Text = "0";
            }
        }
    }
}
