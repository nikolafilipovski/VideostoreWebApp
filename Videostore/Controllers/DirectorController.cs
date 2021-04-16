using Microsoft.AspNetCore.Http;
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

        // GET: DirectorController
        public ActionResult Index()
        {
            var directors = _directorService.GetDirectors();
            return View(directors);
        }

        // GET: DirectorController/Details/5
        public ActionResult Details(int id)
        {
            var director = _directorService.GetDirectorByID(id);
            return View(director);
        }

        // GET: DirectorController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DirectorController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Director director)
        {
            if (director != null)
            {
                if (!string.IsNullOrEmpty(director.directorName) || !string.IsNullOrWhiteSpace(director.directorName))
                {
                    _directorService.Add(director);
                    // logger
                }
            }
            return RedirectToAction(nameof(Index));
        }

        // GET: DirectorController/Edit/5
        public ActionResult Edit(int id)
        {
            var director = _directorService.GetDirectorByID(id);
            return View(director);
        }

        // POST: DirectorController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Director director)
        {
            if (director != null)
            {
                if (!string.IsNullOrEmpty(director.directorName) || !string.IsNullOrWhiteSpace(director.directorName))
                {
                    _directorService.Add(director);
                    // logger
                }
            }
            return RedirectToAction(nameof(Index));
        }

        // GET: DirectorController/Delete/5
        public ActionResult Delete(int id)
        {
            var director = _directorService.GetDirectorByID(id);
            return View(director);
        }

        // POST: DirectorController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Director director)
        {
            _directorService.GetDirectorByID(id);
            // logger 
            return RedirectToAction(("Index"));
        }
    }
}
