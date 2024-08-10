using feature_search.business.core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feature_search.business.core
{
    public interface IUserRepository
    {
        FsUserInfo GetLoginInformation(string userName, string password, bool isSignUpLogin = false);
    }
}
