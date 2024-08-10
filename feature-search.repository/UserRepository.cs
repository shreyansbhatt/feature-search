using feature_search.business.core;
using feature_search.business.core.Entities;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feature_search.repository
{
    public class UserRepository : IUserRepository
    {
        private readonly SQLDatabaseConfiguration _sqlConfiguration;
        public UserRepository(IOptions<SQLDatabaseConfiguration> sqlConfiguration)
        {
            _sqlConfiguration = sqlConfiguration.Value;
        }

        public FsUserInfo GetLoginInformation(string userName, string password, bool isSignUpLogin = false)
        {
            throw new NotImplementedException();
        }
    }
}
