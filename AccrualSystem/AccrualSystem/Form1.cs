﻿using System;
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
            int num = 0;
           string date = dateStartDate.Value.ToShortDateString();
           
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into employees values('"+txtEmployeeID.Text+"','"+txtEmployeeName.Text+"','"+date+"','"+cmbSeniority.Text+"', '"+num+"')";
            cmd.ExecuteNonQuery();
            conn.Close();
            display();

            txtEmployeeID.Text = " ";
            txtEmployeeName.Text = " ";
            cmbSeniority.Text = " ";
            
        }

        public void display() {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from employees";
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
    }
}
