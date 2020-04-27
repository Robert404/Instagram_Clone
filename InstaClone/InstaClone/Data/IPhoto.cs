using InstaClone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InstaClone.Data
{
    public interface IPhoto
    {
        Task Delete(int id);
        PhotoModel GetById(int id);
    }
}
