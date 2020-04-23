using InstaClone.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InstaClone.Models.Profile
{
    public class SearchIndexModel
    {
        public string QueryString { get; set; }
        public IEnumerable<ApplicationUser> QueryResult { get; set; }
        public bool IsNoResult { get; set; }
    }
}
