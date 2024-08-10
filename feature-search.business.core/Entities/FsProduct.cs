using System;
using System.Collections.Generic;

#nullable disable

namespace feature_search.business.core.Entities
{
    public partial class FsProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? ImageId { get; set; }
        public short BrandId { get; set; }
        public bool? IsNew { get; set; }
        public DateTime? LaunchDate { get; set; }
        public string Timezone { get; set; }
        public bool IsDiscontinued { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public bool IsDeleted { get; set; }

        public virtual FsBrand Brand { get; set; }
    }
}
