using System.ComponentModel.DataAnnotations;

namespace GigHub.Models
{
    public class Genre
    {
        /* Propriedade: Id - Gênero (definimos como tipo 'byte' porque a quantidade de gêneros
         * não irá ultrapassar mais do que 255 */
        public byte Id { get; set; }

        [Required]
        [StringLength(255)]
        /* Propriedade: Nome - Gênero */
        public string Name { get; set; }
    }
}