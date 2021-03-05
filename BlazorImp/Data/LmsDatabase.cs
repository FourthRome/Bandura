using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorImp.Data
{
    public class LmsDatabase : ILmsDatabase
    {
        private readonly BlazorImpContext dbContext;

        public LmsDatabase()
        {
        }

        public LmsDatabase(BlazorImpContext context)
        {
            dbContext = context;
        }

    }
}
