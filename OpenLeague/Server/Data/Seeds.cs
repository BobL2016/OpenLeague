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
                    new Member { Id = 1, FirstName = "John", LastName = "Doe", GHIN = "2148925", HandicapIndex = 2.5M },
                    new Member { Id = 2, FirstName = "Jane", LastName = "Doe", GHIN = "8624764", HandicapIndex = 21.9M },
                    new Member { Id = 3, FirstName = "John", LastName = "Smith", GHIN = "2148925", HandicapIndex = 16.2M },
                    new Member { Id = 4, FirstName = "Jane", LastName = "Smith", GHIN = "6515897", HandicapIndex = 1.4M },
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
                    new ScheduleItem { Id = 1, Date = DateTime.Parse("4/24/2021 8:00 AM"), Title = "4 Man Scramble", Format = "" },
                    new ScheduleItem { Id = 2, Date = DateTime.Parse("5/15/2021 8:00 AM"), Title = "Yellow Ball Tournament", Format = "" },
                    new ScheduleItem { Id = 3, Date = DateTime.Parse("6/12/2021 8:00 AM"), Title = "President's Cup", Format = "Individual Low Net In Flights" },
                    new ScheduleItem { Id = 4, Date = DateTime.Parse("7/3/2021 8:00 AM"), Title = "Red, Gold, Black Tees", Format = "4 Man Low Net, Best 3 out of 4 scores" },
                    new ScheduleItem { Id = 5, Date = DateTime.Parse("7/10/2021 8:00 AM"), Title = "Qualifying Rounds for Club Championship", Format = "" },
                    new ScheduleItem { Id = 6, Date = DateTime.Parse("7/17/2021 8:00 AM"), Title = "Qualifying Rounds for Club Championship", Format = "" },
                    new ScheduleItem { Id = 7, Date = DateTime.Parse("7/24/2021 8:00 AM"), Title = "1st Round Club Championship", Format = "" },
                    new ScheduleItem { Id = 8, Date = DateTime.Parse("8/7/2021 8:00 AM"), Title = "Bergen Point Golf Club Memorial Tournament", Format = "2 Man Better Ball Pick You Partner" + Environment.NewLine + "Qualifying Round for the MET Tournement" },
                    new ScheduleItem { Id = 9, Date = DateTime.Parse("8/14/2021 8:00 AM"), Title = "2nd Round Club Championship", Format = "" },
                    new ScheduleItem { Id = 10, Date = DateTime.Parse("8/21/2021 8:00 AM"), Title = "Final Round Club Championship", Format = "" },
                    new ScheduleItem { Id = 11, Date = DateTime.Parse("9/4/2021 8:00 AM"), Title = "Ryder Cub Tournament", Format = "" },
                    new ScheduleItem { Id = 12, Date = DateTime.Parse("9/11/2021 8:00 AM"), Title = "Seagull Open - Best Two of Three Rounds", Format = "" },
                    new ScheduleItem { Id = 13, Date = DateTime.Parse("9/18/2021 8:00 AM"), Title = "Seagull Open - Best Two of Three Rounds", Format = "" },
                    new ScheduleItem { Id = 14, Date = DateTime.Parse("9/25/2021 8:00 AM"), Title = "Seagull Open - Best Two of Three Rounds", Format = "" },
                    new ScheduleItem { Id = 15, Date = DateTime.Parse("10/9/2021 8:00 AM"), Title = "5 Club Flag Tournament", Format = "" }
                };

                return scheduleItems;
            }
        }
    }
}
