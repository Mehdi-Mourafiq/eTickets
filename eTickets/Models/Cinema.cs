using eTickets.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Models
{
    public class Cinema:IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "librairie Logo")]
        [Required(ErrorMessage = "Le logo de librairie  est obligatoire")]
        public string Logo { get; set; }

        [Display(Name = "librairie Name")]
        [Required(ErrorMessage = "Le logo de librairie est obligatoire")]
        public string Name { get; set; }

        [Display(Name = "Description")]
        [Required(ErrorMessage = "La description du librairie  est obligatoire")]
        public string Description { get; set; }

        //Relationships
        public List<Movie> Movies { get; set; }
    }
}
