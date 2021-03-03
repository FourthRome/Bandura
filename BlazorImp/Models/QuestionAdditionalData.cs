using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorImp.Models
{
    public class QuestionAdditionalData
    {
        public int QuestionAdditionalDataId { get; set; }
        public int? QuestionId { get; set; }
        public Question? Question { get; set; }
    }
}
