using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Context
{
    public class RickContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Rick;Trusted_Connection=true");
        }

        public DbSet<Character> Character { get; set; }
        public DbSet<CharacterLocation> CharacterLocation { get; set; }
        public DbSet<CharacterOrigin> CharacterOrigin { get; set; }
        public DbSet<Episode> Episode { get; set; }
        public DbSet<Location> Location { get; set; }


    }
}
