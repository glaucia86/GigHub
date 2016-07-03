using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using GigHub.Models;

namespace GigHub.ViewModels
{
    public class GigViewModel
    {
        [Display(Name = "Local")]
        public string Venue { get; set; }

        [Display(Name = "Data do Show")]
        public string Date { get; set; }

        [Display(Name = "Hora")]
        public string Time { get; set; }

        [Display(Name = "Gênero Musical")]
        public byte Genre { get; set; }

        /* Aqui é para criar uma lista de Gêneros Musicais para a nossa View */
        public IEnumerable<Genre> Genres { get; set; }
    }
}