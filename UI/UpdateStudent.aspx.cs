using System;
using System.Web.UI;
using BLL;
using Model;

namespace UI
{
    public partial class UpdateStudent : Page
    {
        private readonly StudentBLL bll = new StudentBLL();
        private Student student;

        protected void Page_Load(object sender, EventArgs e)
        {
            int id;
            if (int.TryParse(Request.QueryString["id"], out id) && id > 0)
                student = bll.SelectStudent(id);

            if (student == null)
            {
                Response.Redirect("StudentList.aspx");
                return;
            }

            if (!IsPostBack)
            {
                txt_num.Text = student.Num;
                txt_name.Text = student.Name;
                txt_age.Text = student.Age?.ToString();
                txt_class.Text = student.Class;
                txt_phone.Text = student.Phone;
                txt_speciality.Text = student.Speciality;
                if (RadioButtonList1.Items.FindByValue(student.Sex ?? "") != null)
                    RadioButtonList1.SelectedValue = student.Sex;
            }
        }

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

            if (number != student.Num.Trim() && bll.SelectCount(number))
            {
                Response.Write("<script>alert('学号已存在！');</script>");
                return;
            }

            student.Num = number;
            student.Name = name;
            student.Class = studentClass;
            student.Speciality = speciality;
            student.Age = ageText.Length == 0 ? (int?)null : parsedAge;
            student.Phone = txt_phone.Text.Trim();
            student.Sex = RadioButtonList1.SelectedItem?.Value;

            if (bll.UpdateStudent(student))
                Response.Redirect("StudentList.aspx");
            else
                Response.Write("<script>alert('修改失败！');</script>");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            txt_num.Text = txt_name.Text = txt_class.Text = txt_speciality.Text = txt_age.Text = txt_phone.Text = "";
            RadioButtonList1.ClearSelection();
        }
    }
}
