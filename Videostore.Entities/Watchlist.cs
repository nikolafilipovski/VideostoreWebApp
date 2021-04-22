using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Videostore.Entities
{
    public class Watchlist
    {
        [Key]
        public int watchlistID { get; set; }
        public int movieID { get; set; }
        public int buyID { get; set; }
        public int rentID { get; set; }
        public ICollection<Movie> Movies { get; set; }
    }
}
