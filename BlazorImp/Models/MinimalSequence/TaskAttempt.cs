using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorImp.Models
{
    public class TaskAttempt
    {
        public int TaskAttemptID { get; set; }
        public int UserID { get; set; }
        public int CourseID { get; set; }
        public int TaskPageID { get; set; }
        public int AttemptNumber { get; set; }
        public string Answer { get; set; }
        public bool Correct { get; set; }
    }
}
