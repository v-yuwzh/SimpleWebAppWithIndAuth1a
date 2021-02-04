using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SimpleWebAppWithIndAuth1.Data;
using SimpleWebAppWithIndAuth1.Models;

namespace SimpleWebAppWithIndAuth1.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly SimpleWebAppWithIndAuth1.Data.ApplicationDbContext _context;

        public IndexModel(SimpleWebAppWithIndAuth1.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
