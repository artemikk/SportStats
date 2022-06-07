using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SportStats.Models;

namespace SportStats.Data
{
    public class SportStatsContext : DbContext
    {
        public SportStatsContext (DbContextOptions<SportStatsContext> options)
            : base(options)
        {
        }

        public DbSet<SportStats.Models.Zenit>? Zenit { get; set; }

        public DbSet<SportStats.Models.Akhmat>? Akhmat { get; set; }

        public DbSet<SportStats.Models.Arsenal>? Arsenal { get; set; }

        public DbSet<SportStats.Models.CSKA>? CSKA { get; set; }

        public DbSet<SportStats.Models.Dynamo>? Dynamo { get; set; }

        public DbSet<SportStats.Models.Khimki>? Khimki { get; set; }

        public DbSet<SportStats.Models.Krasnodar>? Krasnodar { get; set; }

        public DbSet<SportStats.Models.KrylyaSovetov>? KrylyaSovetov { get; set; }

        public DbSet<SportStats.Models.Lokomotiv>? Lokomotiv { get; set; }

        public DbSet<SportStats.Models.NizhniyNovgorod>? NizhniyNovgorod { get; set; }

        public DbSet<SportStats.Models.Rostov>? Rostov { get; set; }

        public DbSet<SportStats.Models.Rubin>? Rubin { get; set; }

        public DbSet<SportStats.Models.Sochi>? Sochi { get; set; }

        public DbSet<SportStats.Models.Spartak>? Spartak { get; set; }

        public DbSet<SportStats.Models.Ufa>? Ufa { get; set; }

        public DbSet<SportStats.Models.Ural>? Ural { get; set; }
    }
}
