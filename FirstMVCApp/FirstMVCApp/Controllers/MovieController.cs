using FirstMVCApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstMVCApp.Controllers
{
    public class MovieController : Controller
    {
        // GET: MovieController
        public ActionResult Index()
        {
            List<Entities> MovieList = MovieDbRepository.GetMovieList();
            return View(MovieList);
        }

        // GET: MovieController/Details/5
        public ActionResult Details(int id)
        {
            if (id <= 0)
            {
                return RedirectToAction("Index");
            }
            Entities entities = MovieDbRepository.GetMovieById(id);
            return View(entities);
        }

        // GET: MovieController/Create
        public ActionResult Create()
        {
            Entities entities = new Entities();
            return View(entities);
            
        }

        // POST: MovieController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection, Entities pEntities)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    MovieDbRepository.AddNewMovie(pEntities);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MovieController/Edit/5
        public ActionResult Edit(int id)
        {
            Entities entities = MovieDbRepository.GetMovieById(id);
            if (entities != null)
            {
                return View(entities);
            }
            return View(entities);
        }

        // POST: MovieController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection, Entities pEntities)
        {
            try
            {
                MovieDbRepository.UpdateMovie(pEntities);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MovieController/Delete/5
        public ActionResult Delete( int id)
        {
            Entities entities = MovieDbRepository.GetMovieById(id);
            if (entities != null)
            {
                return View(entities);
            }
            return View(entities);
        }

        // POST: MovieController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection, Entities pEntities)
        {
            try
            {
                MovieDbRepository.DeleteMovie(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
