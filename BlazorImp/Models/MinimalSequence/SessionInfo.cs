using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorImp.Models
{
    // This class duplicates UserLastPage class functionality
    // But it still looks like it's needed
    public class SessionInfo
    {
        public int CourseID { get; set; }
        public int? UserID { get; set; }
        public int StepNumber { get; set; }
    }
}
