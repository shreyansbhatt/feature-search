using System;
using System.Collections.Generic;

namespace feature_search.business.core.Entities
{
    public class VariantFeatureMapping : IDocument
    {
        //[BsonId]
        //[BsonRepresentation(BsonType.ObjectId)]
        public Object Id { get; set; }

        //[BsonElement("variant_id")]
        public int VariantID { get; set; }
        //[BsonElement("variant_full_name")]
        public string VariantName { get; set; }
        //[BsonElement("features")]
        public List<Feature> Features { get; set; }

        public DateTime CreatedOn { get; set; }
    }

    public class Feature
    {
        //[BsonElement("feature_id")]
        public int FeatureId { get; set; }
        //[BsonElement("feature_pid")]
        public int FeatureParentId { get; set; }
        //[BsonElement("attributes")]
        public List<string> Attributes { get; set; }
    }


}
