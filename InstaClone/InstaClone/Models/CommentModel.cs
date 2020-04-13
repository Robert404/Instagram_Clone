using InstaClone.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InstaClone.Models
{
    public class CommentModel
    {
        public int Id { get; set; }
        public string Context { get; set; }
        public DateTime Created { get; set; }

        public virtual ApplicationUser Commentator { get; set; }
    }
}
