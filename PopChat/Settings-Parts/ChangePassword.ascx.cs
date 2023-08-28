using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PopChat.Setting_Parts
{
    public partial class ChangePassword : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Sumbit_Click(object sender, EventArgs e)
        {
            string sPasswordOld = PasswordOld.Text.Trim();
            string sPassword = Password.Text.Trim();
            string sPasswordAgain = PasswordAgain.Text.Trim();          
            if (sPassword.Equals(sPasswordAgain))
            {
                if (String.IsNullOrWhiteSpace(sPasswordOld) && sPasswordOld.Count() < 6 || sPasswordOld.Count() > 250)
                {
                    Error_Label.Text = "Пароль содержит 6 и больше символов.<br/>";
                }
                else if (OldPasswordCheck(sPasswordOld) == false) { Error_Label.Text = "Текущий пароль указан не верно.<br/>"; }
                else
                {
                    DataBase.DB DB = new DataBase.DB();
                    if (DB.ChangeUserPassword((string)Session["Authorization"], sPassword))
                    {
                        Error_Label.Text = "Пароль успешно изменен.<br/>";
                    }
                    else
                    {
                        Error_Label.Text = "Ошибка. Попробуйте позже.<br/>";
                    }
                }
            }
            else
            {
                Error_Label.Text = "Укажите одиннаковые пароли.<br/>";
            }
        }
        private bool OldPasswordCheck(string sPasswordOld)
        {
            DataBase.DB DB = new DataBase.DB();
            if (DB.CheckUserPassword((string)Session["Authorization"], sPasswordOld))
            {
                return true;
            }
            else { return false; }
        }
    }
}