using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OpenLeague.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace OpenLeague.Server.Data
{
    public class DbInitializer
    {
        public static async void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            if (context.Members.Any())
            {
                return;
            }

            context.Members.AddRange(Seeds.Members);
            await context.SaveChangesAsync();

            context.ScheduleItems.AddRange(Seeds.ScheduleItems);
            await context.SaveChangesAsync();
        }

    }
}
