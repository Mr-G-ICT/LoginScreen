using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginScreen___Game
{
    public class ProfileRoutines
    {

        private struct UserProfile
        {
            public int UserID;
            public string Firstname;
           public string Username;
            public string email;
            public string Password;
        };

        private UserProfile SingleUser;


        public int GetUserID
        {
            get { return SingleUser.UserID; }
            set { SingleUser.UserID = value; }
        }

        public string GetFirstname
        {
            get { return SingleUser.Firstname; }
            set { SingleUser.Firstname = value; }
        }

        public string GetUsername
        {
            get { return SingleUser.Username; }
            set { SingleUser.Username = value; }
        }

        public string GetEmail
        {
            get { return SingleUser.Username; }
            set { SingleUser.email = value; }
        }

        public string GetPW
        {
            get { return SingleUser.Password; }
            set { SingleUser.email = value; }
        }


    }
}
