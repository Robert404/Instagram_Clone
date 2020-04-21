using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using InstaClone.Models;
using InstaClone.Models.User;
using InstaClone.Models.Profile;
using InstaClone.Data;

namespace InstaClone.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IApplicationUser _userService;

        public HomeController(ILogger<HomeController> logger, IApplicationUser userService)
        {
            _logger = logger;
            _userService = userService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SearchProfile(SearchIndexModel model) 
        {
            var users = _userService.GetFilteredUsers(model.QueryString);
            var emptyQuery = model.QueryString == null;

            var user = new SearchIndexModel
            {
                QueryResult = users,
                IsQueryNull = emptyQuery
            };

            return View(user);
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
