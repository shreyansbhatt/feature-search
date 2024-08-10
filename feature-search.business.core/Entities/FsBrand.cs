using System;
using System.Collections.Generic;

#nullable disable

namespace feature_search.business.core.Entities
{
    public partial class FsBrand
    {
        public FsBrand()
        {
            FsProducts = new HashSet<FsProduct>();
        }

        public short Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Logo { get; set; }
        public bool IsDiscountinued { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<FsProduct> FsProducts { get; set; }
    }
}
