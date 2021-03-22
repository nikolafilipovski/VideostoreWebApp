using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Videostore.Entities
{
    public class Actor
    {
        [Key]
        public int actorID { get; set; }

        [StringLength(50)]
        public string name { get; set; }
        public string nationality { get; set; }
        public DateTime birthday { get; set; }
        public ICollection<Movie> Movies { get; set; }
        public ICollection<TVshow> TVshows { get; set; }
    }
}
