using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Videostore.Entities
{
    public class Director
    {
        [Key]
        [Display(Name = "Name")]
        public int directorID { get; set; }

        [StringLength(50)]
        [Display(Name = "Director name")]
        public string directorName { get; set; }

        [Display(Name = "Nationality")]
        public string directorNationality { get; set; }

        [Display(Name = "Born")]
        public DateTime directorBirthday { get; set; }
        public ICollection<Movie> Movies { get; set; }
        public ICollection<TVshow> TVshows { get; set; }
    }
}
