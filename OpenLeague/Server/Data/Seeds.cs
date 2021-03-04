using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OpenLeague.Shared.Models;

namespace OpenLeague.Server.Data
{
    public static class Seeds
    {

        public static Member[] Members 
        { 
            get
            {
                var members = new Member[]
                {
                    new Member { ID=1, FirstName = "John", LastName = "Doe", GHIN = "2148925", HandicapIndex = 2.5M },
                    new Member { ID=2, FirstName = "Jane", LastName = "Doe", GHIN = "8624764", HandicapIndex = 21.9M },
                    new Member { ID=3, FirstName = "John", LastName = "Smith", GHIN = "2148925", HandicapIndex = 16.2M },
                    new Member { ID=4, FirstName = "Jane", LastName = "Smith", GHIN = "6515897", HandicapIndex = 1.4M },
                };

                return members;
            }
        }

        public static ScheduleItem[] ScheduleItems
        {
            get
            {
                var scheduleItems = new ScheduleItem[]
                {
                    new ScheduleItem { ID = 1, Date = DateTime.Parse("4/4/2021 7:30 AM"), Title = "Opening Day", Format = "Two Man Best Ball" },
                    new ScheduleItem { ID = 2, Date = DateTime.Parse("4/11/2021 7:45 AM"), Title = "League Play", Format = "Two Man Best Ball" },
                    new ScheduleItem { ID = 3, Date = DateTime.Parse("4/18/2021 8:00 AM"), Title = "League Play", Format = "Two Man Best Ball" },
                    new ScheduleItem { ID = 4, Date = DateTime.Parse("4/25/2021 8:15 AM"), Title = "Tourney", Format = "Four Man Scramble" }
                };

                return scheduleItems;
            }
        }
    }
}
