using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Videostore.Entities
{
    public class Rent
    {
        [Key]
        public int rentID { get; set; }
        public int movieID { get; set; }
        public ICollection<Movie> Movies { get; set; }
    }
}
