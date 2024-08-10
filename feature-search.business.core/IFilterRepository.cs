using feature_search.business.core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feature_search.business.core
{
    public interface IFilterRepository
    {
        IEnumerable<FsFeatureMaster> GetAllFeatureFilter();
        //IList<FeatureMasterInformation> GetAllFeatureMasterJson();
        public IEnumerable<Feature> GetAllAttributesOfAllFeatures(List<int> featureIds);
    }
}
