using System;
using System.ComponentModel.DataAnnotations;

namespace GigHub.Models
{
    public class Gig
    {
        /* Propriedade: Id - Gig */
        public int Id { get; set; }

        [Required]
        /* Propriedade: Artista */
        public ApplicationUser Artist { get; set; }

        [Required]
        [StringLength(255)]
        /* Propriedade: Local */
        public string Venue { get; set; }

        public DateTime DateTime { get; set; }

        [Required]
        /* Relacionamento de Gig -> Genre */
        public Genre Genre { get; set; }
    }
}