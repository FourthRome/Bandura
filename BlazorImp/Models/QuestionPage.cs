using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorImp.Models
{
    public class QuestionPage
    {
        public int ID { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public string Context { get; set; }
    }
}
