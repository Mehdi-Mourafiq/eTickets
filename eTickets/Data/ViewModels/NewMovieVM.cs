using eTickets.Data;
using eTickets.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Models
{
    public class NewMovieVM
    {
        public int Id { get; set; }

        [Display(Name = "Nom du livre")]
        [Required(ErrorMessage = "Le nom est obligatoire")]
        public string Name { get; set; }

        [Display(Name = "Description du livre")]
        [Required(ErrorMessage = "La description est obligatoire")]
        public string Description { get; set; }

        [Display(Name = "Prix en $")]
        [Required(ErrorMessage = "Prix est obligatoire")]
        public double Price { get; set; }

        [Display(Name = "URL de l’affiche de livre")]
        [Required(ErrorMessage = "URL de l’affiche de livre est obligatoire")]
        public string ImageURL { get; set; }

        [Display(Name = "Date de début du livre")]
        [Required(ErrorMessage = "Date de début est obligatoire")]
        public DateTime StartDate { get; set; }

        [Display(Name = "Date de fin du livre")]
        [Required(ErrorMessage = "Date de fin est obligatoire")]
        public DateTime EndDate { get; set; }

        [Display(Name = "Selectionner la categorie")]
        [Required(ErrorMessage = "La categorie du film est obligatoire")]
        public MovieCategory MovieCategory { get; set; }

        //Relationships
        [Display(Name = "Selectionner l'acteur(s)")]
        [Required(ErrorMessage = "L'acteur(s) du film est obligatoire")]
        public List<int> ActorIds { get; set; }

        [Display(Name = "Selectionner la Librairie")]
        [Required(ErrorMessage = "Librairie est obligatoire")]
        public int CinemaId { get; set; }

        [Display(Name = "Selectionner le producteur")]
        [Required(ErrorMessage = "Producteur du film est obligatoire")]
        public int ProducerId { get; set; }
    }
}
