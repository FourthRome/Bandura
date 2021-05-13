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
    public class DetailsModel : PageModel
    {
        private readonly BlazorImp.Data.BlazorImpContext _context;

        public DetailsModel(BlazorImp.Data.BlazorImpContext context)
        {
            _context = context;
        }

        public Assignment Assignment { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Assignment = await _context.Assignment
                .Include(a => a.Series)
                .Include(a => a.Type).FirstOrDefaultAsync(m => m.ID == id);

            if (Assignment == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
