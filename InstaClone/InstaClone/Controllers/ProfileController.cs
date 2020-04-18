using InstaClone.Data;
using InstaClone.Models;
using InstaClone.Models.Photo;
using InstaClone.Models.Profile;
using InstaClone.Models.User;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;

namespace InstaClone.Controllers
{
    public class ProfileController:Controller
    {
        private readonly IApplicationUser _userService;
        public ProfileController(IApplicationUser userService) 
        {
            _userService = userService;
        }
        public IActionResult Detail(string id)
        {
            var user = _userService.GetById(id);
            var model = new ProfileModel
            {
                Name = user.UserName,
                Image = user.Image
            };

            return View(model) ;
        }

      
    }
}
