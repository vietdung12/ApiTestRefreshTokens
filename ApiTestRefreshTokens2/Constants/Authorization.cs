using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTestRefreshTokens2.Constants
{
    public class Authorization
    {
        public enum Roles
        {
            Administrator,
            Moderator,
            User
        }
        public const string default_username = "user";
        public const string default_email = "user123@gmail.com";
        public const string default_password = "User@123";
        public const Roles default_role = Roles.User;

    }
}
