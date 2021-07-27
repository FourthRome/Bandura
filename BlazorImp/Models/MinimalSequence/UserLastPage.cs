using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorImp.Models
{
    public class UserLastPage
    {
        public int UserLastPageID { get; set; }
        public int UserID { get; set; }
        public int CourseID { get; set; }
        public int StepNumber { get; set; }
    }
}
