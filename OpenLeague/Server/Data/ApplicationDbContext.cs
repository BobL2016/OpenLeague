using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OpenLeague.Shared.Models;
using OpenLeague.Server.Models;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.Extensions.Options;

namespace OpenLeague.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        { }

        public DbSet<Member> Members { get; set; }
        public DbSet<ScheduleItem> ScheduleItems { get; set; }

        public async override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            foreach (var entry in ChangeTracker.Entries())
            {
                if (entry.Entity is IBaseModel)
                {
                    if (entry.State == EntityState.Added)
                    {
                        entry.Property("Created").CurrentValue = DateTimeOffset.Now;
                    }
                    else if (entry.State == EntityState.Modified)
                    {
                        entry.Property("Updated").CurrentValue = DateTimeOffset.Now;
                    }
                }
            }

            return await base.SaveChangesAsync(cancellationToken);
        }
    }

}
