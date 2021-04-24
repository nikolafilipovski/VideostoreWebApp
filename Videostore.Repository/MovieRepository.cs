using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Videostore.Data;
using Videostore.Entities;
using Videostore.Repository.Interfaces;

namespace Videostore.Repository
{
    public class MovieRepository : IMovieRepository
    {
        private readonly DataContext _context;
        private readonly ILogger<MovieRepository> _logger;

        public MovieRepository(DataContext context, ILogger<MovieRepository> logger)
        {
            _context = context;
            _logger = logger;
        }

        public void Add(Movie movie)
        {
            try
            {
                _context.Movies.Add(movie);
                _context.SaveChanges();
                _logger.LogInformation("New movie was created!");
            }
            catch (Exception exception)
            {
                _logger.LogError("An error occurred while creating a movie" + " | " + exception);
                throw;
            }
        }

        public void Delete(Movie movie)
        {
            try
            {
                _context.Movies.Remove(movie);
                _context.SaveChanges();
                _logger.LogInformation("Movie was deleted!");
            }
            catch (Exception exception)
            {
                _logger.LogError("An error occurred while deleting a movie" + " | " + exception);
                throw;
            }
        }

        public void Edit(Movie movie)
        {
            try
            {
                _context.Movies.Update(movie);
                _context.SaveChanges();
                _logger.LogInformation("Movie was updated!");
            }
            catch (Exception exception)
            {
                _logger.LogError("An error occurred while updating a movie" + " | " + exception);
                throw;
            }
        }

        public Movie GetMovieByID(int ID)
        {
            var result = _context.Movies.FirstOrDefault(x => x.movieID == ID);
            return result;
        }

        public IEnumerable<Movie> GetMovies()
        {
            var result = _context.Movies.AsEnumerable();
            return result;
        }
    }
}
