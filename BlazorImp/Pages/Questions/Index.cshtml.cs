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
    public class IndexModel : PageModel
    {
        private readonly BlazorImp.Data.BlazorImpContext _context;

        public IndexModel(BlazorImp.Data.BlazorImpContext context)
        {
            _context = context;
        }

        public IList<QuestionPage> QuestionPage { get;set; }

        public async Task OnGetAsync()
        {
            QuestionPage = await _context.QuestionPage.ToListAsync();
        }
    }
}
