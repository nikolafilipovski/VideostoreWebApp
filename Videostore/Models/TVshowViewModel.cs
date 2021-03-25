using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Videostore.Models
{
    public class TVshowViewModel
    {
        #region TVshowData

        [StringLength(100)]
        public string title { get; set; }
        public string runTime { get; set; }

        [StringLength(20)]
        public string genre { get; set; }
        public double rating { get; set; }
        public string releaseDate { get; set; }

        [StringLength(500)]
        public string description { get; set; }

        #endregion

        #region ActorData

        [Key]
        public int actorID { get; set; }

        [StringLength(50)]
        public string actorName { get; set; }
        public string actorNationality { get; set; }
        public DateTime actorBirthday { get; set; }

        #endregion

        #region DirectorData

        [Key]
        public int directorID { get; set; }

        [StringLength(50)]
        public string directorName { get; set; }
        public string directorNationality { get; set; }
        public DateTime directorBirthday { get; set; }

        #endregion
    }
}
