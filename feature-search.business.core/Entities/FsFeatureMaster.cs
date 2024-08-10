using System;
using System.Collections.Generic;

#nullable disable

namespace feature_search.business.core.Entities
{
    public partial class FsFeatureMaster
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public string ShortName { get; set; }
        public bool IsDeleted { get; set; }
    }
}
