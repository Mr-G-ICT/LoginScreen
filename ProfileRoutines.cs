using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginScreen___Game
{
    class ProfileRoutines
    {
        public struct UserProfile
        {
            public string Username;
            public string email;
            
        };

        public static void SetupProfile(string username, string email )
        {
            UserProfile SingleUser;

            SingleUser.Username = username;
            SingleUser.email = email;

            // build something in here to get the rest of the data from the database and store it in the struct

        }

    }
}
