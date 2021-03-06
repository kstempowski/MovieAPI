using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ReadingAPI.Models
{
    public class MovieDAL
    {
        public HttpClient GetHttpClient()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44313/");
            return client;
        }

        public async Task<List<Movie>> GetMovies()
        {
            var client = GetHttpClient();

            var response = await client.GetAsync("/api/movielab");
            var movies = await response.Content.ReadAsAsync<List<Movie>>();


            return movies;
        }

        public async Task<Movie> GetMovie(int id)
        {
            var client = GetHttpClient();
            var response = await client.GetAsync($"/api/movielab.{id}");
            var movie = await response.Content.ReadAsAsync<Movie>();
            return movie;
        }

        public async Task AddMovie(Movie movie)
        {
            var client = GetHttpClient();
            var response = await client.PostAsJsonAsync("/api/movielab", movie);
        }

        public async Task DeleteMovie(int id)
        {
            var client = GetHttpClient();
            var response = await client.DeleteAsync($"/api/movielab/{id}");
        }

        public async Task EditMovie(int id, Movie movie)
        {
            var client = GetHttpClient();
            var resposne = await client.PutAsJsonAsync($"/api/movieLab/{id}", movie);
        }
    }
}
