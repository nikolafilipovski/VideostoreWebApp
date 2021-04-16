using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Videostore.Models
{
    public class MovieViewModel
    {
        #region MovieData

        [StringLength(100)]
        [Display(Name = "Title")]
        public string title { get; set; }

        [Display(Name = "Runtime")]
        public string runTime { get; set; }

        [StringLength(20)]
        [Display(Name = "Genre")]
        public string genre { get; set; }

        [Display(Name = "Rating")]
        public double rating { get; set; }

        [Display(Name = "Release date")]
        public string releaseDate { get; set; }

        [StringLength(500)]
        [Display(Name = "Description")]
        public string description { get; set; }

        #endregion

        #region ActorData

        [Key]
        public int actorID { get; set; }

        [StringLength(50)]
        [Display(Name = "Cast")]
        public string actorName { get; set; }
        public string actorNationality { get; set; }
        public DateTime actorBirthday { get; set; }

        #endregion

        #region DirectorData

        [Key]
        [Display(Name = "Director")]
        public int directorID { get; set; }

        [StringLength(50)]
        public string directorName { get; set; }
        public string directorNationality { get; set; }
        public DateTime directorBirthday { get; set; }

        #endregion
    }
}
