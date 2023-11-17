using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace comp_company.Controllers
{
    public class GPUController : Controller
    {
        // GET: GPUController
        public ActionResult Index()
        {
            return View();
        }

        // GET: GPUController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: GPUController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GPUController/Create
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

        // GET: GPUController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: GPUController/Edit/5
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

        // GET: GPUController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: GPUController/Delete/5
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
