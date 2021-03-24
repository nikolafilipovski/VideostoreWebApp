using System;
using System.Collections.Generic;
using System.Text;
using Videostore.Entities;
using Videostore.Repository.Interfaces;
using Videostore.Service.Interfaces;

namespace Videostore.Service
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _movieRepository;

        public MovieService(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public void Add(Movie movie)
        {
            _movieRepository.Add(movie);
        }

        public void Delete(Movie movie)
        {
            _movieRepository.Delete(movie);
        }

        public void Edit(Movie movie)
        {
            _movieRepository.Edit(movie);
        }

        public Movie GetMovieByID(int ID)
        {
            var result = _movieRepository.GetMovieByID(ID);
            return result;
        }

        public IEnumerable<Movie> GetMovies()
        {
            var result = _movieRepository.GetMovies();
            return result;
        }
    }
}
