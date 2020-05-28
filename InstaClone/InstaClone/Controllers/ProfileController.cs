using InstaClone.Data;
using InstaClone.Models;
using InstaClone.Models.Profile;
using InstaClone.Models.User;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace InstaClone.Controllers
{
    public class ProfileController:Controller
    {
        private readonly IApplicationUser _userService;
        private readonly ApplicationDbContext _context;
        public ProfileController(IApplicationUser userService, ApplicationDbContext context) 
        {
            _userService = userService;
            _context = context;
        }
        public IActionResult Detail(string id)
        {
            var user = _userService.GetById(id);
            var model = new ProfileModel
            {
                Name = user.UserName,
                Image = user.Image,
                Id = user.Id
            };

            return View(model) ;
        }


    }
}
