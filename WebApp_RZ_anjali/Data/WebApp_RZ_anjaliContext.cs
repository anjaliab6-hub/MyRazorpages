using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApp_RZ_anjali.Model;

namespace WebApp_RZ_anjali.Data
{
    public class WebApp_RZ_anjaliContext : DbContext
    {
        public WebApp_RZ_anjaliContext (DbContextOptions<WebApp_RZ_anjaliContext> options)
            : base(options)
        {
        }

        public DbSet<WebApp_RZ_anjali.Model.Movie> Movie { get; set; } = default!;
    }
}
