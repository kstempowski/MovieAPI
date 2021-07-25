using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieLabAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieLabAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieLabController : ControllerBase
    {
        private readonly MovieLabContext _context;
        public MovieLabController(MovieLabContext context)
        {
            _context = context;
        }
        #region Create
        //POST: api/Movielab
        [HttpPost]
        public async Task<ActionResult<Movie>> AddMovie(Movie movie)
        {
            _context.Movies.Add(movie);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetMovie), new { id = movie.Id }, movie);
        }

        #endregion


        #region Read
        //GET: api/Movielab
        [HttpGet]
        public async Task<ActionResult<List<Movie>>> GetMovies()
        {
            var movies = await _context.Movies.ToListAsync();
            return movies;
        }

        //GET: api/Movielab/1
        [HttpGet("{id}")]
        public async Task<ActionResult<Movie>> GetMovie(int id)
        {
            var movie = await _context.Movies.FindAsync(id);
            if (movie == null)
            {
                return NotFound();
            }
            else
            {
                return movie;
            }
        }

        #endregion

        #region Update
        //PUT: api/Movielab/{id}
        [HttpPut("{id}")]
        public async Task<ActionResult<Movie>> EditMovie(int id, Movie movie)
        {
            if (id != movie.Id || !ModelState.IsValid)
            {
                return BadRequest();
            }
            else
            {
                Movie dbMovie = _context.Movies.Find(id);
                dbMovie.Title = movie.Title;
                dbMovie.Genre = movie.Genre;
                dbMovie.Runtime = movie.Runtime;
                _context.Entry(dbMovie).State = EntityState.Modified;
                _context.Update(dbMovie);
                await _context.SaveChangesAsync();
                return NoContent();
            }
        }

        #endregion

        #region Delete
        [HttpDelete("{id}")]
        public async Task<ActionResult<Movie>> DeleteMovie(int id)
        {
            var movie = await _context.Movies.FindAsync(id);
            if(id == movie.Id)
            _context.Movies.Remove(movie);
            
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");

            #endregion
           
        }
    }
}
