using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorImp.Models
{
    public class QuizDetails
    {
        public int? QuestionId { get; set; }
        public Question? Question { get; set; }
    }
}
