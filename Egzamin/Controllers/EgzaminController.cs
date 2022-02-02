using Egzamin.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EgzaminNrIndexu13548.Controllers
{
    public class EgzaminController : Controller
    {
        private static IList<EgzaminModel> egzamin = new List<EgzaminModel>()
        {
            new EgzaminModel( ){Id=1, Title="Tytuł1",Price=5 },
            new EgzaminModel( ){Id=2, Title="Tytuł2",Price=5 },
            new EgzaminModel( ){Id=2, Title="Tytuł2",Price=5 }
        };
        // GET: EgzaminController
        public ActionResult Index()
        {
            return View(egzamin);
        }

        // GET: EgzaminController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EgzaminController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EgzaminController/Create
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

        // GET: EgzaminController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EgzaminController/Edit/5
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

        // GET: EgzaminController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EgzaminController/Delete/5
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
