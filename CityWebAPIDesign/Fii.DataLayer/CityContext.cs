using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fii.DataLayer
{
    public sealed class CityContext : DbContext
    {
        public CityContext(DbContextOptions<CityContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<City> Cities { get; set; }
    }
}
