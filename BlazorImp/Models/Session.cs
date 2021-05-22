using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorImp.Models
{
    public class Session
    {
        public int SessionID { get; set; }

        public int UserNumber { get; set; }

        public int CourseID { get; set; }

        public int CurrentPageID { get; set; }
    }
}
