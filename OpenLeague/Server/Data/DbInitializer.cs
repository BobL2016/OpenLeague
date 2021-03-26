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
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            if (context.Members.Any())
            {
                return;
            }

            context.Members.AddRange(Seeds.Members.Select(member => new Member { FirstName = member.FirstName, LastName = member.LastName, GHIN = member.GHIN, HandicapIndex = member.HandicapIndex }).ToArray());
            context.SaveChanges();

            context.ScheduleItems.AddRange(Seeds.ScheduleItems.Select(scheduleItem => new ScheduleItem { Date = scheduleItem.Date, Title = scheduleItem.Title, Format = scheduleItem.Format }).ToArray());
            context.SaveChanges();
        }

    }
}
