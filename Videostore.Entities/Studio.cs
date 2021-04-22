using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Videostore.Entities
{
    public class Studio
    {
        [Key]
        [Display(Name = "Studio")]
        public int studioID { get; set; }
        [Display(Name = "Studio Name")]
        public string studioName { get; set; }
    }
}
