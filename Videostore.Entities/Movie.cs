using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Videostore.Entities
{
    public class Movie
    {
        [Key]
        public int movieID { get; set; }

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

        [StringLength(500)]
        [Display(Name = "Description")]
        public string description { get; set; }

        public Studio studio { get; set; }
        public string studioName { get; set; }
        public int studioID { get; set; }
        
    }
}
