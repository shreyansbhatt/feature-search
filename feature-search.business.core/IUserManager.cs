using feature_search.business.core.Entities;

namespace feature_search.business.core
{
    public interface IUserManager
    {
        FsUserInfo GetLoginInformation(string userName, string password, bool isSignUpLogin = false);
    }
}
