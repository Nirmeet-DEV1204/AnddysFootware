using AnddysFootware.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnddysFootware.Data
{
    public class MvcAndyContext : DbContext
    {
        public MvcAndyContext(DbContextOptions<MvcAndyContext> options) : base(options)
        { 
        
        }
        public DbSet<AndysFootware> AndysFootware { get; set; }
    }
}
