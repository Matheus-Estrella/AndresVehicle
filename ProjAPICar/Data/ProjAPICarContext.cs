using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Generator;

namespace ProjAPICar.Data
{
    public class ProjAPICarContext : DbContext
    {
        public ProjAPICarContext (DbContextOptions<ProjAPICarContext> options)
            : base(options)
        {
        }

        public DbSet<Generator.Car> Car { get; set; } = default!;
    }
}
