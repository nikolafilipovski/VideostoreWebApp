using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Videostore.Models
{
    public class UserModel
    {
        [Key]
        public string ID { get; set; }

        [Required]
        public string name { get; set; }

        [Required]
        public string email { get; set; }

        [Required]
        public string password { get; set; }

        public IQueryable<SelectListItem> roles { get; set; }

        public string roleID { get; set; }

        public string roleName { get; set; }
    }
}
