﻿using System;
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
        public string title { get; set; }
        public string runTime { get; set; }

        [StringLength(20)]
        public string genre { get; set; }
        public double rating { get; set; }
        public string releaseDate { get; set; }

        [StringLength(500)]
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
