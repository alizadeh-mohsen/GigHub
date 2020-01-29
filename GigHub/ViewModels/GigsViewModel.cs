using System;
using GigHub.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GigHub.ViewModels
{
    public class GigsViewModel
    {
        public int Id { get; set; }

        [Required]
        public string Date { get; set; }
        
        [Required]
        public string Time { get; set; }
        
        [Required]
        public string Venue { get; set; }

        [Display(Name = "Genre")]
        public int GenreId { get; set; }
        
        public IEnumerable<Genre> Genres { get; set; }

        public DateTime GetDateTime()
        {
            return DateTime.Parse($"{Date} {Time}");
        }
    }
}
