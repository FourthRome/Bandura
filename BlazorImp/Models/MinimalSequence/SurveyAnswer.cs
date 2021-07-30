using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorImp.Models
{
    public class SurveyAnswer
    {
        public int SurveyAnswerID { get; set; }
        public int UserID { get; set; }
        public int CourseID { get; set; }
        public int SurveyPageModelID { get; set; }
        public string Answer { get; set; }
    }
}
