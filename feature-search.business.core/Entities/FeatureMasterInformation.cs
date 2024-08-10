using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace feature_search.business.core.Entities
{
    public class FeatureMasterInformation
    {
        public List<string> FeatureAttributes { get; set; }
        public int FeatureId { get; set; }
        public int ParentFeatureId { get; set; }
        public string FeatureName { get; set; }
       
    }
}
