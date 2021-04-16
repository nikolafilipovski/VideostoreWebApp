using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;
using Videostore.Entities;
using Videostore.Repository.Interfaces;
using Videostore.Service.Interfaces;

namespace Videostore.Service
{
    public class ActorService : IActorService
    {
        private readonly IActorRepository _actorRepository;

        public ActorService(IActorRepository actorRepository)
        {
            _actorRepository = actorRepository;
        }

        public void Add(Actor actor)
        {
            _actorRepository.Add(actor);
        }

        public void Delete(Actor actor)
        {
            _actorRepository.Delete(actor);
        }

        public void Edit(Actor actor)
        {
            _actorRepository.Edit(actor);
        }

        public Actor GetActorByID(int ID)
        {
            var result = _actorRepository.GetActorByID(ID);
            return result;
        }

        public IEnumerable<Actor> GetActors()
        {
            var result = _actorRepository.GetActors();
            return result;
        }

        #region Helper methods
        public IEnumerable<SelectListItem> dropdownActors(IEnumerable<Actor> actors)
        {
            List<SelectListItem> Actors = new List<SelectListItem>()
            {
                new SelectListItem() { Value = "0", Text = "Select Actor..."}
            };

            foreach (var item in actors)
            {
                Actors.Add(new SelectListItem() { Value = item.actorID.ToString(), Text = item.actorName });
            }
            return Actors;
        }
        #endregion
    }
}
