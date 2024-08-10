using feature_search.business.core;
using feature_search.business.core.Entities;
using System;
using System.Linq;

namespace feature_search.business.concrete
{
    public class UserManager : IUserManager
    {
        private readonly IUserRepository _userRepository;
        public UserManager(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public FsUserInfo GetLoginInformation(string userName, string password, bool isSignUpLogin = false)
        {
            //using (FeaturesSearchContext context = new FeaturesSearchContext(_sqlConfiguration))
            //{
            //    FsUserInfo returnUser = new FsUserInfo();
            //    try
            //    {
            //        returnUser = context.FsUserInfos
            //            .Where(P => P.UserName.Equals(userName) && P.Password.Equals(password)).FirstOrDefault();

            //        return returnUser;
            //    }
            //    catch (Exception)
            //    {
            //        return null;
            //    }
            //}
            return _userRepository.GetLoginInformation(userName, password, isSignUpLogin);

        }

    }
}
