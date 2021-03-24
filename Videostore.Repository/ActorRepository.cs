using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Videostore.Data;
using Videostore.Entities;
using Videostore.Repository.Interfaces;

namespace Videostore.Repository
{
    public class ActorRepository : IActorRepository
    {
        private readonly DataContext _context;

        public ActorRepository(DataContext context)
        {
            _context = context;
        }

        public void Add(Actor actor)
        {
            _context.Actors.Add(actor);
            _context.SaveChanges();
        }

        public void Delete(Actor actor)
        {
            _context.Actors.Remove(actor);
            _context.SaveChanges();
        }

        public void Edit(Actor actor)
        {
            _context.Actors.Update(actor);
            _context.SaveChanges();
        }

        public Actor GetActorByID(int ID)
        {
            var result = _context.Actors.FirstOrDefault(x => x.actorID == ID);
            return result;
        }

        public IEnumerable<Actor> GetActors()
        {
            var result = _context.Actors.AsEnumerable();
            return result; 
        }
    }
}
