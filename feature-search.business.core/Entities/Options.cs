using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace feature_search.business.core.Entities
{

    public class SQLDatabaseConfiguration
    {
        public string FeatureSearchDB { get; set; }
    }
    public class JwtConfiguration
    {
        public string Issuer { get; set; }
        public string Audience { get; set; }
        public string SecretKey { get; set; }
    }

    public class FeatureSearchDatabaseSettings : IFeatureSearchDatabaseSettings
    {
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
    public interface IFeatureSearchDatabaseSettings
    {
        string ConnectionString { get; set; }

        string DatabaseName { get; set; }
    }

}
