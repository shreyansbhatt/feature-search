using feature_search.business.core.Entities;
using System.Collections.Generic;

namespace feature_search.business.core
{
    public interface IFilterManager
    {
        IList<FeatureMasterInformation> GetAllFiltersJSON();
    }
}
