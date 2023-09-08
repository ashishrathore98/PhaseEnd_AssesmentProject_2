using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PhaseEndProject2.Models;

namespace PhaseEndProject2.Data
{
    public class PhaseEndProject2DbContext : DbContext
    {
        public PhaseEndProject2DbContext (DbContextOptions<PhaseEndProject2DbContext> options)
            : base(options)
        {
        }

        public DbSet<PhaseEndProject2.Models.Order> Order { get; set; } = default!;

        public DbSet<PhaseEndProject2.Models.OrderDetail>? OrderDetail { get; set; }

        public DbSet<PhaseEndProject2.Models.Product>? Product { get; set; }
    }
}
