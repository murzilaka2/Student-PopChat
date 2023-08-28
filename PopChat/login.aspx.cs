using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PopChat
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Authorization_Checker();
        }
        private void CheckValues(string Login, string Password)
        {
            DataBase.DB DB = new DataBase.DB();
            if (DB.Authorization(Login, Password))
            {
                Session["Authorization"] = Login;
                Response.Redirect("lobby.aspx");
            }
            else
            {
                LabelLogin.Attributes.Add("style", "color:red"); LabelLogin.Text = "Не верный логин или пароль.";
            }
        }
        protected void Auth_Button_Click(object sender, EventArgs e)
        {
            string sLogin = Login.Text.Trim();
            string sPassword = Password.Text.Trim();
            if (String.IsNullOrWhiteSpace(sLogin) || sLogin.Count() < 3) { LabelLogin.Attributes.Add("style", "color:red"); LabelLogin.Text = "Логин содержит 3 и больше символов."; }
            else if (String.IsNullOrWhiteSpace(sPassword) || sPassword.Count() < 6) { LabelPassword.Attributes.Add("style", "color:red"); LabelPassword.Text = "Пароль содержит 6 и больше символов."; }
            else
            {
                Helper.Help Help = new Helper.Help();
                CheckValues(Server.HtmlEncode(sLogin), Server.HtmlEncode(Help.MD5HASH(sPassword)));
            }
        }

        private void Authorization_Checker()
        {
            if (!String.IsNullOrEmpty((string)Session["Authorization"]))
            {
                Response.Redirect("lobby.aspx");
            }
        }
    }
}