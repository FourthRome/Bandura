using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BlazorImp.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public int Id { get; set; }
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                Id = 0;
            } else
            {
                Id = (int) id;
            }

            return Page();
        }
    }
}
