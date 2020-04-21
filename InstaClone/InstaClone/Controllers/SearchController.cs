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

        public IActionResult Index(string query) 
        {
            var users = _userService.GetFilteredUsers(query);
            var emptyQuery = query == null;

            var model = new SearchIndexModel
            {
                QueryString = query,
                QueryResult = users,
                IsQueryNull = emptyQuery
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult Search(string query)
        {
            return RedirectToAction("Index", new { query });
        }
    }
}
