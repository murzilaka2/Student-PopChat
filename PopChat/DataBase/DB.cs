using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace PopChat.DataBase
{
    public class DB
    {
        private string Connection = "Data Source = HOME-PC\\SQLEXPRESS; Initial Catalog = popchat; Integrated Security = true;";

        public int GetUserID(string Login)
        {
            try
            {
                int ID = 0;
                List<Models.User> User = new List<Models.User>();
                using (SqlConnection con = new SqlConnection(Connection))
                {
                    con.Open();
                    SqlCommand Url = new SqlCommand("select * from [User] WHERE [Login] = '" + Login + "'", con);
                    SqlDataReader ReaderUrl = Url.ExecuteReader();
                    while (ReaderUrl.Read())
                    {
                        ID = Convert.ToInt32(ReaderUrl.GetValue(0));
                    }
                    ReaderUrl.Close();
                    return ID;
                }
            }
            catch { return 0; }
        }
        public List<Models.User> GetUser(int ID)
        {
            try
            {
                List<Models.User> User = new List<Models.User>();
                using (SqlConnection con = new SqlConnection(Connection))
                {
                    con.Open();
                    SqlCommand Url = new SqlCommand("select * from [User] WHERE [ID] = " + ID + "", con);
                    SqlDataReader ReaderUrl = Url.ExecuteReader();
                    while (ReaderUrl.Read())
                    {
                        User.Add(new Models.User(Convert.ToInt32(ReaderUrl.GetValue(0)), ReaderUrl.GetValue(1).ToString(), ReaderUrl.GetValue(2).ToString(), ReaderUrl.GetValue(3).ToString(), ReaderUrl.GetValue(4).ToString()));
                    }
                    ReaderUrl.Close();
                    return User;
                }
            }
            catch { return null; }
        }
        public bool Authorization(string Login, string Password)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(Connection))
                {
                    con.Open();
                    SqlCommand Url = new SqlCommand("select * from [User] Where [Login] = '" + Login + "'", con);
                    SqlDataReader ReaderUrl = Url.ExecuteReader();
                    while (ReaderUrl.Read())
                    {
                        return (ReaderUrl.GetValue(2).ToString() == Login && ReaderUrl.GetValue(4).ToString() == Password) ? true : false;
                    }
                    ReaderUrl.Close();
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
        public bool CheckRegistration(Models.User user, out object res)
        {
            res = 0;
            try
            {
                using (SqlConnection con = new SqlConnection(Connection))
                {
                    con.Open();
                    SqlCommand Url = new SqlCommand("select * from [User] Where [Login] = '" + user.GetLogin() + "'", con);
                    SqlDataReader ReaderUrl = Url.ExecuteReader();
                    while (ReaderUrl.Read())
                    {
                        if (ReaderUrl.GetValue(2) != null) { ReaderUrl.Close(); con.Close(); res = 1; return false; }
                    }
                    ReaderUrl.Close();
                    Url = new SqlCommand("select * from [User] Where [Email] = '" + user.GetEmail() + "'", con);
                    ReaderUrl = Url.ExecuteReader();
                    while (ReaderUrl.Read())
                    {
                        if (ReaderUrl.GetValue(3) != null) { ReaderUrl.Close(); con.Close(); res = 2; return false; }
                    }
                    ReaderUrl.Close();
                    con.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool Registration(Models.User user)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(Connection))
                {
                    con.Open();
                    Helper.Help Help = new Helper.Help();
                    SqlCommand Url = new SqlCommand("insert into [User] values ('" + user.GetName() + "','" + user.GetLogin() + "','" + user.GetEmail() + "','" + Help.MD5HASH(user.GetPassword()) + "' )", con); ;
                    SqlDataReader ReaderUrl = Url.ExecuteReader();
                    ReaderUrl.Close();
                }
                if (CreateUserSettings(user.GetLogin()))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch { return false; }
        }
        private bool CreateUserSettings(string Login)
        {
            int UserID = 0;
            try
            {
                using (SqlConnection con = new SqlConnection(Connection))
                {
                    con.Open();
                    SqlCommand Url = new SqlCommand("select * from [User] Where [Login] = '" + Login + "'", con);
                    SqlDataReader ReaderUrl = Url.ExecuteReader();
                    while (ReaderUrl.Read())
                    {
                        UserID = Convert.ToInt32(ReaderUrl.GetValue(0));
                    }
                    ReaderUrl.Close();
                }
            }
            catch { return false; }
            try
            {
                using (SqlConnection con = new SqlConnection(Connection))
                {
                    con.Open();

                    SqlCommand Url = new SqlCommand("insert into [UserSettings] values(" + UserID + ", null, null, null, null, null, null);", con);
                    SqlDataReader ReaderUrl = Url.ExecuteReader();
                    ReaderUrl.Close();
                }
                return true;
            }
            catch { return false; }
        }
        public bool CheckUserPassword(string Login, string Password)
        {
            string OldPassword = null;
            try
            {
                using (SqlConnection con = new SqlConnection(Connection))
                {
                    con.Open();
                    SqlCommand Url = new SqlCommand("select * from [User] Where [Login] = '" + Login + "'", con);
                    SqlDataReader ReaderUrl = Url.ExecuteReader();
                    while (ReaderUrl.Read())
                    {
                        if (ReaderUrl.GetValue(4) != null) { OldPassword = ReaderUrl.GetValue(4).ToString(); }
                    }
                    ReaderUrl.Close();
                }
            }
            catch { return false; }
            Helper.Help Help = new Helper.Help();
            if (OldPassword.Equals(Help.MD5HASH(Password))) { return true; }
            else { return false; }
        }
        public bool ChangeUserPassword(string Login, string Password)
        {
            try
            {
                Helper.Help Help = new Helper.Help();
                using (SqlConnection con = new SqlConnection(Connection))
                {
                    con.Open();
                    SqlCommand Url = new SqlCommand("Update [User] set [Password] = '" + Help.MD5HASH(Password) + "' WHERE [Login] = '" + Login + "'", con);
                    SqlDataReader ReaderUrl = Url.ExecuteReader();
                    ReaderUrl.Close();

                    return true;
                }
            }
            catch { return false; }
        }
        public bool ChangeUserEmail(string Login, string Email)
        {
            try
            {
                Helper.Help Help = new Helper.Help();
                using (SqlConnection con = new SqlConnection(Connection))
                {
                    con.Open();
                    SqlCommand Url = new SqlCommand("Update [User] set [Email] = '" + Email + "' WHERE [Login] = '" + Login + "'", con);
                    SqlDataReader ReaderUrl = Url.ExecuteReader();
                    ReaderUrl.Close();

                    return true;
                }
            }
            catch { return false; }
        }
        public List<Models.User> GetUser(string Login)
        {
            try
            {
                List<Models.User> User = new List<Models.User>();
                using (SqlConnection con = new SqlConnection(Connection))
                {
                    con.Open();
                    SqlCommand Url = new SqlCommand("select * from [User] WHERE [Login] = '" + Login + "'", con);
                    SqlDataReader ReaderUrl = Url.ExecuteReader();
                    while (ReaderUrl.Read())
                    {
                        User.Add(new Models.User(Convert.ToInt32(ReaderUrl.GetValue(0)), ReaderUrl.GetValue(1).ToString(), ReaderUrl.GetValue(2).ToString(), ReaderUrl.GetValue(3).ToString(),
                        ReaderUrl.GetValue(4).ToString()));
                    }
                    ReaderUrl.Close();
                }
                return User;
            }
            catch { return null; }
        }
        public List<Models.UserSettings> GetUserSettings(int ID)
        {
            try
            {
                List<Models.UserSettings> UserSettings = new List<Models.UserSettings>();
                using (SqlConnection con = new SqlConnection(Connection))
                {
                    con.Open();
                    SqlCommand Url = new SqlCommand("select * from [UserSettings] WHERE [UserID] = " + ID + "", con);
                    SqlDataReader ReaderUrl = Url.ExecuteReader();
                    while (ReaderUrl.Read())
                    {
                        UserSettings.Add(new Models.UserSettings(Convert.ToInt32(ReaderUrl.GetValue(0)), ReaderUrl.GetValue(1).ToString(), ReaderUrl.GetValue(2).ToString(),
                        Convert.ToSByte(ReaderUrl.GetValue(3)), ReaderUrl.GetValue(4).ToString(), Convert.ToInt32(ReaderUrl.GetValue(5))));
                    }
                    ReaderUrl.Close();
                }
                return UserSettings;
            }
            catch { return null; }
        }
        public bool SetUserSettings(List<Models.UserSettings> UserSettings)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(Connection))
                {
                    con.Open();
                    foreach (var item in UserSettings)
                    {
                        SqlCommand Url = new SqlCommand("Update [UserSettings] set [Interests] = '" + item.GetInterests() + "', [CountyCity] = '" + item.GetCountyCity() + "', " +
                        "[Age] = " + item.GetAge() + ", [ProfileImage] = '" + item.GetProfileImage() + "' WHERE [UserID] = " + item.GetUSerID() + "", con);
                        SqlDataReader ReaderUrl = Url.ExecuteReader();
                        ReaderUrl.Close();
                    }
                    return true;
                }
            }
            catch (Exception ex) { return false; }
        }
        public void InsertGlobalMessage(string Login, string Text, string Date)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(Connection))
                {
                    con.Open();
                    SqlCommand Url = new SqlCommand($"insert into [GlobalMessages] values ({GetUserID(Login)}, '{Text}', '{Date}')", con); ;
                    SqlDataReader ReaderUrl = Url.ExecuteReader();
                    ReaderUrl.Close();
                }
            }
            catch (Exception ex) { }
        }
        public List<Models.Message> LoadGlobalMessage()
        {
            try
            {
                List<Models.Message> Message = new List<Models.Message>();
                using (SqlConnection con = new SqlConnection(Connection))
                {
                    con.Open();
                    SqlCommand Url = new SqlCommand("select * from [GlobalMessages]", con);
                    SqlDataReader ReaderUrl = Url.ExecuteReader();
                    while (ReaderUrl.Read())
                    {
                        Message.Add(new Models.Message(Convert.ToInt32(ReaderUrl.GetValue(0)), Convert.ToInt32(ReaderUrl.GetValue(1)), ReaderUrl.GetValue(2).ToString(), Convert.ToDateTime(ReaderUrl.GetValue(3)), false));
                    }
                    ReaderUrl.Close();
                }
                return Message;
            }
            catch { return null; }
        }
        public string LoadUserImage(string Login)
        {
            int ID = GetUserID(Login);
            try
            {
                string Image = null;
                List<Models.Message> Message = new List<Models.Message>();
                using (SqlConnection con = new SqlConnection(Connection))
                {
                    con.Open();
                    SqlCommand Url = new SqlCommand("select * from [UserSettings] WHERE [UserID] = " + ID + "", con);
                    SqlDataReader ReaderUrl = Url.ExecuteReader();
                    while (ReaderUrl.Read())
                    {
                        Image = ReaderUrl.GetValue(4).ToString();
                    }
                    ReaderUrl.Close();
                }
                return Image;
            }
            catch { return null; }
        }
        public void IncrementMessages(string Login)
        {
            int ID = GetUserID(Login);
            int Count = 0;
            foreach (var item in GetUserSettings(ID))
            {
                Count = item.GetMessageCount();
            }
            Count++;
            try
            {
                using (SqlConnection con = new SqlConnection(Connection))
                {
                    con.Open();
                    SqlCommand Url = new SqlCommand("Update [UserSettings] set [MessageCount] = " + Count + " WHERE [UserID] = " + ID + "", con);
                    SqlDataReader ReaderUrl = Url.ExecuteReader();
                    ReaderUrl.Close();
                }
            }
            catch { }
        }
        public void LastTimeOnline(string Login)
        {
            int ID = GetUserID(Login);
            try
            {
                using (SqlConnection con = new SqlConnection(Connection))
                {
                    con.Open();
                    SqlCommand Url = new SqlCommand("Update [UserSettings] set [LastTimeOnline] = '" + DateTime.Now + "' WHERE [UserID] = " + ID + "", con);
                    SqlDataReader ReaderUrl = Url.ExecuteReader();
                    ReaderUrl.Close();
                }
            }
            catch { }
        }
        public List<Models.UserSettings> GetLastTimeOnline(string Login)
        {
            try
            {
                List<Models.UserSettings> UserSettings = new List<Models.UserSettings>();
                using (SqlConnection con = new SqlConnection(Connection))
                {
                    int ID = GetUserID(Login);
                    con.Open();
                    SqlCommand Url = new SqlCommand("select * from [UserSettings] WHERE [UserID] = "+ID+"", con);
                    SqlDataReader ReaderUrl = Url.ExecuteReader();
                    while (ReaderUrl.Read())
                    {
                        UserSettings.Add(new Models.UserSettings(Convert.ToInt32(ReaderUrl.GetValue(0)),Convert.ToDateTime(ReaderUrl.GetValue(6)))) ;
                    }
                    ReaderUrl.Close();
                }
                return UserSettings;
            }
            catch(Exception ex) { return null; }
        }
    }
}