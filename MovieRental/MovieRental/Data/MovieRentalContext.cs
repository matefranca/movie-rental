using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MovieRental.Model;

namespace MovieRental.Data
{
    public class MovieRentalContext : DbContext
    {
        public MovieRentalContext (DbContextOptions<MovieRentalContext> options)
            : base(options)
        {
        }

        public DbSet<Client> Client { get; set; }

        public DbSet<Movie> Movie { get; set; }

        public DbSet<Rental> Rental { get; set; }
    }
}
