using InstaClone.Models;
using InstaClone.Models.Photo;
using InstaClone.Models.Profile;
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

        public PhotoController(IHostingEnvironment hostingEnvironment) 
        {
            _hostingEnvironment = hostingEnvironment;
        }
        
        [HttpGet]
        public IActionResult Upload() 
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> UploadPhoto(PhotoViewModel model) 
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

            return View(model);
        }
    }
}
