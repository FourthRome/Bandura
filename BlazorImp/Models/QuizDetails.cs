using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorImp.Models
{
    public class QuizDetails
    {
        public int QuizDetailsId { get; set; }
        public int? QuestionId { get; set; }
        public Question? Question { get; set; }
    }
}
