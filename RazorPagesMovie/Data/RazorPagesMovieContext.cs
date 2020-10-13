using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Models;

namespace RazorPagesMovie.Data
{
    public class RazorPagesMovieContext : DbContext
    {
        // I can remove the RazorPagesMovie.public DbSet<Movie> Movie { get; set; }
        public DbSet<RazorPagesMovie.Models.Movie> Movie { get; set; }
        public RazorPagesMovieContext (DbContextOptions<RazorPagesMovieContext> options)
            : base(options)
        {
        }

    }
}
