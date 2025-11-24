using BLL;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI
{
    public partial class UpdatePwd : System.Web.UI.Page
    {
        UserLoginBLL bll = new UserLoginBLL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Session["pwd"] == null)
            {
                Response.Write("<script>alert('登录失效,请重新登陆');windows.location('Login.aspx')</script>");
                return;
            }
            else
            {
                string oldpwd = Session["pwd"].ToString();
                string username = Session["username"].ToString();
                if (oldpwd == txt_oldpwd.Text)
                {
                    if (txt_newpwd.Text == txt_again_newpwd.Text)
                    {
                        if (bll.UpdatePwd(username, txt_newpwd.Text))
                        {
                            Response.Write("<script>alert('密码更新成功！');windows.location('Login.aspx')</script>");
                        }
                        else
                        {
                            Response.Write("<script>alert('密码更新成功！'</script>");
                        }

                    }
                    else
                    {
                        Response.Write("<script>alert('两次密码输入不一致！')</script>");
                    }
                }
                else
                {
                    Response.Write("<script> alert('原始密码输入错误！') </ script >");
                }
            }
            
        }
        
    }
}