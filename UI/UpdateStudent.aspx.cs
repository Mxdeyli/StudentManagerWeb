using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using Model;

namespace UI
{
    public partial class UpdateStudent : System.Web.UI.Page
    {
        StudentBLL bll=new StudentBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                int id = int.Parse(Request.QueryString["id"]);
                Student student = bll.SelectStudent(id);
                txt_num.Text = student.Num.ToString();
                txt_name.Text = student.Name;
                if(student.Age!=null)
                {
                    txt_age.Text = student.Age.ToString();
                }
                txt_class.Text = student.Class.ToString();
                txt_phone.Text = student.Phone;
                txt_speciality.Text = student.Speciality;
                txt_phone.Text = student.Phone;
                RadioButtonList1.SelectedValue = student.Sex;
            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["id"]);
            if(bll.SelectCount(txt_num.Text))
            {
                Student student = bll.SelectStudent(id);
                if (txt_num.Text.Trim()!=student.Num.ToString().Trim())
                {
                    Response.Write("<script>alert('学号已存在！')</script>");
                    return;
                }
            }
            Student stu = bll.SelectStudent(id);
            stu.Num = txt_num.Text.Trim();
            stu.Name = txt_name.Text.Trim();
            if (txt_age.Text.Trim()!=string.Empty)
            {
                stu.Age = int.Parse(txt_age.Text.Trim());
            }
            stu.Class = txt_class.Text.Trim();
            stu.Phone = txt_phone.Text.Trim();
            stu.Speciality = txt_speciality.Text.Trim();
            stu.Sex = RadioButtonList1.SelectedValue;
            if(bll.UpdateStudent(stu))
            {
                Response.Write("<script>alert('修改成功！');window.location.href='StudentList.aspx';</script>");
            }
            else
            {
                Response.Write("<script>alert('修改失败！')</script>");
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }
    }
}