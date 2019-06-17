using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuestionOne
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = " ";
            txtMessage.Text = " ";
            lblDisplayMessage.Text = ".";
            lblDisplayMessage.Font = new Font(this.Font, FontStyle.Regular);
            lblDisplayMessage.ForeColor = Color.Black;
            rbtnItalic.Checked = false;
            rbtnUnderline.Checked = false;
            cBoxBold.Checked = false;
            cBoxChangeColor.Checked = false;
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            String name = txtName.Text;
            String message = txtMessage.Text;
            String displayMessage = name + "\n" + message;
            lblDisplayMessage.Text = displayMessage;

            if (rbtnItalic.Checked == true)
            {
                if (cBoxBold.Checked && cBoxChangeColor.Checked) 
                {
                    lblDisplayMessage.Font = new Font(this.Font, FontStyle.Italic | FontStyle.Bold);
                    lblDisplayMessage.ForeColor = Color.Red;

                }
                else if (cBoxBold.Checked)
                {
                    lblDisplayMessage.Font = new Font(this.Font, FontStyle.Italic | FontStyle.Bold);
                }
                else if (cBoxChangeColor.Checked)
                {
                    lblDisplayMessage.Font = new Font(this.Font, FontStyle.Italic);
                    lblDisplayMessage.ForeColor = Color.Red;
                }
                else 
                {
                    lblDisplayMessage.Font = new Font(this.Font, FontStyle.Italic);
                }
                
            }
            else if (rbtnUnderline.Checked == true)
            {
               
                if (cBoxBold.Checked && cBoxChangeColor.Checked)
                {
                    lblDisplayMessage.Font = new Font(this.Font, FontStyle.Underline | FontStyle.Bold);
                    lblDisplayMessage.ForeColor = Color.Red;

                }
                else if (cBoxBold.Checked)
                {
                    lblDisplayMessage.Font = new Font(this.Font, FontStyle.Underline | FontStyle.Bold);
                }
                else if (cBoxChangeColor.Checked)
                {
                    lblDisplayMessage.Font = new Font(this.Font, FontStyle.Underline);
                    lblDisplayMessage.ForeColor = Color.Red;
                }
                else
                {
                    lblDisplayMessage.Font = new Font(this.Font, FontStyle.Underline);
                }
            }
            else 
            {
                if (cBoxBold.Checked && cBoxChangeColor.Checked)
                {
                    lblDisplayMessage.Font = new Font(this.Font, FontStyle.Bold);
                    lblDisplayMessage.ForeColor = Color.Red;

                }
                else if (cBoxBold.Checked)
                {
                    lblDisplayMessage.Font = new Font(this.Font, FontStyle.Bold);
                }
                else if (cBoxChangeColor.Checked)
                {
                   
                    lblDisplayMessage.ForeColor = Color.Red;
                }
                else
                {
                    lblDisplayMessage.Text = displayMessage;
                }
                lblDisplayMessage.Text = displayMessage;
            }
            
        }
    }
}
