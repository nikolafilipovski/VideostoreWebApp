using System;
using System.Collections.Generic;
using System.Text;
using System.Web.Mvc;
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

        public List<SelectListItem> genres = new List<SelectListItem>()
        {
            new SelectListItem() { Text = "Select genre", Selected = true },
            new SelectListItem() { Text = "Action", Value = "1" },
            new SelectListItem() { Text = "Comedy", Value = "2" },
            new SelectListItem() { Text = "Horror", Value = "3" },
            new SelectListItem() { Text = "Sci-Fi", Value = "4" },
            new SelectListItem() { Text = "Drama", Value = "5" },
            new SelectListItem() { Text = "Documentary", Value = "6" }
        };

        public List<SelectListItem> ratings = new List<SelectListItem>()
        {
            new SelectListItem() { Text = "Select rating", Selected = true },
            new SelectListItem() { Text = "Rated G", Value = "1" },
            new SelectListItem() { Text = "Rated GP", Value = "2" },
            new SelectListItem() { Text = "Rated R", Value = "3" },
            new SelectListItem() { Text = "Rated X", Value = "4" },
        };

        public Tuple<List<SelectListItem>, List<SelectListItem>> fillDropdowns(IEnumerable<Actor> actors, IEnumerable<Director> directors)
        {
            List<SelectListItem> Actors = new List<SelectListItem>()
            {
                new SelectListItem() { Value = "0", Text = "Select Actor ..." }
            };

            foreach (var actor in actors)
            {
                Actors.Add(new SelectListItem() { Value = actor.actorID.ToString(), Text = actor.actorName });
            }

            List<SelectListItem> Directors = new List<SelectListItem>()
            {
                new SelectListItem() { Value = "0", Text = "Select Director ..." }
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
