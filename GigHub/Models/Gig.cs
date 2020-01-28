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

        [Required]
        public IdentityUser Artist { get; set; }

        [Required]
        public Genre Genre { get; set; }
    }
}
