using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorImp.Models
{
    public class Page
    {
        public int PageID { get; set; }
        public int CourseID { get; set; }
        public int StepNumber { get; set; }
        public int FinalPageModelID { get; set; }
        public int InfoPageModelID { get; set; }
        public int SurveyPageModelID { get; set; }
        public int TaskPageModelID { get; set; }
        public int VideoPageModelID { get; set; }
    }
}
