using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Web2.Models;

namespace Web2.Data
{
    //會從 appsetting.json 讀取連接字串內容
    public class Web2Context : DbContext
    {
        public Web2Context (DbContextOptions<Web2Context> options)
            : base(options)
        {
        }

        public DbSet<Web2.Models.Movie> Movie { get; set; } = default!;
    }
}
