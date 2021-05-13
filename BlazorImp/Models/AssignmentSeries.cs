using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorImp.Models
{
    public class AssignmentSeries
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int AssignmentAmount { get; set; }
        public int MaxAttempts { get; set; }
    }
}
