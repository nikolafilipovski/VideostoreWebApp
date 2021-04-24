using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
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
        private readonly ILogger<MovieService> _logger;

        public MovieService(IMovieRepository movieRepository, ILogger<MovieService> logger)
        {
            _movieRepository = movieRepository;
            _logger = logger;
        }

        public void Add(Movie movie)
        {
            try
            {
                _movieRepository.Add(movie);
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
                _movieRepository.Delete(movie);
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
                _movieRepository.Edit(movie);
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
