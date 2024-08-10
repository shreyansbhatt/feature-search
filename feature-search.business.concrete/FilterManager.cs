using feature_search.business.core;
using feature_search.business.core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace feature_search.business.concrete
{
    public class FilterManager : IFilterManager
    {
        private readonly IFilterRepository _filterRepository;
        public FilterManager(IFilterRepository filterRepository)
        {
            _filterRepository = filterRepository;
        }
        public IList<FeatureMasterInformation> GetAllFiltersJSON()
        {
            List<FeatureMasterInformation> lstFeatureMasters = new List<FeatureMasterInformation>();
            try
            {

                IEnumerable<FsFeatureMaster> features = _filterRepository.GetAllFeatureFilter(); //context.FsFeatureMasters.Where(P=>P.IsDeleted == false);
                foreach(var feature in features)
                {
                    FeatureMasterInformation featureMasterInformation = new FeatureMasterInformation();
                    featureMasterInformation.FeatureId = feature.Id;
                    featureMasterInformation.FeatureName = feature.Name;
                    featureMasterInformation.ParentFeatureId = feature.PId;
                    featureMasterInformation.FeatureAttributes = new List<string>();

                    //MongoRepository<VariantFeatureMapping> mongoRepository = new MongoRepository<VariantFeatureMapping>(_featureSearchMongoSettings.Value);

                    //var ft = mongoRepository.FilterBy(filter => filter.Features.Any(P=>P.FeatureId == feature.Id), projection => projection.Features.Select(P=>P.Attributes));

                    //featureMasterInformation.FeatureAttributes = ft.First().First().ToList<string>();

                    

                    lstFeatureMasters.Add(featureMasterInformation);
                }
                IEnumerable<Feature> featuresDeep = _filterRepository.GetAllAttributesOfAllFeatures(features.Select(P => P.Id).ToList<int>());
                lstFeatureMasters.ForEach(fm =>
                {
                    fm.FeatureAttributes = featuresDeep.Where(F => F.FeatureId == fm.FeatureId).Select(P=>P.Attributes).FirstOrDefault();
                });
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return lstFeatureMasters;
        }
    }
}
