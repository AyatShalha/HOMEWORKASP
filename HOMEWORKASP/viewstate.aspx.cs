using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HOMEWORKASP
{
    public partial class viewstate : System.Web.UI.Page
    {
        int ClickCount = 1;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                TextBox1.Text = "0";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (ViewState["clicks"] != null)
            {
                ClickCount = (int)ViewState["clicks"] + 1;
            }
            TextBox1.Text = ClickCount.ToString();
            ViewState["clicks"] = ClickCount;
        }
    }
}