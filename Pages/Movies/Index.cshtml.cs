using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Web2.Data;
using Web2.Models;

namespace Web2.Pages.Movies
{
    //命名慣例 <PageName>Model
    public class IndexModel : PageModel
    {
        private readonly Web2.Data.Web2Context _context;

        public IndexModel(Web2.Data.Web2Context context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Movie != null)
            {
                Movie = await _context.Movie.ToListAsync();
            }
        }
    }
}
