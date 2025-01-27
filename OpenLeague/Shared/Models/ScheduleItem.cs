﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OpenLeague.Shared.Models
{
    public class ScheduleItem : BaseModel
    {
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        public string Title { get; set; }
        public string Format { get; set; }
    }
}
