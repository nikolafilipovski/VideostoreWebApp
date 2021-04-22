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
    public class StudioController : Controller
    {
        private readonly IStudioService _studioService;

        public StudioController(IStudioService studioService)
        {
            _studioService = studioService;
        }

        // GET: StudioController
        public ActionResult Index()
        {
            var studios = _studioService.GetStudios();
            return View(studios);
        }

        // GET: StudioController/Details/5
        public ActionResult Details(int id)
        {
            var studio = _studioService.GetStudioByID(id);
            return View(studio);
        }

        // GET: StudioController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StudioController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Studio studio)
        {
            _studioService.Add(studio);
            return RedirectToAction(nameof(Index));
        }

        // GET: StudioController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: StudioController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Studio studio)
        {
            _studioService.Edit(studio);
            return RedirectToAction(nameof(Index));
        }

        // GET: StudioController/Delete/5
        public ActionResult Delete(int id)
        {
            var studio = _studioService.GetStudioByID(id);
            return View(studio);
        }

        // POST: StudioController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Studio studio)
        {
            _studioService.Delete(studio);
            return RedirectToAction(nameof(Index));
        }
    }
}
