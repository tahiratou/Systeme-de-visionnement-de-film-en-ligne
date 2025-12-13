using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisionFlix.Infrastructure.Data
{
    public class VisionFlixDbContextFactory : IDesignTimeDbContextFactory<VisionFlixDbContext>
    {
        public VisionFlixDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<VisionFlixDbContext>();

            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=VisionFlixDB;Integrated Security=True;TrustServerCertificate=True;");

            return new VisionFlixDbContext(optionsBuilder.Options);
        }
    }
}

