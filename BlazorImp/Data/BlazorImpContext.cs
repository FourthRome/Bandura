using Microsoft.EntityFrameworkCore;
using BlazorImp.Models;

namespace BlazorImp.Data
{
    public class BlazorImpContext : DbContext
    {
        //public DbSet<Assignment> Assignment { get; set; }
        //public DbSet<AssignmentSeries> AssignmentSeries { get; set; }
        //public DbSet<AssignmentType> AssignmentType { get; set; }
        //public DbSet<Material> Material { get; set; }
        //public DbSet<UserAnswer> UserAnswer { get; set; }
        //public DbSet<Session> Session { get; set; }
        //public DbSet<Content> Content { get; set; }
        //public DbSet<Module> Module { get; set; }
        //public DbSet<Attempt> Attempt { get; set; }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Page> Pages { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserLastPage> UserLastPages { get; set; }
        public DbSet<SurveyAnswer> SurveyAnswers { get; set; }
        public DbSet<TaskAttempt> TaskAttempts { get; set; }
        public DbSet<SurveyPageModel> SurveyPageModels { get; set; }
        public DbSet<InfoPageModel> InfoPageModels { get; set; }
        public DbSet<VideoPageModel> VideoPageModels { get; set; }
        public DbSet<TaskPageModel> TaskPageModels { get; set; }
        public DbSet<FinalPageModel> FinalPageModels { get; set; }
        public DbSet<CourseMembership> CourseMemberships { get; set; }


        public BlazorImpContext (DbContextOptions<BlazorImpContext> options) : base(options)
        {
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Assignment>().ToTable("Assignment");
            //modelBuilder.Entity<AssignmentSeries>().ToTable("AssignmentSeries");
            //modelBuilder.Entity<AssignmentType>().ToTable("AssignmentType");
            //modelBuilder.Entity<Material>().ToTable("Material");
            //modelBuilder.Entity<UserAnswer>().ToTable("UserAnswer");
            //modelBuilder.Entity<Session>().ToTable("Session");
            //modelBuilder.Entity<Content>().ToTable("Content");
            //modelBuilder.Entity<Module>().ToTable("Module");
            //modelBuilder.Entity<Attempt>().ToTable("Attempt");

            modelBuilder.Entity<Course>().ToTable("Courses");
            modelBuilder.Entity<Page>().ToTable("Pages");
            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<UserLastPage>().ToTable("UserLastPages");
            modelBuilder.Entity<SurveyAnswer>().ToTable("SurveyAnswers");
            modelBuilder.Entity<TaskAttempt>().ToTable("TaskAttempts");
            modelBuilder.Entity<SurveyPageModel>().ToTable("SurveyPageModels");
            modelBuilder.Entity<InfoPageModel>().ToTable("InfoPageModels");
            modelBuilder.Entity<VideoPageModel>().ToTable("VideoPageModels");
            modelBuilder.Entity<TaskPageModel>().ToTable("TaskPageModels");
            modelBuilder.Entity<FinalPageModel>().ToTable("FinalPageModels");
            modelBuilder.Entity<CourseMembership>().ToTable("CourseMemberships");
        }
    }
}
