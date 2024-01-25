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
        public void Calendar1_SelectionChanged(object sender,EventArgs e)
        {
            ShowDate.Text="You Selected:"+ Calendar1.SelectedDate.ToString("D"); ;
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            var message = "";
            if(CheckBox1.Checked)
            {
                message = CheckBox1.Text + "";
            }
            if(CheckBox2.Checked)
            {
                message += CheckBox2.Text + "";
            }
            if(CheckBox3.Checked)
            {
                message += CheckBox3.Text;
            }
            ShowCourses.Text = message; 
        }
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Label1.Text = "Welcome to the Application";
        }
    }
}