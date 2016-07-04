using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using GigHub.Models;

namespace GigHub.ViewModels
{
    public class GigViewModel
    {
        [Required]
        [Display(Name = "Local")]
        public string Venue { get; set; }

        [Required]
        [FutureDate]
        [Display(Name = "Data do Show")]
        public string Date { get; set; }

        [Required]
        [ValidTime]
        [Display(Name = "Hora")]
        public string Time { get; set; }

        [Required]
        [Display(Name = "Gênero Musical")]
        public byte Genre { get; set; }

        /* Aqui é para criar uma lista de Gêneros Musicais para a nossa View */
        public IEnumerable<Genre> Genres { get; set; }

        public DateTime GetDateTime()
        {
            return DateTime.Parse(string.Format("{0} {1}", Date, Time));           
        }
    }
}