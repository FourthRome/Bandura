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
        public DbSet<Assignment> Assignment { get; set; }
        public DbSet<AssignmentSeries> AssignmentSeries { get; set; }
        public DbSet<AssignmentType> AssignmentType { get; set; }
        public DbSet<Material> Material { get; set; }
        public DbSet<UserAnswer> UserAnswer { get; set; }
        public DbSet<Session> Session { get; set; }


        public BlazorImpContext (DbContextOptions<BlazorImpContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Assignment>().ToTable("Assignment");
            modelBuilder.Entity<AssignmentSeries>().ToTable("AssignmentSeries");
            modelBuilder.Entity<AssignmentType>().ToTable("AssignmentType");
            modelBuilder.Entity<Material>().ToTable("Material");
            modelBuilder.Entity<UserAnswer>().ToTable("UserAnswer");
            modelBuilder.Entity<Session>().ToTable("Session");
        }
    }
}
