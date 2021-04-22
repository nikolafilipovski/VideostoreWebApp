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
        private readonly IStudioService _studioService;

        public MovieController(IMovieService movieService, IStudioService studioService)
        {
            _movieService = movieService;
            _studioService = studioService;
        }

        // GET: MovieController
        public ActionResult Index()
        {
            var movies = _movieService.GetMovies();
            return View(movies);
        }

        // GET: MovieController/Details/5
        public ActionResult Details(int id)
        {
            var movie = _movieService.GetMovieByID(id);
            return View(movie);
        }

        // GET: MovieController/Create
        [HttpGet]
        public ActionResult Create()
        {
            var studios = _studioService.GetStudios();
            var dropdown = _movieService.StudiosDropdown(studios);
            ViewBag.studiosList = dropdown;

            return View();
        }

        // POST: MovieController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Movie movie)
        {
            //var movie = new Movie();
            //movie.title = model.title;
            //movie.runTime = model.runTime;
            //movie.genre = model.genre;
            //movie.rating = model.rating;
            //movie.description = model.description;

            _movieService.Add(movie);

            return RedirectToAction(nameof(Index));
        }

        // GET: MovieController/Edit/5
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var movie = _movieService.GetMovieByID(id);
            var studios = _studioService.GetStudios();
            var dropdown = _movieService.StudiosDropdown(studios);
            ViewBag.studiosList = dropdown;

            return View(movie);
        }

        // POST: MovieController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Movie movie)
        {
            _movieService.Edit(movie);
            return RedirectToAction(nameof(Index));
        }

        // GET: MovieController/Delete/5
        public ActionResult Delete(int id)
        {
            var movie = _movieService.GetMovieByID(id);
            return View(movie);
        }

        // POST: MovieController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Movie movie)
        {
            _movieService.Delete(movie);

            return RedirectToAction(nameof(Index));
        }
    }
}
