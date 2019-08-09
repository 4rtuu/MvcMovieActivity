using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MvcMovieActivity.Models
{
    public class MvcMovieActivityContext : DbContext
    {
        public MvcMovieActivityContext (DbContextOptions<MvcMovieActivityContext> options)
            : base(options)
        {
        }

        public DbSet<MvcMovieActivity.Models.Movie> Movie { get; set; }
    }
}
