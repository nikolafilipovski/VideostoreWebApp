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

        #region Dropdowns

        public Tuple<List<SelectListItem>, List<SelectListItem>> fillDropdowns(IEnumerable<Actor> actors, IEnumerable<Director> directors)
        {
            List<SelectListItem> Actors = new List<SelectListItem>()
            {
                new SelectListItem() { Value = "0", Text = "Select Actor..." }
            };

            foreach (var actor in actors)
            {
                Actors.Add(new SelectListItem() { Value = actor.actorID.ToString(), Text = actor.actorName });
            }

            List<SelectListItem> Directors = new List<SelectListItem>()
            {
                new SelectListItem() { Value = "0", Text = "Select Director..." }
            };

            foreach (var director in directors)
            {
                Actors.Add(new SelectListItem() { Value = director.directorID.ToString(), Text = director.directorName });
            }

            return Tuple.Create(Actors, Directors);

        }

        #endregion





    }
}
