using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HOMEWORKASP
{
    public partial class Cookie : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("UserInfo");
            cookie["Name"] = TextBox1.Text;
            cookie["Age"] = TextBox2.Text;
            Response.Cookies.Add(cookie);
            Response.Redirect("ResultCookie.aspx");
        }
    }
}