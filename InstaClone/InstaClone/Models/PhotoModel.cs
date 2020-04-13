using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InstaClone.Models
{
    public class PhotoModel
    {
        public int Id { get; set; }
        public string Description { get; set;}
        public string Photo { get; set; }

    }
}
