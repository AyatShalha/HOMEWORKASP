using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HOMEWORKASP
{
    public partial class ResultQueryString : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LbName.Text = Request.QueryString["Name"];
            LbAge.Text = Request.QueryString["Age"];
        }
    }
}