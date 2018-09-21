using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace TestSurvay
{
    public partial class EndSurvey : System.Web.UI.Page
    {
        protected string GetIPAddress()
        {
            System.Web.HttpContext context = System.Web.HttpContext.Current;
            string ipAddress = context.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];

            if (!string.IsNullOrEmpty(ipAddress))
            {
                string[] addresses = ipAddress.Split(',');
                if (addresses.Length != 0)
                {
                    return addresses[0];
                }
            }

            return context.Request.ServerVariables["REMOTE_ADDR"];
        }
        protected DateTime GetUserDateDidSurvey()
        {
            DateTime dateTime = DateTime.Now;

            return dateTime;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {

            
            var dateSurvey = GetUserDateDidSurvey().Date;
            var list = (List<String>)Session["AnswerList"];
            string id = Session["UserID"].ToString();
            /* foreach(var answer in list)
             {
                 System.Diagnostics.Debug.WriteLine("Answer: "+answer);
             }*/
            var list2 = (List<String>)Session["QuestionList"];
            /*
            foreach (var answer2 in list2)
            {
                System.Diagnostics.Debug.WriteLine("Question: " + answer2);
            }*/


            for (int i = 0; i < list.Count; i++)
            {
                System.Diagnostics.Debug.WriteLine("Answer: " + list[i]);
                System.Diagnostics.Debug.WriteLine("Question: " + list2[i]);
                using (SqlConnection conn = new SqlConnection("Data Source=SQL5027.site4now.net;Initial Catalog=DB_9AB8B7_D18DDA5931;User Id=DB_9AB8B7_D18DDA5931_admin;Password=np4Y9CJR"))
                {
                    string sql = "INSERT INTO Answer (q_id, anwer, person_answer, respondent_ip,respondent_date) VALUES(" + list2[i] + ",'" + list[i] + "','" + id + "','" + GetIPAddress() + "','" + dateSurvey.ToString("yyyy-MM-dd") + "'); ";

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    conn.Open();
                    SqlDataReader rd = cmd.ExecuteReader();

                    if (rd.Read())
                    {



                    }

                }



            }


            /* using (SqlConnection conn = new SqlConnection("Data Source=SQL5027.site4now.net;Initial Catalog=DB_9AB8B7_D18DDA5931;User Id=DB_9AB8B7_D18DDA5931_admin;Password=np4Y9CJR"))
             {
                 string sql = "";

                 SqlCommand cmd = new SqlCommand(sql, conn);
                 conn.Open();
                 SqlDataReader rd = cmd.ExecuteReader();

             }*/
        } catch(Exception error)
            {
                System.Diagnostics.Debug.WriteLine("Error: "+error);
            }


        }
    }
}