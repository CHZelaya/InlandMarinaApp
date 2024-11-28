using InlandMarinaData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NuGet.Repositories;

namespace InlandMarinaMVC.Controllers
{
    public class MarinaController : Controller
    {
        // GET: MarinaController
        public ActionResult Index()
        {
            List<Slip> slips = InlandMarinaSlipsManager.GetSlips();
            return View(slips);
        }

        // GET: MarinaController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MarinaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MarinaController/Create
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

        // GET: MarinaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MarinaController/Edit/5
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

        // GET: MarinaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MarinaController/Delete/5
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
