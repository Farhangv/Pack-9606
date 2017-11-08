using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClientSideDemo
{
    public partial class Authentication : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var username = Request.Form["username"];
            var password = Request.Form["password"];

            if (username == "admin" && password == "admin@123")
            {
                authenticationResult.InnerHtml = "شما با موفقیت وارد سایت شدید";
            }
            else
            {
                authenticationResult.InnerHtml = "نام کاربری یا کلمه عبور شما اشتباه است";
            }
        }
    }
}