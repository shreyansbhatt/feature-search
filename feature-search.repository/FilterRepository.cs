using Dapper;
using feature_search.business.core;
using feature_search.business.core.Entities;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feature_search.repository
{
    
    public class FilterRepository : MongoRepository<VariantFeatureMapping>, IFilterRepository
    {
        private readonly SQLDatabaseConfiguration _sqlConfiguration;
        private readonly FeatureSearchDatabaseSettings _featureSearchMongoSettings;

        public FilterRepository(IOptions<SQLDatabaseConfiguration> sqlConfiguration, IOptions<FeatureSearchDatabaseSettings> featureSearchMongoSettings): base(featureSearchMongoSettings.Value, "VARIANT_FEATURE_MAPPING")
        {
            _sqlConfiguration = sqlConfiguration.Value;
            _featureSearchMongoSettings = featureSearchMongoSettings.Value;
        }
        public IEnumerable<FsFeatureMaster> GetAllFeatureFilter()
        {
            string sql = "SELECT ID AS Id, NAME AS Name, P_ID AS PId, SHORT_NAME AS ShortName, DateCreated, DateUpdated FROM [FeaturesSearch].[dbo].[FS_FEATURE_MASTER] WHERE IsDeleted = 0";
            using (var connection = new SqlConnection(_sqlConfiguration.FeatureSearchDB))
            {
                var result = connection.Query<FsFeatureMaster>(sql).ToList();
                return result;
            }
        }

        public IList<FeatureMasterInformation> GetAllFeatureMasterJson(int featureID)
        {
            throw new MissingMethodException();
        }

        public IEnumerable<Feature> GetAllAttributesOfAllFeatures(List<int> featureIds)
        {
           return FilterBy(filter => filter.Features.Any(P => featureIds.Contains(P.FeatureId)), projection => projection.Features).First();
        }
    }
}
