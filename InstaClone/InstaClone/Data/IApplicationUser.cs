using InstaClone.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InstaClone.Data
{
    public interface IApplicationUser
    {
        ApplicationUser GetById(string id);
        IEnumerable<ApplicationUser> GetAllUsers();
        IEnumerable<ApplicationUser> GetFilteredUsers(string name);
    }
}
