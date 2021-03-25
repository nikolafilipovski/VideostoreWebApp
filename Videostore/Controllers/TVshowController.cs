using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Videostore.Entities;
using Videostore.Models;
using Videostore.Service.Interfaces;

namespace Videostore.Controllers
{
    public class TVshowController : Controller
    {
        private readonly ITVshowService _tvShowService;

        public TVshowController(ITVshowService tvShowService)
        {
            _tvShowService = tvShowService;
        }

        // GET: TVshowController
        public ActionResult Index()
        {
            return View();
        }

        // GET: TVshowController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TVshowController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TVshowController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TVshowViewModel model)
        {
            var tvShow = new TVshow();
            tvShow.title = model.title;
            tvShow.runTime = model.runTime;
            tvShow.rating = model.rating;
            tvShow.description = model.description;
            tvShow.releaseDate = model.releaseDate;
            tvShow.genre = model.genre;

            _tvShowService.Add(tvShow);

            return RedirectToAction(nameof(Index));
        }

        // GET: TVshowController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TVshowController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TVshowController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TVshowController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
