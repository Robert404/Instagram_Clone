using InstaClone.Data;
using InstaClone.Models;
using InstaClone.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InstaClone.Service
{
    public class ApplicationUserService : IApplicationUser
    {
        ApplicationDbContext _context;
        public ApplicationUserService(ApplicationDbContext context) 
        {
            _context = context;
        }
        public IEnumerable<ApplicationUser> GetAllUsers()
        {
            return _context.ApplicationUsers;
        }

        public ApplicationUser GetById(string id)
        {
            return GetAllUsers().FirstOrDefault(u => u.Id == id);
        }

        public IEnumerable<ApplicationUser> GetFilteredUsers(string name)
        {
            return GetAllUsers().Where(u => u.UserName == name);
        }
    }
}
