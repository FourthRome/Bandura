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
        public int TaskPageModelID { get; set; }
        public int AttemptNumber { get; set; }
        public string UserAnswer { get; set; }
        public string UserComment { get; set; }
        public bool Correct { get; set; }
    }
}
