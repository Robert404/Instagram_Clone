using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InstaClone.Models
{
    public class AlbumModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual IEnumerable<PhotoModel> Photos { get; set; }
    }
}
