using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenLeague.Shared.Models
{
    public abstract partial class BaseModel : IBaseModel
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [DataType(DataType.Date)]
        public DateTimeOffset Created { get; set; }

        [DataType(DataType.Date)]
        public DateTimeOffset? Updated { get; set; }

        [DataType(DataType.Date)]
        public DateTimeOffset? Deleted { get; set; }
    }
}
