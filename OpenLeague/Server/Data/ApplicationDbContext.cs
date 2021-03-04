using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OpenLeague.Shared.Models;

namespace OpenLeague.Server.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }

        public DbSet<Member> Members { get; set; }
        public DbSet<ScheduleItem> ScheduleItems { get; set; }
    }
}
