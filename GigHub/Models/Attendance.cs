using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GigHub.Models
{
    /* Esta classe: 'Attendance' ela foi criada devido ao relacionamento entre: Gig - > User (ApplicationUser)
     * e como se trata de um relacionamento 'n para n' tivemos que criar essa classe */
    public class Attendance
    {
        public Gig Gig { get; set; }

        public ApplicationUser Attende { get; set; }

        [Key]
        [Column(Order = 1)]
        public int GigId { get; set; }

        [Key]
        [Column(Order = 2)]
        public string AttendeeId { get; set; }
    }
}
