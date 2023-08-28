using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PopChat
{
    public partial class profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Authorization_Checker();
            LoadUser();
        }
        private void Authorization_Checker()
        {
            if (String.IsNullOrEmpty((string)Session["Authorization"]))
            {
                Response.Redirect("login.aspx");
            }
        }
        private void LoadUser()
        {
            if (Int32.TryParse(Request.QueryString["userid"], out int ID))
            {
                DataBase.DB DB = new DataBase.DB();
                foreach (var item in DB.GetUser(ID))
                {
                    UserLogin.InnerText = item.GetLogin();
                    Email.Text = item.GetEmail();
                    foreach (var item2 in DB.GetUserSettings(item.GetID()))
                    {
                        Country.Text = item2.GetCountyCity();
                        MessageCount.Text = item2.GetMessageCount().ToString();
                        UserImage.ImageUrl = item2.GetProfileImage();
                        Intereses.Text = item2.GetInterests();
                        foreach (var item3 in DB.GetLastTimeOnline(item.GetLogin()))
                        {
                            string Date = item3.GetLastTimeOnline().ToString();
                            if (Date.Contains(DateTime.Now.ToString()))
                            {
                                Online.Text = "Сегодня, в " + Date.Substring(11);
                            }
                            else { Online.Text = Date; }
                        }

                    }
                }
            }
            else { Response.Redirect("lobby.aspx"); }

        }
    }
}