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
    public class IndexModel : PageModel
    {
        private readonly WebApp_RZ_anjali.Data.WebApp_RZ_anjaliContext _context;

        public IndexModel(WebApp_RZ_anjali.Data.WebApp_RZ_anjaliContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
