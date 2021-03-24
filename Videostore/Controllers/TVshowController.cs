using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Videostore.Controllers
{
    public class TVshowController : Controller
    {
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
        public ActionResult Create(IFormCollection collection)
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
