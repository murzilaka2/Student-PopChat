using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PopChat.Parts
{
    public partial class NavBar : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Authorization_Checker();
            LoadUserImage();
        }
        private void Authorization_Checker()
        {
            if (!String.IsNullOrEmpty((string)Session["Authorization"]))
            {
                RegistrationButton.Visible = false;
                UserInfo.Text = "Выход";
                UserInfo.PostBackUrl = null;
                UserInfo.Click += new EventHandler(Exit_Click);
                UserImage.Visible = true;
                DataBase.DB DB = new DataBase.DB();
                UserPlace.Controls.Add(new LiteralControl("<a href=\"../profile.aspx?userid="+DB.GetUserID((string)Session["Authorization"]) +"\"><li class=\"nav-item nav-trial navbar-user\">"));
                UserPlace.Controls.Add(new LiteralControl((string)Session["Authorization"]));
                UserPlace.Controls.Add(new LiteralControl("</li></a>"));
                LastTimeOnline();

            }
        }
        private void LoadUserImage()
        {
            DataBase.DB DB = new DataBase.DB();
            string Image = DB.LoadUserImage((string)Session["Authorization"]);
            if (!String.IsNullOrEmpty(Image))
            {
                UserImage.ImageUrl = Image;
            }
        }
        private void LastTimeOnline()
        {
            DataBase.DB DB = new DataBase.DB();
            DB.LastTimeOnline((string)Session["Authorization"]);
        }
        void Exit_Click(Object sender, EventArgs e)
        {
            Session["Authorization"] = null;
            Response.Redirect("index.aspx");
        }
      
    }
}