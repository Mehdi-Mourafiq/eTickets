using eTickets.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Models
{
    public class Producer:IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Photo de profile")]
        [Required(ErrorMessage = "Photo de profile est obligatoire")]
        public string ProfilePictureURL { get; set; }

        [Display(Name = "Le nom complet")]
        [Required(ErrorMessage = "Le nom complet est obligatoire")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Le nom doit etre entre 3 est 50 caractères")]
        public string FullName { get; set; }

        [Display(Name = "Biographie")]
        [Required(ErrorMessage = "La biographie est obligatoire")]
        public string Bio { get; set; }

        //Relationships
        public List<Movie> Movies { get; set; }
    }
}
