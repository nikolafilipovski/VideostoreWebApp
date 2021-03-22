using System;
using System.Collections.Generic;
using System.Text;

namespace Videostore.Entities
{
    public class Watchlist
    {
        public int watchlistID { get; set; }
        public int movieID { get; set; }
        public int TVshowID { get; set; }
        public int buyID { get; set; }
        public int rentID { get; set; }
        public ICollection<Movie> Movies { get; set; }
        public ICollection<TVshow> TVshows { get; set; }
    }
}
