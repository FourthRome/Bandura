using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BlazorImp.Data;
using BlazorImp.Models;

namespace BlazorImp.Pages.Questions
{
    public class DeleteModel : PageModel
    {
        private readonly BlazorImp.Data.BlazorImpContext _context;

        public DeleteModel(BlazorImp.Data.BlazorImpContext context)
        {
            _context = context;
        }

        [BindProperty]
        public QuestionPage QuestionPage { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            QuestionPage = await _context.QuestionPage.FirstOrDefaultAsync(m => m.ID == id);

            if (QuestionPage == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            QuestionPage = await _context.QuestionPage.FindAsync(id);

            if (QuestionPage != null)
            {
                _context.QuestionPage.Remove(QuestionPage);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
