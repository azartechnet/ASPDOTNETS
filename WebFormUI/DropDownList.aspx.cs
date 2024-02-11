using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormUI
{
    public partial class DropDownList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        protected void Button1_Click(object sender,EventArgs e)
        {
            if(DropDownList1.SelectedValue=="")
            {
                Label1.Text = "Please select the city";
            }
            else
            {
                Label1.Text="Your Choice"+DropDownList1.SelectedValue;
            }
        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void CheckBox1_CheckedChanged1(object sender, EventArgs e)
        {

        }
    }
}