using InstaClone.Data;
using InstaClone.Models.Profile;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InstaClone.Controllers
{
    public class SearchController:Controller
    {
        private readonly IApplicationUser _userService;
        public SearchController(IApplicationUser userService) 
        {
            _userService = userService;
        }

        public IActionResult Index(SearchIndexModel model) 
        {
            var users = _userService.GetFilteredUsers(model.QueryString);
            var noResult = (!string.IsNullOrEmpty(model.QueryString) && (!users.Any()));
        
            var model1 = new SearchIndexModel
            {
                QueryString = model.QueryString,
                QueryResult = users,
                IsNoResult = noResult
            };

            return View(model1);
        }

        [HttpPost]
        public IActionResult Search(SearchIndexModel model)
        {
            return RedirectToAction("Index", new { model.QueryString });
        }

        public IActionResult UserProfile(string name) 
        {
            var user = _userService.GetAllUsers().FirstOrDefault(u => u.UserName == name);

            var model = new ProfileModel
            {
                Name = user.UserName,
                Image = user.Image
            };

            return View(model);
        }

    }
}
