using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PopChat
{
    public partial class settings : System.Web.UI.Page
    {
        static int C { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            Authorization_Checker();
            Hide();
        }
        private void Authorization_Checker()
        {
            if (String.IsNullOrEmpty((string)Session["Authorization"]))
            {
                Response.Redirect("login.aspx");
            }
        }
        protected void ChangePassword_Click(object sender, EventArgs e)
        {
            C = 1;
            Hide();
        }
        protected void ChangeEmail_Click(object sender, EventArgs e)
        {
            C = 2;
            Hide();
        }
        protected void MessageSettings_Click(object sender, EventArgs e)
        {
            C = 3;
            Hide();
        }
        protected void GeneralInfo_Click(object sender, EventArgs e)
        {
            C = 4;
            Hide();
        }
        private void Hide()
        {
            ChangePasswordPlace.Visible = false;
            ChangeEmailPlace.Visible = false;
            ChangeMessageSettings.Visible = false;
            DefaultInfoPlace.Visible = false;
            if (C==0 || C == 1){ ChangePasswordPlace.Visible = true; }
            else if(C == 2) { ChangeEmailPlace.Visible = true; }
            else if (C == 3) { ChangeMessageSettings.Visible = true; }
            else if (C == 4) { DefaultInfoPlace.Visible = true; }
            
        }
    }
}