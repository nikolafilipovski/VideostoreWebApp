using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;
using Videostore.Entities;

namespace Videostore.Service.Interfaces
{
    public interface IMovieService
    {
        void Add(Movie movie);
        void Edit(Movie movie);
        void Delete(Movie movie);
        Movie GetMovieByID(int ID);
        IEnumerable<Movie> GetMovies();
        IEnumerable<SelectListItem> StudiosDropdown(IEnumerable<Studio> studios);
    }
}
