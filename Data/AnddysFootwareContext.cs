using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AnddysFootware.Models;

namespace AnddysFootware.Data
{
    public class AnddysFootwareContext : DbContext
    {
        public AnddysFootwareContext (DbContextOptions<AnddysFootwareContext> options)
            : base(options)
        {
        }

        public DbSet<AnddysFootware.Models.AndysFootware> AndysFootware { get; set; }
    }
}
