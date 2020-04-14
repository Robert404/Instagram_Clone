using InstaClone.Data;
using InstaClone.Models.Profile;
using InstaClone.Models.User;
using Microsoft.AspNetCore.Mvc;
using System;

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
                Subscribed = user.Subscribed,
                Subscribers = user.Subscribers,
                Image = user.Image
            };

            return View(model) ;
        }
    }
}
