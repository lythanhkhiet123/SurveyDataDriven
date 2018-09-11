using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace TestSurvay
{
    public partial class registerPage : System.Web.UI.Page
    {
        string sql = "";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            
            using (SqlConnection conn = new SqlConnection("Data Source=SQL5027.site4now.net;Initial Catalog=DB_9AB8B7_D18DDA5931;User Id=DB_9AB8B7_D18DDA5931_admin;Password=np4Y9CJR"))
            {
                sql = "insert into registeredusers (firstname, lastname,age,gender,address,surburb,state,postcode,email,phone) output INSERTED.ID values ('" + TextBox1.Text + "','" + TextBox2.Text + "','" + DropDownList1.Text + "','" + DropDownList2.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "','" + DropDownList3.Text + "','" + TextBox8.Text + "','" + TextBox9.Text + "','" + TextBox10.Text + "');";

                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                int modified = (int)cmd.ExecuteScalar();
                //Response.Write("<script>alert('" + modified + "');</script>");
                Session["UserID"] = modified;
                Response.Redirect("Survay.aspx");
            }
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            Session["UserID"] = "Anonymous";
            Response.Redirect("Survay.aspx");
        }
    }
}