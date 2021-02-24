using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OpenLeague.Shared.Models;

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

            var members = new Member[]
            {
                new Member { FirstName = "John", LastName = "Doe", GHIN = "2148925", HandicapIndex = 2.5M },
                new Member { FirstName = "Jane", LastName = "Doe", GHIN = "8624764", HandicapIndex = 21.9M },
                new Member { FirstName = "John", LastName = "Smith", GHIN = "2148925", HandicapIndex = 16.2M },
                new Member { FirstName = "Jane", LastName = "Smith", GHIN = "6515897", HandicapIndex = 1.4M },
            };

            context.Members.AddRange(members);
            context.SaveChanges();
        }
    }
}
