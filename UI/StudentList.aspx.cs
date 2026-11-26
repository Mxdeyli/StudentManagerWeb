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
    public partial class StudentList : System.Web.UI.Page
    {
        StudentBLL bll = new StudentBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                BindStudents();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddStudent.aspx");
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id=Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value);
            if(bll.DeleteStudent(id))
            {
                Response.Write("<script>alert('删除成功!');</script>");
            }
            else
            {
                Response.Write("<script>alert('删除失败!');</script>");
            }
            BindStudents();
        }

        private void BindStudents()
        {
            GridView1.DataSource = bll.GetAllStudents();
            GridView1.DataBind();
        }
    }
}
