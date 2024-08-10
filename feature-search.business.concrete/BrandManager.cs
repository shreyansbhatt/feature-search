using feature_search.business.core;
using feature_search.business.core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace feature_search.business.concrete
{
    public class BrandManager : IBrandManager
    {
        //private readonly IOptions<Options.SQLDatabaseConfiguration> _sqlConfiguration;
        private readonly IBrandRepository _brandRepository;
        public BrandManager(IBrandRepository brandRepository)
        {
            _brandRepository = brandRepository;
        }
        public IList<FsBrand> GetAllBrands()
        {
            try
            {
                return _brandRepository.GetAllBrands().Where(P => P.IsDeleted == false).ToList();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public FsBrand GetBrandById(short id)
        {
            try
            {
                return _brandRepository.GetBrandById(id);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public short InsertBrand(BrandInformation brand)
        {
            FsBrand fsBrand = new FsBrand
            {
                Name = brand.Name,
                Description = brand.Description,
                Logo = brand.Logo
            };

            //using FeaturesSearchContext context = new(_sqlConfiguration);
            //try
            //{
            //    context.Add(fsBrand);
            //    context.SaveChanges();
            //    return fsBrand.Id;
            //}
            //catch (Exception)
            //{
            //    return 0;
            //}
            return _brandRepository.InsertBrand(brand);
        }

        public FsBrand UpdateBrand(short id, BrandInformation brand)
        {
            FsBrand fsBrand = new FsBrand
            {
                Id = id,
                Name = brand.Name,
                Description = brand.Description,
                Logo = brand.Logo
            };

            //using FeaturesSearchContext context = new(_sqlConfiguration);
            //try
            //{
            //    context.Update(fsBrand);
            //    context.SaveChanges();
            //    return fsBrand;
            //}
            //catch (Exception)
            //{
            //    return null;
            //}

            return _brandRepository.UpdateBrand(id, brand);
        }
    }
}




