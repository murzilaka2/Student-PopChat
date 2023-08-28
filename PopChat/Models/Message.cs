using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PopChat.Models
{
    public class Message
    {
        int ID { get; set; }
        int UserID { get; set; }
        string MessageText { get; set; }
        DateTime Date { get; set; }
        bool IsRead { get; set; }

        public Message(int ID, int UserID, string MessageText, DateTime Date, bool IsRead)
        {
            this.ID = ID;
            this.UserID = UserID;
            this.MessageText = MessageText;
            this.Date = Date;
            this.IsRead = IsRead;
        }
        public int GetID() { return ID; }
        public int GetUSerID() { return UserID; }
        public string GetMessageText() { return MessageText; }
        public DateTime GetDate() { return Date; }
        public bool GetIsRead() { return IsRead; }
    }
}