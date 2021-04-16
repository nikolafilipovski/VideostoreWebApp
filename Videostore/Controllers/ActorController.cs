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
    public class ActorController : Controller
    {
        private readonly IActorService _actorService;

        public ActorController(IActorService actorService)
        {
            _actorService = actorService;
        }

        // GET: ActorController
        public ActionResult Index()
        {
            var actors = _actorService.GetActors();
            // logger
            return View(actors);
        }

        // GET: ActorController/Details/5
        public ActionResult Details(int id)
        {
            var actor = _actorService.GetActorByID(id);
            return View(actor);
        }

        // GET: ActorController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ActorController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Actor actor)
        {
            if (actor != null)
            {
                if (!string.IsNullOrEmpty(actor.actorName) || !string.IsNullOrWhiteSpace(actor.actorName))
                {
                    _actorService.Add(actor);
                    // _logger.LogInformation("New Actor was added!");
                }
            }
            return RedirectToAction(nameof(Index));
        }

        // GET: ActorController/Edit/5
        public ActionResult Edit(int id)
        {
            var actor = _actorService.GetActorByID(id);
            // logger
            return View(actor);
        }

        // POST: ActorController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Actor actor)
        {
            if (actor != null)
            {
                if (!string.IsNullOrEmpty(actor.actorName) || !string.IsNullOrWhiteSpace(actor.actorName))
                {
                    _actorService.Edit(actor);
                    // _logger.LogInformation("The Actor was updated!");
                }
            }
            return RedirectToAction(nameof(Index));
        }

        // GET: ActorController/Delete/5
        public ActionResult Delete(int id)
        {
            var actors = _actorService.GetActors();
            return View(actors);
        }

        // POST: ActorController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Actor actor)
        {
            _actorService.GetActorByID(id);
            // logger
            return RedirectToAction(("Index"));
        }

        [HttpPost]
        public JsonResult CreateActorAJAX(Actor actor)
        {
            if (actor != null)
            {
                if (!string.IsNullOrEmpty(actor.actorName) || !string.IsNullOrWhiteSpace(actor.actorName))
                {
                    _actorService.Add(actor);
                    return Json(new { data = actor });
                }
                else
                {
                    return Json(new { data = "" });
                }
            }
            else
            {
                return Json(new { data = "" });
            }
        }

    }
}
