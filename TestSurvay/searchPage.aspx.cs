﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace TestSurvay
{
    public partial class searchPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            
            
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            try
            {
                

                string sql = "";
                if (RadioButton1.Checked == true)
                {
                    sql = "select * from Answer where person_answer in( select CONVERT(varchar(20),id) from registeredUsers where firstname = '" + TextBox1.Text + "')";
                }
                else if (RadioButton2.Checked == true)
                {
                    sql = "select* from answer where person_answer in(select person_answer from Answer where q_id = 8 and anwer like '%" + DropDownList1.Text + "%')";
                   
                }
                else if (RadioButton4.Checked == true)
                {
                    sql = "select* from answer where person_answer in(select person_answer from Answer where q_id = 3 and anwer like '%" + DropDownList2.Text + "%')";

                    //sql = "select * from Answer where q_id = 3 and anwer like '%" + DropDownList2.Text + "%'";
                }
                else if (RadioButton6.Checked == true)
                {
                    sql = "select* from answer where person_answer in(select person_answer from Answer where q_id = 2 and anwer like '%" + DropDownList3.Text + "%')";

                    //sql = "select * from Answer where q_id = 2 and anwer like '%" + DropDownList3.Text + "%'";
                }
                else if (RadioButton7.Checked == true)
                {
                    sql = "select* from answer where person_answer in(select person_answer from Answer where q_id = 9 and anwer like '%" + TextBox9.Text + "%')";

                    //sql = "select * from Answer where q_id = 9 and anwer like '%" + TextBox9.Text + "%'";
                }
                else if (RadioButton8.Checked == true)
                {
                    sql = "select* from answer where person_answer in(select person_answer from Answer where q_id = 10 and anwer like '%" + TextBox11.Text + "%')";

                    //sql = "select * from Answer where q_id = 10 and anwer like '%" + TextBox11.Text + "%'";
                }
                else if (RadioButton10.Checked == true)
                {
                    sql = "select* from answer where person_answer in(select person_answer from Answer where q_id = 11 and anwer like '%" + TextBox15.Text + "%')";

                    //sql = "select * from Answer where q_id = 11 and anwer like '%" + TextBox15.Text + "%'";
                }
                else if (RadioButton11.Checked == true)
                {
                    sql = "select* from answer where person_answer in(select person_answer from Answer where q_id = 12 and anwer like '%" + TextBox16.Text + "%')";

                    //sql = "select * from Answer where q_id = 12 and anwer like '%" + TextBox16.Text + "%'";
                }
                else if (RadioButton12.Checked == true)
                {
                    sql = "select* from answer where person_answer in(select person_answer from Answer where q_id = 13 and anwer like '%" + TextBox17.Text + "%')";

                   // sql = "select * from Answer where q_id = 13 and anwer like '%" + TextBox17.Text + "%'";
                }


                Session["sql"] = sql;



                Response.Redirect("resultPage.aspx");
            }catch(Exception error)
            {
                System.Diagnostics.Debug.WriteLine("Error: " + error);
            }
        }

  
    }
}