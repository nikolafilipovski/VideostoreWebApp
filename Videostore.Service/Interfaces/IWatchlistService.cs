using System;
using System.Collections.Generic;
using System.Text;
using Videostore.Entities;

namespace Videostore.Service.Interfaces
{
    public interface IWatchlistService
    {
        void Add(Watchlist watchlist);
        void Edit(Watchlist watchlist);
        void Delete(Watchlist watchlist);
        Watchlist GetWatchlistByID(int ID);
        IEnumerable<Watchlist> GetWatchlists();
    }
}
