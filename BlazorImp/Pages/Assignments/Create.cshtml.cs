using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using BlazorImp.Data;
using BlazorImp.Models;

namespace BlazorImp.Pages.Assignments
{
    public class CreateModel : PageModel
    {
        private readonly BlazorImp.Data.BlazorImpContext _context;

        public CreateModel(BlazorImp.Data.BlazorImpContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["AssignmentSeriesID"] = new SelectList(_context.AssignmentSeries, "ID", "ID");
        ViewData["TypeID"] = new SelectList(_context.AssignmentType, "ID", "ID");
            return Page();
        }

        [BindProperty]
        public Assignment Assignment { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Assignment.Add(Assignment);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
