using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorImp.Models
{
    public class Attempt
    {
        public int AttemptID { get; set; }

        public int ModuleID { get; set; }

        public int StepNumber { get; set; }

        public int UserID { get; set; }

        public int AttemptNumber { get; set; }

        public string UserAnswer { get; set; }

        public bool Correct { get; set; }
    }
}
