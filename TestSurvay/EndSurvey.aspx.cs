using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestSurvay
{
    public partial class EndSurvey : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var list = (List<String>)Session["AnswerList"];
            foreach(var answer in list)
            {
                System.Diagnostics.Debug.WriteLine(answer);
            }
        }
    }
}