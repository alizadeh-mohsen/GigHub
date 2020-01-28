using GigHub.Data;
using GigHub.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace GigHub.Controllers
{
    public class GigsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public GigsController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Create()
        {
            GigsViewModel model = new GigsViewModel
            {
                Genres = await _context.Genres.ToListAsync()
            };
            return View(model);
        }
    }
}