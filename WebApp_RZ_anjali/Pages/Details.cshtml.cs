using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApp_RZ_anjali.Data;
using WebApp_RZ_anjali.Model;

namespace WebApp_RZ_anjali.Pages
{
    public class DetailsModel : PageModel
    {
        private readonly WebApp_RZ_anjali.Data.WebApp_RZ_anjaliContext _context;

        public DetailsModel(WebApp_RZ_anjali.Data.WebApp_RZ_anjaliContext context)
        {
            _context = context;
        }

        public Movie Movie { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie = await _context.Movie.FirstOrDefaultAsync(m => m.Id == id);
            if (movie == null)
            {
                return NotFound();
            }
            else
            {
                Movie = movie;
            }
            // Console.WriteLine(movie);

            return Page();
        }
    }
}
