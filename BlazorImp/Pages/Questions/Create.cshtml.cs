using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using BlazorImp.Data;
using BlazorImp.Models;

namespace BlazorImp.Pages.Questions
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
            return Page();
        }

        [BindProperty]
        public QuestionPage QuestionPage { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.QuestionPage.Add(QuestionPage);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
