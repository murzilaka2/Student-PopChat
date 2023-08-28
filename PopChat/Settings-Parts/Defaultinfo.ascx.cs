using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PopChat.Settings_Parts
{
    public partial class Defaultinfo : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            AgeAdd();
            if (!IsPostBack) { GetUserSettings(); }
        }

        protected void Sumbit_Click(object sender, EventArgs e)
        {
            string sAvatar = Avatar.Text;
            string sCountry = Country.Text.Trim();
            int sAge = 1;
            string sInteres = Interes.Text.Trim();
            if (Int32.TryParse(Age.Text.Trim(), out int n)) { sAge = n; }
            DataBase.DB DB = new DataBase.DB();
            List<Models.UserSettings> UserSettings = new List<Models.UserSettings>();
            UserSettings.Add(new Models.UserSettings(DB.GetUserID((string)Session["Authorization"]), Server.HtmlEncode(sInteres), Server.HtmlEncode(sCountry), Convert.ToSByte(sAge), Server.HtmlEncode(sAvatar), 0));
            SetUserSettings(UserSettings);

        }
        private void AgeAdd()
        {
            for (int i = 12; i < 120; i++)
            {
                Age.Items.Add(i.ToString());
            }
        }
        private void GetUserSettings()
        {
            DataBase.DB DB = new DataBase.DB();
            foreach (var item in DB.GetUser((string)Session["Authorization"]))
            {
                Name.Text = item.GetName();
                Email.Text = item.GetEmail();
                foreach (var item2 in DB.GetUserSettings(item.GetID()))
                {
                    Avatar.Text = item2.GetProfileImage();
                    Country.Text = item2.GetCountyCity();
                    if (item2.GetAge() >= 1)
                    {
                        Age.SelectedValue = item2.GetAge().ToString();
                    }
                    Interes.Text = item2.GetInterests();
                }
            }
        }
        private void SetUserSettings(List<Models.UserSettings> UserSettings)
        {
            DataBase.DB DB = new DataBase.DB();
            if (DB.SetUserSettings(UserSettings)) { Error_Label.Text = "Пользователь успешно изменен."; }
            else { Error_Label.Attributes.Add("style", "color:red"); Error_Label.Text = "Произошла ошибка."; }
        }
    }
}