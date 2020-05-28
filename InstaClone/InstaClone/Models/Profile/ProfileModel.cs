using InstaClone.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InstaClone.Models.Profile
{
    public class ProfileModel
    {  
        public string Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<ApplicationUser> Subscribers { get; set; }
        public int SubscribersCount { get; set; }
        public IEnumerable<ApplicationUser> Subscribed { get; set; }
        public string Image { get; set; }
        public string PostedImages { get; set; }
        public string PostedImage { get; set; }

    }
}
