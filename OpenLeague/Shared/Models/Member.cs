using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenLeague.Shared.Models
{
    public class Member : BaseModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string GHIN { get; set; }
        public decimal HandicapIndex { get; set; }
    }
}
