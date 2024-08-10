using System;
using System.Collections.Generic;

#nullable disable

namespace feature_search.business.core.Entities
{
    public partial class FsImageMaster
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Caption { get; set; }
        public byte TypeId { get; set; }
        public string Url { get; set; }
    }
}
