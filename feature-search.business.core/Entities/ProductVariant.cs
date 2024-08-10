using System;
using System.Collections.Generic;

#nullable disable

namespace feature_search.business.core.Entities
{
    public partial class ProductVariant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? LaunchDate { get; set; }
        public int ProductId { get; set; }
        public bool? IsDiscountinued { get; set; }
        public int? BasePrice { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public bool IsDeleted { get; set; }
        public string ImageIdList { get; set; }
    }
}
