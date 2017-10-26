using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RocketFinTechWebApp.Models
{
    public class UserData
    {
        private string username;
        private string phonenumber;
        private string email;
        private string income;
        private string score;

        public string Username
        {
            set { username = value; }
            get { return username; }
        }

        public string Phonenumber
        {
            set { phonenumber = value; }
            get { return phonenumber; }
        }

        public string Email
        {
            set { email = value; }
            get { return email; }

        }

        public string Income
        {
            set { income = value; }
            get { return income; }
        }

        public string Score
        {
            set { score = value; }
            get { return score; }
        }

        public UserData()
        {
            Username = "";
            Phonenumber = "";
            Email = "";
            Income = "";
            Score = "";
        }
        public UserData(string Dun , string Dp, string De, string Di, string Ds)
        {
            Username = Dun;
            Phonenumber = Dp;
            Email = De;
            Income = Di;
            Score = Ds;
        }

    }
}