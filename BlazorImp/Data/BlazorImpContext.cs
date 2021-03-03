using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BlazorImp.Models;

namespace BlazorImp.Data
{
    public class BlazorImpContext : DbContext
    {
        public DbSet<Question>? QuestionsEntity { get; set; }

        public DbSet<QuestionAdditionalData>? QuestionAdditionalDataEntity { get; set; }
        public DbSet<RightAnswer>? RightAnswersEntity { get; set; }

        public DbSet<QuestionAttempt>? QuestionAttemptsEntity { get; set; }

        public DbSet<QuizDetails>? QuizDetailsEntity { get; set; }

        public DbSet<UserAction>? UserActionsEntity { get; set; }

        public BlazorImpContext (DbContextOptions<BlazorImpContext> options) : base(options)
        {
        }
    }
}
