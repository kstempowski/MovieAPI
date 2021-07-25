using Microsoft.AspNetCore.Mvc;
using ReadingAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReadingAPI.Controllers
{
    public class MovieController : Controller
    {
        private readonly MovieDAL _movies = new MovieDAL();
        public async Task<IActionResult> Index()
        {
            var movies = await _movies.GetMovies();
            return View(movies);
        }

        public IActionResult MovieForm()
        {
            return View(new Movie());
        }

        public async Task<IActionResult> SaveMovie(Movie movie)
        {
            if (ModelState.IsValid)
            {
                await _movies.AddMovie(movie);
                return RedirectToAction("Index");
            }
            return View("Index");
        }

        public async Task<IActionResult> DeleteMovie(int id)
        {
            if (ModelState.IsValid)
            {
                await _movies.DeleteMovie(id);
                return RedirectToAction("Index");

            }
            return View("Index");
        }

        [HttpGet]
        public async Task<IActionResult> EditMovie(int id)
        {
            var movie = await _movies.GetMovie(id);
            if (movie.id == id)
            {
                return View("MovieForm", movie);
            }
            return View("Index");
        }


        [HttpPost]
        public async Task<IActionResult> EditMovie(int id, Movie editedMovie)
        {
            if (ModelState.IsValid)
            {
                await _movies.EditMovie(id, editedMovie);


            }
            return View("Index", editedMovie);
        }
    }
}