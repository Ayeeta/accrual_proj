using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AccrualSystem
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DELL;Initial Catalog=AccrualDB;User ID=sa;Password=sap");
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmployeeID.Text) && string.IsNullOrWhiteSpace(txtEmployeeName.Text) && string.IsNullOrWhiteSpace(cmbSeniority.Text))
            {
                MessageBox.Show("Please enter details");
            }
            else 
            {
                string seniority = cmbSeniority.Text;
                double num = 0;
                int lessThanTwoyears = 2;
                double lessThanFourYears = 2.25;
                double greaterThanFourYears = 2.5;


                string date = dateStartDate.Value.ToShortDateString();
                int startYear = Convert.ToInt32(dateStartDate.Value.Year.ToString());
                int currentYear = Convert.ToInt32(DateTime.Now.Year.ToString());
                int Currentmonth = Convert.ToInt32(DateTime.Now.Month.ToString());
                int startMonth = Convert.ToInt32(dateStartDate.Value.Month);
                int tenure = currentYear - startYear;

                int months = ((currentYear - startYear) * 12) + Currentmonth - startMonth;

                if (tenure <= 2)
                {
                    switch (seniority)
                    {

                        case "A":
                            num = lessThanTwoyears * 5 * Math.Abs(months);
                            break;
                        case "B":
                            num = lessThanTwoyears * 10 * Math.Abs(months);
                            break;
                        case "C":
                            num = lessThanTwoyears * 15 * Math.Abs(months);
                            break;
                        case "D":
                            num = lessThanTwoyears * 20 * Math.Abs(months);
                            break;
                        case "E":
                            num = lessThanTwoyears * 25 * Math.Abs(months);
                            break;
                    }

                }
                else if (tenure > 2 && tenure <= 4)
                {
                    switch (seniority)
                    {

                        case "A":
                            num = lessThanFourYears * 5 * Math.Abs(months);
                            break;
                        case "B":
                            num = lessThanFourYears * 10 * Math.Abs(months);
                            break;
                        case "C":
                            num = lessThanFourYears * 15 * Math.Abs(months);
                            break;
                        case "D":
                            num = lessThanFourYears * 20 * Math.Abs(months);
                            break;
                        case "E":
                            num = lessThanFourYears * 25 * Math.Abs(months);
                            break;
                    }
                }
                else
                {
                    switch (seniority)
                    {

                        case "A":
                            num = greaterThanFourYears * 5 * Math.Abs(months);
                            break;
                        case "B":
                            num = greaterThanFourYears * 10 * Math.Abs(months);
                            break;
                        case "C":
                            num = greaterThanFourYears * 15 * Math.Abs(months);
                            break;
                        case "D":
                            num = greaterThanFourYears * 20 * Math.Abs(months);
                            break;
                        case "E":
                            num = greaterThanFourYears * 25 * Math.Abs(months);
                            break;
                    }
                }
                try 
                {
                    conn.Open();
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into employees values('" + txtEmployeeID.Text + "','" + txtEmployeeName.Text + "','" + date + "','" + seniority + "', '" + num + "')";
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    display();

                    txtEmployeeID.Text = " ";
                    txtEmployeeName.Text = " ";
                    cmbSeniority.Text = " ";
                }
                catch (Exception ex) 
                {
                    MessageBox.Show(" "+ex.Message);
                }
                

                
            }
            
            
        }

        public void display() {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select Employee_ID, Employee_Name, Start_Date, Seniority, Points from employees";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();  
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            display();
        }

        public void points()
        {
            foreach (DataGridViewRow dgvr in dataGridView1.Rows)
            {
                //foreach (DataGridViewCell cell in dgvr.Cells)
                //{
                //    string seniority = cell[].ColumnIndex.ToString();
                //}
                
            }
        }
        
    }
}
