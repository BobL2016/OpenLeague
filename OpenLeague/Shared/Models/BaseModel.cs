using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenLeague.Shared.Models
{
    public abstract partial class BaseModel : IBaseModel
    {
        public int Id { get; set; }
        public DateTimeOffset Created { get; set; }
        public DateTimeOffset? Updated { get; set; }
        public DateTimeOffset? Deleted { get; set; }
    }
}
