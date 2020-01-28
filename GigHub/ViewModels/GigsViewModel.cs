using GigHub.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GigHub.ViewModels
{
    public class GigsViewModel
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string Venue { get; set; }

        [Display(Name = "Genre")]
        public int GenreId { get; set; }
        public IEnumerable<Genre> Genres { get; set; }
    }
}
