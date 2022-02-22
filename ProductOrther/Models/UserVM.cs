using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProductOrther.Data
{
    public class UserVM
    {
        public int Id {get; set;}
        [Required(ErrorMessage="This field is required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public string Password { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public string Email { get; set; }
        [Required(ErrorMessage = "This field is required")]
        [EnumDataType(typeof(RoleType))]
        public RoleType Role { get; set; }
        [NotMapped]
        public List<SelectListItem> Orders { get; set; }

    }
}
