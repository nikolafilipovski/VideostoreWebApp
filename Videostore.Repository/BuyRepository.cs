using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Videostore.Data;
using Videostore.Entities;
using Videostore.Repository.Interfaces;

namespace Videostore.Repository
{
    public class BuyRepository : IBuyRepository
    {
        private readonly DataContext _context;

        public BuyRepository(DataContext context)
        {
            _context = context;
        }

        public void Add(Buy buy)
        {
            _context.Buys.Add(buy);
            _context.SaveChanges();
        }

        public void Delete(Buy buy)
        {
            _context.Buys.Remove(buy);
            _context.SaveChanges();
        }

        public void Edit(Buy buy)
        {
            _context.Buys.Update(buy);
            _context.SaveChanges();
        }

        public Buy GetBuyByID(int ID)
        {
            var result = _context.Buys.FirstOrDefault(x => x.buyID == ID);
            return result;
        }

        public IEnumerable<Buy> GetBuys()
        {
            var result = _context.Buys.AsEnumerable();
            return result;
        }
    }
}
