using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorImp.Models
{
    public class SurveyPageModel
    {
        public int SurveyPageModelID { get; set; }
        public string Header { get; set; }
        public string MainText { get; set; }
        public string Question { get; set; }
    }
}
