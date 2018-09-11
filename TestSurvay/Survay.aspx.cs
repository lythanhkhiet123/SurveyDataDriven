using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TestSurvay.Model;
using System.Data.SqlClient;
using TestSurvay.Controls;

namespace TestSurvay
{
    public partial class Survay : System.Web.UI.Page
    {
        //private static int currentQuestionId = 1;
        // get IP address
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

            string ip = GetIPAddress();
            DateTime date = GetUserDateDidSurvey();
            Response.Write("<script>alert('"+date+"');</script>");
            Object userAnser = Session["UserAnswer"];
            if (userAnser != null)
            {
                Label1.Text = Session["UserAnswer"].ToString();
            }
            Stack<int> followupQuestions = (Stack<int>) Session["FOLLOWUP_ID_LIST"];
           if(followupQuestions == null)
           {
               followupQuestions = new Stack<int>();
               followupQuestions.Push(1);
               Session["FOLLOWUP_ID_LIST"] = followupQuestions;
           }

            int currentQuestionIdInSeeion = followupQuestions.Peek();
            //Session["CURRENT_QUESTION_ID"] = currentQuestionIdInSeeion;
            

          

            Question question = getNextQuestion(currentQuestionIdInSeeion);

          if (question != null)
          {
              QuestionText.Text = question.text;
              if (question.type.Equals("text"))
              {
                  // We gonna create text box question control

         
                  TextBoxUserControl textBox = (TextBoxUserControl)LoadControl("~/Controls/TextBoxUserControl.ascx");
                  textBox.ID = "AnswerTxtBox";
                  PlaceHolder1.Controls.Add(textBox);
                  Session["CURRENT_QUESTION_TYPE"] = textBox.ID;
              }
              else if (question.type.Equals("radio"))
              {
                  // We gonna create radio button question control
                  RadioButtonUserControl radioBtnQuestion = (RadioButtonUserControl)LoadControl("~/Controls/RadioButtonUserControl.ascx");
                  radioBtnQuestion.ID = "RadioButton";
              
                  Session["CURRENT_QUESTION_TYPE"] = radioBtnQuestion.ID;

                  List<QuestionOption> questionOptions = getQuestionOptions(currentQuestionIdInSeeion);

                  foreach(QuestionOption option in  questionOptions) {
                      ListItem newItem = new ListItem();
                      newItem.Text = option.text;
                      radioBtnQuestion.getControl().Items.Add(newItem);
                  }

                  PlaceHolder1.Controls.Add(radioBtnQuestion);
                  
              }
              else if (question.type.Equals("checkbox"))
              {
                  // We gonna create check box question control
                  CheckBoxUserControl checkBoxQuestion = (CheckBoxUserControl)LoadControl("~/Controls/CheckBoxUserControl.ascx");
                  checkBoxQuestion.ID = "CheckBoxButton";
                  Session["CURRENT_QUESTION_TYPE"] = checkBoxQuestion.ID;
                  //CheckBoxList checkBoxQuestion = new CheckBoxList();
                  List<QuestionOption> questionOptions = getQuestionOptions(currentQuestionIdInSeeion);

                  foreach (QuestionOption option in questionOptions)
                  {
                      
                      ListItem newItem = new ListItem();
                      newItem.Value = option.id.ToString();
                      newItem.Text = option.text;
                      if(option.next_q_id != null)
                      {
                          newItem.Attributes["next_q_id"] = option.next_q_id.ToString();
                      }
                      checkBoxQuestion.getControl().Items.Add(newItem);
                  }
                  
                  PlaceHolder1.Controls.Add(checkBoxQuestion);
              }
          }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           
            
            
        }

