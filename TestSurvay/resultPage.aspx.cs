using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace TestSurvay
{
    public partial class resultPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            using (SqlConnection conn = new SqlConnection("Data Source=SQL5027.site4now.net;Initial Catalog=DB_9AB8B7_D18DDA5931;User Id=DB_9AB8B7_D18DDA5931_admin;Password=np4Y9CJR"))
            {
                string sql = Session["sql"].ToString();
                SqlCommand cmd = new SqlCommand(sql, conn);
                
                DataSet data = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                conn.Open();
                da.Fill(data, "Result");
                DataView dv = data.Tables["Result"].DefaultView;


            


                // Bind the GridView control. 
                GridView1.DataSource = dv;
                GridView1.DataBind();
            }
        }
    }
}