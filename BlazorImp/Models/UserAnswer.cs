using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorImp.Models
{
    public class UserAnswer
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public int AssignmentID { get; set; }
        public Assignment Assignment { get; set; }
        public string Solution { get; set; }
        public string Answer { get; set; }
        public bool Correctness { get; set; }
        public int AttemptNumber { get; set; }
        public int SolutionTime { get; set; }
    }
}
