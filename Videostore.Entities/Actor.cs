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
        [Display(Name = "Name")]
        public string actorName { get; set; }

        [Display(Name = "Nationality")]
        public string actorNationality { get; set; }

        [Display(Name = "Born")]
        public DateTime actorBirthday { get; set; }
        public ICollection<Movie> Movies { get; set; }
        public ICollection<TVshow> TVshows { get; set; }
    }
}
