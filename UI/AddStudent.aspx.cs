using BLL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI
{
    public partial class AddStudent : System.Web.UI.Page
    {
        StudentBLL bll =new StudentBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] == null)
            {
                Response.Write("<script>alert('用户未登录');location='Login.aspx'</script>");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (bll.SelectCount(txt_num.Text))
            {
                Response.Write("<script>alert('学号已存在！')</script>");
                return;
            }
            else
            {
            Student stu = new Student();
                stu.Num = txt_num.Text;
                stu.Name = txt_name.Text;
                stu.Class = txt_class.Text;
                stu.Speciality = txt_speciality.Text;
                if (txt_age != null)
                {
                    stu.Age = Convert.ToInt32(txt_age.Text); 
                }
                stu.Phone = txt_phone.Text;
                stu.Sex = RadioButtonList1.SelectedItem.Text;
                if (bll.InsertStudent(stu))
                {
                    Response.Write("<script>alert('插入成功！')</script>");
                    Response.Redirect("StudentList.aspx");
                }
                else 
                {
                    Response.Write("<script>alert('新增信息失败！')</script>");
                }
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }
    }
}