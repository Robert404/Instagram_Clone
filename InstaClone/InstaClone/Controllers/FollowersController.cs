using InstaClone.Data;
using InstaClone.Models.Profile;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace InstaClone.Controllers
{
    public class FollowersController:Controller
    {
        private readonly IApplicationUser _userService;

        public FollowersController(IApplicationUser userService) 
        {
            _userService = userService;
        }

        public IActionResult Follow(string name) 
        {
            return View();
        }
    }
}
