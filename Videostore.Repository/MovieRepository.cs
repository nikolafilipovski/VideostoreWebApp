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

        public MovieRepository(DataContext context)
        {
            _context = context;
        }

        public void Add(Movie movie)
        {
            _context.Movies.Add(movie);
            _context.SaveChanges();
        }

        public void Delete(Movie movie)
        {
            _context.Movies.Remove(movie);
            _context.SaveChanges();
        }

        public void Edit(Movie movie)
        {
            _context.Movies.Update(movie);
            _context.SaveChanges();
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
