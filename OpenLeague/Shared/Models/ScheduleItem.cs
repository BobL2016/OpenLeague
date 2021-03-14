using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenLeague.Shared.Models
{
    public class ScheduleItem : BaseModel
    {
        public DateTime Date { get; set; }
        public string Title { get; set; }
        public string Format { get; set; }
    }
}
