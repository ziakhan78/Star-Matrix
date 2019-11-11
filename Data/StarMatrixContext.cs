using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StarMatrix.Models;

namespace StarMatrix.Models
{
    public class StarMatrixContext : DbContext
    {
        public StarMatrixContext()
        {
        }

        public StarMatrixContext (DbContextOptions<StarMatrixContext> options)
            : base(options)
        {
        }

        public DbSet<StarMatrix.Models.Admin> Admin { get; set; }

        public DbSet<StarMatrix.Models.ShipLocation> ShipLocation { get; set; }

        public DbSet<StarMatrix.Models.ClassType> ClassType { get; set; }

        public DbSet<StarMatrix.Models.Tug> Tug { get; set; }

        public DbSet<StarMatrix.Models.BollardPull> BollardPull { get; set; }

        public DbSet<StarMatrix.Models.EngineHP> EngineHP { get; set; }
    }
}
