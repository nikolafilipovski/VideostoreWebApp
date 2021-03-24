using System;
using System.Collections.Generic;
using System.Text;
using Videostore.Entities;

namespace Videostore.Repository.Interfaces
{
    public interface IActorRepository
    {
        void Add(Actor actor);
        void Edit(Actor actor);
        void Delete(Actor actor);
        Actor GetActorByID(int ID);
        IEnumerable<Actor> GetActors();



    }
}
