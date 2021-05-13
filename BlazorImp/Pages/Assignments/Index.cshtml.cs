using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BlazorImp.Data;
using BlazorImp.Models;

namespace BlazorImp.Pages.Assignments
{
    public class IndexModel : PageModel
    {
        private readonly BlazorImp.Data.BlazorImpContext _context;

        public IndexModel(BlazorImp.Data.BlazorImpContext context)
        {
            _context = context;
        }

        public IList<Assignment> Assignment { get;set; }

        public async Task OnGetAsync()
        {
            Assignment = await _context.Assignment
                .Include(a => a.Series)
                .Include(a => a.Type).ToListAsync();
        }
    }
}
