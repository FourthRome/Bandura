using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorImp.Models
{
    public class QuestionAttempt
    {
        public int QuestionAttemptId { get; set; }

        public int? UserId { get; set; }
        public IdentityUser? User { get; set; }

        public int AttemptNumber { get; set; }

        public int? QuestionId { get; set; }
        public Question? Question { get; set; }

        public string? UserInput { get; set; }

        public double? Grade { get; set; }
    }
}
