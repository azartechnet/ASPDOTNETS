using System;
using System.Collections.Generic;
using System.IO;
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
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            if((FileUpload1.PostedFile!=null)&&(FileUpload1.PostedFile.ContentLength>0))
            {
                string fn=System.IO.Path.GetFileName(FileUpload1.PostedFile.FileName);
                string SaveLocation = Server.MapPath("upload") + "\\" + fn;
                try
                {
                    FileUpload1.PostedFile.SaveAs(SaveLocation);
                    FileUploadStatus.Text = "The file has been uploaded";
                    Console.Write(SaveLocation);
                }
                catch(Exception ex) { 
                   FileUploadStatus.Text=ex.Message;
                }
            }
            else
            {
                FileUploadStatus.Text = "Please select file to uploaded";
            }
        }
       protected void Button4_Click(object sender, EventArgs e)
        {
            string filePath = "D:\\ASPDOTNETS\\WebFormUI\\upload\\fee.txt";
            FileInfo file=new FileInfo(filePath);
            if(file.Exists)
            {
                Response.Clear();
                Response.AddHeader("Content-Disposition", "attachment;filename=" + file.Name);
            }
        }
    }
}