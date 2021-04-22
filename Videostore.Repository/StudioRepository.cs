using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Videostore.Data;
using Videostore.Entities;
using Videostore.Repository.Interfaces;

namespace Videostore.Repository
{
    public class StudioRepository : IStudioRepository
    {
        private readonly DataContext _context;

        public StudioRepository(DataContext context)
        {
            _context = context;
        }

        public void Add(Studio studio)
        {
            _context.Studios.Add(studio);
            _context.SaveChanges();
        }

        public void Delete(Studio studio)
        {
            _context.Studios.Remove(studio);
            _context.SaveChanges();
        }

        public void Edit(Studio studio)
        {
            _context.Studios.Update(studio);
            _context.SaveChanges();
        }

        public Studio GetStudioByID(int ID)
        {
            var result = _context.Studios.FirstOrDefault(x => x.studioID == ID);
            return result;
        }

        public IEnumerable<Studio> GetStudios()
        {
            var result = _context.Studios.AsEnumerable();
            return result;
        }
    }
}
