using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PopChat
{
    public partial class registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Authorization_Checker();
        }
        private void Authorization_Checker()
        {
            if (!String.IsNullOrEmpty((string)Session["Authorization"]))
            {
                Response.Redirect("lobby.aspx");
            }
        }
        private void CheckValues(Models.User user)
        {
            DataBase.DB DB = new DataBase.DB();
            if (!DB.CheckRegistration(user, out object res))
            {
                if ((int)res == 1) { Error_Label.InnerText = "Такой Логин уже используется."; }
                else if ((int)res == 2) { Error_Label.InnerText = "Такой E-Mail уже используется."; }
            }
            else
            {
                if (DB.Registration(user))
                {
                    Session["Authorization"] = user.GetLogin();
                    Response.Redirect("lobby.aspx");
                }
                else { Error_Label.InnerText = "Произошла ошибка при добавлении в базу данных. Попробуйте позже."; }
            }

        }
        protected void Registration_Click(object sender, EventArgs e)
        {
            string sName = Name.Text.Trim();
            string sLogin = Login.Text.Trim();
            string sEmail = Email.Text.Trim();
            string sPassword = Password.Text.Trim();
            string sPasswordAgain = PasswordAgain.Text.Trim();
            if (String.IsNullOrWhiteSpace(sName) || sName.Count() < 2 || sName.Count() > 250) { LabelName.Attributes.Add("style", "color:red"); LabelName.Text = "Имя содержит 2 и больше символов"; }
            else if (String.IsNullOrWhiteSpace(sLogin) || sLogin.Count() < 3 || sLogin.Count() > 250) { LabelLogin.Attributes.Add("style", "color:red"); LabelLogin.Text = "Логин содержит 3 и больше символов"; }
            else if (String.IsNullOrWhiteSpace(sEmail) || sEmail.Count() < 4 || sEmail.Count() > 250) { LabelEmail.Attributes.Add("style", "color:red"); LabelEmail.Text = "Email содержит 4 и больше символов"; }
            else if (String.IsNullOrWhiteSpace(sPassword) || sPassword.Count() < 6 || sPassword.Count() > 250) { LabelPassword.Attributes.Add("style", "color:red"); LabelPassword.Text = "Пароль содержит 6 и больше символов"; }
            else if (!sPassword.Equals(sPasswordAgain)) { LabelPasswordAgain.Attributes.Add("style", "color:red"); LabelPasswordAgain.Text = "Пароли не совпадают"; }
            else { Models.User user = new Models.User(0, sName, sLogin, sEmail, sPassword); CheckValues(user); }
        }
    }
}