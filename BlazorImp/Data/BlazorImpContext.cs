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
        public BlazorImpContext (DbContextOptions<BlazorImpContext> options)
            : base(options)
        {
        }

        public DbSet<BlazorImp.Models.QuestionPage> QuestionPage { get; set; }
    }
}
