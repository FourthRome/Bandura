using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BlazorImp.Data;
using BlazorImp.Models;

namespace BlazorImp.Pages.Assignments
{
    public class EditModel : PageModel
    {
        private readonly BlazorImp.Data.BlazorImpContext _context;

        public EditModel(BlazorImp.Data.BlazorImpContext context)
        {
            _context = context;
        }

        [BindProperty]
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
           ViewData["AssignmentSeriesID"] = new SelectList(_context.AssignmentSeries, "ID", "ID");
           ViewData["TypeID"] = new SelectList(_context.AssignmentType, "ID", "ID");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Assignment).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AssignmentExists(Assignment.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool AssignmentExists(int id)
        {
            return _context.Assignment.Any(e => e.ID == id);
        }
    }
}
