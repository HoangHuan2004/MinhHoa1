﻿using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MinhHoa1.Models;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace MinhHoa1.Controllers
{
    public class RegisterController : Controller
    {
        private IHostingEnvironment hosting;
        public RegisterController(IHostingEnvironment _hosting)
        {
            hosting = _hosting;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult XuLy(PersonModel m, IFormFile FHinh)
        {
            if(FHinh !=null)
            {
                string filename = Guid.NewGuid().ToString() + Path.GetExtension(FHinh.FileName);
                string path = Path.Combine(hosting.WebRootPath + "/images");
                using (var filestream = new FileStream (Path.Combine(path, filename), FileMode.Create))
                {
                    FHinh.CopyTo(filestream);
                }
                m.Picture = filename;
            }
            return View(m);
        }

    }
}
