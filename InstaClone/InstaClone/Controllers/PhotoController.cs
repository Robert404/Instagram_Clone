using InstaClone.Models;
using InstaClone.Models.Photo;
using InstaClone.Models.Profile;
using InstaClone.Models.User;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace InstaClone.Controllers
{
    public class PhotoController:Controller
    {
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly ApplicationDbContext _context;

        public PhotoController(IHostingEnvironment hostingEnvironment, ApplicationDbContext context) 
        {
            _hostingEnvironment = hostingEnvironment;
            _context = context;
        }

        public IActionResult Upload() 
        {
            return View();
        }

        [HttpPost]
        public IActionResult UploadPhoto(PhotoViewModel model) 
        {
            string uniqueFileName = null;
            if (model.Photo != null)
            {
                string uploadsFolder = Path.Combine(_hostingEnvironment.WebRootPath, "images");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.Photo.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                model.Photo.CopyTo(new FileStream(filePath, FileMode.Create));
            }

            var photo = new PhotoModel
            {
                Photo = uniqueFileName
            };

            _context.Photos.Add(photo);
            _context.SaveChanges();

            return RedirectToAction("Detail","Profile");
        }


    }
}
