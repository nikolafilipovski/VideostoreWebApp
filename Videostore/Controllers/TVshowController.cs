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
        private readonly IActorService _actorService;
        private readonly IDirectorService _directorService;

        public TVshowController(ITVshowService tvShowService, IActorService actorService, IDirectorService directorService)
        {
            _tvShowService = tvShowService;
            _actorService = actorService;
            _directorService = directorService;
        }

        // GET: TVshowController
        public ActionResult Index()
        {
            var tvShows = _tvShowService.GetTVshows();
            return View(tvShows);
        }

        // GET: TVshowController/Details/5
        public ActionResult Details(int id)
        {
            var tvShow = _tvShowService.GetTVshowByID(id);
            return View(tvShow);
        }

        // GET: TVshowController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TVshowController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TVshow tvShow)
        {
            //var tvShow = new TVshow();
            //tvShow.title = model.title;
            //tvShow.runTime = model.runTime;
            //tvShow.rating = model.rating;
            //tvShow.description = model.description;
            //tvShow.releaseDate = model.releaseDate;
            //tvShow.genre = model.genre;

            _tvShowService.Add(tvShow);

            return RedirectToAction(nameof(Index));
        }

        // GET: TVshowController/Edit/5
        public ActionResult Edit(int id)
        {
            var tvShow = _tvShowService.GetTVshowByID(id);
            return View(tvShow);
        }

        // POST: TVshowController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, TVshow tvShow)
        {
            _tvShowService.Edit(tvShow);
            return RedirectToAction(nameof(Index));
        }

        // GET: TVshowController/Delete/5
        public ActionResult Delete(int id)
        {
            var tvShow = _tvShowService.GetTVshowByID(id);
            return View(tvShow);
        }

        // POST: TVshowController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, TVshow tvShow)
        {
            _tvShowService.Delete(tvShow);

            return RedirectToAction(nameof(Index));
        }
    }
}
