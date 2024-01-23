using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormsControlls
{
    public partial class WebControls : System.Web.UI.Page
    {


        protected void Button1_Click(object sender, EventArgs e)
        {
            genderId.Text = "";
            if (RadioButton1.Checked)
            {
                genderId.Text = "Your Gender is::" + RadioButton1.Text;
            }
            else
            {
                genderId.Text = "Your Gender is::" + RadioButton2.Text;
            }
        }
    }
}