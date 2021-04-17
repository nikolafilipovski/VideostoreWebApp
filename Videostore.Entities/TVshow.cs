using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Videostore.Entities
{
    public class TVshow
    {
        [Key]
        [Display(Name = "TV Show")]
        public int TVshowID { get; set; }

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

        public Actor actor { get; set; }
        public int actorID { get; set; }
        public Buy buy { get; set; }
        public int buyID { get; set; }
        public Director director { get; set; }
        public int directorID { get; set; }
        public Rent rent { get; set; }
        public int rentID { get; set; }
        public Watchlist watchlist { get; set; }
        public int watchlistID { get; set; }
    }
}
