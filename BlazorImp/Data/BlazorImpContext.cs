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
        public DbSet<Question> Question { get; set; }

        public DbSet<QuestionAdditionalData> QuestionAdditionalData { get; set; }

        public DbSet<RightAnswer> RightAnswer { get; set; }

        public DbSet<QuestionAttempt> QuestionAttempt{ get; set; }

        public DbSet<QuizData> QuizData{ get; set; }

        public DbSet<UserAction> UserActions { get; set; }

        public BlazorImpContext (DbContextOptions<BlazorImpContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Question>().ToTable("Questions");
            modelBuilder.Entity<QuestionAdditionalData>().ToTable("QuestionAdditionalDatas");
            modelBuilder.Entity<RightAnswer>().ToTable("RightAnswers");
            modelBuilder.Entity<QuestionAttempt>().ToTable("QuestionAttempts");
            modelBuilder.Entity<QuizData>().ToTable("QuizDatas");
            modelBuilder.Entity<UserAction>().ToTable("UserActions");
        }
    }
}
