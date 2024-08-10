using feature_search.business.core.Entities;
using MongoDB.Bson.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feature_search.repository
{
    public static class VariantFeatureMapperMap
    {
        public static void Map()
        {
            BsonClassMap.RegisterClassMap<VariantFeatureMapping>(map =>
            {
                map.AutoMap();
                map.SetIgnoreExtraElements(true);
                map.MapIdMember(x => x.Id);
                map.MapMember(x => x.VariantName).SetElementName("variant_full_name").SetIsRequired(true);
                map.MapMember(x => x.VariantID).SetElementName("variant_id").SetIsRequired(false);
                map.MapMember(x => x.Features).SetElementName("features");
            });

            BsonClassMap.RegisterClassMap<Feature>(map =>
            {
                map.AutoMap();
                map.MapMember(x => x.FeatureId).SetElementName("feature_id");
                map.MapMember(x => x.FeatureParentId).SetElementName("feature_pid");
                map.MapMember(x => x.Attributes).SetElementName("attributes");
            });

        }
    }
}
