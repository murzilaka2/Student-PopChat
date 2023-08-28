using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PopChat.Setting_Parts
{
    public partial class ChangeEmail : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        TextBox CodeText = new TextBox();
        static string sCode;
        static string ssEmail;

        protected void Sumbit_Click(object sender, EventArgs e)
        {
            string sEmail = Email.Text.Trim();
            if (String.IsNullOrWhiteSpace(sEmail) && sEmail.Count() < 4)
            {
                Error_Label.Text = "Email содержит 4 и больше символов.";
            }
            else
            {
                if (SendEmailCode(Server.HtmlEncode(sEmail), out string Code))
                {
                    PlaceCode.Controls.Add(new LiteralControl("<br /><br />Письмо отправлено на указанный Email, введите полученный код.<br /><br /><div class=\"floating-label-wrap\">"));                   
                    CodeText.ID = "CodeText";
                    CodeText.CssClass = "floating-label-field floating-label-field--s3";
                    CodeText.Attributes.Add("required", "true");
                    Label CodeTextLabel = new Label();
                    CodeTextLabel.AssociatedControlID = CodeText.ID;
                    CodeTextLabel.CssClass = "floating-label";
                    CodeTextLabel.Text = "Введите код:";
                    PlaceCode.Controls.Add(CodeText);
                    PlaceCode.Controls.Add(CodeTextLabel);
                    PlaceCode.Controls.Add(new LiteralControl("</div>"));
                    Sumbit.Visible = false;
                    SaveEmail.Visible = true;
                    sCode = Code;
                    ssEmail = sEmail;
                }
                else
                {
                    Error_Label.Text = "Произошла ошибка, попробуйте позже.";
                }

            }
        }
        private bool SendEmailCode(string sEmail, out string Code)
        {
            Code = Membership.GeneratePassword(12, 1);
            try
            {
                MailAddress from = new MailAddress("enykoruna1@gmail.com", "Администрация Pop Chat");
                MailAddress to = new MailAddress(sEmail);
                MailMessage m = new MailMessage(from, to);
                m.Subject = "Pop Chat - Смена E-Mail.";
                m.Body = "Отправлен запрос на смену Email адреса.<br /><b>Код для подтверждения: " + Code + "</b><br />Если вы не отправляли запрос на смену Email адреса," +
                "рекомендуем сменить свой пароль в личном аккаунте, а данное письмо удалить.<br />С наилучшими пожалениями, команда Pop Chat.";
                m.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new NetworkCredential("enykoruna1@gmail.com", "jobs192837leny1996");
                smtp.EnableSsl = true;
                smtp.Send(m);
                smtp.Dispose();
                return true;
            }
            catch { return false; }
        }
        private void ChangeOldEmail(string Email)
        {
            DataBase.DB DB = new DataBase.DB();
            if (DB.ChangeUserEmail((string)Session["Authorization"], Email))
            {
                Error_Label.Text = "Email успешно изменен.<br />";
            }
            else { Error_Label.Text = "Произошла ошибка, попробуйте позже."; }
        }

        protected void SaveEmail_Click(object sender, EventArgs e)
        {
            string UserCode = sCode;
            if (String.IsNullOrWhiteSpace(UserCode) && UserCode.Count() < 11) { Error_Label.Text = "Введите корректный код, длинной 12 символов."; }
            else if (UserCode.Equals(sCode))
            {
                ChangeOldEmail(ssEmail);
            }
            else { Error_Label.Text = "Не верный код."; }
        }
    }
}