using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;

namespace GigHub.Models
{
    public class Gig
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }

        [Required, StringLength(100)]
        public string Venue { get; set; }

        public IdentityUser Artist { get; set; }

        [Required]
        public string ArtistId { get; set; }
        
        [Required]
        public int GenreId { get; set; }

        public Genre Genre { get; set; }
    }
}