        private Question getNextQuestion(int currentQuestionId)
        {
            //currentQuestionId++;

            Question q = null;

            using (SqlConnection conn = new SqlConnection("Data Source=SQL5027.site4now.net;Initial Catalog=DB_9AB8B7_D18DDA5931;User Id=DB_9AB8B7_D18DDA5931_admin;Password=np4Y9CJR"))
            {
                SqlCommand cmd = new SqlCommand("select * from Question where id =" + currentQuestionId, conn);
                conn.Open();
                SqlDataReader rd = cmd.ExecuteReader();

                if (rd.Read())
                {
                    q = new Question();
                   q.text = rd["question_text"].ToString();
                   q.type = rd["q_type"].ToString();
                   q.next_q_id = rd["next_q_id"] as int?;
                   

                }
            }

            return q;
        }

        private List<QuestionOption> getQuestionOptions(int currentQuestionId)
        {
            List<QuestionOption> options = new List<QuestionOption>();
            using (SqlConnection conn = new SqlConnection("Data Source=SQL5027.site4now.net;Initial Catalog=DB_9AB8B7_D18DDA5931;User Id=DB_9AB8B7_D18DDA5931_admin;Password=np4Y9CJR"))
            {
                SqlCommand cmd = new SqlCommand("select * from Question_Options where q_id =" + currentQuestionId, conn);
                conn.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                QuestionOption op = null;

                while (rd.Read())
                {
                    op = new QuestionOption();
                    op.text = rd["option_text"].ToString();
                    options.Add(op);
                    op.next_q_id = rd["next_q_id"] as int?;
                    op.id = (int) rd["id"];
                }
            }

            return options;
        }

        private void insertNextQuestionID(int nextQuestionID, Stack<int> followupList)
        {
            if (!followupList.Contains(nextQuestionID))
            {
                followupList.Push(nextQuestionID);
            }
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Stack<int> followUpQuestionList = (Stack<int>)Session["FOLLOWUP_ID_LIST"];
            // Accesss the current question from PlaceHolder
            Control userControl = PlaceHolder1.FindControl(Session["CURRENT_QUESTION_TYPE"].ToString());
            int currentQuestionIdInSeeion = followUpQuestionList.Pop();
            Question question = getNextQuestion(currentQuestionIdInSeeion);
            if (question.next_q_id != null)
            {
                //followUpQuestionList.Push((int)question.next_q_id);            
                insertNextQuestionID((int)question.next_q_id, followUpQuestionList);
            }
            if (userControl is TextBoxUserControl)
            {
                TextBoxUserControl textBoxcontr = (TextBoxUserControl)userControl;
                //Label1.Text = textBoxcontr.getControl().Text;
                Session["UserAnswer"] = textBoxcontr.getControl().Text;
                System.Diagnostics.Debug.WriteLine("Answer = " + textBoxcontr.getControl().Text);
            }
            else if (userControl is CheckBoxUserControl)
            {
                CheckBoxUserControl checkBoxcontr = (CheckBoxUserControl)userControl;
                string answerVar = "";
                foreach (ListItem item in checkBoxcontr.getControl().Items)
                {
                    if (item.Selected)
                    {

                        answerVar += item.Value + ",";

                        if (item.Attributes["next_q_id"] != null)
                        {
                            //followUpQuestionList.Push(int.Parse(item.Attributes["next_q_id"]));
                            insertNextQuestionID((int.Parse(item.Attributes["next_q_id"])), followUpQuestionList);
                        }

                        //answerVar += item.Attributes["next_q_id"] + ",";
                    }
                }
                Session["UserAnswer"] = answerVar;
                //List<string> next_q = new List<string>(answerVar.Split(','));

                //Session["CURRENT_QUESTION_ID"] = next_q.First();
                //Response.Redirect("Survay.aspx");
            }
            else
            {
                // Radio button
            }
            if (followUpQuestionList.Count() > 0)
            {



                Session["CURRENT_QUESTION_ID"] = question.next_q_id;
                Response.Redirect("Survay.aspx");
            }
            else
            {
                Response.Redirect("EndSurvey.aspx");
            }
        }
    }

}