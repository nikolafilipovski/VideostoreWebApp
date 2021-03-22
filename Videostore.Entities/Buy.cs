using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Videostore.Entities
{
    public class Buy
    {
        [Key]
        public int buyID { get; set; }
        public int movieID { get; set; }
        public int TVshowID { get; set; }
        public ICollection<Movie> Movies { get; set; }
        public ICollection<TVshow> TVshows { get; set; }
    }
}
