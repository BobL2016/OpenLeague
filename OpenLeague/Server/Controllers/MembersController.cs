using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OpenLeague.Shared.Models;

namespace OpenLeague.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MembersController : Controller
    {
        [HttpGet]
        public IEnumerable<Member> Get()
        {
            List<Member> members = new List<Member>();

            members.Add(new Member { ID = 1, FirstName = "John", LastName = "Doe", GHIN = "0000000", HandicapIndex = 10.3M});
            members.Add(new Member { ID = 2, FirstName = "Jane", LastName = "Doe", GHIN = "1111111", HandicapIndex = 4.8M });
            members.Add(new Member { ID = 3, FirstName = "John", LastName = "Smith", GHIN = "2222222", HandicapIndex = 2.5M });
            members.Add(new Member { ID = 4, FirstName = "Jane", LastName = "Smith", GHIN = "3333333", HandicapIndex = 19.1M });

            return members;
        }
    }
}
