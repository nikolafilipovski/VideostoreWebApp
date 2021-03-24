using System;
using System.Collections.Generic;
using System.Text;
using Videostore.Entities;
using Videostore.Repository.Interfaces;
using Videostore.Service.Interfaces;

namespace Videostore.Service
{
    public class WatchlistService : IWatchlistService
    {
        private readonly IWatchlistRepository _watchlistRepository;

        public WatchlistService(IWatchlistRepository watchlistRepository)
        {
            _watchlistRepository = watchlistRepository;
        }

        public void Add(Watchlist watchlist)
        {
            _watchlistRepository.Add(watchlist);
        }

        public void Delete(Watchlist watchlist)
        {
            _watchlistRepository.Delete(watchlist);
        }

        public void Edit(Watchlist watchlist)
        {
            _watchlistRepository.Edit(watchlist);
        }

        public Watchlist GetWatchlistByID(int ID)
        {
            var result = _watchlistRepository.GetWatchlistByID(ID);
            return result;
        }

        public IEnumerable<Watchlist> GetWatchlists()
        {
            var result = _watchlistRepository.GetWatchlists();
            return result;
        }
    }
}
