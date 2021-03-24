using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Videostore.Data;
using Videostore.Entities;
using Videostore.Repository.Interfaces;

namespace Videostore.Repository
{
    public class DirectorRepository : IDirectorRepository
    {
        private readonly DataContext _context;

        public DirectorRepository(DataContext context)
        {
            _context = context;
        }

        public void Add(Director director)
        {
            _context.Directors.Add(director);
            _context.SaveChanges();
        }

        public void Delete(Director director)
        {
            _context.Directors.Remove(director);
            _context.SaveChanges();
        }

        public void Edit(Director director)
        {
            _context.Directors.Update(director);
            _context.SaveChanges();
        }

        public Director GetDirectorByID(int ID)
        {
            var result = _context.Directors.FirstOrDefault(x => x.directorID == ID);
            return result;
        }

        public IEnumerable<Director> GetDirectors()
        {
            var result = _context.Directors.AsEnumerable();
            return result;
        }
    }
}
