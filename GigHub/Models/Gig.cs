using System;
using System.ComponentModel.DataAnnotations;

namespace GigHub.Models
{
    public class Gig
    {
        /* Propriedade: Id */
        public int Id { get; set; }

        /* Propriedade: Artista */
        public ApplicationUser Artist { get; set; }

        [Required]
        public string ArtistId { get; set; }

        [Required]
        [StringLength(255)]
        /* Propriedade: Local */
        public string Venue { get; set; }

        [Display(Name = "Data do Show")]
        public DateTime DateTime { get; set; }

        [Required]
        public byte GenreId { get; set; }

        /* Relacionamento de Gig -> Genre */
        public Genre Genre { get; set; }       
    }
}