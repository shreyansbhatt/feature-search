using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feature_search.business.core
{
    public interface IDocument
    {
        public Object Id { get; set; }
        public DateTime CreatedOn { get; set; }
        //public DateTime UpdatedOn { get; set; }
        //public int CreatedBy { get; set; }
        //public int UpdatedBy { get; set; }
    }
}
