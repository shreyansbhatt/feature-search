using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace feature_search.business.core.Entities
{
    public class LoginInformation
    {
        private string _username;
        private string _password;

        public string Username { get => _username; set => _username = value; }
        public string Password { get => _password; set => _password = value; }
    }
}
