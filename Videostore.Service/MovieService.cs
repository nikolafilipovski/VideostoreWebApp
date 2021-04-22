using Microsoft.AspNetCore.Mvc.Rendering;
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

        #region Helper Methods

        public IEnumerable<SelectListItem> StudiosDropdown(IEnumerable<Studio> studios)
        {
            List<SelectListItem> Studios = new List<SelectListItem>()
            {
                new SelectListItem(){ Value = "0", Text = "Select Studio..."}
            };

            foreach (var item in studios)
            {
                Studios.Add(new SelectListItem() { Value = item.studioID.ToString(), Text = item.studioName, Selected = false });
            }
            return Studios;
        }

        #endregion
    }
}
