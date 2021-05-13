using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorImp.Models
{
    public class Assignment
    {
        public int ID { get; set; }
        public int TypeID { get; set; }
        public AssignmentType Type { get; set; }
        public string RightAnswer { get; set; }
        public int AssignmentSeriesID { get; set; }
        public AssignmentSeries Series { get; set; }
    }
}
