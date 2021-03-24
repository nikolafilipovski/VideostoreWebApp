using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Videostore.Data;
using Videostore.Entities;
using Videostore.Repository.Interfaces;

namespace Videostore.Repository
{
    public class WatchlistRepository : IWatchlistRepository
    {
        private readonly DataContext _context;

        public WatchlistRepository(DataContext context)
        {
            _context = context;
        }

        public void Add(Watchlist watchlist)
        {
            _context.Watchlists.Add(watchlist);
            _context.SaveChanges();
        }

        public void Delete(Watchlist watchlist)
        {
            _context.Watchlists.Remove(watchlist);
            _context.SaveChanges();
        }

        public void Edit(Watchlist watchlist)
        {
            _context.Watchlists.Update(watchlist);
            _context.SaveChanges();
        }

        public Watchlist GetWatchlistByID(int ID)
        {
            var result = _context.Watchlists.FirstOrDefault(x => x.watchlistID == ID);
            return result;
        }

        public IEnumerable<Watchlist> GetWatchlists()
        {
            var result = _context.Watchlists.AsEnumerable();
            return result;
        }
    }
}
