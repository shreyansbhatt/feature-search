using feature_search.business.core.Entities;
using System.Collections.Generic;

namespace feature_search.business.core
{
    public interface IBrandManager
    {
        IList<FsBrand> GetAllBrands();

        FsBrand GetBrandById(short id);

        short InsertBrand(BrandInformation brand);

        FsBrand UpdateBrand(short id, BrandInformation brand);
    }
}
