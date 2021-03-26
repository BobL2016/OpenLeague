using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OpenLeague.Shared.Models
{
    public class Member : BaseModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string GHIN { get; set; }

        [Column(TypeName = "decimal(4,1)")]
        public decimal HandicapIndex { get; set; }
    }
}
