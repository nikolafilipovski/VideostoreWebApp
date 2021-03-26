using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Videostore.Entities;
using Videostore.Models;
using Videostore.Service.Interfaces;

namespace Videostore.Controllers
{
    public class MovieController : Controller
    {
        private readonly IMovieService _movieService;
        private readonly IActorService _actorService;
        private readonly IDirectorService _directorService;

        public MovieController(IMovieService movieService, IActorService actorService, IDirectorService directorService)
        {
            _movieService = movieService;
            _actorService = actorService;
            _directorService = directorService;
        }

        // GET: MovieController
        public ActionResult Index()
        {
            return View();
        }

        // GET: MovieController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MovieController/Create
        [HttpGet]
        public ActionResult Create()
        {
            var actors = _actorService.GetActors();
            var directors = _directorService.GetDirectors();
            var dropdowns = _movieService.fillDropdowns(actors, directors);

            ViewBag.actorList = dropdowns.Item1;
            ViewBag.directorList = dropdowns.Item2;

            return View();
        }

        // POST: MovieController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MovieViewModel model)
        {
            var movie = new Movie();
            movie.title = model.title;
            movie.runTime = model.runTime;
            movie.genre = model.runTime;
            movie.rating = model.rating;
            movie.description = model.description;
            movie.releaseDate = model.releaseDate;

            _movieService.Add(movie);

            return RedirectToAction(nameof(Index));
        }

        // GET: MovieController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MovieController/Edit/5
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

        // GET: MovieController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MovieController/Delete/5
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
