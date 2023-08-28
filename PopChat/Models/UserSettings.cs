using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PopChat.Models
{
    public class UserSettings
    {
        int UserID { get; set; }
        string Interests { get; set; }
        string CountyCity { get; set; }
        sbyte Age { get; set; }
        string ProfileImage { get; set; }
        int MessageCount { get; set; }
        DateTime LastTimeOnline { get; set; }

        public UserSettings(int UserID, string Interests, string CountyCity, sbyte Age, string ProfileImage, int MessageCount)
        {
            this.UserID = UserID;
            this.Interests = Interests;
            this.CountyCity = CountyCity;
            this.Age = Age;
            this.ProfileImage = ProfileImage;
            this.MessageCount = MessageCount;
        }
        public UserSettings(int UserID, DateTime LastTimeOnline)
        {
            this.UserID = UserID;
            this.LastTimeOnline = LastTimeOnline;
        }

        public int GetUSerID() { return UserID; }
        public string GetInterests() { return Interests; }
        public string GetCountyCity() { return CountyCity; }
        public sbyte GetAge() { return Age; }
        public string GetProfileImage() { return ProfileImage; }
        public int GetMessageCount() { return MessageCount; }
        public DateTime GetLastTimeOnline() { return LastTimeOnline; }
    }
}