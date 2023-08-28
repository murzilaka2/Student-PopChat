using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PopChat
{
    public partial class lobby : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Authorization_Checker();
            if (!IsPostBack) { LoadGlobalMessages(); }
        }
        private void Authorization_Checker()
        {
            if (String.IsNullOrEmpty((string)Session["Authorization"]))
            {
                Response.Redirect("login.aspx");
            }
        }
        private void LoadGlobalMessages()
        {
            Messages.Controls.Clear();
            DataBase.DB DB = new DataBase.DB();
            foreach (var item in DB.LoadGlobalMessage())
            {
                string Login = null;
                foreach (var item2 in DB.GetUser(item.GetUSerID()))
                {
                    Login = item2.GetLogin();
                }
                string MessageColor = "#78ff08";
                string Date = item.GetDate().ToString();
                Messages.Controls.Add(new LiteralControl("<div class=\"card-body cardm\" style=\"border-left:4px solid" + MessageColor + "\">"));
                Messages.Controls.Add(new LiteralControl($"[{Date.Substring(0, Date.Length - 8)}]" +
                $"[{Date.Substring(11)}][<b><a href=\"../profile.aspx?userid={item.GetUSerID()}\">{Login}</a></b>]: {Server.HtmlDecode(item.GetMessageText())}"));
                Messages.Controls.Add(new LiteralControl("</div>"));
            }
        }

        protected void SendMessage_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(CKEditor1.Text))
            {
                string Text = CKEditor1.Text;
                DataBase.DB DB = new DataBase.DB();
                DB.InsertGlobalMessage((string)Session["Authorization"], Server.HtmlEncode(Text), DateTime.Now.ToString());
                CKEditor1.Text = null;
                DB.IncrementMessages((string)Session["Authorization"]);
                LoadGlobalMessages();
            }
        }
    }
}
