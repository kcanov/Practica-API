using System.ComponentModel.DataAnnotations;

namespace API.Movies.DAL.Models
{
    public class Movie : AuditBase
    {
        [Required]
        [Display(Name = "Nombre de la Pelicula")] 
        public string Name { get; set; }
        public string Duration { get; set; }

        public string Description { get; set; }
        public string Clasification { get; set; }

    }
}