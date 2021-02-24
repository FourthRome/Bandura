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
    public class DetailsModel : PageModel
    {
        private readonly BlazorImp.Data.BlazorImpContext _context;

        public DetailsModel(BlazorImp.Data.BlazorImpContext context)
        {
            _context = context;
        }

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
    }
}
