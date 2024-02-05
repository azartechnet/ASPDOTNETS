using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormUI
{
    public partial class SessionExample1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (password.Text == "qwe123")
            {
                // Storing email to Session variable  
                Session["email"] = email.Text;
            }
            // Checking Session variable is not empty  
            if (Session["email"] != null)
            {
                // Displaying stored email  
                Label6.Text = "This email is stored to the session.";
                Label7.Text = Session["email"].ToString();
            }
        }
    }
}