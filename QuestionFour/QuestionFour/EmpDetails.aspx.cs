using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace QuestionFour
{
    public partial class EmpDetails : System.Web.UI.Page
    {

        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["QuestionsDBConnectionString"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            txtEmpDep.Text = txtEmpName.Text = txtEmpSalary.Text = "";
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into emps values('" + txtEmpName.Text + "','" + txtEmpDep.Text + "','" + txtEmpSalary.Text + "')", conn);
            
            cmd.ExecuteNonQuery();
            
            
           // DataTable dt = new DataTable();
           // SqlDataAdapter da = new SqlDataAdapter(cmd);
          //  da.Fill(dt);
            //GridView1.DataSource = dt;
            GridView1.DataBind();
            conn.Close();

            txtEmpDep.Text = txtEmpName.Text = txtEmpSalary.Text = "";
        }
    }
}