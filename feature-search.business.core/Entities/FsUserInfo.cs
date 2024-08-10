using System;
using System.Collections.Generic;

#nullable disable

namespace feature_search.business.core.Entities
{
    public partial class FsUserInfo
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public byte UserType { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
