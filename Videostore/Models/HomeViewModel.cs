using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Videostore.Entities;

namespace Videostore.Models
{
    public class HomeViewModel
    {
        public IEnumerable<Movie> AllMovies { get; set; }
    }
}
