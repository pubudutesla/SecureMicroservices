using Movies.Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Client.ApiServices
{
    public class MovieApiService : IMovieApiService
    {
        public async Task<IEnumerable<Movie>> GetMovies()
        {
            var movieList = new List<Movie>();
            movieList.Add(
                new Movie
                {
                    Title= "Avengers: End Game",
                    Genre= "Sci-Fi",
                    Rating= "10.0",
                    ReleaseDate= DateTime.Now,
                    ImageUrl= "images/src",
                    Owner= "tesla"
                });

            return await Task.FromResult(movieList);
        }

        Task<Movie> IMovieApiService.CreateMovie(Movie movie)
        {
            throw new NotImplementedException();
        }

        Task IMovieApiService.DeleteMovie(int id)
        {
            throw new NotImplementedException();
        }

        Task<Movie> IMovieApiService.GetMovie(string id)
        {
            throw new NotImplementedException();
        }

        Task<Movie> IMovieApiService.UpdateMovie(Movie movie)
        {
            throw new NotImplementedException();
        }
    }
}
