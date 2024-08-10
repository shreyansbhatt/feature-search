using feature_search.business.core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feature_search.business.core
{
    public interface IBrandRepository
    {
        IList<FsBrand> GetAllBrands();

        FsBrand GetBrandById(short id);

        short InsertBrand(BrandInformation brand);

        FsBrand UpdateBrand(short id, BrandInformation brand);
    }
}
