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
    }
}
