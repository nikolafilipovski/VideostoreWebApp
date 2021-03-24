using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Videostore.Data;
using Videostore.Entities;
using Videostore.Repository.Interfaces;

namespace Videostore.Repository
{
    public class TVshowRepository : ITVshowRepository
    {
        private readonly DataContext _context;

        public TVshowRepository(DataContext context)
        {
            _context = context;
        }

        public void Add(TVshow tvshow)
        {
            _context.TVshows.Add(tvshow);
            _context.SaveChanges();
        }

        public void Delete(TVshow tvshow)
        {
            _context.TVshows.Remove(tvshow);
            _context.SaveChanges();
        }

        public void Edit(TVshow tvshow)
        {
            _context.TVshows.Update(tvshow);
            _context.SaveChanges();
        }

        public TVshow GetTVshowByID(int ID)
        {
            var result = _context.TVshows.FirstOrDefault(x => x.TVshowID == ID);
            return result;
        }

        public IEnumerable<TVshow> GetTVshows()
        {
            var result = _context.TVshows.AsEnumerable();
            return result;
        }
    }
}
