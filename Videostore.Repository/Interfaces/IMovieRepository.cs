using System;
using System.Collections.Generic;
using System.Text;
using Videostore.Entities;

namespace Videostore.Repository.Interfaces
{
    public interface IMovieRepository
    {
        void Add(Movie movie);
        void Edit(Movie movie);
        void Delete(Movie movie);
        Movie GetMovieByID(int ID);
        IEnumerable<Movie> GetMovies();


    }
}
