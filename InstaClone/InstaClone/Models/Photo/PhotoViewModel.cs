using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InstaClone.Models.Photo
{
    public class PhotoViewModel
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public IFormFile Photo { get; set; }
        public string UserName { get; set; }
    }
}
