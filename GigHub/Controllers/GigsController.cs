using GigHub.Data;
using GigHub.Models;
using GigHub.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace GigHub.Controllers
{
    public class GigsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public GigsController(ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        [Authorize]
        public async Task<IActionResult> Create()
        {
            GigsViewModel model = new GigsViewModel
            {
                Genres = await _context.Genres.ToListAsync()
            };
            return View(model);
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Create(GigsViewModel newGig)
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);

            var gig = new Gig
            {
                ArtistId = user.Id,
                GenreId = newGig.GenreId,
                Date = DateTime.Parse(string.Format("{0} {1}", newGig.Date, newGig.Time)),
                Venue = newGig.Venue
            };


            _context.Gigs.Add(gig);

            var result = await _context.SaveChangesAsync();
            if (result > 0)
            {
                newGig.Id = gig.Id;
                return RedirectToAction("index", "Home");
            }

            return BadRequest();
        }
        public IActionResult Save(string @class)
        {
            throw new System.NotImplementedException();
        }
    }
}