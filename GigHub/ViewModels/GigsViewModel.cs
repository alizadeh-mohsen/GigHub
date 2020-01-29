using System;
using GigHub.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using GigHub.Helper;

namespace GigHub.ViewModels
{
    public class GigsViewModel
    {
        public int Id { get; set; }

        [Required, ValidDate]
        public string Date { get; set; }

        [Required, ValidTime]
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
