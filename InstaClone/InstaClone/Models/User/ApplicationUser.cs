using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InstaClone.Models.User
{
    public class ApplicationUser:IdentityUser
    {
        public string Image { get; set; }
        public string Subscribers { get; set; }
        public string Subscribed { get; set; }
    }
} 
