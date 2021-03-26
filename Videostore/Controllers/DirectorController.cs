using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Videostore.Entities;
using Videostore.Service.Interfaces;

namespace Videostore.Controllers
{
    public class DirectorController : Controller
    {
        private readonly IDirectorService _directorService;

        public DirectorController(IDirectorService directorService)
        {
            _directorService = directorService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult CreateDirectorAJAX(Director director)
        {
            _directorService.Add(director);
            return Json(director);
        }
    }
}
