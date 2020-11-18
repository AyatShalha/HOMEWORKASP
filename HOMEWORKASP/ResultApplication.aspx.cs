using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HOMEWORKASP
{
    public partial class ResultApplication : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LbName.Text = Application["Name"].ToString();
            LbAge.Text = Application["Age"].ToString();
        }
    }
}