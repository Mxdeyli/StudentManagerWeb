using System;
using System.Web.UI;
using BLL;
using Model;

namespace UI
{
    public partial class AddStudent : Page
    {
        private readonly StudentBLL bll = new StudentBLL();

        protected void Button1_Click(object sender, EventArgs e)
        {
            string number = txt_num.Text.Trim();
            string name = txt_name.Text.Trim();
            string studentClass = txt_class.Text.Trim();
            string speciality = txt_speciality.Text.Trim();
            if (number.Length == 0 || name.Length == 0 || studentClass.Length == 0 || speciality.Length == 0)
            {
                Response.Write("<script>alert('请填写学号、姓名、班级和专业！');</script>");
                return;
            }

            string ageText = txt_age.Text.Trim();
            int parsedAge = 0;
            if (ageText.Length > 0 && (!int.TryParse(ageText, out parsedAge) || parsedAge <= 0))
            {
                Response.Write("<script>alert('年龄请输入正整数！');</script>");
                return;
            }

            if (bll.SelectCount(number))
            {
                Response.Write("<script>alert('学号已存在！');</script>");
                return;
            }

            var student = new Student
            {
                Num = number,
                Name = name,
                Class = studentClass,
                Speciality = speciality,
                Age = ageText.Length == 0 ? (int?)null : parsedAge,
                Phone = txt_phone.Text.Trim(),
                Sex = RadioButtonList1.SelectedItem?.Value
            };
            if (bll.InsertStudent(student))
                Response.Redirect("StudentList.aspx");
            else
                Response.Write("<script>alert('新增信息失败！');</script>");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            txt_num.Text = txt_name.Text = txt_class.Text = txt_speciality.Text = txt_age.Text = txt_phone.Text = "";
            RadioButtonList1.ClearSelection();
        }
    }
}
