using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Assingment_2_MIST_353_001.Data;
using GeoSnowAPI.Entities;

namespace Assingment_2_MIST_353_001.Pages.ResortCRUD
{
    public class CreateModel : PageModel
    {
        private readonly Assingment_2_MIST_353_001.Data.DbContextClass _context;

        public CreateModel(Assingment_2_MIST_353_001.Data.DbContextClass context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Resort Resort { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.RESORT.Add(Resort);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
