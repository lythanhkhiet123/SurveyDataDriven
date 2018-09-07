using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestSurvay.Controls
{
    public partial class RadioButtonUserControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public RadioButtonList getControl()
        {
            return RadioButtonList1;
        }
    }
}