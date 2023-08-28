using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PopChat.Models
{
    public class User
    {
        int ID { get; set; }
        string Name { get; set; }
        string Login { get; set; }
        string Email { get; set; }
        string Password { get; set; }

        public User(int ID, string Name, string Login, string Email, string Password)
        {
            this.ID = ID;
            this.Name = Name;
            this.Login = Login;
            this.Email = Email;
            this.Password = Password;
        }
        public int GetID() { return ID; }
        public string GetName() { return Name; }
        public string GetLogin() { return Login; }
        public string GetEmail() { return Email; }
        public string GetPassword() { return Password; }
    }
}