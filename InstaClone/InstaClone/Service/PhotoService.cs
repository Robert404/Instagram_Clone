using InstaClone.Data;
using InstaClone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InstaClone.Service
{
    public class PhotoService : IPhoto
    {
        private readonly ApplicationDbContext _context;
        public PhotoService(ApplicationDbContext context) 
        {
            _context = context;
        }
        public async Task Delete(int id)
        {
            var photo = GetById(id);
            _context.Remove(photo);
            await _context.SaveChangesAsync();
        }

        public PhotoModel GetById(int id)
        {
            return _context.Photos.Where(photo => photo.Id == id).FirstOrDefault();
        }
    }
}
